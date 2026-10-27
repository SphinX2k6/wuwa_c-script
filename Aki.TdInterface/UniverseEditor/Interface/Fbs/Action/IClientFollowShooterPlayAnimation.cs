using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063C7 RID: 25543
	public struct IClientFollowShooterPlayAnimation : IFlatbufferObject
	{
		// Token: 0x1700BE50 RID: 48720
		// (get) Token: 0x0602C2E9 RID: 180969 RVA: 0x00610F00 File Offset: 0x0060F100
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C2EA RID: 180970 RVA: 0x00610F0D File Offset: 0x0060F10D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C2EB RID: 180971 RVA: 0x00610F14 File Offset: 0x0060F114
		public static IClientFollowShooterPlayAnimation GetRootAsIClientFollowShooterPlayAnimation(ByteBuffer _bb)
		{
			return IClientFollowShooterPlayAnimation.GetRootAsIClientFollowShooterPlayAnimation(_bb, default(IClientFollowShooterPlayAnimation));
		}

		// Token: 0x0602C2EC RID: 180972 RVA: 0x00610F30 File Offset: 0x0060F130
		public static IClientFollowShooterPlayAnimation GetRootAsIClientFollowShooterPlayAnimation(ByteBuffer _bb, IClientFollowShooterPlayAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C2ED RID: 180973 RVA: 0x00610F4D File Offset: 0x0060F14D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C2EE RID: 180974 RVA: 0x00610F5C File Offset: 0x0060F15C
		public IClientFollowShooterPlayAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE51 RID: 48721
		// (get) Token: 0x0602C2EF RID: 180975 RVA: 0x00610F6C File Offset: 0x0060F16C
		public EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientFollowShooterLeisureInteractType.ResetToPlayer;
				}
				return (EClientFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BE52 RID: 48722
		// (get) Token: 0x0602C2F0 RID: 180976 RVA: 0x00610FA8 File Offset: 0x0060F1A8
		public string Montage
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

		// Token: 0x0602C2F1 RID: 180977 RVA: 0x00610FDF File Offset: 0x0060F1DF
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602C2F2 RID: 180978 RVA: 0x00610FEE File Offset: 0x0060F1EE
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602C2F3 RID: 180979 RVA: 0x00610FFC File Offset: 0x0060F1FC
		public static Offset<IClientFollowShooterPlayAnimation> CreateIClientFollowShooterPlayAnimation(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType Type = EClientFollowShooterLeisureInteractType.ResetToPlayer, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IClientFollowShooterPlayAnimation.AddMontage(builder, MontageOffset);
			IClientFollowShooterPlayAnimation.AddType(builder, Type);
			return IClientFollowShooterPlayAnimation.EndIClientFollowShooterPlayAnimation(builder);
		}

		// Token: 0x0602C2F4 RID: 180980 RVA: 0x00611019 File Offset: 0x0060F219
		public static void StartIClientFollowShooterPlayAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C2F5 RID: 180981 RVA: 0x00611022 File Offset: 0x0060F222
		public static void AddType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C2F6 RID: 180982 RVA: 0x0061102D File Offset: 0x0060F22D
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x0602C2F7 RID: 180983 RVA: 0x0061103D File Offset: 0x0060F23D
		public static Offset<IClientFollowShooterPlayAnimation> EndIClientFollowShooterPlayAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterPlayAnimation>(builder.EndTable());
		}

		// Token: 0x0602C2F8 RID: 180984 RVA: 0x0061104C File Offset: 0x0060F24C
		public IClientFollowShooterPlayAnimationT UnPack()
		{
			IClientFollowShooterPlayAnimationT clientFollowShooterPlayAnimationT = new IClientFollowShooterPlayAnimationT();
			this.UnPackTo(clientFollowShooterPlayAnimationT);
			return clientFollowShooterPlayAnimationT;
		}

		// Token: 0x0602C2F9 RID: 180985 RVA: 0x00611067 File Offset: 0x0060F267
		public void UnPackTo(IClientFollowShooterPlayAnimationT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x0602C2FA RID: 180986 RVA: 0x00611084 File Offset: 0x0060F284
		public static Offset<IClientFollowShooterPlayAnimation> Pack(FlatBufferBuilder builder, IClientFollowShooterPlayAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterPlayAnimation>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return IClientFollowShooterPlayAnimation.CreateIClientFollowShooterPlayAnimation(builder, _o.Type, montageOffset);
		}

		// Token: 0x040109A4 RID: 68004
		private Table __p;
	}
}
