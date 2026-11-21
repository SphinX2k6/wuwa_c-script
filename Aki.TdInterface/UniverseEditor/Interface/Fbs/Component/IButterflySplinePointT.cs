using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005479 RID: 21625
	public class IButterflySplinePointT
	{
		// Token: 0x170099CC RID: 39372
		// (get) Token: 0x06021FAB RID: 139179 RVA: 0x004AF0F3 File Offset: 0x004AD2F3
		// (set) Token: 0x06021FAC RID: 139180 RVA: 0x004AF0FB File Offset: 0x004AD2FB
		public IVectorInfoT Position { get; set; }

		// Token: 0x170099CD RID: 39373
		// (get) Token: 0x06021FAD RID: 139181 RVA: 0x004AF104 File Offset: 0x004AD304
		// (set) Token: 0x06021FAE RID: 139182 RVA: 0x004AF10C File Offset: 0x004AD30C
		public IVectorInfoT ArriveTangent { get; set; }

		// Token: 0x170099CE RID: 39374
		// (get) Token: 0x06021FAF RID: 139183 RVA: 0x004AF115 File Offset: 0x004AD315
		// (set) Token: 0x06021FB0 RID: 139184 RVA: 0x004AF11D File Offset: 0x004AD31D
		public IVectorInfoT LeaveTangent { get; set; }

		// Token: 0x170099CF RID: 39375
		// (get) Token: 0x06021FB1 RID: 139185 RVA: 0x004AF126 File Offset: 0x004AD326
		// (set) Token: 0x06021FB2 RID: 139186 RVA: 0x004AF12E File Offset: 0x004AD32E
		public ESplineLine LineType { get; set; }

		// Token: 0x170099D0 RID: 39376
		// (get) Token: 0x06021FB3 RID: 139187 RVA: 0x004AF137 File Offset: 0x004AD337
		// (set) Token: 0x06021FB4 RID: 139188 RVA: 0x004AF13F File Offset: 0x004AD33F
		public IVectorInfoT Rotation { get; set; }

		// Token: 0x170099D1 RID: 39377
		// (get) Token: 0x06021FB5 RID: 139189 RVA: 0x004AF148 File Offset: 0x004AD348
		// (set) Token: 0x06021FB6 RID: 139190 RVA: 0x004AF150 File Offset: 0x004AD350
		public int MoveSpeed { get; set; }

		// Token: 0x170099D2 RID: 39378
		// (get) Token: 0x06021FB7 RID: 139191 RVA: 0x004AF159 File Offset: 0x004AD359
		// (set) Token: 0x06021FB8 RID: 139192 RVA: 0x004AF161 File Offset: 0x004AD361
		public bool IgnorePoint { get; set; }

		// Token: 0x06021FB9 RID: 139193 RVA: 0x004AF16A File Offset: 0x004AD36A
		public IButterflySplinePointT()
		{
			this.Position = null;
			this.ArriveTangent = null;
			this.LeaveTangent = null;
			this.LineType = ESplineLine.Linear;
			this.Rotation = null;
			this.MoveSpeed = 0;
			this.IgnorePoint = false;
		}
	}
}
