using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DAC RID: 3500
	public class DynamicSpawnMonsterPointComponent : IComponentBase
	{
		// Token: 0x06004F84 RID: 20356 RVA: 0x000C4EA5 File Offset: 0x000C30A5
		[NullableContext(1)]
		public static DynamicSpawnMonsterPointComponent Create(IDynamicSpawnMonsterPointComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DynamicSpawnMonsterPointComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170019E9 RID: 6633
		// (get) Token: 0x06004F85 RID: 20357 RVA: 0x000C4EC4 File Offset: 0x000C30C4
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x170019EA RID: 6634
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x000C4EFC File Offset: 0x000C30FC
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019EB RID: 6635
		// (get) Token: 0x06004F87 RID: 20359 RVA: 0x000C4F14 File Offset: 0x000C3114
		public virtual int? TagId
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.TagId);
			}
		}

		// Token: 0x04002DA1 RID: 11681
		private IDynamicSpawnMonsterPointComponent Instance;
	}
}
