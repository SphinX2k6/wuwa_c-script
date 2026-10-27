using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D93 RID: 3475
	public class INextSlideRail
	{
		// Token: 0x06004F04 RID: 20228 RVA: 0x000C3ECA File Offset: 0x000C20CA
		[NullableContext(1)]
		public static INextSlideRail Create(INextSlideRail? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INextSlideRail
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x000C3EE9 File Offset: 0x000C20E9
		public virtual ETriggerKey TriggerKey
		{
			get
			{
				return (ETriggerKey)this.Instance.TriggerKey;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06004F06 RID: 20230 RVA: 0x000C3EF6 File Offset: 0x000C20F6
		public virtual int TargetRailEntityId
		{
			get
			{
				return this.Instance.TargetRailEntityId;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x000C3F04 File Offset: 0x000C2104
		public virtual bool? IsFallbackRail
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsFallbackRail);
			}
		}

		// Token: 0x04002D6C RID: 11628
		private INextSlideRail Instance;
	}
}
