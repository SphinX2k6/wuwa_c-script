using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B6 RID: 29878
	public struct IPlayScreenEffect : IFlatbufferObject
	{
		// Token: 0x1700DBBE RID: 56254
		// (get) Token: 0x060345A7 RID: 214439 RVA: 0x0070D0C4 File Offset: 0x0070B2C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060345A8 RID: 214440 RVA: 0x0070D0D1 File Offset: 0x0070B2D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060345A9 RID: 214441 RVA: 0x0070D0D8 File Offset: 0x0070B2D8
		public static IPlayScreenEffect GetRootAsIPlayScreenEffect(ByteBuffer _bb)
		{
			return IPlayScreenEffect.GetRootAsIPlayScreenEffect(_bb, default(IPlayScreenEffect));
		}

		// Token: 0x060345AA RID: 214442 RVA: 0x0070D0F4 File Offset: 0x0070B2F4
		public static IPlayScreenEffect GetRootAsIPlayScreenEffect(ByteBuffer _bb, IPlayScreenEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060345AB RID: 214443 RVA: 0x0070D111 File Offset: 0x0070B311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060345AC RID: 214444 RVA: 0x0070D120 File Offset: 0x0070B320
		public IPlayScreenEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DBBF RID: 56255
		// (get) Token: 0x060345AD RID: 214445 RVA: 0x0070D130 File Offset: 0x0070B330
		public EEffectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEffectType.Effect;
				}
				return (EEffectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DBC0 RID: 56256
		// (get) Token: 0x060345AE RID: 214446 RVA: 0x0070D16C File Offset: 0x0070B36C
		public string Path
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060345AF RID: 214447 RVA: 0x0070D1A3 File Offset: 0x0070B3A3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060345B0 RID: 214448 RVA: 0x0070D1B2 File Offset: 0x0070B3B2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700DBC1 RID: 56257
		// (get) Token: 0x060345B1 RID: 214449 RVA: 0x0070D1C0 File Offset: 0x0070B3C0
		public float DestroyTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DBC2 RID: 56258
		// (get) Token: 0x060345B2 RID: 214450 RVA: 0x0070D200 File Offset: 0x0070B400
		public string BindSubScreenKey
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060345B3 RID: 214451 RVA: 0x0070D238 File Offset: 0x0070B438
		public Span<byte> GetBindSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060345B4 RID: 214452 RVA: 0x0070D248 File Offset: 0x0070B448
		public byte[] GetBindSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700DBC3 RID: 56259
		// (get) Token: 0x060345B5 RID: 214453 RVA: 0x0070D258 File Offset: 0x0070B458
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060345B6 RID: 214454 RVA: 0x0070D295 File Offset: 0x0070B495
		public static Offset<IPlayScreenEffect> CreateIPlayScreenEffect(FlatBufferBuilder builder, EEffectType Type = EEffectType.Effect, StringOffset PathOffset = default(StringOffset), float DestroyTime = 0f, StringOffset BindSubScreenKeyOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPlayScreenEffect.AddBindSubScreenKey(builder, BindSubScreenKeyOffset);
			IPlayScreenEffect.AddDestroyTime(builder, DestroyTime);
			IPlayScreenEffect.AddPath(builder, PathOffset);
			IPlayScreenEffect.AddNullMask(builder, NullMask);
			IPlayScreenEffect.AddType(builder, Type);
			return IPlayScreenEffect.EndIPlayScreenEffect(builder);
		}

		// Token: 0x060345B7 RID: 214455 RVA: 0x0070D2C9 File Offset: 0x0070B4C9
		public static void StartIPlayScreenEffect(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060345B8 RID: 214456 RVA: 0x0070D2D2 File Offset: 0x0070B4D2
		public static void AddType(FlatBufferBuilder builder, EEffectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060345B9 RID: 214457 RVA: 0x0070D2DD File Offset: 0x0070B4DD
		public static void AddPath(FlatBufferBuilder builder, StringOffset pathOffset)
		{
			builder.AddOffset(1, pathOffset.Value, 0);
		}

		// Token: 0x060345BA RID: 214458 RVA: 0x0070D2ED File Offset: 0x0070B4ED
		public static void AddDestroyTime(FlatBufferBuilder builder, float destroyTime)
		{
			builder.AddFloat(2, destroyTime, 0.0);
		}

		// Token: 0x060345BB RID: 214459 RVA: 0x0070D300 File Offset: 0x0070B500
		public static void AddBindSubScreenKey(FlatBufferBuilder builder, StringOffset bindSubScreenKeyOffset)
		{
			builder.AddOffset(3, bindSubScreenKeyOffset.Value, 0);
		}

		// Token: 0x060345BC RID: 214460 RVA: 0x0070D310 File Offset: 0x0070B510
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060345BD RID: 214461 RVA: 0x0070D31B File Offset: 0x0070B51B
		public static Offset<IPlayScreenEffect> EndIPlayScreenEffect(FlatBufferBuilder builder)
		{
			return new Offset<IPlayScreenEffect>(builder.EndTable());
		}

		// Token: 0x060345BE RID: 214462 RVA: 0x0070D328 File Offset: 0x0070B528
		public IPlayScreenEffectT UnPack()
		{
			IPlayScreenEffectT playScreenEffectT = new IPlayScreenEffectT();
			this.UnPackTo(playScreenEffectT);
			return playScreenEffectT;
		}

		// Token: 0x060345BF RID: 214463 RVA: 0x0070D343 File Offset: 0x0070B543
		public void UnPackTo(IPlayScreenEffectT _o)
		{
			_o.Type = this.Type;
			_o.Path = this.Path;
			_o.DestroyTime = this.DestroyTime;
			_o.BindSubScreenKey = this.BindSubScreenKey;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060345C0 RID: 214464 RVA: 0x0070D384 File Offset: 0x0070B584
		public static Offset<IPlayScreenEffect> Pack(FlatBufferBuilder builder, IPlayScreenEffectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayScreenEffect>);
			}
			StringOffset pathOffset = (_o.Path == null) ? default(StringOffset) : builder.CreateString(_o.Path);
			StringOffset bindSubScreenKeyOffset = (_o.BindSubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.BindSubScreenKey);
			return IPlayScreenEffect.CreateIPlayScreenEffect(builder, _o.Type, pathOffset, _o.DestroyTime, bindSubScreenKeyOffset, _o.NullMask);
		}

		// Token: 0x0401265B RID: 75355
		private Table __p;
	}
}
