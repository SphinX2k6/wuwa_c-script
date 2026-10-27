using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000E8C RID: 3724
[NullableContext(1)]
[Nullable(0)]
public class KscUtil : IStaticVariableResetter
{
	// Token: 0x06005B30 RID: 23344 RVA: 0x0010A6E7 File Offset: 0x001088E7
	static KscUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KscUtil.CreateStaticDefaultValue), new Action(KscUtil.ResetStaticDefaultValue));
	}

	// Token: 0x06005B31 RID: 23345 RVA: 0x0010A706 File Offset: 0x00108906
	public static void CreateStaticDefaultValue()
	{
		KscUtil.KscWorldHandle = 0;
	}

	// Token: 0x06005B32 RID: 23346 RVA: 0x0010A70E File Offset: 0x0010890E
	public static void ResetStaticDefaultValue()
	{
		KscUtil.KscWorldHandle = 0;
	}

	// Token: 0x06005B33 RID: 23347 RVA: 0x0010A716 File Offset: 0x00108916
	public static void SetKscWorldHandle(int value)
	{
		KscUtil.KscWorldHandle = value;
	}

	// Token: 0x06005B34 RID: 23348 RVA: 0x0010A71E File Offset: 0x0010891E
	public static List<T> GetDtRows<[Nullable(0)] T>([Nullable(2)] UDataTable dt) where T : FKSCTableRowBase
	{
		return DataTableUtil.GetDataTableAllRowFromTable<T>(dt);
	}

	// Token: 0x06005B35 RID: 23349 RVA: 0x0010A728 File Offset: 0x00108928
	public static void LoadDt<[Nullable(0)] T>([Nullable(2)] UObject context, string path, [Nullable(new byte[]
	{
		2,
		0,
		1,
		1
	})] Dictionary<int, ValueTuple<T, string>> rowContainer) where T : FKSCTableRowBase
	{
		if (string.IsNullOrEmpty(path))
		{
			return;
		}
		UDataTable udataTable = ResourceSystem.Instance.Load<UDataTable>(path, "js_undefined");
		if (udataTable != null)
		{
			List<T> dtRows = KscUtil.GetDtRows<T>(udataTable);
			for (int i = 0; i < dtRows.Count; i++)
			{
				T t = dtRows[i];
				string item = t.RuntimeDA.ToAssetPathName();
				if (rowContainer != null)
				{
					rowContainer[t.Id] = new ValueTuple<T, string>(t, item);
				}
			}
		}
	}

	// Token: 0x06005B36 RID: 23350 RVA: 0x0010A7A0 File Offset: 0x001089A0
	[NullableContext(2)]
	public static string AssetPath2Name(string assetPath)
	{
		if (string.IsNullOrEmpty(assetPath))
		{
			return null;
		}
		string[] array = assetPath.Split('.', StringSplitOptions.None);
		if (array.Length == 0)
		{
			return assetPath;
		}
		return array[array.Length - 1];
	}

	// Token: 0x06005B37 RID: 23351 RVA: 0x0010A7D0 File Offset: 0x001089D0
	public static void AsyncLoadKscAsset<[Nullable(0)] TD>(LoadAssetParams<TD> params_) where TD : UDataAsset
	{
		ResourceSystem.Instance.LoadAsync<UObject>(params_.Path, delegate([Nullable(2)] UObject resultAsset, string resultPath)
		{
			if (resultAsset == null || !resultAsset.IsValid())
			{
				string text = "[加载Ksc资产] 失败 " + params_.Path;
				KscLog.Error(KscLog.EModule.Load, ELogAuthor.PZ, params_.Context, text, default(ReadOnlySpan<ValueTuple<string, object>>));
				Action<string> failCallback = params_.FailCallback;
				if (failCallback == null)
				{
					return;
				}
				failCallback(text);
				return;
			}
			else if (params_.KscWorldHandle != KscUtil.KscWorldHandle)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 3);
				defaultInterpolatedStringHandler.AppendLiteral("[加载Ksc资产] 场景不一致, ");
				defaultInterpolatedStringHandler.AppendFormatted(params_.Path);
				defaultInterpolatedStringHandler.AppendLiteral(", LoadHandle: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(params_.KscWorldHandle);
				defaultInterpolatedStringHandler.AppendLiteral(", CurHandle: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(KscUtil.KscWorldHandle);
				string text2 = defaultInterpolatedStringHandler.ToStringAndClear();
				KscLog.Info(KscLog.EModule.Load, ELogAuthor.CX, params_.Context, text2, default(ReadOnlySpan<ValueTuple<string, object>>));
				TD key = (TD)((object)resultAsset);
				TMap<TD, int> nativeContainer = params_.NativeContainer;
				if (nativeContainer != null)
				{
					nativeContainer.Add(key, params_.Id);
				}
				Action<string> failCallback2 = params_.FailCallback;
				if (failCallback2 == null)
				{
					return;
				}
				failCallback2(text2);
				return;
			}
			else
			{
				bool isBuildDevelopmentOrDebug = Info.Instance.IsBuildDevelopmentOrDebug;
				TD td = (TD)((object)resultAsset);
				TMap<TD, int> nativeContainer2 = params_.NativeContainer;
				if (nativeContainer2 != null)
				{
					nativeContainer2.Add(td, params_.Id);
				}
				Action<TD> callback = params_.Callback;
				if (callback == null)
				{
					return;
				}
				callback(td);
				return;
			}
		}, 100, "js_undefined");
	}

	// Token: 0x06005B38 RID: 23352 RVA: 0x0010A814 File Offset: 0x00108A14
	public static void AsyncLoadKscAssetDt<[Nullable(0)] T, [Nullable(0)] TD>([Nullable(2)] UObject context, string path, [Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<int, string> dtModelContainer, [Nullable(new byte[]
	{
		2,
		1,
		0,
		1,
		1
	})] Dictionary<string, ValueTuple<string, TD>> daModelContainer, [Nullable(new byte[]
	{
		2,
		1
	})] TMap<TD, int> nativeContainer) where T : UnrealScriptStructProxy where TD : UDataAsset
	{
		ResourceSystem.Instance.LoadAsync<UObject>(path, delegate([Nullable(2)] UObject asset, string path_)
		{
			if (asset == null || !asset.IsValid())
			{
				KscLog.EModule flag = KscLog.EModule.Load;
				ELogAuthor author = ELogAuthor.PZ;
				UObject context2 = context;
				string log = "[DT加载] 失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path_);
				KscLog.Error(flag, author, context2, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			List<FKSCTableRowBase> dtRows = KscUtil.GetDtRows<FKSCTableRowBase>((UDataTable)asset);
			for (int i = 0; i < dtRows.Count; i++)
			{
				FKSCTableRowBase fksctableRowBase = dtRows[i];
				int id = fksctableRowBase.Id;
				string text = fksctableRowBase.RuntimeDA.ToAssetPathName();
				if (dtModelContainer != null)
				{
					dtModelContainer[id] = text;
				}
				KscUtil.AsyncLoadKscAsset<TD>(new LoadAssetParams<TD>
				{
					Context = context,
					Id = id,
					Path = text,
					NativeContainer = nativeContainer,
					KscWorldHandle = KscUtil.KscWorldHandle
				});
			}
		}, ResourceSystem.EResourceLoadPriority.Default, "js_undefined");
	}

	// Token: 0x06005B39 RID: 23353 RVA: 0x0010A85C File Offset: 0x00108A5C
	public static Dictionary<int, int[]> GetFollowerSkillIdsByProxies(int[] proxyIds)
	{
		Dictionary<int, int[]> dictionary = new Dictionary<int, int[]>();
		if (proxyIds.Length != 0)
		{
			foreach (int num in proxyIds)
			{
				TrapDefenseAuxiliary? config = ConfigTrapDefenseAuxiliaryById.GetConfig(num, true);
				int[] array = (config != null) ? config.GetValueOrDefault().InitSkills() : null;
				if (array != null)
				{
					dictionary[num] = array;
				}
			}
		}
		return dictionary;
	}

	// Token: 0x06005B3A RID: 23354 RVA: 0x0010A8BC File Offset: 0x00108ABC
	public static int[] GetFollowerSkillIdsByProxy(int proxyId)
	{
		int[] result = new int[0];
		TrapDefenseAuxiliary? config = ConfigTrapDefenseAuxiliaryById.GetConfig(proxyId, true);
		int[] array = (config != null) ? config.GetValueOrDefault().InitSkills() : null;
		if (array != null)
		{
			result = array;
		}
		return result;
	}

	// Token: 0x06005B3B RID: 23355 RVA: 0x0010A8FC File Offset: 0x00108AFC
	public static int? GetFollowerCdSkillByProxy(int proxyId)
	{
		TrapDefenseAuxiliary? config = ConfigTrapDefenseAuxiliaryById.GetConfig(proxyId, true);
		if (config == null)
		{
			return null;
		}
		return new int?(config.GetValueOrDefault().CDSkill);
	}

	// Token: 0x06005B3C RID: 23356 RVA: 0x0010A938 File Offset: 0x00108B38
	[NullableContext(2)]
	public static int[] GetFollowerCueIds(int proxyId)
	{
		TrapDefenseAuxiliary? config = ConfigTrapDefenseAuxiliaryById.GetConfig(proxyId, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().CueIds();
	}

	// Token: 0x06005B3D RID: 23357 RVA: 0x0010A968 File Offset: 0x00108B68
	[NullableContext(2)]
	public static int[] GetFollowerCdCueIds(int proxyId, TDPlayerDefine.EFollowerState state)
	{
		TrapDefenseAuxiliary? config = ConfigTrapDefenseAuxiliaryById.GetConfig(proxyId, true);
		if (config == null)
		{
			return null;
		}
		if (state == TDPlayerDefine.EFollowerState.InCD)
		{
			return config.Value.CDCueId();
		}
		if (state == TDPlayerDefine.EFollowerState.CDReady)
		{
			return config.Value.ReadyCueId();
		}
		return null;
	}

	// Token: 0x06005B3E RID: 23358 RVA: 0x0010A9B4 File Offset: 0x00108BB4
	public static int? GetFollowerPropertyIdByProxy(int proxyId)
	{
		TrapDefenseAuxiliary? config = ConfigTrapDefenseAuxiliaryById.GetConfig(proxyId, true);
		if (config == null)
		{
			return null;
		}
		return new int?(config.GetValueOrDefault().InitProperty);
	}

	// Token: 0x06005B3F RID: 23359 RVA: 0x0010A9F0 File Offset: 0x00108BF0
	[NullableContext(2)]
	public static Dictionary<EKSC_AttrType, float> GetFollowerAttrsByProxy(int proxyId)
	{
		Dictionary<EKSC_AttrType, float> result = new Dictionary<EKSC_AttrType, float>();
		int? followerPropertyIdByProxy = KscUtil.GetFollowerPropertyIdByProxy(proxyId);
		if (followerPropertyIdByProxy == null)
		{
			KscLog.EModule flag = KscLog.EModule.Attr;
			ELogAuthor author = ELogAuthor.PZ;
			UObject gameInstance = GlobalData.GameInstance;
			string log = "塔防获取辅助机属性配置异常";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("辅助机proxy id", proxyId);
			KscLog.Warn(flag, author, gameInstance, log, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return result;
		}
		KscSubControllerBase curSubController = KuroSimpleCombatController.Instance.CurSubController;
		if (curSubController != null)
		{
			return curSubController.GetAttrsDefault(followerPropertyIdByProxy.Value);
		}
		KSCBaseProperty? config = ConfigKSCBasePropertyById.GetConfig(followerPropertyIdByProxy.Value, true);
		if (config == null)
		{
			KscLog.EModule flag2 = KscLog.EModule.Attr;
			ELogAuthor author2 = ELogAuthor.CFT;
			UObject gameInstance2 = GlobalData.GameInstance;
			string log2 = "KSC获取属性配置异常";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("propertyId", followerPropertyIdByProxy);
			KscLog.Error(flag2, author2, gameInstance2, log2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return KscUtil.GetAttrsDataByPropertyConfig(config.Value);
	}

	// Token: 0x06005B40 RID: 23360 RVA: 0x0010AAAC File Offset: 0x00108CAC
	public static Dictionary<string, object> GetAttrsDataMapByType<[Nullable(2)] T>(T config)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		foreach (FieldInfo fieldInfo in config.GetType().GetFields(BindingFlags.Public))
		{
			dictionary[fieldInfo.Name] = fieldInfo.GetValue(config);
		}
		return dictionary;
	}

	// Token: 0x06005B41 RID: 23361 RVA: 0x0010AB00 File Offset: 0x00108D00
	public static Dictionary<EKSC_AttrType, float> GetAttrsDataByPropertyConfig(KSCBaseProperty config)
	{
		return new Dictionary<EKSC_AttrType, float>
		{
			{
				EKSC_AttrType.Lv,
				(float)config.Lv
			},
			{
				EKSC_AttrType.LifeMax,
				(float)config.LifeMax
			},
			{
				EKSC_AttrType.BaseLife,
				(float)config.LifeMax
			},
			{
				EKSC_AttrType.Life,
				(float)config.Life
			},
			{
				EKSC_AttrType.Shield,
				(float)config.Sheild
			},
			{
				EKSC_AttrType.Atk,
				(float)config.Atk
			},
			{
				EKSC_AttrType.Crit,
				(float)config.Crit
			},
			{
				EKSC_AttrType.CritDamage,
				(float)config.CritDamage
			},
			{
				EKSC_AttrType.Def,
				(float)config.Def
			},
			{
				EKSC_AttrType.MoveSpeed,
				(float)config.MoveSpeed
			},
			{
				EKSC_AttrType.SkillCoolDown,
				(float)config.SkillCoolDown
			},
			{
				EKSC_AttrType.SkillCoolDownChangeMin,
				(float)config.SkillCoolDownChangeMin
			},
			{
				EKSC_AttrType.DamageChangePhys,
				(float)config.DamageChangePhys
			},
			{
				EKSC_AttrType.DamageChangeElement1,
				(float)config.DamageChangeElement1
			},
			{
				EKSC_AttrType.DamageChangeElement2,
				(float)config.DamageChangeElement2
			},
			{
				EKSC_AttrType.DamageChangeElement3,
				(float)config.DamageChangeElement3
			},
			{
				EKSC_AttrType.DamageChangeElement4,
				(float)config.DamageChangeElement4
			},
			{
				EKSC_AttrType.DamageChangeElement5,
				(float)config.DamageChangeElement5
			},
			{
				EKSC_AttrType.DamageChangeElement6,
				(float)config.DamageChangeElement6
			},
			{
				EKSC_AttrType.DamageResistancePhys,
				(float)config.DamageResistancePhys
			},
			{
				EKSC_AttrType.DamageResistanceElement1,
				(float)config.DamageResistanceElement1
			},
			{
				EKSC_AttrType.DamageResistanceElement2,
				(float)config.DamageResistanceElement2
			},
			{
				EKSC_AttrType.DamageResistanceElement3,
				(float)config.DamageResistanceElement3
			},
			{
				EKSC_AttrType.DamageResistanceElement4,
				(float)config.DamageResistanceElement4
			},
			{
				EKSC_AttrType.DamageResistanceElement5,
				(float)config.DamageResistanceElement5
			},
			{
				EKSC_AttrType.DamageResistanceElement6,
				(float)config.DamageResistanceElement6
			},
			{
				EKSC_AttrType.HealChange,
				(float)config.HealChange
			},
			{
				EKSC_AttrType.HealedChange,
				(float)config.HealedChange
			},
			{
				EKSC_AttrType.DamageReducePhys,
				(float)config.DamageReducePhys
			},
			{
				EKSC_AttrType.DamageReduceElement1,
				(float)config.DamageReduceElement1
			},
			{
				EKSC_AttrType.DamageReduceElement2,
				(float)config.DamageReduceElement2
			},
			{
				EKSC_AttrType.DamageReduceElement3,
				(float)config.DamageReduceElement3
			},
			{
				EKSC_AttrType.DamageReduceElement4,
				(float)config.DamageReduceElement4
			},
			{
				EKSC_AttrType.DamageReduceElement5,
				(float)config.DamageReduceElement5
			},
			{
				EKSC_AttrType.DamageReduceElement6,
				(float)config.DamageReduceElement6
			},
			{
				EKSC_AttrType.IgnoreDefRate,
				(float)config.IgnoreDefRate
			},
			{
				EKSC_AttrType.IgnoreDamageResistancePhys,
				(float)config.IgnoreDamageResistancePhys
			},
			{
				EKSC_AttrType.IgnoreDamageResistanceElement1,
				(float)config.IgnoreDamageResistanceElement1
			},
			{
				EKSC_AttrType.IgnoreDamageResistanceElement2,
				(float)config.IgnoreDamageResistanceElement2
			},
			{
				EKSC_AttrType.IgnoreDamageResistanceElement3,
				(float)config.IgnoreDamageResistanceElement3
			},
			{
				EKSC_AttrType.IgnoreDamageResistanceElement4,
				(float)config.IgnoreDamageResistanceElement4
			},
			{
				EKSC_AttrType.IgnoreDamageResistanceElement5,
				(float)config.IgnoreDamageResistanceElement5
			},
			{
				EKSC_AttrType.IgnoreDamageResistanceElement6,
				(float)config.IgnoreDamageResistanceElement6
			},
			{
				EKSC_AttrType.DamageAmplify1,
				(float)config.DamageAmplify1
			},
			{
				EKSC_AttrType.DamageAmplify2,
				(float)config.DamageAmplify2
			}
		};
	}

	// Token: 0x06005B42 RID: 23362 RVA: 0x0010ADE0 File Offset: 0x00108FE0
	public static Dictionary<int, int> ToBuffParam(int[] bornBuff, [Nullable(2)] HashSet<int> bornBuffSet = null)
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (int key in bornBuff)
		{
			dictionary[key] = 1;
		}
		if (bornBuffSet != null)
		{
			foreach (int key2 in bornBuffSet)
			{
				dictionary[key2] = 1;
			}
		}
		return dictionary;
	}

	// Token: 0x040029AC RID: 10668
	private static int KscWorldHandle;
}
