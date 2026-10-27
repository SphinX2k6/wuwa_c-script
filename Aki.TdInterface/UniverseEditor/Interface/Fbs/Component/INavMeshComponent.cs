using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E7 RID: 21991
	public struct INavMeshComponent : IFlatbufferObject
	{
		// Token: 0x1700A2BB RID: 41659
		// (get) Token: 0x060247B9 RID: 149433 RVA: 0x005093A6 File Offset: 0x005075A6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060247BA RID: 149434 RVA: 0x005093B3 File Offset: 0x005075B3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060247BB RID: 149435 RVA: 0x005093BC File Offset: 0x005075BC
		public static INavMeshComponent GetRootAsINavMeshComponent(ByteBuffer _bb)
		{
			return INavMeshComponent.GetRootAsINavMeshComponent(_bb, default(INavMeshComponent));
		}

		// Token: 0x060247BC RID: 149436 RVA: 0x005093D8 File Offset: 0x005075D8
		public static INavMeshComponent GetRootAsINavMeshComponent(ByteBuffer _bb, INavMeshComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060247BD RID: 149437 RVA: 0x005093F5 File Offset: 0x005075F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060247BE RID: 149438 RVA: 0x00509404 File Offset: 0x00507604
		public INavMeshComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A2BC RID: 41660
		// (get) Token: 0x060247BF RID: 149439 RVA: 0x00509414 File Offset: 0x00507614
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A2BD RID: 41661
		// (get) Token: 0x060247C0 RID: 149440 RVA: 0x00509454 File Offset: 0x00507654
		public INavMeshAkiEntitySource? Source
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new INavMeshAkiEntitySource?(default(INavMeshAkiEntitySource).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A2BE RID: 41662
		// (get) Token: 0x060247C1 RID: 149441 RVA: 0x005094B4 File Offset: 0x005076B4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060247C2 RID: 149442 RVA: 0x005094F0 File Offset: 0x005076F0
		public static Offset<INavMeshComponent> CreateINavMeshComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<INavMeshAkiEntitySource> SourceOffset = default(Offset<INavMeshAkiEntitySource>), byte NullMask = 0)
		{
			builder.StartTable(3);
			INavMeshComponent.AddSource(builder, SourceOffset);
			INavMeshComponent.AddNullMask(builder, NullMask);
			INavMeshComponent.AddDisabled(builder, Disabled);
			return INavMeshComponent.EndINavMeshComponent(builder);
		}

		// Token: 0x060247C3 RID: 149443 RVA: 0x00509514 File Offset: 0x00507714
		public static void StartINavMeshComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060247C4 RID: 149444 RVA: 0x0050951D File Offset: 0x0050771D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060247C5 RID: 149445 RVA: 0x00509528 File Offset: 0x00507728
		public static void AddSource(FlatBufferBuilder builder, Offset<INavMeshAkiEntitySource> sourceOffset)
		{
			builder.AddOffset(1, sourceOffset.Value, 0);
		}

		// Token: 0x060247C6 RID: 149446 RVA: 0x00509538 File Offset: 0x00507738
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060247C7 RID: 149447 RVA: 0x00509543 File Offset: 0x00507743
		public static Offset<INavMeshComponent> EndINavMeshComponent(FlatBufferBuilder builder)
		{
			return new Offset<INavMeshComponent>(builder.EndTable());
		}

		// Token: 0x060247C8 RID: 149448 RVA: 0x00509550 File Offset: 0x00507750
		public INavMeshComponentT UnPack()
		{
			INavMeshComponentT navMeshComponentT = new INavMeshComponentT();
			this.UnPackTo(navMeshComponentT);
			return navMeshComponentT;
		}

		// Token: 0x060247C9 RID: 149449 RVA: 0x0050956C File Offset: 0x0050776C
		public void UnPackTo(INavMeshComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Source = ((this.Source != null) ? this.Source.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060247CA RID: 149450 RVA: 0x005095C0 File Offset: 0x005077C0
		public static Offset<INavMeshComponent> Pack(FlatBufferBuilder builder, INavMeshComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<INavMeshComponent>);
			}
			Offset<INavMeshAkiEntitySource> sourceOffset = (_o.Source == null) ? default(Offset<INavMeshAkiEntitySource>) : INavMeshAkiEntitySource.Pack(builder, _o.Source);
			return INavMeshComponent.CreateINavMeshComponent(builder, _o.Disabled, sourceOffset, _o.NullMask);
		}

		// Token: 0x0400E951 RID: 59729
		private Table __p;
	}
}
