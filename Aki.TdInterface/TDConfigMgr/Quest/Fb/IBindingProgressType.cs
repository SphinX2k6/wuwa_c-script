using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001337 RID: 4919
	public class IBindingProgressType
	{
		// Token: 0x060070C0 RID: 28864 RVA: 0x0011002F File Offset: 0x0010E22F
		[NullableContext(1)]
		public static IBindingProgressType Create(IBindingProgressType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBindingProgressType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17002425 RID: 9253
		// (get) Token: 0x060070C1 RID: 28865 RVA: 0x0011004E File Offset: 0x0010E24E
		public virtual EBindingProgressType Type
		{
			get
			{
				return (EBindingProgressType)this.Instance.Type;
			}
		}

		// Token: 0x0400410D RID: 16653
		private IBindingProgressType Instance;
	}
}
