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
	// Token: 0x02006EE2 RID: 28386
	[NullableContext(1)]
	[Nullable(0)]
	public class DollGrabEndlessStartItem : UiPanelBase, IGridProxy<IGrabItemData>
	{
		// Token: 0x17009AEE RID: 39662
		// (get) Token: 0x06045246 RID: 283206 RVA: 0x01119FB9 File Offset: 0x011181B9
		// (set) Token: 0x06045247 RID: 283207 RVA: 0x01119FC1 File Offset: 0x011181C1
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

		// Token: 0x17009AEF RID: 39663
		// (get) Token: 0x06045248 RID: 283208 RVA: 0x01119FCA File Offset: 0x011181CA
		// (set) Token: 0x06045249 RID: 283209 RVA: 0x01119FD2 File Offset: 0x011181D2
		public int GridIndex { get; set; }

		// Token: 0x17009AF0 RID: 39664
		// (get) Token: 0x0604524A RID: 283210 RVA: 0x01119FDB File Offset: 0x011181DB
		// (set) Token: 0x0604524B RID: 283211 RVA: 0x01119FE3 File Offset: 0x011181E3
		public int DisplayIndex { get; set; }

		// Token: 0x0604524C RID: 283212 RVA: 0x01119FEC File Offset: 0x011181EC
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

		// Token: 0x0604524D RID: 283213 RVA: 0x0111A055 File Offset: 0x01118255
		public void Refresh(IGrabItemData data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}

		// Token: 0x0604524E RID: 283214 RVA: 0x0111A068 File Offset: 0x01118268
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

		// Token: 0x0604524F RID: 283215 RVA: 0x0111A0B3 File Offset: 0x011182B3
		public void Clear()
		{
		}

		// Token: 0x06045250 RID: 283216 RVA: 0x0111A0B5 File Offset: 0x011182B5
		public void OnSelected(bool fireEvent)
		{
		}

		// Token: 0x06045251 RID: 283217 RVA: 0x0111A0B7 File Offset: 0x011182B7
		public void OnDeselected(bool fireEvent)
		{
		}

		// Token: 0x06045252 RID: 283218 RVA: 0x0111A0B9 File Offset: 0x011182B9
		public object GetKey(IGrabItemData data, int gridIndex)
		{
			return this.GridIndex;
		}
	}
}
