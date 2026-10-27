using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02005B00 RID: 23296
	public class CookingData : ICookingData, ICookItemData
	{
		// Token: 0x17008C50 RID: 35920
		// (get) Token: 0x0603AFBE RID: 241598 RVA: 0x00E10F29 File Offset: 0x00E0F129
		// (set) Token: 0x0603AFBF RID: 241599 RVA: 0x00E10F31 File Offset: 0x00E0F131
		public ECookListType MainType { get; set; }

		// Token: 0x17008C51 RID: 35921
		// (get) Token: 0x0603AFC0 RID: 241600 RVA: 0x00E10F3A File Offset: 0x00E0F13A
		// (set) Token: 0x0603AFC1 RID: 241601 RVA: 0x00E10F42 File Offset: 0x00E0F142
		public int ItemId { get; set; }

		// Token: 0x17008C52 RID: 35922
		// (get) Token: 0x0603AFC2 RID: 241602 RVA: 0x00E10F4B File Offset: 0x00E0F14B
		// (set) Token: 0x0603AFC3 RID: 241603 RVA: 0x00E10F53 File Offset: 0x00E0F153
		public bool IsNew { get; set; }

		// Token: 0x17008C53 RID: 35923
		// (get) Token: 0x0603AFC4 RID: 241604 RVA: 0x00E10F5C File Offset: 0x00E0F15C
		// (set) Token: 0x0603AFC5 RID: 241605 RVA: 0x00E10F64 File Offset: 0x00E0F164
		public int Quality { get; set; }

		// Token: 0x17008C54 RID: 35924
		// (get) Token: 0x0603AFC6 RID: 241606 RVA: 0x00E10F6D File Offset: 0x00E0F16D
		// (set) Token: 0x0603AFC7 RID: 241607 RVA: 0x00E10F75 File Offset: 0x00E0F175
		public bool IsUnLock { get; set; }

		// Token: 0x17008C55 RID: 35925
		// (get) Token: 0x0603AFC8 RID: 241608 RVA: 0x00E10F7E File Offset: 0x00E0F17E
		// (set) Token: 0x0603AFC9 RID: 241609 RVA: 0x00E10F86 File Offset: 0x00E0F186
		public ESubCookDataType SubType { get; set; }

		// Token: 0x17008C56 RID: 35926
		// (get) Token: 0x0603AFCA RID: 241610 RVA: 0x00E10F8F File Offset: 0x00E0F18F
		// (set) Token: 0x0603AFCB RID: 241611 RVA: 0x00E10F97 File Offset: 0x00E0F197
		public int UniqueId { get; set; }

		// Token: 0x17008C57 RID: 35927
		// (get) Token: 0x0603AFCC RID: 241612 RVA: 0x00E10FA0 File Offset: 0x00E0F1A0
		// (set) Token: 0x0603AFCD RID: 241613 RVA: 0x00E10FA8 File Offset: 0x00E0F1A8
		public int CookCount { get; set; }

		// Token: 0x17008C58 RID: 35928
		// (get) Token: 0x0603AFCE RID: 241614 RVA: 0x00E10FB1 File Offset: 0x00E0F1B1
		// (set) Token: 0x0603AFCF RID: 241615 RVA: 0x00E10FB9 File Offset: 0x00E0F1B9
		public int? LastRoleId { get; set; }

		// Token: 0x17008C59 RID: 35929
		// (get) Token: 0x0603AFD0 RID: 241616 RVA: 0x00E10FC2 File Offset: 0x00E0F1C2
		// (set) Token: 0x0603AFD1 RID: 241617 RVA: 0x00E10FCA File Offset: 0x00E0F1CA
		public int IsCook { get; set; }

		// Token: 0x17008C5A RID: 35930
		// (get) Token: 0x0603AFD2 RID: 241618 RVA: 0x00E10FD3 File Offset: 0x00E0F1D3
		// (set) Token: 0x0603AFD3 RID: 241619 RVA: 0x00E10FDB File Offset: 0x00E0F1DB
		public int EffectType { get; set; }

		// Token: 0x17008C5B RID: 35931
		// (get) Token: 0x0603AFD4 RID: 241620 RVA: 0x00E10FE4 File Offset: 0x00E0F1E4
		// (set) Token: 0x0603AFD5 RID: 241621 RVA: 0x00E10FEC File Offset: 0x00E0F1EC
		public int DataId { get; set; }

		// Token: 0x17008C5C RID: 35932
		// (get) Token: 0x0603AFD6 RID: 241622 RVA: 0x00E10FF5 File Offset: 0x00E0F1F5
		// (set) Token: 0x0603AFD7 RID: 241623 RVA: 0x00E10FFD File Offset: 0x00E0F1FD
		public int LimitTotalCount { get; set; }

		// Token: 0x17008C5D RID: 35933
		// (get) Token: 0x0603AFD8 RID: 241624 RVA: 0x00E11006 File Offset: 0x00E0F206
		// (set) Token: 0x0603AFD9 RID: 241625 RVA: 0x00E1100E File Offset: 0x00E0F20E
		public int LimitedCount { get; set; }

		// Token: 0x17008C5E RID: 35934
		// (get) Token: 0x0603AFDA RID: 241626 RVA: 0x00E11017 File Offset: 0x00E0F217
		// (set) Token: 0x0603AFDB RID: 241627 RVA: 0x00E1101F File Offset: 0x00E0F21F
		public double ExistStartTime { get; set; }

		// Token: 0x17008C5F RID: 35935
		// (get) Token: 0x0603AFDC RID: 241628 RVA: 0x00E11028 File Offset: 0x00E0F228
		// (set) Token: 0x0603AFDD RID: 241629 RVA: 0x00E11030 File Offset: 0x00E0F230
		public double ExistEndTime { get; set; }
	}
}
