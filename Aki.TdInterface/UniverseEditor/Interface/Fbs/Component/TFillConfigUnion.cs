using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C22 RID: 23586
	public class TFillConfigUnion
	{
		// Token: 0x1700B1F4 RID: 45556
		// (get) Token: 0x0602872D RID: 165677 RVA: 0x0059100A File Offset: 0x0058F20A
		// (set) Token: 0x0602872E RID: 165678 RVA: 0x00591012 File Offset: 0x0058F212
		public TFillConfig Type { get; set; }

		// Token: 0x1700B1F5 RID: 45557
		// (get) Token: 0x0602872F RID: 165679 RVA: 0x0059101B File Offset: 0x0058F21B
		// (set) Token: 0x06028730 RID: 165680 RVA: 0x00591023 File Offset: 0x0058F223
		public object Value { get; set; }

		// Token: 0x06028731 RID: 165681 RVA: 0x0059102C File Offset: 0x0058F22C
		public TFillConfigUnion()
		{
			this.Type = TFillConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06028732 RID: 165682 RVA: 0x00591042 File Offset: 0x0058F242
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028733 RID: 165683 RVA: 0x00591054 File Offset: 0x0058F254
		public IDirectionFillT AsIDirectionFill()
		{
			return this.As<IDirectionFillT>();
		}

		// Token: 0x06028734 RID: 165684 RVA: 0x0059105C File Offset: 0x0058F25C
		public static TFillConfigUnion FromIDirectionFill(IDirectionFillT _idirectionfill)
		{
			return new TFillConfigUnion
			{
				Type = TFillConfig.IDirectionFill,
				Value = _idirectionfill
			};
		}

		// Token: 0x06028735 RID: 165685 RVA: 0x00591071 File Offset: 0x0058F271
		public IFixedFillT AsIFixedFill()
		{
			return this.As<IFixedFillT>();
		}

		// Token: 0x06028736 RID: 165686 RVA: 0x00591079 File Offset: 0x0058F279
		public static TFillConfigUnion FromIFixedFill(IFixedFillT _ifixedfill)
		{
			return new TFillConfigUnion
			{
				Type = TFillConfig.IFixedFill,
				Value = _ifixedfill
			};
		}

		// Token: 0x06028737 RID: 165687 RVA: 0x00591090 File Offset: 0x0058F290
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
