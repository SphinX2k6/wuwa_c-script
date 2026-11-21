using System;
using Aki.UniverseEditor.Interface.Fbs.Component;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D79 RID: 19833
	public struct ICircuitConnectPowerPortAsset : IFlatbufferObject
	{
		// Token: 0x17008DE4 RID: 36324
		// (get) Token: 0x0601EBD9 RID: 125913 RVA: 0x0044C9CD File Offset: 0x0044ABCD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EBDA RID: 125914 RVA: 0x0044C9DA File Offset: 0x0044ABDA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EBDB RID: 125915 RVA: 0x0044C9E4 File Offset: 0x0044ABE4
		public static ICircuitConnectPowerPortAsset GetRootAsICircuitConnectPowerPortAsset(ByteBuffer _bb)
		{
			return ICircuitConnectPowerPortAsset.GetRootAsICircuitConnectPowerPortAsset(_bb, default(ICircuitConnectPowerPortAsset));
		}

		// Token: 0x0601EBDC RID: 125916 RVA: 0x0044CA00 File Offset: 0x0044AC00
		public static ICircuitConnectPowerPortAsset GetRootAsICircuitConnectPowerPortAsset(ByteBuffer _bb, ICircuitConnectPowerPortAsset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EBDD RID: 125917 RVA: 0x0044CA1D File Offset: 0x0044AC1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EBDE RID: 125918 RVA: 0x0044CA2C File Offset: 0x0044AC2C
		public ICircuitConnectPowerPortAsset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DE5 RID: 36325
		// (get) Token: 0x0601EBDF RID: 125919 RVA: 0x0044CA3C File Offset: 0x0044AC3C
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

		// Token: 0x0601EBE0 RID: 125920 RVA: 0x0044CA78 File Offset: 0x0044AC78
		public static Offset<ICircuitConnectPowerPortAsset> CreateICircuitConnectPowerPortAsset(FlatBufferBuilder builder, ECircuitConnectElementType Type = ECircuitConnectElementType.Straight)
		{
			builder.StartTable(1);
			ICircuitConnectPowerPortAsset.AddType(builder, Type);
			return ICircuitConnectPowerPortAsset.EndICircuitConnectPowerPortAsset(builder);
		}

		// Token: 0x0601EBE1 RID: 125921 RVA: 0x0044CA8E File Offset: 0x0044AC8E
		public static void StartICircuitConnectPowerPortAsset(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601EBE2 RID: 125922 RVA: 0x0044CA97 File Offset: 0x0044AC97
		public static void AddType(FlatBufferBuilder builder, ECircuitConnectElementType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601EBE3 RID: 125923 RVA: 0x0044CAA2 File Offset: 0x0044ACA2
		public static Offset<ICircuitConnectPowerPortAsset> EndICircuitConnectPowerPortAsset(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectPowerPortAsset>(builder.EndTable());
		}

		// Token: 0x0601EBE4 RID: 125924 RVA: 0x0044CAB0 File Offset: 0x0044ACB0
		public ICircuitConnectPowerPortAssetT UnPack()
		{
			ICircuitConnectPowerPortAssetT circuitConnectPowerPortAssetT = new ICircuitConnectPowerPortAssetT();
			this.UnPackTo(circuitConnectPowerPortAssetT);
			return circuitConnectPowerPortAssetT;
		}

		// Token: 0x0601EBE5 RID: 125925 RVA: 0x0044CACB File Offset: 0x0044ACCB
		public void UnPackTo(ICircuitConnectPowerPortAssetT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601EBE6 RID: 125926 RVA: 0x0044CADC File Offset: 0x0044ACDC
		public static Offset<ICircuitConnectPowerPortAsset> Pack(FlatBufferBuilder builder, ICircuitConnectPowerPortAssetT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectPowerPortAsset>);
			}
			return ICircuitConnectPowerPortAsset.CreateICircuitConnectPowerPortAsset(builder, _o.Type);
		}

		// Token: 0x0400D9CB RID: 55755
		private Table __p;
	}
}
