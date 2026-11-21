using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A4F RID: 6735
[NullableContext(1)]
[Nullable(0)]
public class PhotoWeatherData
{
	// Token: 0x060109EE RID: 68078 RVA: 0x004DD103 File Offset: 0x004DB303
	public PhotoWeatherData()
	{
	}

	// Token: 0x060109EF RID: 68079 RVA: 0x004DD10B File Offset: 0x004DB30B
	public PhotoWeatherData(int weatherId, PhotoWeather config)
	{
		this.WeatherId = weatherId;
		this.Config = new PhotoWeather?(config);
	}

	// Token: 0x1700192C RID: 6444
	// (get) Token: 0x060109F0 RID: 68080 RVA: 0x004DD126 File Offset: 0x004DB326
	public bool IsDefault
	{
		get
		{
			return this.Config == null;
		}
	}

	// Token: 0x1700192D RID: 6445
	// (get) Token: 0x060109F1 RID: 68081 RVA: 0x004DD138 File Offset: 0x004DB338
	public int PhotoWeatherType
	{
		get
		{
			if (this.Config == null)
			{
				return 0;
			}
			return this.Config.GetValueOrDefault().Id;
		}
	}

	// Token: 0x1700192E RID: 6446
	// (get) Token: 0x060109F2 RID: 68082 RVA: 0x004DD164 File Offset: 0x004DB364
	public string Icon
	{
		get
		{
			return ((this.Config != null) ? this.Config.GetValueOrDefault().Icon : null) ?? "";
		}
	}

	// Token: 0x1700192F RID: 6447
	// (get) Token: 0x060109F3 RID: 68083 RVA: 0x004DD19C File Offset: 0x004DB39C
	public string Name
	{
		get
		{
			return ((this.Config != null) ? this.Config.GetValueOrDefault().Name : null) ?? "";
		}
	}

	// Token: 0x0400930A RID: 37642
	public int WeatherId;

	// Token: 0x0400930B RID: 37643
	private readonly PhotoWeather? Config;
}
