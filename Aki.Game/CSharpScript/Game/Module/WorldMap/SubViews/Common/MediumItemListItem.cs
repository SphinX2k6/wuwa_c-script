using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.Common
{
	// Token: 0x02004830 RID: 18480
	public class MediumItemListItem : GridProxyAbstract<TItem>
	{
		// Token: 0x060305F0 RID: 198128 RVA: 0x00B3AD64 File Offset: 0x00B38F64
		protected override UniTask OnBeforeStartAsync()
		{
			MediumItemListItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MediumItemListItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060305F1 RID: 198129 RVA: 0x00B3ADA8 File Offset: 0x00B38FA8
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

		// Token: 0x060305F2 RID: 198130 RVA: 0x00B3AE40 File Offset: 0x00B39040
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

		// Token: 0x0401A034 RID: 106548
		[Nullable(2)]
		private MediumItemGrid GridItem;

		// Token: 0x0401A035 RID: 106549
		private int? ItemId;

		// Token: 0x0401A036 RID: 106550
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<int, string> GetBottomTextCallback;

		// Token: 0x0200AB0A RID: 43786
		public class EComponents
		{
			// Token: 0x04033FC4 RID: 212932
			public const int Root = 0;
		}
	}
}
