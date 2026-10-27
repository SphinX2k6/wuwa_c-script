using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E63 RID: 15971
	public struct IFlipperConditionStepFight : IFlatbufferObject
	{
		// Token: 0x17006EBA RID: 28346
		// (get) Token: 0x060167B8 RID: 92088 RVA: 0x0034002A File Offset: 0x0033E22A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060167B9 RID: 92089 RVA: 0x00340037 File Offset: 0x0033E237
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060167BA RID: 92090 RVA: 0x00340040 File Offset: 0x0033E240
		public static IFlipperConditionStepFight GetRootAsIFlipperConditionStepFight(ByteBuffer _bb)
		{
			return IFlipperConditionStepFight.GetRootAsIFlipperConditionStepFight(_bb, default(IFlipperConditionStepFight));
		}

		// Token: 0x060167BB RID: 92091 RVA: 0x0034005C File Offset: 0x0033E25C
		public static IFlipperConditionStepFight GetRootAsIFlipperConditionStepFight(ByteBuffer _bb, IFlipperConditionStepFight obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060167BC RID: 92092 RVA: 0x00340079 File Offset: 0x0033E279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060167BD RID: 92093 RVA: 0x00340088 File Offset: 0x0033E288
		public IFlipperConditionStepFight __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006EBB RID: 28347
		// (get) Token: 0x060167BE RID: 92094 RVA: 0x00340098 File Offset: 0x0033E298
		public EFlipperConditionStep Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFlipperConditionStep.Fight;
				}
				return (EFlipperConditionStep)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060167BF RID: 92095 RVA: 0x003400D4 File Offset: 0x0033E2D4
		public static Offset<IFlipperConditionStepFight> CreateIFlipperConditionStepFight(FlatBufferBuilder builder, EFlipperConditionStep Type = EFlipperConditionStep.Fight)
		{
			builder.StartTable(1);
			IFlipperConditionStepFight.AddType(builder, Type);
			return IFlipperConditionStepFight.EndIFlipperConditionStepFight(builder);
		}

		// Token: 0x060167C0 RID: 92096 RVA: 0x003400EA File Offset: 0x0033E2EA
		public static void StartIFlipperConditionStepFight(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060167C1 RID: 92097 RVA: 0x003400F3 File Offset: 0x0033E2F3
		public static void AddType(FlatBufferBuilder builder, EFlipperConditionStep type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060167C2 RID: 92098 RVA: 0x003400FE File Offset: 0x0033E2FE
		public static Offset<IFlipperConditionStepFight> EndIFlipperConditionStepFight(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperConditionStepFight>(builder.EndTable());
		}

		// Token: 0x060167C3 RID: 92099 RVA: 0x0034010C File Offset: 0x0033E30C
		public IFlipperConditionStepFightT UnPack()
		{
			IFlipperConditionStepFightT flipperConditionStepFightT = new IFlipperConditionStepFightT();
			this.UnPackTo(flipperConditionStepFightT);
			return flipperConditionStepFightT;
		}

		// Token: 0x060167C4 RID: 92100 RVA: 0x00340127 File Offset: 0x0033E327
		public void UnPackTo(IFlipperConditionStepFightT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060167C5 RID: 92101 RVA: 0x00340138 File Offset: 0x0033E338
		public static Offset<IFlipperConditionStepFight> Pack(FlatBufferBuilder builder, IFlipperConditionStepFightT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperConditionStepFight>);
			}
			return IFlipperConditionStepFight.CreateIFlipperConditionStepFight(builder, _o.Type);
		}

		// Token: 0x0400B815 RID: 47125
		private Table __p;
	}
}
