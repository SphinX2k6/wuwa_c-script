using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041C1 RID: 16833
	public class ITetrisPlayModeBase_UnionUnion
	{
		// Token: 0x17007758 RID: 30552
		// (get) Token: 0x06018C98 RID: 101528 RVA: 0x0039168D File Offset: 0x0038F88D
		// (set) Token: 0x06018C99 RID: 101529 RVA: 0x00391695 File Offset: 0x0038F895
		public ITetrisPlayModeBase_Union Type { get; set; }

		// Token: 0x17007759 RID: 30553
		// (get) Token: 0x06018C9A RID: 101530 RVA: 0x0039169E File Offset: 0x0038F89E
		// (set) Token: 0x06018C9B RID: 101531 RVA: 0x003916A6 File Offset: 0x0038F8A6
		public object Value { get; set; }

		// Token: 0x06018C9C RID: 101532 RVA: 0x003916AF File Offset: 0x0038F8AF
		public ITetrisPlayModeBase_UnionUnion()
		{
			this.Type = ITetrisPlayModeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018C9D RID: 101533 RVA: 0x003916C5 File Offset: 0x0038F8C5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018C9E RID: 101534 RVA: 0x003916D7 File Offset: 0x0038F8D7
		public ITetrisPlayModeBaseT AsITetrisPlayModeBase()
		{
			return this.As<ITetrisPlayModeBaseT>();
		}

		// Token: 0x06018C9F RID: 101535 RVA: 0x003916DF File Offset: 0x0038F8DF
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeBase(ITetrisPlayModeBaseT _itetrisplaymodebase)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeBase,
				Value = _itetrisplaymodebase
			};
		}

		// Token: 0x06018CA0 RID: 101536 RVA: 0x003916F4 File Offset: 0x0038F8F4
		public ITetrisPlayModeNormalT AsITetrisPlayModeNormal()
		{
			return this.As<ITetrisPlayModeNormalT>();
		}

		// Token: 0x06018CA1 RID: 101537 RVA: 0x003916FC File Offset: 0x0038F8FC
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeNormal(ITetrisPlayModeNormalT _itetrisplaymodenormal)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeNormal,
				Value = _itetrisplaymodenormal
			};
		}

		// Token: 0x06018CA2 RID: 101538 RVA: 0x00391711 File Offset: 0x0038F911
		public ITetrisPlayModeEndlessT AsITetrisPlayModeEndless()
		{
			return this.As<ITetrisPlayModeEndlessT>();
		}

		// Token: 0x06018CA3 RID: 101539 RVA: 0x00391719 File Offset: 0x0038F919
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeEndless(ITetrisPlayModeEndlessT _itetrisplaymodeendless)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeEndless,
				Value = _itetrisplaymodeendless
			};
		}

		// Token: 0x06018CA4 RID: 101540 RVA: 0x0039172E File Offset: 0x0038F92E
		public ITetrisPlayModeMainLineT AsITetrisPlayModeMainLine()
		{
			return this.As<ITetrisPlayModeMainLineT>();
		}

		// Token: 0x06018CA5 RID: 101541 RVA: 0x00391736 File Offset: 0x0038F936
		public static ITetrisPlayModeBase_UnionUnion FromITetrisPlayModeMainLine(ITetrisPlayModeMainLineT _itetrisplaymodemainline)
		{
			return new ITetrisPlayModeBase_UnionUnion
			{
				Type = ITetrisPlayModeBase_Union.ITetrisPlayModeMainLine,
				Value = _itetrisplaymodemainline
			};
		}

		// Token: 0x06018CA6 RID: 101542 RVA: 0x0039174C File Offset: 0x0038F94C
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
