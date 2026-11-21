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
	// Token: 0x02003719 RID: 14105
	public class TrackMenuItem : UiPanelBase
	{
		// Token: 0x06024B42 RID: 150338 RVA: 0x00A5CA24 File Offset: 0x00A5AC24
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

		// Token: 0x06024B43 RID: 150339 RVA: 0x00A5CA78 File Offset: 0x00A5AC78
		protected override void OnStart()
		{
			UUIItem uiitem = (base.GetExtendToggle(0).GetOwner() as AUIBaseActor).GetUIItem();
			this.LevelSequencePlayer = new LevelSequencePlayer(uiitem);
		}

		// Token: 0x06024B44 RID: 150340 RVA: 0x00A5CAA8 File Offset: 0x00A5ACA8
		protected override void OnBeforeShow()
		{
			this.PlayAppearSequence();
		}

		// Token: 0x06024B45 RID: 150341 RVA: 0x00A5CAB0 File Offset: 0x00A5ACB0
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

		// Token: 0x06024B46 RID: 150342 RVA: 0x00A5CADC File Offset: 0x00A5ACDC
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

		// Token: 0x06024B47 RID: 150343 RVA: 0x00A5CB66 File Offset: 0x00A5AD66
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

		// Token: 0x06024B48 RID: 150344 RVA: 0x00A5CB84 File Offset: 0x00A5AD84
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

		// Token: 0x06024B49 RID: 150345 RVA: 0x00A5CC04 File Offset: 0x00A5AE04
		protected override UniTask OnBeforeHideAsync()
		{
			TrackMenuItem.<OnBeforeHideAsync>d__10 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<TrackMenuItem.<OnBeforeHideAsync>d__10>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024B4A RID: 150346 RVA: 0x00A5CC47 File Offset: 0x00A5AE47
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

		// Token: 0x06024B4B RID: 150347 RVA: 0x00A5CC80 File Offset: 0x00A5AE80
		public UniTask PlayReleaseSequence()
		{
			TrackMenuItem.<PlayReleaseSequence>d__12 <PlayReleaseSequence>d__;
			<PlayReleaseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReleaseSequence>d__.<>4__this = this;
			<PlayReleaseSequence>d__.<>1__state = -1;
			<PlayReleaseSequence>d__.<>t__builder.Start<TrackMenuItem.<PlayReleaseSequence>d__12>(ref <PlayReleaseSequence>d__);
			return <PlayReleaseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06024B4C RID: 150348 RVA: 0x00A5CCC4 File Offset: 0x00A5AEC4
		public void PlayAppearSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06024B4D RID: 150349 RVA: 0x00A5CCF4 File Offset: 0x00A5AEF4
		public UniTask PlayDisappearSequence()
		{
			TrackMenuItem.<PlayDisappearSequence>d__14 <PlayDisappearSequence>d__;
			<PlayDisappearSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDisappearSequence>d__.<>4__this = this;
			<PlayDisappearSequence>d__.<>1__state = -1;
			<PlayDisappearSequence>d__.<>t__builder.Start<TrackMenuItem.<PlayDisappearSequence>d__14>(ref <PlayDisappearSequence>d__);
			return <PlayDisappearSequence>d__.<>t__builder.Task;
		}

		// Token: 0x04014618 RID: 83480
		[Nullable(2)]
		private ITrackMenuItemData TrackData;

		// Token: 0x04014619 RID: 83481
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x02009459 RID: 37977
		public static class EComponents
		{
			// Token: 0x0402E62E RID: 189998
			public const int Toggle = 0;

			// Token: 0x0402E62F RID: 189999
			public const int Icon = 1;

			// Token: 0x0402E630 RID: 190000
			public const int Info = 2;
		}
	}
}
