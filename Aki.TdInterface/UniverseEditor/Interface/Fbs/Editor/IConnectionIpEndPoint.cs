using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CA9 RID: 19625
	public struct IConnectionIpEndPoint : IFlatbufferObject
	{
		// Token: 0x17008B0C RID: 35596
		// (get) Token: 0x0601E194 RID: 123284 RVA: 0x00437906 File Offset: 0x00435B06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E195 RID: 123285 RVA: 0x00437913 File Offset: 0x00435B13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E196 RID: 123286 RVA: 0x0043791C File Offset: 0x00435B1C
		public static IConnectionIpEndPoint GetRootAsIConnectionIpEndPoint(ByteBuffer _bb)
		{
			return IConnectionIpEndPoint.GetRootAsIConnectionIpEndPoint(_bb, default(IConnectionIpEndPoint));
		}

		// Token: 0x0601E197 RID: 123287 RVA: 0x00437938 File Offset: 0x00435B38
		public static IConnectionIpEndPoint GetRootAsIConnectionIpEndPoint(ByteBuffer _bb, IConnectionIpEndPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E198 RID: 123288 RVA: 0x00437955 File Offset: 0x00435B55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E199 RID: 123289 RVA: 0x00437964 File Offset: 0x00435B64
		public IConnectionIpEndPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B0D RID: 35597
		// (get) Token: 0x0601E19A RID: 123290 RVA: 0x00437974 File Offset: 0x00435B74
		public string Address
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

		// Token: 0x0601E19B RID: 123291 RVA: 0x004379AB File Offset: 0x00435BAB
		public Span<byte> GetAddressBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601E19C RID: 123292 RVA: 0x004379BA File Offset: 0x00435BBA
		public byte[] GetAddressArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x17008B0E RID: 35598
		// (get) Token: 0x0601E19D RID: 123293 RVA: 0x004379C8 File Offset: 0x00435BC8
		public int Port
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

		// Token: 0x0601E19E RID: 123294 RVA: 0x00437A04 File Offset: 0x00435C04
		public static Offset<IConnectionIpEndPoint> CreateIConnectionIpEndPoint(FlatBufferBuilder builder, StringOffset AddressOffset = default(StringOffset), int Port = 0)
		{
			builder.StartTable(2);
			IConnectionIpEndPoint.AddPort(builder, Port);
			IConnectionIpEndPoint.AddAddress(builder, AddressOffset);
			return IConnectionIpEndPoint.EndIConnectionIpEndPoint(builder);
		}

		// Token: 0x0601E19F RID: 123295 RVA: 0x00437A21 File Offset: 0x00435C21
		public static void StartIConnectionIpEndPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E1A0 RID: 123296 RVA: 0x00437A2A File Offset: 0x00435C2A
		public static void AddAddress(FlatBufferBuilder builder, StringOffset addressOffset)
		{
			builder.AddOffset(0, addressOffset.Value, 0);
		}

		// Token: 0x0601E1A1 RID: 123297 RVA: 0x00437A3A File Offset: 0x00435C3A
		public static void AddPort(FlatBufferBuilder builder, int port)
		{
			builder.AddInt(1, port, 0);
		}

		// Token: 0x0601E1A2 RID: 123298 RVA: 0x00437A45 File Offset: 0x00435C45
		public static Offset<IConnectionIpEndPoint> EndIConnectionIpEndPoint(FlatBufferBuilder builder)
		{
			return new Offset<IConnectionIpEndPoint>(builder.EndTable());
		}

		// Token: 0x0601E1A3 RID: 123299 RVA: 0x00437A54 File Offset: 0x00435C54
		public IConnectionIpEndPointT UnPack()
		{
			IConnectionIpEndPointT connectionIpEndPointT = new IConnectionIpEndPointT();
			this.UnPackTo(connectionIpEndPointT);
			return connectionIpEndPointT;
		}

		// Token: 0x0601E1A4 RID: 123300 RVA: 0x00437A6F File Offset: 0x00435C6F
		public void UnPackTo(IConnectionIpEndPointT _o)
		{
			_o.Address = this.Address;
			_o.Port = this.Port;
		}

		// Token: 0x0601E1A5 RID: 123301 RVA: 0x00437A8C File Offset: 0x00435C8C
		public static Offset<IConnectionIpEndPoint> Pack(FlatBufferBuilder builder, IConnectionIpEndPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectionIpEndPoint>);
			}
			StringOffset addressOffset = (_o.Address == null) ? default(StringOffset) : builder.CreateString(_o.Address);
			return IConnectionIpEndPoint.CreateIConnectionIpEndPoint(builder, addressOffset, _o.Port);
		}

		// Token: 0x0400D7AB RID: 55211
		private Table __p;
	}
}
