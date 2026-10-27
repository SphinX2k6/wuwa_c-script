using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002918 RID: 10520
	[NullableContext(2)]
	[Nullable(0)]
	public class IOnetimeGamepadShake : IGamepadShakeConfig
	{
		// Token: 0x0600E97C RID: 59772 RVA: 0x00223A2B File Offset: 0x00221C2B
		[NullableContext(1)]
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

		// Token: 0x1700490E RID: 18702
		// (get) Token: 0x0600E97D RID: 59773 RVA: 0x00223A4A File Offset: 0x00221C4A
		public override EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x1700490F RID: 18703
		// (get) Token: 0x0600E97E RID: 59774 RVA: 0x00223A58 File Offset: 0x00221C58
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

		// Token: 0x17004910 RID: 18704
		// (get) Token: 0x0600E97F RID: 59775 RVA: 0x00223A8E File Offset: 0x00221C8E
		public virtual string GamepadShakeTag
		{
			get
			{
				return this.Instance.GamepadShakeTag;
			}
		}

		// Token: 0x040080DE RID: 32990
		private IOnetimeGamepadShake Instance;
	}
}
