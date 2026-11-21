using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D73 RID: 19827
	public struct ICircuitConnectCurveAsset : IFlatbufferObject
	{
		// Token: 0x17008DDC RID: 36316
		// (get) Token: 0x0601EBB1 RID: 125873 RVA: 0x0044C658 File Offset: 0x0044A858
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EBB2 RID: 125874 RVA: 0x0044C665 File Offset: 0x0044A865
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EBB3 RID: 125875 RVA: 0x0044C66C File Offset: 0x0044A86C
		public static ICircuitConnectCurveAsset GetRootAsICircuitConnectCurveAsset(ByteBuffer _bb)
		{
			return ICircuitConnectCurveAsset.GetRootAsICircuitConnectCurveAsset(_bb, default(ICircuitConnectCurveAsset));
		}

		// Token: 0x0601EBB4 RID: 125876 RVA: 0x0044C688 File Offset: 0x0044A888
		public static ICircuitConnectCurveAsset GetRootAsICircuitConnectCurveAsset(ByteBuffer _bb, ICircuitConnectCurveAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EBB5 RID: 125877 RVA: 0x0044C6A5 File Offset: 0x0044A8A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EBB6 RID: 125878 RVA: 0x0044C6B4 File Offset: 0x0044A8B4
		public ICircuitConnectCurveAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DDD RID: 36317
		// (get) Token: 0x0601EBB7 RID: 125879 RVA: 0x0044C6C4 File Offset: 0x0044A8C4
		public ECircuitConnectElementType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECircuitConnectElementType.Straight;
				}
				return (ECircuitConnectElementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DDE RID: 36318
		// (get) Token: 0x0601EBB8 RID: 125880 RVA: 0x0044C700 File Offset: 0x0044A900
		public ETurntableConnectorDisk Disk
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ETurntableConnectorDisk.Disk0;
				}
				return (ETurntableConnectorDisk)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EBB9 RID: 125881 RVA: 0x0044C73C File Offset: 0x0044A93C
		public static Offset<ICircuitConnectCurveAsset> CreateICircuitConnectCurveAsset(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight, ETurntableConnectorDisk Disk = ETurntableConnectorDisk.Disk0)
		{
			builder.StartTable(2);
			ICircuitConnectCurveAsset.AddDisk(builder, Disk);
			ICircuitConnectCurveAsset.AddType(builder, Type);
			return ICircuitConnectCurveAsset.EndICircuitConnectCurveAsset(builder);
		}

		// Token: 0x0601EBBA RID: 125882 RVA: 0x0044C759 File Offset: 0x0044A959
		public static void StartICircuitConnectCurveAsset(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EBBB RID: 125883 RVA: 0x0044C762 File Offset: 0x0044A962
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EBBC RID: 125884 RVA: 0x0044C76D File Offset: 0x0044A96D
		public static void AddDisk(FlatBufferBuilder builder, ETurntableConnectorDisk disk)
		{
			builder.AddByte(1, (byte)disk, 0);
		}

		// Token: 0x0601EBBD RID: 125885 RVA: 0x0044C778 File Offset: 0x0044A978
		public static Offset<ICircuitConnectCurveAsset> EndICircuitConnectCurveAsset(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectCurveAsset>(builder.EndTable());
		}

		// Token: 0x0601EBBE RID: 125886 RVA: 0x0044C788 File Offset: 0x0044A988
		public ICircuitConnectCurveAssetT UnPack()
		{
			ICircuitConnectCurveAssetT circuitConnectCurveAssetT = new ICircuitConnectCurveAssetT();
			this.UnPackTo(circuitConnectCurveAssetT);
			return circuitConnectCurveAssetT;
		}

		// Token: 0x0601EBBF RID: 125887 RVA: 0x0044C7A3 File Offset: 0x0044A9A3
		public void UnPackTo(ICircuitConnectCurveAssetT _o)
		{
			_o.Type = this.Type;
			_o.Disk = this.Disk;
		}

		// Token: 0x0601EBC0 RID: 125888 RVA: 0x0044C7C0 File Offset: 0x0044A9C0
		public static Offset<ICircuitConnectCurveAsset> Pack(FlatBufferBuilder builder, ICircuitConnectCurveAssetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectCurveAsset>);
			}
			return ICircuitConnectCurveAsset.CreateICircuitConnectCurveAsset(builder, _o.Type, _o.Disk);
		}

		// Token: 0x0400D9C6 RID: 55750
		private Table __p;
	}
}
