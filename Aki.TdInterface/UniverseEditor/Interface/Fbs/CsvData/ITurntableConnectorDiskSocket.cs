using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB8 RID: 19896
	public struct ITurntableConnectorDiskSocket : IFlatbufferObject
	{
		// Token: 0x17008E59 RID: 36441
		// (get) Token: 0x0601EDE7 RID: 126439 RVA: 0x00450486 File Offset: 0x0044E686
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EDE8 RID: 126440 RVA: 0x00450493 File Offset: 0x0044E693
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EDE9 RID: 126441 RVA: 0x0045049C File Offset: 0x0044E69C
		public static ITurntableConnectorDiskSocket GetRootAsITurntableConnectorDiskSocket(ByteBuffer _bb)
		{
			return ITurntableConnectorDiskSocket.GetRootAsITurntableConnectorDiskSocket(_bb, default(ITurntableConnectorDiskSocket));
		}

		// Token: 0x0601EDEA RID: 126442 RVA: 0x004504B8 File Offset: 0x0044E6B8
		public static ITurntableConnectorDiskSocket GetRootAsITurntableConnectorDiskSocket(ByteBuffer _bb, ITurntableConnectorDiskSocket obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EDEB RID: 126443 RVA: 0x004504D5 File Offset: 0x0044E6D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EDEC RID: 126444 RVA: 0x004504E4 File Offset: 0x0044E6E4
		public ITurntableConnectorDiskSocket __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E5A RID: 36442
		// (get) Token: 0x0601EDED RID: 126445 RVA: 0x004504F4 File Offset: 0x0044E6F4
		public ETurntableConnectorDisk Disk
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETurntableConnectorDisk.Disk0;
				}
				return (ETurntableConnectorDisk)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008E5B RID: 36443
		// (get) Token: 0x0601EDEE RID: 126446 RVA: 0x00450530 File Offset: 0x0044E730
		public string Socket
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

		// Token: 0x0601EDEF RID: 126447 RVA: 0x00450567 File Offset: 0x0044E767
		public Span<byte> GetSocketBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0601EDF0 RID: 126448 RVA: 0x00450576 File Offset: 0x0044E776
		public byte[] GetSocketArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0601EDF1 RID: 126449 RVA: 0x00450584 File Offset: 0x0044E784
		public static Offset<ITurntableConnectorDiskSocket> CreateITurntableConnectorDiskSocket(FlatBufferBuilder builder, ETurntableConnectorDisk Disk = ETurntableConnectorDisk.Disk0, StringOffset SocketOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ITurntableConnectorDiskSocket.AddSocket(builder, SocketOffset);
			ITurntableConnectorDiskSocket.AddDisk(builder, Disk);
			return ITurntableConnectorDiskSocket.EndITurntableConnectorDiskSocket(builder);
		}

		// Token: 0x0601EDF2 RID: 126450 RVA: 0x004505A1 File Offset: 0x0044E7A1
		public static void StartITurntableConnectorDiskSocket(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EDF3 RID: 126451 RVA: 0x004505AA File Offset: 0x0044E7AA
		public static void AddDisk(FlatBufferBuilder builder, ETurntableConnectorDisk disk)
		{
			builder.AddByte(0, (byte)disk, 0);
		}

		// Token: 0x0601EDF4 RID: 126452 RVA: 0x004505B5 File Offset: 0x0044E7B5
		public static void AddSocket(FlatBufferBuilder builder, StringOffset socketOffset)
		{
			builder.AddOffset(1, socketOffset.Value, 0);
		}

		// Token: 0x0601EDF5 RID: 126453 RVA: 0x004505C5 File Offset: 0x0044E7C5
		public static Offset<ITurntableConnectorDiskSocket> EndITurntableConnectorDiskSocket(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorDiskSocket>(builder.EndTable());
		}

		// Token: 0x0601EDF6 RID: 126454 RVA: 0x004505D4 File Offset: 0x0044E7D4
		public ITurntableConnectorDiskSocketT UnPack()
		{
			ITurntableConnectorDiskSocketT turntableConnectorDiskSocketT = new ITurntableConnectorDiskSocketT();
			this.UnPackTo(turntableConnectorDiskSocketT);
			return turntableConnectorDiskSocketT;
		}

		// Token: 0x0601EDF7 RID: 126455 RVA: 0x004505EF File Offset: 0x0044E7EF
		public void UnPackTo(ITurntableConnectorDiskSocketT _o)
		{
			_o.Disk = this.Disk;
			_o.Socket = this.Socket;
		}

		// Token: 0x0601EDF8 RID: 126456 RVA: 0x0045060C File Offset: 0x0044E80C
		public static Offset<ITurntableConnectorDiskSocket> Pack(FlatBufferBuilder builder, ITurntableConnectorDiskSocketT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorDiskSocket>);
			}
			StringOffset socketOffset = (_o.Socket == null) ? default(StringOffset) : builder.CreateString(_o.Socket);
			return ITurntableConnectorDiskSocket.CreateITurntableConnectorDiskSocket(builder, _o.Disk, socketOffset);
		}

		// Token: 0x0400DA24 RID: 55844
		private Table __p;
	}
}
