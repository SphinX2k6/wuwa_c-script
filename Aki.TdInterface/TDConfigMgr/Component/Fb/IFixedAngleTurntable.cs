using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C77 RID: 3191
	[NullableContext(1)]
	[Nullable(0)]
	public class IFixedAngleTurntable : ITurntableControlType
	{
		// Token: 0x0600491E RID: 18718 RVA: 0x000B77DC File Offset: 0x000B59DC
		public static IFixedAngleTurntable Create(IFixedAngleTurntable? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedAngleTurntable
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x0600491F RID: 18719 RVA: 0x000B77FB File Offset: 0x000B59FB
		public override EControllerType Type
		{
			get
			{
				return (EControllerType)this.Instance.Type;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x000B7808 File Offset: 0x000B5A08
		public override int RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x06004921 RID: 18721 RVA: 0x000B7818 File Offset: 0x000B5A18
		public virtual List<IFixedAngleItem> ItemConfig
		{
			get
			{
				if (this._ItemConfigInited)
				{
					return this._ItemConfigCache;
				}
				this._ItemConfigInited = true;
				int itemConfigLength = this.Instance.ItemConfigLength;
				this._ItemConfigCache = new List<IFixedAngleItem>(itemConfigLength);
				for (int i = 0; i < itemConfigLength; i++)
				{
					this._ItemConfigCache.Add(IFixedAngleItem.Create(this.Instance.ItemConfig(i)));
				}
				return this._ItemConfigCache;
			}
		}

		// Token: 0x040029B4 RID: 10676
		private IFixedAngleTurntable Instance;

		// Token: 0x040029B5 RID: 10677
		private List<IFixedAngleItem> _ItemConfigCache;

		// Token: 0x040029B6 RID: 10678
		private bool _ItemConfigInited;
	}
}
