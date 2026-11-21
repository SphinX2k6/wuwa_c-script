using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062FB RID: 25339
	public class TTrampleTipOptionUnion
	{
		// Token: 0x1700BBBE RID: 48062
		// (get) Token: 0x0602B0C3 RID: 176323 RVA: 0x005DE63E File Offset: 0x005DC83E
		// (set) Token: 0x0602B0C4 RID: 176324 RVA: 0x005DE646 File Offset: 0x005DC846
		public TTrampleTipOption Type { get; set; }

		// Token: 0x1700BBBF RID: 48063
		// (get) Token: 0x0602B0C5 RID: 176325 RVA: 0x005DE64F File Offset: 0x005DC84F
		// (set) Token: 0x0602B0C6 RID: 176326 RVA: 0x005DE657 File Offset: 0x005DC857
		public object Value { get; set; }

		// Token: 0x0602B0C7 RID: 176327 RVA: 0x005DE660 File Offset: 0x005DC860
		public TTrampleTipOptionUnion()
		{
			this.Type = TTrampleTipOption.NONE;
			this.Value = null;
		}

		// Token: 0x0602B0C8 RID: 176328 RVA: 0x005DE676 File Offset: 0x005DC876
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B0C9 RID: 176329 RVA: 0x005DE688 File Offset: 0x005DC888
		public ICountDownTextTipT AsICountDownTextTip()
		{
			return this.As<ICountDownTextTipT>();
		}

		// Token: 0x0602B0CA RID: 176330 RVA: 0x005DE690 File Offset: 0x005DC890
		public static TTrampleTipOptionUnion FromICountDownTextTip(ICountDownTextTipT _icountdowntexttip)
		{
			return new TTrampleTipOptionUnion
			{
				Type = TTrampleTipOption.ICountDownTextTip,
				Value = _icountdowntexttip
			};
		}

		// Token: 0x0602B0CB RID: 176331 RVA: 0x005DE6A5 File Offset: 0x005DC8A5
		public IMechaTrackCountDownTipT AsIMechaTrackCountDownTip()
		{
			return this.As<IMechaTrackCountDownTipT>();
		}

		// Token: 0x0602B0CC RID: 176332 RVA: 0x005DE6AD File Offset: 0x005DC8AD
		public static TTrampleTipOptionUnion FromIMechaTrackCountDownTip(IMechaTrackCountDownTipT _imechatrackcountdowntip)
		{
			return new TTrampleTipOptionUnion
			{
				Type = TTrampleTipOption.IMechaTrackCountDownTip,
				Value = _imechatrackcountdowntip
			};
		}

		// Token: 0x0602B0CD RID: 176333 RVA: 0x005DE6C4 File Offset: 0x005DC8C4
		public static int Pack(FlatBufferBuilder builder, TTrampleTipOptionUnion _o)
		{
			TTrampleTipOption type = _o.Type;
			if (type == TTrampleTipOption.ICountDownTextTip)
			{
				return ICountDownTextTip.Pack(builder, _o.AsICountDownTextTip()).Value;
			}
			if (type != TTrampleTipOption.IMechaTrackCountDownTip)
			{
				return 0;
			}
			return IMechaTrackCountDownTip.Pack(builder, _o.AsIMechaTrackCountDownTip()).Value;
		}
	}
}
