using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070F1 RID: 28913
	public struct IShowTalkCameraMotionPreset : IFlatbufferObject
	{
		// Token: 0x1700D6E9 RID: 55017
		// (get) Token: 0x060333EF RID: 209903 RVA: 0x006E8E29 File Offset: 0x006E7029
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060333F0 RID: 209904 RVA: 0x006E8E36 File Offset: 0x006E7036
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060333F1 RID: 209905 RVA: 0x006E8E40 File Offset: 0x006E7040
		public static IShowTalkCameraMotionPreset GetRootAsIShowTalkCameraMotionPreset(ByteBuffer _bb)
		{
			return IShowTalkCameraMotionPreset.GetRootAsIShowTalkCameraMotionPreset(_bb, default(IShowTalkCameraMotionPreset));
		}

		// Token: 0x060333F2 RID: 209906 RVA: 0x006E8E5C File Offset: 0x006E705C
		public static IShowTalkCameraMotionPreset GetRootAsIShowTalkCameraMotionPreset(ByteBuffer _bb, IShowTalkCameraMotionPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060333F3 RID: 209907 RVA: 0x006E8E79 File Offset: 0x006E7079
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060333F4 RID: 209908 RVA: 0x006E8E88 File Offset: 0x006E7088
		public IShowTalkCameraMotionPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6EA RID: 55018
		// (get) Token: 0x060333F5 RID: 209909 RVA: 0x006E8E98 File Offset: 0x006E7098
		public EShowTalkCameraMotionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTalkCameraMotionType.Preset;
				}
				return (EShowTalkCameraMotionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D6EB RID: 55019
		// (get) Token: 0x060333F6 RID: 209910 RVA: 0x006E8ED4 File Offset: 0x006E70D4
		public string Sequence
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

		// Token: 0x060333F7 RID: 209911 RVA: 0x006E8F0B File Offset: 0x006E710B
		public Span<byte> GetSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060333F8 RID: 209912 RVA: 0x006E8F1A File Offset: 0x006E711A
		public byte[] GetSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D6EC RID: 55020
		// (get) Token: 0x060333F9 RID: 209913 RVA: 0x006E8F28 File Offset: 0x006E7128
		public IFlowCameraShake? CamShake
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFlowCameraShake?(default(IFlowCameraShake).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060333FA RID: 209914 RVA: 0x006E8F85 File Offset: 0x006E7185
		public static Offset<IShowTalkCameraMotionPreset> CreateIShowTalkCameraMotionPreset(FlatBufferBuilder builder, EShowTalkCameraMotionType Type = EShowTalkCameraMotionType.Preset, StringOffset SequenceOffset = default(StringOffset), Offset<IFlowCameraShake> CamShakeOffset = default(Offset<IFlowCameraShake>))
		{
			builder.StartTable(3);
			IShowTalkCameraMotionPreset.AddCamShake(builder, CamShakeOffset);
			IShowTalkCameraMotionPreset.AddSequence(builder, SequenceOffset);
			IShowTalkCameraMotionPreset.AddType(builder, Type);
			return IShowTalkCameraMotionPreset.EndIShowTalkCameraMotionPreset(builder);
		}

		// Token: 0x060333FB RID: 209915 RVA: 0x006E8FA9 File Offset: 0x006E71A9
		public static void StartIShowTalkCameraMotionPreset(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060333FC RID: 209916 RVA: 0x006E8FB2 File Offset: 0x006E71B2
		public static void AddType(FlatBufferBuilder builder, EShowTalkCameraMotionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060333FD RID: 209917 RVA: 0x006E8FBD File Offset: 0x006E71BD
		public static void AddSequence(FlatBufferBuilder builder, StringOffset sequenceOffset)
		{
			builder.AddOffset(1, sequenceOffset.Value, 0);
		}

		// Token: 0x060333FE RID: 209918 RVA: 0x006E8FCD File Offset: 0x006E71CD
		public static void AddCamShake(FlatBufferBuilder builder, Offset<IFlowCameraShake> camShakeOffset)
		{
			builder.AddOffset(2, camShakeOffset.Value, 0);
		}

		// Token: 0x060333FF RID: 209919 RVA: 0x006E8FDD File Offset: 0x006E71DD
		public static Offset<IShowTalkCameraMotionPreset> EndIShowTalkCameraMotionPreset(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkCameraMotionPreset>(builder.EndTable());
		}

		// Token: 0x06033400 RID: 209920 RVA: 0x006E8FEC File Offset: 0x006E71EC
		public IShowTalkCameraMotionPresetT UnPack()
		{
			IShowTalkCameraMotionPresetT showTalkCameraMotionPresetT = new IShowTalkCameraMotionPresetT();
			this.UnPackTo(showTalkCameraMotionPresetT);
			return showTalkCameraMotionPresetT;
		}

		// Token: 0x06033401 RID: 209921 RVA: 0x006E9008 File Offset: 0x006E7208
		public void UnPackTo(IShowTalkCameraMotionPresetT _o)
		{
			_o.Type = this.Type;
			_o.Sequence = this.Sequence;
			_o.CamShake = ((this.CamShake != null) ? this.CamShake.Value.UnPack() : null);
		}

		// Token: 0x06033402 RID: 209922 RVA: 0x006E905C File Offset: 0x006E725C
		public static Offset<IShowTalkCameraMotionPreset> Pack(FlatBufferBuilder builder, IShowTalkCameraMotionPresetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkCameraMotionPreset>);
			}
			StringOffset sequenceOffset = (_o.Sequence == null) ? default(StringOffset) : builder.CreateString(_o.Sequence);
			Offset<IFlowCameraShake> camShakeOffset = (_o.CamShake == null) ? default(Offset<IFlowCameraShake>) : IFlowCameraShake.Pack(builder, _o.CamShake);
			return IShowTalkCameraMotionPreset.CreateIShowTalkCameraMotionPreset(builder, _o.Type, sequenceOffset, camShakeOffset);
		}

		// Token: 0x04011B75 RID: 72565
		private Table __p;
	}
}
