using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FE0 RID: 20448
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorBrochureItem : GridProxyAbstract<BrochureItemData>
	{
		// Token: 0x06033366 RID: 209766 RVA: 0x00E5A57C File Offset: 0x00E5877C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickGetButton))
			};
		}

		// Token: 0x06033367 RID: 209767 RVA: 0x00E5A653 File Offset: 0x00E58853
		protected override void OnStart()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
			}
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06033368 RID: 209768 RVA: 0x00E5A688 File Offset: 0x00E58888
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Brochure_Unlock" && this.Data != null)
			{
				this.Refresh(this.Data, false, 0);
			}
		}

		// Token: 0x06033369 RID: 209769 RVA: 0x00E5A6AD File Offset: 0x00E588AD
		private void OnClick()
		{
			if (this.OnToggleCallBack != null)
			{
				this.OnToggleCallBack(this.Data);
			}
		}

		// Token: 0x0603336A RID: 209770 RVA: 0x00E5A6C8 File Offset: 0x00E588C8
		private void OnClickGetButton()
		{
			if (this.OnClickGetButtonCallBack != null)
			{
				this.OnClickGetButtonCallBack(this.Data);
			}
		}

		// Token: 0x0603336B RID: 209771 RVA: 0x00E5A6E3 File Offset: 0x00E588E3
		public void SetToggleCallBack([Nullable(new byte[]
		{
			1,
			2
		})] Action<BrochureItemData> callBack)
		{
			this.OnToggleCallBack = callBack;
		}

		// Token: 0x0603336C RID: 209772 RVA: 0x00E5A6EC File Offset: 0x00E588EC
		public void SetClickGetButtonCallBack([Nullable(new byte[]
		{
			1,
			2
		})] Action<BrochureItemData> callBack)
		{
			this.OnClickGetButtonCallBack = callBack;
		}

		// Token: 0x0603336D RID: 209773 RVA: 0x00E5A6F8 File Offset: 0x00E588F8
		[NullableContext(1)]
		public override void Refresh(BrochureItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			EBrochureState ebrochureState = data.State;
			if (ebrochureState == EBrochureState.Unlock && this.IsNeedPlayUnlockSequence(this.Data.ConfigId))
			{
				ebrochureState = EBrochureState.Lock;
			}
			SpringManorConfig instance = SpringManorConfig.Instance;
			BookItem? bookItem = (instance != null) ? instance.GetSpringManorBookItemById(data.ConfigId) : null;
			if (bookItem == null)
			{
				return;
			}
			bool flag = ebrochureState == EBrochureState.Lock;
			string path = flag ? bookItem.Value.LockIcon : bookItem.Value.UnlockIcon;
			base.TrySetTextureByPath(path, base.GetTexture(1), null, null);
			if (this.TextureTransitionComp == null)
			{
				this.TextureTransitionComp = (base.GetTexture(1).GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent);
			}
			base.SetTextureTransitionByPath(path, this.TextureTransitionComp, EUISelectableSelectionState.EUISelectableSelectionState_MAX);
			UUIItem item = base.GetItem(2);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				UUIItem uuiitem = button.RootUIComp.Get();
				if (uuiitem != null)
				{
					uuiitem.SetUIActive(ebrochureState == EBrochureState.Unlock);
				}
			}
			if (flag)
			{
				bool flag2 = !string.IsNullOrEmpty(bookItem.Value.GuideTitle);
				UUIText text = base.GetText(5);
				if (text != null)
				{
					text.ShowTextNew(flag2 ? bookItem.Value.GuideTitle : bookItem.Value.DescriptionTitle);
				}
			}
			else
			{
				UUIText text2 = base.GetText(5);
				if (text2 != null)
				{
					text2.ShowTextNew(bookItem.Value.DescriptionTitle);
				}
			}
			UiResourceConfig instance2 = UiResourceConfig.Instance;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
			defaultInterpolatedStringHandler.AppendLiteral("SP_BrochureSort0");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Index + 1);
			string resourcePath = instance2.GetResourcePath(defaultInterpolatedStringHandler.ToStringAndClear());
			this.SetSpriteByPath(resourcePath, base.GetSprite(4), false, null, null);
			this.PlayRewardSequence(ebrochureState == EBrochureState.Unlock);
		}

		// Token: 0x0603336E RID: 209774 RVA: 0x00E5A8EC File Offset: 0x00E58AEC
		private void PlayRewardSequence(bool isPlay)
		{
			if (isPlay)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlayLevelSequenceByName("Gift_Loop", false, null, false);
				return;
			}
			else
			{
				LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
				if (sequencePlayer2 == null)
				{
					return;
				}
				sequencePlayer2.StopSequenceByKey("Gift_Loop", false, false);
				return;
			}
		}

		// Token: 0x0603336F RID: 209775 RVA: 0x00E5A934 File Offset: 0x00E58B34
		private bool IsNeedPlayUnlockSequence(int configId)
		{
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.SpringManorBrochureUnlockSequencePlayed, null);
			return player == null || !player.Contains(configId);
		}

		// Token: 0x06033370 RID: 209776 RVA: 0x00E5A95C File Offset: 0x00E58B5C
		public void CheckPlayUnlockSequence()
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.State == EBrochureState.Unlock)
			{
				HashSet<int> hashSet = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.SpringManorBrochureUnlockSequencePlayed, null) ?? new HashSet<int>();
				if (!hashSet.Contains(this.Data.ConfigId))
				{
					hashSet.Add(this.Data.ConfigId);
					LocalStorage.SetPlayer<HashSet<int>>(ELocalStoragePlayerKey.SpringManorBrochureUnlockSequencePlayed, hashSet);
					LevelSequencePlayer sequencePlayer = this.SequencePlayer;
					if (sequencePlayer == null)
					{
						return;
					}
					sequencePlayer.PlayLevelSequenceByName("Unlock", false, null, false);
				}
			}
		}

		// Token: 0x0401B310 RID: 111376
		private Action<BrochureItemData> OnToggleCallBack;

		// Token: 0x0401B311 RID: 111377
		private Action<BrochureItemData> OnClickGetButtonCallBack;

		// Token: 0x0401B312 RID: 111378
		private BrochureItemData Data;

		// Token: 0x0401B313 RID: 111379
		private UUITextureTransitionComponent TextureTransitionComp;

		// Token: 0x0401B314 RID: 111380
		private LevelSequencePlayer SequencePlayer;
	}
}
