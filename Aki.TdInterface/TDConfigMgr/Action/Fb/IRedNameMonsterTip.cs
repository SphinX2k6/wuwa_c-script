using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A2D RID: 10797
	public class IRedNameMonsterTip : ICommonTipType
	{
		// Token: 0x0600EE98 RID: 61080 RVA: 0x0022FE06 File Offset: 0x0022E006
		public static IRedNameMonsterTip Create(IRedNameMonsterTip? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRedNameMonsterTip
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170046EC RID: 18156
		// (get) Token: 0x0600EE99 RID: 61081 RVA: 0x0022FE25 File Offset: 0x0022E025
		public override ECommonTipType Type
		{
			get
			{
				return (ECommonTipType)this.Instance.Type;
			}
		}

		// Token: 0x170046ED RID: 18157
		// (get) Token: 0x0600EE9A RID: 61082 RVA: 0x0022FE32 File Offset: 0x0022E032
		public virtual int MonsterId
		{
			get
			{
				return this.Instance.MonsterId;
			}
		}

		// Token: 0x170046EE RID: 18158
		// (get) Token: 0x0600EE9B RID: 61083 RVA: 0x0022FE3F File Offset: 0x0022E03F
		public virtual float Duration
		{
			get
			{
				return this.Instance.Duration;
			}
		}

		// Token: 0x0400830F RID: 33551
		private IRedNameMonsterTip Instance;
	}
}
