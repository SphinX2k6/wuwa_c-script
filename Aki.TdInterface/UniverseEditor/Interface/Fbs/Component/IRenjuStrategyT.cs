using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200585C RID: 22620
	public class IRenjuStrategyT
	{
		// Token: 0x1700A913 RID: 43283
		// (get) Token: 0x06026155 RID: 155989 RVA: 0x00540181 File Offset: 0x0053E381
		// (set) Token: 0x06026156 RID: 155990 RVA: 0x00540189 File Offset: 0x0053E389
		public EAiGearStrategy Type { get; set; }

		// Token: 0x1700A914 RID: 43284
		// (get) Token: 0x06026157 RID: 155991 RVA: 0x00540192 File Offset: 0x0053E392
		// (set) Token: 0x06026158 RID: 155992 RVA: 0x0054019A File Offset: 0x0053E39A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700A915 RID: 43285
		// (get) Token: 0x06026159 RID: 155993 RVA: 0x005401A3 File Offset: 0x0053E3A3
		// (set) Token: 0x0602615A RID: 155994 RVA: 0x005401AB File Offset: 0x0053E3AB
		public int Chessboard { get; set; }

		// Token: 0x1700A916 RID: 43286
		// (get) Token: 0x0602615B RID: 155995 RVA: 0x005401B4 File Offset: 0x0053E3B4
		// (set) Token: 0x0602615C RID: 155996 RVA: 0x005401BC File Offset: 0x0053E3BC
		public string CommonConfig { get; set; }

		// Token: 0x1700A917 RID: 43287
		// (get) Token: 0x0602615D RID: 155997 RVA: 0x005401C5 File Offset: 0x0053E3C5
		// (set) Token: 0x0602615E RID: 155998 RVA: 0x005401CD File Offset: 0x0053E3CD
		public byte NullMask { get; set; }

		// Token: 0x0602615F RID: 155999 RVA: 0x005401D6 File Offset: 0x0053E3D6
		public IRenjuStrategyT()
		{
			this.Type = EAiGearStrategy.RenjuStrategy;
			this.Condition = null;
			this.Chessboard = 0;
			this.CommonConfig = null;
			this.NullMask = 0;
		}
	}
}
