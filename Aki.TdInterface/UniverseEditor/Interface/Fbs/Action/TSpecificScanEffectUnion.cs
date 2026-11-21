using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FD1 RID: 32721
	public class TSpecificScanEffectUnion
	{
		// Token: 0x1700F303 RID: 62211
		// (get) Token: 0x0603AEA5 RID: 241317 RVA: 0x007EA162 File Offset: 0x007E8362
		// (set) Token: 0x0603AEA6 RID: 241318 RVA: 0x007EA16A File Offset: 0x007E836A
		public TSpecificScanEffect Type { get; set; }

		// Token: 0x1700F304 RID: 62212
		// (get) Token: 0x0603AEA7 RID: 241319 RVA: 0x007EA173 File Offset: 0x007E8373
		// (set) Token: 0x0603AEA8 RID: 241320 RVA: 0x007EA17B File Offset: 0x007E837B
		public object Value { get; set; }

		// Token: 0x0603AEA9 RID: 241321 RVA: 0x007EA184 File Offset: 0x007E8384
		public TSpecificScanEffectUnion()
		{
			this.Type = TSpecificScanEffect.NONE;
			this.Value = null;
		}

		// Token: 0x0603AEAA RID: 241322 RVA: 0x007EA19A File Offset: 0x007E839A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AEAB RID: 241323 RVA: 0x007EA1AC File Offset: 0x007E83AC
		public IChargeSlashScanEffectT AsIChargeSlashScanEffect()
		{
			return this.As<IChargeSlashScanEffectT>();
		}

		// Token: 0x0603AEAC RID: 241324 RVA: 0x007EA1B4 File Offset: 0x007E83B4
		public static TSpecificScanEffectUnion FromIChargeSlashScanEffect(IChargeSlashScanEffectT _ichargeslashscaneffect)
		{
			return new TSpecificScanEffectUnion
			{
				Type = TSpecificScanEffect.IChargeSlashScanEffect,
				Value = _ichargeslashscaneffect
			};
		}

		// Token: 0x0603AEAD RID: 241325 RVA: 0x007EA1C9 File Offset: 0x007E83C9
		public IFlyingFeatherScanEffectT AsIFlyingFeatherScanEffect()
		{
			return this.As<IFlyingFeatherScanEffectT>();
		}

		// Token: 0x0603AEAE RID: 241326 RVA: 0x007EA1D1 File Offset: 0x007E83D1
		public static TSpecificScanEffectUnion FromIFlyingFeatherScanEffect(IFlyingFeatherScanEffectT _iflyingfeatherscaneffect)
		{
			return new TSpecificScanEffectUnion
			{
				Type = TSpecificScanEffect.IFlyingFeatherScanEffect,
				Value = _iflyingfeatherscaneffect
			};
		}

		// Token: 0x0603AEAF RID: 241327 RVA: 0x007EA1E8 File Offset: 0x007E83E8
		public static int Pack(FlatBufferBuilder builder, TSpecificScanEffectUnion _o)
		{
			TSpecificScanEffect type = _o.Type;
			if (type == TSpecificScanEffect.IChargeSlashScanEffect)
			{
				return IChargeSlashScanEffect.Pack(builder, _o.AsIChargeSlashScanEffect()).Value;
			}
			if (type != TSpecificScanEffect.IFlyingFeatherScanEffect)
			{
				return 0;
			}
			return IFlyingFeatherScanEffect.Pack(builder, _o.AsIFlyingFeatherScanEffect()).Value;
		}
	}
}
