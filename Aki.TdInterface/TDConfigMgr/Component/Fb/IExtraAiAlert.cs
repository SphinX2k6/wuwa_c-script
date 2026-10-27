using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C9F RID: 3231
	public class IExtraAiAlert
	{
		// Token: 0x060049E0 RID: 18912 RVA: 0x000B9266 File Offset: 0x000B7466
		[NullableContext(1)]
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

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x000B9288 File Offset: 0x000B7488
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

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x000B92C0 File Offset: 0x000B74C0
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

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x060049E3 RID: 18915 RVA: 0x000B92F8 File Offset: 0x000B74F8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IStateAlert> SelfStateAlert
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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

		// Token: 0x04002A32 RID: 10802
		private IExtraAiAlert Instance;

		// Token: 0x04002A33 RID: 10803
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IStateAlert> _SelfStateAlertCache;

		// Token: 0x04002A34 RID: 10804
		private bool _SelfStateAlertInited;
	}
}
