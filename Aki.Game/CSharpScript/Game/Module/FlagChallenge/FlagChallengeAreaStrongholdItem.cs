using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A2A RID: 18986
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeAreaStrongholdItem : UiPanelBase
	{
		// Token: 0x0602F92F RID: 194863 RVA: 0x00D446F8 File Offset: 0x00D428F8
		public FlagChallengeAreaStrongholdItem(FlagChallengeStrongholdData data)
		{
			this.Data = data;
		}

		// Token: 0x0602F930 RID: 194864 RVA: 0x00D44750 File Offset: 0x00D42950
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUITexture)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUISprite)),
				new ValueTuple<int, Type>(8, typeof(UUISprite)),
				new ValueTuple<int, Type>(9, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
			};
		}

		// Token: 0x0602F931 RID: 194865 RVA: 0x00D44868 File Offset: 0x00D42A68
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.PlaySequencePurely("Start", false, false);
			base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
			int challengeLevelId = this.Data.StrongholdConfig.ChallengeLevelId;
			FlagChallengeLevel? levelConfig = FlagChallengeConfig.Instance.GetLevelConfig(challengeLevelId);
			EFlagChallengeStrongholdType strongholdType = this.Data.GetStrongholdType();
			bool flag = this.Data.IsUnlocked();
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(1);
			UUITexture texture3 = base.GetTexture(3);
			UUISprite sprite = base.GetSprite(7);
			UUISprite sprite2 = base.GetSprite(8);
			UUITexture texture4 = base.GetTexture(4);
			base.GetText(5).SetText(this.Data.GetIndex().ToString(), true);
			if (flag)
			{
				EFlagChallengeUiStyleType uiStyle = (EFlagChallengeUiStyleType)levelConfig.Value.UiStyle;
				UiResourceConfig instance = UiResourceConfig.Instance;
				bool isPass = this.Data.IsPass;
				texture.SetUIActive(!isPass);
				texture3.SetUIActive(isPass);
				texture2.SetUIActive(false);
				string dynamicRes = FlagChallengeUtils.GetDynamicRes(uiStyle, "StrongholdItemIncompleteBg", (int)strongholdType);
				base.SetTextureByPath(instance.GetResourcePath(dynamicRes), texture, null, null);
				dynamicRes = FlagChallengeUtils.GetDynamicRes(uiStyle, "StrongholdItemCompleteBg", (int)strongholdType);
				base.SetTextureByPath(instance.GetResourcePath(dynamicRes), texture3, null, null);
				string baseKey = isPass ? "StrongholdItemCompleteIcon" : "StrongholdItemIncompleteIcon";
				dynamicRes = FlagChallengeUtils.GetDynamicRes(uiStyle, baseKey, (int)strongholdType);
				base.SetTextureByPath(instance.GetResourcePath(dynamicRes), texture4, null, null);
				sprite.SetUIActive(this.Data.IsPass);
				sprite2.SetUIActive(!this.Data.IsPass);
				if (this.Data.IsBossStronghold())
				{
					UUITexture texture5 = base.GetTexture(9);
					if (texture5 != null)
					{
						texture5.SetUIActive(true);
					}
					if (texture5 == null)
					{
						return;
					}
					texture5.SetColor(FColor.FromHex(this.rollTexColor[uiStyle]));
					return;
				}
			}
			else
			{
				texture.SetUIActive(false);
				texture3.SetUIActive(false);
				texture2.SetUIActive(true);
				sprite.SetUIActive(false);
				sprite2.SetUIActive(false);
				texture4.SetUIActive(false);
				if (this.Data.IsBossStronghold())
				{
					UUITexture texture6 = base.GetTexture(9);
					if (texture6 == null)
					{
						return;
					}
					texture6.SetUIActive(false);
				}
			}
		}

		// Token: 0x0602F932 RID: 194866 RVA: 0x00D44ACD File Offset: 0x00D42CCD
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0602F933 RID: 194867 RVA: 0x00D44AE7 File Offset: 0x00D42CE7
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x0602F934 RID: 194868 RVA: 0x00D44AF0 File Offset: 0x00D42CF0
		public void SetSelected(bool isSelected, bool bFireEvent = false)
		{
			EToggleState state = isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, bFireEvent, false, false);
			base.GetItem(6).SetUIActive(isSelected);
			this.IsSelected = isSelected;
		}

		// Token: 0x0602F935 RID: 194869 RVA: 0x00D44B29 File Offset: 0x00D42D29
		private void OnClickToggle(EToggleState state)
		{
			this.SetSelected(true, false);
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data.Id);
		}

		// Token: 0x0602F936 RID: 194870 RVA: 0x00D44B4E File Offset: 0x00D42D4E
		private bool OnCanExecuteChange()
		{
			return !this.IsSelected;
		}

		// Token: 0x0602F937 RID: 194871 RVA: 0x00D44B59 File Offset: 0x00D42D59
		public bool GetIsBoss()
		{
			return this.Data.IsBossStronghold();
		}

		// Token: 0x04019370 RID: 103280
		private readonly Dictionary<EFlagChallengeUiStyleType, string> rollTexColor = new Dictionary<EFlagChallengeUiStyleType, string>
		{
			{
				EFlagChallengeUiStyleType.Green,
				"#CCFF00"
			},
			{
				EFlagChallengeUiStyleType.Yellow,
				"#FF7200"
			},
			{
				EFlagChallengeUiStyleType.Red,
				"#FF0042"
			},
			{
				EFlagChallengeUiStyleType.Hidden,
				"#FF0042"
			}
		};

		// Token: 0x04019371 RID: 103281
		private readonly FlagChallengeStrongholdData Data;

		// Token: 0x04019372 RID: 103282
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x04019373 RID: 103283
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04019374 RID: 103284
		private bool IsSelected;
	}
}
