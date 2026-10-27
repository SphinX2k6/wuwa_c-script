using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1D RID: 27165
	public struct ILimitPlayerMove : IFlatbufferObject
	{
		// Token: 0x1700C980 RID: 51584
		// (get) Token: 0x0602F885 RID: 194693 RVA: 0x00678A15 File Offset: 0x00676C15
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F886 RID: 194694 RVA: 0x00678A22 File Offset: 0x00676C22
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F887 RID: 194695 RVA: 0x00678A2C File Offset: 0x00676C2C
		public static ILimitPlayerMove GetRootAsILimitPlayerMove(ByteBuffer _bb)
		{
			return ILimitPlayerMove.GetRootAsILimitPlayerMove(_bb, default(ILimitPlayerMove));
		}

		// Token: 0x0602F888 RID: 194696 RVA: 0x00678A48 File Offset: 0x00676C48
		public static ILimitPlayerMove GetRootAsILimitPlayerMove(ByteBuffer _bb, ILimitPlayerMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F889 RID: 194697 RVA: 0x00678A65 File Offset: 0x00676C65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F88A RID: 194698 RVA: 0x00678A74 File Offset: 0x00676C74
		public ILimitPlayerMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C981 RID: 51585
		// (get) Token: 0x0602F88B RID: 194699 RVA: 0x00678A84 File Offset: 0x00676C84
		public ELimitPlayOperation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return (ELimitPlayOperation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C982 RID: 51586
		// (get) Token: 0x0602F88C RID: 194700 RVA: 0x00678AC0 File Offset: 0x00676CC0
		public bool IsOnlyForward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C983 RID: 51587
		// (get) Token: 0x0602F88D RID: 194701 RVA: 0x00678B00 File Offset: 0x00676D00
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

		// Token: 0x0602F88E RID: 194702 RVA: 0x00678B3C File Offset: 0x00676D3C
		public static Offset<ILimitPlayerMove> CreateILimitPlayerMove(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera, bool IsOnlyForward = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILimitPlayerMove.AddNullMask(builder, NullMask);
			ILimitPlayerMove.AddIsOnlyForward(builder, IsOnlyForward);
			ILimitPlayerMove.AddType(builder, Type);
			return ILimitPlayerMove.EndILimitPlayerMove(builder);
		}

		// Token: 0x0602F88F RID: 194703 RVA: 0x00678B60 File Offset: 0x00676D60
		public static void StartILimitPlayerMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602F890 RID: 194704 RVA: 0x00678B69 File Offset: 0x00676D69
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F891 RID: 194705 RVA: 0x00678B74 File Offset: 0x00676D74
		public static void AddIsOnlyForward(FlatBufferBuilder builder, bool isOnlyForward)
		{
			builder.AddBool(1, isOnlyForward, false);
		}

		// Token: 0x0602F892 RID: 194706 RVA: 0x00678B7F File Offset: 0x00676D7F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602F893 RID: 194707 RVA: 0x00678B8A File Offset: 0x00676D8A
		public static Offset<ILimitPlayerMove> EndILimitPlayerMove(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerMove>(builder.EndTable());
		}

		// Token: 0x0602F894 RID: 194708 RVA: 0x00678B98 File Offset: 0x00676D98
		public ILimitPlayerMoveT UnPack()
		{
			ILimitPlayerMoveT limitPlayerMoveT = new ILimitPlayerMoveT();
			this.UnPackTo(limitPlayerMoveT);
			return limitPlayerMoveT;
		}

		// Token: 0x0602F895 RID: 194709 RVA: 0x00678BB3 File Offset: 0x00676DB3
		public void UnPackTo(ILimitPlayerMoveT _o)
		{
			_o.Type = this.Type;
			_o.IsOnlyForward = this.IsOnlyForward;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F896 RID: 194710 RVA: 0x00678BDC File Offset: 0x00676DDC
		public static Offset<ILimitPlayerMove> Pack(FlatBufferBuilder builder, ILimitPlayerMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerMove>);
			}
			return ILimitPlayerMove.CreateILimitPlayerMove(builder, _o.Type, _o.IsOnlyForward, _o.NullMask);
		}

		// Token: 0x04011221 RID: 70177
		private Table __p;
	}
}
