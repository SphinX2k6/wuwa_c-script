using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6B RID: 3435
	public class IFixedFill : IFillType
	{
		// Token: 0x06004E1A RID: 19994 RVA: 0x000C2AFB File Offset: 0x000C0CFB
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

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06004E1B RID: 19995 RVA: 0x000C2B1A File Offset: 0x000C0D1A
		public override EFillType Type
		{
			get
			{
				return (EFillType)this.Instance.Type;
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x000C2B28 File Offset: 0x000C0D28
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

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06004E1D RID: 19997 RVA: 0x000C2B5E File Offset: 0x000C0D5E
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

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06004E1E RID: 19998 RVA: 0x000C2B92 File Offset: 0x000C0D92
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

		// Token: 0x04002C5A RID: 11354
		private IFixedFill Instance;

		// Token: 0x04002C5B RID: 11355
		[Nullable(2)]
		private IPieceIndex _CentreCache;

		// Token: 0x04002C5C RID: 11356
		private bool _CentreInited;

		// Token: 0x04002C5D RID: 11357
		[Nullable(2)]
		private IJigsawConfig _ConfigCache;

		// Token: 0x04002C5E RID: 11358
		private bool _ConfigInited;
	}
}
