using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B60 RID: 15200
	public class TVarRefUnion
	{
		// Token: 0x1700682A RID: 26666
		// (get) Token: 0x06014C9F RID: 85151 RVA: 0x003052A6 File Offset: 0x003034A6
		// (set) Token: 0x06014CA0 RID: 85152 RVA: 0x003052AE File Offset: 0x003034AE
		public TVarRef Type { get; set; }

		// Token: 0x1700682B RID: 26667
		// (get) Token: 0x06014CA1 RID: 85153 RVA: 0x003052B7 File Offset: 0x003034B7
		// (set) Token: 0x06014CA2 RID: 85154 RVA: 0x003052BF File Offset: 0x003034BF
		public object Value { get; set; }

		// Token: 0x06014CA3 RID: 85155 RVA: 0x003052C8 File Offset: 0x003034C8
		public TVarRefUnion()
		{
			this.Type = TVarRef.NONE;
			this.Value = null;
		}

		// Token: 0x06014CA4 RID: 85156 RVA: 0x003052DE File Offset: 0x003034DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014CA5 RID: 85157 RVA: 0x003052F0 File Offset: 0x003034F0
		public IConstVarRefT AsIConstVarRef()
		{
			return this.As<IConstVarRefT>();
		}

		// Token: 0x06014CA6 RID: 85158 RVA: 0x003052F8 File Offset: 0x003034F8
		public static TVarRefUnion FromIConstVarRef(IConstVarRefT _iconstvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.IConstVarRef,
				Value = _iconstvarref
			};
		}

		// Token: 0x06014CA7 RID: 85159 RVA: 0x0030530D File Offset: 0x0030350D
		public IGlobalVarRefT AsIGlobalVarRef()
		{
			return this.As<IGlobalVarRefT>();
		}

		// Token: 0x06014CA8 RID: 85160 RVA: 0x00305315 File Offset: 0x00303515
		public static TVarRefUnion FromIGlobalVarRef(IGlobalVarRefT _iglobalvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.IGlobalVarRef,
				Value = _iglobalvarref
			};
		}

		// Token: 0x06014CA9 RID: 85161 RVA: 0x0030532A File Offset: 0x0030352A
		public IOtherVarRefT AsIOtherVarRef()
		{
			return this.As<IOtherVarRefT>();
		}

		// Token: 0x06014CAA RID: 85162 RVA: 0x00305332 File Offset: 0x00303532
		public static TVarRefUnion FromIOtherVarRef(IOtherVarRefT _iothervarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.IOtherVarRef,
				Value = _iothervarref
			};
		}

		// Token: 0x06014CAB RID: 85163 RVA: 0x00305347 File Offset: 0x00303547
		public ISelfVarRefT AsISelfVarRef()
		{
			return this.As<ISelfVarRefT>();
		}

		// Token: 0x06014CAC RID: 85164 RVA: 0x0030534F File Offset: 0x0030354F
		public static TVarRefUnion FromISelfVarRef(ISelfVarRefT _iselfvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.ISelfVarRef,
				Value = _iselfvarref
			};
		}

		// Token: 0x06014CAD RID: 85165 RVA: 0x00305364 File Offset: 0x00303564
		public ISystemVarRefT AsISystemVarRef()
		{
			return this.As<ISystemVarRefT>();
		}

		// Token: 0x06014CAE RID: 85166 RVA: 0x0030536C File Offset: 0x0030356C
		public static TVarRefUnion FromISystemVarRef(ISystemVarRefT _isystemvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.ISystemVarRef,
				Value = _isystemvarref
			};
		}

		// Token: 0x06014CAF RID: 85167 RVA: 0x00305384 File Offset: 0x00303584
		public static int Pack(FlatBufferBuilder builder, TVarRefUnion _o)
		{
			switch (_o.Type)
			{
			case TVarRef.IConstVarRef:
				return IConstVarRef.Pack(builder, _o.AsIConstVarRef()).Value;
			case TVarRef.IGlobalVarRef:
				return IGlobalVarRef.Pack(builder, _o.AsIGlobalVarRef()).Value;
			case TVarRef.IOtherVarRef:
				return IOtherVarRef.Pack(builder, _o.AsIOtherVarRef()).Value;
			case TVarRef.ISelfVarRef:
				return ISelfVarRef.Pack(builder, _o.AsISelfVarRef()).Value;
			case TVarRef.ISystemVarRef:
				return ISystemVarRef.Pack(builder, _o.AsISystemVarRef()).Value;
			default:
				return 0;
			}
		}
	}
}
