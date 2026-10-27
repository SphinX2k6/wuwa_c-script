using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B2 RID: 28850
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class CharacterEmotionBubbleController : ControllerBase
	{
		// Token: 0x0604655D RID: 288093 RVA: 0x011A17D4 File Offset: 0x0119F9D4
		protected override bool OnInit()
		{
			this.InitEmotionConfig();
			this.InitAnimalConfig();
			return true;
		}

		// Token: 0x0604655E RID: 288094 RVA: 0x011A17E4 File Offset: 0x0119F9E4
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

		// Token: 0x0604655F RID: 288095 RVA: 0x011A1818 File Offset: 0x0119FA18
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

		// Token: 0x06046560 RID: 288096 RVA: 0x011A1874 File Offset: 0x0119FA74
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

		// Token: 0x06046561 RID: 288097 RVA: 0x011A18E4 File Offset: 0x0119FAE4
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

		// Token: 0x06046562 RID: 288098 RVA: 0x011A1954 File Offset: 0x0119FB54
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

		// Token: 0x06046563 RID: 288099 RVA: 0x011A1B38 File Offset: 0x0119FD38
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

		// Token: 0x17009C59 RID: 40025
		// (get) Token: 0x06046564 RID: 288100 RVA: 0x011A1C78 File Offset: 0x0119FE78
		public static CharacterEmotionBubbleController Instance
		{
			get
			{
				return CharacterEmotionBubbleController._Instance;
			}
		}

		// Token: 0x06046565 RID: 288101 RVA: 0x011A1C7F File Offset: 0x0119FE7F
		public static CharacterEmotionBubbleController GetOrCreateInstance()
		{
			if (CharacterEmotionBubbleController._Instance == null)
			{
				CharacterEmotionBubbleController.CreateInstance();
			}
			return CharacterEmotionBubbleController._Instance;
		}

		// Token: 0x06046566 RID: 288102 RVA: 0x011A1C93 File Offset: 0x0119FE93
		public static bool CreateInstance()
		{
			if (CharacterEmotionBubbleController._Instance != null)
			{
				return true;
			}
			CharacterEmotionBubbleController._Instance = new CharacterEmotionBubbleController();
			return true;
		}

		// Token: 0x06046567 RID: 288103 RVA: 0x011A1CA9 File Offset: 0x0119FEA9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06046568 RID: 288104 RVA: 0x011A1CAB File Offset: 0x0119FEAB
		public static void ResetStaticDefaultValue()
		{
			CharacterEmotionBubbleController._Instance = null;
		}

		// Token: 0x06046569 RID: 288105 RVA: 0x011A1CB3 File Offset: 0x0119FEB3
		static CharacterEmotionBubbleController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CharacterEmotionBubbleController.CreateStaticDefaultValue), new Action(CharacterEmotionBubbleController.ResetStaticDefaultValue));
		}

		// Token: 0x04024DB6 RID: 150966
		private readonly Dictionary<int, IEmotionConfigInfo> MonsterEmotionMap = new Dictionary<int, IEmotionConfigInfo>();

		// Token: 0x04024DB7 RID: 150967
		private readonly Dictionary<string, Dictionary<string, Dictionary<string, IEmotionBubbleConfig>>> EmotionMontageMap = new Dictionary<string, Dictionary<string, Dictionary<string, IEmotionBubbleConfig>>>();

		// Token: 0x04024DB8 RID: 150968
		private readonly Dictionary<string, string> EmotionEffectMap = new Dictionary<string, string>();

		// Token: 0x04024DB9 RID: 150969
		[Nullable(2)]
		private static CharacterEmotionBubbleController _Instance;
	}
}
