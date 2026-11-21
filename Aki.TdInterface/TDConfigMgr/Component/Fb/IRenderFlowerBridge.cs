using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E64 RID: 3684
	public class IRenderFlowerBridge : IRenderSpecifiedRangeType
	{
		// Token: 0x06005342 RID: 21314 RVA: 0x000CD7D6 File Offset: 0x000CB9D6
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

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06005343 RID: 21315 RVA: 0x000CD7F5 File Offset: 0x000CB9F5
		public override ERenderSpecifiedRangeType Type
		{
			get
			{
				return (ERenderSpecifiedRangeType)this.Instance.Type;
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x000CD802 File Offset: 0x000CBA02
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06005345 RID: 21317 RVA: 0x000CD80F File Offset: 0x000CBA0F
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

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x000CD83E File Offset: 0x000CBA3E
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04002F89 RID: 12169
		private IRenderFlowerBridge Instance;

		// Token: 0x04002F8A RID: 12170
		private ITargetEntityType _CenterTargetCache;

		// Token: 0x04002F8B RID: 12171
		private bool _CenterTargetInited;
	}
}
