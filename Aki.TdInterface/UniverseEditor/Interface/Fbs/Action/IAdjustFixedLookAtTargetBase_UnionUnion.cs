using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067C1 RID: 26561
	public class IAdjustFixedLookAtTargetBase_UnionUnion
	{
		// Token: 0x1700C281 RID: 49793
		// (get) Token: 0x0602D3F3 RID: 185331 RVA: 0x006311A5 File Offset: 0x0062F3A5
		// (set) Token: 0x0602D3F4 RID: 185332 RVA: 0x006311AD File Offset: 0x0062F3AD
		public IAdjustFixedLookAtTargetBase_Union Type { get; set; }

		// Token: 0x1700C282 RID: 49794
		// (get) Token: 0x0602D3F5 RID: 185333 RVA: 0x006311B6 File Offset: 0x0062F3B6
		// (set) Token: 0x0602D3F6 RID: 185334 RVA: 0x006311BE File Offset: 0x0062F3BE
		public object Value { get; set; }

		// Token: 0x0602D3F7 RID: 185335 RVA: 0x006311C7 File Offset: 0x0062F3C7
		public IAdjustFixedLookAtTargetBase_UnionUnion()
		{
			this.Type = IAdjustFixedLookAtTargetBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D3F8 RID: 185336 RVA: 0x006311DD File Offset: 0x0062F3DD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D3F9 RID: 185337 RVA: 0x006311EF File Offset: 0x0062F3EF
		public IAdjustFixedLookAtTargetBaseT AsIAdjustFixedLookAtTargetBase()
		{
			return this.As<IAdjustFixedLookAtTargetBaseT>();
		}

		// Token: 0x0602D3FA RID: 185338 RVA: 0x006311F7 File Offset: 0x0062F3F7
		public static IAdjustFixedLookAtTargetBase_UnionUnion FromIAdjustFixedLookAtTargetBase(IAdjustFixedLookAtTargetBaseT _iadjustfixedlookattargetbase)
		{
			return new IAdjustFixedLookAtTargetBase_UnionUnion
			{
				Type = IAdjustFixedLookAtTargetBase_Union.IAdjustFixedLookAtTargetBase,
				Value = _iadjustfixedlookattargetbase
			};
		}

		// Token: 0x0602D3FB RID: 185339 RVA: 0x0063120C File Offset: 0x0062F40C
		public IAdjustFixedLookAtTargetRangeEntityT AsIAdjustFixedLookAtTargetRangeEntity()
		{
			return this.As<IAdjustFixedLookAtTargetRangeEntityT>();
		}

		// Token: 0x0602D3FC RID: 185340 RVA: 0x00631214 File Offset: 0x0062F414
		public static IAdjustFixedLookAtTargetBase_UnionUnion FromIAdjustFixedLookAtTargetRangeEntity(IAdjustFixedLookAtTargetRangeEntityT _iadjustfixedlookattargetrangeentity)
		{
			return new IAdjustFixedLookAtTargetBase_UnionUnion
			{
				Type = IAdjustFixedLookAtTargetBase_Union.IAdjustFixedLookAtTargetRangeEntity,
				Value = _iadjustfixedlookattargetrangeentity
			};
		}

		// Token: 0x0602D3FD RID: 185341 RVA: 0x0063122C File Offset: 0x0062F42C
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
