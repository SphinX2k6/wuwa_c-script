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
	// Token: 0x02003A6A RID: 14954
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TrapDefenseMonsterTypeItem : GridProxyAbstract<TrapDefenseMonsterTypeData>
	{
		// Token: 0x060266D4 RID: 157396 RVA: 0x00AC30AC File Offset: 0x00AC12AC
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

		// Token: 0x060266D5 RID: 157397 RVA: 0x00AC3158 File Offset: 0x00AC1358
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseMonsterTypeItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseMonsterTypeItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060266D6 RID: 157398 RVA: 0x00AC319C File Offset: 0x00AC139C
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

		// Token: 0x060266D7 RID: 157399 RVA: 0x00AC31E7 File Offset: 0x00AC13E7
		public TrapDefenseMonsterItem CreateItemMonster()
		{
			return new TrapDefenseMonsterItem(false)
			{
				OnSelectMonsterItemCallback = new Action<TrapDefenseMonsterData>(this.OnSelectMonsterItem)
			};
		}

		// Token: 0x060266D8 RID: 157400 RVA: 0x00AC3201 File Offset: 0x00AC1401
		public override void OnSelected(bool isSelected)
		{
			if (!this.IsFireForBuffClick)
			{
				this.LayoutMonster.SelectGridProxy(Math.Max(this.LastSelectMonsterIndex, 0), false);
			}
		}

		// Token: 0x060266D9 RID: 157401 RVA: 0x00AC3223 File Offset: 0x00AC1423
		public override void OnDeselected(bool isSelected)
		{
			this.LayoutMonster.DeselectCurrentGridProxy();
		}

		// Token: 0x060266DA RID: 157402 RVA: 0x00AC3230 File Offset: 0x00AC1430
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

		// Token: 0x04015124 RID: 86308
		public TrapDefenseMonsterTypeData ItemData;

		// Token: 0x04015125 RID: 86309
		public Action<TrapDefenseMonsterTypeData> ClickCallBack;

		// Token: 0x04015126 RID: 86310
		public Action<TrapDefenseMonsterData> OnSelectMonsterCallBack;

		// Token: 0x04015127 RID: 86311
		public GenericLayout<TrapDefenseMonsterItem, TrapDefenseMonsterData> LayoutMonster;

		// Token: 0x04015128 RID: 86312
		public int LastSelectMonsterIndex = -1;

		// Token: 0x04015129 RID: 86313
		public bool IsFireForBuffClick;

		// Token: 0x02009649 RID: 38473
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EEB5 RID: 192181
			public const int SpriteIconType = 0;

			// Token: 0x0402EEB6 RID: 192182
			public const int TextNameType = 1;

			// Token: 0x0402EEB7 RID: 192183
			public const int LayoutMonster = 2;

			// Token: 0x0402EEB8 RID: 192184
			public const int ItemMonster = 3;
		}
	}
}
