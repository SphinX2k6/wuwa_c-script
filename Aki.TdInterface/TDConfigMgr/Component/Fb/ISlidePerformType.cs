using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D96 RID: 3478
	public class ISlidePerformType
	{
		// Token: 0x06004F17 RID: 20247 RVA: 0x000C41EB File Offset: 0x000C23EB
		[NullableContext(1)]
		public static ISlidePerformType Create(ISlidePerformType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlidePerformType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06004F18 RID: 20248 RVA: 0x000C420A File Offset: 0x000C240A
		public virtual ESlidePerformType Type
		{
			get
			{
				return (ESlidePerformType)this.Instance.Type;
			}
		}

		// Token: 0x04002D73 RID: 11635
		private ISlidePerformType Instance;
	}
}
