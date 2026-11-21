using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007088 RID: 28808
	public struct IKiteHookInteract : IFlatbufferObject
	{
		// Token: 0x1700D310 RID: 54032
		// (get) Token: 0x06031F9D RID: 204701 RVA: 0x006C3785 File Offset: 0x006C1985
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031F9E RID: 204702 RVA: 0x006C3792 File Offset: 0x006C1992
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031F9F RID: 204703 RVA: 0x006C379C File Offset: 0x006C199C
		public static IKiteHookInteract GetRootAsIKiteHookInteract(ByteBuffer _bb)
		{
			return IKiteHookInteract.GetRootAsIKiteHookInteract(_bb, default(IKiteHookInteract));
		}

		// Token: 0x06031FA0 RID: 204704 RVA: 0x006C37B8 File Offset: 0x006C19B8
		public static IKiteHookInteract GetRootAsIKiteHookInteract(ByteBuffer _bb, IKiteHookInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031FA1 RID: 204705 RVA: 0x006C37D5 File Offset: 0x006C19D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031FA2 RID: 204706 RVA: 0x006C37E4 File Offset: 0x006C19E4
		public IKiteHookInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D311 RID: 54033
		// (get) Token: 0x06031FA3 RID: 204707 RVA: 0x006C37F4 File Offset: 0x006C19F4
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

		// Token: 0x1700D312 RID: 54034
		// (get) Token: 0x06031FA4 RID: 204708 RVA: 0x006C3830 File Offset: 0x006C1A30
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031FA5 RID: 204709 RVA: 0x006C386C File Offset: 0x006C1A6C
		public static Offset<IKiteHookInteract> CreateIKiteHookInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill, int EntityId = 0)
		{
			builder.StartTable(2);
			IKiteHookInteract.AddEntityId(builder, EntityId);
			IKiteHookInteract.AddType(builder, Type);
			return IKiteHookInteract.EndIKiteHookInteract(builder);
		}

		// Token: 0x06031FA6 RID: 204710 RVA: 0x006C3889 File Offset: 0x006C1A89
		public static void StartIKiteHookInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031FA7 RID: 204711 RVA: 0x006C3892 File Offset: 0x006C1A92
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06031FA8 RID: 204712 RVA: 0x006C389D File Offset: 0x006C1A9D
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06031FA9 RID: 204713 RVA: 0x006C38A8 File Offset: 0x006C1AA8
		public static Offset<IKiteHookInteract> EndIKiteHookInteract(FlatBufferBuilder builder)
		{
			return new Offset<IKiteHookInteract>(builder.EndTable());
		}

		// Token: 0x06031FAA RID: 204714 RVA: 0x006C38B8 File Offset: 0x006C1AB8
		public IKiteHookInteractT UnPack()
		{
			IKiteHookInteractT kiteHookInteractT = new IKiteHookInteractT();
			this.UnPackTo(kiteHookInteractT);
			return kiteHookInteractT;
		}

		// Token: 0x06031FAB RID: 204715 RVA: 0x006C38D3 File Offset: 0x006C1AD3
		public void UnPackTo(IKiteHookInteractT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
		}

		// Token: 0x06031FAC RID: 204716 RVA: 0x006C38F0 File Offset: 0x006C1AF0
		public static Offset<IKiteHookInteract> Pack(FlatBufferBuilder builder, IKiteHookInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IKiteHookInteract>);
			}
			return IKiteHookInteract.CreateIKiteHookInteract(builder, _o.Type, _o.EntityId);
		}

		// Token: 0x04012001 RID: 73729
		private Table __p;
	}
}
