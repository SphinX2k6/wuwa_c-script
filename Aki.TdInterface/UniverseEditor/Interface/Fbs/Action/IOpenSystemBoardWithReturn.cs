using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A0 RID: 29600
	public struct IOpenSystemBoardWithReturn : IFlatbufferObject
	{
		// Token: 0x1700D978 RID: 55672
		// (get) Token: 0x06033C23 RID: 212003 RVA: 0x006FB61E File Offset: 0x006F981E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033C24 RID: 212004 RVA: 0x006FB62B File Offset: 0x006F982B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033C25 RID: 212005 RVA: 0x006FB634 File Offset: 0x006F9834
		public static IOpenSystemBoardWithReturn GetRootAsIOpenSystemBoardWithReturn(ByteBuffer _bb)
		{
			return IOpenSystemBoardWithReturn.GetRootAsIOpenSystemBoardWithReturn(_bb, default(IOpenSystemBoardWithReturn));
		}

		// Token: 0x06033C26 RID: 212006 RVA: 0x006FB650 File Offset: 0x006F9850
		public static IOpenSystemBoardWithReturn GetRootAsIOpenSystemBoardWithReturn(ByteBuffer _bb, IOpenSystemBoardWithReturn obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033C27 RID: 212007 RVA: 0x006FB66D File Offset: 0x006F986D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033C28 RID: 212008 RVA: 0x006FB67C File Offset: 0x006F987C
		public IOpenSystemBoardWithReturn __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D979 RID: 55673
		// (get) Token: 0x06033C29 RID: 212009 RVA: 0x006FB68C File Offset: 0x006F988C
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

		// Token: 0x06033C2A RID: 212010 RVA: 0x006FB6C8 File Offset: 0x006F98C8
		public TTable? SystemType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06033C2B RID: 212011 RVA: 0x006FB70C File Offset: 0x006F990C
		public IOpenConfirmBox2WithReturn SystemTypeAsIOpenConfirmBox2WithReturn()
		{
			return this.SystemType<IOpenConfirmBox2WithReturn>().Value;
		}

		// Token: 0x06033C2C RID: 212012 RVA: 0x006FB728 File Offset: 0x006F9928
		public IOpenConfirmBoxWithReturn SystemTypeAsIOpenConfirmBoxWithReturn()
		{
			return this.SystemType<IOpenConfirmBoxWithReturn>().Value;
		}

		// Token: 0x06033C2D RID: 212013 RVA: 0x006FB744 File Offset: 0x006F9944
		public IOpenFishingItemDeliveryWithReturn SystemTypeAsIOpenFishingItemDeliveryWithReturn()
		{
			return this.SystemType<IOpenFishingItemDeliveryWithReturn>().Value;
		}

		// Token: 0x06033C2E RID: 212014 RVA: 0x006FB760 File Offset: 0x006F9960
		public IOpenGiantDeliveryWithReturn SystemTypeAsIOpenGiantDeliveryWithReturn()
		{
			return this.SystemType<IOpenGiantDeliveryWithReturn>().Value;
		}

		// Token: 0x06033C2F RID: 212015 RVA: 0x006FB77C File Offset: 0x006F997C
		public IOpenGreatSwordChallengeResult SystemTypeAsIOpenGreatSwordChallengeResult()
		{
			return this.SystemType<IOpenGreatSwordChallengeResult>().Value;
		}

		// Token: 0x06033C30 RID: 212016 RVA: 0x006FB798 File Offset: 0x006F9998
		public IOpenInfrastructureItemDeliveryWithReturn SystemTypeAsIOpenInfrastructureItemDeliveryWithReturn()
		{
			return this.SystemType<IOpenInfrastructureItemDeliveryWithReturn>().Value;
		}

		// Token: 0x06033C31 RID: 212017 RVA: 0x006FB7B4 File Offset: 0x006F99B4
		public IOpenMechaStuntTrackChallengeResultWithReturn SystemTypeAsIOpenMechaStuntTrackChallengeResultWithReturn()
		{
			return this.SystemType<IOpenMechaStuntTrackChallengeResultWithReturn>().Value;
		}

		// Token: 0x06033C32 RID: 212018 RVA: 0x006FB7D0 File Offset: 0x006F99D0
		public IOpenMotorRaceChallengeResultWithReturn SystemTypeAsIOpenMotorRaceChallengeResultWithReturn()
		{
			return this.SystemType<IOpenMotorRaceChallengeResultWithReturn>().Value;
		}

		// Token: 0x06033C33 RID: 212019 RVA: 0x006FB7EC File Offset: 0x006F99EC
		public IOpenSoaringChallengeResultWithReturn SystemTypeAsIOpenSoaringChallengeResultWithReturn()
		{
			return this.SystemType<IOpenSoaringChallengeResultWithReturn>().Value;
		}

		// Token: 0x06033C34 RID: 212020 RVA: 0x006FB808 File Offset: 0x006F9A08
		public IOpenVillageInfrDeliveryWithReturn SystemTypeAsIOpenVillageInfrDeliveryWithReturn()
		{
			return this.SystemType<IOpenVillageInfrDeliveryWithReturn>().Value;
		}

		// Token: 0x06033C35 RID: 212021 RVA: 0x006FB823 File Offset: 0x006F9A23
		public static Offset<IOpenSystemBoardWithReturn> CreateIOpenSystemBoardWithReturn(FlatBufferBuilder builder, TOpenSystemBoardWithReturn SystemType_type = TOpenSystemBoardWithReturn.NONE, int SystemTypeOffset = 0)
		{
			builder.StartTable(2);
			IOpenSystemBoardWithReturn.AddSystemType(builder, SystemTypeOffset);
			IOpenSystemBoardWithReturn.AddSystemTypeType(builder, SystemType_type);
			return IOpenSystemBoardWithReturn.EndIOpenSystemBoardWithReturn(builder);
		}

		// Token: 0x06033C36 RID: 212022 RVA: 0x006FB840 File Offset: 0x006F9A40
		public static void StartIOpenSystemBoardWithReturn(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033C37 RID: 212023 RVA: 0x006FB849 File Offset: 0x006F9A49
		public static void AddSystemTypeType(FlatBufferBuilder builder, TOpenSystemBoardWithReturn systemTypeType)
		{
			builder.AddByte(0, (byte)systemTypeType, 0);
		}

		// Token: 0x06033C38 RID: 212024 RVA: 0x006FB854 File Offset: 0x006F9A54
		public static void AddSystemType(FlatBufferBuilder builder, int systemTypeOffset)
		{
			builder.AddOffset(1, systemTypeOffset, 0);
		}

		// Token: 0x06033C39 RID: 212025 RVA: 0x006FB85F File Offset: 0x006F9A5F
		public static Offset<IOpenSystemBoardWithReturn> EndIOpenSystemBoardWithReturn(FlatBufferBuilder builder)
		{
			return new Offset<IOpenSystemBoardWithReturn>(builder.EndTable());
		}

		// Token: 0x06033C3A RID: 212026 RVA: 0x006FB86C File Offset: 0x006F9A6C
		public IOpenSystemBoardWithReturnT UnPack()
		{
			IOpenSystemBoardWithReturnT openSystemBoardWithReturnT = new IOpenSystemBoardWithReturnT();
			this.UnPackTo(openSystemBoardWithReturnT);
			return openSystemBoardWithReturnT;
		}

		// Token: 0x06033C3B RID: 212027 RVA: 0x006FB888 File Offset: 0x006F9A88
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
			case TOpenSystemBoardWithReturn.IOpenMechaStuntTrackChallengeResultWithReturn:
				_o.SystemType.Value = ((this.SystemType<IOpenMechaStuntTrackChallengeResultWithReturn>() != null) ? this.SystemType<IOpenMechaStuntTrackChallengeResultWithReturn>().Value.UnPack() : null);
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

		// Token: 0x06033C3C RID: 212028 RVA: 0x006FBB14 File Offset: 0x006F9D14
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

		// Token: 0x040124C4 RID: 74948
		private Table __p;
	}
}
