using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002BF3 RID: 11251
	public class IGamepadShakeConfig
	{
		// Token: 0x0600F7CB RID: 63435 RVA: 0x00240D4F File Offset: 0x0023EF4F
		public static IGamepadShakeConfig Create(IGamepadShakeConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGamepadShakeConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004C93 RID: 19603
		// (get) Token: 0x0600F7CC RID: 63436 RVA: 0x00240D6E File Offset: 0x0023EF6E
		public virtual EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x040087AB RID: 34731
		private IGamepadShakeConfig Instance;
	}
}
