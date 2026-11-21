using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x02000240 RID: 576
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherDownLoadConfig
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00058DB3 File Offset: 0x00056FB3
		public string Title { get; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x00058DBB File Offset: 0x00056FBB
		public string ContentTitle { get; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00058DC3 File Offset: 0x00056FC3
		public string ContentTitleHd { get; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x00058DCB File Offset: 0x00056FCB
		public string ContentTitleSd { get; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00058DD3 File Offset: 0x00056FD3
		public string Content { get; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x00058DDB File Offset: 0x00056FDB
		public string ContentHd { get; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00058DE3 File Offset: 0x00056FE3
		public string ContentSd { get; }

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00058DEB File Offset: 0x00056FEB
		public LauncherDownLoadConfig(string title, string contentTitle, string contentTitleHd, string contentTitleSd, string content, string contentHd, string contentSd)
		{
			this.Title = title;
			this.ContentTitle = contentTitle;
			this.ContentTitleHd = contentTitleHd;
			this.ContentTitleSd = contentTitleSd;
			this.Content = content;
			this.ContentHd = contentHd;
			this.ContentSd = contentSd;
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00058E28 File Offset: 0x00057028
		public static string GetTableName()
		{
			return "DownLoadTab";
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00058E30 File Offset: 0x00057030
		public static LauncherDownLoadConfig Parse(UKuroSqliteResultSet rs)
		{
			string title = null;
			if (!rs.GetString("Title", ref title))
			{
				return null;
			}
			string contentTitle = null;
			if (!rs.GetString("ContentTitle", ref contentTitle))
			{
				return null;
			}
			string contentTitleHd = null;
			if (!rs.GetString("ContentTitleHD", ref contentTitleHd))
			{
				return null;
			}
			string contentTitleSd = null;
			if (!rs.GetString("ContentTitleSD", ref contentTitleSd))
			{
				return null;
			}
			string content = null;
			if (!rs.GetString("Content", ref content))
			{
				return null;
			}
			string contentHd = null;
			if (!rs.GetString("ContentHD", ref contentHd))
			{
				return null;
			}
			string contentSd = null;
			if (!rs.GetString("ContentSD", ref contentSd))
			{
				return null;
			}
			return new LauncherDownLoadConfig(title, contentTitle, contentTitleHd, contentTitleSd, content, contentHd, contentSd);
		}

		// Token: 0x04000974 RID: 2420
		private const string TableName = "DownLoadTab";
	}
}
