using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D81 RID: 3457
	public class IExtraAiAlert
	{
		// Token: 0x06004E8E RID: 20110 RVA: 0x000C3C76 File Offset: 0x000C1E76
		public static IExtraAiAlert Create(IExtraAiAlert? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExtraAiAlert
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x06004E8F RID: 20111 RVA: 0x000C3C98 File Offset: 0x000C1E98
		public virtual int? MoveAlert
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.MoveAlert);
			}
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06004E90 RID: 20112 RVA: 0x000C3CD0 File Offset: 0x000C1ED0
		public virtual int? StopAlert
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.StopAlert);
			}
		}

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06004E91 RID: 20113 RVA: 0x000C3D08 File Offset: 0x000C1F08
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IStateAlert> SelfStateAlert
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._SelfStateAlertInited)
				{
					return this._SelfStateAlertCache;
				}
				this._SelfStateAlertInited = true;
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				int selfStateAlertLength = this.Instance.SelfStateAlertLength;
				this._SelfStateAlertCache = new List<IStateAlert>(selfStateAlertLength);
				for (int i = 0; i < selfStateAlertLength; i++)
				{
					this._SelfStateAlertCache.Add(IStateAlert.Create(this.Instance.SelfStateAlert(i)));
				}
				return this._SelfStateAlertCache;
			}
		}

		// Token: 0x04002CAC RID: 11436
		private IExtraAiAlert Instance;

		// Token: 0x04002CAD RID: 11437
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IStateAlert> _SelfStateAlertCache;

		// Token: 0x04002CAE RID: 11438
		private bool _SelfStateAlertInited;
	}
}
