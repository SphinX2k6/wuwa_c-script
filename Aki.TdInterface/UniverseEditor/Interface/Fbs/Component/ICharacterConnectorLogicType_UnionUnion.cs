using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F83 RID: 20355
	public class ICharacterConnectorLogicType_UnionUnion
	{
		// Token: 0x1700931A RID: 37658
		// (get) Token: 0x060204FF RID: 132351 RVA: 0x0047ECF0 File Offset: 0x0047CEF0
		// (set) Token: 0x06020500 RID: 132352 RVA: 0x0047ECF8 File Offset: 0x0047CEF8
		public ICharacterConnectorLogicType_Union Type { get; set; }

		// Token: 0x1700931B RID: 37659
		// (get) Token: 0x06020501 RID: 132353 RVA: 0x0047ED01 File Offset: 0x0047CF01
		// (set) Token: 0x06020502 RID: 132354 RVA: 0x0047ED09 File Offset: 0x0047CF09
		public object Value { get; set; }

		// Token: 0x06020503 RID: 132355 RVA: 0x0047ED12 File Offset: 0x0047CF12
		public ICharacterConnectorLogicType_UnionUnion()
		{
			this.Type = ICharacterConnectorLogicType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020504 RID: 132356 RVA: 0x0047ED28 File Offset: 0x0047CF28
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020505 RID: 132357 RVA: 0x0047ED3A File Offset: 0x0047CF3A
		public ICharacterConnectorLogicTypeT AsICharacterConnectorLogicType()
		{
			return this.As<ICharacterConnectorLogicTypeT>();
		}

		// Token: 0x06020506 RID: 132358 RVA: 0x0047ED42 File Offset: 0x0047CF42
		public static ICharacterConnectorLogicType_UnionUnion FromICharacterConnectorLogicType(ICharacterConnectorLogicTypeT _icharacterconnectorlogictype)
		{
			return new ICharacterConnectorLogicType_UnionUnion
			{
				Type = ICharacterConnectorLogicType_Union.ICharacterConnectorLogicType,
				Value = _icharacterconnectorlogictype
			};
		}

		// Token: 0x06020507 RID: 132359 RVA: 0x0047ED57 File Offset: 0x0047CF57
		public ICharacterConnectorRangeT AsICharacterConnectorRange()
		{
			return this.As<ICharacterConnectorRangeT>();
		}

		// Token: 0x06020508 RID: 132360 RVA: 0x0047ED5F File Offset: 0x0047CF5F
		public static ICharacterConnectorLogicType_UnionUnion FromICharacterConnectorRange(ICharacterConnectorRangeT _icharacterconnectorrange)
		{
			return new ICharacterConnectorLogicType_UnionUnion
			{
				Type = ICharacterConnectorLogicType_Union.ICharacterConnectorRange,
				Value = _icharacterconnectorrange
			};
		}

		// Token: 0x06020509 RID: 132361 RVA: 0x0047ED74 File Offset: 0x0047CF74
		public static int Pack(FlatBufferBuilder builder, ICharacterConnectorLogicType_UnionUnion _o)
		{
			ICharacterConnectorLogicType_Union type = _o.Type;
			if (type == ICharacterConnectorLogicType_Union.ICharacterConnectorLogicType)
			{
				return ICharacterConnectorLogicType.Pack(builder, _o.AsICharacterConnectorLogicType()).Value;
			}
			if (type != ICharacterConnectorLogicType_Union.ICharacterConnectorRange)
			{
				return 0;
			}
			return ICharacterConnectorRange.Pack(builder, _o.AsICharacterConnectorRange()).Value;
		}
	}
}
