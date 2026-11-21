using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079DD RID: 31197
	public struct ISubScreenInitData : IFlatbufferObject
	{
		// Token: 0x1700E4B8 RID: 58552
		// (get) Token: 0x06036F78 RID: 225144 RVA: 0x007594F7 File Offset: 0x007576F7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F79 RID: 225145 RVA: 0x00759504 File Offset: 0x00757704
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036F7A RID: 225146 RVA: 0x0075950C File Offset: 0x0075770C
		public static ISubScreenInitData GetRootAsISubScreenInitData(ByteBuffer _bb)
		{
			return ISubScreenInitData.GetRootAsISubScreenInitData(_bb, default(ISubScreenInitData));
		}

		// Token: 0x06036F7B RID: 225147 RVA: 0x00759528 File Offset: 0x00757728
		public static ISubScreenInitData GetRootAsISubScreenInitData(ByteBuffer _bb, ISubScreenInitData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036F7C RID: 225148 RVA: 0x00759545 File Offset: 0x00757745
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036F7D RID: 225149 RVA: 0x00759554 File Offset: 0x00757754
		public ISubScreenInitData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4B9 RID: 58553
		// (get) Token: 0x06036F7E RID: 225150 RVA: 0x00759564 File Offset: 0x00757764
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

		// Token: 0x1700E4BA RID: 58554
		// (get) Token: 0x06036F7F RID: 225151 RVA: 0x007595A0 File Offset: 0x007577A0
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

		// Token: 0x06036F80 RID: 225152 RVA: 0x007595D7 File Offset: 0x007577D7
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06036F81 RID: 225153 RVA: 0x007595E6 File Offset: 0x007577E6
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06036F82 RID: 225154 RVA: 0x007595F4 File Offset: 0x007577F4
		public static Offset<ISubScreenInitData> CreateISubScreenInitData(FlatBufferBuilder builder, ESubScreenInitDataType Type = ESubScreenInitDataType.Preset, StringOffset SubScreenKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISubScreenInitData.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreenInitData.AddType(builder, Type);
			return ISubScreenInitData.EndISubScreenInitData(builder);
		}

		// Token: 0x06036F83 RID: 225155 RVA: 0x00759611 File Offset: 0x00757811
		public static void StartISubScreenInitData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036F84 RID: 225156 RVA: 0x0075961A File Offset: 0x0075781A
		public static void AddType(FlatBufferBuilder builder, ESubScreenInitDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036F85 RID: 225157 RVA: 0x00759625 File Offset: 0x00757825
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x06036F86 RID: 225158 RVA: 0x00759635 File Offset: 0x00757835
		public static Offset<ISubScreenInitData> EndISubScreenInitData(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenInitData>(builder.EndTable());
		}

		// Token: 0x06036F87 RID: 225159 RVA: 0x00759644 File Offset: 0x00757844
		public ISubScreenInitDataT UnPack()
		{
			ISubScreenInitDataT subScreenInitDataT = new ISubScreenInitDataT();
			this.UnPackTo(subScreenInitDataT);
			return subScreenInitDataT;
		}

		// Token: 0x06036F88 RID: 225160 RVA: 0x0075965F File Offset: 0x0075785F
		public void UnPackTo(ISubScreenInitDataT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
		}

		// Token: 0x06036F89 RID: 225161 RVA: 0x0075967C File Offset: 0x0075787C
		public static Offset<ISubScreenInitData> Pack(FlatBufferBuilder builder, ISubScreenInitDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenInitData>);
			}
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			return ISubScreenInitData.CreateISubScreenInitData(builder, _o.Type, subScreenKeyOffset);
		}

		// Token: 0x04012CF1 RID: 77041
		private Table __p;
	}
}
