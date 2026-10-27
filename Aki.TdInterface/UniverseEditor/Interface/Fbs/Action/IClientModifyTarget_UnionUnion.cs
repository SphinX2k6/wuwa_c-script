using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063DD RID: 25565
	public class IClientModifyTarget_UnionUnion
	{
		// Token: 0x1700BE6F RID: 48751
		// (get) Token: 0x0602C38B RID: 181131 RVA: 0x00612074 File Offset: 0x00610274
		// (set) Token: 0x0602C38C RID: 181132 RVA: 0x0061207C File Offset: 0x0061027C
		public IClientModifyTarget_Union Type { get; set; }

		// Token: 0x1700BE70 RID: 48752
		// (get) Token: 0x0602C38D RID: 181133 RVA: 0x00612085 File Offset: 0x00610285
		// (set) Token: 0x0602C38E RID: 181134 RVA: 0x0061208D File Offset: 0x0061028D
		public object Value { get; set; }

		// Token: 0x0602C38F RID: 181135 RVA: 0x00612096 File Offset: 0x00610296
		public IClientModifyTarget_UnionUnion()
		{
			this.Type = IClientModifyTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C390 RID: 181136 RVA: 0x006120AC File Offset: 0x006102AC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C391 RID: 181137 RVA: 0x006120BE File Offset: 0x006102BE
		public IClientModifyTargetT AsIClientModifyTarget()
		{
			return this.As<IClientModifyTargetT>();
		}

		// Token: 0x0602C392 RID: 181138 RVA: 0x006120C6 File Offset: 0x006102C6
		public static IClientModifyTarget_UnionUnion FromIClientModifyTarget(IClientModifyTargetT _iclientmodifytarget)
		{
			return new IClientModifyTarget_UnionUnion
			{
				Type = IClientModifyTarget_Union.IClientModifyTarget,
				Value = _iclientmodifytarget
			};
		}

		// Token: 0x0602C393 RID: 181139 RVA: 0x006120DB File Offset: 0x006102DB
		public IClientModifySelfTargetT AsIClientModifySelfTarget()
		{
			return this.As<IClientModifySelfTargetT>();
		}

		// Token: 0x0602C394 RID: 181140 RVA: 0x006120E3 File Offset: 0x006102E3
		public static IClientModifyTarget_UnionUnion FromIClientModifySelfTarget(IClientModifySelfTargetT _iclientmodifyselftarget)
		{
			return new IClientModifyTarget_UnionUnion
			{
				Type = IClientModifyTarget_Union.IClientModifySelfTarget,
				Value = _iclientmodifyselftarget
			};
		}

		// Token: 0x0602C395 RID: 181141 RVA: 0x006120F8 File Offset: 0x006102F8
		public IClientModifyPlayerTargetT AsIClientModifyPlayerTarget()
		{
			return this.As<IClientModifyPlayerTargetT>();
		}

		// Token: 0x0602C396 RID: 181142 RVA: 0x00612100 File Offset: 0x00610300
		public static IClientModifyTarget_UnionUnion FromIClientModifyPlayerTarget(IClientModifyPlayerTargetT _iclientmodifyplayertarget)
		{
			return new IClientModifyTarget_UnionUnion
			{
				Type = IClientModifyTarget_Union.IClientModifyPlayerTarget,
				Value = _iclientmodifyplayertarget
			};
		}

		// Token: 0x0602C397 RID: 181143 RVA: 0x00612118 File Offset: 0x00610318
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
