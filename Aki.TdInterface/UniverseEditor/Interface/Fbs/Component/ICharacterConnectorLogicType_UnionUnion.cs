using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B2 RID: 21682
	public class ICharacterConnectorLogicType_UnionUnion
	{
		// Token: 0x17009A93 RID: 39571
		// (get) Token: 0x06022251 RID: 139857 RVA: 0x004B4CE0 File Offset: 0x004B2EE0
		// (set) Token: 0x06022252 RID: 139858 RVA: 0x004B4CE8 File Offset: 0x004B2EE8
		public ICharacterConnectorLogicType_Union Type { get; set; }

		// Token: 0x17009A94 RID: 39572
		// (get) Token: 0x06022253 RID: 139859 RVA: 0x004B4CF1 File Offset: 0x004B2EF1
		// (set) Token: 0x06022254 RID: 139860 RVA: 0x004B4CF9 File Offset: 0x004B2EF9
		public object Value { get; set; }

		// Token: 0x06022255 RID: 139861 RVA: 0x004B4D02 File Offset: 0x004B2F02
		public ICharacterConnectorLogicType_UnionUnion()
		{
			this.Type = ICharacterConnectorLogicType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022256 RID: 139862 RVA: 0x004B4D18 File Offset: 0x004B2F18
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022257 RID: 139863 RVA: 0x004B4D2A File Offset: 0x004B2F2A
		public ICharacterConnectorLogicTypeT AsICharacterConnectorLogicType()
		{
			return this.As<ICharacterConnectorLogicTypeT>();
		}

		// Token: 0x06022258 RID: 139864 RVA: 0x004B4D32 File Offset: 0x004B2F32
		public static ICharacterConnectorLogicType_UnionUnion FromICharacterConnectorLogicType(ICharacterConnectorLogicTypeT _icharacterconnectorlogictype)
		{
			return new ICharacterConnectorLogicType_UnionUnion
			{
				Type = ICharacterConnectorLogicType_Union.ICharacterConnectorLogicType,
				Value = _icharacterconnectorlogictype
			};
		}

		// Token: 0x06022259 RID: 139865 RVA: 0x004B4D47 File Offset: 0x004B2F47
		public ICharacterConnectorRangeT AsICharacterConnectorRange()
		{
			return this.As<ICharacterConnectorRangeT>();
		}

		// Token: 0x0602225A RID: 139866 RVA: 0x004B4D4F File Offset: 0x004B2F4F
		public static ICharacterConnectorLogicType_UnionUnion FromICharacterConnectorRange(ICharacterConnectorRangeT _icharacterconnectorrange)
		{
			return new ICharacterConnectorLogicType_UnionUnion
			{
				Type = ICharacterConnectorLogicType_Union.ICharacterConnectorRange,
				Value = _icharacterconnectorrange
			};
		}

		// Token: 0x0602225B RID: 139867 RVA: 0x004B4D64 File Offset: 0x004B2F64
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
