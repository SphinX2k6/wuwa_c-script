using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A18 RID: 14872
	public struct IBlackBoardInt : IFlatbufferObject
	{
		// Token: 0x170065EF RID: 26095
		// (get) Token: 0x060141A3 RID: 82339 RVA: 0x002F11C6 File Offset: 0x002EF3C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060141A4 RID: 82340 RVA: 0x002F11D3 File Offset: 0x002EF3D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060141A5 RID: 82341 RVA: 0x002F11DC File Offset: 0x002EF3DC
		public static IBlackBoardInt GetRootAsIBlackBoardInt(ByteBuffer _bb)
		{
			return IBlackBoardInt.GetRootAsIBlackBoardInt(_bb, default(IBlackBoardInt));
		}

		// Token: 0x060141A6 RID: 82342 RVA: 0x002F11F8 File Offset: 0x002EF3F8
		public static IBlackBoardInt GetRootAsIBlackBoardInt(ByteBuffer _bb, IBlackBoardInt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060141A7 RID: 82343 RVA: 0x002F1215 File Offset: 0x002EF415
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060141A8 RID: 82344 RVA: 0x002F1224 File Offset: 0x002EF424
		public IBlackBoardInt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170065F0 RID: 26096
		// (get) Token: 0x060141A9 RID: 82345 RVA: 0x002F1234 File Offset: 0x002EF434
		public EBlackBoardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBlackBoardType.Boolean;
				}
				return (EBlackBoardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170065F1 RID: 26097
		// (get) Token: 0x060141AA RID: 82346 RVA: 0x002F1270 File Offset: 0x002EF470
		public string Key
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

		// Token: 0x060141AB RID: 82347 RVA: 0x002F12A7 File Offset: 0x002EF4A7
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060141AC RID: 82348 RVA: 0x002F12B6 File Offset: 0x002EF4B6
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170065F2 RID: 26098
		// (get) Token: 0x060141AD RID: 82349 RVA: 0x002F12C4 File Offset: 0x002EF4C4
		public int Value
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060141AE RID: 82350 RVA: 0x002F1300 File Offset: 0x002EF500
		public static Offset<IBlackBoardInt> CreateIBlackBoardInt(FlatBufferBuilder builder, EBlackBoardType Type = EBlackBoardType.Boolean, StringOffset KeyOffset = default(StringOffset), int Value = 0)
		{
			builder.StartTable(3);
			IBlackBoardInt.AddValue(builder, Value);
			IBlackBoardInt.AddKey(builder, KeyOffset);
			IBlackBoardInt.AddType(builder, Type);
			return IBlackBoardInt.EndIBlackBoardInt(builder);
		}

		// Token: 0x060141AF RID: 82351 RVA: 0x002F1324 File Offset: 0x002EF524
		public static void StartIBlackBoardInt(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060141B0 RID: 82352 RVA: 0x002F132D File Offset: 0x002EF52D
		public static void AddType(FlatBufferBuilder builder, EBlackBoardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060141B1 RID: 82353 RVA: 0x002F1338 File Offset: 0x002EF538
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(1, keyOffset.Value, 0);
		}

		// Token: 0x060141B2 RID: 82354 RVA: 0x002F1348 File Offset: 0x002EF548
		public static void AddValue(FlatBufferBuilder builder, int value)
		{
			builder.AddInt(2, value, 0);
		}

		// Token: 0x060141B3 RID: 82355 RVA: 0x002F1353 File Offset: 0x002EF553
		public static Offset<IBlackBoardInt> EndIBlackBoardInt(FlatBufferBuilder builder)
		{
			return new Offset<IBlackBoardInt>(builder.EndTable());
		}

		// Token: 0x060141B4 RID: 82356 RVA: 0x002F1360 File Offset: 0x002EF560
		public IBlackBoardIntT UnPack()
		{
			IBlackBoardIntT blackBoardIntT = new IBlackBoardIntT();
			this.UnPackTo(blackBoardIntT);
			return blackBoardIntT;
		}

		// Token: 0x060141B5 RID: 82357 RVA: 0x002F137B File Offset: 0x002EF57B
		public void UnPackTo(IBlackBoardIntT _o)
		{
			_o.Type = this.Type;
			_o.Key = this.Key;
			_o.Value = this.Value;
		}

		// Token: 0x060141B6 RID: 82358 RVA: 0x002F13A4 File Offset: 0x002EF5A4
		public static Offset<IBlackBoardInt> Pack(FlatBufferBuilder builder, IBlackBoardIntT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBlackBoardInt>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IBlackBoardInt.CreateIBlackBoardInt(builder, _o.Type, keyOffset, _o.Value);
		}

		// Token: 0x0400AE84 RID: 44676
		private Table __p;
	}
}
