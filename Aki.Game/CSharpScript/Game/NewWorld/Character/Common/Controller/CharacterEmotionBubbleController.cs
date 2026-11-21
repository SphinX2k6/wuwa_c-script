using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006311 RID: 25361
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CharacterEmotionBubbleController : ControllerBase
	{
		// Token: 0x0603D607 RID: 251399 RVA: 0x011BF0A6 File Offset: 0x011BD2A6
		protected override bool OnInit()
		{
			this.InitEmotionConfig();
			this.InitAnimalConfig();
			return true;
		}

		// Token: 0x0603D608 RID: 251400 RVA: 0x011BF0B8 File Offset: 0x011BD2B8
		[NullableContext(2)]
		public IEmotionConfigInfo GetMonsterEmotionConfigById(int id)
		{
			if (!this.MonsterEmotionMap.ContainsKey(id))
			{
				this.InitMonsterConfig(id);
			}
			IEmotionConfigInfo result;
			this.MonsterEmotionMap.TryGetValue(id, out result);
			return result;
		}

		// Token: 0x0603D609 RID: 251401 RVA: 0x011BF0EC File Offset: 0x011BD2EC
		[NullableContext(2)]
		public IEmotionEffectInfo GetMonsterEmotionInfo(int id)
		{
			IEmotionConfigInfo monsterEmotionConfigById = this.GetMonsterEmotionConfigById(id);
			if (monsterEmotionConfigById == null)
			{
				return null;
			}
			string text;
			this.EmotionEffectMap.TryGetValue(monsterEmotionConfigById.EmotionName, out text);
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			return new IEmotionEffectInfo
			{
				Effect = text,
				Socket = monsterEmotionConfigById.Socket,
				Offset = monsterEmotionConfigById.Offset
			};
		}

		// Token: 0x0603D60A RID: 251402 RVA: 0x011BF148 File Offset: 0x011BD348
		[return: Nullable(2)]
		public IEmotionEffectInfo GetAnimalEmotionInfo(string blueprintPath, string emotion, string montage)
		{
			string text;
			this.EmotionEffectMap.TryGetValue(emotion, out text);
			IEmotionBubbleConfig emotionBubbleConfig = null;
			Dictionary<string, Dictionary<string, IEmotionBubbleConfig>> dictionary;
			Dictionary<string, IEmotionBubbleConfig> dictionary2;
			if (this.EmotionMontageMap.TryGetValue(blueprintPath, out dictionary) && dictionary.TryGetValue(emotion, out dictionary2))
			{
				dictionary2.TryGetValue(montage, out emotionBubbleConfig);
			}
			if (text != null && emotionBubbleConfig != null)
			{
				return new IEmotionEffectInfo
				{
					Effect = text,
					Socket = emotionBubbleConfig.Socket,
					Offset = emotionBubbleConfig.Offset
				};
			}
			return null;
		}

		// Token: 0x0603D60B RID: 251403 RVA: 0x011BF1B8 File Offset: 0x011BD3B8
		private void InitEmotionConfig()
		{
			IReadOnlyList<EmotionBubbleConfig> configList = ConfigEmotionBubbleConfigAll.GetConfigList(true);
			if (configList == null || configList.Count == 0)
			{
				return;
			}
			foreach (EmotionBubbleConfig emotionBubbleConfig in configList)
			{
				this.EmotionEffectMap[emotionBubbleConfig.EmotionName] = emotionBubbleConfig.EmotionPath;
			}
		}

		// Token: 0x0603D60C RID: 251404 RVA: 0x011BF228 File Offset: 0x011BD428
		private unsafe void InitMonsterConfig(int id)
		{
			EmotionBubbleMonsterConfig? config = ConfigEmotionBubbleMonsterConfigById.GetConfig(id, true);
			if (config == null)
			{
				return;
			}
			List<int> list = new List<int>();
			if (config.Value.StateTagList() != null)
			{
				string[] array = config.Value.StateTagList();
				int i = 0;
				while (i < array.Length)
				{
					string text = array[i];
					FGameplayTag? gameplayTagByName = GameplayTagUtils.GetGameplayTagByName(text);
					int? num = (gameplayTagByName != null) ? new int?(gameplayTagByName.GetValueOrDefault().TagId()) : null;
					if (num == null)
					{
						goto IL_A4;
					}
					int? num2 = num;
					int num3 = 0;
					if (num2.GetValueOrDefault() == num3 & num2 != null)
					{
						goto IL_A4;
					}
					list.Add(num.Value);
					IL_10C:
					i++;
					continue;
					IL_A4:
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "[Emotion] InitMonsterConfig 没找到对应Tag";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Tag", text);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					goto IL_10C;
				}
			}
			if (list.Count == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Character;
				ELogAuthor author2 = ELogAuthor.CWZ;
				string message2 = "[Emotion] InitMonsterConfig 配置无任何有效 Tag，跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance2.Warn(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.MonsterEmotionMap[id] = new IEmotionConfigInfo
			{
				EmotionName = config.Value.EmotionName,
				TagList = list,
				Socket = config.Value.AttachPoint,
				Offset = global::Vector.Create((double)config.Value.Offset(0), (double)config.Value.Offset(1), (double)config.Value.Offset(2))
			};
		}

		// Token: 0x0603D60D RID: 251405 RVA: 0x011BF40C File Offset: 0x011BD60C
		private void InitAnimalConfig()
		{
			IReadOnlyList<EmotionBubbleAnimalConfig> configList = ConfigEmotionBubbleAnimalConfigAll.GetConfigList(true);
			if (configList == null || configList.Count == 0)
			{
				return;
			}
			foreach (EmotionBubbleAnimalConfig emotionBubbleAnimalConfig in configList)
			{
				string monsterBp = emotionBubbleAnimalConfig.MonsterBp;
				if (!this.EmotionMontageMap.ContainsKey(monsterBp))
				{
					this.EmotionMontageMap[monsterBp] = new Dictionary<string, Dictionary<string, IEmotionBubbleConfig>>();
				}
				Dictionary<string, Dictionary<string, IEmotionBubbleConfig>> dictionary = this.EmotionMontageMap[monsterBp];
				string montagePath = emotionBubbleAnimalConfig.MontagePath;
				if (montagePath.Length < 1)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Character;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "[Emotion] InitAnimalConfig MontagePath为空";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BlueprintPath", monsterBp);
					instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					if (!dictionary.ContainsKey(emotionBubbleAnimalConfig.EmotionName))
					{
						dictionary[emotionBubbleAnimalConfig.EmotionName] = new Dictionary<string, IEmotionBubbleConfig>();
					}
					dictionary[emotionBubbleAnimalConfig.EmotionName][montagePath] = new IEmotionBubbleConfig
					{
						Socket = emotionBubbleAnimalConfig.AttachPoint,
						Offset = global::Vector.Create((double)emotionBubbleAnimalConfig.Offset(0), (double)emotionBubbleAnimalConfig.Offset(1), (double)emotionBubbleAnimalConfig.Offset(2))
					};
				}
			}
		}

		// Token: 0x1700744D RID: 29773
		// (get) Token: 0x0603D60E RID: 251406 RVA: 0x011BF54C File Offset: 0x011BD74C
		public static CharacterEmotionBubbleController Instance
		{
			get
			{
				return CharacterEmotionBubbleController._Instance;
			}
		}

		// Token: 0x0603D60F RID: 251407 RVA: 0x011BF553 File Offset: 0x011BD753
		public static CharacterEmotionBubbleController GetOrCreateInstance()
		{
			if (CharacterEmotionBubbleController._Instance == null)
			{
				CharacterEmotionBubbleController.CreateInstance();
			}
			return CharacterEmotionBubbleController._Instance;
		}

		// Token: 0x0603D610 RID: 251408 RVA: 0x011BF567 File Offset: 0x011BD767
		public static bool CreateInstance()
		{
			if (CharacterEmotionBubbleController._Instance != null)
			{
				return true;
			}
			CharacterEmotionBubbleController._Instance = new CharacterEmotionBubbleController();
			return true;
		}

		// Token: 0x0603D611 RID: 251409 RVA: 0x011BF57D File Offset: 0x011BD77D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D612 RID: 251410 RVA: 0x011BF57F File Offset: 0x011BD77F
		public static void ResetStaticDefaultValue()
		{
			CharacterEmotionBubbleController._Instance = null;
		}

		// Token: 0x0603D613 RID: 251411 RVA: 0x011BF587 File Offset: 0x011BD787
		static CharacterEmotionBubbleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterEmotionBubbleController.CreateStaticDefaultValue), new Action(CharacterEmotionBubbleController.ResetStaticDefaultValue));
		}

		// Token: 0x040208DD RID: 133341
		private readonly Dictionary<int, IEmotionConfigInfo> MonsterEmotionMap = new Dictionary<int, IEmotionConfigInfo>();

		// Token: 0x040208DE RID: 133342
		private readonly Dictionary<string, Dictionary<string, Dictionary<string, IEmotionBubbleConfig>>> EmotionMontageMap = new Dictionary<string, Dictionary<string, Dictionary<string, IEmotionBubbleConfig>>>();

		// Token: 0x040208DF RID: 133343
		private readonly Dictionary<string, string> EmotionEffectMap = new Dictionary<string, string>();

		// Token: 0x040208E0 RID: 133344
		[Nullable(2)]
		private static CharacterEmotionBubbleController _Instance;
	}
}
