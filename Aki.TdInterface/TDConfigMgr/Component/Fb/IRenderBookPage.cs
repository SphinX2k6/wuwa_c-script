using System;
using Aki.TDConfigMgr.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E65 RID: 3685
	public class IRenderBookPage : IRenderSpecifiedRangeType
	{
		// Token: 0x06005348 RID: 21320 RVA: 0x000CD853 File Offset: 0x000CBA53
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

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x000CD872 File Offset: 0x000CBA72
		public override ERenderSpecifiedRangeType Type
		{
			get
			{
				return (ERenderSpecifiedRangeType)this.Instance.Type;
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x0600534A RID: 21322 RVA: 0x000CD87F File Offset: 0x000CBA7F
		public virtual int Radius
		{
			get
			{
				return this.Instance.Radius;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x0600534B RID: 21323 RVA: 0x000CD88C File Offset: 0x000CBA8C
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

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x0600534C RID: 21324 RVA: 0x000CD8BB File Offset: 0x000CBABB
		public virtual string AkEvent
		{
			get
			{
				return this.Instance.AkEvent;
			}
		}

		// Token: 0x04002F8C RID: 12172
		private IRenderBookPage Instance;

		// Token: 0x04002F8D RID: 12173
		private ITargetEntityType _CenterTargetCache;

		// Token: 0x04002F8E RID: 12174
		private bool _CenterTargetInited;
	}
}
