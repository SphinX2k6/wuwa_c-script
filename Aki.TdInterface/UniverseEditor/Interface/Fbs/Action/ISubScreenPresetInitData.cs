using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200721D RID: 29213
	public struct ISubScreenPresetInitData : IFlatbufferObject
	{
		// Token: 0x1700D8DB RID: 55515
		// (get) Token: 0x06033D1C RID: 212252 RVA: 0x006F9527 File Offset: 0x006F7727
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D1D RID: 212253 RVA: 0x006F9534 File Offset: 0x006F7734
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D1E RID: 212254 RVA: 0x006F953C File Offset: 0x006F773C
		public static ISubScreenPresetInitData GetRootAsISubScreenPresetInitData(ByteBuffer _bb)
		{
			return ISubScreenPresetInitData.GetRootAsISubScreenPresetInitData(_bb, default(ISubScreenPresetInitData));
		}

		// Token: 0x06033D1F RID: 212255 RVA: 0x006F9558 File Offset: 0x006F7758
		public static ISubScreenPresetInitData GetRootAsISubScreenPresetInitData(ByteBuffer _bb, ISubScreenPresetInitData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D20 RID: 212256 RVA: 0x006F9575 File Offset: 0x006F7775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D21 RID: 212257 RVA: 0x006F9584 File Offset: 0x006F7784
		public ISubScreenPresetInitData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8DC RID: 55516
		// (get) Token: 0x06033D22 RID: 212258 RVA: 0x006F9594 File Offset: 0x006F7794
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

		// Token: 0x1700D8DD RID: 55517
		// (get) Token: 0x06033D23 RID: 212259 RVA: 0x006F95D0 File Offset: 0x006F77D0
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

		// Token: 0x06033D24 RID: 212260 RVA: 0x006F9607 File Offset: 0x006F7807
		public Span<byte> GetSubScreenKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06033D25 RID: 212261 RVA: 0x006F9616 File Offset: 0x006F7816
		public byte[] GetSubScreenKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D8DE RID: 55518
		// (get) Token: 0x06033D26 RID: 212262 RVA: 0x006F9624 File Offset: 0x006F7824
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

		// Token: 0x06033D27 RID: 212263 RVA: 0x006F9660 File Offset: 0x006F7860
		public static Offset<ISubScreenPresetInitData> CreateISubScreenPresetInitData(FlatBufferBuilder builder, ESubScreenInitDataType Type = ESubScreenInitDataType.Preset, StringOffset SubScreenKeyOffset = default(StringOffset), ESubScreenInitPreset AnchorType = ESubScreenInitPreset.Left)
		{
			builder.StartTable(3);
			ISubScreenPresetInitData.AddSubScreenKey(builder, SubScreenKeyOffset);
			ISubScreenPresetInitData.AddAnchorType(builder, AnchorType);
			ISubScreenPresetInitData.AddType(builder, Type);
			return ISubScreenPresetInitData.EndISubScreenPresetInitData(builder);
		}

		// Token: 0x06033D28 RID: 212264 RVA: 0x006F9684 File Offset: 0x006F7884
		public static void StartISubScreenPresetInitData(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033D29 RID: 212265 RVA: 0x006F968D File Offset: 0x006F788D
		public static void AddType(FlatBufferBuilder builder, ESubScreenInitDataType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D2A RID: 212266 RVA: 0x006F9698 File Offset: 0x006F7898
		public static void AddSubScreenKey(FlatBufferBuilder builder, StringOffset subScreenKeyOffset)
		{
			builder.AddOffset(1, subScreenKeyOffset.Value, 0);
		}

		// Token: 0x06033D2B RID: 212267 RVA: 0x006F96A8 File Offset: 0x006F78A8
		public static void AddAnchorType(FlatBufferBuilder builder, ESubScreenInitPreset anchorType)
		{
			builder.AddByte(2, (byte)anchorType, 0);
		}

		// Token: 0x06033D2C RID: 212268 RVA: 0x006F96B3 File Offset: 0x006F78B3
		public static Offset<ISubScreenPresetInitData> EndISubScreenPresetInitData(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenPresetInitData>(builder.EndTable());
		}

		// Token: 0x06033D2D RID: 212269 RVA: 0x006F96C0 File Offset: 0x006F78C0
		public ISubScreenPresetInitDataT UnPack()
		{
			ISubScreenPresetInitDataT subScreenPresetInitDataT = new ISubScreenPresetInitDataT();
			this.UnPackTo(subScreenPresetInitDataT);
			return subScreenPresetInitDataT;
		}

		// Token: 0x06033D2E RID: 212270 RVA: 0x006F96DB File Offset: 0x006F78DB
		public void UnPackTo(ISubScreenPresetInitDataT _o)
		{
			_o.Type = this.Type;
			_o.SubScreenKey = this.SubScreenKey;
			_o.AnchorType = this.AnchorType;
		}

		// Token: 0x06033D2F RID: 212271 RVA: 0x006F9704 File Offset: 0x006F7904
		public static Offset<ISubScreenPresetInitData> Pack(FlatBufferBuilder builder, ISubScreenPresetInitDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenPresetInitData>);
			}
			StringOffset subScreenKeyOffset = (_o.SubScreenKey == null) ? default(StringOffset) : builder.CreateString(_o.SubScreenKey);
			return ISubScreenPresetInitData.CreateISubScreenPresetInitData(builder, _o.Type, subScreenKeyOffset, _o.AnchorType);
		}

		// Token: 0x04011D0C RID: 72972
		private Table __p;
	}
}
