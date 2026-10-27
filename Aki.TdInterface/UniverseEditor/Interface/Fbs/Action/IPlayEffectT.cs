using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE5 RID: 27877
	public class IPlayEffectT
	{
		// Token: 0x1700CFA8 RID: 53160
		// (get) Token: 0x06031289 RID: 201353 RVA: 0x006ABA0F File Offset: 0x006A9C0F
		// (set) Token: 0x0603128A RID: 201354 RVA: 0x006ABA17 File Offset: 0x006A9C17
		public string Path { get; set; }

		// Token: 0x1700CFA9 RID: 53161
		// (get) Token: 0x0603128B RID: 201355 RVA: 0x006ABA20 File Offset: 0x006A9C20
		// (set) Token: 0x0603128C RID: 201356 RVA: 0x006ABA28 File Offset: 0x006A9C28
		public TPos2Union Pos2 { get; set; }

		// Token: 0x0603128D RID: 201357 RVA: 0x006ABA31 File Offset: 0x006A9C31
		public IPlayEffectT()
		{
			this.Path = null;
			this.Pos2 = null;
		}
	}
}
