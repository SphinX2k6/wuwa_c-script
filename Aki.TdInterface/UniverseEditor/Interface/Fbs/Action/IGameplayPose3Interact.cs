using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F20 RID: 28448
	public struct IGameplayPose3Interact : IFlatbufferObject
	{
		// Token: 0x1700D090 RID: 53392
		// (get) Token: 0x060313AB RID: 201643 RVA: 0x006ABAA1 File Offset: 0x006A9CA1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313AC RID: 201644 RVA: 0x006ABAAE File Offset: 0x006A9CAE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313AD RID: 201645 RVA: 0x006ABAB8 File Offset: 0x006A9CB8
		public static IGameplayPose3Interact GetRootAsIGameplayPose3Interact(ByteBuffer _bb)
		{
			return IGameplayPose3Interact.GetRootAsIGameplayPose3Interact(_bb, default(IGameplayPose3Interact));
		}

		// Token: 0x060313AE RID: 201646 RVA: 0x006ABAD4 File Offset: 0x006A9CD4
		public static IGameplayPose3Interact GetRootAsIGameplayPose3Interact(ByteBuffer _bb, IGameplayPose3Interact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313AF RID: 201647 RVA: 0x006ABAF1 File Offset: 0x006A9CF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313B0 RID: 201648 RVA: 0x006ABB00 File Offset: 0x006A9D00
		public IGameplayPose3Interact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D091 RID: 53393
		// (get) Token: 0x060313B1 RID: 201649 RVA: 0x006ABB10 File Offset: 0x006A9D10
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060313B2 RID: 201650 RVA: 0x006ABB4C File Offset: 0x006A9D4C
		public static Offset<IGameplayPose3Interact> CreateIGameplayPose3Interact(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGameplayPose3Interact.AddType(builder, Type);
			return IGameplayPose3Interact.EndIGameplayPose3Interact(builder);
		}

		// Token: 0x060313B3 RID: 201651 RVA: 0x006ABB62 File Offset: 0x006A9D62
		public static void StartIGameplayPose3Interact(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060313B4 RID: 201652 RVA: 0x006ABB6B File Offset: 0x006A9D6B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060313B5 RID: 201653 RVA: 0x006ABB76 File Offset: 0x006A9D76
		public static Offset<IGameplayPose3Interact> EndIGameplayPose3Interact(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayPose3Interact>(builder.EndTable());
		}

		// Token: 0x060313B6 RID: 201654 RVA: 0x006ABB84 File Offset: 0x006A9D84
		public IGameplayPose3InteractT UnPack()
		{
			IGameplayPose3InteractT gameplayPose3InteractT = new IGameplayPose3InteractT();
			this.UnPackTo(gameplayPose3InteractT);
			return gameplayPose3InteractT;
		}

		// Token: 0x060313B7 RID: 201655 RVA: 0x006ABB9F File Offset: 0x006A9D9F
		public void UnPackTo(IGameplayPose3InteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060313B8 RID: 201656 RVA: 0x006ABBB0 File Offset: 0x006A9DB0
		public static Offset<IGameplayPose3Interact> Pack(FlatBufferBuilder builder, IGameplayPose3InteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayPose3Interact>);
			}
			return IGameplayPose3Interact.CreateIGameplayPose3Interact(builder, _o.Type);
		}

		// Token: 0x04011E29 RID: 73257
		private Table __p;
	}
}
