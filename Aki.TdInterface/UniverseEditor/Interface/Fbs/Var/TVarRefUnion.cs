using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F68 RID: 16232
	public class TVarRefUnion
	{
		// Token: 0x17006DC9 RID: 28105
		// (get) Token: 0x06016169 RID: 90473 RVA: 0x0032B83E File Offset: 0x00329A3E
		// (set) Token: 0x0601616A RID: 90474 RVA: 0x0032B846 File Offset: 0x00329A46
		public TVarRef Type { get; set; }

		// Token: 0x17006DCA RID: 28106
		// (get) Token: 0x0601616B RID: 90475 RVA: 0x0032B84F File Offset: 0x00329A4F
		// (set) Token: 0x0601616C RID: 90476 RVA: 0x0032B857 File Offset: 0x00329A57
		public object Value { get; set; }

		// Token: 0x0601616D RID: 90477 RVA: 0x0032B860 File Offset: 0x00329A60
		public TVarRefUnion()
		{
			this.Type = TVarRef.NONE;
			this.Value = null;
		}

		// Token: 0x0601616E RID: 90478 RVA: 0x0032B876 File Offset: 0x00329A76
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601616F RID: 90479 RVA: 0x0032B888 File Offset: 0x00329A88
		public IConstVarRefT AsIConstVarRef()
		{
			return this.As<IConstVarRefT>();
		}

		// Token: 0x06016170 RID: 90480 RVA: 0x0032B890 File Offset: 0x00329A90
		public static TVarRefUnion FromIConstVarRef(IConstVarRefT _iconstvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.IConstVarRef,
				Value = _iconstvarref
			};
		}

		// Token: 0x06016171 RID: 90481 RVA: 0x0032B8A5 File Offset: 0x00329AA5
		public IGlobalVarRefT AsIGlobalVarRef()
		{
			return this.As<IGlobalVarRefT>();
		}

		// Token: 0x06016172 RID: 90482 RVA: 0x0032B8AD File Offset: 0x00329AAD
		public static TVarRefUnion FromIGlobalVarRef(IGlobalVarRefT _iglobalvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.IGlobalVarRef,
				Value = _iglobalvarref
			};
		}

		// Token: 0x06016173 RID: 90483 RVA: 0x0032B8C2 File Offset: 0x00329AC2
		public IOtherVarRefT AsIOtherVarRef()
		{
			return this.As<IOtherVarRefT>();
		}

		// Token: 0x06016174 RID: 90484 RVA: 0x0032B8CA File Offset: 0x00329ACA
		public static TVarRefUnion FromIOtherVarRef(IOtherVarRefT _iothervarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.IOtherVarRef,
				Value = _iothervarref
			};
		}

		// Token: 0x06016175 RID: 90485 RVA: 0x0032B8DF File Offset: 0x00329ADF
		public ISelfVarRefT AsISelfVarRef()
		{
			return this.As<ISelfVarRefT>();
		}

		// Token: 0x06016176 RID: 90486 RVA: 0x0032B8E7 File Offset: 0x00329AE7
		public static TVarRefUnion FromISelfVarRef(ISelfVarRefT _iselfvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.ISelfVarRef,
				Value = _iselfvarref
			};
		}

		// Token: 0x06016177 RID: 90487 RVA: 0x0032B8FC File Offset: 0x00329AFC
		public ISystemVarRefT AsISystemVarRef()
		{
			return this.As<ISystemVarRefT>();
		}

		// Token: 0x06016178 RID: 90488 RVA: 0x0032B904 File Offset: 0x00329B04
		public static TVarRefUnion FromISystemVarRef(ISystemVarRefT _isystemvarref)
		{
			return new TVarRefUnion
			{
				Type = TVarRef.ISystemVarRef,
				Value = _isystemvarref
			};
		}

		// Token: 0x06016179 RID: 90489 RVA: 0x0032B91C File Offset: 0x00329B1C
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
