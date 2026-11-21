using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C7D RID: 31869
	public struct ITriggerSpecificScanEffect : IFlatbufferObject
	{
		// Token: 0x1700EE9C RID: 61084
		// (get) Token: 0x06039769 RID: 235369 RVA: 0x007C1CC6 File Offset: 0x007BFEC6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603976A RID: 235370 RVA: 0x007C1CD3 File Offset: 0x007BFED3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603976B RID: 235371 RVA: 0x007C1CDC File Offset: 0x007BFEDC
		public static ITriggerSpecificScanEffect GetRootAsITriggerSpecificScanEffect(ByteBuffer _bb)
		{
			return ITriggerSpecificScanEffect.GetRootAsITriggerSpecificScanEffect(_bb, default(ITriggerSpecificScanEffect));
		}

		// Token: 0x0603976C RID: 235372 RVA: 0x007C1CF8 File Offset: 0x007BFEF8
		public static ITriggerSpecificScanEffect GetRootAsITriggerSpecificScanEffect(ByteBuffer _bb, ITriggerSpecificScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603976D RID: 235373 RVA: 0x007C1D15 File Offset: 0x007BFF15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603976E RID: 235374 RVA: 0x007C1D24 File Offset: 0x007BFF24
		public ITriggerSpecificScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE9D RID: 61085
		// (get) Token: 0x0603976F RID: 235375 RVA: 0x007C1D34 File Offset: 0x007BFF34
		public TSpecificScanEffect ScanEffectType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TSpecificScanEffect.NONE;
				}
				return (TSpecificScanEffect)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039770 RID: 235376 RVA: 0x007C1D70 File Offset: 0x007BFF70
		public TTable? ScanEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039771 RID: 235377 RVA: 0x007C1DB4 File Offset: 0x007BFFB4
		public IChargeSlashScanEffect ScanEffectAsIChargeSlashScanEffect()
		{
			return this.ScanEffect<IChargeSlashScanEffect>().Value;
		}

		// Token: 0x06039772 RID: 235378 RVA: 0x007C1DD0 File Offset: 0x007BFFD0
		public IFlyingFeatherScanEffect ScanEffectAsIFlyingFeatherScanEffect()
		{
			return this.ScanEffect<IFlyingFeatherScanEffect>().Value;
		}

		// Token: 0x06039773 RID: 235379 RVA: 0x007C1DEB File Offset: 0x007BFFEB
		public static Offset<ITriggerSpecificScanEffect> CreateITriggerSpecificScanEffect(FlatBufferBuilder builder, TSpecificScanEffect ScanEffect_type = TSpecificScanEffect.NONE, int ScanEffectOffset = 0)
		{
			builder.StartTable(2);
			ITriggerSpecificScanEffect.AddScanEffect(builder, ScanEffectOffset);
			ITriggerSpecificScanEffect.AddScanEffectType(builder, ScanEffect_type);
			return ITriggerSpecificScanEffect.EndITriggerSpecificScanEffect(builder);
		}

		// Token: 0x06039774 RID: 235380 RVA: 0x007C1E08 File Offset: 0x007C0008
		public static void StartITriggerSpecificScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039775 RID: 235381 RVA: 0x007C1E11 File Offset: 0x007C0011
		public static void AddScanEffectType(FlatBufferBuilder builder, TSpecificScanEffect scanEffectType)
		{
			builder.AddByte(0, (byte)scanEffectType, 0);
		}

		// Token: 0x06039776 RID: 235382 RVA: 0x007C1E1C File Offset: 0x007C001C
		public static void AddScanEffect(FlatBufferBuilder builder, int scanEffectOffset)
		{
			builder.AddOffset(1, scanEffectOffset, 0);
		}

		// Token: 0x06039777 RID: 235383 RVA: 0x007C1E27 File Offset: 0x007C0027
		public static Offset<ITriggerSpecificScanEffect> EndITriggerSpecificScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerSpecificScanEffect>(builder.EndTable());
		}

		// Token: 0x06039778 RID: 235384 RVA: 0x007C1E34 File Offset: 0x007C0034
		public ITriggerSpecificScanEffectT UnPack()
		{
			ITriggerSpecificScanEffectT triggerSpecificScanEffectT = new ITriggerSpecificScanEffectT();
			this.UnPackTo(triggerSpecificScanEffectT);
			return triggerSpecificScanEffectT;
		}

		// Token: 0x06039779 RID: 235385 RVA: 0x007C1E50 File Offset: 0x007C0050
		public void UnPackTo(ITriggerSpecificScanEffectT _o)
		{
			_o.ScanEffect = new TSpecificScanEffectUnion();
			_o.ScanEffect.Type = this.ScanEffectType;
			TSpecificScanEffect scanEffectType = this.ScanEffectType;
			if (scanEffectType == TSpecificScanEffect.IChargeSlashScanEffect)
			{
				_o.ScanEffect.Value = ((this.ScanEffect<IChargeSlashScanEffect>() != null) ? this.ScanEffect<IChargeSlashScanEffect>().Value.UnPack() : null);
				return;
			}
			if (scanEffectType != TSpecificScanEffect.IFlyingFeatherScanEffect)
			{
				return;
			}
			_o.ScanEffect.Value = ((this.ScanEffect<IFlyingFeatherScanEffect>() != null) ? this.ScanEffect<IFlyingFeatherScanEffect>().Value.UnPack() : null);
		}

		// Token: 0x0603977A RID: 235386 RVA: 0x007C1EF4 File Offset: 0x007C00F4
		public static Offset<ITriggerSpecificScanEffect> Pack(FlatBufferBuilder builder, ITriggerSpecificScanEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerSpecificScanEffect>);
			}
			TSpecificScanEffect scanEffect_type = (_o.ScanEffect == null) ? TSpecificScanEffect.NONE : _o.ScanEffect.Type;
			int scanEffectOffset = (_o.ScanEffect == null) ? 0 : TSpecificScanEffectUnion.Pack(builder, _o.ScanEffect);
			return ITriggerSpecificScanEffect.CreateITriggerSpecificScanEffect(builder, scanEffect_type, scanEffectOffset);
		}

		// Token: 0x04013349 RID: 78665
		private Table __p;
	}
}
