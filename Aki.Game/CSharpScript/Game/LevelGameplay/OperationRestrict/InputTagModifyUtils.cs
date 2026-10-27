using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.OperationRestrict
{
	// Token: 0x02006ABE RID: 27326
	[NullableContext(1)]
	[Nullable(0)]
	public class InputTagModifyUtils : Singleton
	{
		// Token: 0x06043E53 RID: 278099 RVA: 0x010A4EF8 File Offset: 0x010A30F8
		private void InitTagInfoCache()
		{
			this.TagParentInfoCache.Clear();
			this.TagChildrenInfoCache.Clear();
			foreach (ValueTuple<string, string> valueTuple in InputDistributeDefine.InitializeInputDistributeTagDefine)
			{
				if (!(valueTuple.Item1 == "BlockAllInputTag"))
				{
					this.TagParentInfoCache[valueTuple.Item1] = valueTuple.Item2;
					HashSet<string> hashSet;
					if (valueTuple.Item2 == null || !this.TagChildrenInfoCache.TryGetValue(valueTuple.Item2, out hashSet))
					{
						hashSet = new HashSet<string>();
						string text = valueTuple.Item2 ?? "";
						this.TagChildrenInfoCache[text] = hashSet;
						if (string.IsNullOrEmpty(text))
						{
							Log.Instance.Warn(ELogModule.LevelEvent, ELogAuthor.LRX, "ParentTag of $" + valueTuple.Item1 + " is NullOrEmpty, possible overwriting other NullOrEmpty TagChildrenInfoCache!", default(ReadOnlySpan<ValueTuple<string, object>>));
						}
					}
					hashSet.Add(valueTuple.Item1);
				}
			}
		}

		// Token: 0x06043E54 RID: 278100 RVA: 0x010A5010 File Offset: 0x010A3210
		private void GetAllChildInputTag(string inputTag, HashSet<string> childrenTagsContainer, bool bIncludeChildOfChild = false)
		{
			if (this.TagParentInfoCache.Count == 0 || this.TagChildrenInfoCache.Count > 0)
			{
				this.InitTagInfoCache();
			}
			HashSet<string> hashSet;
			if (!this.TagChildrenInfoCache.TryGetValue(inputTag, out hashSet) || hashSet.Count == 0)
			{
				return;
			}
			foreach (string item in hashSet)
			{
				childrenTagsContainer.Add(item);
			}
			if (bIncludeChildOfChild)
			{
				foreach (string inputTag2 in hashSet)
				{
					this.GetAllChildInputTag(inputTag2, childrenTagsContainer, true);
				}
			}
		}

		// Token: 0x06043E55 RID: 278101 RVA: 0x010A50DC File Offset: 0x010A32DC
		private void GetAllChildInputTag(string inputTag, List<string> childrenTagsContainer, bool bIncludeChildOfChild = false)
		{
			if (this.TagParentInfoCache.Count == 0 || this.TagChildrenInfoCache.Count > 0)
			{
				this.InitTagInfoCache();
			}
			HashSet<string> hashSet;
			if (!this.TagChildrenInfoCache.TryGetValue(inputTag, out hashSet) || hashSet.Count == 0)
			{
				return;
			}
			childrenTagsContainer.AddRange(hashSet);
			if (bIncludeChildOfChild)
			{
				foreach (string inputTag2 in hashSet)
				{
					this.GetAllChildInputTag(inputTag2, childrenTagsContainer, true);
				}
			}
		}

		// Token: 0x06043E56 RID: 278102 RVA: 0x010A5170 File Offset: 0x010A3370
		private string GetParentInputTag(string inputTag)
		{
			if (this.TagParentInfoCache.Count == 0 || this.TagChildrenInfoCache.Count > 0)
			{
				this.InitTagInfoCache();
			}
			string text;
			this.TagParentInfoCache.TryGetValue(inputTag, out text);
			return text ?? "";
		}

		// Token: 0x06043E57 RID: 278103 RVA: 0x010A51B8 File Offset: 0x010A33B8
		public bool GetIsInputTagEnable(IEnumerable<string> targetTagList, string tagToCheck, bool fullMatch = false)
		{
			if (this.TagParentInfoCache.Count == 0 || this.TagChildrenInfoCache.Count > 0)
			{
				this.InitTagInfoCache();
			}
			if (fullMatch)
			{
				return targetTagList.Contains(tagToCheck);
			}
			HashSet<string> hashSet = new HashSet<string>(targetTagList);
			string text = tagToCheck;
			while (text != null)
			{
				if (hashSet.Contains(text))
				{
					return true;
				}
				this.TagParentInfoCache.TryGetValue(text, out text);
			}
			return false;
		}

		// Token: 0x06043E58 RID: 278104 RVA: 0x010A521C File Offset: 0x010A341C
		private void ModifyInputTag(List<string> targetTagList, string[] tagsToAdd, string[] tagsToRem)
		{
			foreach (string item in tagsToRem)
			{
				int num = targetTagList.IndexOf(item);
				if (num != -1)
				{
					targetTagList.RemoveAt(num);
				}
			}
			foreach (string item2 in tagsToAdd)
			{
				if (targetTagList.IndexOf(item2) == -1)
				{
					targetTagList.Add(item2);
				}
			}
		}

		// Token: 0x06043E59 RID: 278105 RVA: 0x010A5284 File Offset: 0x010A3484
		private void EnableInputTag(List<string> targetTagList, string targetTagName)
		{
			if (this.GetIsInputTagEnable(targetTagList, targetTagName, false))
			{
				return;
			}
			string parentInputTag = this.GetParentInputTag(targetTagName);
			HashSet<string> hashSet = new HashSet<string>();
			this.GetAllChildInputTag(parentInputTag, hashSet, false);
			HashSet<string> hashSet2 = new HashSet<string>();
			this.GetAllChildInputTag(targetTagName, hashSet2, true);
			this.ModifyInputTag(targetTagList, new string[]
			{
				targetTagName
			}, hashSet2.ToArray<string>());
			int num = 0;
			foreach (string item in targetTagList)
			{
				if (hashSet.Contains(item))
				{
					num++;
				}
			}
			if (num == hashSet.Count && parentInputTag != null)
			{
				this.EnableInputTag(targetTagList, parentInputTag);
			}
		}

		// Token: 0x06043E5A RID: 278106 RVA: 0x010A533C File Offset: 0x010A353C
		private void DisableInputTag(List<string> targetTagList, string targetTagName)
		{
			if (!this.GetIsInputTagEnable(targetTagList, targetTagName, false))
			{
				return;
			}
			string parentInputTag = this.GetParentInputTag(targetTagName);
			HashSet<string> hashSet = new HashSet<string>();
			this.GetAllChildInputTag(parentInputTag, hashSet, false);
			HashSet<string> hashSet2 = new HashSet<string>();
			this.GetAllChildInputTag(targetTagName, hashSet2, true);
			List<string> list = new List<string>
			{
				targetTagName
			};
			list.AddRange(hashSet2);
			this.ModifyInputTag(targetTagList, Array.Empty<string>(), list.ToArray());
			List<string> list2 = new List<string>();
			foreach (string text in hashSet)
			{
				if (!(text == targetTagName) && this.GetIsInputTagEnable(targetTagList, text, false))
				{
					list2.Add(text);
				}
			}
			if (parentInputTag != null)
			{
				this.DisableInputTag(targetTagList, parentInputTag);
			}
			foreach (string targetTagName2 in list2)
			{
				this.EnableInputTag(targetTagList, targetTagName2);
			}
		}

		// Token: 0x06043E5B RID: 278107 RVA: 0x010A5450 File Offset: 0x010A3650
		public void SetEnableInputTag(List<string> targetTagList, string targetTagName, bool enable)
		{
			if (enable)
			{
				this.EnableInputTag(targetTagList, targetTagName);
				return;
			}
			this.DisableInputTag(targetTagList, targetTagName);
		}

		// Token: 0x17009966 RID: 39270
		// (get) Token: 0x06043E5C RID: 278108 RVA: 0x010A5466 File Offset: 0x010A3666
		public static InputTagModifyUtils Instance
		{
			get
			{
				if (InputTagModifyUtils._instance == null)
				{
					InputTagModifyUtils._instance = new InputTagModifyUtils();
					InputTagModifyUtils._instance.OnInit();
				}
				return InputTagModifyUtils._instance;
			}
		}

		// Token: 0x06043E5D RID: 278109 RVA: 0x010A5489 File Offset: 0x010A3689
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043E5E RID: 278110 RVA: 0x010A548B File Offset: 0x010A368B
		public static void ResetStaticDefaultValue()
		{
			InputTagModifyUtils instance = InputTagModifyUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputTagModifyUtils._instance = null;
		}

		// Token: 0x06043E5F RID: 278111 RVA: 0x010A54A4 File Offset: 0x010A36A4
		static InputTagModifyUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputTagModifyUtils.CreateStaticDefaultValue), new Action(InputTagModifyUtils.ResetStaticDefaultValue));
		}

		// Token: 0x040237C5 RID: 145349
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private readonly Dictionary<string, string> TagParentInfoCache = new Dictionary<string, string>();

		// Token: 0x040237C6 RID: 145350
		private readonly Dictionary<string, HashSet<string>> TagChildrenInfoCache = new Dictionary<string, HashSet<string>>();

		// Token: 0x040237C7 RID: 145351
		[Nullable(2)]
		private static InputTagModifyUtils _instance;
	}
}
