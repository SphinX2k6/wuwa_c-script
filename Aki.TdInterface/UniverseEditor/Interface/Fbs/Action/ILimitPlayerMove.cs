using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CD RID: 28877
	public struct ILimitPlayerMove : IFlatbufferObject
	{
		// Token: 0x1700D380 RID: 54144
		// (get) Token: 0x06032245 RID: 205381 RVA: 0x006C8D6D File Offset: 0x006C6F6D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032246 RID: 205382 RVA: 0x006C8D7A File Offset: 0x006C6F7A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032247 RID: 205383 RVA: 0x006C8D84 File Offset: 0x006C6F84
		public static ILimitPlayerMove GetRootAsILimitPlayerMove(ByteBuffer _bb)
		{
			return ILimitPlayerMove.GetRootAsILimitPlayerMove(_bb, default(ILimitPlayerMove));
		}

		// Token: 0x06032248 RID: 205384 RVA: 0x006C8DA0 File Offset: 0x006C6FA0
		public static ILimitPlayerMove GetRootAsILimitPlayerMove(ByteBuffer _bb, ILimitPlayerMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032249 RID: 205385 RVA: 0x006C8DBD File Offset: 0x006C6FBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603224A RID: 205386 RVA: 0x006C8DCC File Offset: 0x006C6FCC
		public ILimitPlayerMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D381 RID: 54145
		// (get) Token: 0x0603224B RID: 205387 RVA: 0x006C8DDC File Offset: 0x006C6FDC
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

		// Token: 0x1700D382 RID: 54146
		// (get) Token: 0x0603224C RID: 205388 RVA: 0x006C8E18 File Offset: 0x006C7018
		public bool IsOnlyForward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D383 RID: 54147
		// (get) Token: 0x0603224D RID: 205389 RVA: 0x006C8E58 File Offset: 0x006C7058
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

		// Token: 0x0603224E RID: 205390 RVA: 0x006C8E94 File Offset: 0x006C7094
		public static Offset<ILimitPlayerMove> CreateILimitPlayerMove(FlatBufferBuilder builder, ELimitPlayOperation Type = ELimitPlayOperation.AllowCamera, bool IsOnlyForward = false, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILimitPlayerMove.AddNullMask(builder, NullMask);
			ILimitPlayerMove.AddIsOnlyForward(builder, IsOnlyForward);
			ILimitPlayerMove.AddType(builder, Type);
			return ILimitPlayerMove.EndILimitPlayerMove(builder);
		}

		// Token: 0x0603224F RID: 205391 RVA: 0x006C8EB8 File Offset: 0x006C70B8
		public static void StartILimitPlayerMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032250 RID: 205392 RVA: 0x006C8EC1 File Offset: 0x006C70C1
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032251 RID: 205393 RVA: 0x006C8ECC File Offset: 0x006C70CC
		public static void AddIsOnlyForward(FlatBufferBuilder builder, bool isOnlyForward)
		{
			builder.AddBool(1, isOnlyForward, false);
		}

		// Token: 0x06032252 RID: 205394 RVA: 0x006C8ED7 File Offset: 0x006C70D7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06032253 RID: 205395 RVA: 0x006C8EE2 File Offset: 0x006C70E2
		public static Offset<ILimitPlayerMove> EndILimitPlayerMove(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerMove>(builder.EndTable());
		}

		// Token: 0x06032254 RID: 205396 RVA: 0x006C8EF0 File Offset: 0x006C70F0
		public ILimitPlayerMoveT UnPack()
		{
			ILimitPlayerMoveT limitPlayerMoveT = new ILimitPlayerMoveT();
			this.UnPackTo(limitPlayerMoveT);
			return limitPlayerMoveT;
		}

		// Token: 0x06032255 RID: 205397 RVA: 0x006C8F0B File Offset: 0x006C710B
		public void UnPackTo(ILimitPlayerMoveT _o)
		{
			_o.Type = this.Type;
			_o.IsOnlyForward = this.IsOnlyForward;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032256 RID: 205398 RVA: 0x006C8F34 File Offset: 0x006C7134
		public static Offset<ILimitPlayerMove> Pack(FlatBufferBuilder builder, ILimitPlayerMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerMove>);
			}
			return ILimitPlayerMove.CreateILimitPlayerMove(builder, _o.Type, _o.IsOnlyForward, _o.NullMask);
		}

		// Token: 0x0401208B RID: 73867
		private Table __p;
	}
}
