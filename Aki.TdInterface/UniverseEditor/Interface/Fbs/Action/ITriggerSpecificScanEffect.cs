using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200748A RID: 29834
	public struct ITriggerSpecificScanEffect : IFlatbufferObject
	{
		// Token: 0x1700E27D RID: 57981
		// (get) Token: 0x0603637C RID: 222076 RVA: 0x0075EF0A File Offset: 0x0075D10A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603637D RID: 222077 RVA: 0x0075EF17 File Offset: 0x0075D117
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603637E RID: 222078 RVA: 0x0075EF20 File Offset: 0x0075D120
		public static ITriggerSpecificScanEffect GetRootAsITriggerSpecificScanEffect(ByteBuffer _bb)
		{
			return ITriggerSpecificScanEffect.GetRootAsITriggerSpecificScanEffect(_bb, default(ITriggerSpecificScanEffect));
		}

		// Token: 0x0603637F RID: 222079 RVA: 0x0075EF3C File Offset: 0x0075D13C
		public static ITriggerSpecificScanEffect GetRootAsITriggerSpecificScanEffect(ByteBuffer _bb, ITriggerSpecificScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036380 RID: 222080 RVA: 0x0075EF59 File Offset: 0x0075D159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036381 RID: 222081 RVA: 0x0075EF68 File Offset: 0x0075D168
		public ITriggerSpecificScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E27E RID: 57982
		// (get) Token: 0x06036382 RID: 222082 RVA: 0x0075EF78 File Offset: 0x0075D178
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

		// Token: 0x06036383 RID: 222083 RVA: 0x0075EFB4 File Offset: 0x0075D1B4
		public TTable? ScanEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036384 RID: 222084 RVA: 0x0075EFF8 File Offset: 0x0075D1F8
		public IChargeSlashScanEffect ScanEffectAsIChargeSlashScanEffect()
		{
			return this.ScanEffect<IChargeSlashScanEffect>().Value;
		}

		// Token: 0x06036385 RID: 222085 RVA: 0x0075F014 File Offset: 0x0075D214
		public IFlyingFeatherScanEffect ScanEffectAsIFlyingFeatherScanEffect()
		{
			return this.ScanEffect<IFlyingFeatherScanEffect>().Value;
		}

		// Token: 0x06036386 RID: 222086 RVA: 0x0075F02F File Offset: 0x0075D22F
		public static Offset<ITriggerSpecificScanEffect> CreateITriggerSpecificScanEffect(FlatBufferBuilder builder, TSpecificScanEffect ScanEffect_type = TSpecificScanEffect.NONE, int ScanEffectOffset = 0)
		{
			builder.StartTable(2);
			ITriggerSpecificScanEffect.AddScanEffect(builder, ScanEffectOffset);
			ITriggerSpecificScanEffect.AddScanEffectType(builder, ScanEffect_type);
			return ITriggerSpecificScanEffect.EndITriggerSpecificScanEffect(builder);
		}

		// Token: 0x06036387 RID: 222087 RVA: 0x0075F04C File Offset: 0x0075D24C
		public static void StartITriggerSpecificScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036388 RID: 222088 RVA: 0x0075F055 File Offset: 0x0075D255
		public static void AddScanEffectType(FlatBufferBuilder builder, TSpecificScanEffect scanEffectType)
		{
			builder.AddByte(0, (byte)scanEffectType, 0);
		}

		// Token: 0x06036389 RID: 222089 RVA: 0x0075F060 File Offset: 0x0075D260
		public static void AddScanEffect(FlatBufferBuilder builder, int scanEffectOffset)
		{
			builder.AddOffset(1, scanEffectOffset, 0);
		}

		// Token: 0x0603638A RID: 222090 RVA: 0x0075F06B File Offset: 0x0075D26B
		public static Offset<ITriggerSpecificScanEffect> EndITriggerSpecificScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerSpecificScanEffect>(builder.EndTable());
		}

		// Token: 0x0603638B RID: 222091 RVA: 0x0075F078 File Offset: 0x0075D278
		public ITriggerSpecificScanEffectT UnPack()
		{
			ITriggerSpecificScanEffectT triggerSpecificScanEffectT = new ITriggerSpecificScanEffectT();
			this.UnPackTo(triggerSpecificScanEffectT);
			return triggerSpecificScanEffectT;
		}

		// Token: 0x0603638C RID: 222092 RVA: 0x0075F094 File Offset: 0x0075D294
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

		// Token: 0x0603638D RID: 222093 RVA: 0x0075F138 File Offset: 0x0075D338
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

		// Token: 0x04012321 RID: 74529
		private Table __p;
	}
}
