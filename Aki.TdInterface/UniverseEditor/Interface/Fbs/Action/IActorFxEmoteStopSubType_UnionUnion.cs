using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060C0 RID: 24768
	public class IActorFxEmoteStopSubType_UnionUnion
	{
		// Token: 0x1700B686 RID: 46726
		// (get) Token: 0x0602A49A RID: 173210 RVA: 0x005D42B5 File Offset: 0x005D24B5
		// (set) Token: 0x0602A49B RID: 173211 RVA: 0x005D42BD File Offset: 0x005D24BD
		public IActorFxEmoteStopSubType_Union Type { get; set; }

		// Token: 0x1700B687 RID: 46727
		// (get) Token: 0x0602A49C RID: 173212 RVA: 0x005D42C6 File Offset: 0x005D24C6
		// (set) Token: 0x0602A49D RID: 173213 RVA: 0x005D42CE File Offset: 0x005D24CE
		public object Value { get; set; }

		// Token: 0x0602A49E RID: 173214 RVA: 0x005D42D7 File Offset: 0x005D24D7
		public IActorFxEmoteStopSubType_UnionUnion()
		{
			this.Type = IActorFxEmoteStopSubType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A49F RID: 173215 RVA: 0x005D42ED File Offset: 0x005D24ED
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A4A0 RID: 173216 RVA: 0x005D42FF File Offset: 0x005D24FF
		public IActorFxEmoteStopSubTypeT AsIActorFxEmoteStopSubType()
		{
			return this.As<IActorFxEmoteStopSubTypeT>();
		}

		// Token: 0x0602A4A1 RID: 173217 RVA: 0x005D4307 File Offset: 0x005D2507
		public static IActorFxEmoteStopSubType_UnionUnion FromIActorFxEmoteStopSubType(IActorFxEmoteStopSubTypeT _iactorfxemotestopsubtype)
		{
			return new IActorFxEmoteStopSubType_UnionUnion
			{
				Type = IActorFxEmoteStopSubType_Union.IActorFxEmoteStopSubType,
				Value = _iactorfxemotestopsubtype
			};
		}

		// Token: 0x0602A4A2 RID: 173218 RVA: 0x005D431C File Offset: 0x005D251C
		public IActorFxEmoteStopAllT AsIActorFxEmoteStopAll()
		{
			return this.As<IActorFxEmoteStopAllT>();
		}

		// Token: 0x0602A4A3 RID: 173219 RVA: 0x005D4324 File Offset: 0x005D2524
		public static IActorFxEmoteStopSubType_UnionUnion FromIActorFxEmoteStopAll(IActorFxEmoteStopAllT _iactorfxemotestopall)
		{
			return new IActorFxEmoteStopSubType_UnionUnion
			{
				Type = IActorFxEmoteStopSubType_Union.IActorFxEmoteStopAll,
				Value = _iactorfxemotestopall
			};
		}

		// Token: 0x0602A4A4 RID: 173220 RVA: 0x005D4339 File Offset: 0x005D2539
		public IActorFxEmoteStopSocketsT AsIActorFxEmoteStopSockets()
		{
			return this.As<IActorFxEmoteStopSocketsT>();
		}

		// Token: 0x0602A4A5 RID: 173221 RVA: 0x005D4341 File Offset: 0x005D2541
		public static IActorFxEmoteStopSubType_UnionUnion FromIActorFxEmoteStopSockets(IActorFxEmoteStopSocketsT _iactorfxemotestopsockets)
		{
			return new IActorFxEmoteStopSubType_UnionUnion
			{
				Type = IActorFxEmoteStopSubType_Union.IActorFxEmoteStopSockets,
				Value = _iactorfxemotestopsockets
			};
		}

		// Token: 0x0602A4A6 RID: 173222 RVA: 0x005D4358 File Offset: 0x005D2558
		public static int Pack(FlatBufferBuilder builder, IActorFxEmoteStopSubType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IActorFxEmoteStopSubType_Union.IActorFxEmoteStopSubType:
				return IActorFxEmoteStopSubType.Pack(builder, _o.AsIActorFxEmoteStopSubType()).Value;
			case IActorFxEmoteStopSubType_Union.IActorFxEmoteStopAll:
				return IActorFxEmoteStopAll.Pack(builder, _o.AsIActorFxEmoteStopAll()).Value;
			case IActorFxEmoteStopSubType_Union.IActorFxEmoteStopSockets:
				return IActorFxEmoteStopSockets.Pack(builder, _o.AsIActorFxEmoteStopSockets()).Value;
			default:
				return 0;
			}
		}
	}
}
