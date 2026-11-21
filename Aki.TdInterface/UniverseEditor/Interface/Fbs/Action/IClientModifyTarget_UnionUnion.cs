using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5D RID: 27229
	public class IClientModifyTarget_UnionUnion
	{
		// Token: 0x1700C809 RID: 51209
		// (get) Token: 0x0602EB61 RID: 191329 RVA: 0x0065DF00 File Offset: 0x0065C100
		// (set) Token: 0x0602EB62 RID: 191330 RVA: 0x0065DF08 File Offset: 0x0065C108
		public IClientModifyTarget_Union Type { get; set; }

		// Token: 0x1700C80A RID: 51210
		// (get) Token: 0x0602EB63 RID: 191331 RVA: 0x0065DF11 File Offset: 0x0065C111
		// (set) Token: 0x0602EB64 RID: 191332 RVA: 0x0065DF19 File Offset: 0x0065C119
		public object Value { get; set; }

		// Token: 0x0602EB65 RID: 191333 RVA: 0x0065DF22 File Offset: 0x0065C122
		public IClientModifyTarget_UnionUnion()
		{
			this.Type = IClientModifyTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EB66 RID: 191334 RVA: 0x0065DF38 File Offset: 0x0065C138
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EB67 RID: 191335 RVA: 0x0065DF4A File Offset: 0x0065C14A
		public IClientModifyTargetT AsIClientModifyTarget()
		{
			return this.As<IClientModifyTargetT>();
		}

		// Token: 0x0602EB68 RID: 191336 RVA: 0x0065DF52 File Offset: 0x0065C152
		public static IClientModifyTarget_UnionUnion FromIClientModifyTarget(IClientModifyTargetT _iclientmodifytarget)
		{
			return new IClientModifyTarget_UnionUnion
			{
				Type = IClientModifyTarget_Union.IClientModifyTarget,
				Value = _iclientmodifytarget
			};
		}

		// Token: 0x0602EB69 RID: 191337 RVA: 0x0065DF67 File Offset: 0x0065C167
		public IClientModifySelfTargetT AsIClientModifySelfTarget()
		{
			return this.As<IClientModifySelfTargetT>();
		}

		// Token: 0x0602EB6A RID: 191338 RVA: 0x0065DF6F File Offset: 0x0065C16F
		public static IClientModifyTarget_UnionUnion FromIClientModifySelfTarget(IClientModifySelfTargetT _iclientmodifyselftarget)
		{
			return new IClientModifyTarget_UnionUnion
			{
				Type = IClientModifyTarget_Union.IClientModifySelfTarget,
				Value = _iclientmodifyselftarget
			};
		}

		// Token: 0x0602EB6B RID: 191339 RVA: 0x0065DF84 File Offset: 0x0065C184
		public IClientModifyPlayerTargetT AsIClientModifyPlayerTarget()
		{
			return this.As<IClientModifyPlayerTargetT>();
		}

		// Token: 0x0602EB6C RID: 191340 RVA: 0x0065DF8C File Offset: 0x0065C18C
		public static IClientModifyTarget_UnionUnion FromIClientModifyPlayerTarget(IClientModifyPlayerTargetT _iclientmodifyplayertarget)
		{
			return new IClientModifyTarget_UnionUnion
			{
				Type = IClientModifyTarget_Union.IClientModifyPlayerTarget,
				Value = _iclientmodifyplayertarget
			};
		}

		// Token: 0x0602EB6D RID: 191341 RVA: 0x0065DFA4 File Offset: 0x0065C1A4
		public static int Pack(FlatBufferBuilder builder, IClientModifyTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientModifyTarget_Union.IClientModifyTarget:
				return IClientModifyTarget.Pack(builder, _o.AsIClientModifyTarget()).Value;
			case IClientModifyTarget_Union.IClientModifySelfTarget:
				return IClientModifySelfTarget.Pack(builder, _o.AsIClientModifySelfTarget()).Value;
			case IClientModifyTarget_Union.IClientModifyPlayerTarget:
				return IClientModifyPlayerTarget.Pack(builder, _o.AsIClientModifyPlayerTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
