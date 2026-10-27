using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000231 RID: 561
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E4D RID: 3661 RVA: 0x0005569F File Offset: 0x0005389F
		public VideoVersionInfo(bool hasContent) : base("video", "video", new Dictionary<string, string>())
		{
			this.hasContent = hasContent;
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000556BD File Offset: 0x000538BD
		public override void Init()
		{
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000556BF File Offset: 0x000538BF
		public override string GetResType()
		{
			return "Video";
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000556C6 File Offset: 0x000538C6
		public override bool HasContentOnRemote()
		{
			return this.hasContent;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x000556CE File Offset: 0x000538CE
		public override string ManifestHash
		{
			get
			{
				return "";
			}
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000556D5 File Offset: 0x000538D5
		public override bool UpdateVersionRecord()
		{
			return true;
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000556D8 File Offset: 0x000538D8
		public override bool ClearVersionRecord()
		{
			return true;
		}

		// Token: 0x040008F7 RID: 2295
		private readonly bool hasContent;
	}
}
