using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02003BCF RID: 15311
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonCustomHandleBase
	{
		// Token: 0x060274B9 RID: 160953 RVA: 0x00B05B0E File Offset: 0x00B03D0E
		public void Init(SkillButtonData skillButtonData)
		{
			this.SkillButtonData = skillButtonData;
			this.OnInit();
		}

		// Token: 0x060274BA RID: 160954 RVA: 0x00B05B1D File Offset: 0x00B03D1D
		protected virtual void OnInit()
		{
		}

		// Token: 0x060274BB RID: 160955 RVA: 0x00B05B1F File Offset: 0x00B03D1F
		public virtual void Refresh()
		{
		}

		// Token: 0x060274BC RID: 160956 RVA: 0x00B05B21 File Offset: 0x00B03D21
		public virtual void RefreshByTagChanged()
		{
		}

		// Token: 0x060274BD RID: 160957 RVA: 0x00B05B23 File Offset: 0x00B03D23
		public virtual bool RefreshOnInputControllerChange()
		{
			return false;
		}

		// Token: 0x060274BE RID: 160958 RVA: 0x00B05B26 File Offset: 0x00B03D26
		public void ClearModifyMark()
		{
			this.SkillCdModifyMark = false;
			this.EnableModifyMark = false;
			this.CustomHdModifyMark = false;
			this.EnableSlideControlModifyMark = false;
			this.CustomSkillTexturePathModifyMark = false;
			this.CustomSkillIconNameModifyMark = false;
		}

		// Token: 0x060274BF RID: 160959 RVA: 0x00B05B52 File Offset: 0x00B03D52
		public virtual float GetCustomRemainingCoolDown()
		{
			return 0f;
		}

		// Token: 0x04015706 RID: 87814
		public ESkillButtonCustomHandle HandleType;

		// Token: 0x04015707 RID: 87815
		[Nullable(2)]
		protected SkillButtonData SkillButtonData;

		// Token: 0x04015708 RID: 87816
		public List<int> TagIds = new List<int>();

		// Token: 0x04015709 RID: 87817
		public List<long> BuffIds = new List<long>();

		// Token: 0x0401570A RID: 87818
		public List<string> Params = new List<string>();

		// Token: 0x0401570B RID: 87819
		public bool ForceEnable;

		// Token: 0x0401570C RID: 87820
		public bool SkillCdModifyMark;

		// Token: 0x0401570D RID: 87821
		public bool EnableModifyMark;

		// Token: 0x0401570E RID: 87822
		public bool CustomHdModifyMark;

		// Token: 0x0401570F RID: 87823
		public bool EnableSlideControlModifyMark;

		// Token: 0x04015710 RID: 87824
		public bool CustomSkillTexturePathModifyMark;

		// Token: 0x04015711 RID: 87825
		public bool CustomSkillIconNameModifyMark;

		// Token: 0x04015712 RID: 87826
		public int CustomHdMarkFrom = -1;
	}
}
