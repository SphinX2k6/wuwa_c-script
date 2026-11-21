using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D46 RID: 3398
	public class IAirWallWholeSpawnMode : IAirWallSpawnMode
	{
		// Token: 0x06004D61 RID: 19809 RVA: 0x000C13CF File Offset: 0x000BF5CF
		public static IAirWallWholeSpawnMode Create(IAirWallWholeSpawnMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallWholeSpawnMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06004D62 RID: 19810 RVA: 0x000C13EE File Offset: 0x000BF5EE
		public override EAirWallSpawnMode Type
		{
			get
			{
				return (EAirWallSpawnMode)this.Instance.Type;
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x000C13FB File Offset: 0x000BF5FB
		public virtual IAirWallSpawnStyle SpawnStyle
		{
			get
			{
				if (this._SpawnStyleInited)
				{
					return this._SpawnStyleCache;
				}
				this._SpawnStyleInited = true;
				this._SpawnStyleCache = ComponentReadHelper.ReadIAirWallWholeSpawnMode_SpawnStyle(this.Instance);
				return this._SpawnStyleCache;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06004D64 RID: 19812 RVA: 0x000C142A File Offset: 0x000BF62A
		public virtual float Thickness
		{
			get
			{
				return this.Instance.Thickness;
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x000C1437 File Offset: 0x000BF637
		public virtual float Height
		{
			get
			{
				return this.Instance.Height;
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06004D66 RID: 19814 RVA: 0x000C1444 File Offset: 0x000BF644
		public virtual float Depth
		{
			get
			{
				return this.Instance.Depth;
			}
		}

		// Token: 0x04002BEB RID: 11243
		private IAirWallWholeSpawnMode Instance;

		// Token: 0x04002BEC RID: 11244
		private IAirWallSpawnStyle _SpawnStyleCache;

		// Token: 0x04002BED RID: 11245
		private bool _SpawnStyleInited;
	}
}
