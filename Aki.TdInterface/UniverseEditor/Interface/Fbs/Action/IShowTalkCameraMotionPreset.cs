using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078BD RID: 30909
	public struct IShowTalkCameraMotionPreset : IFlatbufferObject
	{
		// Token: 0x1700E2CC RID: 58060
		// (get) Token: 0x06036691 RID: 222865 RVA: 0x00749435 File Offset: 0x00747635
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036692 RID: 222866 RVA: 0x00749442 File Offset: 0x00747642
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036693 RID: 222867 RVA: 0x0074944C File Offset: 0x0074764C
		public static IShowTalkCameraMotionPreset GetRootAsIShowTalkCameraMotionPreset(ByteBuffer _bb)
		{
			return IShowTalkCameraMotionPreset.GetRootAsIShowTalkCameraMotionPreset(_bb, default(IShowTalkCameraMotionPreset));
		}

		// Token: 0x06036694 RID: 222868 RVA: 0x00749468 File Offset: 0x00747668
		public static IShowTalkCameraMotionPreset GetRootAsIShowTalkCameraMotionPreset(ByteBuffer _bb, IShowTalkCameraMotionPreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036695 RID: 222869 RVA: 0x00749485 File Offset: 0x00747685
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036696 RID: 222870 RVA: 0x00749494 File Offset: 0x00747694
		public IShowTalkCameraMotionPreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2CD RID: 58061
		// (get) Token: 0x06036697 RID: 222871 RVA: 0x007494A4 File Offset: 0x007476A4
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

		// Token: 0x1700E2CE RID: 58062
		// (get) Token: 0x06036698 RID: 222872 RVA: 0x007494E0 File Offset: 0x007476E0
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

		// Token: 0x06036699 RID: 222873 RVA: 0x00749517 File Offset: 0x00747717
		public Span<byte> GetSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603669A RID: 222874 RVA: 0x00749526 File Offset: 0x00747726
		public byte[] GetSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E2CF RID: 58063
		// (get) Token: 0x0603669B RID: 222875 RVA: 0x00749534 File Offset: 0x00747734
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

		// Token: 0x0603669C RID: 222876 RVA: 0x00749591 File Offset: 0x00747791
		public static Offset<IShowTalkCameraMotionPreset> CreateIShowTalkCameraMotionPreset(FlatBufferBuilder builder, EShowTalkCameraMotionType Type = EShowTalkCameraMotionType.Preset, StringOffset SequenceOffset = default(StringOffset), Offset<IFlowCameraShake> CamShakeOffset = default(Offset<IFlowCameraShake>))
		{
			builder.StartTable(3);
			IShowTalkCameraMotionPreset.AddCamShake(builder, CamShakeOffset);
			IShowTalkCameraMotionPreset.AddSequence(builder, SequenceOffset);
			IShowTalkCameraMotionPreset.AddType(builder, Type);
			return IShowTalkCameraMotionPreset.EndIShowTalkCameraMotionPreset(builder);
		}

		// Token: 0x0603669D RID: 222877 RVA: 0x007495B5 File Offset: 0x007477B5
		public static void StartIShowTalkCameraMotionPreset(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603669E RID: 222878 RVA: 0x007495BE File Offset: 0x007477BE
		public static void AddType(FlatBufferBuilder builder, EShowTalkCameraMotionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603669F RID: 222879 RVA: 0x007495C9 File Offset: 0x007477C9
		public static void AddSequence(FlatBufferBuilder builder, StringOffset sequenceOffset)
		{
			builder.AddOffset(1, sequenceOffset.Value, 0);
		}

		// Token: 0x060366A0 RID: 222880 RVA: 0x007495D9 File Offset: 0x007477D9
		public static void AddCamShake(FlatBufferBuilder builder, Offset<IFlowCameraShake> camShakeOffset)
		{
			builder.AddOffset(2, camShakeOffset.Value, 0);
		}

		// Token: 0x060366A1 RID: 222881 RVA: 0x007495E9 File Offset: 0x007477E9
		public static Offset<IShowTalkCameraMotionPreset> EndIShowTalkCameraMotionPreset(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkCameraMotionPreset>(builder.EndTable());
		}

		// Token: 0x060366A2 RID: 222882 RVA: 0x007495F8 File Offset: 0x007477F8
		public IShowTalkCameraMotionPresetT UnPack()
		{
			IShowTalkCameraMotionPresetT showTalkCameraMotionPresetT = new IShowTalkCameraMotionPresetT();
			this.UnPackTo(showTalkCameraMotionPresetT);
			return showTalkCameraMotionPresetT;
		}

		// Token: 0x060366A3 RID: 222883 RVA: 0x00749614 File Offset: 0x00747814
		public void UnPackTo(IShowTalkCameraMotionPresetT _o)
		{
			_o.Type = this.Type;
			_o.Sequence = this.Sequence;
			_o.CamShake = ((this.CamShake != null) ? this.CamShake.Value.UnPack() : null);
		}

		// Token: 0x060366A4 RID: 222884 RVA: 0x00749668 File Offset: 0x00747868
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

		// Token: 0x04012B63 RID: 76643
		private Table __p;
	}
}
