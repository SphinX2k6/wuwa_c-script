using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A28 RID: 23080
	public abstract class SolarSchoolHideHudViewBase : UiViewBase
	{
		// Token: 0x06038D74 RID: 232820 RVA: 0x00FE9A6D File Offset: 0x00FE7C6D
		[NullableContext(1)]
		protected SolarSchoolHideHudViewBase(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038D75 RID: 232821 RVA: 0x00FE9A76 File Offset: 0x00FE7C76
		protected override void OnBeforeShowImplementImplement()
		{
			if (this.HudHidden)
			{
				return;
			}
			this.HudHidden = true;
			SolarSchoolGamePlayModel.Instance.PushRootHudHide();
		}

		// Token: 0x06038D76 RID: 232822 RVA: 0x00FE9A92 File Offset: 0x00FE7C92
		protected override void OnBeforePlayCloseSequence()
		{
			this.RestoreHud();
		}

		// Token: 0x06038D77 RID: 232823 RVA: 0x00FE9A9A File Offset: 0x00FE7C9A
		protected override void OnBeforeDestroyImplement()
		{
			this.RestoreHud();
		}

		// Token: 0x06038D78 RID: 232824 RVA: 0x00FE9AA2 File Offset: 0x00FE7CA2
		private void RestoreHud()
		{
			if (!this.HudHidden)
			{
				return;
			}
			this.HudHidden = false;
			SolarSchoolGamePlayModel.Instance.PopRootHudHide();
		}

		// Token: 0x0401DEA0 RID: 122528
		private bool HudHidden;
	}
}
