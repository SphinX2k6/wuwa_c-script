using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1A RID: 28442
	public struct IGameplayPose1Interact : IFlatbufferObject
	{
		// Token: 0x1700D08A RID: 53386
		// (get) Token: 0x06031387 RID: 201607 RVA: 0x006AB7B4 File Offset: 0x006A99B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031388 RID: 201608 RVA: 0x006AB7C1 File Offset: 0x006A99C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031389 RID: 201609 RVA: 0x006AB7C8 File Offset: 0x006A99C8
		public static IGameplayPose1Interact GetRootAsIGameplayPose1Interact(ByteBuffer _bb)
		{
			return IGameplayPose1Interact.GetRootAsIGameplayPose1Interact(_bb, default(IGameplayPose1Interact));
		}

		// Token: 0x0603138A RID: 201610 RVA: 0x006AB7E4 File Offset: 0x006A99E4
		public static IGameplayPose1Interact GetRootAsIGameplayPose1Interact(ByteBuffer _bb, IGameplayPose1Interact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603138B RID: 201611 RVA: 0x006AB801 File Offset: 0x006A9A01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603138C RID: 201612 RVA: 0x006AB810 File Offset: 0x006A9A10
		public IGameplayPose1Interact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D08B RID: 53387
		// (get) Token: 0x0603138D RID: 201613 RVA: 0x006AB820 File Offset: 0x006A9A20
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

		// Token: 0x0603138E RID: 201614 RVA: 0x006AB85C File Offset: 0x006A9A5C
		public static Offset<IGameplayPose1Interact> CreateIGameplayPose1Interact(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGameplayPose1Interact.AddType(builder, Type);
			return IGameplayPose1Interact.EndIGameplayPose1Interact(builder);
		}

		// Token: 0x0603138F RID: 201615 RVA: 0x006AB872 File Offset: 0x006A9A72
		public static void StartIGameplayPose1Interact(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031390 RID: 201616 RVA: 0x006AB87B File Offset: 0x006A9A7B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031391 RID: 201617 RVA: 0x006AB886 File Offset: 0x006A9A86
		public static Offset<IGameplayPose1Interact> EndIGameplayPose1Interact(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayPose1Interact>(builder.EndTable());
		}

		// Token: 0x06031392 RID: 201618 RVA: 0x006AB894 File Offset: 0x006A9A94
		public IGameplayPose1InteractT UnPack()
		{
			IGameplayPose1InteractT gameplayPose1InteractT = new IGameplayPose1InteractT();
			this.UnPackTo(gameplayPose1InteractT);
			return gameplayPose1InteractT;
		}

		// Token: 0x06031393 RID: 201619 RVA: 0x006AB8AF File Offset: 0x006A9AAF
		public void UnPackTo(IGameplayPose1InteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06031394 RID: 201620 RVA: 0x006AB8C0 File Offset: 0x006A9AC0
		public static Offset<IGameplayPose1Interact> Pack(FlatBufferBuilder builder, IGameplayPose1InteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayPose1Interact>);
			}
			return IGameplayPose1Interact.CreateIGameplayPose1Interact(builder, _o.Type);
		}

		// Token: 0x04011E25 RID: 73253
		private Table __p;
	}
}
