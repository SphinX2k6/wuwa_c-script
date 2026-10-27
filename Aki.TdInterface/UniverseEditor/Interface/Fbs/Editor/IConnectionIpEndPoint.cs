using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004841 RID: 18497
	public struct IConnectionIpEndPoint : IFlatbufferObject
	{
		// Token: 0x170084C1 RID: 33985
		// (get) Token: 0x0601C997 RID: 117143 RVA: 0x0040AFB6 File Offset: 0x004091B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C998 RID: 117144 RVA: 0x0040AFC3 File Offset: 0x004091C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C999 RID: 117145 RVA: 0x0040AFCC File Offset: 0x004091CC
		public static IConnectionIpEndPoint GetRootAsIConnectionIpEndPoint(ByteBuffer _bb)
		{
			return IConnectionIpEndPoint.GetRootAsIConnectionIpEndPoint(_bb, default(IConnectionIpEndPoint));
		}

		// Token: 0x0601C99A RID: 117146 RVA: 0x0040AFE8 File Offset: 0x004091E8
		public static IConnectionIpEndPoint GetRootAsIConnectionIpEndPoint(ByteBuffer _bb, IConnectionIpEndPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C99B RID: 117147 RVA: 0x0040B005 File Offset: 0x00409205
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C99C RID: 117148 RVA: 0x0040B014 File Offset: 0x00409214
		public IConnectionIpEndPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170084C2 RID: 33986
		// (get) Token: 0x0601C99D RID: 117149 RVA: 0x0040B024 File Offset: 0x00409224
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

		// Token: 0x0601C99E RID: 117150 RVA: 0x0040B05B File Offset: 0x0040925B
		public Span<byte> GetAddressBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601C99F RID: 117151 RVA: 0x0040B06A File Offset: 0x0040926A
		public byte[] GetAddressArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x170084C3 RID: 33987
		// (get) Token: 0x0601C9A0 RID: 117152 RVA: 0x0040B078 File Offset: 0x00409278
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

		// Token: 0x0601C9A1 RID: 117153 RVA: 0x0040B0B4 File Offset: 0x004092B4
		public static Offset<IConnectionIpEndPoint> CreateIConnectionIpEndPoint(FlatBufferBuilder builder, StringOffset AddressOffset = default(StringOffset), int Port = 0)
		{
			builder.StartTable(2);
			IConnectionIpEndPoint.AddPort(builder, Port);
			IConnectionIpEndPoint.AddAddress(builder, AddressOffset);
			return IConnectionIpEndPoint.EndIConnectionIpEndPoint(builder);
		}

		// Token: 0x0601C9A2 RID: 117154 RVA: 0x0040B0D1 File Offset: 0x004092D1
		public static void StartIConnectionIpEndPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601C9A3 RID: 117155 RVA: 0x0040B0DA File Offset: 0x004092DA
		public static void AddAddress(FlatBufferBuilder builder, StringOffset addressOffset)
		{
			builder.AddOffset(0, addressOffset.Value, 0);
		}

		// Token: 0x0601C9A4 RID: 117156 RVA: 0x0040B0EA File Offset: 0x004092EA
		public static void AddPort(FlatBufferBuilder builder, int port)
		{
			builder.AddInt(1, port, 0);
		}

		// Token: 0x0601C9A5 RID: 117157 RVA: 0x0040B0F5 File Offset: 0x004092F5
		public static Offset<IConnectionIpEndPoint> EndIConnectionIpEndPoint(FlatBufferBuilder builder)
		{
			return new Offset<IConnectionIpEndPoint>(builder.EndTable());
		}

		// Token: 0x0601C9A6 RID: 117158 RVA: 0x0040B104 File Offset: 0x00409304
		public IConnectionIpEndPointT UnPack()
		{
			IConnectionIpEndPointT connectionIpEndPointT = new IConnectionIpEndPointT();
			this.UnPackTo(connectionIpEndPointT);
			return connectionIpEndPointT;
		}

		// Token: 0x0601C9A7 RID: 117159 RVA: 0x0040B11F File Offset: 0x0040931F
		public void UnPackTo(IConnectionIpEndPointT _o)
		{
			_o.Address = this.Address;
			_o.Port = this.Port;
		}

		// Token: 0x0601C9A8 RID: 117160 RVA: 0x0040B13C File Offset: 0x0040933C
		public static Offset<IConnectionIpEndPoint> Pack(FlatBufferBuilder builder, IConnectionIpEndPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectionIpEndPoint>);
			}
			StringOffset addressOffset = (_o.Address == null) ? default(StringOffset) : builder.CreateString(_o.Address);
			return IConnectionIpEndPoint.CreateIConnectionIpEndPoint(builder, addressOffset, _o.Port);
		}

		// Token: 0x0400CD70 RID: 52592
		private Table __p;
	}
}
