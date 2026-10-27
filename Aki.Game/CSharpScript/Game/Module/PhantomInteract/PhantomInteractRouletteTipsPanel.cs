using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomInteract
{
	// Token: 0x020050FE RID: 20734
	public class PhantomInteractRouletteTipsPanel : UiPanelBase
	{
		// Token: 0x06035002 RID: 217090 RVA: 0x00C8DD68 File Offset: 0x00C8BF68
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText))
			};
		}

		// Token: 0x06035003 RID: 217091 RVA: 0x00C8DDC4 File Offset: 0x00C8BFC4
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomInteractRouletteTipsPanel.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractRouletteTipsPanel.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035004 RID: 217092 RVA: 0x00C8DE08 File Offset: 0x00C8C008
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

		// Token: 0x0401C387 RID: 115591
		private const int GRID_COUNT = 8;

		// Token: 0x0401C388 RID: 115592
		[Nullable(1)]
		private readonly List<PhantomGridItem> GridItems = new List<PhantomGridItem>();

		// Token: 0x0200B258 RID: 45656
		private enum EComponent
		{
			// Token: 0x04036116 RID: 221462
			ItemContent,
			// Token: 0x04036117 RID: 221463
			ItemGrid,
			// Token: 0x04036118 RID: 221464
			TxtPath
		}
	}
}
