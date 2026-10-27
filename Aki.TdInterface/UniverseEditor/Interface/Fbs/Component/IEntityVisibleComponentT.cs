using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051C6 RID: 20934
	public class IEntityVisibleComponentT
	{
		// Token: 0x1700992D RID: 39213
		// (get) Token: 0x06021EF0 RID: 138992 RVA: 0x004B533D File Offset: 0x004B353D
		// (set) Token: 0x06021EF1 RID: 138993 RVA: 0x004B5345 File Offset: 0x004B3545
		public bool Disabled { get; set; }

		// Token: 0x1700992E RID: 39214
		// (get) Token: 0x06021EF2 RID: 138994 RVA: 0x004B534E File Offset: 0x004B354E
		// (set) Token: 0x06021EF3 RID: 138995 RVA: 0x004B5356 File Offset: 0x004B3556
		public bool DelayChange { get; set; }

		// Token: 0x1700992F RID: 39215
		// (get) Token: 0x06021EF4 RID: 138996 RVA: 0x004B535F File Offset: 0x004B355F
		// (set) Token: 0x06021EF5 RID: 138997 RVA: 0x004B5367 File Offset: 0x004B3567
		public bool UseFadeEffect { get; set; }

		// Token: 0x17009930 RID: 39216
		// (get) Token: 0x06021EF6 RID: 138998 RVA: 0x004B5370 File Offset: 0x004B3570
		// (set) Token: 0x06021EF7 RID: 138999 RVA: 0x004B5378 File Offset: 0x004B3578
		public bool UseCutEffect { get; set; }

		// Token: 0x17009931 RID: 39217
		// (get) Token: 0x06021EF8 RID: 139000 RVA: 0x004B5381 File Offset: 0x004B3581
		// (set) Token: 0x06021EF9 RID: 139001 RVA: 0x004B5389 File Offset: 0x004B3589
		public bool UseHolographicEffect { get; set; }

		// Token: 0x17009932 RID: 39218
		// (get) Token: 0x06021EFA RID: 139002 RVA: 0x004B5392 File Offset: 0x004B3592
		// (set) Token: 0x06021EFB RID: 139003 RVA: 0x004B539A File Offset: 0x004B359A
		public List<IVisibleConditionGroupT> VisibleConditions { get; set; }

		// Token: 0x17009933 RID: 39219
		// (get) Token: 0x06021EFC RID: 139004 RVA: 0x004B53A3 File Offset: 0x004B35A3
		// (set) Token: 0x06021EFD RID: 139005 RVA: 0x004B53AB File Offset: 0x004B35AB
		public int CustomVisibleRange { get; set; }

		// Token: 0x17009934 RID: 39220
		// (get) Token: 0x06021EFE RID: 139006 RVA: 0x004B53B4 File Offset: 0x004B35B4
		// (set) Token: 0x06021EFF RID: 139007 RVA: 0x004B53BC File Offset: 0x004B35BC
		public ERuntimePlatformOptions TargetPlatform { get; set; }

		// Token: 0x17009935 RID: 39221
		// (get) Token: 0x06021F00 RID: 139008 RVA: 0x004B53C5 File Offset: 0x004B35C5
		// (set) Token: 0x06021F01 RID: 139009 RVA: 0x004B53CD File Offset: 0x004B35CD
		public byte NullMask { get; set; }

		// Token: 0x06021F02 RID: 139010 RVA: 0x004B53D8 File Offset: 0x004B35D8
		public IEntityVisibleComponentT()
		{
			this.Disabled = false;
			this.DelayChange = false;
			this.UseFadeEffect = false;
			this.UseCutEffect = false;
			this.UseHolographicEffect = false;
			this.VisibleConditions = null;
			this.CustomVisibleRange = 0;
			this.TargetPlatform = ERuntimePlatformOptions.None;
			this.NullMask = 0;
		}
	}
}
