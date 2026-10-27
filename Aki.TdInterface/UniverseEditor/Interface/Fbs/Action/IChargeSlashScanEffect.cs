using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006355 RID: 25429
	public struct IChargeSlashScanEffect : IFlatbufferObject
	{
		// Token: 0x1700BDB7 RID: 48567
		// (get) Token: 0x0602BFC9 RID: 180169 RVA: 0x0060B787 File Offset: 0x00609987
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BFCA RID: 180170 RVA: 0x0060B794 File Offset: 0x00609994
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BFCB RID: 180171 RVA: 0x0060B79C File Offset: 0x0060999C
		public static IChargeSlashScanEffect GetRootAsIChargeSlashScanEffect(ByteBuffer _bb)
		{
			return IChargeSlashScanEffect.GetRootAsIChargeSlashScanEffect(_bb, default(IChargeSlashScanEffect));
		}

		// Token: 0x0602BFCC RID: 180172 RVA: 0x0060B7B8 File Offset: 0x006099B8
		public static IChargeSlashScanEffect GetRootAsIChargeSlashScanEffect(ByteBuffer _bb, IChargeSlashScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BFCD RID: 180173 RVA: 0x0060B7D5 File Offset: 0x006099D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BFCE RID: 180174 RVA: 0x0060B7E4 File Offset: 0x006099E4
		public IChargeSlashScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDB8 RID: 48568
		// (get) Token: 0x0602BFCF RID: 180175 RVA: 0x0060B7F4 File Offset: 0x006099F4
		public ESpecificScanType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecificScanType.None;
				}
				return (ESpecificScanType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BDB9 RID: 48569
		// (get) Token: 0x0602BFD0 RID: 180176 RVA: 0x0060B830 File Offset: 0x00609A30
		public int TriggerPosEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602BFD1 RID: 180177 RVA: 0x0060B86C File Offset: 0x00609A6C
		public static Offset<IChargeSlashScanEffect> CreateIChargeSlashScanEffect(FlatBufferBuilder builder, ESpecificScanType Type = ESpecificScanType.None, int TriggerPosEntityId = 0)
		{
			builder.StartTable(2);
			IChargeSlashScanEffect.AddTriggerPosEntityId(builder, TriggerPosEntityId);
			IChargeSlashScanEffect.AddType(builder, Type);
			return IChargeSlashScanEffect.EndIChargeSlashScanEffect(builder);
		}

		// Token: 0x0602BFD2 RID: 180178 RVA: 0x0060B889 File Offset: 0x00609A89
		public static void StartIChargeSlashScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BFD3 RID: 180179 RVA: 0x0060B892 File Offset: 0x00609A92
		public static void AddType(FlatBufferBuilder builder, ESpecificScanType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BFD4 RID: 180180 RVA: 0x0060B89D File Offset: 0x00609A9D
		public static void AddTriggerPosEntityId(FlatBufferBuilder builder, int triggerPosEntityId)
		{
			builder.AddInt(1, triggerPosEntityId, 0);
		}

		// Token: 0x0602BFD5 RID: 180181 RVA: 0x0060B8A8 File Offset: 0x00609AA8
		public static Offset<IChargeSlashScanEffect> EndIChargeSlashScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<IChargeSlashScanEffect>(builder.EndTable());
		}

		// Token: 0x0602BFD6 RID: 180182 RVA: 0x0060B8B8 File Offset: 0x00609AB8
		public IChargeSlashScanEffectT UnPack()
		{
			IChargeSlashScanEffectT chargeSlashScanEffectT = new IChargeSlashScanEffectT();
			this.UnPackTo(chargeSlashScanEffectT);
			return chargeSlashScanEffectT;
		}

		// Token: 0x0602BFD7 RID: 180183 RVA: 0x0060B8D3 File Offset: 0x00609AD3
		public void UnPackTo(IChargeSlashScanEffectT _o)
		{
			_o.Type = this.Type;
			_o.TriggerPosEntityId = this.TriggerPosEntityId;
		}

		// Token: 0x0602BFD8 RID: 180184 RVA: 0x0060B8F0 File Offset: 0x00609AF0
		public static Offset<IChargeSlashScanEffect> Pack(FlatBufferBuilder builder, IChargeSlashScanEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChargeSlashScanEffect>);
			}
			return IChargeSlashScanEffect.CreateIChargeSlashScanEffect(builder, _o.Type, _o.TriggerPosEntityId);
		}

		// Token: 0x04010920 RID: 67872
		private Table __p;
	}
}
