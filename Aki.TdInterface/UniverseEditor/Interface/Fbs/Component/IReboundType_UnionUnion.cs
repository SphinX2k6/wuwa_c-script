using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E19 RID: 24089
	public class IReboundType_UnionUnion
	{
		// Token: 0x1700B18F RID: 45455
		// (get) Token: 0x06028397 RID: 164759 RVA: 0x00580305 File Offset: 0x0057E505
		// (set) Token: 0x06028398 RID: 164760 RVA: 0x0058030D File Offset: 0x0057E50D
		public IReboundType_Union Type { get; set; }

		// Token: 0x1700B190 RID: 45456
		// (get) Token: 0x06028399 RID: 164761 RVA: 0x00580316 File Offset: 0x0057E516
		// (set) Token: 0x0602839A RID: 164762 RVA: 0x0058031E File Offset: 0x0057E51E
		public object Value { get; set; }

		// Token: 0x0602839B RID: 164763 RVA: 0x00580327 File Offset: 0x0057E527
		public IReboundType_UnionUnion()
		{
			this.Type = IReboundType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602839C RID: 164764 RVA: 0x0058033D File Offset: 0x0057E53D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602839D RID: 164765 RVA: 0x0058034F File Offset: 0x0057E54F
		public IReboundTypeT AsIReboundType()
		{
			return this.As<IReboundTypeT>();
		}

		// Token: 0x0602839E RID: 164766 RVA: 0x00580357 File Offset: 0x0057E557
		public static IReboundType_UnionUnion FromIReboundType(IReboundTypeT _ireboundtype)
		{
			return new IReboundType_UnionUnion
			{
				Type = IReboundType_Union.IReboundType,
				Value = _ireboundtype
			};
		}

		// Token: 0x0602839F RID: 164767 RVA: 0x0058036C File Offset: 0x0057E56C
		public IForwardFrontReboundT AsIForwardFrontRebound()
		{
			return this.As<IForwardFrontReboundT>();
		}

		// Token: 0x060283A0 RID: 164768 RVA: 0x00580374 File Offset: 0x0057E574
		public static IReboundType_UnionUnion FromIForwardFrontRebound(IForwardFrontReboundT _iforwardfrontrebound)
		{
			return new IReboundType_UnionUnion
			{
				Type = IReboundType_Union.IForwardFrontRebound,
				Value = _iforwardfrontrebound
			};
		}

		// Token: 0x060283A1 RID: 164769 RVA: 0x0058038C File Offset: 0x0057E58C
		public static int Pack(FlatBufferBuilder builder, IReboundType_UnionUnion _o)
		{
			IReboundType_Union type = _o.Type;
			if (type == IReboundType_Union.IReboundType)
			{
				return IReboundType.Pack(builder, _o.AsIReboundType()).Value;
			}
			if (type != IReboundType_Union.IForwardFrontRebound)
			{
				return 0;
			}
			return IForwardFrontRebound.Pack(builder, _o.AsIForwardFrontRebound()).Value;
		}
	}
}
