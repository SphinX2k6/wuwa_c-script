using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A41 RID: 27201
	public struct IClientFollowShooterPlayAnimation : IFlatbufferObject
	{
		// Token: 0x1700C7DC RID: 51164
		// (get) Token: 0x0602EA7E RID: 191102 RVA: 0x0065C44A File Offset: 0x0065A64A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA7F RID: 191103 RVA: 0x0065C457 File Offset: 0x0065A657
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA80 RID: 191104 RVA: 0x0065C460 File Offset: 0x0065A660
		public static IClientFollowShooterPlayAnimation GetRootAsIClientFollowShooterPlayAnimation(ByteBuffer _bb)
		{
			return IClientFollowShooterPlayAnimation.GetRootAsIClientFollowShooterPlayAnimation(_bb, default(IClientFollowShooterPlayAnimation));
		}

		// Token: 0x0602EA81 RID: 191105 RVA: 0x0065C47C File Offset: 0x0065A67C
		public static IClientFollowShooterPlayAnimation GetRootAsIClientFollowShooterPlayAnimation(ByteBuffer _bb, IClientFollowShooterPlayAnimation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA82 RID: 191106 RVA: 0x0065C499 File Offset: 0x0065A699
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA83 RID: 191107 RVA: 0x0065C4A8 File Offset: 0x0065A6A8
		public IClientFollowShooterPlayAnimation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7DD RID: 51165
		// (get) Token: 0x0602EA84 RID: 191108 RVA: 0x0065C4B8 File Offset: 0x0065A6B8
		public EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return (EClientFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7DE RID: 51166
		// (get) Token: 0x0602EA85 RID: 191109 RVA: 0x0065C4F4 File Offset: 0x0065A6F4
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

		// Token: 0x0602EA86 RID: 191110 RVA: 0x0065C52B File Offset: 0x0065A72B
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602EA87 RID: 191111 RVA: 0x0065C53A File Offset: 0x0065A73A
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602EA88 RID: 191112 RVA: 0x0065C548 File Offset: 0x0065A748
		public static Offset<IClientFollowShooterPlayAnimation> CreateIClientFollowShooterPlayAnimation(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType Type = EClientFollowShooterLeisureInteractType.PlayAnimation, StringOffset MontageOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IClientFollowShooterPlayAnimation.AddMontage(builder, MontageOffset);
			IClientFollowShooterPlayAnimation.AddType(builder, Type);
			return IClientFollowShooterPlayAnimation.EndIClientFollowShooterPlayAnimation(builder);
		}

		// Token: 0x0602EA89 RID: 191113 RVA: 0x0065C565 File Offset: 0x0065A765
		public static void StartIClientFollowShooterPlayAnimation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EA8A RID: 191114 RVA: 0x0065C56E File Offset: 0x0065A76E
		public static void AddType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EA8B RID: 191115 RVA: 0x0065C579 File Offset: 0x0065A779
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x0602EA8C RID: 191116 RVA: 0x0065C589 File Offset: 0x0065A789
		public static Offset<IClientFollowShooterPlayAnimation> EndIClientFollowShooterPlayAnimation(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterPlayAnimation>(builder.EndTable());
		}

		// Token: 0x0602EA8D RID: 191117 RVA: 0x0065C598 File Offset: 0x0065A798
		public IClientFollowShooterPlayAnimationT UnPack()
		{
			IClientFollowShooterPlayAnimationT clientFollowShooterPlayAnimationT = new IClientFollowShooterPlayAnimationT();
			this.UnPackTo(clientFollowShooterPlayAnimationT);
			return clientFollowShooterPlayAnimationT;
		}

		// Token: 0x0602EA8E RID: 191118 RVA: 0x0065C5B3 File Offset: 0x0065A7B3
		public void UnPackTo(IClientFollowShooterPlayAnimationT _o)
		{
			_o.Type = this.Type;
			_o.Montage = this.Montage;
		}

		// Token: 0x0602EA8F RID: 191119 RVA: 0x0065C5D0 File Offset: 0x0065A7D0
		public static Offset<IClientFollowShooterPlayAnimation> Pack(FlatBufferBuilder builder, IClientFollowShooterPlayAnimationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterPlayAnimation>);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			return IClientFollowShooterPlayAnimation.CreateIClientFollowShooterPlayAnimation(builder, _o.Type, montageOffset);
		}

		// Token: 0x040117C2 RID: 71618
		private Table __p;
	}
}
