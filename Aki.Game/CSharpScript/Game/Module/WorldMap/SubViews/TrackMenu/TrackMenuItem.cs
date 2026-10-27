using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu
{
	// Token: 0x020047E8 RID: 18408
	public class TrackMenuItem : UiPanelBase
	{
		// Token: 0x06030372 RID: 197490 RVA: 0x00B2CAE0 File Offset: 0x00B2ACE0
		[NullableContext(1)]
		public UniTask Init(UUIItem uiItem, ITrackMenuItemData trackData)
		{
			TrackMenuItem.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.uiItem = uiItem;
			<Init>d__.trackData = trackData;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrackMenuItem.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06030373 RID: 197491 RVA: 0x00B2CB34 File Offset: 0x00B2AD34
		protected override void OnStart()
		{
			UUIItem uiitem = (base.GetExtendToggle(0).GetOwner() as AUIBaseActor).GetUIItem();
			this.LevelSequencePlayer = new LevelSequencePlayer(uiitem);
		}

		// Token: 0x06030374 RID: 197492 RVA: 0x00B2CB64 File Offset: 0x00B2AD64
		protected override void OnBeforeShow()
		{
			this.PlayAppearSequence();
		}

		// Token: 0x06030375 RID: 197493 RVA: 0x00B2CB6C File Offset: 0x00B2AD6C
		protected override void OnAfterShow()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			FOnToggleStateChange onStateChange = extendToggle.OnStateChange;
			if (onStateChange == null)
			{
				return;
			}
			onStateChange.Add(new Action<EToggleState>(this.OnClick));
		}

		// Token: 0x06030376 RID: 197494 RVA: 0x00B2CB98 File Offset: 0x00B2AD98
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06030377 RID: 197495 RVA: 0x00B2CC22 File Offset: 0x00B2AE22
		public void OnClick(EToggleState state)
		{
			if (EToggleState.ETT_Checked == state)
			{
				this.PlayReleaseSequence().ContinueWith(delegate()
				{
					EventSystem instance = EventSystem.Instance;
					if (instance == null)
					{
						return;
					}
					instance.Emit<ITrackMenuItemData>(EEventName.TrackMenuClickItem, this.TrackData);
				});
			}
		}

		// Token: 0x06030378 RID: 197496 RVA: 0x00B2CC40 File Offset: 0x00B2AE40
		private void SetUp()
		{
			this.SetSpriteByPath(this.TrackData.Icon, base.GetSprite(1), false, null, null);
			if (this.TrackData.MarkItem != null)
			{
				this.TrackData.MarkItem.SetTitleText(base.GetText(2));
				return;
			}
			if (this.TrackData.Title != null)
			{
				UUIText text = base.GetText(2);
				if (text == null)
				{
					return;
				}
				text.SetText(this.TrackData.Title, true);
			}
		}

		// Token: 0x06030379 RID: 197497 RVA: 0x00B2CCC0 File Offset: 0x00B2AEC0
		protected override UniTask OnBeforeHideAsync()
		{
			TrackMenuItem.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<TrackMenuItem.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603037A RID: 197498 RVA: 0x00B2CD03 File Offset: 0x00B2AF03
		protected override void OnBeforeDestroy()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				FOnToggleStateChange onStateChange = extendToggle.OnStateChange;
				if (onStateChange != null)
				{
					onStateChange.Clear();
				}
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603037B RID: 197499 RVA: 0x00B2CD3C File Offset: 0x00B2AF3C
		public UniTask PlayReleaseSequence()
		{
			TrackMenuItem.<PlayReleaseSequence>d__12 <PlayReleaseSequence>d__;
			<PlayReleaseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReleaseSequence>d__.<>4__this = this;
			<PlayReleaseSequence>d__.<>1__state = -1;
			<PlayReleaseSequence>d__.<>t__builder.Start<TrackMenuItem.<PlayReleaseSequence>d__12>(ref <PlayReleaseSequence>d__);
			return <PlayReleaseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603037C RID: 197500 RVA: 0x00B2CD80 File Offset: 0x00B2AF80
		public void PlayAppearSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603037D RID: 197501 RVA: 0x00B2CDB0 File Offset: 0x00B2AFB0
		public UniTask PlayDisappearSequence()
		{
			TrackMenuItem.<PlayDisappearSequence>d__14 <PlayDisappearSequence>d__;
			<PlayDisappearSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDisappearSequence>d__.<>4__this = this;
			<PlayDisappearSequence>d__.<>1__state = -1;
			<PlayDisappearSequence>d__.<>t__builder.Start<TrackMenuItem.<PlayDisappearSequence>d__14>(ref <PlayDisappearSequence>d__);
			return <PlayDisappearSequence>d__.<>t__builder.Task;
		}

		// Token: 0x04019F64 RID: 106340
		[Nullable(2)]
		private ITrackMenuItemData TrackData;

		// Token: 0x04019F65 RID: 106341
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200AAA7 RID: 43687
		public static class EComponents
		{
			// Token: 0x04033EA8 RID: 212648
			public const int Toggle = 0;

			// Token: 0x04033EA9 RID: 212649
			public const int Icon = 1;

			// Token: 0x04033EAA RID: 212650
			public const int Info = 2;
		}
	}
}
