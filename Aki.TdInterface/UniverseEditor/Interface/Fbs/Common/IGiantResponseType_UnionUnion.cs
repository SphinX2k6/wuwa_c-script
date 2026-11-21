using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006408 RID: 25608
	public class IGiantResponseType_UnionUnion
	{
		// Token: 0x1700BD25 RID: 48421
		// (get) Token: 0x0602B80C RID: 178188 RVA: 0x005ECDA9 File Offset: 0x005EAFA9
		// (set) Token: 0x0602B80D RID: 178189 RVA: 0x005ECDB1 File Offset: 0x005EAFB1
		public IGiantResponseType_Union Type { get; set; }

		// Token: 0x1700BD26 RID: 48422
		// (get) Token: 0x0602B80E RID: 178190 RVA: 0x005ECDBA File Offset: 0x005EAFBA
		// (set) Token: 0x0602B80F RID: 178191 RVA: 0x005ECDC2 File Offset: 0x005EAFC2
		public object Value { get; set; }

		// Token: 0x0602B810 RID: 178192 RVA: 0x005ECDCB File Offset: 0x005EAFCB
		public IGiantResponseType_UnionUnion()
		{
			this.Type = IGiantResponseType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B811 RID: 178193 RVA: 0x005ECDE1 File Offset: 0x005EAFE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B812 RID: 178194 RVA: 0x005ECDF3 File Offset: 0x005EAFF3
		public IGiantResponseTypeT AsIGiantResponseType()
		{
			return this.As<IGiantResponseTypeT>();
		}

		// Token: 0x0602B813 RID: 178195 RVA: 0x005ECDFB File Offset: 0x005EAFFB
		public static IGiantResponseType_UnionUnion FromIGiantResponseType(IGiantResponseTypeT _igiantresponsetype)
		{
			return new IGiantResponseType_UnionUnion
			{
				Type = IGiantResponseType_Union.IGiantResponseType,
				Value = _igiantresponsetype
			};
		}

		// Token: 0x0602B814 RID: 178196 RVA: 0x005ECE10 File Offset: 0x005EB010
		public IGiantResponsePlayAnimationT AsIGiantResponsePlayAnimation()
		{
			return this.As<IGiantResponsePlayAnimationT>();
		}

		// Token: 0x0602B815 RID: 178197 RVA: 0x005ECE18 File Offset: 0x005EB018
		public static IGiantResponseType_UnionUnion FromIGiantResponsePlayAnimation(IGiantResponsePlayAnimationT _igiantresponseplayanimation)
		{
			return new IGiantResponseType_UnionUnion
			{
				Type = IGiantResponseType_Union.IGiantResponsePlayAnimation,
				Value = _igiantresponseplayanimation
			};
		}

		// Token: 0x0602B816 RID: 178198 RVA: 0x005ECE2D File Offset: 0x005EB02D
		public IGiantResponsePlayFlowT AsIGiantResponsePlayFlow()
		{
			return this.As<IGiantResponsePlayFlowT>();
		}

		// Token: 0x0602B817 RID: 178199 RVA: 0x005ECE35 File Offset: 0x005EB035
		public static IGiantResponseType_UnionUnion FromIGiantResponsePlayFlow(IGiantResponsePlayFlowT _igiantresponseplayflow)
		{
			return new IGiantResponseType_UnionUnion
			{
				Type = IGiantResponseType_Union.IGiantResponsePlayFlow,
				Value = _igiantresponseplayflow
			};
		}

		// Token: 0x0602B818 RID: 178200 RVA: 0x005ECE4C File Offset: 0x005EB04C
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
