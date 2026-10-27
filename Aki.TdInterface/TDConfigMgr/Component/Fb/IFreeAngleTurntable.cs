using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C75 RID: 3189
	[NullableContext(1)]
	[Nullable(0)]
	public class IFreeAngleTurntable : ITurntableControlType
	{
		// Token: 0x06004913 RID: 18707 RVA: 0x000B76D7 File Offset: 0x000B58D7
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

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06004914 RID: 18708 RVA: 0x000B76F6 File Offset: 0x000B58F6
		public override EControllerType Type
		{
			get
			{
				return (EControllerType)this.Instance.Type;
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06004915 RID: 18709 RVA: 0x000B7703 File Offset: 0x000B5903
		public override int RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x06004916 RID: 18710 RVA: 0x000B7710 File Offset: 0x000B5910
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

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x06004917 RID: 18711 RVA: 0x000B7779 File Offset: 0x000B5979
		public virtual int IntervalAngle
		{
			get
			{
				return this.Instance.IntervalAngle;
			}
		}

		// Token: 0x040029B0 RID: 10672
		private IFreeAngleTurntable Instance;

		// Token: 0x040029B1 RID: 10673
		private List<IFreeAngleItem> _ItemConfigCache;

		// Token: 0x040029B2 RID: 10674
		private bool _ItemConfigInited;
	}
}
