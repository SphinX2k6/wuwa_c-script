using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005919 RID: 22809
	public class IHitLogicChangeCountDownStateT
	{
		// Token: 0x1700A572 RID: 42354
		// (get) Token: 0x06025158 RID: 151896 RVA: 0x005170C6 File Offset: 0x005152C6
		// (set) Token: 0x06025159 RID: 151897 RVA: 0x005170CE File Offset: 0x005152CE
		public EHitLogicType Type { get; set; }

		// Token: 0x0602515A RID: 151898 RVA: 0x005170D7 File Offset: 0x005152D7
		public IHitLogicChangeCountDownStateT()
		{
			this.Type = EHitLogicType.ChangeNextState;
		}
	}
}
