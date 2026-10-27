using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006879 RID: 26745
	public struct IGameplayPose1Interact : IFlatbufferObject
	{
		// Token: 0x1700C6A4 RID: 50852
		// (get) Token: 0x0602EA4D RID: 191053 RVA: 0x0065C734 File Offset: 0x0065A934
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA4E RID: 191054 RVA: 0x0065C741 File Offset: 0x0065A941
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA4F RID: 191055 RVA: 0x0065C748 File Offset: 0x0065A948
		public static IGameplayPose1Interact GetRootAsIGameplayPose1Interact(ByteBuffer _bb)
		{
			return IGameplayPose1Interact.GetRootAsIGameplayPose1Interact(_bb, default(IGameplayPose1Interact));
		}

		// Token: 0x0602EA50 RID: 191056 RVA: 0x0065C764 File Offset: 0x0065A964
		public static IGameplayPose1Interact GetRootAsIGameplayPose1Interact(ByteBuffer _bb, IGameplayPose1Interact obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA51 RID: 191057 RVA: 0x0065C781 File Offset: 0x0065A981
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA52 RID: 191058 RVA: 0x0065C790 File Offset: 0x0065A990
		public IGameplayPose1Interact __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6A5 RID: 50853
		// (get) Token: 0x0602EA53 RID: 191059 RVA: 0x0065C7A0 File Offset: 0x0065A9A0
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

		// Token: 0x0602EA54 RID: 191060 RVA: 0x0065C7DC File Offset: 0x0065A9DC
		public static Offset<IGameplayPose1Interact> CreateIGameplayPose1Interact(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGameplayPose1Interact.AddType(builder, Type);
			return IGameplayPose1Interact.EndIGameplayPose1Interact(builder);
		}

		// Token: 0x0602EA55 RID: 191061 RVA: 0x0065C7F2 File Offset: 0x0065A9F2
		public static void StartIGameplayPose1Interact(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EA56 RID: 191062 RVA: 0x0065C7FB File Offset: 0x0065A9FB
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EA57 RID: 191063 RVA: 0x0065C806 File Offset: 0x0065AA06
		public static Offset<IGameplayPose1Interact> EndIGameplayPose1Interact(FlatBufferBuilder builder)
		{
			return new Offset<IGameplayPose1Interact>(builder.EndTable());
		}

		// Token: 0x0602EA58 RID: 191064 RVA: 0x0065C814 File Offset: 0x0065AA14
		public IGameplayPose1InteractT UnPack()
		{
			IGameplayPose1InteractT gameplayPose1InteractT = new IGameplayPose1InteractT();
			this.UnPackTo(gameplayPose1InteractT);
			return gameplayPose1InteractT;
		}

		// Token: 0x0602EA59 RID: 191065 RVA: 0x0065C82F File Offset: 0x0065AA2F
		public void UnPackTo(IGameplayPose1InteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EA5A RID: 191066 RVA: 0x0065C840 File Offset: 0x0065AA40
		public static Offset<IGameplayPose1Interact> Pack(FlatBufferBuilder builder, IGameplayPose1InteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameplayPose1Interact>);
			}
			return IGameplayPose1Interact.CreateIGameplayPose1Interact(builder, _o.Type);
		}

		// Token: 0x04010FD0 RID: 69584
		private Table __p;
	}
}
