using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072BA RID: 29370
	public class ITalkEffectType_UnionUnion
	{
		// Token: 0x1700D9DA RID: 55770
		// (get) Token: 0x060341DD RID: 213469 RVA: 0x007012B9 File Offset: 0x006FF4B9
		// (set) Token: 0x060341DE RID: 213470 RVA: 0x007012C1 File Offset: 0x006FF4C1
		public ITalkEffectType_Union Type { get; set; }

		// Token: 0x1700D9DB RID: 55771
		// (get) Token: 0x060341DF RID: 213471 RVA: 0x007012CA File Offset: 0x006FF4CA
		// (set) Token: 0x060341E0 RID: 213472 RVA: 0x007012D2 File Offset: 0x006FF4D2
		public object Value { get; set; }

		// Token: 0x060341E1 RID: 213473 RVA: 0x007012DB File Offset: 0x006FF4DB
		public ITalkEffectType_UnionUnion()
		{
			this.Type = ITalkEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060341E2 RID: 213474 RVA: 0x007012F1 File Offset: 0x006FF4F1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060341E3 RID: 213475 RVA: 0x00701303 File Offset: 0x006FF503
		public ITalkEffectTypeT AsITalkEffectType()
		{
			return this.As<ITalkEffectTypeT>();
		}

		// Token: 0x060341E4 RID: 213476 RVA: 0x0070130B File Offset: 0x006FF50B
		public static ITalkEffectType_UnionUnion FromITalkEffectType(ITalkEffectTypeT _italkeffecttype)
		{
			return new ITalkEffectType_UnionUnion
			{
				Type = ITalkEffectType_Union.ITalkEffectType,
				Value = _italkeffecttype
			};
		}

		// Token: 0x060341E5 RID: 213477 RVA: 0x00701320 File Offset: 0x006FF520
		public ITalkCommonEffectT AsITalkCommonEffect()
		{
			return this.As<ITalkCommonEffectT>();
		}

		// Token: 0x060341E6 RID: 213478 RVA: 0x00701328 File Offset: 0x006FF528
		public static ITalkEffectType_UnionUnion FromITalkCommonEffect(ITalkCommonEffectT _italkcommoneffect)
		{
			return new ITalkEffectType_UnionUnion
			{
				Type = ITalkEffectType_Union.ITalkCommonEffect,
				Value = _italkcommoneffect
			};
		}

		// Token: 0x060341E7 RID: 213479 RVA: 0x00701340 File Offset: 0x006FF540
		public static int Pack(FlatBufferBuilder builder, ITalkEffectType_UnionUnion _o)
		{
			ITalkEffectType_Union type = _o.Type;
			if (type == ITalkEffectType_Union.ITalkEffectType)
			{
				return ITalkEffectType.Pack(builder, _o.AsITalkEffectType()).Value;
			}
			if (type != ITalkEffectType_Union.ITalkCommonEffect)
			{
				return 0;
			}
			return ITalkCommonEffect.Pack(builder, _o.AsITalkCommonEffect()).Value;
		}
	}
}
