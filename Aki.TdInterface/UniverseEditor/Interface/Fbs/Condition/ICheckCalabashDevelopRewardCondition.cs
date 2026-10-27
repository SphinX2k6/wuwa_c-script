using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004991 RID: 18833
	public struct ICheckCalabashDevelopRewardCondition : IFlatbufferObject
	{
		// Token: 0x1700880B RID: 34827
		// (get) Token: 0x0601D5E0 RID: 120288 RVA: 0x00423DE0 File Offset: 0x00421FE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D5E1 RID: 120289 RVA: 0x00423DED File Offset: 0x00421FED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D5E2 RID: 120290 RVA: 0x00423DF4 File Offset: 0x00421FF4
		public static ICheckCalabashDevelopRewardCondition GetRootAsICheckCalabashDevelopRewardCondition(ByteBuffer _bb)
		{
			return ICheckCalabashDevelopRewardCondition.GetRootAsICheckCalabashDevelopRewardCondition(_bb, default(ICheckCalabashDevelopRewardCondition));
		}

		// Token: 0x0601D5E3 RID: 120291 RVA: 0x00423E10 File Offset: 0x00422010
		public static ICheckCalabashDevelopRewardCondition GetRootAsICheckCalabashDevelopRewardCondition(ByteBuffer _bb, ICheckCalabashDevelopRewardCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D5E4 RID: 120292 RVA: 0x00423E2D File Offset: 0x0042202D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D5E5 RID: 120293 RVA: 0x00423E3C File Offset: 0x0042203C
		public ICheckCalabashDevelopRewardCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700880C RID: 34828
		// (get) Token: 0x0601D5E6 RID: 120294 RVA: 0x00423E4C File Offset: 0x0042204C
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

		// Token: 0x1700880D RID: 34829
		// (get) Token: 0x0601D5E7 RID: 120295 RVA: 0x00423E88 File Offset: 0x00422088
		public int MonsterId
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

		// Token: 0x1700880E RID: 34830
		// (get) Token: 0x0601D5E8 RID: 120296 RVA: 0x00423EC4 File Offset: 0x004220C4
		public ECalabashDevelop Develop
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECalabashDevelop.None;
				}
				return (ECalabashDevelop)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D5E9 RID: 120297 RVA: 0x00423F00 File Offset: 0x00422100
		public static Offset<ICheckCalabashDevelopRewardCondition> CreateICheckCalabashDevelopRewardCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int MonsterId = 0, ECalabashDevelop Develop = ECalabashDevelop.None)
		{
			builder.StartTable(3);
			ICheckCalabashDevelopRewardCondition.AddMonsterId(builder, MonsterId);
			ICheckCalabashDevelopRewardCondition.AddDevelop(builder, Develop);
			ICheckCalabashDevelopRewardCondition.AddType(builder, Type);
			return ICheckCalabashDevelopRewardCondition.EndICheckCalabashDevelopRewardCondition(builder);
		}

		// Token: 0x0601D5EA RID: 120298 RVA: 0x00423F24 File Offset: 0x00422124
		public static void StartICheckCalabashDevelopRewardCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D5EB RID: 120299 RVA: 0x00423F2D File Offset: 0x0042212D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D5EC RID: 120300 RVA: 0x00423F38 File Offset: 0x00422138
		public static void AddMonsterId(FlatBufferBuilder builder, int monsterId)
		{
			builder.AddInt(1, monsterId, 0);
		}

		// Token: 0x0601D5ED RID: 120301 RVA: 0x00423F43 File Offset: 0x00422143
		public static void AddDevelop(FlatBufferBuilder builder, ECalabashDevelop develop)
		{
			builder.AddByte(2, (byte)develop, 0);
		}

		// Token: 0x0601D5EE RID: 120302 RVA: 0x00423F4E File Offset: 0x0042214E
		public static Offset<ICheckCalabashDevelopRewardCondition> EndICheckCalabashDevelopRewardCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckCalabashDevelopRewardCondition>(builder.EndTable());
		}

		// Token: 0x0601D5EF RID: 120303 RVA: 0x00423F5C File Offset: 0x0042215C
		public ICheckCalabashDevelopRewardConditionT UnPack()
		{
			ICheckCalabashDevelopRewardConditionT checkCalabashDevelopRewardConditionT = new ICheckCalabashDevelopRewardConditionT();
			this.UnPackTo(checkCalabashDevelopRewardConditionT);
			return checkCalabashDevelopRewardConditionT;
		}

		// Token: 0x0601D5F0 RID: 120304 RVA: 0x00423F77 File Offset: 0x00422177
		public void UnPackTo(ICheckCalabashDevelopRewardConditionT _o)
		{
			_o.Type = this.Type;
			_o.MonsterId = this.MonsterId;
			_o.Develop = this.Develop;
		}

		// Token: 0x0601D5F1 RID: 120305 RVA: 0x00423FA0 File Offset: 0x004221A0
		public static Offset<ICheckCalabashDevelopRewardCondition> Pack(FlatBufferBuilder builder, ICheckCalabashDevelopRewardConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckCalabashDevelopRewardCondition>);
			}
			return ICheckCalabashDevelopRewardCondition.CreateICheckCalabashDevelopRewardCondition(builder, _o.Type, _o.MonsterId, _o.Develop);
		}

		// Token: 0x0400D1A1 RID: 53665
		private Table __p;
	}
}
