using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004786 RID: 18310
	public class TTetrisPlayModeUnion
	{
		// Token: 0x17007FAF RID: 32687
		// (get) Token: 0x0601AF5F RID: 110431 RVA: 0x003D2742 File Offset: 0x003D0942
		// (set) Token: 0x0601AF60 RID: 110432 RVA: 0x003D274A File Offset: 0x003D094A
		public TTetrisPlayMode Type { get; set; }

		// Token: 0x17007FB0 RID: 32688
		// (get) Token: 0x0601AF61 RID: 110433 RVA: 0x003D2753 File Offset: 0x003D0953
		// (set) Token: 0x0601AF62 RID: 110434 RVA: 0x003D275B File Offset: 0x003D095B
		public object Value { get; set; }

		// Token: 0x0601AF63 RID: 110435 RVA: 0x003D2764 File Offset: 0x003D0964
		public TTetrisPlayModeUnion()
		{
			this.Type = TTetrisPlayMode.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF64 RID: 110436 RVA: 0x003D277A File Offset: 0x003D097A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF65 RID: 110437 RVA: 0x003D278C File Offset: 0x003D098C
		public ITetrisPlayModeEndlessT AsITetrisPlayModeEndless()
		{
			return this.As<ITetrisPlayModeEndlessT>();
		}

		// Token: 0x0601AF66 RID: 110438 RVA: 0x003D2794 File Offset: 0x003D0994
		public static TTetrisPlayModeUnion FromITetrisPlayModeEndless(ITetrisPlayModeEndlessT _itetrisplaymodeendless)
		{
			return new TTetrisPlayModeUnion
			{
				Type = TTetrisPlayMode.ITetrisPlayModeEndless,
				Value = _itetrisplaymodeendless
			};
		}

		// Token: 0x0601AF67 RID: 110439 RVA: 0x003D27A9 File Offset: 0x003D09A9
		public ITetrisPlayModeMainLineT AsITetrisPlayModeMainLine()
		{
			return this.As<ITetrisPlayModeMainLineT>();
		}

		// Token: 0x0601AF68 RID: 110440 RVA: 0x003D27B1 File Offset: 0x003D09B1
		public static TTetrisPlayModeUnion FromITetrisPlayModeMainLine(ITetrisPlayModeMainLineT _itetrisplaymodemainline)
		{
			return new TTetrisPlayModeUnion
			{
				Type = TTetrisPlayMode.ITetrisPlayModeMainLine,
				Value = _itetrisplaymodemainline
			};
		}

		// Token: 0x0601AF69 RID: 110441 RVA: 0x003D27C6 File Offset: 0x003D09C6
		public ITetrisPlayModeNormalT AsITetrisPlayModeNormal()
		{
			return this.As<ITetrisPlayModeNormalT>();
		}

		// Token: 0x0601AF6A RID: 110442 RVA: 0x003D27CE File Offset: 0x003D09CE
		public static TTetrisPlayModeUnion FromITetrisPlayModeNormal(ITetrisPlayModeNormalT _itetrisplaymodenormal)
		{
			return new TTetrisPlayModeUnion
			{
				Type = TTetrisPlayMode.ITetrisPlayModeNormal,
				Value = _itetrisplaymodenormal
			};
		}

		// Token: 0x0601AF6B RID: 110443 RVA: 0x003D27E4 File Offset: 0x003D09E4
		public static int Pack(FlatBufferBuilder builder, TTetrisPlayModeUnion _o)
		{
			switch (_o.Type)
			{
			case TTetrisPlayMode.ITetrisPlayModeEndless:
				return ITetrisPlayModeEndless.Pack(builder, _o.AsITetrisPlayModeEndless()).Value;
			case TTetrisPlayMode.ITetrisPlayModeMainLine:
				return ITetrisPlayModeMainLine.Pack(builder, _o.AsITetrisPlayModeMainLine()).Value;
			case TTetrisPlayMode.ITetrisPlayModeNormal:
				return ITetrisPlayModeNormal.Pack(builder, _o.AsITetrisPlayModeNormal()).Value;
			default:
				return 0;
			}
		}
	}
}
