using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B2 RID: 27058
	public class ICharacterLookAtData_UnionUnion
	{
		// Token: 0x1700C723 RID: 50979
		// (get) Token: 0x0602E69C RID: 190108 RVA: 0x0065582D File Offset: 0x00653A2D
		// (set) Token: 0x0602E69D RID: 190109 RVA: 0x00655835 File Offset: 0x00653A35
		public ICharacterLookAtData_Union Type { get; set; }

		// Token: 0x1700C724 RID: 50980
		// (get) Token: 0x0602E69E RID: 190110 RVA: 0x0065583E File Offset: 0x00653A3E
		// (set) Token: 0x0602E69F RID: 190111 RVA: 0x00655846 File Offset: 0x00653A46
		public object Value { get; set; }

		// Token: 0x0602E6A0 RID: 190112 RVA: 0x0065584F File Offset: 0x00653A4F
		public ICharacterLookAtData_UnionUnion()
		{
			this.Type = ICharacterLookAtData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E6A1 RID: 190113 RVA: 0x00655865 File Offset: 0x00653A65
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E6A2 RID: 190114 RVA: 0x00655877 File Offset: 0x00653A77
		public ICharacterLookAtDataT AsICharacterLookAtData()
		{
			return this.As<ICharacterLookAtDataT>();
		}

		// Token: 0x0602E6A3 RID: 190115 RVA: 0x0065587F File Offset: 0x00653A7F
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtData(ICharacterLookAtDataT _icharacterlookatdata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtData,
				Value = _icharacterlookatdata
			};
		}

		// Token: 0x0602E6A4 RID: 190116 RVA: 0x00655894 File Offset: 0x00653A94
		public ICharacterLookAtEmptyDataT AsICharacterLookAtEmptyData()
		{
			return this.As<ICharacterLookAtEmptyDataT>();
		}

		// Token: 0x0602E6A5 RID: 190117 RVA: 0x0065589C File Offset: 0x00653A9C
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtEmptyData(ICharacterLookAtEmptyDataT _icharacterlookatemptydata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtEmptyData,
				Value = _icharacterlookatemptydata
			};
		}

		// Token: 0x0602E6A6 RID: 190118 RVA: 0x006558B1 File Offset: 0x00653AB1
		public ICharacterLookAtEntityDataT AsICharacterLookAtEntityData()
		{
			return this.As<ICharacterLookAtEntityDataT>();
		}

		// Token: 0x0602E6A7 RID: 190119 RVA: 0x006558B9 File Offset: 0x00653AB9
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtEntityData(ICharacterLookAtEntityDataT _icharacterlookatentitydata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtEntityData,
				Value = _icharacterlookatentitydata
			};
		}

		// Token: 0x0602E6A8 RID: 190120 RVA: 0x006558CE File Offset: 0x00653ACE
		public ICharacterLookAtPositionDataT AsICharacterLookAtPositionData()
		{
			return this.As<ICharacterLookAtPositionDataT>();
		}

		// Token: 0x0602E6A9 RID: 190121 RVA: 0x006558D6 File Offset: 0x00653AD6
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtPositionData(ICharacterLookAtPositionDataT _icharacterlookatpositiondata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtPositionData,
				Value = _icharacterlookatpositiondata
			};
		}

		// Token: 0x0602E6AA RID: 190122 RVA: 0x006558EB File Offset: 0x00653AEB
		public ICharacterLookAtPlayerDataT AsICharacterLookAtPlayerData()
		{
			return this.As<ICharacterLookAtPlayerDataT>();
		}

		// Token: 0x0602E6AB RID: 190123 RVA: 0x006558F3 File Offset: 0x00653AF3
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtPlayerData(ICharacterLookAtPlayerDataT _icharacterlookatplayerdata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtPlayerData,
				Value = _icharacterlookatplayerdata
			};
		}

		// Token: 0x0602E6AC RID: 190124 RVA: 0x00655908 File Offset: 0x00653B08
		public ICharacterLookAtUnlockDataT AsICharacterLookAtUnlockData()
		{
			return this.As<ICharacterLookAtUnlockDataT>();
		}

		// Token: 0x0602E6AD RID: 190125 RVA: 0x00655910 File Offset: 0x00653B10
		public static ICharacterLookAtData_UnionUnion FromICharacterLookAtUnlockData(ICharacterLookAtUnlockDataT _icharacterlookatunlockdata)
		{
			return new ICharacterLookAtData_UnionUnion
			{
				Type = ICharacterLookAtData_Union.ICharacterLookAtUnlockData,
				Value = _icharacterlookatunlockdata
			};
		}

		// Token: 0x0602E6AE RID: 190126 RVA: 0x00655928 File Offset: 0x00653B28
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
