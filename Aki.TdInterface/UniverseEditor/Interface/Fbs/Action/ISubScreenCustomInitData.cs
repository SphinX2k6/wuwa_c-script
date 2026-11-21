using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079DA RID: 31194
	public struct ISubScreenCustomInitData : IFlatbufferObject
	{
		// Token: 0x1700E4B1 RID: 58545
		// (get) Token: 0x06036F5C RID: 225116 RVA: 0x007591AA File Offset: 0x007573AA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F5D RID: 225117 RVA: 0x007591B7 File Offset: 0x007573B7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F5E RID: 225118 RVA: 0x007591C0 File Offset: 0x007573C0
		public static ISubScreenCustomInitData GetRootAsISubScreenCustomInitData(ByteBuffer _bb)
		{
			return ISubScreenCustomInitData.GetRootAsISubScreenCustomInitData(_bb, default(ISubScreenCustomInitData));
		}

		// Token: 0x06036F5F RID: 225119 RVA: 0x007591DC File Offset: 0x007573DC
		public static ISubScreenCustomInitData GetRootAsISubScreenCustomInitData(ByteBuffer _bb, ISubScreenCustomInitData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F60 RID: 225120 RVA: 0x007591F9 File Offset: 0x007573F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F61 RID: 225121 RVA: 0x00759208 File Offset: 0x00757408
		public ISubScreenCustomInitData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4B2 RID: 58546
		// (get) Token: 0x06036F62 RID: 225122 RVA: 0x00759218 File Offset: 0x00757418
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

		// Token: 0x1700E4B3 RID: 58547
		// (get) Token: 0x06036F63 RID: 225123 RVA: 0x00759254 File Offset: 0x00757454
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

		// Token: 0x06036F64 RID: 225124 RVA: 0x0075928B File Offset: 0x0075748B
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036F65 RID: 225125 RVA: 0x0075929A File Offset: 0x0075749A
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E4B4 RID: 58548
		// (get) Token: 0x06036F66 RID: 225126 RVA: 0x007592A8 File Offset: 0x007574A8
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

		// Token: 0x06036F67 RID: 225127 RVA: 0x00759305 File Offset: 0x00757505
		public static Offset<ISubScreenCustomInitData> CreateISubScreenCustomInitData(FlatBufferBuilder builder, ESubScreenInitDataType Type = ESubScreenInitDataType.Preset, StringOffset SubScreenKeyOffset = default(StringOffset), Offset<ISubScreenConfig> InitConfigOffset = default(Offset<ISubScreenConfig>))
		{
			builder.StartTable(3);
			ISubScreenCustomInitData.AddInitConfig(builder, InitConfigOffset);
			ISubScreenCustomInitData.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreenCustomInitData.AddType(builder, Type);
			return ISubScreenCustomInitData.EndISubScreenCustomInitData(builder);
		}

		// Token: 0x06036F68 RID: 225128 RVA: 0x00759329 File Offset: 0x00757529
		public static void StartISubScreenCustomInitData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036F69 RID: 225129 RVA: 0x00759332 File Offset: 0x00757532
		public static void AddType(FlatBufferBuilder builder, ESubScreenInitDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F6A RID: 225130 RVA: 0x0075933D File Offset: 0x0075753D
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x06036F6B RID: 225131 RVA: 0x0075934D File Offset: 0x0075754D
		public static void AddInitConfig(FlatBufferBuilder builder, Offset<ISubScreenConfig> initConfigOffset)
		{
			builder.AddOffset(2, initConfigOffset.Value, 0);
		}

		// Token: 0x06036F6C RID: 225132 RVA: 0x0075935D File Offset: 0x0075755D
		public static Offset<ISubScreenCustomInitData> EndISubScreenCustomInitData(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenCustomInitData>(builder.EndTable());
		}

		// Token: 0x06036F6D RID: 225133 RVA: 0x0075936C File Offset: 0x0075756C
		public ISubScreenCustomInitDataT UnPack()
		{
			ISubScreenCustomInitDataT subScreenCustomInitDataT = new ISubScreenCustomInitDataT();
			this.UnPackTo(subScreenCustomInitDataT);
			return subScreenCustomInitDataT;
		}

		// Token: 0x06036F6E RID: 225134 RVA: 0x00759388 File Offset: 0x00757588
		public void UnPackTo(ISubScreenCustomInitDataT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
			_o.InitConfig = ((this.InitConfig != null) ? this.InitConfig.Value.UnPack() : null);
		}

		// Token: 0x06036F6F RID: 225135 RVA: 0x007593DC File Offset: 0x007575DC
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

		// Token: 0x04012CED RID: 77037
		private Table __p;
	}
}
