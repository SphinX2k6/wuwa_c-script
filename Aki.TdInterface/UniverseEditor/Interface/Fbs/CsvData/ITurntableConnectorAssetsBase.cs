using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB2 RID: 19890
	public struct ITurntableConnectorAssetsBase : IFlatbufferObject
	{
		// Token: 0x17008E54 RID: 36436
		// (get) Token: 0x0601EDC9 RID: 126409 RVA: 0x00450214 File Offset: 0x0044E414
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EDCA RID: 126410 RVA: 0x00450221 File Offset: 0x0044E421
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EDCB RID: 126411 RVA: 0x00450228 File Offset: 0x0044E428
		public static ITurntableConnectorAssetsBase GetRootAsITurntableConnectorAssetsBase(ByteBuffer _bb)
		{
			return ITurntableConnectorAssetsBase.GetRootAsITurntableConnectorAssetsBase(_bb, default(ITurntableConnectorAssetsBase));
		}

		// Token: 0x0601EDCC RID: 126412 RVA: 0x00450244 File Offset: 0x0044E444
		public static ITurntableConnectorAssetsBase GetRootAsITurntableConnectorAssetsBase(ByteBuffer _bb, ITurntableConnectorAssetsBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EDCD RID: 126413 RVA: 0x00450261 File Offset: 0x0044E461
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EDCE RID: 126414 RVA: 0x00450270 File Offset: 0x0044E470
		public ITurntableConnectorAssetsBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008E55 RID: 36437
		// (get) Token: 0x0601EDCF RID: 126415 RVA: 0x00450280 File Offset: 0x0044E480
		public ETurntableConnectorGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETurntableConnectorGameplayType.CircuitConnect;
				}
				return (ETurntableConnectorGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EDD0 RID: 126416 RVA: 0x004502BC File Offset: 0x0044E4BC
		public static Offset<ITurntableConnectorAssetsBase> CreateITurntableConnectorAssetsBase(FlatBufferBuilder builder, ETurntableConnectorGameplayType Type = ETurntableConnectorGameplayType.CircuitConnect)
		{
			builder.StartTable(1);
			ITurntableConnectorAssetsBase.AddType(builder, Type);
			return ITurntableConnectorAssetsBase.EndITurntableConnectorAssetsBase(builder);
		}

		// Token: 0x0601EDD1 RID: 126417 RVA: 0x004502D2 File Offset: 0x0044E4D2
		public static void StartITurntableConnectorAssetsBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EDD2 RID: 126418 RVA: 0x004502DB File Offset: 0x0044E4DB
		public static void AddType(FlatBufferBuilder builder, ETurntableConnectorGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EDD3 RID: 126419 RVA: 0x004502E6 File Offset: 0x0044E4E6
		public static Offset<ITurntableConnectorAssetsBase> EndITurntableConnectorAssetsBase(FlatBufferBuilder builder)
		{
			return new Offset<ITurntableConnectorAssetsBase>(builder.EndTable());
		}

		// Token: 0x0601EDD4 RID: 126420 RVA: 0x004502F4 File Offset: 0x0044E4F4
		public ITurntableConnectorAssetsBaseT UnPack()
		{
			ITurntableConnectorAssetsBaseT turntableConnectorAssetsBaseT = new ITurntableConnectorAssetsBaseT();
			this.UnPackTo(turntableConnectorAssetsBaseT);
			return turntableConnectorAssetsBaseT;
		}

		// Token: 0x0601EDD5 RID: 126421 RVA: 0x0045030F File Offset: 0x0044E50F
		public void UnPackTo(ITurntableConnectorAssetsBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EDD6 RID: 126422 RVA: 0x00450320 File Offset: 0x0044E520
		public static Offset<ITurntableConnectorAssetsBase> Pack(FlatBufferBuilder builder, ITurntableConnectorAssetsBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITurntableConnectorAssetsBase>);
			}
			return ITurntableConnectorAssetsBase.CreateITurntableConnectorAssetsBase(builder, _o.Type);
		}

		// Token: 0x0400DA1C RID: 55836
		private Table __p;
	}
}
