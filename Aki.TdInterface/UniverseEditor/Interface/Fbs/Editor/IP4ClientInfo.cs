using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200488F RID: 18575
	public struct IP4ClientInfo : IFlatbufferObject
	{
		// Token: 0x170086B8 RID: 34488
		// (get) Token: 0x0601CFB6 RID: 118710 RVA: 0x004185D0 File Offset: 0x004167D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CFB7 RID: 118711 RVA: 0x004185DD File Offset: 0x004167DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CFB8 RID: 118712 RVA: 0x004185E4 File Offset: 0x004167E4
		public static IP4ClientInfo GetRootAsIP4ClientInfo(ByteBuffer _bb)
		{
			return IP4ClientInfo.GetRootAsIP4ClientInfo(_bb, default(IP4ClientInfo));
		}

		// Token: 0x0601CFB9 RID: 118713 RVA: 0x00418600 File Offset: 0x00416800
		public static IP4ClientInfo GetRootAsIP4ClientInfo(ByteBuffer _bb, IP4ClientInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CFBA RID: 118714 RVA: 0x0041861D File Offset: 0x0041681D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CFBB RID: 118715 RVA: 0x0041862C File Offset: 0x0041682C
		public IP4ClientInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170086B9 RID: 34489
		// (get) Token: 0x0601CFBC RID: 118716 RVA: 0x0041863C File Offset: 0x0041683C
		public string Client
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CFBD RID: 118717 RVA: 0x00418673 File Offset: 0x00416873
		public Span<byte> GetClientBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601CFBE RID: 118718 RVA: 0x00418682 File Offset: 0x00416882
		public byte[] GetClientArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170086BA RID: 34490
		// (get) Token: 0x0601CFBF RID: 118719 RVA: 0x00418690 File Offset: 0x00416890
		public string Owner
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

		// Token: 0x0601CFC0 RID: 118720 RVA: 0x004186C7 File Offset: 0x004168C7
		public Span<byte> GetOwnerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601CFC1 RID: 118721 RVA: 0x004186D6 File Offset: 0x004168D6
		public byte[] GetOwnerArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170086BB RID: 34491
		// (get) Token: 0x0601CFC2 RID: 118722 RVA: 0x004186E4 File Offset: 0x004168E4
		public string Root
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CFC3 RID: 118723 RVA: 0x0041871B File Offset: 0x0041691B
		public Span<byte> GetRootBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601CFC4 RID: 118724 RVA: 0x0041872A File Offset: 0x0041692A
		public byte[] GetRootArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170086BC RID: 34492
		// (get) Token: 0x0601CFC5 RID: 118725 RVA: 0x00418738 File Offset: 0x00416938
		public string Stream
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601CFC6 RID: 118726 RVA: 0x00418770 File Offset: 0x00416970
		public Span<byte> GetStreamBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601CFC7 RID: 118727 RVA: 0x00418780 File Offset: 0x00416980
		public byte[] GetStreamArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601CFC8 RID: 118728 RVA: 0x0041878F File Offset: 0x0041698F
		public static Offset<IP4ClientInfo> CreateIP4ClientInfo(FlatBufferBuilder builder, StringOffset ClientOffset = default(StringOffset), StringOffset OwnerOffset = default(StringOffset), StringOffset RootOffset = default(StringOffset), StringOffset StreamOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IP4ClientInfo.AddStream(builder, StreamOffset);
			IP4ClientInfo.AddRoot(builder, RootOffset);
			IP4ClientInfo.AddOwner(builder, OwnerOffset);
			IP4ClientInfo.AddClient(builder, ClientOffset);
			return IP4ClientInfo.EndIP4ClientInfo(builder);
		}

		// Token: 0x0601CFC9 RID: 118729 RVA: 0x004187BB File Offset: 0x004169BB
		public static void StartIP4ClientInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601CFCA RID: 118730 RVA: 0x004187C4 File Offset: 0x004169C4
		public static void AddClient(FlatBufferBuilder builder, StringOffset clientOffset)
		{
			builder.AddOffset(0, clientOffset.Value, 0);
		}

		// Token: 0x0601CFCB RID: 118731 RVA: 0x004187D4 File Offset: 0x004169D4
		public static void AddOwner(FlatBufferBuilder builder, StringOffset ownerOffset)
		{
			builder.AddOffset(1, ownerOffset.Value, 0);
		}

		// Token: 0x0601CFCC RID: 118732 RVA: 0x004187E4 File Offset: 0x004169E4
		public static void AddRoot(FlatBufferBuilder builder, StringOffset rootOffset)
		{
			builder.AddOffset(2, rootOffset.Value, 0);
		}

		// Token: 0x0601CFCD RID: 118733 RVA: 0x004187F4 File Offset: 0x004169F4
		public static void AddStream(FlatBufferBuilder builder, StringOffset streamOffset)
		{
			builder.AddOffset(3, streamOffset.Value, 0);
		}

		// Token: 0x0601CFCE RID: 118734 RVA: 0x00418804 File Offset: 0x00416A04
		public static Offset<IP4ClientInfo> EndIP4ClientInfo(FlatBufferBuilder builder)
		{
			return new Offset<IP4ClientInfo>(builder.EndTable());
		}

		// Token: 0x0601CFCF RID: 118735 RVA: 0x00418814 File Offset: 0x00416A14
		public IP4ClientInfoT UnPack()
		{
			IP4ClientInfoT ip4ClientInfoT = new IP4ClientInfoT();
			this.UnPackTo(ip4ClientInfoT);
			return ip4ClientInfoT;
		}

		// Token: 0x0601CFD0 RID: 118736 RVA: 0x0041882F File Offset: 0x00416A2F
		public void UnPackTo(IP4ClientInfoT _o)
		{
			_o.Client = this.Client;
			_o.Owner = this.Owner;
			_o.Root = this.Root;
			_o.Stream = this.Stream;
		}

		// Token: 0x0601CFD1 RID: 118737 RVA: 0x00418864 File Offset: 0x00416A64
		public static Offset<IP4ClientInfo> Pack(FlatBufferBuilder builder, IP4ClientInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IP4ClientInfo>);
			}
			StringOffset clientOffset = (_o.Client == null) ? default(StringOffset) : builder.CreateString(_o.Client);
			StringOffset ownerOffset = (_o.Owner == null) ? default(StringOffset) : builder.CreateString(_o.Owner);
			StringOffset rootOffset = (_o.Root == null) ? default(StringOffset) : builder.CreateString(_o.Root);
			StringOffset streamOffset = (_o.Stream == null) ? default(StringOffset) : builder.CreateString(_o.Stream);
			return IP4ClientInfo.CreateIP4ClientInfo(builder, clientOffset, ownerOffset, rootOffset, streamOffset);
		}

		// Token: 0x0400CE77 RID: 52855
		private Table __p;
	}
}
