using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F3 RID: 21747
	public struct ICircuitConnectStraightLayout : IFlatbufferObject
	{
		// Token: 0x17009B54 RID: 39764
		// (get) Token: 0x06022563 RID: 140643 RVA: 0x004BB86A File Offset: 0x004B9A6A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022564 RID: 140644 RVA: 0x004BB877 File Offset: 0x004B9A77
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022565 RID: 140645 RVA: 0x004BB880 File Offset: 0x004B9A80
		public static ICircuitConnectStraightLayout GetRootAsICircuitConnectStraightLayout(ByteBuffer _bb)
		{
			return ICircuitConnectStraightLayout.GetRootAsICircuitConnectStraightLayout(_bb, default(ICircuitConnectStraightLayout));
		}

		// Token: 0x06022566 RID: 140646 RVA: 0x004BB89C File Offset: 0x004B9A9C
		public static ICircuitConnectStraightLayout GetRootAsICircuitConnectStraightLayout(ByteBuffer _bb, ICircuitConnectStraightLayout obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022567 RID: 140647 RVA: 0x004BB8B9 File Offset: 0x004B9AB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022568 RID: 140648 RVA: 0x004BB8C8 File Offset: 0x004B9AC8
		public ICircuitConnectStraightLayout __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B55 RID: 39765
		// (get) Token: 0x06022569 RID: 140649 RVA: 0x004BB8D8 File Offset: 0x004B9AD8
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

		// Token: 0x17009B56 RID: 39766
		// (get) Token: 0x0602256A RID: 140650 RVA: 0x004BB914 File Offset: 0x004B9B14
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

		// Token: 0x0602256B RID: 140651 RVA: 0x004BB950 File Offset: 0x004B9B50
		public static Offset<ICircuitConnectStraightLayout> CreateICircuitConnectStraightLayout(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight, ETurntableConnectorDisk Disk = ETurntableConnectorDisk.Disk0)
		{
			builder.StartTable(2);
			ICircuitConnectStraightLayout.AddDisk(builder, Disk);
			ICircuitConnectStraightLayout.AddType(builder, Type);
			return ICircuitConnectStraightLayout.EndICircuitConnectStraightLayout(builder);
		}

		// Token: 0x0602256C RID: 140652 RVA: 0x004BB96D File Offset: 0x004B9B6D
		public static void StartICircuitConnectStraightLayout(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602256D RID: 140653 RVA: 0x004BB976 File Offset: 0x004B9B76
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602256E RID: 140654 RVA: 0x004BB981 File Offset: 0x004B9B81
		public static void AddDisk(FlatBufferBuilder builder, ETurntableConnectorDisk disk)
		{
			builder.AddByte(1, (byte)disk, 0);
		}

		// Token: 0x0602256F RID: 140655 RVA: 0x004BB98C File Offset: 0x004B9B8C
		public static Offset<ICircuitConnectStraightLayout> EndICircuitConnectStraightLayout(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectStraightLayout>(builder.EndTable());
		}

		// Token: 0x06022570 RID: 140656 RVA: 0x004BB99C File Offset: 0x004B9B9C
		public ICircuitConnectStraightLayoutT UnPack()
		{
			ICircuitConnectStraightLayoutT circuitConnectStraightLayoutT = new ICircuitConnectStraightLayoutT();
			this.UnPackTo(circuitConnectStraightLayoutT);
			return circuitConnectStraightLayoutT;
		}

		// Token: 0x06022571 RID: 140657 RVA: 0x004BB9B7 File Offset: 0x004B9BB7
		public void UnPackTo(ICircuitConnectStraightLayoutT _o)
		{
			_o.Type = this.Type;
			_o.Disk = this.Disk;
		}

		// Token: 0x06022572 RID: 140658 RVA: 0x004BB9D4 File Offset: 0x004B9BD4
		public static Offset<ICircuitConnectStraightLayout> Pack(FlatBufferBuilder builder, ICircuitConnectStraightLayoutT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectStraightLayout>);
			}
			return ICircuitConnectStraightLayout.CreateICircuitConnectStraightLayout(builder, _o.Type, _o.Disk);
		}

		// Token: 0x0400EA51 RID: 59985
		private Table __p;
	}
}
