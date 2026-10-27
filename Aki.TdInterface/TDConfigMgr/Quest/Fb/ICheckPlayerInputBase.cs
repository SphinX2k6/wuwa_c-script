using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020013C5 RID: 5061
	public class ICheckPlayerInputBase
	{
		// Token: 0x06007397 RID: 29591 RVA: 0x0011559D File Offset: 0x0011379D
		[NullableContext(1)]
		public static ICheckPlayerInputBase Create(ICheckPlayerInputBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckPlayerInputBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170025E0 RID: 9696
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x001155BC File Offset: 0x001137BC
		public virtual ECheckPlayerInputType Type
		{
			get
			{
				return (ECheckPlayerInputType)this.Instance.Type;
			}
		}

		// Token: 0x040042EB RID: 17131
		private ICheckPlayerInputBase Instance;
	}
}
