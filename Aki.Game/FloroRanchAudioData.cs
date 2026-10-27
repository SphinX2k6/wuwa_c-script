using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AEE RID: 6894
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchAudioData
{
	// Token: 0x0600CC9F RID: 52383 RVA: 0x002EBED5 File Offset: 0x002EA0D5
	public FloroRanchAudioData(FloroRanchAudio config)
	{
		this.Config = config;
	}

	// Token: 0x0600CCA0 RID: 52384 RVA: 0x002EBEE4 File Offset: 0x002EA0E4
	public string GetAudioText()
	{
		return this.Config.Text;
	}

	// Token: 0x0600CCA1 RID: 52385 RVA: 0x002EBF00 File Offset: 0x002EA100
	public string GetAudioEvent()
	{
		return this.Config.AudioEvent;
	}

	// Token: 0x04005DF6 RID: 24054
	private readonly FloroRanchAudio Config;
}
