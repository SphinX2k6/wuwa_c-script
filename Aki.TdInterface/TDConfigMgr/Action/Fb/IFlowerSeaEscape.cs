using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002865 RID: 10341
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowerSeaEscape : IUiGame
	{
		// Token: 0x0600E52F RID: 58671 RVA: 0x0021B5D6 File Offset: 0x002197D6
		public static IFlowerSeaEscape Create(IFlowerSeaEscape? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerSeaEscape
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004627 RID: 17959
		// (get) Token: 0x0600E530 RID: 58672 RVA: 0x0021B5F5 File Offset: 0x002197F5
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x17004628 RID: 17960
		// (get) Token: 0x0600E531 RID: 58673 RVA: 0x0021B602 File Offset: 0x00219802
		public virtual int EndAreaEntityId
		{
			get
			{
				return this.Instance.EndAreaEntityId;
			}
		}

		// Token: 0x17004629 RID: 17961
		// (get) Token: 0x0600E532 RID: 58674 RVA: 0x0021B60F File Offset: 0x0021980F
		public virtual string ConfigDa
		{
			get
			{
				return this.Instance.ConfigDa;
			}
		}

		// Token: 0x1700462A RID: 17962
		// (get) Token: 0x0600E533 RID: 58675 RVA: 0x0021B61C File Offset: 0x0021981C
		public virtual string SpreadingState
		{
			get
			{
				return this.Instance.SpreadingState;
			}
		}

		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x0600E534 RID: 58676 RVA: 0x0021B629 File Offset: 0x00219829
		public virtual string PausedState
		{
			get
			{
				return this.Instance.PausedState;
			}
		}

		// Token: 0x1700462C RID: 17964
		// (get) Token: 0x0600E535 RID: 58677 RVA: 0x0021B636 File Offset: 0x00219836
		public virtual string ResetState
		{
			get
			{
				return this.Instance.ResetState;
			}
		}

		// Token: 0x04007EC7 RID: 32455
		private IFlowerSeaEscape Instance;
	}
}
