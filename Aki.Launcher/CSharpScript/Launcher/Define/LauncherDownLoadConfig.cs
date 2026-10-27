using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Define
{
	// Token: 0x0200023B RID: 571
	[NullableContext(1)]
	[Nullable(0)]
	public class LauncherDownLoadConfig
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000E7D RID: 3709 RVA: 0x000562AB File Offset: 0x000544AB
		public string Title { get; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x000562B3 File Offset: 0x000544B3
		public string ContentTitle { get; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000E7F RID: 3711 RVA: 0x000562BB File Offset: 0x000544BB
		public string ContentTitleHd { get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x000562C3 File Offset: 0x000544C3
		public string ContentTitleSd { get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000E81 RID: 3713 RVA: 0x000562CB File Offset: 0x000544CB
		public string Content { get; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000E82 RID: 3714 RVA: 0x000562D3 File Offset: 0x000544D3
		public string ContentHd { get; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000562DB File Offset: 0x000544DB
		public string ContentSd { get; }

		// Token: 0x06000E84 RID: 3716 RVA: 0x000562E3 File Offset: 0x000544E3
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

		// Token: 0x06000E85 RID: 3717 RVA: 0x00056320 File Offset: 0x00054520
		public static string GetTableName()
		{
			return "DownLoadTab";
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x00056328 File Offset: 0x00054528
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

		// Token: 0x04000932 RID: 2354
		private const string TableName = "DownLoadTab";
	}
}
