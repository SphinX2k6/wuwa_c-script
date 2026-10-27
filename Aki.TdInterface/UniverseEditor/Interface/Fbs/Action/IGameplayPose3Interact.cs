using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687F RID: 26751
	public struct IGameplayPose3Interact : IFlatbufferObject
	{
		// Token: 0x1700C6AA RID: 50858
		// (get) Token: 0x0602EA71 RID: 191089 RVA: 0x0065CA21 File Offset: 0x0065AC21
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA72 RID: 191090 RVA: 0x0065CA2E File Offset: 0x0065AC2E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA73 RID: 191091 RVA: 0x0065CA38 File Offset: 0x0065AC38
		public static IGameplayPose3Interact GetRootAsIGameplayPose3Interact(ByteBuffer _bb)
		{
			return IGameplayPose3Interact.GetRootAsIGameplayPose3Interact(_bb, default(IGameplayPose3Interact));
		}

		// Token: 0x0602EA74 RID: 191092 RVA: 0x0065CA54 File Offset: 0x0065AC54
		public static IGameplayPose3Interact GetRootAsIGameplayPose3Interact(ByteBuffer _bb, IGameplayPose3Interact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA75 RID: 191093 RVA: 0x0065CA71 File Offset: 0x0065AC71
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA76 RID: 191094 RVA: 0x0065CA80 File Offset: 0x0065AC80
		public IGameplayPose3Interact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6AB RID: 50859
		// (get) Token: 0x0602EA77 RID: 191095 RVA: 0x0065CA90 File Offset: 0x0065AC90
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

		// Token: 0x0602EA78 RID: 191096 RVA: 0x0065CACC File Offset: 0x0065ACCC
		public static Offset<IGameplayPose3Interact> CreateIGameplayPose3Interact(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGameplayPose3Interact.AddType(builder, Type);
			return IGameplayPose3Interact.EndIGameplayPose3Interact(builder);
		}

		// Token: 0x0602EA79 RID: 191097 RVA: 0x0065CAE2 File Offset: 0x0065ACE2
		public static void StartIGameplayPose3Interact(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EA7A RID: 191098 RVA: 0x0065CAEB File Offset: 0x0065ACEB
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EA7B RID: 191099 RVA: 0x0065CAF6 File Offset: 0x0065ACF6
		public static Offset<IGameplayPose3Interact> EndIGameplayPose3Interact(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayPose3Interact>(builder.EndTable());
		}

		// Token: 0x0602EA7C RID: 191100 RVA: 0x0065CB04 File Offset: 0x0065AD04
		public IGameplayPose3InteractT UnPack()
		{
			IGameplayPose3InteractT gameplayPose3InteractT = new IGameplayPose3InteractT();
			this.UnPackTo(gameplayPose3InteractT);
			return gameplayPose3InteractT;
		}

		// Token: 0x0602EA7D RID: 191101 RVA: 0x0065CB1F File Offset: 0x0065AD1F
		public void UnPackTo(IGameplayPose3InteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EA7E RID: 191102 RVA: 0x0065CB30 File Offset: 0x0065AD30
		public static Offset<IGameplayPose3Interact> Pack(FlatBufferBuilder builder, IGameplayPose3InteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayPose3Interact>);
			}
			return IGameplayPose3Interact.CreateIGameplayPose3Interact(builder, _o.Type);
		}

		// Token: 0x04010FD4 RID: 69588
		private Table __p;
	}
}
