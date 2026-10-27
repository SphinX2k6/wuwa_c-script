using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002953 RID: 10579
	[NullableContext(2)]
	[Nullable(0)]
	public class IEnableSectionalUi : IUiOperationType
	{
		// Token: 0x0600EA8C RID: 60044 RVA: 0x002257A6 File Offset: 0x002239A6
		[NullableContext(1)]
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

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x002257C5 File Offset: 0x002239C5
		public override EUiOperationType Type
		{
			get
			{
				return (EUiOperationType)this.Instance.Type;
			}
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x0600EA8E RID: 60046 RVA: 0x002257D4 File Offset: 0x002239D4
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

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x0600EA8F RID: 60047 RVA: 0x0022580C File Offset: 0x00223A0C
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

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x0600EA90 RID: 60048 RVA: 0x00225844 File Offset: 0x00223A44
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

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x0600EA91 RID: 60049 RVA: 0x0022587C File Offset: 0x00223A7C
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

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x0600EA92 RID: 60050 RVA: 0x002258B4 File Offset: 0x00223AB4
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

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x002258EC File Offset: 0x00223AEC
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

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x0600EA94 RID: 60052 RVA: 0x00225924 File Offset: 0x00223B24
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

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x0022595C File Offset: 0x00223B5C
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

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x0600EA96 RID: 60054 RVA: 0x00225998 File Offset: 0x00223B98
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

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x002259D4 File Offset: 0x00223BD4
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

		// Token: 0x170049B3 RID: 18867
		// (get) Token: 0x0600EA98 RID: 60056 RVA: 0x00225A10 File Offset: 0x00223C10
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

		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x0600EA99 RID: 60057 RVA: 0x00225A4C File Offset: 0x00223C4C
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

		// Token: 0x170049B5 RID: 18869
		// (get) Token: 0x0600EA9A RID: 60058 RVA: 0x00225A88 File Offset: 0x00223C88
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

		// Token: 0x170049B6 RID: 18870
		// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x00225AC4 File Offset: 0x00223CC4
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

		// Token: 0x170049B7 RID: 18871
		// (get) Token: 0x0600EA9C RID: 60060 RVA: 0x00225B40 File Offset: 0x00223D40
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

		// Token: 0x04008143 RID: 33091
		private IEnableSectionalUi Instance;

		// Token: 0x04008144 RID: 33092
		private List<EUiElement> _AlwaysShowUiSectionsCache;

		// Token: 0x04008145 RID: 33093
		private bool _AlwaysShowUiSectionsInited;
	}
}
