using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064F8 RID: 25848
	public struct ICustomJson : IFlatbufferObject
	{
		// Token: 0x1700C040 RID: 49216
		// (get) Token: 0x0602CD69 RID: 183657 RVA: 0x0062906A File Offset: 0x0062726A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CD6A RID: 183658 RVA: 0x00629077 File Offset: 0x00627277
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CD6B RID: 183659 RVA: 0x00629080 File Offset: 0x00627280
		public static ICustomJson GetRootAsICustomJson(ByteBuffer _bb)
		{
			return ICustomJson.GetRootAsICustomJson(_bb, default(ICustomJson));
		}

		// Token: 0x0602CD6C RID: 183660 RVA: 0x0062909C File Offset: 0x0062729C
		public static ICustomJson GetRootAsICustomJson(ByteBuffer _bb, ICustomJson obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CD6D RID: 183661 RVA: 0x006290B9 File Offset: 0x006272B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CD6E RID: 183662 RVA: 0x006290C8 File Offset: 0x006272C8
		public ICustomJson __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C041 RID: 49217
		// (get) Token: 0x0602CD6F RID: 183663 RVA: 0x006290D8 File Offset: 0x006272D8
		public string Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CD70 RID: 183664 RVA: 0x0062910F File Offset: 0x0062730F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602CD71 RID: 183665 RVA: 0x0062911E File Offset: 0x0062731E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700C042 RID: 49218
		// (get) Token: 0x0602CD72 RID: 183666 RVA: 0x0062912C File Offset: 0x0062732C
		public string JsonString
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

		// Token: 0x0602CD73 RID: 183667 RVA: 0x00629163 File Offset: 0x00627363
		public Span<byte> GetJsonStringBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CD74 RID: 183668 RVA: 0x00629172 File Offset: 0x00627372
		public byte[] GetJsonStringArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CD75 RID: 183669 RVA: 0x00629180 File Offset: 0x00627380
		public static Offset<ICustomJson> CreateICustomJson(FlatBufferBuilder builder, StringOffset NameOffset = default(StringOffset), StringOffset JsonStringOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ICustomJson.AddJsonString(builder, JsonStringOffset);
			ICustomJson.AddName(builder, NameOffset);
			return ICustomJson.EndICustomJson(builder);
		}

		// Token: 0x0602CD76 RID: 183670 RVA: 0x0062919D File Offset: 0x0062739D
		public static void StartICustomJson(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CD77 RID: 183671 RVA: 0x006291A6 File Offset: 0x006273A6
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(0, nameOffset.Value, 0);
		}

		// Token: 0x0602CD78 RID: 183672 RVA: 0x006291B6 File Offset: 0x006273B6
		public static void AddJsonString(FlatBufferBuilder builder, StringOffset jsonStringOffset)
		{
			builder.AddOffset(1, jsonStringOffset.Value, 0);
		}

		// Token: 0x0602CD79 RID: 183673 RVA: 0x006291C6 File Offset: 0x006273C6
		public static Offset<ICustomJson> EndICustomJson(FlatBufferBuilder builder)
		{
			return new Offset<ICustomJson>(builder.EndTable());
		}

		// Token: 0x0602CD7A RID: 183674 RVA: 0x006291D4 File Offset: 0x006273D4
		public ICustomJsonT UnPack()
		{
			ICustomJsonT customJsonT = new ICustomJsonT();
			this.UnPackTo(customJsonT);
			return customJsonT;
		}

		// Token: 0x0602CD7B RID: 183675 RVA: 0x006291EF File Offset: 0x006273EF
		public void UnPackTo(ICustomJsonT _o)
		{
			_o.Name = this.Name;
			_o.JsonString = this.JsonString;
		}

		// Token: 0x0602CD7C RID: 183676 RVA: 0x0062920C File Offset: 0x0062740C
		public static Offset<ICustomJson> Pack(FlatBufferBuilder builder, ICustomJsonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomJson>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset jsonStringOffset = (_o.JsonString == null) ? default(StringOffset) : builder.CreateString(_o.JsonString);
			return ICustomJson.CreateICustomJson(builder, nameOffset, jsonStringOffset);
		}

		// Token: 0x04010B3B RID: 68411
		private Table __p;
	}
}
