using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A56 RID: 31318
	public class ISystemFunction_UnionUnion
	{
		// Token: 0x1700E570 RID: 58736
		// (get) Token: 0x0603731B RID: 226075 RVA: 0x0075F6B5 File Offset: 0x0075D8B5
		// (set) Token: 0x0603731C RID: 226076 RVA: 0x0075F6BD File Offset: 0x0075D8BD
		public ISystemFunction_Union Type { get; set; }

		// Token: 0x1700E571 RID: 58737
		// (get) Token: 0x0603731D RID: 226077 RVA: 0x0075F6C6 File Offset: 0x0075D8C6
		// (set) Token: 0x0603731E RID: 226078 RVA: 0x0075F6CE File Offset: 0x0075D8CE
		public object Value { get; set; }

		// Token: 0x0603731F RID: 226079 RVA: 0x0075F6D7 File Offset: 0x0075D8D7
		public ISystemFunction_UnionUnion()
		{
			this.Type = ISystemFunction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06037320 RID: 226080 RVA: 0x0075F6ED File Offset: 0x0075D8ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037321 RID: 226081 RVA: 0x0075F6FF File Offset: 0x0075D8FF
		public ISystemFunctionT AsISystemFunction()
		{
			return this.As<ISystemFunctionT>();
		}

		// Token: 0x06037322 RID: 226082 RVA: 0x0075F707 File Offset: 0x0075D907
		public static ISystemFunction_UnionUnion FromISystemFunction(ISystemFunctionT _isystemfunction)
		{
			return new ISystemFunction_UnionUnion
			{
				Type = ISystemFunction_Union.ISystemFunction,
				Value = _isystemfunction
			};
		}

		// Token: 0x06037323 RID: 226083 RVA: 0x0075F71C File Offset: 0x0075D91C
		public IBuyGoodsT AsIBuyGoods()
		{
			return this.As<IBuyGoodsT>();
		}

		// Token: 0x06037324 RID: 226084 RVA: 0x0075F724 File Offset: 0x0075D924
		public static ISystemFunction_UnionUnion FromIBuyGoods(IBuyGoodsT _ibuygoods)
		{
			return new ISystemFunction_UnionUnion
			{
				Type = ISystemFunction_Union.IBuyGoods,
				Value = _ibuygoods
			};
		}

		// Token: 0x06037325 RID: 226085 RVA: 0x0075F73C File Offset: 0x0075D93C
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
