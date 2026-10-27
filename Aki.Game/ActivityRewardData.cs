using System;
using System.Runtime.CompilerServices;

// Token: 0x020010A9 RID: 4265
[NullableContext(2)]
[Nullable(0)]
public class ActivityRewardData : IActivityRewardData
{
	// Token: 0x17000933 RID: 2355
	// (get) Token: 0x06006EEE RID: 28398 RVA: 0x0016B313 File Offset: 0x00169513
	// (set) Token: 0x06006EEF RID: 28399 RVA: 0x0016B31B File Offset: 0x0016951B
	public int? Id { get; set; }

	// Token: 0x17000934 RID: 2356
	// (get) Token: 0x06006EF0 RID: 28400 RVA: 0x0016B324 File Offset: 0x00169524
	// (set) Token: 0x06006EF1 RID: 28401 RVA: 0x0016B32C File Offset: 0x0016952C
	[Nullable(1)]
	public string NameText { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x17000935 RID: 2357
	// (get) Token: 0x06006EF2 RID: 28402 RVA: 0x0016B335 File Offset: 0x00169535
	// (set) Token: 0x06006EF3 RID: 28403 RVA: 0x0016B33D File Offset: 0x0016953D
	public string NameTextId { get; set; }

	// Token: 0x17000936 RID: 2358
	// (get) Token: 0x06006EF4 RID: 28404 RVA: 0x0016B346 File Offset: 0x00169546
	// (set) Token: 0x06006EF5 RID: 28405 RVA: 0x0016B34E File Offset: 0x0016954E
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] NameTextArgs { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000937 RID: 2359
	// (get) Token: 0x06006EF6 RID: 28406 RVA: 0x0016B357 File Offset: 0x00169557
	// (set) Token: 0x06006EF7 RID: 28407 RVA: 0x0016B35F File Offset: 0x0016955F
	public TItem[] RewardList { get; set; }

	// Token: 0x17000938 RID: 2360
	// (get) Token: 0x06006EF8 RID: 28408 RVA: 0x0016B368 File Offset: 0x00169568
	// (set) Token: 0x06006EF9 RID: 28409 RVA: 0x0016B370 File Offset: 0x00169570
	public EActivityRewardState RewardState { get; set; }

	// Token: 0x17000939 RID: 2361
	// (get) Token: 0x06006EFA RID: 28410 RVA: 0x0016B379 File Offset: 0x00169579
	// (set) Token: 0x06006EFB RID: 28411 RVA: 0x0016B381 File Offset: 0x00169581
	public string RewardButtonTextId { get; set; }

	// Token: 0x1700093A RID: 2362
	// (get) Token: 0x06006EFC RID: 28412 RVA: 0x0016B38A File Offset: 0x0016958A
	// (set) Token: 0x06006EFD RID: 28413 RVA: 0x0016B392 File Offset: 0x00169592
	public string RewardButtonText { get; set; }

	// Token: 0x1700093B RID: 2363
	// (get) Token: 0x06006EFE RID: 28414 RVA: 0x0016B39B File Offset: 0x0016959B
	// (set) Token: 0x06006EFF RID: 28415 RVA: 0x0016B3A3 File Offset: 0x001695A3
	public bool? RewardButtonRedDot { get; set; }

	// Token: 0x1700093C RID: 2364
	// (get) Token: 0x06006F00 RID: 28416 RVA: 0x0016B3AC File Offset: 0x001695AC
	// (set) Token: 0x06006F01 RID: 28417 RVA: 0x0016B3B4 File Offset: 0x001695B4
	public Action ClickFunction { get; set; }

	// Token: 0x1700093D RID: 2365
	// (get) Token: 0x06006F02 RID: 28418 RVA: 0x0016B3BD File Offset: 0x001695BD
	// (set) Token: 0x06006F03 RID: 28419 RVA: 0x0016B3C5 File Offset: 0x001695C5
	public bool? ClickFunctionAndCloseSelf { get; set; }

	// Token: 0x1700093E RID: 2366
	// (get) Token: 0x06006F04 RID: 28420 RVA: 0x0016B3CE File Offset: 0x001695CE
	// (set) Token: 0x06006F05 RID: 28421 RVA: 0x0016B3D6 File Offset: 0x001695D6
	public string ProgressText { get; set; }
}
