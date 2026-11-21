using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006728 RID: 26408
	public class IActorFxEmoteType_UnionUnion
	{
		// Token: 0x1700BFF6 RID: 49142
		// (get) Token: 0x0602CB9B RID: 183195 RVA: 0x0061E51D File Offset: 0x0061C71D
		// (set) Token: 0x0602CB9C RID: 183196 RVA: 0x0061E525 File Offset: 0x0061C725
		public IActorFxEmoteType_Union Type { get; set; }

		// Token: 0x1700BFF7 RID: 49143
		// (get) Token: 0x0602CB9D RID: 183197 RVA: 0x0061E52E File Offset: 0x0061C72E
		// (set) Token: 0x0602CB9E RID: 183198 RVA: 0x0061E536 File Offset: 0x0061C736
		public object Value { get; set; }

		// Token: 0x0602CB9F RID: 183199 RVA: 0x0061E53F File Offset: 0x0061C73F
		public IActorFxEmoteType_UnionUnion()
		{
			this.Type = IActorFxEmoteType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CBA0 RID: 183200 RVA: 0x0061E555 File Offset: 0x0061C755
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CBA1 RID: 183201 RVA: 0x0061E567 File Offset: 0x0061C767
		public IActorFxEmoteTypeT AsIActorFxEmoteType()
		{
			return this.As<IActorFxEmoteTypeT>();
		}

		// Token: 0x0602CBA2 RID: 183202 RVA: 0x0061E56F File Offset: 0x0061C76F
		public static IActorFxEmoteType_UnionUnion FromIActorFxEmoteType(IActorFxEmoteTypeT _iactorfxemotetype)
		{
			return new IActorFxEmoteType_UnionUnion
			{
				Type = IActorFxEmoteType_Union.IActorFxEmoteType,
				Value = _iactorfxemotetype
			};
		}

		// Token: 0x0602CBA3 RID: 183203 RVA: 0x0061E584 File Offset: 0x0061C784
		public IActorFxEmotePlayT AsIActorFxEmotePlay()
		{
			return this.As<IActorFxEmotePlayT>();
		}

		// Token: 0x0602CBA4 RID: 183204 RVA: 0x0061E58C File Offset: 0x0061C78C
		public static IActorFxEmoteType_UnionUnion FromIActorFxEmotePlay(IActorFxEmotePlayT _iactorfxemoteplay)
		{
			return new IActorFxEmoteType_UnionUnion
			{
				Type = IActorFxEmoteType_Union.IActorFxEmotePlay,
				Value = _iactorfxemoteplay
			};
		}

		// Token: 0x0602CBA5 RID: 183205 RVA: 0x0061E5A1 File Offset: 0x0061C7A1
		public IActorFxEmoteStopT AsIActorFxEmoteStop()
		{
			return this.As<IActorFxEmoteStopT>();
		}

		// Token: 0x0602CBA6 RID: 183206 RVA: 0x0061E5A9 File Offset: 0x0061C7A9
		public static IActorFxEmoteType_UnionUnion FromIActorFxEmoteStop(IActorFxEmoteStopT _iactorfxemotestop)
		{
			return new IActorFxEmoteType_UnionUnion
			{
				Type = IActorFxEmoteType_Union.IActorFxEmoteStop,
				Value = _iactorfxemotestop
			};
		}

		// Token: 0x0602CBA7 RID: 183207 RVA: 0x0061E5C0 File Offset: 0x0061C7C0
		public static int Pack(FlatBufferBuilder builder, IActorFxEmoteType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IActorFxEmoteType_Union.IActorFxEmoteType:
				return IActorFxEmoteType.Pack(builder, _o.AsIActorFxEmoteType()).Value;
			case IActorFxEmoteType_Union.IActorFxEmotePlay:
				return IActorFxEmotePlay.Pack(builder, _o.AsIActorFxEmotePlay()).Value;
			case IActorFxEmoteType_Union.IActorFxEmoteStop:
				return IActorFxEmoteStop.Pack(builder, _o.AsIActorFxEmoteStop()).Value;
			default:
				return 0;
			}
		}
	}
}
