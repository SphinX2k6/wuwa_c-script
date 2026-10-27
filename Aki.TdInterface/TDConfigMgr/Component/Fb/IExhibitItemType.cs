using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD4 RID: 3540
	public class IExhibitItemType
	{
		// Token: 0x06005053 RID: 20563 RVA: 0x000C6806 File Offset: 0x000C4A06
		[NullableContext(1)]
		public static IExhibitItemType Create(IExhibitItemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExhibitItemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06005054 RID: 20564 RVA: 0x000C6825 File Offset: 0x000C4A25
		public virtual EExhibitItemType Type
		{
			get
			{
				return (EExhibitItemType)this.Instance.Type;
			}
		}

		// Token: 0x04002E19 RID: 11801
		private IExhibitItemType Instance;
	}
}
