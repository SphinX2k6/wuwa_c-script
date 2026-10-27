using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066BB RID: 26299
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchDropItemDetailView : UiViewBase
	{
		// Token: 0x06041C75 RID: 269429 RVA: 0x00FF392D File Offset: 0x00FF1B2D
		public DropCatchDropItemDetailView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041C76 RID: 269430 RVA: 0x00FF3938 File Offset: 0x00FF1B38
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

		// Token: 0x06041C77 RID: 269431 RVA: 0x00FF39BE File Offset: 0x00FF1BBE
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

		// Token: 0x06041C78 RID: 269432 RVA: 0x00FF39E8 File Offset: 0x00FF1BE8
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

		// Token: 0x06041C79 RID: 269433 RVA: 0x00FF3A44 File Offset: 0x00FF1C44
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

		// Token: 0x06041C7A RID: 269434 RVA: 0x00FF3AA0 File Offset: 0x00FF1CA0
		private CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem InitItem()
		{
			return new CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem();
		}

		// Token: 0x06041C7B RID: 269435 RVA: 0x00FF3AA8 File Offset: 0x00FF1CA8
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
			itemLayout.RefreshByData(dropCatchGameplayById.Value.DropItemList().ToList<int>(), null, false);
		}

		// Token: 0x06041C7C RID: 269436 RVA: 0x00FF3AF8 File Offset: 0x00FF1CF8
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

		// Token: 0x04022428 RID: 140328
		[Nullable(2)]
		private DropCatchGameplayProxy Proxy;

		// Token: 0x04022429 RID: 140329
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0402242A RID: 140330
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Item.DropCatchDropItem, int> ItemLayout;

		// Token: 0x0402242B RID: 140331
		private int CurOpenLevelId;
	}
}
