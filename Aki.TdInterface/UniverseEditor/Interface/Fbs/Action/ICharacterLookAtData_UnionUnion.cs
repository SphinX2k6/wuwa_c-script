using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006341 RID: 25409
	public class ICharacterLookAtData_UnionUnion
	{
		// Token: 0x1700BD9B RID: 48539
		// (get) Token: 0x0602BF32 RID: 180018 RVA: 0x0060A6D9 File Offset: 0x006088D9
		// (set) Token: 0x0602BF33 RID: 180019 RVA: 0x0060A6E1 File Offset: 0x006088E1
		public ICharacterLookAtData_Union Type { get; set; }

		// Token: 0x1700BD9C RID: 48540
		// (get) Token: 0x0602BF34 RID: 180020 RVA: 0x0060A6EA File Offset: 0x006088EA
		// (set) Token: 0x0602BF35 RID: 180021 RVA: 0x0060A6F2 File Offset: 0x006088F2
		public object Value { get; set; }

		// Token: 0x0602BF36 RID: 180022 RVA: 0x0060A6FB File Offset: 0x006088FB
		public ICharacterLookAtData_UnionUnion()
		{
			this.Type = ICharacterLookAtData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BF37 RID: 180023 RVA: 0x0060A711 File Offset: 0x00608911
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BF38 RID: 180024 RVA: 0x0060A723 File Offset: 0x00608923
		public ICharacterLookAtDataT AsICharacterLookAtData()
		{
			return this.As<ICharacterLookAtDataT>();
		}

		// Token: 0x0602BF39 RID: 180025 RVA: 0x0060A72B File Offset: 0x0060892B
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtData(ICharacterLookAtDataT _icharacterlookatdata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtData,
				Value = _icharacterlookatdata
			};
		}

		// Token: 0x0602BF3A RID: 180026 RVA: 0x0060A740 File Offset: 0x00608940
		public ICharacterLookAtEmptyDataT AsICharacterLookAtEmptyData()
		{
			return this.As<ICharacterLookAtEmptyDataT>();
		}

		// Token: 0x0602BF3B RID: 180027 RVA: 0x0060A748 File Offset: 0x00608948
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtEmptyData(ICharacterLookAtEmptyDataT _icharacterlookatemptydata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtEmptyData,
				Value = _icharacterlookatemptydata
			};
		}

		// Token: 0x0602BF3C RID: 180028 RVA: 0x0060A75D File Offset: 0x0060895D
		public ICharacterLookAtEntityDataT AsICharacterLookAtEntityData()
		{
			return this.As<ICharacterLookAtEntityDataT>();
		}

		// Token: 0x0602BF3D RID: 180029 RVA: 0x0060A765 File Offset: 0x00608965
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtEntityData(ICharacterLookAtEntityDataT _icharacterlookatentitydata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtEntityData,
				Value = _icharacterlookatentitydata
			};
		}

		// Token: 0x0602BF3E RID: 180030 RVA: 0x0060A77A File Offset: 0x0060897A
		public ICharacterLookAtPositionDataT AsICharacterLookAtPositionData()
		{
			return this.As<ICharacterLookAtPositionDataT>();
		}

		// Token: 0x0602BF3F RID: 180031 RVA: 0x0060A782 File Offset: 0x00608982
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtPositionData(ICharacterLookAtPositionDataT _icharacterlookatpositiondata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtPositionData,
				Value = _icharacterlookatpositiondata
			};
		}

		// Token: 0x0602BF40 RID: 180032 RVA: 0x0060A797 File Offset: 0x00608997
		public ICharacterLookAtPlayerDataT AsICharacterLookAtPlayerData()
		{
			return this.As<ICharacterLookAtPlayerDataT>();
		}

		// Token: 0x0602BF41 RID: 180033 RVA: 0x0060A79F File Offset: 0x0060899F
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtPlayerData(ICharacterLookAtPlayerDataT _icharacterlookatplayerdata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtPlayerData,
				Value = _icharacterlookatplayerdata
			};
		}

		// Token: 0x0602BF42 RID: 180034 RVA: 0x0060A7B4 File Offset: 0x006089B4
		public ICharacterLookAtUnlockDataT AsICharacterLookAtUnlockData()
		{
			return this.As<ICharacterLookAtUnlockDataT>();
		}

		// Token: 0x0602BF43 RID: 180035 RVA: 0x0060A7BC File Offset: 0x006089BC
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtUnlockData(ICharacterLookAtUnlockDataT _icharacterlookatunlockdata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtUnlockData,
				Value = _icharacterlookatunlockdata
			};
		}

		// Token: 0x0602BF44 RID: 180036 RVA: 0x0060A7D4 File Offset: 0x006089D4
		public static int Pack(FlatBufferBuilder builder, ICharacterLookAtData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ICharacterLookAtData_Union.ICharacterLookAtData:
				return ICharacterLookAtData.Pack(builder, _o.AsICharacterLookAtData()).Value;
			case ICharacterLookAtData_Union.ICharacterLookAtEmptyData:
				return ICharacterLookAtEmptyData.Pack(builder, _o.AsICharacterLookAtEmptyData()).Value;
			case ICharacterLookAtData_Union.ICharacterLookAtEntityData:
				return ICharacterLookAtEntityData.Pack(builder, _o.AsICharacterLookAtEntityData()).Value;
			case ICharacterLookAtData_Union.ICharacterLookAtPositionData:
				return ICharacterLookAtPositionData.Pack(builder, _o.AsICharacterLookAtPositionData()).Value;
			case ICharacterLookAtData_Union.ICharacterLookAtPlayerData:
				return ICharacterLookAtPlayerData.Pack(builder, _o.AsICharacterLookAtPlayerData()).Value;
			case ICharacterLookAtData_Union.ICharacterLookAtUnlockData:
				return ICharacterLookAtUnlockData.Pack(builder, _o.AsICharacterLookAtUnlockData()).Value;
			default:
				return 0;
			}
		}
	}
}
