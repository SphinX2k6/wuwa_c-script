using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E99 RID: 20121
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleSettleInfoPanelWithList<TItem, [Nullable(2)] TData> : UiPanelBase where TItem : class, IGridProxy<TData>
	{
		// Token: 0x06033B90 RID: 211856 RVA: 0x00C1DC90 File Offset: 0x00C1BE90
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(5, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUISprite))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnShowMore))
			};
		}

		// Token: 0x06033B91 RID: 211857 RVA: 0x00C1DD68 File Offset: 0x00C1BF68
		private void OnClickBtnShowMore()
		{
			FRotator frotator;
			if (this.IsShowMore)
			{
				this.IsShowMore = false;
				UUIItem sprite = base.GetSprite(6);
				frotator = new FRotator(0f, -90f, 0f);
				sprite.SetUIRelativeRotation(frotator);
				base.GetVerticalLayout(5).SetHeightFitToChildren(false);
				base.GetVerticalLayout(5).RootUIComp.Get().SetHeight(this.OriginalHeight);
				return;
			}
			this.IsShowMore = true;
			UUIItem sprite2 = base.GetSprite(6);
			frotator = new FRotator(0f, 90f, 0f);
			sprite2.SetUIRelativeRotation(frotator);
			base.GetVerticalLayout(5).SetHeightFitToChildren(true);
		}

		// Token: 0x06033B92 RID: 211858 RVA: 0x00C1DE0C File Offset: 0x00C1C00C
		protected override UniTask OnBeforeStartAsync()
		{
			RogueBattleSettleInfoPanelWithList<TItem, TData>.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleSettleInfoPanelWithList<TItem, TData>.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401B78B RID: 112523
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<TItem, TData> LayoutComponent;

		// Token: 0x0401B78C RID: 112524
		private bool IsShowMore;

		// Token: 0x0401B78D RID: 112525
		private float OriginalHeight;

		// Token: 0x0401B78E RID: 112526
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<TItem> CreateItem;

		// Token: 0x0401B78F RID: 112527
		public List<TData> Data = new List<TData>();
	}
}
