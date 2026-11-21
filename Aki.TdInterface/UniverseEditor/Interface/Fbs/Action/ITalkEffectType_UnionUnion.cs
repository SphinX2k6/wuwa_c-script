using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A8F RID: 31375
	public class ITalkEffectType_UnionUnion
	{
		// Token: 0x1700E5D3 RID: 58835
		// (get) Token: 0x060374E1 RID: 226529 RVA: 0x00762655 File Offset: 0x00760855
		// (set) Token: 0x060374E2 RID: 226530 RVA: 0x0076265D File Offset: 0x0076085D
		public ITalkEffectType_Union Type { get; set; }

		// Token: 0x1700E5D4 RID: 58836
		// (get) Token: 0x060374E3 RID: 226531 RVA: 0x00762666 File Offset: 0x00760866
		// (set) Token: 0x060374E4 RID: 226532 RVA: 0x0076266E File Offset: 0x0076086E
		public object Value { get; set; }

		// Token: 0x060374E5 RID: 226533 RVA: 0x00762677 File Offset: 0x00760877
		public ITalkEffectType_UnionUnion()
		{
			this.Type = ITalkEffectType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060374E6 RID: 226534 RVA: 0x0076268D File Offset: 0x0076088D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060374E7 RID: 226535 RVA: 0x0076269F File Offset: 0x0076089F
		public ITalkEffectTypeT AsITalkEffectType()
		{
			return this.As<ITalkEffectTypeT>();
		}

		// Token: 0x060374E8 RID: 226536 RVA: 0x007626A7 File Offset: 0x007608A7
		public static ITalkEffectType_UnionUnion FromITalkEffectType(ITalkEffectTypeT _italkeffecttype)
		{
			return new ITalkEffectType_UnionUnion
			{
				Type = ITalkEffectType_Union.ITalkEffectType,
				Value = _italkeffecttype
			};
		}

		// Token: 0x060374E9 RID: 226537 RVA: 0x007626BC File Offset: 0x007608BC
		public ITalkCommonEffectT AsITalkCommonEffect()
		{
			return this.As<ITalkCommonEffectT>();
		}

		// Token: 0x060374EA RID: 226538 RVA: 0x007626C4 File Offset: 0x007608C4
		public static ITalkEffectType_UnionUnion FromITalkCommonEffect(ITalkCommonEffectT _italkcommoneffect)
		{
			return new ITalkEffectType_UnionUnion
			{
				Type = ITalkEffectType_Union.ITalkCommonEffect,
				Value = _italkcommoneffect
			};
		}

		// Token: 0x060374EB RID: 226539 RVA: 0x007626DC File Offset: 0x007608DC
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
