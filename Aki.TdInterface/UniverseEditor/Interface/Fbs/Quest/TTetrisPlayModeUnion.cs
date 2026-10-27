using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004324 RID: 17188
	public class TTetrisPlayModeUnion
	{
		// Token: 0x1700797A RID: 31098
		// (get) Token: 0x060197D1 RID: 104401 RVA: 0x003A6D1A File Offset: 0x003A4F1A
		// (set) Token: 0x060197D2 RID: 104402 RVA: 0x003A6D22 File Offset: 0x003A4F22
		public TTetrisPlayMode Type { get; set; }

		// Token: 0x1700797B RID: 31099
		// (get) Token: 0x060197D3 RID: 104403 RVA: 0x003A6D2B File Offset: 0x003A4F2B
		// (set) Token: 0x060197D4 RID: 104404 RVA: 0x003A6D33 File Offset: 0x003A4F33
		public object Value { get; set; }

		// Token: 0x060197D5 RID: 104405 RVA: 0x003A6D3C File Offset: 0x003A4F3C
		public TTetrisPlayModeUnion()
		{
			this.Type = TTetrisPlayMode.NONE;
			this.Value = null;
		}

		// Token: 0x060197D6 RID: 104406 RVA: 0x003A6D52 File Offset: 0x003A4F52
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060197D7 RID: 104407 RVA: 0x003A6D64 File Offset: 0x003A4F64
		public ITetrisPlayModeEndlessT AsITetrisPlayModeEndless()
		{
			return this.As<ITetrisPlayModeEndlessT>();
		}

		// Token: 0x060197D8 RID: 104408 RVA: 0x003A6D6C File Offset: 0x003A4F6C
		public static TTetrisPlayModeUnion FromITetrisPlayModeEndless(ITetrisPlayModeEndlessT _itetrisplaymodeendless)
		{
			return new TTetrisPlayModeUnion
			{
				Type = TTetrisPlayMode.ITetrisPlayModeEndless,
				Value = _itetrisplaymodeendless
			};
		}

		// Token: 0x060197D9 RID: 104409 RVA: 0x003A6D81 File Offset: 0x003A4F81
		public ITetrisPlayModeMainLineT AsITetrisPlayModeMainLine()
		{
			return this.As<ITetrisPlayModeMainLineT>();
		}

		// Token: 0x060197DA RID: 104410 RVA: 0x003A6D89 File Offset: 0x003A4F89
		public static TTetrisPlayModeUnion FromITetrisPlayModeMainLine(ITetrisPlayModeMainLineT _itetrisplaymodemainline)
		{
			return new TTetrisPlayModeUnion
			{
				Type = TTetrisPlayMode.ITetrisPlayModeMainLine,
				Value = _itetrisplaymodemainline
			};
		}

		// Token: 0x060197DB RID: 104411 RVA: 0x003A6D9E File Offset: 0x003A4F9E
		public ITetrisPlayModeNormalT AsITetrisPlayModeNormal()
		{
			return this.As<ITetrisPlayModeNormalT>();
		}

		// Token: 0x060197DC RID: 104412 RVA: 0x003A6DA6 File Offset: 0x003A4FA6
		public static TTetrisPlayModeUnion FromITetrisPlayModeNormal(ITetrisPlayModeNormalT _itetrisplaymodenormal)
		{
			return new TTetrisPlayModeUnion
			{
				Type = TTetrisPlayMode.ITetrisPlayModeNormal,
				Value = _itetrisplaymodenormal
			};
		}

		// Token: 0x060197DD RID: 104413 RVA: 0x003A6DBC File Offset: 0x003A4FBC
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
