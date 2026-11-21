using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D0 RID: 28880
	public struct ILimitPlayerMoveNew : IFlatbufferObject
	{
		// Token: 0x1700D387 RID: 54151
		// (get) Token: 0x0603225F RID: 205407 RVA: 0x006C9004 File Offset: 0x006C7204
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032260 RID: 205408 RVA: 0x006C9011 File Offset: 0x006C7211
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032261 RID: 205409 RVA: 0x006C9018 File Offset: 0x006C7218
		public static ILimitPlayerMoveNew GetRootAsILimitPlayerMoveNew(ByteBuffer _bb)
		{
			return ILimitPlayerMoveNew.GetRootAsILimitPlayerMoveNew(_bb, default(ILimitPlayerMoveNew));
		}

		// Token: 0x06032262 RID: 205410 RVA: 0x006C9034 File Offset: 0x006C7234
		public static ILimitPlayerMoveNew GetRootAsILimitPlayerMoveNew(ByteBuffer _bb, ILimitPlayerMoveNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032263 RID: 205411 RVA: 0x006C9051 File Offset: 0x006C7251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032264 RID: 205412 RVA: 0x006C9060 File Offset: 0x006C7260
		public ILimitPlayerMoveNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D388 RID: 54152
		// (get) Token: 0x06032265 RID: 205413 RVA: 0x006C9070 File Offset: 0x006C7270
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

		// Token: 0x1700D389 RID: 54153
		// (get) Token: 0x06032266 RID: 205414 RVA: 0x006C90AC File Offset: 0x006C72AC
		public bool Forward
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D38A RID: 54154
		// (get) Token: 0x06032267 RID: 205415 RVA: 0x006C90EC File Offset: 0x006C72EC
		public bool Back
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D38B RID: 54155
		// (get) Token: 0x06032268 RID: 205416 RVA: 0x006C912C File Offset: 0x006C732C
		public bool Left
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D38C RID: 54156
		// (get) Token: 0x06032269 RID: 205417 RVA: 0x006C916C File Offset: 0x006C736C
		public bool Right
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0603226A RID: 205418 RVA: 0x006C91AC File Offset: 0x006C73AC
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

		// Token: 0x0603226B RID: 205419 RVA: 0x006C91E0 File Offset: 0x006C73E0
		public static void StartILimitPlayerMoveNew(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603226C RID: 205420 RVA: 0x006C91E9 File Offset: 0x006C73E9
		public static void AddType(FlatBufferBuilder builder, ELimitPlayOperation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603226D RID: 205421 RVA: 0x006C91F4 File Offset: 0x006C73F4
		public static void AddForward(FlatBufferBuilder builder, bool forward)
		{
			builder.AddBool(1, forward, false);
		}

		// Token: 0x0603226E RID: 205422 RVA: 0x006C91FF File Offset: 0x006C73FF
		public static void AddBack(FlatBufferBuilder builder, bool back)
		{
			builder.AddBool(2, back, false);
		}

		// Token: 0x0603226F RID: 205423 RVA: 0x006C920A File Offset: 0x006C740A
		public static void AddLeft(FlatBufferBuilder builder, bool left)
		{
			builder.AddBool(3, left, false);
		}

		// Token: 0x06032270 RID: 205424 RVA: 0x006C9215 File Offset: 0x006C7415
		public static void AddRight(FlatBufferBuilder builder, bool right)
		{
			builder.AddBool(4, right, false);
		}

		// Token: 0x06032271 RID: 205425 RVA: 0x006C9220 File Offset: 0x006C7420
		public static Offset<ILimitPlayerMoveNew> EndILimitPlayerMoveNew(FlatBufferBuilder builder)
		{
			return new Offset<ILimitPlayerMoveNew>(builder.EndTable());
		}

		// Token: 0x06032272 RID: 205426 RVA: 0x006C9230 File Offset: 0x006C7430
		public ILimitPlayerMoveNewT UnPack()
		{
			ILimitPlayerMoveNewT limitPlayerMoveNewT = new ILimitPlayerMoveNewT();
			this.UnPackTo(limitPlayerMoveNewT);
			return limitPlayerMoveNewT;
		}

		// Token: 0x06032273 RID: 205427 RVA: 0x006C924B File Offset: 0x006C744B
		public void UnPackTo(ILimitPlayerMoveNewT _o)
		{
			_o.Type = this.Type;
			_o.Forward = this.Forward;
			_o.Back = this.Back;
			_o.Left = this.Left;
			_o.Right = this.Right;
		}

		// Token: 0x06032274 RID: 205428 RVA: 0x006C928C File Offset: 0x006C748C
		public static Offset<ILimitPlayerMoveNew> Pack(FlatBufferBuilder builder, ILimitPlayerMoveNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILimitPlayerMoveNew>);
			}
			return ILimitPlayerMoveNew.CreateILimitPlayerMoveNew(builder, _o.Type, _o.Forward, _o.Back, _o.Left, _o.Right);
		}

		// Token: 0x0401208F RID: 73871
		private Table __p;
	}
}
