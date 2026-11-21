using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EBA RID: 28346
	public struct IFlyingFeatherScanEffect : IFlatbufferObject
	{
		// Token: 0x1700CFED RID: 53229
		// (get) Token: 0x060310A7 RID: 200871 RVA: 0x006A69E8 File Offset: 0x006A4BE8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060310A8 RID: 200872 RVA: 0x006A69F5 File Offset: 0x006A4BF5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060310A9 RID: 200873 RVA: 0x006A69FC File Offset: 0x006A4BFC
		public static IFlyingFeatherScanEffect GetRootAsIFlyingFeatherScanEffect(ByteBuffer _bb)
		{
			return IFlyingFeatherScanEffect.GetRootAsIFlyingFeatherScanEffect(_bb, default(IFlyingFeatherScanEffect));
		}

		// Token: 0x060310AA RID: 200874 RVA: 0x006A6A18 File Offset: 0x006A4C18
		public static IFlyingFeatherScanEffect GetRootAsIFlyingFeatherScanEffect(ByteBuffer _bb, IFlyingFeatherScanEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060310AB RID: 200875 RVA: 0x006A6A35 File Offset: 0x006A4C35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060310AC RID: 200876 RVA: 0x006A6A44 File Offset: 0x006A4C44
		public IFlyingFeatherScanEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CFEE RID: 53230
		// (get) Token: 0x060310AD RID: 200877 RVA: 0x006A6A54 File Offset: 0x006A4C54
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

		// Token: 0x1700CFEF RID: 53231
		// (get) Token: 0x060310AE RID: 200878 RVA: 0x006A6A90 File Offset: 0x006A4C90
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

		// Token: 0x060310AF RID: 200879 RVA: 0x006A6ACC File Offset: 0x006A4CCC
		public static Offset<IFlyingFeatherScanEffect> CreateIFlyingFeatherScanEffect(FlatBufferBuilder builder, ESpecificScanType Type = ESpecificScanType.None, int TriggerPosEntityId = 0)
		{
			builder.StartTable(2);
			IFlyingFeatherScanEffect.AddTriggerPosEntityId(builder, TriggerPosEntityId);
			IFlyingFeatherScanEffect.AddType(builder, Type);
			return IFlyingFeatherScanEffect.EndIFlyingFeatherScanEffect(builder);
		}

		// Token: 0x060310B0 RID: 200880 RVA: 0x006A6AE9 File Offset: 0x006A4CE9
		public static void StartIFlyingFeatherScanEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060310B1 RID: 200881 RVA: 0x006A6AF2 File Offset: 0x006A4CF2
		public static void AddType(FlatBufferBuilder builder, ESpecificScanType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060310B2 RID: 200882 RVA: 0x006A6AFD File Offset: 0x006A4CFD
		public static void AddTriggerPosEntityId(FlatBufferBuilder builder, int triggerPosEntityId)
		{
			builder.AddInt(1, triggerPosEntityId, 0);
		}

		// Token: 0x060310B3 RID: 200883 RVA: 0x006A6B08 File Offset: 0x006A4D08
		public static Offset<IFlyingFeatherScanEffect> EndIFlyingFeatherScanEffect(FlatBufferBuilder builder)
		{
			return new Offset<IFlyingFeatherScanEffect>(builder.EndTable());
		}

		// Token: 0x060310B4 RID: 200884 RVA: 0x006A6B18 File Offset: 0x006A4D18
		public IFlyingFeatherScanEffectT UnPack()
		{
			IFlyingFeatherScanEffectT flyingFeatherScanEffectT = new IFlyingFeatherScanEffectT();
			this.UnPackTo(flyingFeatherScanEffectT);
			return flyingFeatherScanEffectT;
		}

		// Token: 0x060310B5 RID: 200885 RVA: 0x006A6B33 File Offset: 0x006A4D33
		public void UnPackTo(IFlyingFeatherScanEffectT _o)
		{
			_o.Type = this.Type;
			_o.TriggerPosEntityId = this.TriggerPosEntityId;
		}

		// Token: 0x060310B6 RID: 200886 RVA: 0x006A6B50 File Offset: 0x006A4D50
		public static Offset<IFlyingFeatherScanEffect> Pack(FlatBufferBuilder builder, IFlyingFeatherScanEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlyingFeatherScanEffect>);
			}
			return IFlyingFeatherScanEffect.CreateIFlyingFeatherScanEffect(builder, _o.Type, _o.TriggerPosEntityId);
		}

		// Token: 0x04011DB4 RID: 73140
		private Table __p;
	}
}
