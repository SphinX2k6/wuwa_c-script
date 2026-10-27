using System;
using System.Runtime.Serialization;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.PhoneMessage
{
	// Token: 0x020050EC RID: 20716
	[EnumExtensions]
	public enum EAttachmentType
	{
		// Token: 0x0401C348 RID: 115528
		[EnumMember(Value = "Image")]
		Image,
		// Token: 0x0401C349 RID: 115529
		[EnumMember(Value = "Spine")]
		Spine,
		// Token: 0x0401C34A RID: 115530
		[EnumMember(Value = "Mp4")]
		Mp4
	}
}
