using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007205 RID: 29189
	public struct ISubScreenCustomInitData : IFlatbufferObject
	{
		// Token: 0x1700D8B8 RID: 55480
		// (get) Token: 0x06033C5A RID: 212058 RVA: 0x006F7E4A File Offset: 0x006F604A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C5B RID: 212059 RVA: 0x006F7E57 File Offset: 0x006F6057
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C5C RID: 212060 RVA: 0x006F7E60 File Offset: 0x006F6060
		public static ISubScreenCustomInitData GetRootAsISubScreenCustomInitData(ByteBuffer _bb)
		{
			return ISubScreenCustomInitData.GetRootAsISubScreenCustomInitData(_bb, default(ISubScreenCustomInitData));
		}

		// Token: 0x06033C5D RID: 212061 RVA: 0x006F7E7C File Offset: 0x006F607C
		public static ISubScreenCustomInitData GetRootAsISubScreenCustomInitData(ByteBuffer _bb, ISubScreenCustomInitData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C5E RID: 212062 RVA: 0x006F7E99 File Offset: 0x006F6099
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C5F RID: 212063 RVA: 0x006F7EA8 File Offset: 0x006F60A8
		public ISubScreenCustomInitData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8B9 RID: 55481
		// (get) Token: 0x06033C60 RID: 212064 RVA: 0x006F7EB8 File Offset: 0x006F60B8
		public ESubScreenInitDataType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubScreenInitDataType.Preset;
				}
				return (ESubScreenInitDataType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D8BA RID: 55482
		// (get) Token: 0x06033C61 RID: 212065 RVA: 0x006F7EF4 File Offset: 0x006F60F4
		public string SubScreenKey
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

		// Token: 0x06033C62 RID: 212066 RVA: 0x006F7F2B File Offset: 0x006F612B
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033C63 RID: 212067 RVA: 0x006F7F3A File Offset: 0x006F613A
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D8BB RID: 55483
		// (get) Token: 0x06033C64 RID: 212068 RVA: 0x006F7F48 File Offset: 0x006F6148
		public ISubScreenConfig? InitConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISubScreenConfig?(default(ISubScreenConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06033C65 RID: 212069 RVA: 0x006F7FA5 File Offset: 0x006F61A5
		public static Offset<ISubScreenCustomInitData> CreateISubScreenCustomInitData(FlatBufferBuilder builder, ESubScreenInitDataType Type = ESubScreenInitDataType.Preset, StringOffset SubScreenKeyOffset = default(StringOffset), Offset<ISubScreenConfig> InitConfigOffset = default(Offset<ISubScreenConfig>))
		{
			builder.StartTable(3);
			ISubScreenCustomInitData.AddInitConfig(builder, InitConfigOffset);
			ISubScreenCustomInitData.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreenCustomInitData.AddType(builder, Type);
			return ISubScreenCustomInitData.EndISubScreenCustomInitData(builder);
		}

		// Token: 0x06033C66 RID: 212070 RVA: 0x006F7FC9 File Offset: 0x006F61C9
		public static void StartISubScreenCustomInitData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033C67 RID: 212071 RVA: 0x006F7FD2 File Offset: 0x006F61D2
		public static void AddType(FlatBufferBuilder builder, ESubScreenInitDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033C68 RID: 212072 RVA: 0x006F7FDD File Offset: 0x006F61DD
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x06033C69 RID: 212073 RVA: 0x006F7FED File Offset: 0x006F61ED
		public static void AddInitConfig(FlatBufferBuilder builder, Offset<ISubScreenConfig> initConfigOffset)
		{
			builder.AddOffset(2, initConfigOffset.Value, 0);
		}

		// Token: 0x06033C6A RID: 212074 RVA: 0x006F7FFD File Offset: 0x006F61FD
		public static Offset<ISubScreenCustomInitData> EndISubScreenCustomInitData(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenCustomInitData>(builder.EndTable());
		}

		// Token: 0x06033C6B RID: 212075 RVA: 0x006F800C File Offset: 0x006F620C
		public ISubScreenCustomInitDataT UnPack()
		{
			ISubScreenCustomInitDataT subScreenCustomInitDataT = new ISubScreenCustomInitDataT();
			this.UnPackTo(subScreenCustomInitDataT);
			return subScreenCustomInitDataT;
		}

		// Token: 0x06033C6C RID: 212076 RVA: 0x006F8028 File Offset: 0x006F6228
		public void UnPackTo(ISubScreenCustomInitDataT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
			_o.InitConfig = ((this.InitConfig != null) ? this.InitConfig.Value.UnPack() : null);
		}

		// Token: 0x06033C6D RID: 212077 RVA: 0x006F807C File Offset: 0x006F627C
		public static Offset<ISubScreenCustomInitData> Pack(FlatBufferBuilder builder, ISubScreenCustomInitDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenCustomInitData>);
			}
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			Offset<ISubScreenConfig> initConfigOffset = (_o.InitConfig == null) ? default(Offset<ISubScreenConfig>) : ISubScreenConfig.Pack(builder, _o.InitConfig);
			return ISubScreenCustomInitData.CreateISubScreenCustomInitData(builder, _o.Type, subScreenKeyOffset, initConfigOffset);
		}

		// Token: 0x04011CEB RID: 72939
		private Table __p;
	}
}
