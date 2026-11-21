using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200624A RID: 25162
	public class TFrequencyPaintLineOptionUnion
	{
		// Token: 0x1700BB48 RID: 47944
		// (get) Token: 0x0602AD45 RID: 175429 RVA: 0x005D92DA File Offset: 0x005D74DA
		// (set) Token: 0x0602AD46 RID: 175430 RVA: 0x005D92E2 File Offset: 0x005D74E2
		public TFrequencyPaintLineOption Type { get; set; }

		// Token: 0x1700BB49 RID: 47945
		// (get) Token: 0x0602AD47 RID: 175431 RVA: 0x005D92EB File Offset: 0x005D74EB
		// (set) Token: 0x0602AD48 RID: 175432 RVA: 0x005D92F3 File Offset: 0x005D74F3
		public object Value { get; set; }

		// Token: 0x0602AD49 RID: 175433 RVA: 0x005D92FC File Offset: 0x005D74FC
		public TFrequencyPaintLineOptionUnion()
		{
			this.Type = TFrequencyPaintLineOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD4A RID: 175434 RVA: 0x005D9312 File Offset: 0x005D7512
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD4B RID: 175435 RVA: 0x005D9324 File Offset: 0x005D7524
		public IFrequencyPaintConnectLineT AsIFrequencyPaintConnectLine()
		{
			return this.As<IFrequencyPaintConnectLineT>();
		}

		// Token: 0x0602AD4C RID: 175436 RVA: 0x005D932C File Offset: 0x005D752C
		public static TFrequencyPaintLineOptionUnion FromIFrequencyPaintConnectLine(IFrequencyPaintConnectLineT _ifrequencypaintconnectline)
		{
			return new TFrequencyPaintLineOptionUnion
			{
				Type = TFrequencyPaintLineOption.IFrequencyPaintConnectLine,
				Value = _ifrequencypaintconnectline
			};
		}

		// Token: 0x0602AD4D RID: 175437 RVA: 0x005D9341 File Offset: 0x005D7541
		public IFrequencyPaintEncloseLineT AsIFrequencyPaintEncloseLine()
		{
			return this.As<IFrequencyPaintEncloseLineT>();
		}

		// Token: 0x0602AD4E RID: 175438 RVA: 0x005D9349 File Offset: 0x005D7549
		public static TFrequencyPaintLineOptionUnion FromIFrequencyPaintEncloseLine(IFrequencyPaintEncloseLineT _ifrequencypaintencloseline)
		{
			return new TFrequencyPaintLineOptionUnion
			{
				Type = TFrequencyPaintLineOption.IFrequencyPaintEncloseLine,
				Value = _ifrequencypaintencloseline
			};
		}

		// Token: 0x0602AD4F RID: 175439 RVA: 0x005D935E File Offset: 0x005D755E
		public IFrequencyPaintStraightLineT AsIFrequencyPaintStraightLine()
		{
			return this.As<IFrequencyPaintStraightLineT>();
		}

		// Token: 0x0602AD50 RID: 175440 RVA: 0x005D9366 File Offset: 0x005D7566
		public static TFrequencyPaintLineOptionUnion FromIFrequencyPaintStraightLine(IFrequencyPaintStraightLineT _ifrequencypaintstraightline)
		{
			return new TFrequencyPaintLineOptionUnion
			{
				Type = TFrequencyPaintLineOption.IFrequencyPaintStraightLine,
				Value = _ifrequencypaintstraightline
			};
		}

		// Token: 0x0602AD51 RID: 175441 RVA: 0x005D937B File Offset: 0x005D757B
		public IFrequencyPaintStrokeLineT AsIFrequencyPaintStrokeLine()
		{
			return this.As<IFrequencyPaintStrokeLineT>();
		}

		// Token: 0x0602AD52 RID: 175442 RVA: 0x005D9383 File Offset: 0x005D7583
		public static TFrequencyPaintLineOptionUnion FromIFrequencyPaintStrokeLine(IFrequencyPaintStrokeLineT _ifrequencypaintstrokeline)
		{
			return new TFrequencyPaintLineOptionUnion
			{
				Type = TFrequencyPaintLineOption.IFrequencyPaintStrokeLine,
				Value = _ifrequencypaintstrokeline
			};
		}

		// Token: 0x0602AD53 RID: 175443 RVA: 0x005D9398 File Offset: 0x005D7598
		public static int Pack(FlatBufferBuilder builder, TFrequencyPaintLineOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TFrequencyPaintLineOption.IFrequencyPaintConnectLine:
				return IFrequencyPaintConnectLine.Pack(builder, _o.AsIFrequencyPaintConnectLine()).Value;
			case TFrequencyPaintLineOption.IFrequencyPaintEncloseLine:
				return IFrequencyPaintEncloseLine.Pack(builder, _o.AsIFrequencyPaintEncloseLine()).Value;
			case TFrequencyPaintLineOption.IFrequencyPaintStraightLine:
				return IFrequencyPaintStraightLine.Pack(builder, _o.AsIFrequencyPaintStraightLine()).Value;
			case TFrequencyPaintLineOption.IFrequencyPaintStrokeLine:
				return IFrequencyPaintStrokeLine.Pack(builder, _o.AsIFrequencyPaintStrokeLine()).Value;
			default:
				return 0;
			}
		}
	}
}
