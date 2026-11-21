using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.DiffPatch.Data
{
	// Token: 0x02000236 RID: 566
	[NullableContext(1)]
	[Nullable(0)]
	public class VideoVersionInfo : ResVersionInfo
	{
		// Token: 0x06000E8E RID: 3726 RVA: 0x000581A7 File Offset: 0x000563A7
		public VideoVersionInfo(bool hasContent) : base("video", "video", new Dictionary<string, string>())
		{
			this.hasContent = hasContent;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x000581C5 File Offset: 0x000563C5
		public override void Init()
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x000581C7 File Offset: 0x000563C7
		public override string GetResType()
		{
			return "Video";
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x000581CE File Offset: 0x000563CE
		public override bool HasContentOnRemote()
		{
			return this.hasContent;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x000581D6 File Offset: 0x000563D6
		public override string ManifestHash
		{
			get
			{
				return "";
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x000581DD File Offset: 0x000563DD
		public override bool UpdateVersionRecord()
		{
			return true;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000581E0 File Offset: 0x000563E0
		public override bool ClearVersionRecord()
		{
			return true;
		}

		// Token: 0x04000939 RID: 2361
		private readonly bool hasContent;
	}
}
