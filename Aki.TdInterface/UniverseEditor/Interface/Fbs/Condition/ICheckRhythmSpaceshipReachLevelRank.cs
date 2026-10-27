using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B08 RID: 19208
	public struct ICheckRhythmSpaceshipReachLevelRank : IFlatbufferObject
	{
		// Token: 0x17008B54 RID: 35668
		// (get) Token: 0x0601E348 RID: 123720 RVA: 0x0043C56F File Offset: 0x0043A76F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E349 RID: 123721 RVA: 0x0043C57C File Offset: 0x0043A77C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E34A RID: 123722 RVA: 0x0043C584 File Offset: 0x0043A784
		public static ICheckRhythmSpaceshipReachLevelRank GetRootAsICheckRhythmSpaceshipReachLevelRank(ByteBuffer _bb)
		{
			return ICheckRhythmSpaceshipReachLevelRank.GetRootAsICheckRhythmSpaceshipReachLevelRank(_bb, default(ICheckRhythmSpaceshipReachLevelRank));
		}

		// Token: 0x0601E34B RID: 123723 RVA: 0x0043C5A0 File Offset: 0x0043A7A0
		public static ICheckRhythmSpaceshipReachLevelRank GetRootAsICheckRhythmSpaceshipReachLevelRank(ByteBuffer _bb, ICheckRhythmSpaceshipReachLevelRank obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E34C RID: 123724 RVA: 0x0043C5BD File Offset: 0x0043A7BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E34D RID: 123725 RVA: 0x0043C5CC File Offset: 0x0043A7CC
		public ICheckRhythmSpaceshipReachLevelRank __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B55 RID: 35669
		// (get) Token: 0x0601E34E RID: 123726 RVA: 0x0043C5DC File Offset: 0x0043A7DC
		public ECheckSystemStateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECheckSystemStateType.TrackMoonBuilding;
				}
				return (ECheckSystemStateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008B56 RID: 35670
		// (get) Token: 0x0601E34F RID: 123727 RVA: 0x0043C618 File Offset: 0x0043A818
		public int RhythmSpaceshipLevelId
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

		// Token: 0x17008B57 RID: 35671
		// (get) Token: 0x0601E350 RID: 123728 RVA: 0x0043C654 File Offset: 0x0043A854
		public ERhythmSpaceshipLevelRank Rank
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ERhythmSpaceshipLevelRank.None;
				}
				return (ERhythmSpaceshipLevelRank)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E351 RID: 123729 RVA: 0x0043C690 File Offset: 0x0043A890
		public static Offset<ICheckRhythmSpaceshipReachLevelRank> CreateICheckRhythmSpaceshipReachLevelRank(FlatBufferBuilder builder, ECheckSystemStateType Type = ECheckSystemStateType.TrackMoonBuilding, int RhythmSpaceshipLevelId = 0, ERhythmSpaceshipLevelRank Rank = ERhythmSpaceshipLevelRank.None)
		{
			builder.StartTable(3);
			ICheckRhythmSpaceshipReachLevelRank.AddRhythmSpaceshipLevelId(builder, RhythmSpaceshipLevelId);
			ICheckRhythmSpaceshipReachLevelRank.AddRank(builder, Rank);
			ICheckRhythmSpaceshipReachLevelRank.AddType(builder, Type);
			return ICheckRhythmSpaceshipReachLevelRank.EndICheckRhythmSpaceshipReachLevelRank(builder);
		}

		// Token: 0x0601E352 RID: 123730 RVA: 0x0043C6B4 File Offset: 0x0043A8B4
		public static void StartICheckRhythmSpaceshipReachLevelRank(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E353 RID: 123731 RVA: 0x0043C6BD File Offset: 0x0043A8BD
		public static void AddType(FlatBufferBuilder builder, ECheckSystemStateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E354 RID: 123732 RVA: 0x0043C6C8 File Offset: 0x0043A8C8
		public static void AddRhythmSpaceshipLevelId(FlatBufferBuilder builder, int rhythmSpaceshipLevelId)
		{
			builder.AddInt(1, rhythmSpaceshipLevelId, 0);
		}

		// Token: 0x0601E355 RID: 123733 RVA: 0x0043C6D3 File Offset: 0x0043A8D3
		public static void AddRank(FlatBufferBuilder builder, ERhythmSpaceshipLevelRank rank)
		{
			builder.AddByte(2, (byte)rank, 0);
		}

		// Token: 0x0601E356 RID: 123734 RVA: 0x0043C6DE File Offset: 0x0043A8DE
		public static Offset<ICheckRhythmSpaceshipReachLevelRank> EndICheckRhythmSpaceshipReachLevelRank(FlatBufferBuilder builder)
		{
			return new Offset<ICheckRhythmSpaceshipReachLevelRank>(builder.EndTable());
		}

		// Token: 0x0601E357 RID: 123735 RVA: 0x0043C6EC File Offset: 0x0043A8EC
		public ICheckRhythmSpaceshipReachLevelRankT UnPack()
		{
			ICheckRhythmSpaceshipReachLevelRankT checkRhythmSpaceshipReachLevelRankT = new ICheckRhythmSpaceshipReachLevelRankT();
			this.UnPackTo(checkRhythmSpaceshipReachLevelRankT);
			return checkRhythmSpaceshipReachLevelRankT;
		}

		// Token: 0x0601E358 RID: 123736 RVA: 0x0043C707 File Offset: 0x0043A907
		public void UnPackTo(ICheckRhythmSpaceshipReachLevelRankT _o)
		{
			_o.Type = this.Type;
			_o.RhythmSpaceshipLevelId = this.RhythmSpaceshipLevelId;
			_o.Rank = this.Rank;
		}

		// Token: 0x0601E359 RID: 123737 RVA: 0x0043C730 File Offset: 0x0043A930
		public static Offset<ICheckRhythmSpaceshipReachLevelRank> Pack(FlatBufferBuilder builder, ICheckRhythmSpaceshipReachLevelRankT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckRhythmSpaceshipReachLevelRank>);
			}
			return ICheckRhythmSpaceshipReachLevelRank.CreateICheckRhythmSpaceshipReachLevelRank(builder, _o.Type, _o.RhythmSpaceshipLevelId, _o.Rank);
		}

		// Token: 0x0400D3A2 RID: 54178
		private Table __p;
	}
}
