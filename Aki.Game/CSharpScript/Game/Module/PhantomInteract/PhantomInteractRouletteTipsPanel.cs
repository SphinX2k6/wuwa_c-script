using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomInteract
{
	// Token: 0x020040CE RID: 16590
	public class PhantomInteractRouletteTipsPanel : UiPanelBase
	{
		// Token: 0x06029EFB RID: 171771 RVA: 0x00BDB044 File Offset: 0x00BD9244
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06029EFC RID: 171772 RVA: 0x00BDB0A0 File Offset: 0x00BD92A0
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomInteractRouletteTipsPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractRouletteTipsPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06029EFD RID: 171773 RVA: 0x00BDB0E4 File Offset: 0x00BD92E4
		public void Refresh()
		{
			PhantomInteractModel instance = PhantomInteractModel.Instance;
			for (int i = 0; i < this.GridItems.Count; i++)
			{
				PhantomGridItem phantomGridItem = this.GridItems[i];
				PhantomInteractItemData phantomInteractItemData = instance.InteractInfoData.EquippedVisionData[i];
				IPhantomInteractGridData phantomInteractGridData = null;
				PhantomInteractGridData phantomInteractGridData2;
				if (instance.InteractInfoData.GridItemDataMap.TryGetValue(phantomInteractItemData.MonsterId, out phantomInteractGridData2))
				{
					phantomInteractGridData = phantomInteractGridData2;
				}
				phantomGridItem.SetIcon((phantomInteractGridData != null) ? phantomInteractGridData.IconPath : null);
			}
		}

		// Token: 0x04016DBA RID: 93626
		private const int GRID_COUNT = 8;

		// Token: 0x04016DBB RID: 93627
		[Nullable(1)]
		private readonly List<PhantomGridItem> GridItems = new List<PhantomGridItem>();

		// Token: 0x02009C91 RID: 40081
		private enum EComponent
		{
			// Token: 0x04030B6B RID: 199531
			ItemContent,
			// Token: 0x04030B6C RID: 199532
			ItemGrid,
			// Token: 0x04030B6D RID: 199533
			TxtPath
		}
	}
}
