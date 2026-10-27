using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A20 RID: 27168
	public struct ILimitPlayerMoveNew : IFlatbufferObject
	{
		// Token: 0x1700C987 RID: 51591
		// (get) Token: 0x0602F89F RID: 194719 RVA: 0x00678CAC File Offset: 0x00676EAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F8A0 RID: 194720 RVA: 0x00678CB9 File Offset: 0x00676EB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F8A1 RID: 194721 RVA: 0x00678CC0 File Offset: 0x00676EC0
		public static ILimitPlayerMoveNew GetRootAsILimitPlayerMoveNew(ByteBuffer _bb)
		{
			return ILimitPlayerMoveNew.GetRootAsILimitPlayerMoveNew(_bb, default(ILimitPlayerMoveNew));
		}

		// Token: 0x0602F8A2 RID: 194722 RVA: 0x00678CDC File Offset: 0x00676EDC
		public static ILimitPlayerMoveNew GetRootAsILimitPlayerMoveNew(ByteBuffer _bb, ILimitPlayerMoveNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F8A3 RID: 194723 RVA: 0x00678CF9 File Offset: 0x00676EF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F8A4 RID: 194724 RVA: 0x00678D08 File Offset: 0x00676F08
		public ILimitPlayerMoveNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C988 RID: 51592
		// (get) Token: 0x0602F8A5 RID: 194725 RVA: 0x00678D18 File Offset: 0x00676F18
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

		// Token: 0x1700C989 RID: 51593
		// (get) Token: 0x0602F8A6 RID: 194726 RVA: 0x00678D54 File Offset: 0x00676F54
		public bool Forward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C98A RID: 51594
		// (get) Token: 0x0602F8A7 RID: 194727 RVA: 0x00678D94 File Offset: 0x00676F94
		public bool Back
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C98B RID: 51595
		// (get) Token: 0x0602F8A8 RID: 194728 RVA: 0x00678DD4 File Offset: 0x00676FD4
		public bool Left
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C98C RID: 51596
		// (get) Token: 0x0602F8A9 RID: 194729 RVA: 0x00678E14 File Offset: 0x00677014
		public bool Right
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602F8AA RID: 194730 RVA: 0x00678E54 File Offset: 0x00677054
		public static Offset<ILimitPlayerMoveNew> CreateILimitPlayerMoveNew(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera, bool Forward = false, bool Back = false, bool Left = false, bool Right = false)
		{
			builder.StartTable(5);
			ILimitPlayerMoveNew.AddRight(builder, Right);
			ILimitPlayerMoveNew.AddLeft(builder, Left);
			ILimitPlayerMoveNew.AddBack(builder, Back);
			ILimitPlayerMoveNew.AddForward(builder, Forward);
			ILimitPlayerMoveNew.AddType(builder, Type);
			return ILimitPlayerMoveNew.EndILimitPlayerMoveNew(builder);
		}

		// Token: 0x0602F8AB RID: 194731 RVA: 0x00678E88 File Offset: 0x00677088
		public static void StartILimitPlayerMoveNew(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602F8AC RID: 194732 RVA: 0x00678E91 File Offset: 0x00677091
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F8AD RID: 194733 RVA: 0x00678E9C File Offset: 0x0067709C
		public static void AddForward(FlatBufferBuilder builder, bool forward)
		{
			builder.AddBool(1, forward, false);
		}

		// Token: 0x0602F8AE RID: 194734 RVA: 0x00678EA7 File Offset: 0x006770A7
		public static void AddBack(FlatBufferBuilder builder, bool back)
		{
			builder.AddBool(2, back, false);
		}

		// Token: 0x0602F8AF RID: 194735 RVA: 0x00678EB2 File Offset: 0x006770B2
		public static void AddLeft(FlatBufferBuilder builder, bool left)
		{
			builder.AddBool(3, left, false);
		}

		// Token: 0x0602F8B0 RID: 194736 RVA: 0x00678EBD File Offset: 0x006770BD
		public static void AddRight(FlatBufferBuilder builder, bool right)
		{
			builder.AddBool(4, right, false);
		}

		// Token: 0x0602F8B1 RID: 194737 RVA: 0x00678EC8 File Offset: 0x006770C8
		public static Offset<ILimitPlayerMoveNew> EndILimitPlayerMoveNew(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerMoveNew>(builder.EndTable());
		}

		// Token: 0x0602F8B2 RID: 194738 RVA: 0x00678ED8 File Offset: 0x006770D8
		public ILimitPlayerMoveNewT UnPack()
		{
			ILimitPlayerMoveNewT limitPlayerMoveNewT = new ILimitPlayerMoveNewT();
			this.UnPackTo(limitPlayerMoveNewT);
			return limitPlayerMoveNewT;
		}

		// Token: 0x0602F8B3 RID: 194739 RVA: 0x00678EF3 File Offset: 0x006770F3
		public void UnPackTo(ILimitPlayerMoveNewT _o)
		{
			_o.Type = this.Type;
			_o.Forward = this.Forward;
			_o.Back = this.Back;
			_o.Left = this.Left;
			_o.Right = this.Right;
		}

		// Token: 0x0602F8B4 RID: 194740 RVA: 0x00678F34 File Offset: 0x00677134
		public static Offset<ILimitPlayerMoveNew> Pack(FlatBufferBuilder builder, ILimitPlayerMoveNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerMoveNew>);
			}
			return ILimitPlayerMoveNew.CreateILimitPlayerMoveNew(builder, _o.Type, _o.Forward, _o.Back, _o.Left, _o.Right);
		}

		// Token: 0x04011225 RID: 70181
		private Table __p;
	}
}
