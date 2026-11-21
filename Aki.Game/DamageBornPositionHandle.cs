using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;

// Token: 0x02000EBE RID: 3774
[NullableContext(1)]
[Nullable(0)]
public class DamageBornPositionHandle
{
	// Token: 0x060096E7 RID: 38631 RVA: 0x002CB58C File Offset: 0x002C978C
	private DamageViewOffsetInfo SpawnDamageViewOffsetInfo()
	{
		if (this.DamageViewOffsetInfoPool.Count > 0)
		{
			int index = this.DamageViewOffsetInfoPool.Count - 1;
			DamageViewOffsetInfo result = this.DamageViewOffsetInfoPool[index];
			this.DamageViewOffsetInfoPool.RemoveAt(index);
			return result;
		}
		return new DamageViewOffsetInfo();
	}

	// Token: 0x060096E8 RID: 38632 RVA: 0x002CB5D3 File Offset: 0x002C97D3
	private void RecycleDamageViewOffsetInfo(DamageViewOffsetInfo info)
	{
		info.Reset();
		this.DamageViewOffsetInfoPool.Add(info);
	}

	// Token: 0x060096E9 RID: 38633 RVA: 0x002CB5E8 File Offset: 0x002C97E8
	public void Init()
	{
		this.GridWidth = ConfigCommonParamById.GetFloatConfig("DamageUiGridWidth").GetValueOrDefault(100f);
		this.GridHeight = ConfigCommonParamById.GetFloatConfig("DamageUiGridHeight").GetValueOrDefault(50f);
		this.GridRandomOffsetMax = ConfigCommonParamById.GetFloatConfig("DamageUiGridRandomOffsetMax").GetValueOrDefault(1f);
		this.GroupUpdateTime = (double)ConfigCommonParamById.GetFloatConfig("DamageUiGroupUpdateTime").GetValueOrDefault(2000f);
		float valueOrDefault = ConfigCommonParamById.GetFloatConfig("DamageUiScaleMinDist").GetValueOrDefault(1000f);
		this.ScaleMinDistSquared = (double)(valueOrDefault * valueOrDefault);
		float valueOrDefault2 = ConfigCommonParamById.GetFloatConfig("DamageUiScaleMaxDist").GetValueOrDefault(3000f);
		this.ScaleMaxDistSquared = (double)(valueOrDefault2 * valueOrDefault2);
		this.MinScaleByDist = ConfigCommonParamById.GetFloatConfig("DamageUiMinScaleByDist").GetValueOrDefault(0.5f);
		this.InitRandomGrids();
		this.Timer = TimerSystem.FlowTimeInstance.Forever(new TTimerAction(this.OnTimer), 10000f, 1f, null, null, true);
		IReadOnlyList<DamageTextArea> allDamageTextArea = DamageUiConfig.Instance.GetAllDamageTextArea();
		if (allDamageTextArea != null)
		{
			foreach (DamageTextArea value in allDamageTextArea)
			{
				this.DamageTextAreaMap.Add(value.Id, value);
			}
		}
	}

	// Token: 0x060096EA RID: 38634 RVA: 0x002CB758 File Offset: 0x002C9958
	public void Clear()
	{
		foreach (DamageViewOffsetInfo info in this.DamageViewOffsetMap.Values)
		{
			this.RecycleDamageViewOffsetInfo(info);
		}
		this.DamageViewOffsetMap.Clear();
		if (this.Timer != null && TimerSystem.FlowTimeInstance.Has(this.Timer))
		{
			TimerSystem.FlowTimeInstance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x060096EB RID: 38635 RVA: 0x002CB7F0 File Offset: 0x002C99F0
	private void InitRandomGrids()
	{
		this.RandomGrids.Clear();
		IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("DamageUiGridPos");
		if (floatArrayConfig == null || floatArrayConfig.Count == 0)
		{
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("DamageUiGridCount").GetValueOrDefault(3);
			float num = (float)(-(float)(valueOrDefault - 1)) * 0.5f;
			for (int i = 0; i < valueOrDefault; i++)
			{
				for (int j = 0; j < valueOrDefault; j++)
				{
					this.RandomGrids.Add(new float[]
					{
						(float)i - num,
						(float)j - num
					});
				}
			}
		}
		else
		{
			for (int k = 1; k < floatArrayConfig.Count; k += 2)
			{
				this.RandomGrids.Add(new float[]
				{
					floatArrayConfig[k - 1],
					floatArrayConfig[k]
				});
			}
		}
		this.GridTotalCount = this.RandomGrids.Count;
		if (ConfigCommonParamById.GetBoolConfig("DamageUiRandomGridIndex").GetValueOrDefault())
		{
			for (int l = this.RandomGrids.Count - 1; l > 0; l--)
			{
				int index = (int)Math.Floor(MathUtils.Instance.Random.NextDouble() * (double)(l + 1));
				float[] value = this.RandomGrids[l];
				this.RandomGrids[l] = this.RandomGrids[index];
				this.RandomGrids[index] = value;
			}
		}
	}

	// Token: 0x060096EC RID: 38636 RVA: 0x002CB956 File Offset: 0x002C9B56
	private void OnTimer(float delta)
	{
		this.CleanupExpiredGroupInfo();
	}

	// Token: 0x060096ED RID: 38637 RVA: 0x002CB960 File Offset: 0x002C9B60
	private void CleanupExpiredGroupInfo()
	{
		double num = Time.Instance.FlowTime - 5000.0;
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, DamageViewOffsetInfo> keyValuePair in this.DamageViewOffsetMap)
		{
			if (keyValuePair.Value.LastUpdateTime < num)
			{
				list.Add(keyValuePair.Key);
				this.RecycleDamageViewOffsetInfo(keyValuePair.Value);
			}
		}
		foreach (int key in list)
		{
			this.DamageViewOffsetMap.Remove(key);
		}
	}

	// Token: 0x060096EE RID: 38638 RVA: 0x002CBA38 File Offset: 0x002C9C38
	public DamageTextArea? GetDamageTextAreaById(int id)
	{
		DamageTextArea value;
		if (this.DamageTextAreaMap.TryGetValue(id, out value))
		{
			return new DamageTextArea?(value);
		}
		return null;
	}

	// Token: 0x060096EF RID: 38639 RVA: 0x002CBA68 File Offset: 0x002C9C68
	public void GetRandomOffset(int entityId, int damageTextAreaId, DamageViewData damageViewData, global::Vector damageLocation, Vector2D outV)
	{
		DamageViewOffsetInfo damageViewOffsetInfo;
		if (!this.DamageViewOffsetMap.TryGetValue(entityId, out damageViewOffsetInfo))
		{
			damageViewOffsetInfo = this.SpawnDamageViewOffsetInfo();
			this.DamageViewOffsetMap.Add(entityId, damageViewOffsetInfo);
		}
		if (Time.Instance.FlowTime - damageViewOffsetInfo.LastUpdateTime > this.GroupUpdateTime || damageTextAreaId != damageViewOffsetInfo.DamageTextAreaId)
		{
			damageViewOffsetInfo.DamageTextAreaId = damageTextAreaId;
			DamageTextArea? damageTextAreaById = this.GetDamageTextAreaById(damageTextAreaId);
			if (damageTextAreaById != null)
			{
				damageViewOffsetInfo.OffsetX = MathUtils.Instance.GetRandomFloatNumber((float)damageTextAreaById.Value.MinDeviationX, (float)damageTextAreaById.Value.MaxDeviationX);
				damageViewOffsetInfo.OffsetY = MathUtils.Instance.GetRandomFloatNumber((float)damageTextAreaById.Value.MinDeviationY, (float)damageTextAreaById.Value.MaxDeviationY);
			}
			else
			{
				damageViewOffsetInfo.OffsetX = MathUtils.Instance.GetRandomFloatNumber(damageViewData.MinRandomOffsetX, damageViewData.MaxRandomOffsetX);
				damageViewOffsetInfo.OffsetY = MathUtils.Instance.GetRandomFloatNumber(damageViewData.MinRandomOffsetY, damageViewData.MaxRandomOffsetY);
			}
			double num = global::Vector.DistSquared(CameraController.Instance.MainModel.CameraLocation, damageLocation);
			if (num <= this.ScaleMinDistSquared)
			{
				damageViewOffsetInfo.DistanceScale = 1f;
			}
			else if (num >= this.ScaleMaxDistSquared)
			{
				damageViewOffsetInfo.DistanceScale = this.MinScaleByDist;
			}
			else
			{
				damageViewOffsetInfo.DistanceScale = 1f - (float)((num - this.ScaleMinDistSquared) / (this.ScaleMaxDistSquared - this.ScaleMinDistSquared)) * (1f - this.MinScaleByDist);
			}
			damageViewOffsetInfo.LastUpdateTime = Time.Instance.FlowTime;
		}
		if (MathUtils.Instance.Random.NextDouble() > 0.5)
		{
			damageViewOffsetInfo.Index++;
		}
		else
		{
			damageViewOffsetInfo.Index += 2;
		}
		damageViewOffsetInfo.Index %= this.GridTotalCount;
		float[] array = this.RandomGrids[damageViewOffsetInfo.Index];
		outV.X = (double)((float)(((double)array[0] + MathUtils.Instance.Random.NextDouble() * (double)this.GridRandomOffsetMax) * (double)this.GridWidth + (double)damageViewOffsetInfo.OffsetX));
		outV.Y = (double)((float)(((double)array[1] + MathUtils.Instance.Random.NextDouble() * (double)this.GridRandomOffsetMax) * (double)this.GridHeight + (double)damageViewOffsetInfo.OffsetY));
		outV.X *= (double)damageViewOffsetInfo.DistanceScale;
		outV.Y *= (double)damageViewOffsetInfo.DistanceScale;
	}

	// Token: 0x04005AA6 RID: 23206
	private const double GROUP_INFO_LIFETIME = 5000.0;

	// Token: 0x04005AA7 RID: 23207
	private const float GROUP_INFO_CLEANUP_INTERVAL = 10000f;

	// Token: 0x04005AA8 RID: 23208
	private float GridWidth;

	// Token: 0x04005AA9 RID: 23209
	private float GridHeight;

	// Token: 0x04005AAA RID: 23210
	private int GridTotalCount;

	// Token: 0x04005AAB RID: 23211
	private float GridRandomOffsetMax;

	// Token: 0x04005AAC RID: 23212
	private double GroupUpdateTime;

	// Token: 0x04005AAD RID: 23213
	private double ScaleMinDistSquared;

	// Token: 0x04005AAE RID: 23214
	private double ScaleMaxDistSquared;

	// Token: 0x04005AAF RID: 23215
	private float MinScaleByDist;

	// Token: 0x04005AB0 RID: 23216
	private readonly Dictionary<int, DamageViewOffsetInfo> DamageViewOffsetMap = new Dictionary<int, DamageViewOffsetInfo>();

	// Token: 0x04005AB1 RID: 23217
	private readonly List<float[]> RandomGrids = new List<float[]>();

	// Token: 0x04005AB2 RID: 23218
	private readonly List<DamageViewOffsetInfo> DamageViewOffsetInfoPool = new List<DamageViewOffsetInfo>();

	// Token: 0x04005AB3 RID: 23219
	[Nullable(2)]
	private TimerHandle Timer;

	// Token: 0x04005AB4 RID: 23220
	private readonly Dictionary<int, DamageTextArea> DamageTextAreaMap = new Dictionary<int, DamageTextArea>();
}
