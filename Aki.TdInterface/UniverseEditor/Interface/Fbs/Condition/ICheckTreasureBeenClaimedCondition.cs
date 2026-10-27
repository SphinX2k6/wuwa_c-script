using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B65 RID: 19301
	public struct ICheckTreasureBeenClaimedCondition : IFlatbufferObject
	{
		// Token: 0x17008C10 RID: 35856
		// (get) Token: 0x0601E685 RID: 124549 RVA: 0x0044262E File Offset: 0x0044082E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E686 RID: 124550 RVA: 0x0044263B File Offset: 0x0044083B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E687 RID: 124551 RVA: 0x00442644 File Offset: 0x00440844
		public static ICheckTreasureBeenClaimedCondition GetRootAsICheckTreasureBeenClaimedCondition(ByteBuffer _bb)
		{
			return ICheckTreasureBeenClaimedCondition.GetRootAsICheckTreasureBeenClaimedCondition(_bb, default(ICheckTreasureBeenClaimedCondition));
		}

		// Token: 0x0601E688 RID: 124552 RVA: 0x00442660 File Offset: 0x00440860
		public static ICheckTreasureBeenClaimedCondition GetRootAsICheckTreasureBeenClaimedCondition(ByteBuffer _bb, ICheckTreasureBeenClaimedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E689 RID: 124553 RVA: 0x0044267D File Offset: 0x0044087D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E68A RID: 124554 RVA: 0x0044268C File Offset: 0x0044088C
		public ICheckTreasureBeenClaimedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C11 RID: 35857
		// (get) Token: 0x0601E68B RID: 124555 RVA: 0x0044269C File Offset: 0x0044089C
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

		// Token: 0x17008C12 RID: 35858
		// (get) Token: 0x0601E68C RID: 124556 RVA: 0x004426D8 File Offset: 0x004408D8
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

		// Token: 0x0601E68D RID: 124557 RVA: 0x00442714 File Offset: 0x00440914
		public static Offset<ICheckTreasureBeenClaimedCondition> CreateICheckTreasureBeenClaimedCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0)
		{
			builder.StartTable(2);
			ICheckTreasureBeenClaimedCondition.AddEntityId(builder, EntityId);
			ICheckTreasureBeenClaimedCondition.AddType(builder, Type);
			return ICheckTreasureBeenClaimedCondition.EndICheckTreasureBeenClaimedCondition(builder);
		}

		// Token: 0x0601E68E RID: 124558 RVA: 0x00442731 File Offset: 0x00440931
		public static void StartICheckTreasureBeenClaimedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E68F RID: 124559 RVA: 0x0044273A File Offset: 0x0044093A
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E690 RID: 124560 RVA: 0x00442745 File Offset: 0x00440945
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601E691 RID: 124561 RVA: 0x00442750 File Offset: 0x00440950
		public static Offset<ICheckTreasureBeenClaimedCondition> EndICheckTreasureBeenClaimedCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTreasureBeenClaimedCondition>(builder.EndTable());
		}

		// Token: 0x0601E692 RID: 124562 RVA: 0x00442760 File Offset: 0x00440960
		public ICheckTreasureBeenClaimedConditionT UnPack()
		{
			ICheckTreasureBeenClaimedConditionT checkTreasureBeenClaimedConditionT = new ICheckTreasureBeenClaimedConditionT();
			this.UnPackTo(checkTreasureBeenClaimedConditionT);
			return checkTreasureBeenClaimedConditionT;
		}

		// Token: 0x0601E693 RID: 124563 RVA: 0x0044277B File Offset: 0x0044097B
		public void UnPackTo(ICheckTreasureBeenClaimedConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x0601E694 RID: 124564 RVA: 0x00442798 File Offset: 0x00440998
		public static Offset<ICheckTreasureBeenClaimedCondition> Pack(FlatBufferBuilder builder, ICheckTreasureBeenClaimedConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTreasureBeenClaimedCondition>);
			}
			return ICheckTreasureBeenClaimedCondition.CreateICheckTreasureBeenClaimedCondition(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400D42E RID: 54318
		private Table __p;
	}
}
