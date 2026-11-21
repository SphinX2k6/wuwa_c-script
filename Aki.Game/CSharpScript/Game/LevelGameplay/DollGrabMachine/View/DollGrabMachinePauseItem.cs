using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine.View
{
	// Token: 0x02006080 RID: 24704
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachinePauseItem : UiPanelBase, IGridProxy<IGrabItemData>
	{
		// Token: 0x17007036 RID: 28726
		// (get) Token: 0x0603B47B RID: 242811 RVA: 0x010C672F File Offset: 0x010C492F
		// (set) Token: 0x0603B47C RID: 242812 RVA: 0x010C6737 File Offset: 0x010C4937
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public IScrollViewDelegate<IGridProxy<IGrabItemData>, IGrabItemData> ScrollViewDelegate { [return: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})] set; }

		// Token: 0x17007037 RID: 28727
		// (get) Token: 0x0603B47D RID: 242813 RVA: 0x010C6740 File Offset: 0x010C4940
		// (set) Token: 0x0603B47E RID: 242814 RVA: 0x010C6748 File Offset: 0x010C4948
		public int GridIndex { get; set; }

		// Token: 0x17007038 RID: 28728
		// (get) Token: 0x0603B47F RID: 242815 RVA: 0x010C6751 File Offset: 0x010C4951
		// (set) Token: 0x0603B480 RID: 242816 RVA: 0x010C6759 File Offset: 0x010C4959
		public int DisplayIndex { get; set; }

		// Token: 0x0603B481 RID: 242817 RVA: 0x010C6764 File Offset: 0x010C4964
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B482 RID: 242818 RVA: 0x010C67CD File Offset: 0x010C49CD
		public void Refresh(IGrabItemData data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}

		// Token: 0x0603B483 RID: 242819 RVA: 0x010C67E0 File Offset: 0x010C49E0
		public UniTask RefreshAsync(IGrabItemData data, bool isSelected, int gridIndex)
		{
			DollGrabMachinePauseItem.<RefreshAsync>d__14 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<DollGrabMachinePauseItem.<RefreshAsync>d__14>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B484 RID: 242820 RVA: 0x010C682B File Offset: 0x010C4A2B
		public void Clear()
		{
		}

		// Token: 0x0603B485 RID: 242821 RVA: 0x010C682D File Offset: 0x010C4A2D
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603B486 RID: 242822 RVA: 0x010C682F File Offset: 0x010C4A2F
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603B487 RID: 242823 RVA: 0x010C6831 File Offset: 0x010C4A31
		public object GetKey(IGrabItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
