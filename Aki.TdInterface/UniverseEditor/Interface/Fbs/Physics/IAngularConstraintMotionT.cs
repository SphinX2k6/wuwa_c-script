using System;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004346 RID: 17222
	public class IAngularConstraintMotionT
	{
		// Token: 0x17007997 RID: 31127
		// (get) Token: 0x0601988F RID: 104591 RVA: 0x003A7E26 File Offset: 0x003A6026
		// (set) Token: 0x06019890 RID: 104592 RVA: 0x003A7E2E File Offset: 0x003A602E
		public EAngularConstraintMotion Type { get; set; }

		// Token: 0x06019891 RID: 104593 RVA: 0x003A7E37 File Offset: 0x003A6037
		public IAngularConstraintMotionT()
		{
			this.Type = EAngularConstraintMotion.ACM_Free;
		}
	}
}
