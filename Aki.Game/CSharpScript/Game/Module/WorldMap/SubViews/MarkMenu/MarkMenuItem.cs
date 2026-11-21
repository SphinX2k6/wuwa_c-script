using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MarkMenu
{
	// Token: 0x02003731 RID: 14129
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkMenuItem : UiPanelBase
	{
		// Token: 0x06024C14 RID: 150548 RVA: 0x00A62168 File Offset: 0x00A60368
		[NullableContext(1)]
		public UniTask Init(UUIItem uiItem, MarkItem markItem)
		{
			MarkMenuItem.<Init>d__3 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.uiItem = uiItem;
			<Init>d__.markItem = markItem;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MarkMenuItem.<Init>d__3>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06024C15 RID: 150549 RVA: 0x00A621BC File Offset: 0x00A603BC
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			AUIBaseActor auibaseActor = ((extendToggle != null) ? extendToggle.GetOwner() : null) as AUIBaseActor;
			UUIItem uuiitem = (auibaseActor != null) ? auibaseActor.GetUIItem() : null;
			this._markInfoTextSizeAdapterProxy = new UiTextAdapterProxy(base.GetText(2));
			UiTextAdapterProxy markInfoTextSizeAdapterProxy = this._markInfoTextSizeAdapterProxy;
			if (markInfoTextSizeAdapterProxy != null)
			{
				markInfoTextSizeAdapterProxy.Init();
			}
			if (uuiitem != null)
			{
				this.LevelSequencePlayer = new LevelSequencePlayer(uuiitem);
			}
		}

		// Token: 0x06024C16 RID: 150550 RVA: 0x00A62220 File Offset: 0x00A60420
		protected override void OnBeforeShow()
		{
			this.PlayAppearSequence();
		}

		// Token: 0x06024C17 RID: 150551 RVA: 0x00A62228 File Offset: 0x00A60428
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06024C18 RID: 150552 RVA: 0x00A622F4 File Offset: 0x00A604F4
		[NullableContext(1)]
		public void SetOnClick(Action<EToggleState> onClick)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(onClick);
		}

		// Token: 0x06024C19 RID: 150553 RVA: 0x00A62310 File Offset: 0x00A60510
		private void SetUp()
		{
			if (this._markItem == null)
			{
				return;
			}
			this.SetSpriteByPath(this._markItem.IconPath, base.GetSprite(1), false, null, null);
			EnrichmentAreaItem enrichmentAreaItem = this._markItem as EnrichmentAreaItem;
			if (enrichmentAreaItem != null)
			{
				string markTitle = enrichmentAreaItem.MarkConfig.MarkTitle;
				string localText = MapConfig.Instance.GetLocalText(enrichmentAreaItem.GetEnrichmentItemNameId());
				UiTextAdapterProxy markInfoTextSizeAdapterProxy = this._markInfoTextSizeAdapterProxy;
				if (markInfoTextSizeAdapterProxy != null)
				{
					markInfoTextSizeAdapterProxy.SetLocalText(markTitle, new object[]
					{
						localText
					});
				}
			}
			else
			{
				UiTextAdapterProxy markInfoTextSizeAdapterProxy2 = this._markInfoTextSizeAdapterProxy;
				if (markInfoTextSizeAdapterProxy2 != null)
				{
					markInfoTextSizeAdapterProxy2.SetText(this._markItem.GetTitleText());
				}
			}
			bool showChildIcon = this._markItem.ShowChildIcon;
			UUISprite sprite = base.GetSprite(3);
			if (sprite != null)
			{
				sprite.SetUIActive(showChildIcon);
			}
			if (showChildIcon)
			{
				string childIconPath = this._markItem.ChildIconPath;
				this.SetSpriteByPath(childIconPath, base.GetSprite(3), false, null, null);
			}
			bool showTopRightIcon = this._markItem.ShowTopRightIcon;
			UUISprite sprite2 = base.GetSprite(4);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(showTopRightIcon);
			}
			if (showTopRightIcon)
			{
				string topRightIconPath = this._markItem.TopRightIconPath;
				this.SetSpriteByPath(topRightIconPath, base.GetSprite(4), false, null, null);
			}
		}

		// Token: 0x06024C1A RID: 150554 RVA: 0x00A6244C File Offset: 0x00A6064C
		protected override UniTask OnBeforeHideAsync()
		{
			MarkMenuItem.<OnBeforeHideAsync>d__9 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MarkMenuItem.<OnBeforeHideAsync>d__9>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024C1B RID: 150555 RVA: 0x00A62490 File Offset: 0x00A60690
		protected override void OnBeforeDestroy()
		{
			UiTextAdapterProxy markInfoTextSizeAdapterProxy = this._markInfoTextSizeAdapterProxy;
			if (markInfoTextSizeAdapterProxy != null)
			{
				markInfoTextSizeAdapterProxy.Clear();
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.OnStateChange.Clear();
			}
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x06024C1C RID: 150556 RVA: 0x00A624E0 File Offset: 0x00A606E0
		public UniTask PlayReleaseSequence()
		{
			MarkMenuItem.<PlayReleaseSequence>d__11 <PlayReleaseSequence>d__;
			<PlayReleaseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReleaseSequence>d__.<>4__this = this;
			<PlayReleaseSequence>d__.<>1__state = -1;
			<PlayReleaseSequence>d__.<>t__builder.Start<MarkMenuItem.<PlayReleaseSequence>d__11>(ref <PlayReleaseSequence>d__);
			return <PlayReleaseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x06024C1D RID: 150557 RVA: 0x00A62524 File Offset: 0x00A60724
		public void PlayAppearSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06024C1E RID: 150558 RVA: 0x00A62554 File Offset: 0x00A60754
		public UniTask PlayDisappearSequence()
		{
			MarkMenuItem.<PlayDisappearSequence>d__13 <PlayDisappearSequence>d__;
			<PlayDisappearSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDisappearSequence>d__.<>4__this = this;
			<PlayDisappearSequence>d__.<>1__state = -1;
			<PlayDisappearSequence>d__.<>t__builder.Start<MarkMenuItem.<PlayDisappearSequence>d__13>(ref <PlayDisappearSequence>d__);
			return <PlayDisappearSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0401465F RID: 83551
		private MarkItem _markItem;

		// Token: 0x04014660 RID: 83552
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04014661 RID: 83553
		private UiTextAdapterProxy _markInfoTextSizeAdapterProxy;

		// Token: 0x0200947D RID: 38013
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0402E6A1 RID: 190113
			Toggle,
			// Token: 0x0402E6A2 RID: 190114
			Icon,
			// Token: 0x0402E6A3 RID: 190115
			Info,
			// Token: 0x0402E6A4 RID: 190116
			SprState,
			// Token: 0x0402E6A5 RID: 190117
			TopRightIcon
		}
	}
}
