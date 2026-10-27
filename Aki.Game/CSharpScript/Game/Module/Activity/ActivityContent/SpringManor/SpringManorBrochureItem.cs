using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02006062 RID: 24674
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SpringManorBrochureItem : GridProxyAbstract<BrochureItemData>
	{
		// Token: 0x0603E6A2 RID: 255650 RVA: 0x00F137B8 File Offset: 0x00F119B8
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

		// Token: 0x0603E6A3 RID: 255651 RVA: 0x00F1388F File Offset: 0x00F11A8F
		protected override void OnStart()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
			}
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E6A4 RID: 255652 RVA: 0x00F138C4 File Offset: 0x00F11AC4
		[NullableContext(1)]
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Brochure_Unlock" && this.Data != null)
			{
				this.Refresh(this.Data, false, 0);
			}
		}

		// Token: 0x0603E6A5 RID: 255653 RVA: 0x00F138E9 File Offset: 0x00F11AE9
		private void OnClick()
		{
			if (this.OnToggleCallBack != null)
			{
				this.OnToggleCallBack(this.Data);
			}
		}

		// Token: 0x0603E6A6 RID: 255654 RVA: 0x00F13904 File Offset: 0x00F11B04
		private void OnClickGetButton()
		{
			if (this.OnClickGetButtonCallBack != null)
			{
				this.OnClickGetButtonCallBack(this.Data);
			}
		}

		// Token: 0x0603E6A7 RID: 255655 RVA: 0x00F1391F File Offset: 0x00F11B1F
		public void SetToggleCallBack([Nullable(new byte[]
		{
			1,
			2
		})] Action<BrochureItemData> callBack)
		{
			this.OnToggleCallBack = callBack;
		}

		// Token: 0x0603E6A8 RID: 255656 RVA: 0x00F13928 File Offset: 0x00F11B28
		public void SetClickGetButtonCallBack([Nullable(new byte[]
		{
			1,
			2
		})] Action<BrochureItemData> callBack)
		{
			this.OnClickGetButtonCallBack = callBack;
		}

		// Token: 0x0603E6A9 RID: 255657 RVA: 0x00F13934 File Offset: 0x00F11B34
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

		// Token: 0x0603E6AA RID: 255658 RVA: 0x00F13B28 File Offset: 0x00F11D28
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

		// Token: 0x0603E6AB RID: 255659 RVA: 0x00F13B70 File Offset: 0x00F11D70
		private bool IsNeedPlayUnlockSequence(int configId)
		{
			HashSet<int> player = LocalStorage.GetPlayer<HashSet<int>>(ELocalStoragePlayerKey.SpringManorBrochureUnlockSequencePlayed, null);
			return player == null || !player.Contains(configId);
		}

		// Token: 0x0603E6AC RID: 255660 RVA: 0x00F13B98 File Offset: 0x00F11D98
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

		// Token: 0x040209E3 RID: 133603
		private Action<BrochureItemData> OnToggleCallBack;

		// Token: 0x040209E4 RID: 133604
		private Action<BrochureItemData> OnClickGetButtonCallBack;

		// Token: 0x040209E5 RID: 133605
		private BrochureItemData Data;

		// Token: 0x040209E6 RID: 133606
		private UUITextureTransitionComponent TextureTransitionComp;

		// Token: 0x040209E7 RID: 133607
		private LevelSequencePlayer SequencePlayer;
	}
}
