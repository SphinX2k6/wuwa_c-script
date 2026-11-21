using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B45 RID: 11077
	public class IPlayPianoGameplay : IUiGame
	{
		// Token: 0x0600F38E RID: 62350 RVA: 0x00238904 File Offset: 0x00236B04
		public static IPlayPianoGameplay Create(IPlayPianoGameplay? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayPianoGameplay
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x0600F38F RID: 62351 RVA: 0x00238923 File Offset: 0x00236B23
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x0600F390 RID: 62352 RVA: 0x00238930 File Offset: 0x00236B30
		public virtual int SplineEntityId
		{
			get
			{
				return this.Instance.SplineEntityId;
			}
		}

		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x0600F391 RID: 62353 RVA: 0x0023893D File Offset: 0x00236B3D
		public virtual int RangeEntityId
		{
			get
			{
				return this.Instance.RangeEntityId;
			}
		}

		// Token: 0x04008595 RID: 34197
		private IPlayPianoGameplay Instance;
	}
}
