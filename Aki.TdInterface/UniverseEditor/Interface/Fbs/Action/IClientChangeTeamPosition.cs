using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FC RID: 27132
	public struct IClientChangeTeamPosition : IFlatbufferObject
	{
		// Token: 0x1700C783 RID: 51075
		// (get) Token: 0x0602E8A6 RID: 190630 RVA: 0x00658EA4 File Offset: 0x006570A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E8A7 RID: 190631 RVA: 0x00658EB1 File Offset: 0x006570B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E8A8 RID: 190632 RVA: 0x00658EB8 File Offset: 0x006570B8
		public static IClientChangeTeamPosition GetRootAsIClientChangeTeamPosition(ByteBuffer _bb)
		{
			return IClientChangeTeamPosition.GetRootAsIClientChangeTeamPosition(_bb, default(IClientChangeTeamPosition));
		}

		// Token: 0x0602E8A9 RID: 190633 RVA: 0x00658ED4 File Offset: 0x006570D4
		public static IClientChangeTeamPosition GetRootAsIClientChangeTeamPosition(ByteBuffer _bb, IClientChangeTeamPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E8AA RID: 190634 RVA: 0x00658EF1 File Offset: 0x006570F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E8AB RID: 190635 RVA: 0x00658F00 File Offset: 0x00657100
		public IClientChangeTeamPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C784 RID: 51076
		// (get) Token: 0x0602E8AC RID: 190636 RVA: 0x00658F10 File Offset: 0x00657110
		public int PositionId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E8AD RID: 190637 RVA: 0x00658F4C File Offset: 0x0065714C
		public static Offset<IClientChangeTeamPosition> CreateIClientChangeTeamPosition(FlatBufferBuilder builder, int PositionId = 0)
		{
			builder.StartTable(1);
			IClientChangeTeamPosition.AddPositionId(builder, PositionId);
			return IClientChangeTeamPosition.EndIClientChangeTeamPosition(builder);
		}

		// Token: 0x0602E8AE RID: 190638 RVA: 0x00658F62 File Offset: 0x00657162
		public static void StartIClientChangeTeamPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E8AF RID: 190639 RVA: 0x00658F6B File Offset: 0x0065716B
		public static void AddPositionId(FlatBufferBuilder builder, int positionId)
		{
			builder.AddInt(0, positionId, 0);
		}

		// Token: 0x0602E8B0 RID: 190640 RVA: 0x00658F76 File Offset: 0x00657176
		public static Offset<IClientChangeTeamPosition> EndIClientChangeTeamPosition(FlatBufferBuilder builder)
		{
			return new Offset<IClientChangeTeamPosition>(builder.EndTable());
		}

		// Token: 0x0602E8B1 RID: 190641 RVA: 0x00658F84 File Offset: 0x00657184
		public IClientChangeTeamPositionT UnPack()
		{
			IClientChangeTeamPositionT clientChangeTeamPositionT = new IClientChangeTeamPositionT();
			this.UnPackTo(clientChangeTeamPositionT);
			return clientChangeTeamPositionT;
		}

		// Token: 0x0602E8B2 RID: 190642 RVA: 0x00658F9F File Offset: 0x0065719F
		public void UnPackTo(IClientChangeTeamPositionT _o)
		{
			_o.PositionId = this.PositionId;
		}

		// Token: 0x0602E8B3 RID: 190643 RVA: 0x00658FB0 File Offset: 0x006571B0
		public static Offset<IClientChangeTeamPosition> Pack(FlatBufferBuilder builder, IClientChangeTeamPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientChangeTeamPosition>);
			}
			return IClientChangeTeamPosition.CreateIClientChangeTeamPosition(builder, _o.PositionId);
		}

		// Token: 0x0401176A RID: 71530
		private Table __p;
	}
}
