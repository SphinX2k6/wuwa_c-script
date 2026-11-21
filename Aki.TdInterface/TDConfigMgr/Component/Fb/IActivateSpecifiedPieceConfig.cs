using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D74 RID: 3444
	public class IActivateSpecifiedPieceConfig
	{
		// Token: 0x06004E46 RID: 20038 RVA: 0x000C3096 File Offset: 0x000C1296
		public static IActivateSpecifiedPieceConfig Create(IActivateSpecifiedPieceConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActivateSpecifiedPieceConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06004E47 RID: 20039 RVA: 0x000C30B5 File Offset: 0x000C12B5
		public virtual IJigsawConfig Jigsaw
		{
			get
			{
				if (this._JigsawInited)
				{
					return this._JigsawCache;
				}
				this._JigsawInited = true;
				this._JigsawCache = IJigsawConfig.Create(this.Instance.Jigsaw);
				return this._JigsawCache;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06004E48 RID: 20040 RVA: 0x000C30E9 File Offset: 0x000C12E9
		public virtual string SelfState
		{
			get
			{
				return this.Instance.SelfState;
			}
		}

		// Token: 0x04002C75 RID: 11381
		private IActivateSpecifiedPieceConfig Instance;

		// Token: 0x04002C76 RID: 11382
		[Nullable(2)]
		private IJigsawConfig _JigsawCache;

		// Token: 0x04002C77 RID: 11383
		private bool _JigsawInited;
	}
}
