using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002917 RID: 10519
	public class IGamepadShakeConfig
	{
		// Token: 0x0600E979 RID: 59769 RVA: 0x002239F7 File Offset: 0x00221BF7
		[NullableContext(1)]
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

		// Token: 0x1700490D RID: 18701
		// (get) Token: 0x0600E97A RID: 59770 RVA: 0x00223A16 File Offset: 0x00221C16
		public virtual EGamepadShakeType Type
		{
			get
			{
				return (EGamepadShakeType)this.Instance.Type;
			}
		}

		// Token: 0x040080DD RID: 32989
		private IGamepadShakeConfig Instance;
	}
}
