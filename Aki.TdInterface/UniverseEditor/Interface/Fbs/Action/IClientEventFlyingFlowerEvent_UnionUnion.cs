using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A0C RID: 27148
	public class IClientEventFlyingFlowerEvent_UnionUnion
	{
		// Token: 0x1700C7A0 RID: 51104
		// (get) Token: 0x0602E933 RID: 190771 RVA: 0x0065A291 File Offset: 0x00658491
		// (set) Token: 0x0602E934 RID: 190772 RVA: 0x0065A299 File Offset: 0x00658499
		public IClientEventFlyingFlowerEvent_Union Type { get; set; }

		// Token: 0x1700C7A1 RID: 51105
		// (get) Token: 0x0602E935 RID: 190773 RVA: 0x0065A2A2 File Offset: 0x006584A2
		// (set) Token: 0x0602E936 RID: 190774 RVA: 0x0065A2AA File Offset: 0x006584AA
		public object Value { get; set; }

		// Token: 0x0602E937 RID: 190775 RVA: 0x0065A2B3 File Offset: 0x006584B3
		public IClientEventFlyingFlowerEvent_UnionUnion()
		{
			this.Type = IClientEventFlyingFlowerEvent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E938 RID: 190776 RVA: 0x0065A2C9 File Offset: 0x006584C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E939 RID: 190777 RVA: 0x0065A2DB File Offset: 0x006584DB
		public IClientEventFlyingFlowerEventT AsIClientEventFlyingFlowerEvent()
		{
			return this.As<IClientEventFlyingFlowerEventT>();
		}

		// Token: 0x0602E93A RID: 190778 RVA: 0x0065A2E3 File Offset: 0x006584E3
		public static IClientEventFlyingFlowerEvent_UnionUnion FromIClientEventFlyingFlowerEvent(IClientEventFlyingFlowerEventT _iclienteventflyingflowerevent)
		{
			return new IClientEventFlyingFlowerEvent_UnionUnion
			{
				Type = IClientEventFlyingFlowerEvent_Union.IClientEventFlyingFlowerEvent,
				Value = _iclienteventflyingflowerevent
			};
		}

		// Token: 0x0602E93B RID: 190779 RVA: 0x0065A2F8 File Offset: 0x006584F8
		public IClientEventFlyingFlowerUpdateSubtitleT AsIClientEventFlyingFlowerUpdateSubtitle()
		{
			return this.As<IClientEventFlyingFlowerUpdateSubtitleT>();
		}

		// Token: 0x0602E93C RID: 190780 RVA: 0x0065A300 File Offset: 0x00658500
		public static IClientEventFlyingFlowerEvent_UnionUnion FromIClientEventFlyingFlowerUpdateSubtitle(IClientEventFlyingFlowerUpdateSubtitleT _iclienteventflyingflowerupdatesubtitle)
		{
			return new IClientEventFlyingFlowerEvent_UnionUnion
			{
				Type = IClientEventFlyingFlowerEvent_Union.IClientEventFlyingFlowerUpdateSubtitle,
				Value = _iclienteventflyingflowerupdatesubtitle
			};
		}

		// Token: 0x0602E93D RID: 190781 RVA: 0x0065A318 File Offset: 0x00658518
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
