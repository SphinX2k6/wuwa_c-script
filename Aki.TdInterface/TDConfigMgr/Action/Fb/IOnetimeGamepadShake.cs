using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF4 RID: 11252
	public class IOnetimeGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600F7CE RID: 63438 RVA: 0x00240D83 File Offset: 0x0023EF83
		public static IOnetimeGamepadShake Create(IOnetimeGamepadShake? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOnetimeGamepadShake
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C94 RID: 19604
		// (get) Token: 0x0600F7CF RID: 63439 RVA: 0x00240DA2 File Offset: 0x0023EFA2
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x17004C95 RID: 19605
		// (get) Token: 0x0600F7D0 RID: 63440 RVA: 0x00240DB0 File Offset: 0x0023EFB0
		public virtual bool? IsIgnoreTimeDilation
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.IsIgnoreTimeDilation);
			}
		}

		// Token: 0x17004C96 RID: 19606
		// (get) Token: 0x0600F7D1 RID: 63441 RVA: 0x00240DE6 File Offset: 0x0023EFE6
		[Nullable(2)]
		public virtual string GamepadShakeTag
		{
			[NullableContext(2)]
			get
			{
				return this.Instance.GamepadShakeTag;
			}
		}

		// Token: 0x040087AC RID: 34732
		private IOnetimeGamepadShake Instance;
	}
}
