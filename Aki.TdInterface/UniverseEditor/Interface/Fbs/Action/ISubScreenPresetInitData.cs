using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079F2 RID: 31218
	public struct ISubScreenPresetInitData : IFlatbufferObject
	{
		// Token: 0x1700E4D4 RID: 58580
		// (get) Token: 0x0603701E RID: 225310 RVA: 0x0075A887 File Offset: 0x00758A87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603701F RID: 225311 RVA: 0x0075A894 File Offset: 0x00758A94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037020 RID: 225312 RVA: 0x0075A89C File Offset: 0x00758A9C
		public static ISubScreenPresetInitData GetRootAsISubScreenPresetInitData(ByteBuffer _bb)
		{
			return ISubScreenPresetInitData.GetRootAsISubScreenPresetInitData(_bb, default(ISubScreenPresetInitData));
		}

		// Token: 0x06037021 RID: 225313 RVA: 0x0075A8B8 File Offset: 0x00758AB8
		public static ISubScreenPresetInitData GetRootAsISubScreenPresetInitData(ByteBuffer _bb, ISubScreenPresetInitData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06037022 RID: 225314 RVA: 0x0075A8D5 File Offset: 0x00758AD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06037023 RID: 225315 RVA: 0x0075A8E4 File Offset: 0x00758AE4
		public ISubScreenPresetInitData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4D5 RID: 58581
		// (get) Token: 0x06037024 RID: 225316 RVA: 0x0075A8F4 File Offset: 0x00758AF4
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

		// Token: 0x1700E4D6 RID: 58582
		// (get) Token: 0x06037025 RID: 225317 RVA: 0x0075A930 File Offset: 0x00758B30
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

		// Token: 0x06037026 RID: 225318 RVA: 0x0075A967 File Offset: 0x00758B67
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06037027 RID: 225319 RVA: 0x0075A976 File Offset: 0x00758B76
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E4D7 RID: 58583
		// (get) Token: 0x06037028 RID: 225320 RVA: 0x0075A984 File Offset: 0x00758B84
		public ESubScreenInitPreset AnchorType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ESubScreenInitPreset.Left;
				}
				return (ESubScreenInitPreset)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037029 RID: 225321 RVA: 0x0075A9C0 File Offset: 0x00758BC0
		public static Offset<ISubScreenPresetInitData> CreateISubScreenPresetInitData(FlatBufferBuilder builder, ESubScreenInitDataType Type = ESubScreenInitDataType.Preset, StringOffset SubScreenKeyOffset = default(StringOffset), ESubScreenInitPreset AnchorType = ESubScreenInitPreset.Left)
		{
			builder.StartTable(3);
			ISubScreenPresetInitData.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreenPresetInitData.AddAnchorType(builder, AnchorType);
			ISubScreenPresetInitData.AddType(builder, Type);
			return ISubScreenPresetInitData.EndISubScreenPresetInitData(builder);
		}

		// Token: 0x0603702A RID: 225322 RVA: 0x0075A9E4 File Offset: 0x00758BE4
		public static void StartISubScreenPresetInitData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603702B RID: 225323 RVA: 0x0075A9ED File Offset: 0x00758BED
		public static void AddType(FlatBufferBuilder builder, ESubScreenInitDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603702C RID: 225324 RVA: 0x0075A9F8 File Offset: 0x00758BF8
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x0603702D RID: 225325 RVA: 0x0075AA08 File Offset: 0x00758C08
		public static void AddAnchorType(FlatBufferBuilder builder, ESubScreenInitPreset anchorType)
		{
			builder.AddByte(2, (byte)anchorType, 0);
		}

		// Token: 0x0603702E RID: 225326 RVA: 0x0075AA13 File Offset: 0x00758C13
		public static Offset<ISubScreenPresetInitData> EndISubScreenPresetInitData(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenPresetInitData>(builder.EndTable());
		}

		// Token: 0x0603702F RID: 225327 RVA: 0x0075AA20 File Offset: 0x00758C20
		public ISubScreenPresetInitDataT UnPack()
		{
			ISubScreenPresetInitDataT subScreenPresetInitDataT = new ISubScreenPresetInitDataT();
			this.UnPackTo(subScreenPresetInitDataT);
			return subScreenPresetInitDataT;
		}

		// Token: 0x06037030 RID: 225328 RVA: 0x0075AA3B File Offset: 0x00758C3B
		public void UnPackTo(ISubScreenPresetInitDataT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
			_o.AnchorType = this.AnchorType;
		}

		// Token: 0x06037031 RID: 225329 RVA: 0x0075AA64 File Offset: 0x00758C64
		public static Offset<ISubScreenPresetInitData> Pack(FlatBufferBuilder builder, ISubScreenPresetInitDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenPresetInitData>);
			}
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			return ISubScreenPresetInitData.CreateISubScreenPresetInitData(builder, _o.Type, subScreenKeyOffset, _o.AnchorType);
		}

		// Token: 0x04012D0E RID: 77070
		private Table __p;
	}
}
