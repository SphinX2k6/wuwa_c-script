using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007281 RID: 29313
	public class ISystemFunction_UnionUnion
	{
		// Token: 0x1700D977 RID: 55671
		// (get) Token: 0x06034019 RID: 213017 RVA: 0x006FE355 File Offset: 0x006FC555
		// (set) Token: 0x0603401A RID: 213018 RVA: 0x006FE35D File Offset: 0x006FC55D
		public ISystemFunction_Union Type { get; set; }

		// Token: 0x1700D978 RID: 55672
		// (get) Token: 0x0603401B RID: 213019 RVA: 0x006FE366 File Offset: 0x006FC566
		// (set) Token: 0x0603401C RID: 213020 RVA: 0x006FE36E File Offset: 0x006FC56E
		public object Value { get; set; }

		// Token: 0x0603401D RID: 213021 RVA: 0x006FE377 File Offset: 0x006FC577
		public ISystemFunction_UnionUnion()
		{
			this.Type = ISystemFunction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603401E RID: 213022 RVA: 0x006FE38D File Offset: 0x006FC58D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603401F RID: 213023 RVA: 0x006FE39F File Offset: 0x006FC59F
		public ISystemFunctionT AsISystemFunction()
		{
			return this.As<ISystemFunctionT>();
		}

		// Token: 0x06034020 RID: 213024 RVA: 0x006FE3A7 File Offset: 0x006FC5A7
		public static ISystemFunction_UnionUnion FromISystemFunction(ISystemFunctionT _isystemfunction)
		{
			return new ISystemFunction_UnionUnion
			{
				Type = ISystemFunction_Union.ISystemFunction,
				Value = _isystemfunction
			};
		}

		// Token: 0x06034021 RID: 213025 RVA: 0x006FE3BC File Offset: 0x006FC5BC
		public IBuyGoodsT AsIBuyGoods()
		{
			return this.As<IBuyGoodsT>();
		}

		// Token: 0x06034022 RID: 213026 RVA: 0x006FE3C4 File Offset: 0x006FC5C4
		public static ISystemFunction_UnionUnion FromIBuyGoods(IBuyGoodsT _ibuygoods)
		{
			return new ISystemFunction_UnionUnion
			{
				Type = ISystemFunction_Union.IBuyGoods,
				Value = _ibuygoods
			};
		}

		// Token: 0x06034023 RID: 213027 RVA: 0x006FE3DC File Offset: 0x006FC5DC
		public static int Pack(FlatBufferBuilder builder, ISystemFunction_UnionUnion _o)
		{
			ISystemFunction_Union type = _o.Type;
			if (type == ISystemFunction_Union.ISystemFunction)
			{
				return ISystemFunction.Pack(builder, _o.AsISystemFunction()).Value;
			}
			if (type != ISystemFunction_Union.IBuyGoods)
			{
				return 0;
			}
			return IBuyGoods.Pack(builder, _o.AsIBuyGoods()).Value;
		}
	}
}
