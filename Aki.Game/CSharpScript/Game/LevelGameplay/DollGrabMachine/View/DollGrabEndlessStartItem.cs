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
	// Token: 0x02006062 RID: 24674
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabEndlessStartItem : UiPanelBase, IGridProxy<IGrabItemData>
	{
		// Token: 0x1700702D RID: 28717
		// (get) Token: 0x0603B3EF RID: 242671 RVA: 0x010C3D49 File Offset: 0x010C1F49
		// (set) Token: 0x0603B3F0 RID: 242672 RVA: 0x010C3D51 File Offset: 0x010C1F51
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

		// Token: 0x1700702E RID: 28718
		// (get) Token: 0x0603B3F1 RID: 242673 RVA: 0x010C3D5A File Offset: 0x010C1F5A
		// (set) Token: 0x0603B3F2 RID: 242674 RVA: 0x010C3D62 File Offset: 0x010C1F62
		public int GridIndex { get; set; }

		// Token: 0x1700702F RID: 28719
		// (get) Token: 0x0603B3F3 RID: 242675 RVA: 0x010C3D6B File Offset: 0x010C1F6B
		// (set) Token: 0x0603B3F4 RID: 242676 RVA: 0x010C3D73 File Offset: 0x010C1F73
		public int DisplayIndex { get; set; }

		// Token: 0x0603B3F5 RID: 242677 RVA: 0x010C3D7C File Offset: 0x010C1F7C
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

		// Token: 0x0603B3F6 RID: 242678 RVA: 0x010C3DE5 File Offset: 0x010C1FE5
		public void Refresh(IGrabItemData data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}

		// Token: 0x0603B3F7 RID: 242679 RVA: 0x010C3DF8 File Offset: 0x010C1FF8
		public UniTask RefreshAsync(IGrabItemData data, bool isSelected, int gridIndex)
		{
			DollGrabEndlessStartItem.<RefreshAsync>d__14 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<DollGrabEndlessStartItem.<RefreshAsync>d__14>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B3F8 RID: 242680 RVA: 0x010C3E43 File Offset: 0x010C2043
		public void Clear()
		{
		}

		// Token: 0x0603B3F9 RID: 242681 RVA: 0x010C3E45 File Offset: 0x010C2045
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x0603B3FA RID: 242682 RVA: 0x010C3E47 File Offset: 0x010C2047
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x0603B3FB RID: 242683 RVA: 0x010C3E49 File Offset: 0x010C2049
		public object GetKey(IGrabItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
