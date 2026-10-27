using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200638B RID: 25483
	public struct IClientChangeTeamPosition : IFlatbufferObject
	{
		// Token: 0x1700BDFB RID: 48635
		// (get) Token: 0x0602C13C RID: 180540 RVA: 0x0060DD50 File Offset: 0x0060BF50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C13D RID: 180541 RVA: 0x0060DD5D File Offset: 0x0060BF5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C13E RID: 180542 RVA: 0x0060DD64 File Offset: 0x0060BF64
		public static IClientChangeTeamPosition GetRootAsIClientChangeTeamPosition(ByteBuffer _bb)
		{
			return IClientChangeTeamPosition.GetRootAsIClientChangeTeamPosition(_bb, default(IClientChangeTeamPosition));
		}

		// Token: 0x0602C13F RID: 180543 RVA: 0x0060DD80 File Offset: 0x0060BF80
		public static IClientChangeTeamPosition GetRootAsIClientChangeTeamPosition(ByteBuffer _bb, IClientChangeTeamPosition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C140 RID: 180544 RVA: 0x0060DD9D File Offset: 0x0060BF9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C141 RID: 180545 RVA: 0x0060DDAC File Offset: 0x0060BFAC
		public IClientChangeTeamPosition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDFC RID: 48636
		// (get) Token: 0x0602C142 RID: 180546 RVA: 0x0060DDBC File Offset: 0x0060BFBC
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

		// Token: 0x1700BDFD RID: 48637
		// (get) Token: 0x0602C143 RID: 180547 RVA: 0x0060DDF8 File Offset: 0x0060BFF8
		public bool RestoreToPrevious
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BDFE RID: 48638
		// (get) Token: 0x0602C144 RID: 180548 RVA: 0x0060DE38 File Offset: 0x0060C038
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

		// Token: 0x0602C145 RID: 180549 RVA: 0x0060DE74 File Offset: 0x0060C074
		public static Offset<IClientChangeTeamPosition> CreateIClientChangeTeamPosition(FlatBufferBuilder builder, int PositionId = 0, bool RestoreToPrevious = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			IClientChangeTeamPosition.AddPositionId(builder, PositionId);
			IClientChangeTeamPosition.AddNullMask(builder, NullMask);
			IClientChangeTeamPosition.AddRestoreToPrevious(builder, RestoreToPrevious);
			return IClientChangeTeamPosition.EndIClientChangeTeamPosition(builder);
		}

		// Token: 0x0602C146 RID: 180550 RVA: 0x0060DE98 File Offset: 0x0060C098
		public static void StartIClientChangeTeamPosition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602C147 RID: 180551 RVA: 0x0060DEA1 File Offset: 0x0060C0A1
		public static void AddPositionId(FlatBufferBuilder builder, int positionId)
		{
			builder.AddInt(0, positionId, 0);
		}

		// Token: 0x0602C148 RID: 180552 RVA: 0x0060DEAC File Offset: 0x0060C0AC
		public static void AddRestoreToPrevious(FlatBufferBuilder builder, bool restoreToPrevious)
		{
			builder.AddBool(1, restoreToPrevious, false);
		}

		// Token: 0x0602C149 RID: 180553 RVA: 0x0060DEB7 File Offset: 0x0060C0B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602C14A RID: 180554 RVA: 0x0060DEC2 File Offset: 0x0060C0C2
		public static Offset<IClientChangeTeamPosition> EndIClientChangeTeamPosition(FlatBufferBuilder builder)
		{
			return new Offset<IClientChangeTeamPosition>(builder.EndTable());
		}

		// Token: 0x0602C14B RID: 180555 RVA: 0x0060DED0 File Offset: 0x0060C0D0
		public IClientChangeTeamPositionT UnPack()
		{
			IClientChangeTeamPositionT clientChangeTeamPositionT = new IClientChangeTeamPositionT();
			this.UnPackTo(clientChangeTeamPositionT);
			return clientChangeTeamPositionT;
		}

		// Token: 0x0602C14C RID: 180556 RVA: 0x0060DEEB File Offset: 0x0060C0EB
		public void UnPackTo(IClientChangeTeamPositionT _o)
		{
			_o.PositionId = this.PositionId;
			_o.RestoreToPrevious = this.RestoreToPrevious;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602C14D RID: 180557 RVA: 0x0060DF14 File Offset: 0x0060C114
		public static Offset<IClientChangeTeamPosition> Pack(FlatBufferBuilder builder, IClientChangeTeamPositionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientChangeTeamPosition>);
			}
			return IClientChangeTeamPosition.CreateIClientChangeTeamPosition(builder, _o.PositionId, _o.RestoreToPrevious, _o.NullMask);
		}

		// Token: 0x04010955 RID: 67925
		private Table __p;
	}
}
