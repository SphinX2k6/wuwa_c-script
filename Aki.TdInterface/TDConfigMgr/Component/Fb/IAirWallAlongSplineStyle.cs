using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D43 RID: 3395
	[NullableContext(2)]
	[Nullable(0)]
	public class IAirWallAlongSplineStyle : IAirWallSpawnStyle
	{
		// Token: 0x06004D55 RID: 19797 RVA: 0x000C12E5 File Offset: 0x000BF4E5
		[NullableContext(0)]
		public static IAirWallAlongSplineStyle Create(IAirWallAlongSplineStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAirWallAlongSplineStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06004D56 RID: 19798 RVA: 0x000C1304 File Offset: 0x000BF504
		public override EAirWallSpawnStyle Type
		{
			get
			{
				return (EAirWallSpawnStyle)this.Instance.Type;
			}
		}

		// Token: 0x170016CB RID: 5835
		// (get) Token: 0x06004D57 RID: 19799 RVA: 0x000C1311 File Offset: 0x000BF511
		public virtual EAirWallAlignType AlignType
		{
			get
			{
				return (EAirWallAlignType)this.Instance.AlignType;
			}
		}

		// Token: 0x170016CC RID: 5836
		// (get) Token: 0x06004D58 RID: 19800 RVA: 0x000C131E File Offset: 0x000BF51E
		public virtual IAirWallCover Cover
		{
			get
			{
				if (this._CoverInited)
				{
					return this._CoverCache;
				}
				this._CoverInited = true;
				this._CoverCache = IAirWallCover.Create(this.Instance.Cover);
				return this._CoverCache;
			}
		}

		// Token: 0x04002BE6 RID: 11238
		private IAirWallAlongSplineStyle Instance;

		// Token: 0x04002BE7 RID: 11239
		private IAirWallCover _CoverCache;

		// Token: 0x04002BE8 RID: 11240
		private bool _CoverInited;
	}
}
