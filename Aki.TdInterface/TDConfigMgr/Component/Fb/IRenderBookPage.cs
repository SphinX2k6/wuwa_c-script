using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6B RID: 3435
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderBookPage : IRenderSpecifiedRangeType
	{
		// Token: 0x06004E2C RID: 20012 RVA: 0x000C210F File Offset: 0x000C030F
		public static IRenderBookPage Create(IRenderBookPage? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderBookPage
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x06004E2D RID: 20013 RVA: 0x000C212E File Offset: 0x000C032E
		public override ERenderSpecifiedRangeType Type
		{
			get
			{
				return (ERenderSpecifiedRangeType)this.Instance.Type;
			}
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x000C213B File Offset: 0x000C033B
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06004E2F RID: 20015 RVA: 0x000C2148 File Offset: 0x000C0348
		public virtual ITargetEntityType CenterTarget
		{
			get
			{
				if (this._CenterTargetInited)
				{
					return this._CenterTargetCache;
				}
				this._CenterTargetInited = true;
				this._CenterTargetCache = ComponentReadHelper.ReadIRenderBookPage_CenterTarget(this.Instance);
				return this._CenterTargetCache;
			}
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x000C2177 File Offset: 0x000C0377
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04002CCC RID: 11468
		private IRenderBookPage Instance;

		// Token: 0x04002CCD RID: 11469
		private ITargetEntityType _CenterTargetCache;

		// Token: 0x04002CCE RID: 11470
		private bool _CenterTargetInited;
	}
}
