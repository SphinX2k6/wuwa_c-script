using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200570B RID: 22283
	public class DangoBrawlItemBase
	{
		// Token: 0x06036D98 RID: 224664 RVA: 0x00F4B9EC File Offset: 0x00F49BEC
		public DangoBrawlItemBase(int uid, int configId)
		{
			this.Uid = uid;
			this.ConfigId = configId;
			this.ConfigType = DangoBrawlConfig.Instance.GetItemConfigTypeById(this.ConfigId);
			this.TemplateId = DangoBrawlUtil.GetTemplateId(configId);
			this.TemplateType = DangoBrawlUtil.GetTemplateType(this.TemplateId);
			this.BoundSize = DangoBrawlUtil.GetTemplateBoundSize(this.TemplateId);
		}

		// Token: 0x170069E7 RID: 27111
		// (get) Token: 0x06036D99 RID: 224665 RVA: 0x00F4BA51 File Offset: 0x00F49C51
		public int MyUid
		{
			get
			{
				return this.Uid;
			}
		}

		// Token: 0x170069E8 RID: 27112
		// (get) Token: 0x06036D9A RID: 224666 RVA: 0x00F4BA59 File Offset: 0x00F49C59
		public int MyConfigId
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x170069E9 RID: 27113
		// (get) Token: 0x06036D9B RID: 224667 RVA: 0x00F4BA61 File Offset: 0x00F49C61
		public int MyTemplateId
		{
			get
			{
				return this.TemplateId;
			}
		}

		// Token: 0x170069EA RID: 27114
		// (get) Token: 0x06036D9C RID: 224668 RVA: 0x00F4BA69 File Offset: 0x00F49C69
		public int MyBoundSize
		{
			get
			{
				return this.BoundSize;
			}
		}

		// Token: 0x170069EB RID: 27115
		// (get) Token: 0x06036D9D RID: 224669 RVA: 0x00F4BA71 File Offset: 0x00F49C71
		public EDangoBrawlItemType MyType
		{
			get
			{
				return this.ConfigType;
			}
		}

		// Token: 0x170069EC RID: 27116
		// (get) Token: 0x06036D9E RID: 224670 RVA: 0x00F4BA79 File Offset: 0x00F49C79
		public EDangoBrawlTemplateType MyTemplateType
		{
			get
			{
				return this.TemplateType;
			}
		}

		// Token: 0x0401D0E8 RID: 119016
		private readonly int Uid;

		// Token: 0x0401D0E9 RID: 119017
		private readonly int ConfigId;

		// Token: 0x0401D0EA RID: 119018
		private readonly int TemplateId;

		// Token: 0x0401D0EB RID: 119019
		private readonly int BoundSize;

		// Token: 0x0401D0EC RID: 119020
		private readonly EDangoBrawlItemType ConfigType;

		// Token: 0x0401D0ED RID: 119021
		private readonly EDangoBrawlTemplateType TemplateType;
	}
}
