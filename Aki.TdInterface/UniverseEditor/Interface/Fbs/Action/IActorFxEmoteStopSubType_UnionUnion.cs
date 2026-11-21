using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006722 RID: 26402
	public class IActorFxEmoteStopSubType_UnionUnion
	{
		// Token: 0x1700BFF1 RID: 49137
		// (get) Token: 0x0602CB7B RID: 183163 RVA: 0x0061E25D File Offset: 0x0061C45D
		// (set) Token: 0x0602CB7C RID: 183164 RVA: 0x0061E265 File Offset: 0x0061C465
		public IActorFxEmoteStopSubType_Union Type { get; set; }

		// Token: 0x1700BFF2 RID: 49138
		// (get) Token: 0x0602CB7D RID: 183165 RVA: 0x0061E26E File Offset: 0x0061C46E
		// (set) Token: 0x0602CB7E RID: 183166 RVA: 0x0061E276 File Offset: 0x0061C476
		public object Value { get; set; }

		// Token: 0x0602CB7F RID: 183167 RVA: 0x0061E27F File Offset: 0x0061C47F
		public IActorFxEmoteStopSubType_UnionUnion()
		{
			this.Type = IActorFxEmoteStopSubType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CB80 RID: 183168 RVA: 0x0061E295 File Offset: 0x0061C495
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CB81 RID: 183169 RVA: 0x0061E2A7 File Offset: 0x0061C4A7
		public IActorFxEmoteStopSubTypeT AsIActorFxEmoteStopSubType()
		{
			return this.As<IActorFxEmoteStopSubTypeT>();
		}

		// Token: 0x0602CB82 RID: 183170 RVA: 0x0061E2AF File Offset: 0x0061C4AF
		public static IActorFxEmoteStopSubType_UnionUnion FromIActorFxEmoteStopSubType(IActorFxEmoteStopSubTypeT _iactorfxemotestopsubtype)
		{
			return new IActorFxEmoteStopSubType_UnionUnion
			{
				Type = IActorFxEmoteStopSubType_Union.IActorFxEmoteStopSubType,
				Value = _iactorfxemotestopsubtype
			};
		}

		// Token: 0x0602CB83 RID: 183171 RVA: 0x0061E2C4 File Offset: 0x0061C4C4
		public IActorFxEmoteStopAllT AsIActorFxEmoteStopAll()
		{
			return this.As<IActorFxEmoteStopAllT>();
		}

		// Token: 0x0602CB84 RID: 183172 RVA: 0x0061E2CC File Offset: 0x0061C4CC
		public static IActorFxEmoteStopSubType_UnionUnion FromIActorFxEmoteStopAll(IActorFxEmoteStopAllT _iactorfxemotestopall)
		{
			return new IActorFxEmoteStopSubType_UnionUnion
			{
				Type = IActorFxEmoteStopSubType_Union.IActorFxEmoteStopAll,
				Value = _iactorfxemotestopall
			};
		}

		// Token: 0x0602CB85 RID: 183173 RVA: 0x0061E2E1 File Offset: 0x0061C4E1
		public IActorFxEmoteStopSocketsT AsIActorFxEmoteStopSockets()
		{
			return this.As<IActorFxEmoteStopSocketsT>();
		}

		// Token: 0x0602CB86 RID: 183174 RVA: 0x0061E2E9 File Offset: 0x0061C4E9
		public static IActorFxEmoteStopSubType_UnionUnion FromIActorFxEmoteStopSockets(IActorFxEmoteStopSocketsT _iactorfxemotestopsockets)
		{
			return new IActorFxEmoteStopSubType_UnionUnion
			{
				Type = IActorFxEmoteStopSubType_Union.IActorFxEmoteStopSockets,
				Value = _iactorfxemotestopsockets
			};
		}

		// Token: 0x0602CB87 RID: 183175 RVA: 0x0061E300 File Offset: 0x0061C500
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
