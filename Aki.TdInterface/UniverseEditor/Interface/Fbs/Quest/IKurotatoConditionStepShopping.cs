using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004325 RID: 17189
	public struct IKurotatoConditionStepShopping : IFlatbufferObject
	{
		// Token: 0x170075AA RID: 30122
		// (get) Token: 0x060182CC RID: 99020 RVA: 0x0037277D File Offset: 0x0037097D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060182CD RID: 99021 RVA: 0x0037278A File Offset: 0x0037098A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060182CE RID: 99022 RVA: 0x00372794 File Offset: 0x00370994
		public static IKurotatoConditionStepShopping GetRootAsIKurotatoConditionStepShopping(ByteBuffer _bb)
		{
			return IKurotatoConditionStepShopping.GetRootAsIKurotatoConditionStepShopping(_bb, default(IKurotatoConditionStepShopping));
		}

		// Token: 0x060182CF RID: 99023 RVA: 0x003727B0 File Offset: 0x003709B0
		public static IKurotatoConditionStepShopping GetRootAsIKurotatoConditionStepShopping(ByteBuffer _bb, IKurotatoConditionStepShopping obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060182D0 RID: 99024 RVA: 0x003727CD File Offset: 0x003709CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060182D1 RID: 99025 RVA: 0x003727DC File Offset: 0x003709DC
		public IKurotatoConditionStepShopping __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075AB RID: 30123
		// (get) Token: 0x060182D2 RID: 99026 RVA: 0x003727EC File Offset: 0x003709EC
		public EKurotatoConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return (EKurotatoConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060182D3 RID: 99027 RVA: 0x00372828 File Offset: 0x00370A28
		public static Offset<IKurotatoConditionStepShopping> CreateIKurotatoConditionStepShopping(FlatBufferBuilder builder, EKurotatoConditionStep Type = EKurotatoConditionStep.Prepare)
		{
			builder.StartTable(1);
			IKurotatoConditionStepShopping.AddType(builder, Type);
			return IKurotatoConditionStepShopping.EndIKurotatoConditionStepShopping(builder);
		}

		// Token: 0x060182D4 RID: 99028 RVA: 0x0037283E File Offset: 0x00370A3E
		public static void StartIKurotatoConditionStepShopping(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060182D5 RID: 99029 RVA: 0x00372847 File Offset: 0x00370A47
		public static void AddType(FlatBufferBuilder builder, EKurotatoConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060182D6 RID: 99030 RVA: 0x00372852 File Offset: 0x00370A52
		public static Offset<IKurotatoConditionStepShopping> EndIKurotatoConditionStepShopping(FlatBufferBuilder builder)
		{
			return new Offset<IKurotatoConditionStepShopping>(builder.EndTable());
		}

		// Token: 0x060182D7 RID: 99031 RVA: 0x00372860 File Offset: 0x00370A60
		public IKurotatoConditionStepShoppingT UnPack()
		{
			IKurotatoConditionStepShoppingT kurotatoConditionStepShoppingT = new IKurotatoConditionStepShoppingT();
			this.UnPackTo(kurotatoConditionStepShoppingT);
			return kurotatoConditionStepShoppingT;
		}

		// Token: 0x060182D8 RID: 99032 RVA: 0x0037287B File Offset: 0x00370A7B
		public void UnPackTo(IKurotatoConditionStepShoppingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060182D9 RID: 99033 RVA: 0x0037288C File Offset: 0x00370A8C
		public static Offset<IKurotatoConditionStepShopping> Pack(FlatBufferBuilder builder, IKurotatoConditionStepShoppingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKurotatoConditionStepShopping>);
			}
			return IKurotatoConditionStepShopping.CreateIKurotatoConditionStepShopping(builder, _o.Type);
		}

		// Token: 0x0400C2A4 RID: 49828
		private Table __p;
	}
}
