using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000FAD RID: 4013
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchAudioData
{
	// Token: 0x0600A0B0 RID: 41136 RVA: 0x002F6FC1 File Offset: 0x002F51C1
	public FloroRanchAudioData(FloroRanchAudio config)
	{
		this.Config = config;
	}

	// Token: 0x0600A0B1 RID: 41137 RVA: 0x002F6FD0 File Offset: 0x002F51D0
	public string GetAudioText()
	{
		return this.Config.Text;
	}

	// Token: 0x0600A0B2 RID: 41138 RVA: 0x002F6FEC File Offset: 0x002F51EC
	public string GetAudioEvent()
	{
		return this.Config.AudioEvent;
	}

	// Token: 0x04005EC5 RID: 24261
	private readonly FloroRanchAudio Config;
}
