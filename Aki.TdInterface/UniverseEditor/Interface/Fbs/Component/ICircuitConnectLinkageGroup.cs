using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E4 RID: 21732
	public struct ICircuitConnectLinkageGroup : IFlatbufferObject
	{
		// Token: 0x17009B42 RID: 39746
		// (get) Token: 0x060224FD RID: 140541 RVA: 0x004BAEAC File Offset: 0x004B90AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224FE RID: 140542 RVA: 0x004BAEB9 File Offset: 0x004B90B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224FF RID: 140543 RVA: 0x004BAEC0 File Offset: 0x004B90C0
		public static ICircuitConnectLinkageGroup GetRootAsICircuitConnectLinkageGroup(ByteBuffer _bb)
		{
			return ICircuitConnectLinkageGroup.GetRootAsICircuitConnectLinkageGroup(_bb, default(ICircuitConnectLinkageGroup));
		}

		// Token: 0x06022500 RID: 140544 RVA: 0x004BAEDC File Offset: 0x004B90DC
		public static ICircuitConnectLinkageGroup GetRootAsICircuitConnectLinkageGroup(ByteBuffer _bb, ICircuitConnectLinkageGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022501 RID: 140545 RVA: 0x004BAEF9 File Offset: 0x004B90F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022502 RID: 140546 RVA: 0x004BAF08 File Offset: 0x004B9108
		public ICircuitConnectLinkageGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B43 RID: 39747
		// (get) Token: 0x06022503 RID: 140547 RVA: 0x004BAF18 File Offset: 0x004B9118
		public ETurntableConnectorDisk MainDisk
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

		// Token: 0x06022504 RID: 140548 RVA: 0x004BAF54 File Offset: 0x004B9154
		public ETurntableConnectorDisk LinkedDisks(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return ETurntableConnectorDisk.Disk0;
			}
			return (ETurntableConnectorDisk)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x17009B44 RID: 39748
		// (get) Token: 0x06022505 RID: 140549 RVA: 0x004BAF94 File Offset: 0x004B9194
		public int LinkedDisksLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06022506 RID: 140550 RVA: 0x004BAFBF File Offset: 0x004B91BF
		public Span<ETurntableConnectorDisk> GetLinkedDisksBytes()
		{
			return this.__p.__vector_as_span<ETurntableConnectorDisk>(6, 1);
		}

		// Token: 0x06022507 RID: 140551 RVA: 0x004BAFD0 File Offset: 0x004B91D0
		public ETurntableConnectorDisk[] GetLinkedDisksArray()
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			ETurntableConnectorDisk[] array = new ETurntableConnectorDisk[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (ETurntableConnectorDisk)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x06022508 RID: 140552 RVA: 0x004BB039 File Offset: 0x004B9239
		public static Offset<ICircuitConnectLinkageGroup> CreateICircuitConnectLinkageGroup(FlatBufferBuilder builder, ETurntableConnectorDisk MainDisk = ETurntableConnectorDisk.Disk0, VectorOffset LinkedDisksOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICircuitConnectLinkageGroup.AddLinkedDisks(builder, LinkedDisksOffset);
			ICircuitConnectLinkageGroup.AddMainDisk(builder, MainDisk);
			return ICircuitConnectLinkageGroup.EndICircuitConnectLinkageGroup(builder);
		}

		// Token: 0x06022509 RID: 140553 RVA: 0x004BB056 File Offset: 0x004B9256
		public static void StartICircuitConnectLinkageGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602250A RID: 140554 RVA: 0x004BB05F File Offset: 0x004B925F
		public static void AddMainDisk(FlatBufferBuilder builder, ETurntableConnectorDisk mainDisk)
		{
			builder.AddByte(0, (byte)mainDisk, 0);
		}

		// Token: 0x0602250B RID: 140555 RVA: 0x004BB06A File Offset: 0x004B926A
		public static void AddLinkedDisks(FlatBufferBuilder builder, VectorOffset linkedDisksOffset)
		{
			builder.AddOffset(1, linkedDisksOffset.Value, 0);
		}

		// Token: 0x0602250C RID: 140556 RVA: 0x004BB07C File Offset: 0x004B927C
		public static VectorOffset CreateLinkedDisksVector(FlatBufferBuilder builder, ETurntableConnectorDisk[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602250D RID: 140557 RVA: 0x004BB0B3 File Offset: 0x004B92B3
		public static VectorOffset CreateLinkedDisksVectorBlock(FlatBufferBuilder builder, ETurntableConnectorDisk[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<ETurntableConnectorDisk>(data);
			return builder.EndVector();
		}

		// Token: 0x0602250E RID: 140558 RVA: 0x004BB0CD File Offset: 0x004B92CD
		public static VectorOffset CreateLinkedDisksVectorBlock(FlatBufferBuilder builder, ArraySegment<ETurntableConnectorDisk> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<ETurntableConnectorDisk>(data);
			return builder.EndVector();
		}

		// Token: 0x0602250F RID: 140559 RVA: 0x004BB0EB File Offset: 0x004B92EB
		public static VectorOffset CreateLinkedDisksVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<ETurntableConnectorDisk>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022510 RID: 140560 RVA: 0x004BB104 File Offset: 0x004B9304
		public static void StartLinkedDisksVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x06022511 RID: 140561 RVA: 0x004BB10F File Offset: 0x004B930F
		public static Offset<ICircuitConnectLinkageGroup> EndICircuitConnectLinkageGroup(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectLinkageGroup>(builder.EndTable());
		}

		// Token: 0x06022512 RID: 140562 RVA: 0x004BB11C File Offset: 0x004B931C
		public ICircuitConnectLinkageGroupT UnPack()
		{
			ICircuitConnectLinkageGroupT circuitConnectLinkageGroupT = new ICircuitConnectLinkageGroupT();
			this.UnPackTo(circuitConnectLinkageGroupT);
			return circuitConnectLinkageGroupT;
		}

		// Token: 0x06022513 RID: 140563 RVA: 0x004BB138 File Offset: 0x004B9338
		public void UnPackTo(ICircuitConnectLinkageGroupT _o)
		{
			_o.MainDisk = this.MainDisk;
			_o.LinkedDisks = new List<ETurntableConnectorDisk>();
			for (int i = 0; i < this.LinkedDisksLength; i++)
			{
				_o.LinkedDisks.Add(this.LinkedDisks(i));
			}
		}

		// Token: 0x06022514 RID: 140564 RVA: 0x004BB180 File Offset: 0x004B9380
		public static Offset<ICircuitConnectLinkageGroup> Pack(FlatBufferBuilder builder, ICircuitConnectLinkageGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectLinkageGroup>);
			}
			VectorOffset linkedDisksOffset = default(VectorOffset);
			if (_o.LinkedDisks != null)
			{
				ETurntableConnectorDisk[] data = _o.LinkedDisks.ToArray();
				linkedDisksOffset = ICircuitConnectLinkageGroup.CreateLinkedDisksVector(builder, data);
			}
			return ICircuitConnectLinkageGroup.CreateICircuitConnectLinkageGroup(builder, _o.MainDisk, linkedDisksOffset);
		}

		// Token: 0x0400EA40 RID: 59968
		private Table __p;
	}
}
