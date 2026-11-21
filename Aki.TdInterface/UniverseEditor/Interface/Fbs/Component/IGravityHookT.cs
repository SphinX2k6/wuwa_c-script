using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058B1 RID: 22705
	public class IGravityHookT
	{
		// Token: 0x1700A497 RID: 42135
		// (get) Token: 0x06024D94 RID: 150932 RVA: 0x0050F90D File Offset: 0x0050DB0D
		// (set) Token: 0x06024D95 RID: 150933 RVA: 0x0050F915 File Offset: 0x0050DB15
		public EHookInteractType Type { get; set; }

		// Token: 0x1700A498 RID: 42136
		// (get) Token: 0x06024D96 RID: 150934 RVA: 0x0050F91E File Offset: 0x0050DB1E
		// (set) Token: 0x06024D97 RID: 150935 RVA: 0x0050F926 File Offset: 0x0050DB26
		public List<IActionInfoT> HookActions { get; set; }

		// Token: 0x1700A499 RID: 42137
		// (get) Token: 0x06024D98 RID: 150936 RVA: 0x0050F92F File Offset: 0x0050DB2F
		// (set) Token: 0x06024D99 RID: 150937 RVA: 0x0050F937 File Offset: 0x0050DB37
		public List<IActionInfoT> ExitHookActions { get; set; }

		// Token: 0x1700A49A RID: 42138
		// (get) Token: 0x06024D9A RID: 150938 RVA: 0x0050F940 File Offset: 0x0050DB40
		// (set) Token: 0x06024D9B RID: 150939 RVA: 0x0050F948 File Offset: 0x0050DB48
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x1700A49B RID: 42139
		// (get) Token: 0x06024D9C RID: 150940 RVA: 0x0050F951 File Offset: 0x0050DB51
		// (set) Token: 0x06024D9D RID: 150941 RVA: 0x0050F959 File Offset: 0x0050DB59
		public IClientHookActionConfigT ClientHookActionConfig { get; set; }

		// Token: 0x1700A49C RID: 42140
		// (get) Token: 0x06024D9E RID: 150942 RVA: 0x0050F962 File Offset: 0x0050DB62
		// (set) Token: 0x06024D9F RID: 150943 RVA: 0x0050F96A File Offset: 0x0050DB6A
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700A49D RID: 42141
		// (get) Token: 0x06024DA0 RID: 150944 RVA: 0x0050F973 File Offset: 0x0050DB73
		// (set) Token: 0x06024DA1 RID: 150945 RVA: 0x0050F97B File Offset: 0x0050DB7B
		public int SafePointId { get; set; }

		// Token: 0x1700A49E RID: 42142
		// (get) Token: 0x06024DA2 RID: 150946 RVA: 0x0050F984 File Offset: 0x0050DB84
		// (set) Token: 0x06024DA3 RID: 150947 RVA: 0x0050F98C File Offset: 0x0050DB8C
		public int CameraLookAtPointId { get; set; }

		// Token: 0x1700A49F RID: 42143
		// (get) Token: 0x06024DA4 RID: 150948 RVA: 0x0050F995 File Offset: 0x0050DB95
		// (set) Token: 0x06024DA5 RID: 150949 RVA: 0x0050F99D File Offset: 0x0050DB9D
		public byte NullMask { get; set; }

		// Token: 0x06024DA6 RID: 150950 RVA: 0x0050F9A8 File Offset: 0x0050DBA8
		public IGravityHookT()
		{
			this.Type = EHookInteractType.FixedPointHook;
			this.HookActions = null;
			this.ExitHookActions = null;
			this.FinishActions = null;
			this.ClientHookActionConfig = null;
			this.GravityDirection = null;
			this.SafePointId = 0;
			this.CameraLookAtPointId = 0;
			this.NullMask = 0;
		}
	}
}
