using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D56 RID: 3414
	public class IFixedAngleTurntable : ITurntableControlType
	{
		// Token: 0x06004DBD RID: 19901 RVA: 0x000C1FE0 File Offset: 0x000C01E0
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

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x06004DBE RID: 19902 RVA: 0x000C1FFF File Offset: 0x000C01FF
		public override EControllerType Type
		{
			get
			{
				return (EControllerType)this.Instance.Type;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06004DBF RID: 19903 RVA: 0x000C200C File Offset: 0x000C020C
		public override int RotationSpeed
		{
			get
			{
				return this.Instance.RotationSpeed;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x000C201C File Offset: 0x000C021C
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

		// Token: 0x04002C21 RID: 11297
		private IFixedAngleTurntable Instance;

		// Token: 0x04002C22 RID: 11298
		private List<IFixedAngleItem> _ItemConfigCache;

		// Token: 0x04002C23 RID: 11299
		private bool _ItemConfigInited;
	}
}
