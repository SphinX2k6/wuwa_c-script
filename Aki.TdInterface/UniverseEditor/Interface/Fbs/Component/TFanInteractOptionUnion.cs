using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1F RID: 23583
	public class TFanInteractOptionUnion
	{
		// Token: 0x1700B1F2 RID: 45554
		// (get) Token: 0x06028721 RID: 165665 RVA: 0x00590F0E File Offset: 0x0058F10E
		// (set) Token: 0x06028722 RID: 165666 RVA: 0x00590F16 File Offset: 0x0058F116
		public TFanInteractOption Type { get; set; }

		// Token: 0x1700B1F3 RID: 45555
		// (get) Token: 0x06028723 RID: 165667 RVA: 0x00590F1F File Offset: 0x0058F11F
		// (set) Token: 0x06028724 RID: 165668 RVA: 0x00590F27 File Offset: 0x0058F127
		public object Value { get; set; }

		// Token: 0x06028725 RID: 165669 RVA: 0x00590F30 File Offset: 0x0058F130
		public TFanInteractOptionUnion()
		{
			this.Type = TFanInteractOption.NONE;
			this.Value = null;
		}

		// Token: 0x06028726 RID: 165670 RVA: 0x00590F46 File Offset: 0x0058F146
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028727 RID: 165671 RVA: 0x00590F58 File Offset: 0x0058F158
		public IFanInteractByFKeyT AsIFanInteractByFKey()
		{
			return this.As<IFanInteractByFKeyT>();
		}

		// Token: 0x06028728 RID: 165672 RVA: 0x00590F60 File Offset: 0x0058F160
		public static TFanInteractOptionUnion FromIFanInteractByFKey(IFanInteractByFKeyT _ifaninteractbyfkey)
		{
			return new TFanInteractOptionUnion
			{
				Type = TFanInteractOption.IFanInteractByFKey,
				Value = _ifaninteractbyfkey
			};
		}

		// Token: 0x06028729 RID: 165673 RVA: 0x00590F75 File Offset: 0x0058F175
		public IFanInteractByHitT AsIFanInteractByHit()
		{
			return this.As<IFanInteractByHitT>();
		}

		// Token: 0x0602872A RID: 165674 RVA: 0x00590F7D File Offset: 0x0058F17D
		public static TFanInteractOptionUnion FromIFanInteractByHit(IFanInteractByHitT _ifaninteractbyhit)
		{
			return new TFanInteractOptionUnion
			{
				Type = TFanInteractOption.IFanInteractByHit,
				Value = _ifaninteractbyhit
			};
		}

		// Token: 0x0602872B RID: 165675 RVA: 0x00590F94 File Offset: 0x0058F194
		public static int Pack(FlatBufferBuilder builder, TFanInteractOptionUnion _o)
		{
			TFanInteractOption type = _o.Type;
			if (type == TFanInteractOption.IFanInteractByFKey)
			{
				return IFanInteractByFKey.Pack(builder, _o.AsIFanInteractByFKey()).Value;
			}
			if (type != TFanInteractOption.IFanInteractByHit)
			{
				return 0;
			}
			return IFanInteractByHit.Pack(builder, _o.AsIFanInteractByHit()).Value;
		}
	}
}
