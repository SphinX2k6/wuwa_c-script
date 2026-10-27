using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA9 RID: 28585
	public class ISetAreaTimeLockT
	{
		// Token: 0x1700D447 RID: 54343
		// (get) Token: 0x06032853 RID: 206931 RVA: 0x006D175D File Offset: 0x006CF95D
		// (set) Token: 0x06032854 RID: 206932 RVA: 0x006D1765 File Offset: 0x006CF965
		public ESetAreaTime Type { get; set; }

		// Token: 0x1700D448 RID: 54344
		// (get) Token: 0x06032855 RID: 206933 RVA: 0x006D176E File Offset: 0x006CF96E
		// (set) Token: 0x06032856 RID: 206934 RVA: 0x006D1776 File Offset: 0x006CF976
		public List<int> AreaIds { get; set; }

		// Token: 0x1700D449 RID: 54345
		// (get) Token: 0x06032857 RID: 206935 RVA: 0x006D177F File Offset: 0x006CF97F
		// (set) Token: 0x06032858 RID: 206936 RVA: 0x006D1787 File Offset: 0x006CF987
		public IFixedTimeT LockTime { get; set; }

		// Token: 0x06032859 RID: 206937 RVA: 0x006D1790 File Offset: 0x006CF990
		public ISetAreaTimeLockT()
		{
			this.Type = ESetAreaTime.Lock;
			this.AreaIds = null;
			this.LockTime = null;
		}
	}
}
