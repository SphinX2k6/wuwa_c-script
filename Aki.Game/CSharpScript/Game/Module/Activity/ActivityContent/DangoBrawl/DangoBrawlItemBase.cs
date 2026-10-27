using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067BB RID: 26555
	public class DangoBrawlItemBase
	{
		// Token: 0x06042242 RID: 270914 RVA: 0x0100A608 File Offset: 0x01008808
		public DangoBrawlItemBase(int uid, int configId)
		{
			this.Uid = uid;
			this.ConfigId = configId;
			this.ConfigType = DangoBrawlConfig.Instance.GetItemConfigTypeById(this.ConfigId);
			this.TemplateId = DangoBrawlUtil.GetTemplateId(configId);
			this.TemplateType = DangoBrawlUtil.GetTemplateType(this.TemplateId);
			this.BoundSize = DangoBrawlUtil.GetTemplateBoundSize(this.TemplateId);
		}

		// Token: 0x170096A6 RID: 38566
		// (get) Token: 0x06042243 RID: 270915 RVA: 0x0100A66D File Offset: 0x0100886D
		public int MyUid
		{
			get
			{
				return this.Uid;
			}
		}

		// Token: 0x170096A7 RID: 38567
		// (get) Token: 0x06042244 RID: 270916 RVA: 0x0100A675 File Offset: 0x01008875
		public int MyConfigId
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x170096A8 RID: 38568
		// (get) Token: 0x06042245 RID: 270917 RVA: 0x0100A67D File Offset: 0x0100887D
		public int MyTemplateId
		{
			get
			{
				return this.TemplateId;
			}
		}

		// Token: 0x170096A9 RID: 38569
		// (get) Token: 0x06042246 RID: 270918 RVA: 0x0100A685 File Offset: 0x01008885
		public int MyBoundSize
		{
			get
			{
				return this.BoundSize;
			}
		}

		// Token: 0x170096AA RID: 38570
		// (get) Token: 0x06042247 RID: 270919 RVA: 0x0100A68D File Offset: 0x0100888D
		public EDangoBrawlItemType MyType
		{
			get
			{
				return this.ConfigType;
			}
		}

		// Token: 0x170096AB RID: 38571
		// (get) Token: 0x06042248 RID: 270920 RVA: 0x0100A695 File Offset: 0x01008895
		public EDangoBrawlTemplateType MyTemplateType
		{
			get
			{
				return this.TemplateType;
			}
		}

		// Token: 0x0402288B RID: 141451
		private readonly int Uid;

		// Token: 0x0402288C RID: 141452
		private readonly int ConfigId;

		// Token: 0x0402288D RID: 141453
		private readonly int TemplateId;

		// Token: 0x0402288E RID: 141454
		private readonly int BoundSize;

		// Token: 0x0402288F RID: 141455
		private readonly EDangoBrawlItemType ConfigType;

		// Token: 0x04022890 RID: 141456
		private readonly EDangoBrawlTemplateType TemplateType;
	}
}
