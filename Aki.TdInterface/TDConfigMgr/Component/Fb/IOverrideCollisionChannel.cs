using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE1 RID: 3553
	public class IOverrideCollisionChannel
	{
		// Token: 0x06005088 RID: 20616 RVA: 0x000C7C1A File Offset: 0x000C5E1A
		public static IOverrideCollisionChannel Create(IOverrideCollisionChannel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOverrideCollisionChannel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06005089 RID: 20617 RVA: 0x000C7C3C File Offset: 0x000C5E3C
		public virtual ECollisionChannelPreset? CollisionChannelPreset
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new ECollisionChannelPreset?((ECollisionChannelPreset)this.Instance.CollisionChannelPreset);
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x0600508A RID: 20618 RVA: 0x000C7C74 File Offset: 0x000C5E74
		public virtual float? BlurResponseRadius
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new float?(this.Instance.BlurResponseRadius);
			}
		}

		// Token: 0x04002DE0 RID: 11744
		private IOverrideCollisionChannel Instance;
	}
}
