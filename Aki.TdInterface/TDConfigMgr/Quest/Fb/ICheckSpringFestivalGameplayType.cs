using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001412 RID: 5138
	public class ICheckSpringFestivalGameplayType
	{
		// Token: 0x060074CD RID: 29901 RVA: 0x0011733C File Offset: 0x0011553C
		[NullableContext(1)]
		public static ICheckSpringFestivalGameplayType Create(ICheckSpringFestivalGameplayType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckSpringFestivalGameplayType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x060074CE RID: 29902 RVA: 0x0011735B File Offset: 0x0011555B
		public virtual ESpringFestivalGameplayType Type
		{
			get
			{
				return (ESpringFestivalGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x040043A0 RID: 17312
		private ICheckSpringFestivalGameplayType Instance;
	}
}
