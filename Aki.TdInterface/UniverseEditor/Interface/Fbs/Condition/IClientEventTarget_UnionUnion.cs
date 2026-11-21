using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005065 RID: 20581
	public class IClientEventTarget_UnionUnion
	{
		// Token: 0x1700934C RID: 37708
		// (get) Token: 0x060202D1 RID: 131793 RVA: 0x00476209 File Offset: 0x00474409
		// (set) Token: 0x060202D2 RID: 131794 RVA: 0x00476211 File Offset: 0x00474411
		public IClientEventTarget_Union Type { get; set; }

		// Token: 0x1700934D RID: 37709
		// (get) Token: 0x060202D3 RID: 131795 RVA: 0x0047621A File Offset: 0x0047441A
		// (set) Token: 0x060202D4 RID: 131796 RVA: 0x00476222 File Offset: 0x00474422
		public object Value { get; set; }

		// Token: 0x060202D5 RID: 131797 RVA: 0x0047622B File Offset: 0x0047442B
		public IClientEventTarget_UnionUnion()
		{
			this.Type = IClientEventTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060202D6 RID: 131798 RVA: 0x00476241 File Offset: 0x00474441
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060202D7 RID: 131799 RVA: 0x00476253 File Offset: 0x00474453
		public IClientEventTargetT AsIClientEventTarget()
		{
			return this.As<IClientEventTargetT>();
		}

		// Token: 0x060202D8 RID: 131800 RVA: 0x0047625B File Offset: 0x0047445B
		public static IClientEventTarget_UnionUnion FromIClientEventTarget(IClientEventTargetT _iclienteventtarget)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.IClientEventTarget,
				Value = _iclienteventtarget
			};
		}

		// Token: 0x060202D9 RID: 131801 RVA: 0x00476270 File Offset: 0x00474470
		public ISelfClientEventT AsISelfClientEvent()
		{
			return this.As<ISelfClientEventT>();
		}

		// Token: 0x060202DA RID: 131802 RVA: 0x00476278 File Offset: 0x00474478
		public static IClientEventTarget_UnionUnion FromISelfClientEvent(ISelfClientEventT _iselfclientevent)
		{
			return new IClientEventTarget_UnionUnion
			{
				Type = IClientEventTarget_Union.ISelfClientEvent,
				Value = _iselfclientevent
			};
		}

		// Token: 0x060202DB RID: 131803 RVA: 0x00476290 File Offset: 0x00474490
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
