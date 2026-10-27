using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AC2 RID: 19138
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseMonsterTypeItem : GridProxyAbstract<TrapDefenseMonsterTypeData>
	{
		// Token: 0x06031944 RID: 203076 RVA: 0x00B7F0F8 File Offset: 0x00B7D2F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06031945 RID: 203077 RVA: 0x00B7F1A4 File Offset: 0x00B7D3A4
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMonsterTypeItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMonsterTypeItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031946 RID: 203078 RVA: 0x00B7F1E8 File Offset: 0x00B7D3E8
		public override UniTask RefreshAsync(TrapDefenseMonsterTypeData data, bool isSelected, int gridIndex)
		{
			TrapDefenseMonsterTypeItem.<RefreshAsync>d__9 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<TrapDefenseMonsterTypeItem.<RefreshAsync>d__9>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031947 RID: 203079 RVA: 0x00B7F233 File Offset: 0x00B7D433
		public TrapDefenseMonsterItem CreateItemMonster()
		{
			return new TrapDefenseMonsterItem(false)
			{
				OnSelectMonsterItemCallback = new Action<TrapDefenseMonsterData>(this.OnSelectMonsterItem)
			};
		}

		// Token: 0x06031948 RID: 203080 RVA: 0x00B7F24D File Offset: 0x00B7D44D
		public override void OnSelected(bool isSelected)
		{
			if (!this.IsFireForBuffClick)
			{
				this.LayoutMonster.SelectGridProxy(Math.Max(this.LastSelectMonsterIndex, 0), false);
			}
		}

		// Token: 0x06031949 RID: 203081 RVA: 0x00B7F26F File Offset: 0x00B7D46F
		public override void OnDeselected(bool isSelected)
		{
			this.LayoutMonster.DeselectCurrentGridProxy();
		}

		// Token: 0x0603194A RID: 203082 RVA: 0x00B7F27C File Offset: 0x00B7D47C
		private void OnSelectMonsterItem(TrapDefenseMonsterData data)
		{
			this.IsFireForBuffClick = true;
			IScrollViewDelegate<IGridProxy<TrapDefenseMonsterTypeData>, TrapDefenseMonsterTypeData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate != null)
			{
				scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
			}
			Action<TrapDefenseMonsterData> onSelectMonsterCallBack = this.OnSelectMonsterCallBack;
			if (onSelectMonsterCallBack != null)
			{
				onSelectMonsterCallBack(data);
			}
			this.IsFireForBuffClick = false;
		}

		// Token: 0x0401A7D2 RID: 108498
		public TrapDefenseMonsterTypeData ItemData;

		// Token: 0x0401A7D3 RID: 108499
		public Action<TrapDefenseMonsterTypeData> ClickCallBack;

		// Token: 0x0401A7D4 RID: 108500
		public Action<TrapDefenseMonsterData> OnSelectMonsterCallBack;

		// Token: 0x0401A7D5 RID: 108501
		public GenericLayout<TrapDefenseMonsterItem, TrapDefenseMonsterData> LayoutMonster;

		// Token: 0x0401A7D6 RID: 108502
		public int LastSelectMonsterIndex = -1;

		// Token: 0x0401A7D7 RID: 108503
		public bool IsFireForBuffClick;

		// Token: 0x0200AC29 RID: 44073
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034504 RID: 214276
			public const int SpriteIconType = 0;

			// Token: 0x04034505 RID: 214277
			public const int TextNameType = 1;

			// Token: 0x04034506 RID: 214278
			public const int LayoutMonster = 2;

			// Token: 0x04034507 RID: 214279
			public const int ItemMonster = 3;
		}
	}
}
