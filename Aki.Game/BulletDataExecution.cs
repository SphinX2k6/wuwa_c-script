using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002305 RID: 8965
[NullableContext(1)]
[Nullable(0)]
public class BulletDataExecution
{
	// Token: 0x170021B8 RID: 8632
	// (get) Token: 0x060161E0 RID: 90592 RVA: 0x0066DA61 File Offset: 0x0066BC61
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<LogicDataBase> GbDataList
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			this.InitGbGroup();
			return this.GbDataListInternal;
		}
	}

	// Token: 0x170021B9 RID: 8633
	// (get) Token: 0x060161E1 RID: 90593 RVA: 0x0066DA6F File Offset: 0x0066BC6F
	public bool HasRebound
	{
		get
		{
			return this.HasReboundInternal;
		}
	}

	// Token: 0x170021BA RID: 8634
	// (get) Token: 0x060161E2 RID: 90594 RVA: 0x0066DA77 File Offset: 0x0066BC77
	public bool HasCollision
	{
		get
		{
			return this.HasCollisionInternal;
		}
	}

	// Token: 0x060161E3 RID: 90595 RVA: 0x0066DA80 File Offset: 0x0066BC80
	public void InitGbGroup()
	{
		if (this.GbGroupInternalInit)
		{
			return;
		}
		this.GbGroupInternalInit = true;
		FName assetPathName = this.Data.GB组.GetAssetPathName();
		if (assetPathName != FName.NAME_None)
		{
			this.ActionGroup = ResourceSystem.Instance.Load<UKuroBpDataAssetGroup>(assetPathName.ToString(), "js_undefined");
			UKuroBpDataAssetGroup actionGroup = this.ActionGroup;
			TArray<UKuroBpDataAsset> tarray = (actionGroup != null) ? actionGroup.Data : null;
			int num = (tarray != null) ? tarray.Num() : 0;
			if (num > 0)
			{
				this.GbDataListInternal = new List<LogicDataBase>();
				this.SupportCamp = new List<ECamp>();
				this.ReboundBitMask = 0;
				for (int i = 0; i < num; i++)
				{
					LogicDataBase logicDataBase = tarray.Get(i) as LogicDataBase;
					this.GbDataListInternal.Add(logicDataBase);
					if (!this.HasReboundInternal && logicDataBase is LogicDataRebound)
					{
						this.HasReboundInternal = true;
					}
					if (!this.HasCollisionInternal && logicDataBase is LogicDataBulletCollision)
					{
						this.HasCollisionInternal = true;
					}
				}
			}
		}
	}

	// Token: 0x170021BB RID: 8635
	// (get) Token: 0x060161E4 RID: 90596 RVA: 0x0066DB78 File Offset: 0x0066BD78
	[Nullable(2)]
	public int[] TagIdOnVictimEnter
	{
		[NullableContext(2)]
		get
		{
			if (!this.TagIdOnVictimEnterInit)
			{
				this.TagIdOnVictimEnterInit = true;
				SReBulletDataExe data = this.Data;
				TArray<FGameplayTag> tarray = (data != null) ? data.受击对象进入添加Tag.GameplayTags : null;
				int num = (tarray != null) ? tarray.Num() : 0;
				if (num > 0)
				{
					this.TagIdOnVictimEnterInternal = new int[num];
					for (int i = 0; i < num; i++)
					{
						FGameplayTag tag = tarray.Get(i);
						this.TagIdOnVictimEnterInternal[i] = tag.TagId();
					}
				}
			}
			return this.TagIdOnVictimEnterInternal;
		}
	}

	// Token: 0x170021BC RID: 8636
	// (get) Token: 0x060161E5 RID: 90597 RVA: 0x0066DBF4 File Offset: 0x0066BDF4
	public long[] GeIdApplyToVictim
	{
		get
		{
			if (this.GeIdApplyToVictimInternal == null)
			{
				TArray<long> 受击对象进入应用的GE的Id = this.Data.受击对象进入应用的GE的Id;
				this.GeIdApplyToVictimInternal = new long[受击对象进入应用的GE的Id.Count];
				受击对象进入应用的GE的Id.AsSpan<long>().CopyTo(this.GeIdApplyToVictimInternal);
			}
			return this.GeIdApplyToVictimInternal;
		}
	}

	// Token: 0x170021BD RID: 8637
	// (get) Token: 0x060161E6 RID: 90598 RVA: 0x0066DC45 File Offset: 0x0066BE45
	public bool WaitEnterGeReply
	{
		get
		{
			if (this.WaitEnterGeReplyInternal == null)
			{
				this.WaitEnterGeReplyInternal = new bool?(this.Data.等待回包过程中不重复触发进入GE);
			}
			return this.WaitEnterGeReplyInternal.Value;
		}
	}

	// Token: 0x170021BE RID: 8638
	// (get) Token: 0x060161E7 RID: 90599 RVA: 0x0066DC75 File Offset: 0x0066BE75
	public FGameplayTag SendGameplayEventTagToVictim
	{
		get
		{
			if (this.SendGameplayEventTagToVictimInternal == null)
			{
				this.SendGameplayEventTagToVictimInternal = new FGameplayTag?(this.Data.命中后对受击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToVictimInternal.Value;
		}
	}

	// Token: 0x170021BF RID: 8639
	// (get) Token: 0x060161E8 RID: 90600 RVA: 0x0066DCA8 File Offset: 0x0066BEA8
	public long[] SendGeIdToVictim
	{
		get
		{
			if (this.SendGeIdToVictimInternal == null)
			{
				TArray<long> 命中后对受击者应用GE的Id = this.Data.命中后对受击者应用GE的Id;
				this.SendGeIdToVictimInternal = new long[命中后对受击者应用GE的Id.Num()];
				命中后对受击者应用GE的Id.AsSpan<long>().CopyTo(this.SendGeIdToVictimInternal);
			}
			return this.SendGeIdToVictimInternal;
		}
	}

	// Token: 0x170021C0 RID: 8640
	// (get) Token: 0x060161E9 RID: 90601 RVA: 0x0066DCFC File Offset: 0x0066BEFC
	public long[] SendGeIdToRoleInGame
	{
		get
		{
			if (this.SendGeIdToRoleInGameInternal == null)
			{
				TArray<long> 命中后对在场上角色应用的GE的Id = this.Data.命中后对在场上角色应用的GE的Id;
				this.SendGeIdToRoleInGameInternal = new long[命中后对在场上角色应用的GE的Id.Num()];
				命中后对在场上角色应用的GE的Id.AsSpan<long>().CopyTo(this.SendGeIdToRoleInGameInternal);
			}
			return this.SendGeIdToRoleInGameInternal;
		}
	}

	// Token: 0x170021C1 RID: 8641
	// (get) Token: 0x060161EA RID: 90602 RVA: 0x0066DD4D File Offset: 0x0066BF4D
	public FGameplayTag SendGameplayEventTagToAttacker
	{
		get
		{
			if (this.SendGameplayEventTagToAttackerInternal == null)
			{
				this.SendGameplayEventTagToAttackerInternal = new FGameplayTag?(this.Data.命中后对攻击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToAttackerInternal.Value;
		}
	}

	// Token: 0x170021C2 RID: 8642
	// (get) Token: 0x060161EB RID: 90603 RVA: 0x0066DD80 File Offset: 0x0066BF80
	public long[] SendGeIdToAttacker
	{
		get
		{
			if (this.SendGeIdToAttackerInternal == null)
			{
				TArray<long> 命中后对攻击者应用GE的Id = this.Data.命中后对攻击者应用GE的Id;
				this.SendGeIdToAttackerInternal = new long[命中后对攻击者应用GE的Id.Num()];
				命中后对攻击者应用GE的Id.AsSpan<long>().CopyTo(this.SendGeIdToAttackerInternal);
			}
			return this.SendGeIdToAttackerInternal;
		}
	}

	// Token: 0x170021C3 RID: 8643
	// (get) Token: 0x060161EC RID: 90604 RVA: 0x0066DDD1 File Offset: 0x0066BFD1
	public FGameplayTag SendGameplayEventTagToAttackerOnEnd
	{
		get
		{
			if (this.SendGameplayEventTagToAttackerOnEndInternal == null)
			{
				this.SendGameplayEventTagToAttackerOnEndInternal = new FGameplayTag?(this.Data.结束时对攻击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToAttackerOnEndInternal.Value;
		}
	}

	// Token: 0x170021C4 RID: 8644
	// (get) Token: 0x060161ED RID: 90605 RVA: 0x0066DE04 File Offset: 0x0066C004
	public long[] EnergyRecoverGeIds
	{
		get
		{
			if (this.EnergyRecoverGeIdsInternal == null)
			{
				TArray<long> 能量恢复类GE数组的Id = this.Data.能量恢复类GE数组的Id;
				this.EnergyRecoverGeIdsInternal = new long[能量恢复类GE数组的Id.Num()];
				能量恢复类GE数组的Id.AsSpan<long>().CopyTo(this.EnergyRecoverGeIdsInternal);
			}
			return this.EnergyRecoverGeIdsInternal;
		}
	}

	// Token: 0x170021C5 RID: 8645
	// (get) Token: 0x060161EE RID: 90606 RVA: 0x0066DE55 File Offset: 0x0066C055
	public FGameplayTag SendGameplayEventTagToAttackerOnStart
	{
		get
		{
			if (this.SendGameplayEventTagToAttackerOnStartInternal == null)
			{
				this.SendGameplayEventTagToAttackerOnStartInternal = new FGameplayTag?(this.Data.生成时对攻击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToAttackerOnStartInternal.Value;
		}
	}

	// Token: 0x060161EF RID: 90607 RVA: 0x0066DE85 File Offset: 0x0066C085
	public BulletDataExecution(SReBulletDataExe data)
	{
		this.Data = data;
	}

	// Token: 0x060161F0 RID: 90608 RVA: 0x0066DE94 File Offset: 0x0066C094
	public bool Preload()
	{
		this.InitGbGroup();
		return true;
	}

	// Token: 0x0400B9CC RID: 47564
	[Nullable(2)]
	private readonly SReBulletDataExe Data;

	// Token: 0x0400B9CD RID: 47565
	private bool GbGroupInternalInit;

	// Token: 0x0400B9CE RID: 47566
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LogicDataBase> GbDataListInternal;

	// Token: 0x0400B9CF RID: 47567
	public bool MovementReplaced;

	// Token: 0x0400B9D0 RID: 47568
	public int ReboundBitMask;

	// Token: 0x0400B9D1 RID: 47569
	[Nullable(2)]
	public List<ECamp> SupportCamp;

	// Token: 0x0400B9D2 RID: 47570
	private bool HasReboundInternal;

	// Token: 0x0400B9D3 RID: 47571
	private bool HasCollisionInternal;

	// Token: 0x0400B9D4 RID: 47572
	[Nullable(2)]
	private UKuroBpDataAssetGroup ActionGroup;

	// Token: 0x0400B9D5 RID: 47573
	private bool TagIdOnVictimEnterInit;

	// Token: 0x0400B9D6 RID: 47574
	[Nullable(2)]
	private int[] TagIdOnVictimEnterInternal;

	// Token: 0x0400B9D7 RID: 47575
	[Nullable(2)]
	private long[] GeIdApplyToVictimInternal;

	// Token: 0x0400B9D8 RID: 47576
	private bool? WaitEnterGeReplyInternal;

	// Token: 0x0400B9D9 RID: 47577
	private FGameplayTag? SendGameplayEventTagToVictimInternal;

	// Token: 0x0400B9DA RID: 47578
	[Nullable(2)]
	private long[] SendGeIdToVictimInternal;

	// Token: 0x0400B9DB RID: 47579
	[Nullable(2)]
	private long[] SendGeIdToRoleInGameInternal;

	// Token: 0x0400B9DC RID: 47580
	private FGameplayTag? SendGameplayEventTagToAttackerInternal;

	// Token: 0x0400B9DD RID: 47581
	[Nullable(2)]
	private long[] SendGeIdToAttackerInternal;

	// Token: 0x0400B9DE RID: 47582
	private FGameplayTag? SendGameplayEventTagToAttackerOnEndInternal;

	// Token: 0x0400B9DF RID: 47583
	[Nullable(2)]
	private long[] EnergyRecoverGeIdsInternal;

	// Token: 0x0400B9E0 RID: 47584
	private FGameplayTag? SendGameplayEventTagToAttackerOnStartInternal;
}
