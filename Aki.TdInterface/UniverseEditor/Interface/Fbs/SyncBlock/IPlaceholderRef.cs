using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.SyncBlock
{
	// Token: 0x02003F86 RID: 16262
	public struct IPlaceholderRef : IFlatbufferObject
	{
		// Token: 0x17006E0C RID: 28172
		// (get) Token: 0x06016289 RID: 90761 RVA: 0x0032D9E0 File Offset: 0x0032BBE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601628A RID: 90762 RVA: 0x0032D9ED File Offset: 0x0032BBED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601628B RID: 90763 RVA: 0x0032D9F4 File Offset: 0x0032BBF4
		public static IPlaceholderRef GetRootAsIPlaceholderRef(ByteBuffer _bb)
		{
			return IPlaceholderRef.GetRootAsIPlaceholderRef(_bb, default(IPlaceholderRef));
		}

		// Token: 0x0601628C RID: 90764 RVA: 0x0032DA10 File Offset: 0x0032BC10
		public static IPlaceholderRef GetRootAsIPlaceholderRef(ByteBuffer _bb, IPlaceholderRef obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601628D RID: 90765 RVA: 0x0032DA2D File Offset: 0x0032BC2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601628E RID: 90766 RVA: 0x0032DA3C File Offset: 0x0032BC3C
		public IPlaceholderRef __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E0D RID: 28173
		// (get) Token: 0x0601628F RID: 90767 RVA: 0x0032DA4C File Offset: 0x0032BC4C
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

		// Token: 0x17006E0E RID: 28174
		// (get) Token: 0x06016290 RID: 90768 RVA: 0x0032DA88 File Offset: 0x0032BC88
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

		// Token: 0x06016291 RID: 90769 RVA: 0x0032DABF File Offset: 0x0032BCBF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06016292 RID: 90770 RVA: 0x0032DACE File Offset: 0x0032BCCE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17006E0F RID: 28175
		// (get) Token: 0x06016293 RID: 90771 RVA: 0x0032DADC File Offset: 0x0032BCDC
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

		// Token: 0x06016294 RID: 90772 RVA: 0x0032DB13 File Offset: 0x0032BD13
		public Span<byte> GetFieldNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06016295 RID: 90773 RVA: 0x0032DB22 File Offset: 0x0032BD22
		public byte[] GetFieldNameArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06016296 RID: 90774 RVA: 0x0032DB30 File Offset: 0x0032BD30
		public static Offset<IPlaceholderRef> CreateIPlaceholderRef(FlatBufferBuilder builder, TPlaceholderType Type = TPlaceholderType.BuffIdList, StringOffset NameOffset = default(StringOffset), StringOffset FieldNameOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IPlaceholderRef.AddFieldName(builder, FieldNameOffset);
			IPlaceholderRef.AddName(builder, NameOffset);
			IPlaceholderRef.AddType(builder, Type);
			return IPlaceholderRef.EndIPlaceholderRef(builder);
		}

		// Token: 0x06016297 RID: 90775 RVA: 0x0032DB54 File Offset: 0x0032BD54
		public static void StartIPlaceholderRef(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016298 RID: 90776 RVA: 0x0032DB5D File Offset: 0x0032BD5D
		public static void AddType(FlatBufferBuilder builder, TPlaceholderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016299 RID: 90777 RVA: 0x0032DB68 File Offset: 0x0032BD68
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601629A RID: 90778 RVA: 0x0032DB78 File Offset: 0x0032BD78
		public static void AddFieldName(FlatBufferBuilder builder, StringOffset fieldNameOffset)
		{
			builder.AddOffset(2, fieldNameOffset.Value, 0);
		}

		// Token: 0x0601629B RID: 90779 RVA: 0x0032DB88 File Offset: 0x0032BD88
		public static Offset<IPlaceholderRef> EndIPlaceholderRef(FlatBufferBuilder builder)
		{
			return new Offset<IPlaceholderRef>(builder.EndTable());
		}

		// Token: 0x0601629C RID: 90780 RVA: 0x0032DB98 File Offset: 0x0032BD98
		public IPlaceholderRefT UnPack()
		{
			IPlaceholderRefT placeholderRefT = new IPlaceholderRefT();
			this.UnPackTo(placeholderRefT);
			return placeholderRefT;
		}

		// Token: 0x0601629D RID: 90781 RVA: 0x0032DBB3 File Offset: 0x0032BDB3
		public void UnPackTo(IPlaceholderRefT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.FieldName = this.FieldName;
		}

		// Token: 0x0601629E RID: 90782 RVA: 0x0032DBDC File Offset: 0x0032BDDC
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

		// Token: 0x0400BA4A RID: 47690
		private Table __p;
	}
}
