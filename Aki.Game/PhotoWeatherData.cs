using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002564 RID: 9572
[NullableContext(1)]
[Nullable(0)]
public class PhotoWeatherData
{
	// Token: 0x0601350C RID: 79116 RVA: 0x004CE4CB File Offset: 0x004CC6CB
	public PhotoWeatherData()
	{
	}

	// Token: 0x0601350D RID: 79117 RVA: 0x004CE4D3 File Offset: 0x004CC6D3
	public PhotoWeatherData(int weatherId, PhotoWeather config)
	{
		this.WeatherId = weatherId;
		this.Config = new PhotoWeather?(config);
	}

	// Token: 0x170018F2 RID: 6386
	// (get) Token: 0x0601350E RID: 79118 RVA: 0x004CE4EE File Offset: 0x004CC6EE
	public bool IsDefault
	{
		get
		{
			return this.Config == null;
		}
	}

	// Token: 0x170018F3 RID: 6387
	// (get) Token: 0x0601350F RID: 79119 RVA: 0x004CE500 File Offset: 0x004CC700
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

	// Token: 0x170018F4 RID: 6388
	// (get) Token: 0x06013510 RID: 79120 RVA: 0x004CE52C File Offset: 0x004CC72C
	public string Icon
	{
		get
		{
			return ((this.Config != null) ? this.Config.GetValueOrDefault().Icon : null) ?? "";
		}
	}

	// Token: 0x170018F5 RID: 6389
	// (get) Token: 0x06013511 RID: 79121 RVA: 0x004CE564 File Offset: 0x004CC764
	public string Name
	{
		get
		{
			return ((this.Config != null) ? this.Config.GetValueOrDefault().Name : null) ?? "";
		}
	}

	// Token: 0x040091B1 RID: 37297
	public int WeatherId;

	// Token: 0x040091B2 RID: 37298
	private readonly PhotoWeather? Config;
}
