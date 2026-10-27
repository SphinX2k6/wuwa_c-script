using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Map.Mark;
using CSharpScript.Game.Module.Map.Mark.Component;
using CSharpScript.Game.Module.Map.Marks;
using CSharpScript.Game.Module.Map.Marks.MarkItem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MarkMenu
{
	// Token: 0x02004800 RID: 18432
	[NullableContext(2)]
	[Nullable(0)]
	public class MarkMenuItem : UiPanelBase
	{
		// Token: 0x06030444 RID: 197700 RVA: 0x00B321C0 File Offset: 0x00B303C0
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

		// Token: 0x06030445 RID: 197701 RVA: 0x00B32214 File Offset: 0x00B30414
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			AUIBaseActor auibaseActor = ((extendToggle != null) ? extendToggle.GetOwner() : null) as AUIBaseActor;
			UUIItem uuiitem = (auibaseActor != null) ? auibaseActor.GetUIItem() : null;
			this.MarkInfoTextSizeAdapterProxy = new UiTextAdapterProxy(base.GetText(2));
			UiTextAdapterProxy markInfoTextSizeAdapterProxy = this.MarkInfoTextSizeAdapterProxy;
			if (markInfoTextSizeAdapterProxy != null)
			{
				markInfoTextSizeAdapterProxy.Init();
			}
			if (uuiitem != null)
			{
				this.LevelSequencePlayer = new LevelSequencePlayer(uuiitem);
			}
		}

		// Token: 0x06030446 RID: 197702 RVA: 0x00B32278 File Offset: 0x00B30478
		protected override void OnBeforeShow()
		{
			this.PlayAppearSequence();
		}

		// Token: 0x06030447 RID: 197703 RVA: 0x00B32280 File Offset: 0x00B30480
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

		// Token: 0x06030448 RID: 197704 RVA: 0x00B3234C File Offset: 0x00B3054C
		[NullableContext(1)]
		public void SetOnClick(Action<EToggleState> onClick)
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
			onStateChange.Add(onClick);
		}

		// Token: 0x06030449 RID: 197705 RVA: 0x00B3236C File Offset: 0x00B3056C
		private void SetUp()
		{
			if (this.MarkItem == null)
			{
				return;
			}
			this.SetSpriteByPath(this.MarkItem.IconPath, base.GetSprite(1), false, null, null);
			EnrichmentAreaItem enrichmentAreaItem = this.MarkItem as EnrichmentAreaItem;
			if (enrichmentAreaItem != null)
			{
				string markTitle = enrichmentAreaItem.MarkConfig.MarkTitle;
				MapConfig instance = MapConfig.Instance;
				string text = (instance != null) ? instance.GetLocalText(enrichmentAreaItem.GetEnrichmentItemNameId()) : null;
				UiTextAdapterProxy markInfoTextSizeAdapterProxy = this.MarkInfoTextSizeAdapterProxy;
				if (markInfoTextSizeAdapterProxy != null)
				{
					markInfoTextSizeAdapterProxy.SetLocalText(markTitle, new object[]
					{
						text
					});
				}
			}
			else
			{
				UiTextAdapterProxy markInfoTextSizeAdapterProxy2 = this.MarkInfoTextSizeAdapterProxy;
				if (markInfoTextSizeAdapterProxy2 != null)
				{
					markInfoTextSizeAdapterProxy2.SetText(this.MarkItem.GetTitleText());
				}
			}
			MarkItemEntity markItemEntity = this.MarkItem.MarkItemEntity;
			MarkViewLifeCircleComponent markViewLifeCircleComponent = (markItemEntity != null) ? markItemEntity.ViewLifeCircle : null;
			if (markViewLifeCircleComponent != null)
			{
				bool flag = markViewLifeCircleComponent.IsChildViewVisible(EMarkViewComponentType.ChildIcon, false);
				UUISprite sprite = base.GetSprite(3);
				if (sprite != null)
				{
					sprite.SetUIActive(flag);
				}
				if (flag)
				{
					string childIconPath = this.MarkItem.MarkItemEntity.Resource.ChildIconPath;
					this.SetSpriteByPath(childIconPath, base.GetSprite(3), false, null, null);
				}
				bool flag2 = markViewLifeCircleComponent.IsChildViewVisible(EMarkViewComponentType.TopRightIcon, false);
				UUISprite sprite2 = base.GetSprite(4);
				if (sprite2 != null)
				{
					sprite2.SetUIActive(flag2);
				}
				if (flag2)
				{
					string topRightIconPath = this.MarkItem.MarkItemEntity.Resource.TopRightIconPath;
					this.SetSpriteByPath(topRightIconPath, base.GetSprite(4), false, null, null);
				}
			}
		}

		// Token: 0x0603044A RID: 197706 RVA: 0x00B324DC File Offset: 0x00B306DC
		protected override UniTask OnBeforeHideAsync()
		{
			MarkMenuItem.<OnBeforeHideAsync>d__9 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MarkMenuItem.<OnBeforeHideAsync>d__9>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603044B RID: 197707 RVA: 0x00B32520 File Offset: 0x00B30720
		protected override void OnBeforeDestroy()
		{
			UiTextAdapterProxy markInfoTextSizeAdapterProxy = this.MarkInfoTextSizeAdapterProxy;
			if (markInfoTextSizeAdapterProxy != null)
			{
				markInfoTextSizeAdapterProxy.Clear();
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				FOnToggleStateChange onStateChange = extendToggle.OnStateChange;
				if (onStateChange != null)
				{
					onStateChange.Clear();
				}
			}
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
			}
			this.LevelSequencePlayer = null;
		}

		// Token: 0x0603044C RID: 197708 RVA: 0x00B32578 File Offset: 0x00B30778
		public UniTask PlayReleaseSequence()
		{
			MarkMenuItem.<PlayReleaseSequence>d__11 <PlayReleaseSequence>d__;
			<PlayReleaseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayReleaseSequence>d__.<>4__this = this;
			<PlayReleaseSequence>d__.<>1__state = -1;
			<PlayReleaseSequence>d__.<>t__builder.Start<MarkMenuItem.<PlayReleaseSequence>d__11>(ref <PlayReleaseSequence>d__);
			return <PlayReleaseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0603044D RID: 197709 RVA: 0x00B325BC File Offset: 0x00B307BC
		public void PlayAppearSequence()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603044E RID: 197710 RVA: 0x00B325EC File Offset: 0x00B307EC
		public UniTask PlayDisappearSequence()
		{
			MarkMenuItem.<PlayDisappearSequence>d__13 <PlayDisappearSequence>d__;
			<PlayDisappearSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayDisappearSequence>d__.<>4__this = this;
			<PlayDisappearSequence>d__.<>1__state = -1;
			<PlayDisappearSequence>d__.<>t__builder.Start<MarkMenuItem.<PlayDisappearSequence>d__13>(ref <PlayDisappearSequence>d__);
			return <PlayDisappearSequence>d__.<>t__builder.Task;
		}

		// Token: 0x04019FAB RID: 106411
		private MarkItem MarkItem;

		// Token: 0x04019FAC RID: 106412
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04019FAD RID: 106413
		private UiTextAdapterProxy MarkInfoTextSizeAdapterProxy;

		// Token: 0x0200AACC RID: 43724
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04033F1E RID: 212766
			Toggle,
			// Token: 0x04033F1F RID: 212767
			Icon,
			// Token: 0x04033F20 RID: 212768
			Info,
			// Token: 0x04033F21 RID: 212769
			SprState,
			// Token: 0x04033F22 RID: 212770
			TopRightIcon
		}
	}
}
