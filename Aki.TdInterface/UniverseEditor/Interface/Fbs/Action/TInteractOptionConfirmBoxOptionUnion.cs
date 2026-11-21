using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F13 RID: 32531
	public class TInteractOptionConfirmBoxOptionUnion
	{
		// Token: 0x1700F285 RID: 62085
		// (get) Token: 0x0603AAAD RID: 240301 RVA: 0x007E3FD2 File Offset: 0x007E21D2
		// (set) Token: 0x0603AAAE RID: 240302 RVA: 0x007E3FDA File Offset: 0x007E21DA
		public TInteractOptionConfirmBoxOption Type { get; set; }

		// Token: 0x1700F286 RID: 62086
		// (get) Token: 0x0603AAAF RID: 240303 RVA: 0x007E3FE3 File Offset: 0x007E21E3
		// (set) Token: 0x0603AAB0 RID: 240304 RVA: 0x007E3FEB File Offset: 0x007E21EB
		public object Value { get; set; }

		// Token: 0x0603AAB1 RID: 240305 RVA: 0x007E3FF4 File Offset: 0x007E21F4
		public TInteractOptionConfirmBoxOptionUnion()
		{
			this.Type = TInteractOptionConfirmBoxOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AAB2 RID: 240306 RVA: 0x007E400A File Offset: 0x007E220A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AAB3 RID: 240307 RVA: 0x007E401C File Offset: 0x007E221C
		public ICommonConfirmBoxT AsICommonConfirmBox()
		{
			return this.As<ICommonConfirmBoxT>();
		}

		// Token: 0x0603AAB4 RID: 240308 RVA: 0x007E4024 File Offset: 0x007E2224
		public static TInteractOptionConfirmBoxOptionUnion FromICommonConfirmBox(ICommonConfirmBoxT _icommonconfirmbox)
		{
			return new TInteractOptionConfirmBoxOptionUnion
			{
				Type = TInteractOptionConfirmBoxOption.ICommonConfirmBox,
				Value = _icommonconfirmbox
			};
		}

		// Token: 0x0603AAB5 RID: 240309 RVA: 0x007E4039 File Offset: 0x007E2239
		public IHonamiStoryCorruptedChestConfirmBoxT AsIHonamiStoryCorruptedChestConfirmBox()
		{
			return this.As<IHonamiStoryCorruptedChestConfirmBoxT>();
		}

		// Token: 0x0603AAB6 RID: 240310 RVA: 0x007E4041 File Offset: 0x007E2241
		public static TInteractOptionConfirmBoxOptionUnion FromIHonamiStoryCorruptedChestConfirmBox(IHonamiStoryCorruptedChestConfirmBoxT _ihonamistorycorruptedchestconfirmbox)
		{
			return new TInteractOptionConfirmBoxOptionUnion
			{
				Type = TInteractOptionConfirmBoxOption.IHonamiStoryCorruptedChestConfirmBox,
				Value = _ihonamistorycorruptedchestconfirmbox
			};
		}

		// Token: 0x0603AAB7 RID: 240311 RVA: 0x007E4056 File Offset: 0x007E2256
		public IHonamiStoryEvacuateConfirmBoxT AsIHonamiStoryEvacuateConfirmBox()
		{
			return this.As<IHonamiStoryEvacuateConfirmBoxT>();
		}

		// Token: 0x0603AAB8 RID: 240312 RVA: 0x007E405E File Offset: 0x007E225E
		public static TInteractOptionConfirmBoxOptionUnion FromIHonamiStoryEvacuateConfirmBox(IHonamiStoryEvacuateConfirmBoxT _ihonamistoryevacuateconfirmbox)
		{
			return new TInteractOptionConfirmBoxOptionUnion
			{
				Type = TInteractOptionConfirmBoxOption.IHonamiStoryEvacuateConfirmBox,
				Value = _ihonamistoryevacuateconfirmbox
			};
		}

		// Token: 0x0603AAB9 RID: 240313 RVA: 0x007E4074 File Offset: 0x007E2274
		public static int Pack(FlatBufferBuilder builder, TInteractOptionConfirmBoxOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TInteractOptionConfirmBoxOption.ICommonConfirmBox:
				return ICommonConfirmBox.Pack(builder, _o.AsICommonConfirmBox()).Value;
			case TInteractOptionConfirmBoxOption.IHonamiStoryCorruptedChestConfirmBox:
				return IHonamiStoryCorruptedChestConfirmBox.Pack(builder, _o.AsIHonamiStoryCorruptedChestConfirmBox()).Value;
			case TInteractOptionConfirmBoxOption.IHonamiStoryEvacuateConfirmBox:
				return IHonamiStoryEvacuateConfirmBox.Pack(builder, _o.AsIHonamiStoryEvacuateConfirmBox()).Value;
			default:
				return 0;
			}
		}
	}
}
