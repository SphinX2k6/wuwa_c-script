using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CF4 RID: 19700
	public struct IP4ClientInfo : IFlatbufferObject
	{
		// Token: 0x17008D00 RID: 36096
		// (get) Token: 0x0601E7A3 RID: 124835 RVA: 0x00444D6C File Offset: 0x00442F6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E7A4 RID: 124836 RVA: 0x00444D79 File Offset: 0x00442F79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E7A5 RID: 124837 RVA: 0x00444D80 File Offset: 0x00442F80
		public static IP4ClientInfo GetRootAsIP4ClientInfo(ByteBuffer _bb)
		{
			return IP4ClientInfo.GetRootAsIP4ClientInfo(_bb, default(IP4ClientInfo));
		}

		// Token: 0x0601E7A6 RID: 124838 RVA: 0x00444D9C File Offset: 0x00442F9C
		public static IP4ClientInfo GetRootAsIP4ClientInfo(ByteBuffer _bb, IP4ClientInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E7A7 RID: 124839 RVA: 0x00444DB9 File Offset: 0x00442FB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E7A8 RID: 124840 RVA: 0x00444DC8 File Offset: 0x00442FC8
		public IP4ClientInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008D01 RID: 36097
		// (get) Token: 0x0601E7A9 RID: 124841 RVA: 0x00444DD8 File Offset: 0x00442FD8
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

		// Token: 0x0601E7AA RID: 124842 RVA: 0x00444E0F File Offset: 0x0044300F
		public Span<byte> GetClientBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E7AB RID: 124843 RVA: 0x00444E1E File Offset: 0x0044301E
		public byte[] GetClientArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008D02 RID: 36098
		// (get) Token: 0x0601E7AC RID: 124844 RVA: 0x00444E2C File Offset: 0x0044302C
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

		// Token: 0x0601E7AD RID: 124845 RVA: 0x00444E63 File Offset: 0x00443063
		public Span<byte> GetOwnerBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601E7AE RID: 124846 RVA: 0x00444E72 File Offset: 0x00443072
		public byte[] GetOwnerArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17008D03 RID: 36099
		// (get) Token: 0x0601E7AF RID: 124847 RVA: 0x00444E80 File Offset: 0x00443080
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

		// Token: 0x0601E7B0 RID: 124848 RVA: 0x00444EB7 File Offset: 0x004430B7
		public Span<byte> GetRootBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601E7B1 RID: 124849 RVA: 0x00444EC6 File Offset: 0x004430C6
		public byte[] GetRootArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008D04 RID: 36100
		// (get) Token: 0x0601E7B2 RID: 124850 RVA: 0x00444ED4 File Offset: 0x004430D4
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

		// Token: 0x0601E7B3 RID: 124851 RVA: 0x00444F0C File Offset: 0x0044310C
		public Span<byte> GetStreamBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601E7B4 RID: 124852 RVA: 0x00444F1C File Offset: 0x0044311C
		public byte[] GetStreamArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601E7B5 RID: 124853 RVA: 0x00444F2B File Offset: 0x0044312B
		public static Offset<IP4ClientInfo> CreateIP4ClientInfo(FlatBufferBuilder builder, StringOffset ClientOffset = default(StringOffset), StringOffset OwnerOffset = default(StringOffset), StringOffset RootOffset = default(StringOffset), StringOffset StreamOffset = default(StringOffset))
		{
			builder.StartTable(4);
			IP4ClientInfo.AddStream(builder, StreamOffset);
			IP4ClientInfo.AddRoot(builder, RootOffset);
			IP4ClientInfo.AddOwner(builder, OwnerOffset);
			IP4ClientInfo.AddClient(builder, ClientOffset);
			return IP4ClientInfo.EndIP4ClientInfo(builder);
		}

		// Token: 0x0601E7B6 RID: 124854 RVA: 0x00444F57 File Offset: 0x00443157
		public static void StartIP4ClientInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E7B7 RID: 124855 RVA: 0x00444F60 File Offset: 0x00443160
		public static void AddClient(FlatBufferBuilder builder, StringOffset clientOffset)
		{
			builder.AddOffset(0, clientOffset.Value, 0);
		}

		// Token: 0x0601E7B8 RID: 124856 RVA: 0x00444F70 File Offset: 0x00443170
		public static void AddOwner(FlatBufferBuilder builder, StringOffset ownerOffset)
		{
			builder.AddOffset(1, ownerOffset.Value, 0);
		}

		// Token: 0x0601E7B9 RID: 124857 RVA: 0x00444F80 File Offset: 0x00443180
		public static void AddRoot(FlatBufferBuilder builder, StringOffset rootOffset)
		{
			builder.AddOffset(2, rootOffset.Value, 0);
		}

		// Token: 0x0601E7BA RID: 124858 RVA: 0x00444F90 File Offset: 0x00443190
		public static void AddStream(FlatBufferBuilder builder, StringOffset streamOffset)
		{
			builder.AddOffset(3, streamOffset.Value, 0);
		}

		// Token: 0x0601E7BB RID: 124859 RVA: 0x00444FA0 File Offset: 0x004431A0
		public static Offset<IP4ClientInfo> EndIP4ClientInfo(FlatBufferBuilder builder)
		{
			return new Offset<IP4ClientInfo>(builder.EndTable());
		}

		// Token: 0x0601E7BC RID: 124860 RVA: 0x00444FB0 File Offset: 0x004431B0
		public IP4ClientInfoT UnPack()
		{
			IP4ClientInfoT ip4ClientInfoT = new IP4ClientInfoT();
			this.UnPackTo(ip4ClientInfoT);
			return ip4ClientInfoT;
		}

		// Token: 0x0601E7BD RID: 124861 RVA: 0x00444FCB File Offset: 0x004431CB
		public void UnPackTo(IP4ClientInfoT _o)
		{
			_o.Client = this.Client;
			_o.Owner = this.Owner;
			_o.Root = this.Root;
			_o.Stream = this.Stream;
		}

		// Token: 0x0601E7BE RID: 124862 RVA: 0x00445000 File Offset: 0x00443200
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

		// Token: 0x0400D8B0 RID: 55472
		private Table __p;
	}
}
