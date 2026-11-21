using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069C6 RID: 27078
	public struct IChargeSlashScanEffect : IFlatbufferObject
	{
		// Token: 0x1700C73F RID: 51007
		// (get) Token: 0x0602E733 RID: 190259 RVA: 0x006568DB File Offset: 0x00654ADB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E734 RID: 190260 RVA: 0x006568E8 File Offset: 0x00654AE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E735 RID: 190261 RVA: 0x006568F0 File Offset: 0x00654AF0
		public static IChargeSlashScanEffect GetRootAsIChargeSlashScanEffect(ByteBuffer _bb)
		{
			return IChargeSlashScanEffect.GetRootAsIChargeSlashScanEffect(_bb, default(IChargeSlashScanEffect));
		}

		// Token: 0x0602E736 RID: 190262 RVA: 0x0065690C File Offset: 0x00654B0C
		public static IChargeSlashScanEffect GetRootAsIChargeSlashScanEffect(ByteBuffer _bb, IChargeSlashScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E737 RID: 190263 RVA: 0x00656929 File Offset: 0x00654B29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E738 RID: 190264 RVA: 0x00656938 File Offset: 0x00654B38
		public IChargeSlashScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C740 RID: 51008
		// (get) Token: 0x0602E739 RID: 190265 RVA: 0x00656948 File Offset: 0x00654B48
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

		// Token: 0x1700C741 RID: 51009
		// (get) Token: 0x0602E73A RID: 190266 RVA: 0x00656984 File Offset: 0x00654B84
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

		// Token: 0x0602E73B RID: 190267 RVA: 0x006569C0 File Offset: 0x00654BC0
		public static Offset<IChargeSlashScanEffect> CreateIChargeSlashScanEffect(FlatBufferBuilder builder, ESpecificScanType Type = ESpecificScanType.None, int TriggerPosEntityId = 0)
		{
			builder.StartTable(2);
			IChargeSlashScanEffect.AddTriggerPosEntityId(builder, TriggerPosEntityId);
			IChargeSlashScanEffect.AddType(builder, Type);
			return IChargeSlashScanEffect.EndIChargeSlashScanEffect(builder);
		}

		// Token: 0x0602E73C RID: 190268 RVA: 0x006569DD File Offset: 0x00654BDD
		public static void StartIChargeSlashScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E73D RID: 190269 RVA: 0x006569E6 File Offset: 0x00654BE6
		public static void AddType(FlatBufferBuilder builder, ESpecificScanType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E73E RID: 190270 RVA: 0x006569F1 File Offset: 0x00654BF1
		public static void AddTriggerPosEntityId(FlatBufferBuilder builder, int triggerPosEntityId)
		{
			builder.AddInt(1, triggerPosEntityId, 0);
		}

		// Token: 0x0602E73F RID: 190271 RVA: 0x006569FC File Offset: 0x00654BFC
		public static Offset<IChargeSlashScanEffect> EndIChargeSlashScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<IChargeSlashScanEffect>(builder.EndTable());
		}

		// Token: 0x0602E740 RID: 190272 RVA: 0x00656A0C File Offset: 0x00654C0C
		public IChargeSlashScanEffectT UnPack()
		{
			IChargeSlashScanEffectT chargeSlashScanEffectT = new IChargeSlashScanEffectT();
			this.UnPackTo(chargeSlashScanEffectT);
			return chargeSlashScanEffectT;
		}

		// Token: 0x0602E741 RID: 190273 RVA: 0x00656A27 File Offset: 0x00654C27
		public void UnPackTo(IChargeSlashScanEffectT _o)
		{
			_o.Type = this.Type;
			_o.TriggerPosEntityId = this.TriggerPosEntityId;
		}

		// Token: 0x0602E742 RID: 190274 RVA: 0x00656A44 File Offset: 0x00654C44
		public static Offset<IChargeSlashScanEffect> Pack(FlatBufferBuilder builder, IChargeSlashScanEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChargeSlashScanEffect>);
			}
			return IChargeSlashScanEffect.CreateIChargeSlashScanEffect(builder, _o.Type, _o.TriggerPosEntityId);
		}

		// Token: 0x04011735 RID: 71477
		private Table __p;
	}
}
