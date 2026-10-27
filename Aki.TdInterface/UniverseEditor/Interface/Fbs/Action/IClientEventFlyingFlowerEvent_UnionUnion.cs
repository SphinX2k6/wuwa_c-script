using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200639B RID: 25499
	public class IClientEventFlyingFlowerEvent_UnionUnion
	{
		// Token: 0x1700BE1C RID: 48668
		// (get) Token: 0x0602C1D1 RID: 180689 RVA: 0x0060F259 File Offset: 0x0060D459
		// (set) Token: 0x0602C1D2 RID: 180690 RVA: 0x0060F261 File Offset: 0x0060D461
		public IClientEventFlyingFlowerEvent_Union Type { get; set; }

		// Token: 0x1700BE1D RID: 48669
		// (get) Token: 0x0602C1D3 RID: 180691 RVA: 0x0060F26A File Offset: 0x0060D46A
		// (set) Token: 0x0602C1D4 RID: 180692 RVA: 0x0060F272 File Offset: 0x0060D472
		public object Value { get; set; }

		// Token: 0x0602C1D5 RID: 180693 RVA: 0x0060F27B File Offset: 0x0060D47B
		public IClientEventFlyingFlowerEvent_UnionUnion()
		{
			this.Type = IClientEventFlyingFlowerEvent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C1D6 RID: 180694 RVA: 0x0060F291 File Offset: 0x0060D491
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C1D7 RID: 180695 RVA: 0x0060F2A3 File Offset: 0x0060D4A3
		public IClientEventFlyingFlowerEventT AsIClientEventFlyingFlowerEvent()
		{
			return this.As<IClientEventFlyingFlowerEventT>();
		}

		// Token: 0x0602C1D8 RID: 180696 RVA: 0x0060F2AB File Offset: 0x0060D4AB
		public static IClientEventFlyingFlowerEvent_UnionUnion FromIClientEventFlyingFlowerEvent(IClientEventFlyingFlowerEventT _iclienteventflyingflowerevent)
		{
			return new IClientEventFlyingFlowerEvent_UnionUnion
			{
				Type = IClientEventFlyingFlowerEvent_Union.IClientEventFlyingFlowerEvent,
				Value = _iclienteventflyingflowerevent
			};
		}

		// Token: 0x0602C1D9 RID: 180697 RVA: 0x0060F2C0 File Offset: 0x0060D4C0
		public IClientEventFlyingFlowerUpdateSubtitleT AsIClientEventFlyingFlowerUpdateSubtitle()
		{
			return this.As<IClientEventFlyingFlowerUpdateSubtitleT>();
		}

		// Token: 0x0602C1DA RID: 180698 RVA: 0x0060F2C8 File Offset: 0x0060D4C8
		public static IClientEventFlyingFlowerEvent_UnionUnion FromIClientEventFlyingFlowerUpdateSubtitle(IClientEventFlyingFlowerUpdateSubtitleT _iclienteventflyingflowerupdatesubtitle)
		{
			return new IClientEventFlyingFlowerEvent_UnionUnion
			{
				Type = IClientEventFlyingFlowerEvent_Union.IClientEventFlyingFlowerUpdateSubtitle,
				Value = _iclienteventflyingflowerupdatesubtitle
			};
		}

		// Token: 0x0602C1DB RID: 180699 RVA: 0x0060F2E0 File Offset: 0x0060D4E0
		public static int Pack(FlatBufferBuilder builder, IClientEventFlyingFlowerEvent_UnionUnion _o)
		{
			IClientEventFlyingFlowerEvent_Union type = _o.Type;
			if (type == IClientEventFlyingFlowerEvent_Union.IClientEventFlyingFlowerEvent)
			{
				return IClientEventFlyingFlowerEvent.Pack(builder, _o.AsIClientEventFlyingFlowerEvent()).Value;
			}
			if (type != IClientEventFlyingFlowerEvent_Union.IClientEventFlyingFlowerUpdateSubtitle)
			{
				return 0;
			}
			return IClientEventFlyingFlowerUpdateSubtitle.Pack(builder, _o.AsIClientEventFlyingFlowerUpdateSubtitle()).Value;
		}
	}
}
