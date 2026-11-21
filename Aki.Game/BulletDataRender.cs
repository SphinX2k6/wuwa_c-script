using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x0200230B RID: 8971
[NullableContext(1)]
[Nullable(0)]
public class BulletDataRender
{
	// Token: 0x170021F5 RID: 8693
	// (get) Token: 0x0601622F RID: 90671 RVA: 0x0066EF39 File Offset: 0x0066D139
	public FName VictimCameraShakeOnHit
	{
		get
		{
			if (this.VictimCameraShakeOnHitInternal == null)
			{
				this.VictimCameraShakeOnHitInternal = new FName?(this.Data.命中时受击者震屏.GetAssetPathName());
			}
			return this.VictimCameraShakeOnHitInternal.Value;
		}
	}

	// Token: 0x170021F6 RID: 8694
	// (get) Token: 0x06016230 RID: 90672 RVA: 0x0066EF6E File Offset: 0x0066D16E
	public FName AttackerCameraShakeOnHit
	{
		get
		{
			if (this.AttackerCameraShakeOnHitInternal == null)
			{
				this.AttackerCameraShakeOnHitInternal = new FName?(this.Data.命中时攻击者震屏.GetAssetPathName());
			}
			return this.AttackerCameraShakeOnHitInternal.Value;
		}
	}

	// Token: 0x170021F7 RID: 8695
	// (get) Token: 0x06016231 RID: 90673 RVA: 0x0066EFA4 File Offset: 0x0066D1A4
	public Dictionary<EBulletHitEffect, FName> EffectOnHit
	{
		get
		{
			if (this.EffectOnHitInternal == null)
			{
				this.EffectOnHitInternal = new Dictionary<EBulletHitEffect, FName>();
				foreach (KeyValuePair<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>> keyValuePair in this.Data.命中特效DA)
				{
					TEnumAsByte<EBulletHitEffect> tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr;
					keyValuePair.Deconstruct(out tenumAsByte, out tsoftObjectPtr);
					TEnumAsByte<EBulletHitEffect> value = tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr2 = tsoftObjectPtr;
					this.EffectOnHitInternal.Add(value, tsoftObjectPtr2.GetAssetPathName());
				}
			}
			return this.EffectOnHitInternal;
		}
	}

	// Token: 0x170021F8 RID: 8696
	// (get) Token: 0x06016232 RID: 90674 RVA: 0x0066F038 File Offset: 0x0066D238
	public string AudioOnHit
	{
		get
		{
			if (this.AudioOnHitInternal == null)
			{
				this.AudioOnHitInternal = this.Data.命中音效;
			}
			return this.AudioOnHitInternal;
		}
	}

	// Token: 0x170021F9 RID: 8697
	// (get) Token: 0x06016233 RID: 90675 RVA: 0x0066F05C File Offset: 0x0066D25C
	public Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf> EffectOnHitConf
	{
		get
		{
			if (this.EffectOnHitConfInternal == null)
			{
				this.EffectOnHitConfInternal = new Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf>();
				TArray<SBulletEffectOnHitConf> 命中特效配置 = this.Data.命中特效配置;
				int num = 命中特效配置.Num();
				for (int i = 0; i < num; i++)
				{
					SBulletEffectOnHitConf sbulletEffectOnHitConf = 命中特效配置.Get(i);
					BulletHitEffectConf value = new BulletHitEffectConf(sbulletEffectOnHitConf);
					this.EffectOnHitConfInternal.Add((global::EBulletEffectOnHitType)sbulletEffectOnHitConf.类型, value);
				}
			}
			return this.EffectOnHitConfInternal;
		}
	}

	// Token: 0x170021FA RID: 8698
	// (get) Token: 0x06016234 RID: 90676 RVA: 0x0066F0C9 File Offset: 0x0066D2C9
	public FName EffectBullet
	{
		get
		{
			if (this.EffectBulletInternal == null)
			{
				this.EffectBulletInternal = new FName?(this.Data.子弹特效DA.GetAssetPathName());
			}
			return this.EffectBulletInternal.Value;
		}
	}

	// Token: 0x170021FB RID: 8699
	// (get) Token: 0x06016235 RID: 90677 RVA: 0x0066F100 File Offset: 0x0066D300
	public Dictionary<int, string> EffectBulletParams
	{
		get
		{
			if (this.EffectBulletParamsInternal == null)
			{
				this.EffectBulletParamsInternal = new Dictionary<int, string>();
				foreach (KeyValuePair<TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletEffectParam>, string> keyValuePair in this.Data.子弹特效DA参数)
				{
					TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletEffectParam> tenumAsByte;
					string text;
					keyValuePair.Deconstruct(out tenumAsByte, out text);
					TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletEffectParam> value = tenumAsByte;
					string value2 = text;
					this.EffectBulletParamsInternal.Add((int)value, value2);
				}
			}
			return this.EffectBulletParamsInternal;
		}
	}

	// Token: 0x170021FC RID: 8700
	// (get) Token: 0x06016236 RID: 90678 RVA: 0x0066F190 File Offset: 0x0066D390
	public bool EffectStopInsteadDestroy
	{
		get
		{
			if (this.EffectStopInsteadDestroyInternal == null)
			{
				this.EffectStopInsteadDestroyInternal = new bool?(this.Data.子弹销毁调用子弹停止特效);
			}
			return this.EffectStopInsteadDestroyInternal.Value;
		}
	}

	// Token: 0x170021FD RID: 8701
	// (get) Token: 0x06016237 RID: 90679 RVA: 0x0066F1C0 File Offset: 0x0066D3C0
	public bool HandOverParentEffect
	{
		get
		{
			if (this.HandOverParentEffectInternal == null)
			{
				this.HandOverParentEffectInternal = new bool?(this.Data.接手父子弹的特效);
			}
			return this.HandOverParentEffectInternal.Value;
		}
	}

	// Token: 0x170021FE RID: 8702
	// (get) Token: 0x06016238 RID: 90680 RVA: 0x0066F1F0 File Offset: 0x0066D3F0
	public int CameraShakeCountMax
	{
		get
		{
			if (this.CameraShakeCountMaxInternal == null)
			{
				this.CameraShakeCountMaxInternal = new int?(this.Data.最大震动次数);
			}
			return this.CameraShakeCountMaxInternal.Value;
		}
	}

	// Token: 0x170021FF RID: 8703
	// (get) Token: 0x06016239 RID: 90681 RVA: 0x0066F220 File Offset: 0x0066D420
	public Dictionary<EBulletSpecificEffect, FName> SpecialEffect
	{
		get
		{
			if (this.SpecialEffectInternal == null)
			{
				this.SpecialEffectInternal = new Dictionary<EBulletSpecificEffect, FName>();
				foreach (KeyValuePair<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>> keyValuePair in this.Data.特殊特效DA)
				{
					TEnumAsByte<EBulletSpecificEffect> tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr;
					keyValuePair.Deconstruct(out tenumAsByte, out tsoftObjectPtr);
					TEnumAsByte<EBulletSpecificEffect> value = tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr2 = tsoftObjectPtr;
					this.SpecialEffectInternal.Add(value, tsoftObjectPtr2.GetAssetPathName());
				}
			}
			return this.SpecialEffectInternal;
		}
	}

	// Token: 0x17002200 RID: 8704
	// (get) Token: 0x0601623A RID: 90682 RVA: 0x0066F2B4 File Offset: 0x0066D4B4
	public FName AttackerCameraShakeOnStart
	{
		get
		{
			if (this.AttackerCameraShakeOnStartInternal == null)
			{
				this.AttackerCameraShakeOnStartInternal = new FName?(this.Data.生成时攻击者震屏.GetAssetPathName());
			}
			return this.AttackerCameraShakeOnStartInternal.Value;
		}
	}

	// Token: 0x17002201 RID: 8705
	// (get) Token: 0x0601623B RID: 90683 RVA: 0x0066F2E9 File Offset: 0x0066D4E9
	public bool CameraShakeToSummonOwner
	{
		get
		{
			if (this.CameraShakeToSummonOwnerInternal == null)
			{
				this.CameraShakeToSummonOwnerInternal = new bool?(this.Data.震屏关联到召唤兽主人);
			}
			return this.CameraShakeToSummonOwnerInternal.Value;
		}
	}

	// Token: 0x17002202 RID: 8706
	// (get) Token: 0x0601623C RID: 90684 RVA: 0x0066F319 File Offset: 0x0066D519
	public FName AttackerCameraShakeOnHitWeakPoint
	{
		get
		{
			if (this.AttackerCameraShakeOnHitWeakPointInternal == null)
			{
				this.AttackerCameraShakeOnHitWeakPointInternal = new FName?(this.Data.命中弱点时攻击者震屏.GetAssetPathName());
			}
			return this.AttackerCameraShakeOnHitWeakPointInternal.Value;
		}
	}

	// Token: 0x17002203 RID: 8707
	// (get) Token: 0x0601623D RID: 90685 RVA: 0x0066F34E File Offset: 0x0066D54E
	public FName OnHitMaterialEffect
	{
		get
		{
			if (this.OnHitMaterialEffectInternal == null)
			{
				this.OnHitMaterialEffectInternal = new FName?(this.Data.受击闪白.GetAssetPathName());
			}
			return this.OnHitMaterialEffectInternal.Value;
		}
	}

	// Token: 0x0601623E RID: 90686 RVA: 0x0066F383 File Offset: 0x0066D583
	public BulletDataRender(SReBulletDataPerformance data)
	{
		this.Data = data;
	}

	// Token: 0x0601623F RID: 90687 RVA: 0x0066F394 File Offset: 0x0066D594
	public bool Preload()
	{
		FName effectBullet = this.EffectBullet;
		bool handOverParentEffect = this.HandOverParentEffect;
		int cameraShakeCountMax = this.CameraShakeCountMax;
		Dictionary<EBulletSpecificEffect, FName> specialEffect = this.SpecialEffect;
		FName attackerCameraShakeOnStart = this.AttackerCameraShakeOnStart;
		string audioOnHit = this.AudioOnHit;
		Dictionary<int, string> effectBulletParams = this.EffectBulletParams;
		Dictionary<EBulletHitEffect, FName> effectOnHit = this.EffectOnHit;
		Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf> effectOnHitConf = this.EffectOnHitConf;
		FName victimCameraShakeOnHit = this.VictimCameraShakeOnHit;
		FName attackerCameraShakeOnHit = this.AttackerCameraShakeOnHit;
		bool effectStopInsteadDestroy = this.EffectStopInsteadDestroy;
		bool cameraShakeToSummonOwner = this.CameraShakeToSummonOwner;
		FName attackerCameraShakeOnHitWeakPoint = this.AttackerCameraShakeOnHitWeakPoint;
		FName onHitMaterialEffect = this.OnHitMaterialEffect;
		return true;
	}

	// Token: 0x0400BA2D RID: 47661
	[Nullable(2)]
	private readonly SReBulletDataPerformance Data;

	// Token: 0x0400BA2E RID: 47662
	private FName? VictimCameraShakeOnHitInternal;

	// Token: 0x0400BA2F RID: 47663
	private FName? AttackerCameraShakeOnHitInternal;

	// Token: 0x0400BA30 RID: 47664
	[Nullable(2)]
	private Dictionary<EBulletHitEffect, FName> EffectOnHitInternal;

	// Token: 0x0400BA31 RID: 47665
	[Nullable(2)]
	private string AudioOnHitInternal;

	// Token: 0x0400BA32 RID: 47666
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf> EffectOnHitConfInternal;

	// Token: 0x0400BA33 RID: 47667
	private FName? EffectBulletInternal;

	// Token: 0x0400BA34 RID: 47668
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> EffectBulletParamsInternal;

	// Token: 0x0400BA35 RID: 47669
	private bool? EffectStopInsteadDestroyInternal;

	// Token: 0x0400BA36 RID: 47670
	private bool? HandOverParentEffectInternal;

	// Token: 0x0400BA37 RID: 47671
	private int? CameraShakeCountMaxInternal;

	// Token: 0x0400BA38 RID: 47672
	[Nullable(2)]
	private Dictionary<EBulletSpecificEffect, FName> SpecialEffectInternal;

	// Token: 0x0400BA39 RID: 47673
	private FName? AttackerCameraShakeOnStartInternal;

	// Token: 0x0400BA3A RID: 47674
	private bool? CameraShakeToSummonOwnerInternal;

	// Token: 0x0400BA3B RID: 47675
	private FName? AttackerCameraShakeOnHitWeakPointInternal;

	// Token: 0x0400BA3C RID: 47676
	private FName? OnHitMaterialEffectInternal;
}
