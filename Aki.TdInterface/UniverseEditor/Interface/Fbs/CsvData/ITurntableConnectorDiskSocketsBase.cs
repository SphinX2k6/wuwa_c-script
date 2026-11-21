using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DBB RID: 19899
	public struct ITurntableConnectorDiskSocketsBase : IFlatbufferObject
	{
		// Token: 0x17008E5E RID: 36446
		// (get) Token: 0x0601EDFF RID: 126463 RVA: 0x004506B9 File Offset: 0x0044E8B9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EE00 RID: 126464 RVA: 0x004506C6 File Offset: 0x0044E8C6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EE01 RID: 126465 RVA: 0x004506D0 File Offset: 0x0044E8D0
		public static ITurntableConnectorDiskSocketsBase GetRootAsITurntableConnectorDiskSocketsBase(ByteBuffer _bb)
		{
			return ITurntableConnectorDiskSocketsBase.GetRootAsITurntableConnectorDiskSocketsBase(_bb, default(ITurntableConnectorDiskSocketsBase));
		}

		// Token: 0x0601EE02 RID: 126466 RVA: 0x004506EC File Offset: 0x0044E8EC
		public static ITurntableConnectorDiskSocketsBase GetRootAsITurntableConnectorDiskSocketsBase(ByteBuffer _bb, ITurntableConnectorDiskSocketsBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EE03 RID: 126467 RVA: 0x00450709 File Offset: 0x0044E909
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EE04 RID: 126468 RVA: 0x00450718 File Offset: 0x0044E918
		public ITurntableConnectorDiskSocketsBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E5F RID: 36447
		// (get) Token: 0x0601EE05 RID: 126469 RVA: 0x00450728 File Offset: 0x0044E928
		public ETurntableConnectorDiskLayout Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETurntableConnectorDiskLayout.Normal;
				}
				return (ETurntableConnectorDiskLayout)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EE06 RID: 126470 RVA: 0x00450764 File Offset: 0x0044E964
		public static Offset<ITurntableConnectorDiskSocketsBase> CreateITurntableConnectorDiskSocketsBase(FlatBufferBuilder builder, ETurntableConnectorDiskLayout Type = ETurntableConnectorDiskLayout.Normal)
		{
			builder.StartTable(1);
			ITurntableConnectorDiskSocketsBase.AddType(builder, Type);
			return ITurntableConnectorDiskSocketsBase.EndITurntableConnectorDiskSocketsBase(builder);
		}

		// Token: 0x0601EE07 RID: 126471 RVA: 0x0045077A File Offset: 0x0044E97A
		public static void StartITurntableConnectorDiskSocketsBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EE08 RID: 126472 RVA: 0x00450783 File Offset: 0x0044E983
		public static void AddType(FlatBufferBuilder builder, ETurntableConnectorDiskLayout type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EE09 RID: 126473 RVA: 0x0045078E File Offset: 0x0044E98E
		public static Offset<ITurntableConnectorDiskSocketsBase> EndITurntableConnectorDiskSocketsBase(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorDiskSocketsBase>(builder.EndTable());
		}

		// Token: 0x0601EE0A RID: 126474 RVA: 0x0045079C File Offset: 0x0044E99C
		public ITurntableConnectorDiskSocketsBaseT UnPack()
		{
			ITurntableConnectorDiskSocketsBaseT turntableConnectorDiskSocketsBaseT = new ITurntableConnectorDiskSocketsBaseT();
			this.UnPackTo(turntableConnectorDiskSocketsBaseT);
			return turntableConnectorDiskSocketsBaseT;
		}

		// Token: 0x0601EE0B RID: 126475 RVA: 0x004507B7 File Offset: 0x0044E9B7
		public void UnPackTo(ITurntableConnectorDiskSocketsBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EE0C RID: 126476 RVA: 0x004507C8 File Offset: 0x0044E9C8
		public static Offset<ITurntableConnectorDiskSocketsBase> Pack(FlatBufferBuilder builder, ITurntableConnectorDiskSocketsBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorDiskSocketsBase>);
			}
			return ITurntableConnectorDiskSocketsBase.CreateITurntableConnectorDiskSocketsBase(builder, _o.Type);
		}

		// Token: 0x0400DA27 RID: 55847
		private Table __p;
	}
}
