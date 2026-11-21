using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D7E RID: 3454
	public class LevitateMagnetComponent : IComponentBase
	{
		// Token: 0x06004E7D RID: 20093 RVA: 0x000C39F2 File Offset: 0x000C1BF2
		public static LevitateMagnetComponent Create(ILevitateMagnetComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevitateMagnetComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06004E7E RID: 20094 RVA: 0x000C3A14 File Offset: 0x000C1C14
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x06004E7F RID: 20095 RVA: 0x000C3A4C File Offset: 0x000C1C4C
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x06004E80 RID: 20096 RVA: 0x000C3A62 File Offset: 0x000C1C62
		public virtual int MoveSpeed
		{
			get
			{
				return this.Instance.MoveSpeed;
			}
		}

		// Token: 0x1700177F RID: 6015
		// (get) Token: 0x06004E81 RID: 20097 RVA: 0x000C3A70 File Offset: 0x000C1C70
		public virtual int? Test
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new int?(this.Instance.Test);
			}
		}

		// Token: 0x04002CA3 RID: 11427
		private ILevitateMagnetComponent Instance;
	}
}
