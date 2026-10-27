using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF5 RID: 19445
	public struct ICustomJsonCondition : IFlatbufferObject
	{
		// Token: 0x17008D3D RID: 36157
		// (get) Token: 0x0601EC8D RID: 126093 RVA: 0x0045001C File Offset: 0x0044E21C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC8E RID: 126094 RVA: 0x00450029 File Offset: 0x0044E229
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC8F RID: 126095 RVA: 0x00450030 File Offset: 0x0044E230
		public static ICustomJsonCondition GetRootAsICustomJsonCondition(ByteBuffer _bb)
		{
			return ICustomJsonCondition.GetRootAsICustomJsonCondition(_bb, default(ICustomJsonCondition));
		}

		// Token: 0x0601EC90 RID: 126096 RVA: 0x0045004C File Offset: 0x0044E24C
		public static ICustomJsonCondition GetRootAsICustomJsonCondition(ByteBuffer _bb, ICustomJsonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC91 RID: 126097 RVA: 0x00450069 File Offset: 0x0044E269
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC92 RID: 126098 RVA: 0x00450078 File Offset: 0x0044E278
		public ICustomJsonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D3E RID: 36158
		// (get) Token: 0x0601EC93 RID: 126099 RVA: 0x00450088 File Offset: 0x0044E288
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008D3F RID: 36159
		// (get) Token: 0x0601EC94 RID: 126100 RVA: 0x004500C4 File Offset: 0x0044E2C4
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

		// Token: 0x0601EC95 RID: 126101 RVA: 0x004500FB File Offset: 0x0044E2FB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601EC96 RID: 126102 RVA: 0x0045010A File Offset: 0x0044E30A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008D40 RID: 36160
		// (get) Token: 0x0601EC97 RID: 126103 RVA: 0x00450118 File Offset: 0x0044E318
		public string JsonString
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

		// Token: 0x0601EC98 RID: 126104 RVA: 0x0045014F File Offset: 0x0044E34F
		public Span<byte> GetJsonStringBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601EC99 RID: 126105 RVA: 0x0045015E File Offset: 0x0044E35E
		public byte[] GetJsonStringArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0601EC9A RID: 126106 RVA: 0x0045016C File Offset: 0x0044E36C
		public static Offset<ICustomJsonCondition> CreateICustomJsonCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset NameOffset = default(StringOffset), StringOffset JsonStringOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICustomJsonCondition.AddJsonString(builder, JsonStringOffset);
			ICustomJsonCondition.AddName(builder, NameOffset);
			ICustomJsonCondition.AddType(builder, Type);
			return ICustomJsonCondition.EndICustomJsonCondition(builder);
		}

		// Token: 0x0601EC9B RID: 126107 RVA: 0x00450190 File Offset: 0x0044E390
		public static void StartICustomJsonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601EC9C RID: 126108 RVA: 0x00450199 File Offset: 0x0044E399
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EC9D RID: 126109 RVA: 0x004501A4 File Offset: 0x0044E3A4
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x0601EC9E RID: 126110 RVA: 0x004501B4 File Offset: 0x0044E3B4
		public static void AddJsonString(FlatBufferBuilder builder, StringOffset jsonStringOffset)
		{
			builder.AddOffset(2, jsonStringOffset.Value, 0);
		}

		// Token: 0x0601EC9F RID: 126111 RVA: 0x004501C4 File Offset: 0x0044E3C4
		public static Offset<ICustomJsonCondition> EndICustomJsonCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICustomJsonCondition>(builder.EndTable());
		}

		// Token: 0x0601ECA0 RID: 126112 RVA: 0x004501D4 File Offset: 0x0044E3D4
		public ICustomJsonConditionT UnPack()
		{
			ICustomJsonConditionT customJsonConditionT = new ICustomJsonConditionT();
			this.UnPackTo(customJsonConditionT);
			return customJsonConditionT;
		}

		// Token: 0x0601ECA1 RID: 126113 RVA: 0x004501EF File Offset: 0x0044E3EF
		public void UnPackTo(ICustomJsonConditionT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.JsonString = this.JsonString;
		}

		// Token: 0x0601ECA2 RID: 126114 RVA: 0x00450218 File Offset: 0x0044E418
		public static Offset<ICustomJsonCondition> Pack(FlatBufferBuilder builder, ICustomJsonConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICustomJsonCondition>);
			}
			StringOffset nameOffset = (_o.Name == null) ? default(StringOffset) : builder.CreateString(_o.Name);
			StringOffset jsonStringOffset = (_o.JsonString == null) ? default(StringOffset) : builder.CreateString(_o.JsonString);
			return ICustomJsonCondition.CreateICustomJsonCondition(builder, _o.Type, nameOffset, jsonStringOffset);
		}

		// Token: 0x0400D580 RID: 54656
		private Table __p;
	}
}
