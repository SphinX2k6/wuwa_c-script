using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200620A RID: 25098
	public class IBlendAnimTargetBase_UnionUnion
	{
		// Token: 0x1700BB13 RID: 47891
		// (get) Token: 0x0602B437 RID: 177207 RVA: 0x005F5BA9 File Offset: 0x005F3DA9
		// (set) Token: 0x0602B438 RID: 177208 RVA: 0x005F5BB1 File Offset: 0x005F3DB1
		public IBlendAnimTargetBase_Union Type { get; set; }

		// Token: 0x1700BB14 RID: 47892
		// (get) Token: 0x0602B439 RID: 177209 RVA: 0x005F5BBA File Offset: 0x005F3DBA
		// (set) Token: 0x0602B43A RID: 177210 RVA: 0x005F5BC2 File Offset: 0x005F3DC2
		public object Value { get; set; }

		// Token: 0x0602B43B RID: 177211 RVA: 0x005F5BCB File Offset: 0x005F3DCB
		public IBlendAnimTargetBase_UnionUnion()
		{
			this.Type = IBlendAnimTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B43C RID: 177212 RVA: 0x005F5BE1 File Offset: 0x005F3DE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B43D RID: 177213 RVA: 0x005F5BF3 File Offset: 0x005F3DF3
		public IBlendAnimTargetBaseT AsIBlendAnimTargetBase()
		{
			return this.As<IBlendAnimTargetBaseT>();
		}

		// Token: 0x0602B43E RID: 177214 RVA: 0x005F5BFB File Offset: 0x005F3DFB
		public static IBlendAnimTargetBase_UnionUnion FromIBlendAnimTargetBase(IBlendAnimTargetBaseT _iblendanimtargetbase)
		{
			return new IBlendAnimTargetBase_UnionUnion
			{
				Type = IBlendAnimTargetBase_Union.IBlendAnimTargetBase,
				Value = _iblendanimtargetbase
			};
		}

		// Token: 0x0602B43F RID: 177215 RVA: 0x005F5C10 File Offset: 0x005F3E10
		public IPlayerBlendAnimTargetT AsIPlayerBlendAnimTarget()
		{
			return this.As<IPlayerBlendAnimTargetT>();
		}

		// Token: 0x0602B440 RID: 177216 RVA: 0x005F5C18 File Offset: 0x005F3E18
		public static IBlendAnimTargetBase_UnionUnion FromIPlayerBlendAnimTarget(IPlayerBlendAnimTargetT _iplayerblendanimtarget)
		{
			return new IBlendAnimTargetBase_UnionUnion
			{
				Type = IBlendAnimTargetBase_Union.IPlayerBlendAnimTarget,
				Value = _iplayerblendanimtarget
			};
		}

		// Token: 0x0602B441 RID: 177217 RVA: 0x005F5C30 File Offset: 0x005F3E30
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
