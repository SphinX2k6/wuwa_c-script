using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004889 RID: 18569
	public class VillageInfrNewTipsView : UiTickViewBase
	{
		// Token: 0x0603091F RID: 198943 RVA: 0x00B481AA File Offset: 0x00B463AA
		[NullableContext(1)]
		public VillageInfrNewTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030920 RID: 198944 RVA: 0x00B481B4 File Offset: 0x00B463B4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x06030921 RID: 198945 RVA: 0x00B48224 File Offset: 0x00B46424
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrNewTipsView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrNewTipsView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06030922 RID: 198946 RVA: 0x00B48268 File Offset: 0x00B46468
		protected override void OnStart()
		{
			int configId = (int)this.OpenParam;
			InfrV2TreeBuild? infrTreeBuild = VillageInfrConfig.Instance.GetInfrTreeBuild(configId);
			int num = infrTreeBuild.Value.Requirement().Keys.First<int>();
			if (num == 0)
			{
				Log.Instance.Error(ELogModule.Item, ELogAuthor.ZJC, "新物品提示错误, 没有物品id!", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.CloseMe(null);
				return;
			}
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(num);
			if (itemConfigData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.ZJC;
				string message = "新物品提示错误, 没有物品配置!";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.CloseMe(null);
				return;
			}
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = num,
				ItemConfigId = new int?(num)
			};
			this.IconItem.Apply<PropSmallItemGrid>(parameters);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "VillageInfr_Tips_Itemsatisfies", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(itemConfigData.Name, Array.Empty<object>())));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "VillageInfr_Tips_Deliverytips", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(infrTreeBuild.Value.Name, Array.Empty<object>())));
		}

		// Token: 0x06030923 RID: 198947 RVA: 0x00B4839D File Offset: 0x00B4659D
		protected override void OnBeforeDestroy()
		{
			ItemModel.Instance.LastCloseTimeStamp = TimeUtil.Instance.GetServerTimeStamp();
		}

		// Token: 0x06030924 RID: 198948 RVA: 0x00B483B3 File Offset: 0x00B465B3
		protected override void OnFinishShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401A1A5 RID: 106917
		[Nullable(2)]
		private SmallItemGrid IconItem;
	}
}
