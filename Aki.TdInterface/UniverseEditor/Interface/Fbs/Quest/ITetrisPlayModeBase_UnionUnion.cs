using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200461A RID: 17946
	public class ITetrisPlayModeBase_UnionUnion
	{
		// Token: 0x17007D84 RID: 32132
		// (get) Token: 0x0601A3EE RID: 107502 RVA: 0x003BCAE1 File Offset: 0x003BACE1
		// (set) Token: 0x0601A3EF RID: 107503 RVA: 0x003BCAE9 File Offset: 0x003BACE9
		public ITetrisPlayModeBase_Union Type { get; set; }

		// Token: 0x17007D85 RID: 32133
		// (get) Token: 0x0601A3F0 RID: 107504 RVA: 0x003BCAF2 File Offset: 0x003BACF2
		// (set) Token: 0x0601A3F1 RID: 107505 RVA: 0x003BCAFA File Offset: 0x003BACFA
		public object Value { get; set; }

		// Token: 0x0601A3F2 RID: 107506 RVA: 0x003BCB03 File Offset: 0x003BAD03
		public ITetrisPlayModeBase_UnionUnion()
		{
			this.Type = ITetrisPlayModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A3F3 RID: 107507 RVA: 0x003BCB19 File Offset: 0x003BAD19
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A3F4 RID: 107508 RVA: 0x003BCB2B File Offset: 0x003BAD2B
		public ITetrisPlayModeBaseT AsITetrisPlayModeBase()
		{
			return this.As<ITetrisPlayModeBaseT>();
		}

		// Token: 0x0601A3F5 RID: 107509 RVA: 0x003BCB33 File Offset: 0x003BAD33
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeBase(ITetrisPlayModeBaseT _itetrisplaymodebase)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeBase,
				Value = _itetrisplaymodebase
			};
		}

		// Token: 0x0601A3F6 RID: 107510 RVA: 0x003BCB48 File Offset: 0x003BAD48
		public ITetrisPlayModeNormalT AsITetrisPlayModeNormal()
		{
			return this.As<ITetrisPlayModeNormalT>();
		}

		// Token: 0x0601A3F7 RID: 107511 RVA: 0x003BCB50 File Offset: 0x003BAD50
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeNormal(ITetrisPlayModeNormalT _itetrisplaymodenormal)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeNormal,
				Value = _itetrisplaymodenormal
			};
		}

		// Token: 0x0601A3F8 RID: 107512 RVA: 0x003BCB65 File Offset: 0x003BAD65
		public ITetrisPlayModeEndlessT AsITetrisPlayModeEndless()
		{
			return this.As<ITetrisPlayModeEndlessT>();
		}

		// Token: 0x0601A3F9 RID: 107513 RVA: 0x003BCB6D File Offset: 0x003BAD6D
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeEndless(ITetrisPlayModeEndlessT _itetrisplaymodeendless)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeEndless,
				Value = _itetrisplaymodeendless
			};
		}

		// Token: 0x0601A3FA RID: 107514 RVA: 0x003BCB82 File Offset: 0x003BAD82
		public ITetrisPlayModeMainLineT AsITetrisPlayModeMainLine()
		{
			return this.As<ITetrisPlayModeMainLineT>();
		}

		// Token: 0x0601A3FB RID: 107515 RVA: 0x003BCB8A File Offset: 0x003BAD8A
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeMainLine(ITetrisPlayModeMainLineT _itetrisplaymodemainline)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeMainLine,
				Value = _itetrisplaymodemainline
			};
		}

		// Token: 0x0601A3FC RID: 107516 RVA: 0x003BCBA0 File Offset: 0x003BADA0
		public static int Pack(FlatBufferBuilder builder, ITetrisPlayModeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITetrisPlayModeBase_Union.ITetrisPlayModeBase:
				return ITetrisPlayModeBase.Pack(builder, _o.AsITetrisPlayModeBase()).Value;
			case ITetrisPlayModeBase_Union.ITetrisPlayModeNormal:
				return ITetrisPlayModeNormal.Pack(builder, _o.AsITetrisPlayModeNormal()).Value;
			case ITetrisPlayModeBase_Union.ITetrisPlayModeEndless:
				return ITetrisPlayModeEndless.Pack(builder, _o.AsITetrisPlayModeEndless()).Value;
			case ITetrisPlayModeBase_Union.ITetrisPlayModeMainLine:
				return ITetrisPlayModeMainLine.Pack(builder, _o.AsITetrisPlayModeMainLine()).Value;
			default:
				return 0;
			}
		}
	}
}
