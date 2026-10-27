using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001DC9 RID: 7625
[NullableContext(1)]
[Nullable(0)]
public class GuidePrefabDefine : IStaticVariableResetter
{
	// Token: 0x0600E7FB RID: 59387 RVA: 0x0036CF78 File Offset: 0x0036B178
	static GuidePrefabDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuidePrefabDefine.CreateStaticDefaultValue), new Action(GuidePrefabDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600E7FC RID: 59388 RVA: 0x0036CF98 File Offset: 0x0036B198
	public static void CreateStaticDefaultValue()
	{
		Dictionary<string, GuidePrefabDefine.IPrefabSettingValue> dictionary = new Dictionary<string, GuidePrefabDefine.IPrefabSettingValue>();
		string key = "FightConcertoStateGuide";
		GuidePrefabDefine.PrefabSettingValue prefabSettingValue = new GuidePrefabDefine.PrefabSettingValue();
		prefabSettingValue.GetPrefabPathFunc = delegate(string[] args)
		{
			List<string> res = new List<string>();
			SceneTeamModel.Instance.GetTeamEntities(true).ToList<EntityHandle>().ForEach(delegate(EntityHandle roleEntity)
			{
				res.Add("/Game/Aki/UI/UIResources/UiFight/Prefabs/FightConcertoState.FightConcertoState");
			});
			return res.ToArray();
		};
		prefabSettingValue.Callback = delegate(AActor[] actors, string[] args)
		{
			List<EntityHandle> list = SceneTeamModel.Instance.GetTeamEntities(true).ToList<EntityHandle>();
			int index;
			int index2;
			for (index = 0; index < list.Count; index = index2 + 1)
			{
				EntityHandle roleEntity = list[index];
				if (index < actors.Length)
				{
					ConcertoResponseItem item = new ConcertoResponseItem();
					item.CreateByActorAsync(actors[index], null, false).ContinueWith(delegate()
					{
						item.Refresh(BattleUiModel.Instance.GetRoleData(roleEntity.Id));
						(actors[index].GetComponentByClass(UUIItem.StaticClass()) as UUIItem).SetUIActive(true);
					});
				}
				index2 = index;
			}
		};
		dictionary.Add(key, prefabSettingValue);
		GuidePrefabDefine.predefPrefabSetting = dictionary;
	}

	// Token: 0x0600E7FD RID: 59389 RVA: 0x0036D009 File Offset: 0x0036B209
	public static void ResetStaticDefaultValue()
	{
		GuidePrefabDefine.predefPrefabSetting = null;
	}

	// Token: 0x0600E7FE RID: 59390 RVA: 0x0036D014 File Offset: 0x0036B214
	public static void setPrefabText(UUIText text, string content)
	{
		StringBuilder stringBuilder = new StringBuilder();
		List<GuidePrefabDefine.IPrefabConf> prefabas = new List<GuidePrefabDefine.IPrefabConf>();
		List<string> list = new List<string>();
		List<int> prefabSlice = new List<int>();
		int num = 0;
		int i = 0;
		while (i < content.Length)
		{
			int num2 = content.IndexOf('[', i);
			if (num2 == -1)
			{
				stringBuilder.Append(content.Substring(i, content.Length - i));
				break;
			}
			stringBuilder.Append(content.Substring(i, num2 - i));
			int num3 = content.IndexOf(']', num2);
			if (num3 <= num2)
			{
				stringBuilder.Append(content.Substring(num2 + 1, content.Length - num2 - 1));
				break;
			}
			string[] array = content.Substring(num2 + 1, num3 - num2 - 1).Split(',', StringSplitOptions.None);
			if (array.Length == 0)
			{
				return;
			}
			prefabas.Add(new GuidePrefabDefine.PrefabConf
			{
				PrefabKey = array[0],
				Args = array
			});
			GuidePrefabDefine.IPrefabSettingValue prefabSettingValue;
			if (!GuidePrefabDefine.predefPrefabSetting.TryGetValue(array[0], out prefabSettingValue))
			{
				return;
			}
			string[] array2 = prefabSettingValue.GetPrefabPathFunc(array);
			prefabSlice.Add(array2.Length);
			list.AddRange(array2);
			i = num3 + 1;
			for (int j = 0; j < array2.Length; j++)
			{
				stringBuilder.Append("<snidx=");
				stringBuilder.Append(num);
				stringBuilder.Append("/>");
				num++;
			}
		}
		LguiUtil.Instance.LoadAndSetText(text, stringBuilder.ToString(), list.ToArray(), delegate(AActor[] objects)
		{
			int num4 = 0;
			for (int k = 0; k < prefabas.Count; k++)
			{
				GuidePrefabDefine.IPrefabConf prefabConf = prefabas[k];
				GuidePrefabDefine.IPrefabSettingValue prefabSettingValue2;
				if (GuidePrefabDefine.predefPrefabSetting.TryGetValue(prefabConf.PrefabKey, out prefabSettingValue2) && prefabSettingValue2 != null && prefabSettingValue2.Callback != null)
				{
					prefabSettingValue2.Callback(objects.Skip(num4).Take(prefabSlice[k]).ToArray<AActor>(), prefabConf.Args);
				}
				num4 += prefabSlice[k];
			}
		}, "js_undefined");
	}

	// Token: 0x04006B54 RID: 27476
	public const string NEW_TAG = "New:";

	// Token: 0x04006B55 RID: 27477
	public static Dictionary<string, GuidePrefabDefine.IPrefabSettingValue> predefPrefabSetting;

	// Token: 0x0200839E RID: 33694
	public interface IPrefabSettingValue
	{
		// Token: 0x1700A06B RID: 41067
		// (get) Token: 0x0604A4BA RID: 304314
		// (set) Token: 0x0604A4BB RID: 304315
		Func<string[], string[]> GetPrefabPathFunc { get; set; }

		// Token: 0x1700A06C RID: 41068
		// (get) Token: 0x0604A4BC RID: 304316
		// (set) Token: 0x0604A4BD RID: 304317
		Action<AActor[], string[]> Callback { get; set; }
	}

	// Token: 0x0200839F RID: 33695
	[Nullable(0)]
	public class PrefabSettingValue : GuidePrefabDefine.IPrefabSettingValue
	{
		// Token: 0x1700A06D RID: 41069
		// (get) Token: 0x0604A4BE RID: 304318 RVA: 0x0135692E File Offset: 0x01354B2E
		// (set) Token: 0x0604A4BF RID: 304319 RVA: 0x01356936 File Offset: 0x01354B36
		public Func<string[], string[]> GetPrefabPathFunc { get; set; }

		// Token: 0x1700A06E RID: 41070
		// (get) Token: 0x0604A4C0 RID: 304320 RVA: 0x0135693F File Offset: 0x01354B3F
		// (set) Token: 0x0604A4C1 RID: 304321 RVA: 0x01356947 File Offset: 0x01354B47
		public Action<AActor[], string[]> Callback { get; set; }
	}

	// Token: 0x020083A0 RID: 33696
	public interface IPrefabConf
	{
		// Token: 0x1700A06F RID: 41071
		// (get) Token: 0x0604A4C3 RID: 304323
		// (set) Token: 0x0604A4C4 RID: 304324
		string PrefabKey { get; set; }

		// Token: 0x1700A070 RID: 41072
		// (get) Token: 0x0604A4C5 RID: 304325
		// (set) Token: 0x0604A4C6 RID: 304326
		string[] Args { get; set; }
	}

	// Token: 0x020083A1 RID: 33697
	[Nullable(0)]
	public class PrefabConf : GuidePrefabDefine.IPrefabConf
	{
		// Token: 0x1700A071 RID: 41073
		// (get) Token: 0x0604A4C7 RID: 304327 RVA: 0x01356958 File Offset: 0x01354B58
		// (set) Token: 0x0604A4C8 RID: 304328 RVA: 0x01356960 File Offset: 0x01354B60
		public string PrefabKey { get; set; }

		// Token: 0x1700A072 RID: 41074
		// (get) Token: 0x0604A4C9 RID: 304329 RVA: 0x01356969 File Offset: 0x01354B69
		// (set) Token: 0x0604A4CA RID: 304330 RVA: 0x01356971 File Offset: 0x01354B71
		public string[] Args { get; set; }
	}
}
