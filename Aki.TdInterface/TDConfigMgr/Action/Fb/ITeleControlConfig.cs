using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F7 RID: 10487
	public class ITeleControlConfig : IExploreConfig
	{
		// Token: 0x0600E8EC RID: 59628 RVA: 0x00222B31 File Offset: 0x00220D31
		[NullableContext(1)]
		public static ITeleControlConfig Create(ITeleControlConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleControlConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x0600E8ED RID: 59629 RVA: 0x00222B50 File Offset: 0x00220D50
		public override EExploreStateType Type
		{
			get
			{
				return (EExploreStateType)this.Instance.Type;
			}
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x00222B5D File Offset: 0x00220D5D
		public virtual ETeleControlType TeleControlType
		{
			get
			{
				return (ETeleControlType)this.Instance.TeleControlType;
			}
		}

		// Token: 0x04008095 RID: 32917
		private ITeleControlConfig Instance;
	}
}
