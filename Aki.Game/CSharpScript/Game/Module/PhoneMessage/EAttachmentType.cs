using System;
using System.Runtime.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020040BC RID: 16572
	[EnumExtensions]
	public enum EAttachmentType
	{
		// Token: 0x04016D7B RID: 93563
		[EnumMember(Value = "Image")]
		Image,
		// Token: 0x04016D7C RID: 93564
		[EnumMember(Value = "Spine")]
		Spine,
		// Token: 0x04016D7D RID: 93565
		[EnumMember(Value = "Mp4")]
		Mp4
	}
}
