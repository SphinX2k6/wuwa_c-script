using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003B7E RID: 15230
	public struct IPlaceholderRef : IFlatbufferObject
	{
		// Token: 0x1700686D RID: 26733
		// (get) Token: 0x06014DBF RID: 85439 RVA: 0x00307448 File Offset: 0x00305648
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014DC0 RID: 85440 RVA: 0x00307455 File Offset: 0x00305655
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014DC1 RID: 85441 RVA: 0x0030745C File Offset: 0x0030565C
		public static IPlaceholderRef GetRootAsIPlaceholderRef(ByteBuffer _bb)
		{
			return IPlaceholderRef.GetRootAsIPlaceholderRef(_bb, default(IPlaceholderRef));
		}

		// Token: 0x06014DC2 RID: 85442 RVA: 0x00307478 File Offset: 0x00305678
		public static IPlaceholderRef GetRootAsIPlaceholderRef(ByteBuffer _bb, IPlaceholderRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014DC3 RID: 85443 RVA: 0x00307495 File Offset: 0x00305695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014DC4 RID: 85444 RVA: 0x003074A4 File Offset: 0x003056A4
		public IPlaceholderRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700686E RID: 26734
		// (get) Token: 0x06014DC5 RID: 85445 RVA: 0x003074B4 File Offset: 0x003056B4
		public TPlaceholderType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TPlaceholderType.BuffIdList;
				}
				return (TPlaceholderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700686F RID: 26735
		// (get) Token: 0x06014DC6 RID: 85446 RVA: 0x003074F0 File Offset: 0x003056F0
		public string Name
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

		// Token: 0x06014DC7 RID: 85447 RVA: 0x00307527 File Offset: 0x00305727
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06014DC8 RID: 85448 RVA: 0x00307536 File Offset: 0x00305736
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006870 RID: 26736
		// (get) Token: 0x06014DC9 RID: 85449 RVA: 0x00307544 File Offset: 0x00305744
		public string FieldName
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06014DCA RID: 85450 RVA: 0x0030757B File Offset: 0x0030577B
		public Span<byte> GetFieldNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06014DCB RID: 85451 RVA: 0x0030758A File Offset: 0x0030578A
		public byte[] GetFieldNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06014DCC RID: 85452 RVA: 0x00307598 File Offset: 0x00305798
		public static Offset<IPlaceholderRef> CreateIPlaceholderRef(FlatBufferBuilder builder, TPlaceholderType Type = TPlaceholderType.BuffIdList, StringOffset NameOffset = default(StringOffset), StringOffset FieldNameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPlaceholderRef.AddFieldName(builder, FieldNameOffset);
			IPlaceholderRef.AddName(builder, NameOffset);
			IPlaceholderRef.AddType(builder, Type);
			return IPlaceholderRef.EndIPlaceholderRef(builder);
		}

		// Token: 0x06014DCD RID: 85453 RVA: 0x003075BC File Offset: 0x003057BC
		public static void StartIPlaceholderRef(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06014DCE RID: 85454 RVA: 0x003075C5 File Offset: 0x003057C5
		public static void AddType(FlatBufferBuilder builder, TPlaceholderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014DCF RID: 85455 RVA: 0x003075D0 File Offset: 0x003057D0
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06014DD0 RID: 85456 RVA: 0x003075E0 File Offset: 0x003057E0
		public static void AddFieldName(FlatBufferBuilder builder, StringOffset fieldNameOffset)
		{
			builder.AddOffset(2, fieldNameOffset.Value, 0);
		}

		// Token: 0x06014DD1 RID: 85457 RVA: 0x003075F0 File Offset: 0x003057F0
		public static Offset<IPlaceholderRef> EndIPlaceholderRef(FlatBufferBuilder builder)
		{
			return new Offset<IPlaceholderRef>(builder.EndTable());
		}

		// Token: 0x06014DD2 RID: 85458 RVA: 0x00307600 File Offset: 0x00305800
		public IPlaceholderRefT UnPack()
		{
			IPlaceholderRefT placeholderRefT = new IPlaceholderRefT();
			this.UnPackTo(placeholderRefT);
			return placeholderRefT;
		}

		// Token: 0x06014DD3 RID: 85459 RVA: 0x0030761B File Offset: 0x0030581B
		public void UnPackTo(IPlaceholderRefT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.FieldName = this.FieldName;
		}

		// Token: 0x06014DD4 RID: 85460 RVA: 0x00307644 File Offset: 0x00305844
		public static Offset<IPlaceholderRef> Pack(FlatBufferBuilder builder, IPlaceholderRefT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaceholderRef>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset fieldNameOffset = (_o.FieldName == null) ? default(StringOffset) : builder.CreateString(_o.FieldName);
			return IPlaceholderRef.CreateIPlaceholderRef(builder, _o.Type, nameOffset, fieldNameOffset);
		}

		// Token: 0x0400B0CD RID: 45261
		private Table __p;
	}
}
