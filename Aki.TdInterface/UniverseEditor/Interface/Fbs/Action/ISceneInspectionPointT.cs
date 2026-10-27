using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F31 RID: 28465
	public class ISceneInspectionPointT
	{
		// Token: 0x1700D395 RID: 54165
		// (get) Token: 0x060324B9 RID: 206009 RVA: 0x006CB1C4 File Offset: 0x006C93C4
		// (set) Token: 0x060324BA RID: 206010 RVA: 0x006CB1CC File Offset: 0x006C93CC
		public IVectorInfoT InteractPointPos { get; set; }

		// Token: 0x1700D396 RID: 54166
		// (get) Token: 0x060324BB RID: 206011 RVA: 0x006CB1D5 File Offset: 0x006C93D5
		// (set) Token: 0x060324BC RID: 206012 RVA: 0x006CB1DD File Offset: 0x006C93DD
		public List<IActionInfoT> ActionList { get; set; }

		// Token: 0x060324BD RID: 206013 RVA: 0x006CB1E6 File Offset: 0x006C93E6
		public ISceneInspectionPointT()
		{
			this.InteractPointPos = null;
			this.ActionList = null;
		}
	}
}
