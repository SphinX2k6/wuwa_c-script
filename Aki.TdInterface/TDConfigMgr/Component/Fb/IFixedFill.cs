using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C89 RID: 3209
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedFill : IFillType
	{
		// Token: 0x0600496C RID: 18796 RVA: 0x000B80EB File Offset: 0x000B62EB
		public static IFixedFill Create(IFixedFill? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedFill
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600496D RID: 18797 RVA: 0x000B810A File Offset: 0x000B630A
		public override EFillType Type
		{
			get
			{
				return (EFillType)this.Instance.Type;
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x000B8118 File Offset: 0x000B6318
		public virtual int? ModelId
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.ModelId);
			}
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x0600496F RID: 18799 RVA: 0x000B814E File Offset: 0x000B634E
		public virtual IPieceIndex Centre
		{
			get
			{
				if (this._CentreInited)
				{
					return this._CentreCache;
				}
				this._CentreInited = true;
				this._CentreCache = IPieceIndex.Create(this.Instance.Centre);
				return this._CentreCache;
			}
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x000B8182 File Offset: 0x000B6382
		public virtual IJigsawConfig Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				this._ConfigCache = IJigsawConfig.Create(this.Instance.Config);
				return this._ConfigCache;
			}
		}

		// Token: 0x040029E0 RID: 10720
		private IFixedFill Instance;

		// Token: 0x040029E1 RID: 10721
		[Nullable(2)]
		private IPieceIndex _CentreCache;

		// Token: 0x040029E2 RID: 10722
		private bool _CentreInited;

		// Token: 0x040029E3 RID: 10723
		[Nullable(2)]
		private IJigsawConfig _ConfigCache;

		// Token: 0x040029E4 RID: 10724
		private bool _ConfigInited;
	}
}
