using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006796 RID: 26518
	public class IFadeOutScreenT
	{
		// Token: 0x1700C4DB RID: 50395
		// (get) Token: 0x0602E24E RID: 189006 RVA: 0x0064D8CD File Offset: 0x0064BACD
		// (set) Token: 0x0602E24F RID: 189007 RVA: 0x0064D8D5 File Offset: 0x0064BAD5
		public IEaseDataT Ease { get; set; }

		// Token: 0x1700C4DC RID: 50396
		// (get) Token: 0x0602E250 RID: 189008 RVA: 0x0064D8DE File Offset: 0x0064BADE
		// (set) Token: 0x0602E251 RID: 189009 RVA: 0x0064D8E6 File Offset: 0x0064BAE6
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700C4DD RID: 50397
		// (get) Token: 0x0602E252 RID: 189010 RVA: 0x0064D8EF File Offset: 0x0064BAEF
		// (set) Token: 0x0602E253 RID: 189011 RVA: 0x0064D8F7 File Offset: 0x0064BAF7
		public byte NullMask { get; set; }

		// Token: 0x0602E254 RID: 189012 RVA: 0x0064D900 File Offset: 0x0064BB00
		public IFadeOutScreenT()
		{
			this.Ease = null;
			this.OnlyLowMemoryDeviceExecute = false;
			this.NullMask = 0;
		}
	}
}
