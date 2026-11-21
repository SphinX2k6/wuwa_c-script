using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200504C RID: 20556
	public struct ICheckTreasureBeenClaimedCondition : IFlatbufferObject
	{
		// Token: 0x17009320 RID: 37664
		// (get) Token: 0x06020213 RID: 131603 RVA: 0x00474E7A File Offset: 0x0047307A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020214 RID: 131604 RVA: 0x00474E87 File Offset: 0x00473087
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020215 RID: 131605 RVA: 0x00474E90 File Offset: 0x00473090
		public static ICheckTreasureBeenClaimedCondition GetRootAsICheckTreasureBeenClaimedCondition(ByteBuffer _bb)
		{
			return ICheckTreasureBeenClaimedCondition.GetRootAsICheckTreasureBeenClaimedCondition(_bb, default(ICheckTreasureBeenClaimedCondition));
		}

		// Token: 0x06020216 RID: 131606 RVA: 0x00474EAC File Offset: 0x004730AC
		public static ICheckTreasureBeenClaimedCondition GetRootAsICheckTreasureBeenClaimedCondition(ByteBuffer _bb, ICheckTreasureBeenClaimedCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020217 RID: 131607 RVA: 0x00474EC9 File Offset: 0x004730C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020218 RID: 131608 RVA: 0x00474ED8 File Offset: 0x004730D8
		public ICheckTreasureBeenClaimedCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009321 RID: 37665
		// (get) Token: 0x06020219 RID: 131609 RVA: 0x00474EE8 File Offset: 0x004730E8
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

		// Token: 0x17009322 RID: 37666
		// (get) Token: 0x0602021A RID: 131610 RVA: 0x00474F24 File Offset: 0x00473124
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

		// Token: 0x0602021B RID: 131611 RVA: 0x00474F60 File Offset: 0x00473160
		public static Offset<ICheckTreasureBeenClaimedCondition> CreateICheckTreasureBeenClaimedCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0)
		{
			builder.StartTable(2);
			ICheckTreasureBeenClaimedCondition.AddEntityId(builder, EntityId);
			ICheckTreasureBeenClaimedCondition.AddType(builder, Type);
			return ICheckTreasureBeenClaimedCondition.EndICheckTreasureBeenClaimedCondition(builder);
		}

		// Token: 0x0602021C RID: 131612 RVA: 0x00474F7D File Offset: 0x0047317D
		public static void StartICheckTreasureBeenClaimedCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602021D RID: 131613 RVA: 0x00474F86 File Offset: 0x00473186
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602021E RID: 131614 RVA: 0x00474F91 File Offset: 0x00473191
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0602021F RID: 131615 RVA: 0x00474F9C File Offset: 0x0047319C
		public static Offset<ICheckTreasureBeenClaimedCondition> EndICheckTreasureBeenClaimedCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICheckTreasureBeenClaimedCondition>(builder.EndTable());
		}

		// Token: 0x06020220 RID: 131616 RVA: 0x00474FAC File Offset: 0x004731AC
		public ICheckTreasureBeenClaimedConditionT UnPack()
		{
			ICheckTreasureBeenClaimedConditionT checkTreasureBeenClaimedConditionT = new ICheckTreasureBeenClaimedConditionT();
			this.UnPackTo(checkTreasureBeenClaimedConditionT);
			return checkTreasureBeenClaimedConditionT;
		}

		// Token: 0x06020221 RID: 131617 RVA: 0x00474FC7 File Offset: 0x004731C7
		public void UnPackTo(ICheckTreasureBeenClaimedConditionT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06020222 RID: 131618 RVA: 0x00474FE4 File Offset: 0x004731E4
		public static Offset<ICheckTreasureBeenClaimedCondition> Pack(FlatBufferBuilder builder, ICheckTreasureBeenClaimedConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckTreasureBeenClaimedCondition>);
			}
			return ICheckTreasureBeenClaimedCondition.CreateICheckTreasureBeenClaimedCondition(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x0400DF2E RID: 57134
		private Table __p;
	}
}
