using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D54 RID: 3412
	public class IFreeAngleTurntable : ITurntableControlType
	{
		// Token: 0x06004DB2 RID: 19890 RVA: 0x000C1EDB File Offset: 0x000C00DB
		public static IFreeAngleTurntable Create(IFreeAngleTurntable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFreeAngleTurntable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x06004DB3 RID: 19891 RVA: 0x000C1EFA File Offset: 0x000C00FA
		public override EControllerType Type
		{
			get
			{
				return (EControllerType)this.Instance.Type;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x000C1F07 File Offset: 0x000C0107
		public override int RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06004DB5 RID: 19893 RVA: 0x000C1F14 File Offset: 0x000C0114
		public virtual List<IFreeAngleItem> ItemConfig
		{
			get
			{
				if (this._ItemConfigInited)
				{
					return this._ItemConfigCache;
				}
				this._ItemConfigInited = true;
				int itemConfigLength = this.Instance.ItemConfigLength;
				this._ItemConfigCache = new List<IFreeAngleItem>(itemConfigLength);
				for (int i = 0; i < itemConfigLength; i++)
				{
					this._ItemConfigCache.Add(IFreeAngleItem.Create(this.Instance.ItemConfig(i)));
				}
				return this._ItemConfigCache;
			}
		}

		// Token: 0x17001708 RID: 5896
		// (get) Token: 0x06004DB6 RID: 19894 RVA: 0x000C1F7D File Offset: 0x000C017D
		public virtual int IntervalAngle
		{
			get
			{
				return this.Instance.IntervalAngle;
			}
		}

		// Token: 0x04002C1D RID: 11293
		private IFreeAngleTurntable Instance;

		// Token: 0x04002C1E RID: 11294
		private List<IFreeAngleItem> _ItemConfigCache;

		// Token: 0x04002C1F RID: 11295
		private bool _ItemConfigInited;
	}
}
