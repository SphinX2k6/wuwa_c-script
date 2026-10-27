using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007696 RID: 30358
	public class TControlTrackingTypeUnion
	{
		// Token: 0x1700E5F7 RID: 58871
		// (get) Token: 0x060373CC RID: 226252 RVA: 0x0077C5EE File Offset: 0x0077A7EE
		// (set) Token: 0x060373CD RID: 226253 RVA: 0x0077C5F6 File Offset: 0x0077A7F6
		public TControlTrackingType Type { get; set; }

		// Token: 0x1700E5F8 RID: 58872
		// (get) Token: 0x060373CE RID: 226254 RVA: 0x0077C5FF File Offset: 0x0077A7FF
		// (set) Token: 0x060373CF RID: 226255 RVA: 0x0077C607 File Offset: 0x0077A807
		public object Value { get; set; }

		// Token: 0x060373D0 RID: 226256 RVA: 0x0077C610 File Offset: 0x0077A810
		public TControlTrackingTypeUnion()
		{
			this.Type = TControlTrackingType.NONE;
			this.Value = null;
		}

		// Token: 0x060373D1 RID: 226257 RVA: 0x0077C626 File Offset: 0x0077A826
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060373D2 RID: 226258 RVA: 0x0077C638 File Offset: 0x0077A838
		public IControlTrackingOtherT AsIControlTrackingOther()
		{
			return this.As<IControlTrackingOtherT>();
		}

		// Token: 0x060373D3 RID: 226259 RVA: 0x0077C640 File Offset: 0x0077A840
		public static TControlTrackingTypeUnion FromIControlTrackingOther(IControlTrackingOtherT _icontroltrackingother)
		{
			return new TControlTrackingTypeUnion
			{
				Type = TControlTrackingType.IControlTrackingOther,
				Value = _icontroltrackingother
			};
		}

		// Token: 0x060373D4 RID: 226260 RVA: 0x0077C655 File Offset: 0x0077A855
		public IControlTrackingSelfT AsIControlTrackingSelf()
		{
			return this.As<IControlTrackingSelfT>();
		}

		// Token: 0x060373D5 RID: 226261 RVA: 0x0077C65D File Offset: 0x0077A85D
		public static TControlTrackingTypeUnion FromIControlTrackingSelf(IControlTrackingSelfT _icontroltrackingself)
		{
			return new TControlTrackingTypeUnion
			{
				Type = TControlTrackingType.IControlTrackingSelf,
				Value = _icontroltrackingself
			};
		}

		// Token: 0x060373D6 RID: 226262 RVA: 0x0077C674 File Offset: 0x0077A874
		public static int Pack(FlatBufferBuilder builder, TControlTrackingTypeUnion _o)
		{
			TControlTrackingType type = _o.Type;
			if (type == TControlTrackingType.IControlTrackingOther)
			{
				return IControlTrackingOther.Pack(builder, _o.AsIControlTrackingOther()).Value;
			}
			if (type != TControlTrackingType.IControlTrackingSelf)
			{
				return 0;
			}
			return IControlTrackingSelf.Pack(builder, _o.AsIControlTrackingSelf()).Value;
		}
	}
}
