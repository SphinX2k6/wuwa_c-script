using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D9E RID: 3486
	[NullableContext(2)]
	[Nullable(0)]
	public class IFollowShooterInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004F3C RID: 20284 RVA: 0x000C530E File Offset: 0x000C350E
		[NullableContext(0)]
		public static IFollowShooterInteractPoint Create(IFollowShooterInteractPoint? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFollowShooterInteractPoint
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x000C532D File Offset: 0x000C352D
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x06004F3E RID: 20286 RVA: 0x000C533A File Offset: 0x000C353A
		public virtual IThrowFollowShooterInteractConfig ThrowInteractConfig
		{
			get
			{
				if (this._ThrowInteractConfigInited)
				{
					return this._ThrowInteractConfigCache;
				}
				this._ThrowInteractConfigInited = true;
				this._ThrowInteractConfigCache = IThrowFollowShooterInteractConfig.Create(this.Instance.ThrowInteractConfig);
				return this._ThrowInteractConfigCache;
			}
		}

		// Token: 0x04002D09 RID: 11529
		private IFollowShooterInteractPoint Instance;

		// Token: 0x04002D0A RID: 11530
		private IThrowFollowShooterInteractConfig _ThrowInteractConfigCache;

		// Token: 0x04002D0B RID: 11531
		private bool _ThrowInteractConfigInited;
	}
}
