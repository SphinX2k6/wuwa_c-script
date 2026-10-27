using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687C RID: 26748
	public struct IGameplayPose2Interact : IFlatbufferObject
	{
		// Token: 0x1700C6A7 RID: 50855
		// (get) Token: 0x0602EA5F RID: 191071 RVA: 0x0065C8A9 File Offset: 0x0065AAA9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA60 RID: 191072 RVA: 0x0065C8B6 File Offset: 0x0065AAB6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA61 RID: 191073 RVA: 0x0065C8C0 File Offset: 0x0065AAC0
		public static IGameplayPose2Interact GetRootAsIGameplayPose2Interact(ByteBuffer _bb)
		{
			return IGameplayPose2Interact.GetRootAsIGameplayPose2Interact(_bb, default(IGameplayPose2Interact));
		}

		// Token: 0x0602EA62 RID: 191074 RVA: 0x0065C8DC File Offset: 0x0065AADC
		public static IGameplayPose2Interact GetRootAsIGameplayPose2Interact(ByteBuffer _bb, IGameplayPose2Interact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA63 RID: 191075 RVA: 0x0065C8F9 File Offset: 0x0065AAF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA64 RID: 191076 RVA: 0x0065C908 File Offset: 0x0065AB08
		public IGameplayPose2Interact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6A8 RID: 50856
		// (get) Token: 0x0602EA65 RID: 191077 RVA: 0x0065C918 File Offset: 0x0065AB18
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

		// Token: 0x0602EA66 RID: 191078 RVA: 0x0065C954 File Offset: 0x0065AB54
		public static Offset<IGameplayPose2Interact> CreateIGameplayPose2Interact(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGameplayPose2Interact.AddType(builder, Type);
			return IGameplayPose2Interact.EndIGameplayPose2Interact(builder);
		}

		// Token: 0x0602EA67 RID: 191079 RVA: 0x0065C96A File Offset: 0x0065AB6A
		public static void StartIGameplayPose2Interact(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EA68 RID: 191080 RVA: 0x0065C973 File Offset: 0x0065AB73
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EA69 RID: 191081 RVA: 0x0065C97E File Offset: 0x0065AB7E
		public static Offset<IGameplayPose2Interact> EndIGameplayPose2Interact(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayPose2Interact>(builder.EndTable());
		}

		// Token: 0x0602EA6A RID: 191082 RVA: 0x0065C98C File Offset: 0x0065AB8C
		public IGameplayPose2InteractT UnPack()
		{
			IGameplayPose2InteractT gameplayPose2InteractT = new IGameplayPose2InteractT();
			this.UnPackTo(gameplayPose2InteractT);
			return gameplayPose2InteractT;
		}

		// Token: 0x0602EA6B RID: 191083 RVA: 0x0065C9A7 File Offset: 0x0065ABA7
		public void UnPackTo(IGameplayPose2InteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EA6C RID: 191084 RVA: 0x0065C9B8 File Offset: 0x0065ABB8
		public static Offset<IGameplayPose2Interact> Pack(FlatBufferBuilder builder, IGameplayPose2InteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayPose2Interact>);
			}
			return IGameplayPose2Interact.CreateIGameplayPose2Interact(builder, _o.Type);
		}

		// Token: 0x04010FD2 RID: 69586
		private Table __p;
	}
}
