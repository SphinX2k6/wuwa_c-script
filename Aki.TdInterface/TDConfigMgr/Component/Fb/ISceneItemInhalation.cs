using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D60 RID: 3424
	public class ISceneItemInhalation : IInhalationPerformanceType
	{
		// Token: 0x06004DFE RID: 19966 RVA: 0x000C1C4D File Offset: 0x000BFE4D
		[NullableContext(1)]
		public static ISceneItemInhalation Create(ISceneItemInhalation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemInhalation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06004DFF RID: 19967 RVA: 0x000C1C6C File Offset: 0x000BFE6C
		public override EInhalationPerformanceType Type
		{
			get
			{
				return (EInhalationPerformanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002CB5 RID: 11445
		private ISceneItemInhalation Instance;
	}
}
