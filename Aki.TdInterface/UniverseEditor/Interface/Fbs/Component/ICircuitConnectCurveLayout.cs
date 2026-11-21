using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054D5 RID: 21717
	public struct ICircuitConnectCurveLayout : IFlatbufferObject
	{
		// Token: 0x17009B26 RID: 39718
		// (get) Token: 0x06022471 RID: 140401 RVA: 0x004B9AEF File Offset: 0x004B7CEF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022472 RID: 140402 RVA: 0x004B9AFC File Offset: 0x004B7CFC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022473 RID: 140403 RVA: 0x004B9B04 File Offset: 0x004B7D04
		public static ICircuitConnectCurveLayout GetRootAsICircuitConnectCurveLayout(ByteBuffer _bb)
		{
			return ICircuitConnectCurveLayout.GetRootAsICircuitConnectCurveLayout(_bb, default(ICircuitConnectCurveLayout));
		}

		// Token: 0x06022474 RID: 140404 RVA: 0x004B9B20 File Offset: 0x004B7D20
		public static ICircuitConnectCurveLayout GetRootAsICircuitConnectCurveLayout(ByteBuffer _bb, ICircuitConnectCurveLayout obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022475 RID: 140405 RVA: 0x004B9B3D File Offset: 0x004B7D3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022476 RID: 140406 RVA: 0x004B9B4C File Offset: 0x004B7D4C
		public ICircuitConnectCurveLayout __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B27 RID: 39719
		// (get) Token: 0x06022477 RID: 140407 RVA: 0x004B9B5C File Offset: 0x004B7D5C
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

		// Token: 0x17009B28 RID: 39720
		// (get) Token: 0x06022478 RID: 140408 RVA: 0x004B9B98 File Offset: 0x004B7D98
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

		// Token: 0x06022479 RID: 140409 RVA: 0x004B9BD4 File Offset: 0x004B7DD4
		public static Offset<ICircuitConnectCurveLayout> CreateICircuitConnectCurveLayout(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight, ETurntableConnectorDisk Disk = ETurntableConnectorDisk.Disk0)
		{
			builder.StartTable(2);
			ICircuitConnectCurveLayout.AddDisk(builder, Disk);
			ICircuitConnectCurveLayout.AddType(builder, Type);
			return ICircuitConnectCurveLayout.EndICircuitConnectCurveLayout(builder);
		}

		// Token: 0x0602247A RID: 140410 RVA: 0x004B9BF1 File Offset: 0x004B7DF1
		public static void StartICircuitConnectCurveLayout(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602247B RID: 140411 RVA: 0x004B9BFA File Offset: 0x004B7DFA
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602247C RID: 140412 RVA: 0x004B9C05 File Offset: 0x004B7E05
		public static void AddDisk(FlatBufferBuilder builder, ETurntableConnectorDisk disk)
		{
			builder.AddByte(1, (byte)disk, 0);
		}

		// Token: 0x0602247D RID: 140413 RVA: 0x004B9C10 File Offset: 0x004B7E10
		public static Offset<ICircuitConnectCurveLayout> EndICircuitConnectCurveLayout(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectCurveLayout>(builder.EndTable());
		}

		// Token: 0x0602247E RID: 140414 RVA: 0x004B9C20 File Offset: 0x004B7E20
		public ICircuitConnectCurveLayoutT UnPack()
		{
			ICircuitConnectCurveLayoutT circuitConnectCurveLayoutT = new ICircuitConnectCurveLayoutT();
			this.UnPackTo(circuitConnectCurveLayoutT);
			return circuitConnectCurveLayoutT;
		}

		// Token: 0x0602247F RID: 140415 RVA: 0x004B9C3B File Offset: 0x004B7E3B
		public void UnPackTo(ICircuitConnectCurveLayoutT _o)
		{
			_o.Type = this.Type;
			_o.Disk = this.Disk;
		}

		// Token: 0x06022480 RID: 140416 RVA: 0x004B9C58 File Offset: 0x004B7E58
		public static Offset<ICircuitConnectCurveLayout> Pack(FlatBufferBuilder builder, ICircuitConnectCurveLayoutT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectCurveLayout>);
			}
			return ICircuitConnectCurveLayout.CreateICircuitConnectCurveLayout(builder, _o.Type, _o.Disk);
		}

		// Token: 0x0400EA28 RID: 59944
		private Table __p;
	}
}
