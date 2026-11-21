using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F0 RID: 21744
	public struct ICircuitConnectPowerPortLayout : IFlatbufferObject
	{
		// Token: 0x17009B4F RID: 39759
		// (get) Token: 0x0602254D RID: 140621 RVA: 0x004BB669 File Offset: 0x004B9869
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602254E RID: 140622 RVA: 0x004BB676 File Offset: 0x004B9876
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602254F RID: 140623 RVA: 0x004BB680 File Offset: 0x004B9880
		public static ICircuitConnectPowerPortLayout GetRootAsICircuitConnectPowerPortLayout(ByteBuffer _bb)
		{
			return ICircuitConnectPowerPortLayout.GetRootAsICircuitConnectPowerPortLayout(_bb, default(ICircuitConnectPowerPortLayout));
		}

		// Token: 0x06022550 RID: 140624 RVA: 0x004BB69C File Offset: 0x004B989C
		public static ICircuitConnectPowerPortLayout GetRootAsICircuitConnectPowerPortLayout(ByteBuffer _bb, ICircuitConnectPowerPortLayout obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022551 RID: 140625 RVA: 0x004BB6B9 File Offset: 0x004B98B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022552 RID: 140626 RVA: 0x004BB6C8 File Offset: 0x004B98C8
		public ICircuitConnectPowerPortLayout __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B50 RID: 39760
		// (get) Token: 0x06022553 RID: 140627 RVA: 0x004BB6D8 File Offset: 0x004B98D8
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

		// Token: 0x17009B51 RID: 39761
		// (get) Token: 0x06022554 RID: 140628 RVA: 0x004BB714 File Offset: 0x004B9914
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

		// Token: 0x06022555 RID: 140629 RVA: 0x004BB750 File Offset: 0x004B9950
		public static Offset<ICircuitConnectPowerPortLayout> CreateICircuitConnectPowerPortLayout(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight, ETurntableConnectorDisk Disk = ETurntableConnectorDisk.Disk0)
		{
			builder.StartTable(2);
			ICircuitConnectPowerPortLayout.AddDisk(builder, Disk);
			ICircuitConnectPowerPortLayout.AddType(builder, Type);
			return ICircuitConnectPowerPortLayout.EndICircuitConnectPowerPortLayout(builder);
		}

		// Token: 0x06022556 RID: 140630 RVA: 0x004BB76D File Offset: 0x004B996D
		public static void StartICircuitConnectPowerPortLayout(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022557 RID: 140631 RVA: 0x004BB776 File Offset: 0x004B9976
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022558 RID: 140632 RVA: 0x004BB781 File Offset: 0x004B9981
		public static void AddDisk(FlatBufferBuilder builder, ETurntableConnectorDisk disk)
		{
			builder.AddByte(1, (byte)disk, 0);
		}

		// Token: 0x06022559 RID: 140633 RVA: 0x004BB78C File Offset: 0x004B998C
		public static Offset<ICircuitConnectPowerPortLayout> EndICircuitConnectPowerPortLayout(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectPowerPortLayout>(builder.EndTable());
		}

		// Token: 0x0602255A RID: 140634 RVA: 0x004BB79C File Offset: 0x004B999C
		public ICircuitConnectPowerPortLayoutT UnPack()
		{
			ICircuitConnectPowerPortLayoutT circuitConnectPowerPortLayoutT = new ICircuitConnectPowerPortLayoutT();
			this.UnPackTo(circuitConnectPowerPortLayoutT);
			return circuitConnectPowerPortLayoutT;
		}

		// Token: 0x0602255B RID: 140635 RVA: 0x004BB7B7 File Offset: 0x004B99B7
		public void UnPackTo(ICircuitConnectPowerPortLayoutT _o)
		{
			_o.Type = this.Type;
			_o.Disk = this.Disk;
		}

		// Token: 0x0602255C RID: 140636 RVA: 0x004BB7D4 File Offset: 0x004B99D4
		public static Offset<ICircuitConnectPowerPortLayout> Pack(FlatBufferBuilder builder, ICircuitConnectPowerPortLayoutT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectPowerPortLayout>);
			}
			return ICircuitConnectPowerPortLayout.CreateICircuitConnectPowerPortLayout(builder, _o.Type, _o.Disk);
		}

		// Token: 0x0400EA4E RID: 59982
		private Table __p;
	}
}
