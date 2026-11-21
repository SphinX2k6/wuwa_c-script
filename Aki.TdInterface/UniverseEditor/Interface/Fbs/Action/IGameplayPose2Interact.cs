using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1D RID: 28445
	public struct IGameplayPose2Interact : IFlatbufferObject
	{
		// Token: 0x1700D08D RID: 53389
		// (get) Token: 0x06031399 RID: 201625 RVA: 0x006AB929 File Offset: 0x006A9B29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603139A RID: 201626 RVA: 0x006AB936 File Offset: 0x006A9B36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603139B RID: 201627 RVA: 0x006AB940 File Offset: 0x006A9B40
		public static IGameplayPose2Interact GetRootAsIGameplayPose2Interact(ByteBuffer _bb)
		{
			return IGameplayPose2Interact.GetRootAsIGameplayPose2Interact(_bb, default(IGameplayPose2Interact));
		}

		// Token: 0x0603139C RID: 201628 RVA: 0x006AB95C File Offset: 0x006A9B5C
		public static IGameplayPose2Interact GetRootAsIGameplayPose2Interact(ByteBuffer _bb, IGameplayPose2Interact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603139D RID: 201629 RVA: 0x006AB979 File Offset: 0x006A9B79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603139E RID: 201630 RVA: 0x006AB988 File Offset: 0x006A9B88
		public IGameplayPose2Interact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D08E RID: 53390
		// (get) Token: 0x0603139F RID: 201631 RVA: 0x006AB998 File Offset: 0x006A9B98
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

		// Token: 0x060313A0 RID: 201632 RVA: 0x006AB9D4 File Offset: 0x006A9BD4
		public static Offset<IGameplayPose2Interact> CreateIGameplayPose2Interact(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGameplayPose2Interact.AddType(builder, Type);
			return IGameplayPose2Interact.EndIGameplayPose2Interact(builder);
		}

		// Token: 0x060313A1 RID: 201633 RVA: 0x006AB9EA File Offset: 0x006A9BEA
		public static void StartIGameplayPose2Interact(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060313A2 RID: 201634 RVA: 0x006AB9F3 File Offset: 0x006A9BF3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060313A3 RID: 201635 RVA: 0x006AB9FE File Offset: 0x006A9BFE
		public static Offset<IGameplayPose2Interact> EndIGameplayPose2Interact(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayPose2Interact>(builder.EndTable());
		}

		// Token: 0x060313A4 RID: 201636 RVA: 0x006ABA0C File Offset: 0x006A9C0C
		public IGameplayPose2InteractT UnPack()
		{
			IGameplayPose2InteractT gameplayPose2InteractT = new IGameplayPose2InteractT();
			this.UnPackTo(gameplayPose2InteractT);
			return gameplayPose2InteractT;
		}

		// Token: 0x060313A5 RID: 201637 RVA: 0x006ABA27 File Offset: 0x006A9C27
		public void UnPackTo(IGameplayPose2InteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060313A6 RID: 201638 RVA: 0x006ABA38 File Offset: 0x006A9C38
		public static Offset<IGameplayPose2Interact> Pack(FlatBufferBuilder builder, IGameplayPose2InteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayPose2Interact>);
			}
			return IGameplayPose2Interact.CreateIGameplayPose2Interact(builder, _o.Type);
		}

		// Token: 0x04011E27 RID: 73255
		private Table __p;
	}
}
