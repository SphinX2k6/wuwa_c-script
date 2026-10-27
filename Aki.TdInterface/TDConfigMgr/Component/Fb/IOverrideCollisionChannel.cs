using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE9 RID: 3305
	public class IOverrideCollisionChannel
	{
		// Token: 0x06004B7B RID: 19323 RVA: 0x000BC766 File Offset: 0x000BA966
		[NullableContext(1)]
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

		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x000BC788 File Offset: 0x000BA988
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

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06004B7D RID: 19325 RVA: 0x000BC7C0 File Offset: 0x000BA9C0
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

		// Token: 0x04002B28 RID: 11048
		private IOverrideCollisionChannel Instance;
	}
}
