using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A15 RID: 18965
	public struct ICheckEntityReward : IFlatbufferObject
	{
		// Token: 0x1700894B RID: 35147
		// (get) Token: 0x0601DAC1 RID: 121537 RVA: 0x0042CD00 File Offset: 0x0042AF00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DAC2 RID: 121538 RVA: 0x0042CD0D File Offset: 0x0042AF0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DAC3 RID: 121539 RVA: 0x0042CD14 File Offset: 0x0042AF14
		public static ICheckEntityReward GetRootAsICheckEntityReward(ByteBuffer _bb)
		{
			return ICheckEntityReward.GetRootAsICheckEntityReward(_bb, default(ICheckEntityReward));
		}

		// Token: 0x0601DAC4 RID: 121540 RVA: 0x0042CD30 File Offset: 0x0042AF30
		public static ICheckEntityReward GetRootAsICheckEntityReward(ByteBuffer _bb, ICheckEntityReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DAC5 RID: 121541 RVA: 0x0042CD4D File Offset: 0x0042AF4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DAC6 RID: 121542 RVA: 0x0042CD5C File Offset: 0x0042AF5C
		public ICheckEntityReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700894C RID: 35148
		// (get) Token: 0x0601DAC7 RID: 121543 RVA: 0x0042CD6C File Offset: 0x0042AF6C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700894D RID: 35149
		// (get) Token: 0x0601DAC8 RID: 121544 RVA: 0x0042CDA8 File Offset: 0x0042AFA8
		public int EntityId
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

		// Token: 0x1700894E RID: 35150
		// (get) Token: 0x0601DAC9 RID: 121545 RVA: 0x0042CDE4 File Offset: 0x0042AFE4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DACA RID: 121546 RVA: 0x0042CE20 File Offset: 0x0042B020
		public static Offset<ICheckEntityReward> CreateICheckEntityReward(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckEntityReward.AddEntityId(builder, EntityId);
			ICheckEntityReward.AddNullMask(builder, NullMask);
			ICheckEntityReward.AddType(builder, Type);
			return ICheckEntityReward.EndICheckEntityReward(builder);
		}

		// Token: 0x0601DACB RID: 121547 RVA: 0x0042CE44 File Offset: 0x0042B044
		public static void StartICheckEntityReward(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601DACC RID: 121548 RVA: 0x0042CE4D File Offset: 0x0042B04D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DACD RID: 121549 RVA: 0x0042CE58 File Offset: 0x0042B058
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601DACE RID: 121550 RVA: 0x0042CE63 File Offset: 0x0042B063
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601DACF RID: 121551 RVA: 0x0042CE6E File Offset: 0x0042B06E
		public static Offset<ICheckEntityReward> EndICheckEntityReward(FlatBufferBuilder builder)
		{
			return new Offset<ICheckEntityReward>(builder.EndTable());
		}

		// Token: 0x0601DAD0 RID: 121552 RVA: 0x0042CE7C File Offset: 0x0042B07C
		public ICheckEntityRewardT UnPack()
		{
			ICheckEntityRewardT checkEntityRewardT = new ICheckEntityRewardT();
			this.UnPackTo(checkEntityRewardT);
			return checkEntityRewardT;
		}

		// Token: 0x0601DAD1 RID: 121553 RVA: 0x0042CE97 File Offset: 0x0042B097
		public void UnPackTo(ICheckEntityRewardT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601DAD2 RID: 121554 RVA: 0x0042CEC0 File Offset: 0x0042B0C0
		public static Offset<ICheckEntityReward> Pack(FlatBufferBuilder builder, ICheckEntityRewardT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckEntityReward>);
			}
			return ICheckEntityReward.CreateICheckEntityReward(builder, _o.Type, _o.EntityId, _o.NullMask);
		}

		// Token: 0x0400D261 RID: 53857
		private Table __p;
	}
}
