using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C39 RID: 27705
	public struct IOpenSystemBoardWithReturn : IFlatbufferObject
	{
		// Token: 0x1700CE5D RID: 52829
		// (get) Token: 0x06030CCB RID: 199883 RVA: 0x006A11B6 File Offset: 0x0069F3B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030CCC RID: 199884 RVA: 0x006A11C3 File Offset: 0x0069F3C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030CCD RID: 199885 RVA: 0x006A11CC File Offset: 0x0069F3CC
		public static IOpenSystemBoardWithReturn GetRootAsIOpenSystemBoardWithReturn(ByteBuffer _bb)
		{
			return IOpenSystemBoardWithReturn.GetRootAsIOpenSystemBoardWithReturn(_bb, default(IOpenSystemBoardWithReturn));
		}

		// Token: 0x06030CCE RID: 199886 RVA: 0x006A11E8 File Offset: 0x0069F3E8
		public static IOpenSystemBoardWithReturn GetRootAsIOpenSystemBoardWithReturn(ByteBuffer _bb, IOpenSystemBoardWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030CCF RID: 199887 RVA: 0x006A1205 File Offset: 0x0069F405
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030CD0 RID: 199888 RVA: 0x006A1214 File Offset: 0x0069F414
		public IOpenSystemBoardWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE5E RID: 52830
		// (get) Token: 0x06030CD1 RID: 199889 RVA: 0x006A1224 File Offset: 0x0069F424
		public TOpenSystemBoardWithReturn SystemTypeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TOpenSystemBoardWithReturn.NONE;
				}
				return (TOpenSystemBoardWithReturn)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030CD2 RID: 199890 RVA: 0x006A1260 File Offset: 0x0069F460
		public TTable? SystemType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030CD3 RID: 199891 RVA: 0x006A12A4 File Offset: 0x0069F4A4
		public IOpenConfirmBox2WithReturn SystemTypeAsIOpenConfirmBox2WithReturn()
		{
			return this.SystemType<IOpenConfirmBox2WithReturn>().Value;
		}

		// Token: 0x06030CD4 RID: 199892 RVA: 0x006A12C0 File Offset: 0x0069F4C0
		public IOpenConfirmBoxWithReturn SystemTypeAsIOpenConfirmBoxWithReturn()
		{
			return this.SystemType<IOpenConfirmBoxWithReturn>().Value;
		}

		// Token: 0x06030CD5 RID: 199893 RVA: 0x006A12DC File Offset: 0x0069F4DC
		public IOpenFishingItemDeliveryWithReturn SystemTypeAsIOpenFishingItemDeliveryWithReturn()
		{
			return this.SystemType<IOpenFishingItemDeliveryWithReturn>().Value;
		}

		// Token: 0x06030CD6 RID: 199894 RVA: 0x006A12F8 File Offset: 0x0069F4F8
		public IOpenGiantDeliveryWithReturn SystemTypeAsIOpenGiantDeliveryWithReturn()
		{
			return this.SystemType<IOpenGiantDeliveryWithReturn>().Value;
		}

		// Token: 0x06030CD7 RID: 199895 RVA: 0x006A1314 File Offset: 0x0069F514
		public IOpenGreatSwordChallengeResult SystemTypeAsIOpenGreatSwordChallengeResult()
		{
			return this.SystemType<IOpenGreatSwordChallengeResult>().Value;
		}

		// Token: 0x06030CD8 RID: 199896 RVA: 0x006A1330 File Offset: 0x0069F530
		public IOpenInfrastructureItemDeliveryWithReturn SystemTypeAsIOpenInfrastructureItemDeliveryWithReturn()
		{
			return this.SystemType<IOpenInfrastructureItemDeliveryWithReturn>().Value;
		}

		// Token: 0x06030CD9 RID: 199897 RVA: 0x006A134C File Offset: 0x0069F54C
		public IOpenMotorRaceChallengeResultWithReturn SystemTypeAsIOpenMotorRaceChallengeResultWithReturn()
		{
			return this.SystemType<IOpenMotorRaceChallengeResultWithReturn>().Value;
		}

		// Token: 0x06030CDA RID: 199898 RVA: 0x006A1368 File Offset: 0x0069F568
		public IOpenSoaringChallengeResultWithReturn SystemTypeAsIOpenSoaringChallengeResultWithReturn()
		{
			return this.SystemType<IOpenSoaringChallengeResultWithReturn>().Value;
		}

		// Token: 0x06030CDB RID: 199899 RVA: 0x006A1384 File Offset: 0x0069F584
		public IOpenVillageInfrDeliveryWithReturn SystemTypeAsIOpenVillageInfrDeliveryWithReturn()
		{
			return this.SystemType<IOpenVillageInfrDeliveryWithReturn>().Value;
		}

		// Token: 0x06030CDC RID: 199900 RVA: 0x006A139F File Offset: 0x0069F59F
		public static Offset<IOpenSystemBoardWithReturn> CreateIOpenSystemBoardWithReturn(FlatBufferBuilder builder, TOpenSystemBoardWithReturn SystemType_type = TOpenSystemBoardWithReturn.NONE, int SystemTypeOffset = 0)
		{
			builder.StartTable(2);
			IOpenSystemBoardWithReturn.AddSystemType(builder, SystemTypeOffset);
			IOpenSystemBoardWithReturn.AddSystemTypeType(builder, SystemType_type);
			return IOpenSystemBoardWithReturn.EndIOpenSystemBoardWithReturn(builder);
		}

		// Token: 0x06030CDD RID: 199901 RVA: 0x006A13BC File Offset: 0x0069F5BC
		public static void StartIOpenSystemBoardWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030CDE RID: 199902 RVA: 0x006A13C5 File Offset: 0x0069F5C5
		public static void AddSystemTypeType(FlatBufferBuilder builder, TOpenSystemBoardWithReturn systemTypeType)
		{
			builder.AddByte(0, (byte)systemTypeType, 0);
		}

		// Token: 0x06030CDF RID: 199903 RVA: 0x006A13D0 File Offset: 0x0069F5D0
		public static void AddSystemType(FlatBufferBuilder builder, int systemTypeOffset)
		{
			builder.AddOffset(1, systemTypeOffset, 0);
		}

		// Token: 0x06030CE0 RID: 199904 RVA: 0x006A13DB File Offset: 0x0069F5DB
		public static Offset<IOpenSystemBoardWithReturn> EndIOpenSystemBoardWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemBoardWithReturn>(builder.EndTable());
		}

		// Token: 0x06030CE1 RID: 199905 RVA: 0x006A13E8 File Offset: 0x0069F5E8
		public IOpenSystemBoardWithReturnT UnPack()
		{
			IOpenSystemBoardWithReturnT openSystemBoardWithReturnT = new IOpenSystemBoardWithReturnT();
			this.UnPackTo(openSystemBoardWithReturnT);
			return openSystemBoardWithReturnT;
		}

		// Token: 0x06030CE2 RID: 199906 RVA: 0x006A1404 File Offset: 0x0069F604
		public void UnPackTo(IOpenSystemBoardWithReturnT _o)
		{
			_o.SystemType = new TOpenSystemBoardWithReturnUnion();
			_o.SystemType.Type = this.SystemTypeType;
			switch (this.SystemTypeType)
			{
			case TOpenSystemBoardWithReturn.IOpenConfirmBox2WithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenConfirmBox2WithReturn>() != null) ? this.SystemType<IOpenConfirmBox2WithReturn>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenConfirmBoxWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenConfirmBoxWithReturn>() != null) ? this.SystemType<IOpenConfirmBoxWithReturn>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenFishingItemDeliveryWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenFishingItemDeliveryWithReturn>() != null) ? this.SystemType<IOpenFishingItemDeliveryWithReturn>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenGiantDeliveryWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenGiantDeliveryWithReturn>() != null) ? this.SystemType<IOpenGiantDeliveryWithReturn>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenGreatSwordChallengeResult:
				_o.SystemType.Value = ((this.SystemType<IOpenGreatSwordChallengeResult>() != null) ? this.SystemType<IOpenGreatSwordChallengeResult>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenInfrastructureItemDeliveryWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenInfrastructureItemDeliveryWithReturn>() != null) ? this.SystemType<IOpenInfrastructureItemDeliveryWithReturn>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenMotorRaceChallengeResultWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenMotorRaceChallengeResultWithReturn>() != null) ? this.SystemType<IOpenMotorRaceChallengeResultWithReturn>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenSoaringChallengeResultWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenSoaringChallengeResultWithReturn>() != null) ? this.SystemType<IOpenSoaringChallengeResultWithReturn>().Value.UnPack() : null);
				return;
			case TOpenSystemBoardWithReturn.IOpenVillageInfrDeliveryWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenVillageInfrDeliveryWithReturn>() != null) ? this.SystemType<IOpenVillageInfrDeliveryWithReturn>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06030CE3 RID: 199907 RVA: 0x006A1654 File Offset: 0x0069F854
		public static Offset<IOpenSystemBoardWithReturn> Pack(FlatBufferBuilder builder, IOpenSystemBoardWithReturnT _o)
		{
			if (_o == null)
			{
				return default(Offset<IOpenSystemBoardWithReturn>);
			}
			TOpenSystemBoardWithReturn systemType_type = (_o.SystemType == null) ? TOpenSystemBoardWithReturn.NONE : _o.SystemType.Type;
			int systemTypeOffset = (_o.SystemType == null) ? 0 : TOpenSystemBoardWithReturnUnion.Pack(builder, _o.SystemType);
			return IOpenSystemBoardWithReturn.CreateIOpenSystemBoardWithReturn(builder, systemType_type, systemTypeOffset);
		}

		// Token: 0x0401156D RID: 71021
		private Table __p;
	}
}
