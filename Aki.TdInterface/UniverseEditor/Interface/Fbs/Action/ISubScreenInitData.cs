using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007208 RID: 29192
	public struct ISubScreenInitData : IFlatbufferObject
	{
		// Token: 0x1700D8BF RID: 55487
		// (get) Token: 0x06033C76 RID: 212086 RVA: 0x006F8197 File Offset: 0x006F6397
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C77 RID: 212087 RVA: 0x006F81A4 File Offset: 0x006F63A4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C78 RID: 212088 RVA: 0x006F81AC File Offset: 0x006F63AC
		public static ISubScreenInitData GetRootAsISubScreenInitData(ByteBuffer _bb)
		{
			return ISubScreenInitData.GetRootAsISubScreenInitData(_bb, default(ISubScreenInitData));
		}

		// Token: 0x06033C79 RID: 212089 RVA: 0x006F81C8 File Offset: 0x006F63C8
		public static ISubScreenInitData GetRootAsISubScreenInitData(ByteBuffer _bb, ISubScreenInitData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C7A RID: 212090 RVA: 0x006F81E5 File Offset: 0x006F63E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C7B RID: 212091 RVA: 0x006F81F4 File Offset: 0x006F63F4
		public ISubScreenInitData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8C0 RID: 55488
		// (get) Token: 0x06033C7C RID: 212092 RVA: 0x006F8204 File Offset: 0x006F6404
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

		// Token: 0x1700D8C1 RID: 55489
		// (get) Token: 0x06033C7D RID: 212093 RVA: 0x006F8240 File Offset: 0x006F6440
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

		// Token: 0x06033C7E RID: 212094 RVA: 0x006F8277 File Offset: 0x006F6477
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033C7F RID: 212095 RVA: 0x006F8286 File Offset: 0x006F6486
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06033C80 RID: 212096 RVA: 0x006F8294 File Offset: 0x006F6494
		public static Offset<ISubScreenInitData> CreateISubScreenInitData(FlatBufferBuilder builder, ESubScreenInitDataType Type = ESubScreenInitDataType.Preset, StringOffset SubScreenKeyOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISubScreenInitData.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreenInitData.AddType(builder, Type);
			return ISubScreenInitData.EndISubScreenInitData(builder);
		}

		// Token: 0x06033C81 RID: 212097 RVA: 0x006F82B1 File Offset: 0x006F64B1
		public static void StartISubScreenInitData(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033C82 RID: 212098 RVA: 0x006F82BA File Offset: 0x006F64BA
		public static void AddType(FlatBufferBuilder builder, ESubScreenInitDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033C83 RID: 212099 RVA: 0x006F82C5 File Offset: 0x006F64C5
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x06033C84 RID: 212100 RVA: 0x006F82D5 File Offset: 0x006F64D5
		public static Offset<ISubScreenInitData> EndISubScreenInitData(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenInitData>(builder.EndTable());
		}

		// Token: 0x06033C85 RID: 212101 RVA: 0x006F82E4 File Offset: 0x006F64E4
		public ISubScreenInitDataT UnPack()
		{
			ISubScreenInitDataT subScreenInitDataT = new ISubScreenInitDataT();
			this.UnPackTo(subScreenInitDataT);
			return subScreenInitDataT;
		}

		// Token: 0x06033C86 RID: 212102 RVA: 0x006F82FF File Offset: 0x006F64FF
		public void UnPackTo(ISubScreenInitDataT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
		}

		// Token: 0x06033C87 RID: 212103 RVA: 0x006F831C File Offset: 0x006F651C
		public static Offset<ISubScreenInitData> Pack(FlatBufferBuilder builder, ISubScreenInitDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenInitData>);
			}
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			return ISubScreenInitData.CreateISubScreenInitData(builder, _o.Type, subScreenKeyOffset);
		}

		// Token: 0x04011CEF RID: 72943
		private Table __p;
	}
}
