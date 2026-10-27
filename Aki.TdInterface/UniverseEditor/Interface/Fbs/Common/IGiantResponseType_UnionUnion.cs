using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DCB RID: 24011
	public class IGiantResponseType_UnionUnion
	{
		// Token: 0x1700B3BF RID: 46015
		// (get) Token: 0x06029182 RID: 168322 RVA: 0x005A4079 File Offset: 0x005A2279
		// (set) Token: 0x06029183 RID: 168323 RVA: 0x005A4081 File Offset: 0x005A2281
		public IGiantResponseType_Union Type { get; set; }

		// Token: 0x1700B3C0 RID: 46016
		// (get) Token: 0x06029184 RID: 168324 RVA: 0x005A408A File Offset: 0x005A228A
		// (set) Token: 0x06029185 RID: 168325 RVA: 0x005A4092 File Offset: 0x005A2292
		public object Value { get; set; }

		// Token: 0x06029186 RID: 168326 RVA: 0x005A409B File Offset: 0x005A229B
		public IGiantResponseType_UnionUnion()
		{
			this.Type = IGiantResponseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029187 RID: 168327 RVA: 0x005A40B1 File Offset: 0x005A22B1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029188 RID: 168328 RVA: 0x005A40C3 File Offset: 0x005A22C3
		public IGiantResponseTypeT AsIGiantResponseType()
		{
			return this.As<IGiantResponseTypeT>();
		}

		// Token: 0x06029189 RID: 168329 RVA: 0x005A40CB File Offset: 0x005A22CB
		public static IGiantResponseType_UnionUnion FromIGiantResponseType(IGiantResponseTypeT _igiantresponsetype)
		{
			return new IGiantResponseType_UnionUnion
			{
				Type = IGiantResponseType_Union.IGiantResponseType,
				Value = _igiantresponsetype
			};
		}

		// Token: 0x0602918A RID: 168330 RVA: 0x005A40E0 File Offset: 0x005A22E0
		public IGiantResponsePlayAnimationT AsIGiantResponsePlayAnimation()
		{
			return this.As<IGiantResponsePlayAnimationT>();
		}

		// Token: 0x0602918B RID: 168331 RVA: 0x005A40E8 File Offset: 0x005A22E8
		public static IGiantResponseType_UnionUnion FromIGiantResponsePlayAnimation(IGiantResponsePlayAnimationT _igiantresponseplayanimation)
		{
			return new IGiantResponseType_UnionUnion
			{
				Type = IGiantResponseType_Union.IGiantResponsePlayAnimation,
				Value = _igiantresponseplayanimation
			};
		}

		// Token: 0x0602918C RID: 168332 RVA: 0x005A40FD File Offset: 0x005A22FD
		public IGiantResponsePlayFlowT AsIGiantResponsePlayFlow()
		{
			return this.As<IGiantResponsePlayFlowT>();
		}

		// Token: 0x0602918D RID: 168333 RVA: 0x005A4105 File Offset: 0x005A2305
		public static IGiantResponseType_UnionUnion FromIGiantResponsePlayFlow(IGiantResponsePlayFlowT _igiantresponseplayflow)
		{
			return new IGiantResponseType_UnionUnion
			{
				Type = IGiantResponseType_Union.IGiantResponsePlayFlow,
				Value = _igiantresponseplayflow
			};
		}

		// Token: 0x0602918E RID: 168334 RVA: 0x005A411C File Offset: 0x005A231C
		public static int Pack(FlatBufferBuilder builder, IGiantResponseType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGiantResponseType_Union.IGiantResponseType:
				return IGiantResponseType.Pack(builder, _o.AsIGiantResponseType()).Value;
			case IGiantResponseType_Union.IGiantResponsePlayAnimation:
				return IGiantResponsePlayAnimation.Pack(builder, _o.AsIGiantResponsePlayAnimation()).Value;
			case IGiantResponseType_Union.IGiantResponsePlayFlow:
				return IGiantResponsePlayFlow.Pack(builder, _o.AsIGiantResponsePlayFlow()).Value;
			default:
				return 0;
			}
		}
	}
}
