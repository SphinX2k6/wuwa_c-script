using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6A RID: 3434
	[NullableContext(1)]
	[Nullable(0)]
	public class IRenderFlowerBridge : IRenderSpecifiedRangeType
	{
		// Token: 0x06004E26 RID: 20006 RVA: 0x000C2092 File Offset: 0x000C0292
		public static IRenderFlowerBridge Create(IRenderFlowerBridge? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenderFlowerBridge
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x06004E27 RID: 20007 RVA: 0x000C20B1 File Offset: 0x000C02B1
		public override ERenderSpecifiedRangeType Type
		{
			get
			{
				return (ERenderSpecifiedRangeType)this.Instance.Type;
			}
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x000C20BE File Offset: 0x000C02BE
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x06004E29 RID: 20009 RVA: 0x000C20CB File Offset: 0x000C02CB
		public virtual ITargetEntityType CenterTarget
		{
			get
			{
				if (this._CenterTargetInited)
				{
					return this._CenterTargetCache;
				}
				this._CenterTargetInited = true;
				this._CenterTargetCache = ComponentReadHelper.ReadIRenderFlowerBridge_CenterTarget(this.Instance);
				return this._CenterTargetCache;
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x000C20FA File Offset: 0x000C02FA
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04002CC9 RID: 11465
		private IRenderFlowerBridge Instance;

		// Token: 0x04002CCA RID: 11466
		private ITargetEntityType _CenterTargetCache;

		// Token: 0x04002CCB RID: 11467
		private bool _CenterTargetInited;
	}
}
