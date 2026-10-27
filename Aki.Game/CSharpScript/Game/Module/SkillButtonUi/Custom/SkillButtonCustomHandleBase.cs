using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SkillButtonUi.Custom
{
	// Token: 0x02004C1E RID: 19486
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonCustomHandleBase
	{
		// Token: 0x06032706 RID: 206598 RVA: 0x00BC0E82 File Offset: 0x00BBF082
		public void Init(SkillButtonData skillButtonData)
		{
			this.SkillButtonData = skillButtonData;
			this.OnInit();
		}

		// Token: 0x06032707 RID: 206599 RVA: 0x00BC0E91 File Offset: 0x00BBF091
		protected virtual void OnInit()
		{
		}

		// Token: 0x06032708 RID: 206600 RVA: 0x00BC0E93 File Offset: 0x00BBF093
		public virtual void Refresh()
		{
		}

		// Token: 0x06032709 RID: 206601 RVA: 0x00BC0E95 File Offset: 0x00BBF095
		public virtual void RefreshByTagChanged()
		{
		}

		// Token: 0x0603270A RID: 206602 RVA: 0x00BC0E97 File Offset: 0x00BBF097
		public virtual bool RefreshOnInputControllerChange()
		{
			return false;
		}

		// Token: 0x0603270B RID: 206603 RVA: 0x00BC0E9A File Offset: 0x00BBF09A
		public void ClearModifyMark()
		{
			this.SkillCdModifyMark = false;
			this.EnableModifyMark = false;
			this.CustomHdModifyMark = false;
			this.EnableSlideControlModifyMark = false;
			this.CustomSkillTexturePathModifyMark = false;
			this.CustomSkillIconNameModifyMark = false;
		}

		// Token: 0x0603270C RID: 206604 RVA: 0x00BC0EC6 File Offset: 0x00BBF0C6
		public virtual float GetCustomRemainingCoolDown()
		{
			return 0f;
		}

		// Token: 0x0401ADA9 RID: 109993
		public ESkillButtonCustomHandle HandleType;

		// Token: 0x0401ADAA RID: 109994
		[Nullable(2)]
		protected SkillButtonData SkillButtonData;

		// Token: 0x0401ADAB RID: 109995
		public List<int> TagIds = new List<int>();

		// Token: 0x0401ADAC RID: 109996
		public List<long> BuffIds = new List<long>();

		// Token: 0x0401ADAD RID: 109997
		public List<string> Params = new List<string>();

		// Token: 0x0401ADAE RID: 109998
		public bool ForceEnable;

		// Token: 0x0401ADAF RID: 109999
		public bool SkillCdModifyMark;

		// Token: 0x0401ADB0 RID: 110000
		public bool EnableModifyMark;

		// Token: 0x0401ADB1 RID: 110001
		public bool CustomHdModifyMark;

		// Token: 0x0401ADB2 RID: 110002
		public bool EnableSlideControlModifyMark;

		// Token: 0x0401ADB3 RID: 110003
		public bool CustomSkillTexturePathModifyMark;

		// Token: 0x0401ADB4 RID: 110004
		public bool CustomSkillIconNameModifyMark;

		// Token: 0x0401ADB5 RID: 110005
		public int CustomHdMarkFrom = -1;
	}
}
