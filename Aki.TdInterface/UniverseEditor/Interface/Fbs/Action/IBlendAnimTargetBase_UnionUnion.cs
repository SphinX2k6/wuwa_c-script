using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687B RID: 26747
	public class IBlendAnimTargetBase_UnionUnion
	{
		// Token: 0x1700C499 RID: 50329
		// (get) Token: 0x0602DB90 RID: 187280 RVA: 0x00640795 File Offset: 0x0063E995
		// (set) Token: 0x0602DB91 RID: 187281 RVA: 0x0064079D File Offset: 0x0063E99D
		public IBlendAnimTargetBase_Union Type { get; set; }

		// Token: 0x1700C49A RID: 50330
		// (get) Token: 0x0602DB92 RID: 187282 RVA: 0x006407A6 File Offset: 0x0063E9A6
		// (set) Token: 0x0602DB93 RID: 187283 RVA: 0x006407AE File Offset: 0x0063E9AE
		public object Value { get; set; }

		// Token: 0x0602DB94 RID: 187284 RVA: 0x006407B7 File Offset: 0x0063E9B7
		public IBlendAnimTargetBase_UnionUnion()
		{
			this.Type = IBlendAnimTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DB95 RID: 187285 RVA: 0x006407CD File Offset: 0x0063E9CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DB96 RID: 187286 RVA: 0x006407DF File Offset: 0x0063E9DF
		public IBlendAnimTargetBaseT AsIBlendAnimTargetBase()
		{
			return this.As<IBlendAnimTargetBaseT>();
		}

		// Token: 0x0602DB97 RID: 187287 RVA: 0x006407E7 File Offset: 0x0063E9E7
		public static IBlendAnimTargetBase_UnionUnion FromIBlendAnimTargetBase(IBlendAnimTargetBaseT _iblendanimtargetbase)
		{
			return new IBlendAnimTargetBase_UnionUnion
			{
				Type = IBlendAnimTargetBase_Union.IBlendAnimTargetBase,
				Value = _iblendanimtargetbase
			};
		}

		// Token: 0x0602DB98 RID: 187288 RVA: 0x006407FC File Offset: 0x0063E9FC
		public IPlayerBlendAnimTargetT AsIPlayerBlendAnimTarget()
		{
			return this.As<IPlayerBlendAnimTargetT>();
		}

		// Token: 0x0602DB99 RID: 187289 RVA: 0x00640804 File Offset: 0x0063EA04
		public static IBlendAnimTargetBase_UnionUnion FromIPlayerBlendAnimTarget(IPlayerBlendAnimTargetT _iplayerblendanimtarget)
		{
			return new IBlendAnimTargetBase_UnionUnion
			{
				Type = IBlendAnimTargetBase_Union.IPlayerBlendAnimTarget,
				Value = _iplayerblendanimtarget
			};
		}

		// Token: 0x0602DB9A RID: 187290 RVA: 0x0064081C File Offset: 0x0063EA1C
		public static int Pack(FlatBufferBuilder builder, IBlendAnimTargetBase_UnionUnion _o)
		{
			IBlendAnimTargetBase_Union type = _o.Type;
			if (type == IBlendAnimTargetBase_Union.IBlendAnimTargetBase)
			{
				return IBlendAnimTargetBase.Pack(builder, _o.AsIBlendAnimTargetBase()).Value;
			}
			if (type != IBlendAnimTargetBase_Union.IPlayerBlendAnimTarget)
			{
				return 0;
			}
			return IPlayerBlendAnimTarget.Pack(builder, _o.AsIPlayerBlendAnimTarget()).Value;
		}
	}
}
