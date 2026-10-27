using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE8 RID: 27880
	public class IPlayEffect2T
	{
		// Token: 0x1700CFAD RID: 53165
		// (get) Token: 0x060312A1 RID: 201377 RVA: 0x006ABC73 File Offset: 0x006A9E73
		// (set) Token: 0x060312A2 RID: 201378 RVA: 0x006ABC7B File Offset: 0x006A9E7B
		public EEffectType Type { get; set; }

		// Token: 0x1700CFAE RID: 53166
		// (get) Token: 0x060312A3 RID: 201379 RVA: 0x006ABC84 File Offset: 0x006A9E84
		// (set) Token: 0x060312A4 RID: 201380 RVA: 0x006ABC8C File Offset: 0x006A9E8C
		public string Path { get; set; }

		// Token: 0x060312A5 RID: 201381 RVA: 0x006ABC95 File Offset: 0x006A9E95
		public IPlayEffect2T()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
		}
	}
}
