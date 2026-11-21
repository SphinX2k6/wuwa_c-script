using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200128B RID: 4747
[NullableContext(1)]
[Nullable(0)]
public class GuidePrefabDefine : IStaticVariableResetter
{
	// Token: 0x0600BC1A RID: 48154 RVA: 0x00378C78 File Offset: 0x00376E78
	static GuidePrefabDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuidePrefabDefine.CreateStaticDefaultValue), new Action(GuidePrefabDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600BC1B RID: 48155 RVA: 0x00378C98 File Offset: 0x00376E98
	public static void CreateStaticDefaultValue()
	{
		Dictionary<string, GuidePrefabDefine.IPrefabSettingValue> dictionary = new Dictionary<string, GuidePrefabDefine.IPrefabSettingValue>();
		string key = "FightConcertoStateGuide";
		GuidePrefabDefine.PrefabSettingValue prefabSettingValue = new GuidePrefabDefine.PrefabSettingValue();
		prefabSettingValue.GetPrefabPathFunc = delegate(string[] args)
		{
			List<string> list = new List<string>();
			foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(true))
			{
				list.Add("/Game/Aki/UI/UIResources/UiFight/Prefabs/FightConcertoState.FightConcertoState");
			}
			return list.ToArray();
		};
		prefabSettingValue.Callback = delegate(AActor[] actors, string[] args)
		{
			List<EntityHandle> teamEntities = SceneTeamModel.Instance.GetTeamEntities(true);
			int index;
			int index2;
			for (index = 0; index < teamEntities.Count; index = index2 + 1)
			{
				EntityHandle roleEntity = teamEntities[index];
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

	// Token: 0x0600BC1C RID: 48156 RVA: 0x00378D09 File Offset: 0x00376F09
	public static void ResetStaticDefaultValue()
	{
		GuidePrefabDefine.predefPrefabSetting = null;
	}

	// Token: 0x0600BC1D RID: 48157 RVA: 0x00378D14 File Offset: 0x00376F14
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
					int num5 = (num4 < objects.Length) ? num4 : objects.Length;
					int num6 = prefabSlice[k];
					if (num6 > objects.Length - num5)
					{
						num6 = objects.Length - num5;
					}
					if (num6 < 0)
					{
						num6 = 0;
					}
					AActor[] array3 = new AActor[num6];
					Array.Copy(objects, num5, array3, 0, num6);
					prefabSettingValue2.Callback(array3, prefabConf.Args);
				}
				num4 += prefabSlice[k];
			}
		}, "js_undefined");
	}

	// Token: 0x04006C35 RID: 27701
	public const string NEW_TAG = "New:";

	// Token: 0x04006C36 RID: 27702
	public static Dictionary<string, GuidePrefabDefine.IPrefabSettingValue> predefPrefabSetting;

	// Token: 0x02007526 RID: 29990
	public interface IPrefabSettingValue
	{
		// Token: 0x17007809 RID: 30729
		// (get) Token: 0x060408BD RID: 264381
		// (set) Token: 0x060408BE RID: 264382
		Func<string[], string[]> GetPrefabPathFunc { get; set; }

		// Token: 0x1700780A RID: 30730
		// (get) Token: 0x060408BF RID: 264383
		// (set) Token: 0x060408C0 RID: 264384
		Action<AActor[], string[]> Callback { get; set; }
	}

	// Token: 0x02007527 RID: 29991
	[Nullable(0)]
	public class PrefabSettingValue : GuidePrefabDefine.IPrefabSettingValue
	{
		// Token: 0x1700780B RID: 30731
		// (get) Token: 0x060408C1 RID: 264385 RVA: 0x012F9D52 File Offset: 0x012F7F52
		// (set) Token: 0x060408C2 RID: 264386 RVA: 0x012F9D5A File Offset: 0x012F7F5A
		public Func<string[], string[]> GetPrefabPathFunc { get; set; }

		// Token: 0x1700780C RID: 30732
		// (get) Token: 0x060408C3 RID: 264387 RVA: 0x012F9D63 File Offset: 0x012F7F63
		// (set) Token: 0x060408C4 RID: 264388 RVA: 0x012F9D6B File Offset: 0x012F7F6B
		public Action<AActor[], string[]> Callback { get; set; }
	}

	// Token: 0x02007528 RID: 29992
	public interface IPrefabConf
	{
		// Token: 0x1700780D RID: 30733
		// (get) Token: 0x060408C6 RID: 264390
		// (set) Token: 0x060408C7 RID: 264391
		string PrefabKey { get; set; }

		// Token: 0x1700780E RID: 30734
		// (get) Token: 0x060408C8 RID: 264392
		// (set) Token: 0x060408C9 RID: 264393
		string[] Args { get; set; }
	}

	// Token: 0x02007529 RID: 29993
	[Nullable(0)]
	public class PrefabConf : GuidePrefabDefine.IPrefabConf
	{
		// Token: 0x1700780F RID: 30735
		// (get) Token: 0x060408CA RID: 264394 RVA: 0x012F9D7C File Offset: 0x012F7F7C
		// (set) Token: 0x060408CB RID: 264395 RVA: 0x012F9D84 File Offset: 0x012F7F84
		public string PrefabKey { get; set; }

		// Token: 0x17007810 RID: 30736
		// (get) Token: 0x060408CC RID: 264396 RVA: 0x012F9D8D File Offset: 0x012F7F8D
		// (set) Token: 0x060408CD RID: 264397 RVA: 0x012F9D95 File Offset: 0x012F7F95
		public string[] Args { get; set; }
	}
}
