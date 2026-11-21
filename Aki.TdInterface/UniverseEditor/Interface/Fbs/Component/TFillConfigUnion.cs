using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006241 RID: 25153
	public class TFillConfigUnion
	{
		// Token: 0x1700BB42 RID: 47938
		// (get) Token: 0x0602AD1F RID: 175391 RVA: 0x005D8F9A File Offset: 0x005D719A
		// (set) Token: 0x0602AD20 RID: 175392 RVA: 0x005D8FA2 File Offset: 0x005D71A2
		public TFillConfig Type { get; set; }

		// Token: 0x1700BB43 RID: 47939
		// (get) Token: 0x0602AD21 RID: 175393 RVA: 0x005D8FAB File Offset: 0x005D71AB
		// (set) Token: 0x0602AD22 RID: 175394 RVA: 0x005D8FB3 File Offset: 0x005D71B3
		public object Value { get; set; }

		// Token: 0x0602AD23 RID: 175395 RVA: 0x005D8FBC File Offset: 0x005D71BC
		public TFillConfigUnion()
		{
			this.Type = TFillConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD24 RID: 175396 RVA: 0x005D8FD2 File Offset: 0x005D71D2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD25 RID: 175397 RVA: 0x005D8FE4 File Offset: 0x005D71E4
		public IDirectionFillT AsIDirectionFill()
		{
			return this.As<IDirectionFillT>();
		}

		// Token: 0x0602AD26 RID: 175398 RVA: 0x005D8FEC File Offset: 0x005D71EC
		public static TFillConfigUnion FromIDirectionFill(IDirectionFillT _idirectionfill)
		{
			return new TFillConfigUnion
			{
				Type = TFillConfig.IDirectionFill,
				Value = _idirectionfill
			};
		}

		// Token: 0x0602AD27 RID: 175399 RVA: 0x005D9001 File Offset: 0x005D7201
		public IFixedFillT AsIFixedFill()
		{
			return this.As<IFixedFillT>();
		}

		// Token: 0x0602AD28 RID: 175400 RVA: 0x005D9009 File Offset: 0x005D7209
		public static TFillConfigUnion FromIFixedFill(IFixedFillT _ifixedfill)
		{
			return new TFillConfigUnion
			{
				Type = TFillConfig.IFixedFill,
				Value = _ifixedfill
			};
		}

		// Token: 0x0602AD29 RID: 175401 RVA: 0x005D9020 File Offset: 0x005D7220
		public static int Pack(FlatBufferBuilder builder, TFillConfigUnion _o)
		{
			TFillConfig type = _o.Type;
			if (type == TFillConfig.IDirectionFill)
			{
				return IDirectionFill.Pack(builder, _o.AsIDirectionFill()).Value;
			}
			if (type != TFillConfig.IFixedFill)
			{
				return 0;
			}
			return IFixedFill.Pack(builder, _o.AsIFixedFill()).Value;
		}
	}
}
