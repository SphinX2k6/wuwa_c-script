using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C35 RID: 11317
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSectionalUi : IUiOperationType
	{
		// Token: 0x0600F8F7 RID: 63735 RVA: 0x00242D86 File Offset: 0x00240F86
		[NullableContext(0)]
		public static IEnableSectionalUi Create(IEnableSectionalUi? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSectionalUi
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D3B RID: 19771
		// (get) Token: 0x0600F8F8 RID: 63736 RVA: 0x00242DA5 File Offset: 0x00240FA5
		public override EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x17004D3C RID: 19772
		// (get) Token: 0x0600F8F9 RID: 63737 RVA: 0x00242DB4 File Offset: 0x00240FB4
		public virtual bool? ShowMiniMap
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowMiniMap);
			}
		}

		// Token: 0x17004D3D RID: 19773
		// (get) Token: 0x0600F8FA RID: 63738 RVA: 0x00242DEC File Offset: 0x00240FEC
		public virtual bool? ShowQuestTrack
		{
			get
			{
				if ((this.Instance.NullMask & 2) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowQuestTrack);
			}
		}

		// Token: 0x17004D3E RID: 19774
		// (get) Token: 0x0600F8FB RID: 63739 RVA: 0x00242E24 File Offset: 0x00241024
		public virtual bool? ShowEsc
		{
			get
			{
				if ((this.Instance.NullMask & 4) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowEsc);
			}
		}

		// Token: 0x17004D3F RID: 19775
		// (get) Token: 0x0600F8FC RID: 63740 RVA: 0x00242E5C File Offset: 0x0024105C
		public virtual bool? ShowSystem
		{
			get
			{
				if ((this.Instance.NullMask & 8) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowSystem);
			}
		}

		// Token: 0x17004D40 RID: 19776
		// (get) Token: 0x0600F8FD RID: 63741 RVA: 0x00242E94 File Offset: 0x00241094
		public virtual bool? ShowScreenEffect
		{
			get
			{
				if ((this.Instance.NullMask & 16) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowScreenEffect);
			}
		}

		// Token: 0x17004D41 RID: 19777
		// (get) Token: 0x0600F8FE RID: 63742 RVA: 0x00242ECC File Offset: 0x002410CC
		public virtual bool? ShowRoleFormation
		{
			get
			{
				if ((this.Instance.NullMask & 32) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowRoleFormation);
			}
		}

		// Token: 0x17004D42 RID: 19778
		// (get) Token: 0x0600F8FF RID: 63743 RVA: 0x00242F04 File Offset: 0x00241104
		public virtual bool? ShowRoleStatus
		{
			get
			{
				if ((this.Instance.NullMask & 64) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowRoleStatus);
			}
		}

		// Token: 0x17004D43 RID: 19779
		// (get) Token: 0x0600F900 RID: 63744 RVA: 0x00242F3C File Offset: 0x0024113C
		public virtual bool? ShowBossStatus
		{
			get
			{
				if ((this.Instance.NullMask & 128) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowBossStatus);
			}
		}

		// Token: 0x17004D44 RID: 19780
		// (get) Token: 0x0600F901 RID: 63745 RVA: 0x00242F78 File Offset: 0x00241178
		public virtual bool? ShowGuideLayer
		{
			get
			{
				if ((this.Instance.NullMask & 256) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowGuideLayer);
			}
		}

		// Token: 0x17004D45 RID: 19781
		// (get) Token: 0x0600F902 RID: 63746 RVA: 0x00242FB4 File Offset: 0x002411B4
		public virtual bool? ShowMonsterHpBar
		{
			get
			{
				if ((this.Instance.NullMask & 512) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowMonsterHpBar);
			}
		}

		// Token: 0x17004D46 RID: 19782
		// (get) Token: 0x0600F903 RID: 63747 RVA: 0x00242FF0 File Offset: 0x002411F0
		public virtual bool? ShowDamageText
		{
			get
			{
				if ((this.Instance.NullMask & 1024) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowDamageText);
			}
		}

		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x0600F904 RID: 63748 RVA: 0x0024302C File Offset: 0x0024122C
		public virtual bool? ShowPing
		{
			get
			{
				if ((this.Instance.NullMask & 2048) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowPing);
			}
		}

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x0600F905 RID: 63749 RVA: 0x00243068 File Offset: 0x00241268
		public virtual bool? ShowOther
		{
			get
			{
				if ((this.Instance.NullMask & 4096) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowOther);
			}
		}

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x0600F906 RID: 63750 RVA: 0x002430A4 File Offset: 0x002412A4
		public virtual List<EUiElement> AlwaysShowUiSections
		{
			get
			{
				if (this._AlwaysShowUiSectionsInited)
				{
					return this._AlwaysShowUiSectionsCache;
				}
				this._AlwaysShowUiSectionsInited = true;
				if ((this.Instance.NullMask & 8192) == 0)
				{
					return null;
				}
				int alwaysShowUiSectionsLength = this.Instance.AlwaysShowUiSectionsLength;
				this._AlwaysShowUiSectionsCache = new List<EUiElement>(alwaysShowUiSectionsLength);
				for (int i = 0; i < alwaysShowUiSectionsLength; i++)
				{
					this._AlwaysShowUiSectionsCache.Add((EUiElement)this.Instance.AlwaysShowUiSections(i));
				}
				return this._AlwaysShowUiSectionsCache;
			}
		}

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x0600F907 RID: 63751 RVA: 0x00243120 File Offset: 0x00241320
		public virtual bool? ShowPositionOfficial
		{
			get
			{
				if ((this.Instance.NullMask & 16384) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.ShowPositionOfficial);
			}
		}

		// Token: 0x0400881F RID: 34847
		private IEnableSectionalUi Instance;

		// Token: 0x04008820 RID: 34848
		private List<EUiElement> _AlwaysShowUiSectionsCache;

		// Token: 0x04008821 RID: 34849
		private bool _AlwaysShowUiSectionsInited;
	}
}
