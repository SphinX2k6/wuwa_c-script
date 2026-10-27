using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC1 RID: 3521
	public class ILookAtTargetBase
	{
		// Token: 0x06004FE8 RID: 20456 RVA: 0x000C5A3F File Offset: 0x000C3C3F
		[NullableContext(1)]
		public static ILookAtTargetBase Create(ILookAtTargetBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x000C5A5E File Offset: 0x000C3C5E
		public virtual ELookAtTargetType Type
		{
			get
			{
				return (ELookAtTargetType)this.Instance.Type;
			}
		}

		// Token: 0x04002DD4 RID: 11732
		private ILookAtTargetBase Instance;
	}
}
