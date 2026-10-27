using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B7E RID: 19326
	public class IClientEventTarget_UnionUnion
	{
		// Token: 0x17008C3C RID: 35900
		// (get) Token: 0x0601E743 RID: 124739 RVA: 0x004439BD File Offset: 0x00441BBD
		// (set) Token: 0x0601E744 RID: 124740 RVA: 0x004439C5 File Offset: 0x00441BC5
		public IClientEventTarget_Union Type { get; set; }

		// Token: 0x17008C3D RID: 35901
		// (get) Token: 0x0601E745 RID: 124741 RVA: 0x004439CE File Offset: 0x00441BCE
		// (set) Token: 0x0601E746 RID: 124742 RVA: 0x004439D6 File Offset: 0x00441BD6
		public object Value { get; set; }

		// Token: 0x0601E747 RID: 124743 RVA: 0x004439DF File Offset: 0x00441BDF
		public IClientEventTarget_UnionUnion()
		{
			this.Type = IClientEventTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601E748 RID: 124744 RVA: 0x004439F5 File Offset: 0x00441BF5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601E749 RID: 124745 RVA: 0x00443A07 File Offset: 0x00441C07
		public IClientEventTargetT AsIClientEventTarget()
		{
			return this.As<IClientEventTargetT>();
		}

		// Token: 0x0601E74A RID: 124746 RVA: 0x00443A0F File Offset: 0x00441C0F
		public static IClientEventTarget_UnionUnion FromIClientEventTarget(IClientEventTargetT _iclienteventtarget)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.IClientEventTarget,
				Value = _iclienteventtarget
			};
		}

		// Token: 0x0601E74B RID: 124747 RVA: 0x00443A24 File Offset: 0x00441C24
		public ISelfClientEventT AsISelfClientEvent()
		{
			return this.As<ISelfClientEventT>();
		}

		// Token: 0x0601E74C RID: 124748 RVA: 0x00443A2C File Offset: 0x00441C2C
		public static IClientEventTarget_UnionUnion FromISelfClientEvent(ISelfClientEventT _iselfclientevent)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.ISelfClientEvent,
				Value = _iselfclientevent
			};
		}

		// Token: 0x0601E74D RID: 124749 RVA: 0x00443A44 File Offset: 0x00441C44
		public static int Pack(FlatBufferBuilder builder, IClientEventTarget_UnionUnion _o)
		{
			IClientEventTarget_Union type = _o.Type;
			if (type == IClientEventTarget_Union.IClientEventTarget)
			{
				return IClientEventTarget.Pack(builder, _o.AsIClientEventTarget()).Value;
			}
			if (type != IClientEventTarget_Union.ISelfClientEvent)
			{
				return 0;
			}
			return ISelfClientEvent.Pack(builder, _o.AsISelfClientEvent()).Value;
		}
	}
}
