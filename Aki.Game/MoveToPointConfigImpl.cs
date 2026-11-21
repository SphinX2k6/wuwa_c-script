using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;

// Token: 0x0200265D RID: 9821
[NullableContext(2)]
[Nullable(0)]
public class MoveToPointConfigImpl : IMoveToPointConfig
{
	// Token: 0x170026D0 RID: 9936
	// (get) Token: 0x06018958 RID: 100696 RVA: 0x007745C7 File Offset: 0x007727C7
	// (set) Token: 0x06018959 RID: 100697 RVA: 0x007745CF File Offset: 0x007727CF
	[Nullable(1)]
	public Vector Position { [NullableContext(1)] get; [NullableContext(1)] set; }

	// Token: 0x170026D1 RID: 9937
	// (get) Token: 0x0601895A RID: 100698 RVA: 0x007745D8 File Offset: 0x007727D8
	// (set) Token: 0x0601895B RID: 100699 RVA: 0x007745E0 File Offset: 0x007727E0
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<Vector> ReferencePosition { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170026D2 RID: 9938
	// (get) Token: 0x0601895C RID: 100700 RVA: 0x007745E9 File Offset: 0x007727E9
	// (set) Token: 0x0601895D RID: 100701 RVA: 0x007745F1 File Offset: 0x007727F1
	public bool? IsFly { get; set; }

	// Token: 0x170026D3 RID: 9939
	// (get) Token: 0x0601895E RID: 100702 RVA: 0x007745FA File Offset: 0x007727FA
	// (set) Token: 0x0601895F RID: 100703 RVA: 0x00774602 File Offset: 0x00772802
	public bool? IsForward { get; set; }

	// Token: 0x170026D4 RID: 9940
	// (get) Token: 0x06018960 RID: 100704 RVA: 0x0077460B File Offset: 0x0077280B
	// (set) Token: 0x06018961 RID: 100705 RVA: 0x00774613 File Offset: 0x00772813
	public double? Distance { get; set; }

	// Token: 0x170026D5 RID: 9941
	// (get) Token: 0x06018962 RID: 100706 RVA: 0x0077461C File Offset: 0x0077281C
	// (set) Token: 0x06018963 RID: 100707 RVA: 0x00774624 File Offset: 0x00772824
	public ECharMoveState? MoveState { get; set; }

	// Token: 0x170026D6 RID: 9942
	// (get) Token: 0x06018964 RID: 100708 RVA: 0x0077462D File Offset: 0x0077282D
	// (set) Token: 0x06018965 RID: 100709 RVA: 0x00774635 File Offset: 0x00772835
	public float? MoveSpeed { get; set; }

	// Token: 0x170026D7 RID: 9943
	// (get) Token: 0x06018966 RID: 100710 RVA: 0x0077463E File Offset: 0x0077283E
	// (set) Token: 0x06018967 RID: 100711 RVA: 0x00774646 File Offset: 0x00772846
	public float? TurnSpeed { get; set; }

	// Token: 0x170026D8 RID: 9944
	// (get) Token: 0x06018968 RID: 100712 RVA: 0x0077464F File Offset: 0x0077284F
	// (set) Token: 0x06018969 RID: 100713 RVA: 0x00774657 File Offset: 0x00772857
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Queue<Vector> NextMovePointConfig { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170026D9 RID: 9945
	// (get) Token: 0x0601896A RID: 100714 RVA: 0x00774660 File Offset: 0x00772860
	// (set) Token: 0x0601896B RID: 100715 RVA: 0x00774668 File Offset: 0x00772868
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELevelEventState>> CallbackList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x170026DA RID: 9946
	// (get) Token: 0x0601896C RID: 100716 RVA: 0x00774671 File Offset: 0x00772871
	// (set) Token: 0x0601896D RID: 100717 RVA: 0x00774679 File Offset: 0x00772879
	public Func<bool> ResetCondition { get; set; }

	// Token: 0x170026DB RID: 9947
	// (get) Token: 0x0601896E RID: 100718 RVA: 0x00774682 File Offset: 0x00772882
	// (set) Token: 0x0601896F RID: 100719 RVA: 0x0077468A File Offset: 0x0077288A
	public bool? UseNearestDirection { get; set; }

	// Token: 0x170026DC RID: 9948
	// (get) Token: 0x06018970 RID: 100720 RVA: 0x00774693 File Offset: 0x00772893
	// (set) Token: 0x06018971 RID: 100721 RVA: 0x0077469B File Offset: 0x0077289B
	public Vector FaceToPosition { get; set; }

	// Token: 0x170026DD RID: 9949
	// (get) Token: 0x06018972 RID: 100722 RVA: 0x007746A4 File Offset: 0x007728A4
	// (set) Token: 0x06018973 RID: 100723 RVA: 0x007746AC File Offset: 0x007728AC
	public float? ReturnTimeoutFailed { get; set; }

	// Token: 0x170026DE RID: 9950
	// (get) Token: 0x06018974 RID: 100724 RVA: 0x007746B5 File Offset: 0x007728B5
	// (set) Token: 0x06018975 RID: 100725 RVA: 0x007746BD File Offset: 0x007728BD
	public bool? ForceResetOnLargeDelta { get; set; }

	// Token: 0x170026DF RID: 9951
	// (get) Token: 0x06018976 RID: 100726 RVA: 0x007746C6 File Offset: 0x007728C6
	// (set) Token: 0x06018977 RID: 100727 RVA: 0x007746CE File Offset: 0x007728CE
	public int? LargeDeltaResetMinMove { get; set; }
}
