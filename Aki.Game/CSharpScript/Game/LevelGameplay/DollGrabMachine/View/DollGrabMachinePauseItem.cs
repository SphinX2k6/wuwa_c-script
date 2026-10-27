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
	// Token: 0x02006F00 RID: 28416
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabMachinePauseItem : UiPanelBase, IGridProxy<IGrabItemData>
	{
		// Token: 0x17009AF7 RID: 39671
		// (get) Token: 0x060452D1 RID: 283345 RVA: 0x0111C937 File Offset: 0x0111AB37
		// (set) Token: 0x060452D2 RID: 283346 RVA: 0x0111C93F File Offset: 0x0111AB3F
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

		// Token: 0x17009AF8 RID: 39672
		// (get) Token: 0x060452D3 RID: 283347 RVA: 0x0111C948 File Offset: 0x0111AB48
		// (set) Token: 0x060452D4 RID: 283348 RVA: 0x0111C950 File Offset: 0x0111AB50
		public int GridIndex { get; set; }

		// Token: 0x17009AF9 RID: 39673
		// (get) Token: 0x060452D5 RID: 283349 RVA: 0x0111C959 File Offset: 0x0111AB59
		// (set) Token: 0x060452D6 RID: 283350 RVA: 0x0111C961 File Offset: 0x0111AB61
		public int DisplayIndex { get; set; }

		// Token: 0x060452D7 RID: 283351 RVA: 0x0111C96C File Offset: 0x0111AB6C
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

		// Token: 0x060452D8 RID: 283352 RVA: 0x0111C9D5 File Offset: 0x0111ABD5
		public void Refresh(IGrabItemData data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}

		// Token: 0x060452D9 RID: 283353 RVA: 0x0111C9E8 File Offset: 0x0111ABE8
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

		// Token: 0x060452DA RID: 283354 RVA: 0x0111CA33 File Offset: 0x0111AC33
		public void Clear()
		{
		}

		// Token: 0x060452DB RID: 283355 RVA: 0x0111CA35 File Offset: 0x0111AC35
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x060452DC RID: 283356 RVA: 0x0111CA37 File Offset: 0x0111AC37
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x060452DD RID: 283357 RVA: 0x0111CA39 File Offset: 0x0111AC39
		public object GetKey(IGrabItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
