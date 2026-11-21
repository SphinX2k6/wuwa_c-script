using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02003761 RID: 14177
	public class MediumItemListItem : GridProxyAbstract<TItem>
	{
		// Token: 0x06024DC0 RID: 150976 RVA: 0x00A6AE30 File Offset: 0x00A69030
		protected override UniTask OnBeforeStartAsync()
		{
			MediumItemListItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemListItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06024DC1 RID: 150977 RVA: 0x00A6AE74 File Offset: 0x00A69074
		public override void Refresh(TItem data, bool isSelected, int gridIndex)
		{
			int itemId = data.ItemData.ItemId;
			int count = data.Count;
			this.ItemId = new int?(itemId);
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
			string bottomText = this.GetBottomText(count);
			PropMediumItemGrid parameters = new PropMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(itemId),
				StarLevel = new int?(itemConfigData.QualityId),
				BottomText = bottomText,
				IsOmitBottomText = new bool?(false)
			};
			MediumItemGrid gridItem = this.GridItem;
			if (gridItem == null)
			{
				return;
			}
			gridItem.Apply<PropMediumItemGrid>(parameters);
		}

		// Token: 0x06024DC2 RID: 150978 RVA: 0x00A6AF0C File Offset: 0x00A6910C
		[NullableContext(1)]
		public string GetBottomText(int needCount)
		{
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(this.ItemId.Value, 0);
			if (this.GetBottomTextCallback != null)
			{
				return this.GetBottomTextCallback(needCount);
			}
			string value = (needCount <= commonItemCount) ? "Highlight" : "RedA";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(commonItemCount);
			defaultInterpolatedStringHandler.AppendLiteral("</color>/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(needCount);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x040146E8 RID: 83688
		[Nullable(2)]
		private MediumItemGrid GridItem;

		// Token: 0x040146E9 RID: 83689
		private int? ItemId;

		// Token: 0x040146EA RID: 83690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<int, string> GetBottomTextCallback;

		// Token: 0x020094B9 RID: 38073
		public class EComponents
		{
			// Token: 0x0402E744 RID: 190276
			public const int Root = 0;
		}
	}
}
