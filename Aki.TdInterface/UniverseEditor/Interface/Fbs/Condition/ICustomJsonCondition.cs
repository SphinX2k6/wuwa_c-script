using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050E2 RID: 20706
	public struct ICustomJsonCondition : IFlatbufferObject
	{
		// Token: 0x17009461 RID: 37985
		// (get) Token: 0x06020873 RID: 133235 RVA: 0x00483684 File Offset: 0x00481884
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020874 RID: 133236 RVA: 0x00483691 File Offset: 0x00481891
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020875 RID: 133237 RVA: 0x00483698 File Offset: 0x00481898
		public static ICustomJsonCondition GetRootAsICustomJsonCondition(ByteBuffer _bb)
		{
			return ICustomJsonCondition.GetRootAsICustomJsonCondition(_bb, default(ICustomJsonCondition));
		}

		// Token: 0x06020876 RID: 133238 RVA: 0x004836B4 File Offset: 0x004818B4
		public static ICustomJsonCondition GetRootAsICustomJsonCondition(ByteBuffer _bb, ICustomJsonCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020877 RID: 133239 RVA: 0x004836D1 File Offset: 0x004818D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020878 RID: 133240 RVA: 0x004836E0 File Offset: 0x004818E0
		public ICustomJsonCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009462 RID: 37986
		// (get) Token: 0x06020879 RID: 133241 RVA: 0x004836F0 File Offset: 0x004818F0
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

		// Token: 0x17009463 RID: 37987
		// (get) Token: 0x0602087A RID: 133242 RVA: 0x0048372C File Offset: 0x0048192C
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

		// Token: 0x0602087B RID: 133243 RVA: 0x00483763 File Offset: 0x00481963
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602087C RID: 133244 RVA: 0x00483772 File Offset: 0x00481972
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009464 RID: 37988
		// (get) Token: 0x0602087D RID: 133245 RVA: 0x00483780 File Offset: 0x00481980
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

		// Token: 0x0602087E RID: 133246 RVA: 0x004837B7 File Offset: 0x004819B7
		public Span<byte> GetJsonStringBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602087F RID: 133247 RVA: 0x004837C6 File Offset: 0x004819C6
		public byte[] GetJsonStringArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x06020880 RID: 133248 RVA: 0x004837D4 File Offset: 0x004819D4
		public static Offset<ICustomJsonCondition> CreateICustomJsonCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, StringOffset NameOffset = default(StringOffset), StringOffset JsonStringOffset = default(StringOffset))
		{
			builder.StartTable(3);
			ICustomJsonCondition.AddJsonString(builder, JsonStringOffset);
			ICustomJsonCondition.AddName(builder, NameOffset);
			ICustomJsonCondition.AddType(builder, Type);
			return ICustomJsonCondition.EndICustomJsonCondition(builder);
		}

		// Token: 0x06020881 RID: 133249 RVA: 0x004837F8 File Offset: 0x004819F8
		public static void StartICustomJsonCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06020882 RID: 133250 RVA: 0x00483801 File Offset: 0x00481A01
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020883 RID: 133251 RVA: 0x0048380C File Offset: 0x00481A0C
		public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset)
		{
			builder.AddOffset(1, nameOffset.Value, 0);
		}

		// Token: 0x06020884 RID: 133252 RVA: 0x0048381C File Offset: 0x00481A1C
		public static void AddJsonString(FlatBufferBuilder builder, StringOffset jsonStringOffset)
		{
			builder.AddOffset(2, jsonStringOffset.Value, 0);
		}

		// Token: 0x06020885 RID: 133253 RVA: 0x0048382C File Offset: 0x00481A2C
		public static Offset<ICustomJsonCondition> EndICustomJsonCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICustomJsonCondition>(builder.EndTable());
		}

		// Token: 0x06020886 RID: 133254 RVA: 0x0048383C File Offset: 0x00481A3C
		public ICustomJsonConditionT UnPack()
		{
			ICustomJsonConditionT customJsonConditionT = new ICustomJsonConditionT();
			this.UnPackTo(customJsonConditionT);
			return customJsonConditionT;
		}

		// Token: 0x06020887 RID: 133255 RVA: 0x00483857 File Offset: 0x00481A57
		public void UnPackTo(ICustomJsonConditionT _o)
		{
			_o.Type = this.Type;
			_o.Name = this.Name;
			_o.JsonString = this.JsonString;
		}

		// Token: 0x06020888 RID: 133256 RVA: 0x00483880 File Offset: 0x00481A80
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

		// Token: 0x0400E097 RID: 57495
		private Table __p;
	}
}
