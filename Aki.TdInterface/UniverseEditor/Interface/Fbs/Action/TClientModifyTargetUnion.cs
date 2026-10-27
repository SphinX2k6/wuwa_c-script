using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200767B RID: 30331
	public class TClientModifyTargetUnion
	{
		// Token: 0x1700E5E5 RID: 58853
		// (get) Token: 0x0603731A RID: 226074 RVA: 0x0077B3A6 File Offset: 0x007795A6
		// (set) Token: 0x0603731B RID: 226075 RVA: 0x0077B3AE File Offset: 0x007795AE
		public TClientModifyTarget Type { get; set; }

		// Token: 0x1700E5E6 RID: 58854
		// (get) Token: 0x0603731C RID: 226076 RVA: 0x0077B3B7 File Offset: 0x007795B7
		// (set) Token: 0x0603731D RID: 226077 RVA: 0x0077B3BF File Offset: 0x007795BF
		public object Value { get; set; }

		// Token: 0x0603731E RID: 226078 RVA: 0x0077B3C8 File Offset: 0x007795C8
		public TClientModifyTargetUnion()
		{
			this.Type = TClientModifyTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603731F RID: 226079 RVA: 0x0077B3DE File Offset: 0x007795DE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037320 RID: 226080 RVA: 0x0077B3F0 File Offset: 0x007795F0
		public IClientModifyPlayerTargetT AsIClientModifyPlayerTarget()
		{
			return this.As<IClientModifyPlayerTargetT>();
		}

		// Token: 0x06037321 RID: 226081 RVA: 0x0077B3F8 File Offset: 0x007795F8
		public static TClientModifyTargetUnion FromIClientModifyPlayerTarget(IClientModifyPlayerTargetT _iclientmodifyplayertarget)
		{
			return new TClientModifyTargetUnion
			{
				Type = TClientModifyTarget.IClientModifyPlayerTarget,
				Value = _iclientmodifyplayertarget
			};
		}

		// Token: 0x06037322 RID: 226082 RVA: 0x0077B40D File Offset: 0x0077960D
		public IClientModifySelfTargetT AsIClientModifySelfTarget()
		{
			return this.As<IClientModifySelfTargetT>();
		}

		// Token: 0x06037323 RID: 226083 RVA: 0x0077B415 File Offset: 0x00779615
		public static TClientModifyTargetUnion FromIClientModifySelfTarget(IClientModifySelfTargetT _iclientmodifyselftarget)
		{
			return new TClientModifyTargetUnion
			{
				Type = TClientModifyTarget.IClientModifySelfTarget,
				Value = _iclientmodifyselftarget
			};
		}

		// Token: 0x06037324 RID: 226084 RVA: 0x0077B42C File Offset: 0x0077962C
		public static int Pack(FlatBufferBuilder builder, TClientModifyTargetUnion _o)
		{
			TClientModifyTarget type = _o.Type;
			if (type == TClientModifyTarget.IClientModifyPlayerTarget)
			{
				return IClientModifyPlayerTarget.Pack(builder, _o.AsIClientModifyPlayerTarget()).Value;
			}
			if (type != TClientModifyTarget.IClientModifySelfTarget)
			{
				return 0;
			}
			return IClientModifySelfTarget.Pack(builder, _o.AsIClientModifySelfTarget()).Value;
		}
	}
}
