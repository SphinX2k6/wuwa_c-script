using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CBC RID: 3260
	[NullableContext(2)]
	[Nullable(0)]
	public class IFollowShooterInteractPoint : IExploreSkillInteractType
	{
		// Token: 0x06004A8E RID: 19086 RVA: 0x000BA8FE File Offset: 0x000B8AFE
		[NullableContext(1)]
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

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06004A8F RID: 19087 RVA: 0x000BA91D File Offset: 0x000B8B1D
		public override EExploreSkillInteractType Type
		{
			get
			{
				return (EExploreSkillInteractType)this.Instance.Type;
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x000BA92A File Offset: 0x000B8B2A
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

		// Token: 0x04002A8F RID: 10895
		private IFollowShooterInteractPoint Instance;

		// Token: 0x04002A90 RID: 10896
		private IThrowFollowShooterInteractConfig _ThrowInteractConfigCache;

		// Token: 0x04002A91 RID: 10897
		private bool _ThrowInteractConfigInited;
	}
}
