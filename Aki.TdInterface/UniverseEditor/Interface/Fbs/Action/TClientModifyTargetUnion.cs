using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E89 RID: 32393
	public class TClientModifyTargetUnion
	{
		// Token: 0x1700F223 RID: 61987
		// (get) Token: 0x0603A7C1 RID: 239553 RVA: 0x007DF4F0 File Offset: 0x007DD6F0
		// (set) Token: 0x0603A7C2 RID: 239554 RVA: 0x007DF4F8 File Offset: 0x007DD6F8
		public TClientModifyTarget Type { get; set; }

		// Token: 0x1700F224 RID: 61988
		// (get) Token: 0x0603A7C3 RID: 239555 RVA: 0x007DF501 File Offset: 0x007DD701
		// (set) Token: 0x0603A7C4 RID: 239556 RVA: 0x007DF509 File Offset: 0x007DD709
		public object Value { get; set; }

		// Token: 0x0603A7C5 RID: 239557 RVA: 0x007DF512 File Offset: 0x007DD712
		public TClientModifyTargetUnion()
		{
			this.Type = TClientModifyTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7C6 RID: 239558 RVA: 0x007DF528 File Offset: 0x007DD728
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7C7 RID: 239559 RVA: 0x007DF53A File Offset: 0x007DD73A
		public IClientModifyPlayerTargetT AsIClientModifyPlayerTarget()
		{
			return this.As<IClientModifyPlayerTargetT>();
		}

		// Token: 0x0603A7C8 RID: 239560 RVA: 0x007DF542 File Offset: 0x007DD742
		public static TClientModifyTargetUnion FromIClientModifyPlayerTarget(IClientModifyPlayerTargetT _iclientmodifyplayertarget)
		{
			return new TClientModifyTargetUnion
			{
				Type = TClientModifyTarget.IClientModifyPlayerTarget,
				Value = _iclientmodifyplayertarget
			};
		}

		// Token: 0x0603A7C9 RID: 239561 RVA: 0x007DF557 File Offset: 0x007DD757
		public IClientModifySelfTargetT AsIClientModifySelfTarget()
		{
			return this.As<IClientModifySelfTargetT>();
		}

		// Token: 0x0603A7CA RID: 239562 RVA: 0x007DF55F File Offset: 0x007DD75F
		public static TClientModifyTargetUnion FromIClientModifySelfTarget(IClientModifySelfTargetT _iclientmodifyselftarget)
		{
			return new TClientModifyTargetUnion
			{
				Type = TClientModifyTarget.IClientModifySelfTarget,
				Value = _iclientmodifyselftarget
			};
		}

		// Token: 0x0603A7CB RID: 239563 RVA: 0x007DF574 File Offset: 0x007DD774
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
