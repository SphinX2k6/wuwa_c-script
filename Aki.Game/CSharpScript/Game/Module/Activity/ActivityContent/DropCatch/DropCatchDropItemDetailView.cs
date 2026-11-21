using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200560B RID: 22027
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchDropItemDetailView : UiViewBase
	{
		// Token: 0x060367C1 RID: 223169 RVA: 0x00F34D35 File Offset: 0x00F32F35
		public DropCatchDropItemDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060367C2 RID: 223170 RVA: 0x00F34D40 File Offset: 0x00F32F40
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent))
			};
		}

		// Token: 0x060367C3 RID: 223171 RVA: 0x00F34DC6 File Offset: 0x00F32FC6
		protected override void OnBeforeCreate()
		{
			this.Proxy = (this.OpenParam as DropCatchGameplayProxy);
			DropCatchGameplayProxy proxy = this.Proxy;
			if (proxy == null)
			{
				return;
			}
			proxy.PauseGameplay("DropItemDetail");
		}

		// Token: 0x060367C4 RID: 223172 RVA: 0x00F34DF0 File Offset: 0x00F32FF0
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				this.CaptionItem = new PopupCaptionItem(item);
				this.CaptionItem.SetCloseCallBack(delegate
				{
					DropCatchGameplayProxy proxy = this.Proxy;
					if (proxy != null)
					{
						proxy.ResumeGameplay("DropItemDetail");
					}
					base.CloseMe(null);
				});
			}
			this.ItemLayout = new GenericLayout<CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem, int>(base.GetVerticalLayout(1), new Func<CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem>(this.InitItem), null, false, true);
		}

		// Token: 0x060367C5 RID: 223173 RVA: 0x00F34E4C File Offset: 0x00F3304C
		protected override void OnBeforeShow()
		{
			this.Proxy = (this.OpenParam as DropCatchGameplayProxy);
			DropCatchGameplayProxy proxy = this.Proxy;
			this.CurOpenLevelId = ((proxy != null) ? proxy.GetCurGameplayId() : 0);
			this.RefreshPreviewContent();
			this.SwitchContent();
			USpineSkeletonAnimationComponent spine = base.GetSpine(4);
			if (spine == null)
			{
				return;
			}
			spine.SetAnimation(0, EDropCatchRobotAnimState.IdleRight.ToEnumString(), true);
		}

		// Token: 0x060367C6 RID: 223174 RVA: 0x00F34EA8 File Offset: 0x00F330A8
		private CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem InitItem()
		{
			return new CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem();
		}

		// Token: 0x060367C7 RID: 223175 RVA: 0x00F34EB0 File Offset: 0x00F330B0
		private void RefreshPreviewContent()
		{
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(this.CurOpenLevelId);
			if (dropCatchGameplayById == null)
			{
				return;
			}
			GenericLayout<CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem, int> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(dropCatchGameplayById.Value.DropItemList(), null, false);
		}

		// Token: 0x060367C8 RID: 223176 RVA: 0x00F34EFC File Offset: 0x00F330FC
		private void SwitchContent()
		{
			DropCatchGameplay? dropCatchGameplayById = DropCatchConfig.Instance.GetDropCatchGameplayById(this.CurOpenLevelId);
			if (dropCatchGameplayById == null)
			{
				return;
			}
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(dropCatchGameplayById.Value.Desc);
		}

		// Token: 0x0401CC81 RID: 117889
		[Nullable(2)]
		private DropCatchGameplayProxy Proxy;

		// Token: 0x0401CC82 RID: 117890
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CC83 RID: 117891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem, int> ItemLayout;

		// Token: 0x0401CC84 RID: 117892
		private int CurOpenLevelId;
	}
}
