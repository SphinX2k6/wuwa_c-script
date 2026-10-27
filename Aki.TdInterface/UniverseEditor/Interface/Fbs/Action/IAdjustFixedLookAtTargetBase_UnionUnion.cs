using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200615C RID: 24924
	public class IAdjustFixedLookAtTargetBase_UnionUnion
	{
		// Token: 0x1700B911 RID: 47377
		// (get) Token: 0x0602ACFA RID: 175354 RVA: 0x005E6FC9 File Offset: 0x005E51C9
		// (set) Token: 0x0602ACFB RID: 175355 RVA: 0x005E6FD1 File Offset: 0x005E51D1
		public IAdjustFixedLookAtTargetBase_Union Type { get; set; }

		// Token: 0x1700B912 RID: 47378
		// (get) Token: 0x0602ACFC RID: 175356 RVA: 0x005E6FDA File Offset: 0x005E51DA
		// (set) Token: 0x0602ACFD RID: 175357 RVA: 0x005E6FE2 File Offset: 0x005E51E2
		public object Value { get; set; }

		// Token: 0x0602ACFE RID: 175358 RVA: 0x005E6FEB File Offset: 0x005E51EB
		public IAdjustFixedLookAtTargetBase_UnionUnion()
		{
			this.Type = IAdjustFixedLookAtTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602ACFF RID: 175359 RVA: 0x005E7001 File Offset: 0x005E5201
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD00 RID: 175360 RVA: 0x005E7013 File Offset: 0x005E5213
		public IAdjustFixedLookAtTargetBaseT AsIAdjustFixedLookAtTargetBase()
		{
			return this.As<IAdjustFixedLookAtTargetBaseT>();
		}

		// Token: 0x0602AD01 RID: 175361 RVA: 0x005E701B File Offset: 0x005E521B
		public static IAdjustFixedLookAtTargetBase_UnionUnion FromIAdjustFixedLookAtTargetBase(IAdjustFixedLookAtTargetBaseT _iadjustfixedlookattargetbase)
		{
			return new IAdjustFixedLookAtTargetBase_UnionUnion
			{
				Type = IAdjustFixedLookAtTargetBase_Union.IAdjustFixedLookAtTargetBase,
				Value = _iadjustfixedlookattargetbase
			};
		}

		// Token: 0x0602AD02 RID: 175362 RVA: 0x005E7030 File Offset: 0x005E5230
		public IAdjustFixedLookAtTargetRangeEntityT AsIAdjustFixedLookAtTargetRangeEntity()
		{
			return this.As<IAdjustFixedLookAtTargetRangeEntityT>();
		}

		// Token: 0x0602AD03 RID: 175363 RVA: 0x005E7038 File Offset: 0x005E5238
		public static IAdjustFixedLookAtTargetBase_UnionUnion FromIAdjustFixedLookAtTargetRangeEntity(IAdjustFixedLookAtTargetRangeEntityT _iadjustfixedlookattargetrangeentity)
		{
			return new IAdjustFixedLookAtTargetBase_UnionUnion
			{
				Type = IAdjustFixedLookAtTargetBase_Union.IAdjustFixedLookAtTargetRangeEntity,
				Value = _iadjustfixedlookattargetrangeentity
			};
		}

		// Token: 0x0602AD04 RID: 175364 RVA: 0x005E7050 File Offset: 0x005E5250
		public static int Pack(FlatBufferBuilder builder, IAdjustFixedLookAtTargetBase_UnionUnion _o)
		{
			IAdjustFixedLookAtTargetBase_Union type = _o.Type;
			if (type == IAdjustFixedLookAtTargetBase_Union.IAdjustFixedLookAtTargetBase)
			{
				return IAdjustFixedLookAtTargetBase.Pack(builder, _o.AsIAdjustFixedLookAtTargetBase()).Value;
			}
			if (type != IAdjustFixedLookAtTargetBase_Union.IAdjustFixedLookAtTargetRangeEntity)
			{
				return 0;
			}
			return IAdjustFixedLookAtTargetRangeEntity.Pack(builder, _o.AsIAdjustFixedLookAtTargetRangeEntity()).Value;
		}
	}
}
