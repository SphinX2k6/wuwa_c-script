using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.OperationRestrict
{
	// Token: 0x02005C36 RID: 23606
	[NullableContext(1)]
	[Nullable(0)]
	public class InputTagModifyUtils : Singleton
	{
		// Token: 0x06039F9A RID: 237466 RVA: 0x0104E4DC File Offset: 0x0104C6DC
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

		// Token: 0x06039F9B RID: 237467 RVA: 0x0104E5F4 File Offset: 0x0104C7F4
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

		// Token: 0x06039F9C RID: 237468 RVA: 0x0104E6C0 File Offset: 0x0104C8C0
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

		// Token: 0x06039F9D RID: 237469 RVA: 0x0104E754 File Offset: 0x0104C954
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

		// Token: 0x06039F9E RID: 237470 RVA: 0x0104E79C File Offset: 0x0104C99C
		public bool GetIsInputTagEnable(IEnumerable<string> targetTagList, string tagToCheck, bool fullMatch = false)
		{
			if (this.TagParentInfoCache.Count == 0 || this.TagChildrenInfoCache.Count > 0)
			{
				this.InitTagInfoCache();
			}
			if (fullMatch)
			{
				using (IEnumerator<string> enumerator = targetTagList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == tagToCheck)
						{
							return true;
						}
					}
				}
				return false;
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

		// Token: 0x06039F9F RID: 237471 RVA: 0x0104E83C File Offset: 0x0104CA3C
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

		// Token: 0x06039FA0 RID: 237472 RVA: 0x0104E8A4 File Offset: 0x0104CAA4
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
			string[] array = new string[hashSet2.Count];
			hashSet2.CopyTo(array);
			this.ModifyInputTag(targetTagList, new string[]
			{
				targetTagName
			}, array);
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

		// Token: 0x06039FA1 RID: 237473 RVA: 0x0104E96C File Offset: 0x0104CB6C
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

		// Token: 0x06039FA2 RID: 237474 RVA: 0x0104EA80 File Offset: 0x0104CC80
		public void SetEnableInputTag(List<string> targetTagList, string targetTagName, bool enable)
		{
			if (enable)
			{
				this.EnableInputTag(targetTagList, targetTagName);
				return;
			}
			this.DisableInputTag(targetTagList, targetTagName);
		}

		// Token: 0x17006E69 RID: 28265
		// (get) Token: 0x06039FA3 RID: 237475 RVA: 0x0104EA96 File Offset: 0x0104CC96
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

		// Token: 0x06039FA4 RID: 237476 RVA: 0x0104EAB9 File Offset: 0x0104CCB9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039FA5 RID: 237477 RVA: 0x0104EABB File Offset: 0x0104CCBB
		public static void ResetStaticDefaultValue()
		{
			InputTagModifyUtils instance = InputTagModifyUtils._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InputTagModifyUtils._instance = null;
		}

		// Token: 0x06039FA6 RID: 237478 RVA: 0x0104EAD4 File Offset: 0x0104CCD4
		static InputTagModifyUtils()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InputTagModifyUtils.CreateStaticDefaultValue), new Action(InputTagModifyUtils.ResetStaticDefaultValue));
		}

		// Token: 0x0401EA62 RID: 125538
		[Nullable(new byte[]
		{
			1,
			1,
			2
		})]
		private readonly Dictionary<string, string> TagParentInfoCache = new Dictionary<string, string>();

		// Token: 0x0401EA63 RID: 125539
		private readonly Dictionary<string, HashSet<string>> TagChildrenInfoCache = new Dictionary<string, HashSet<string>>();

		// Token: 0x0401EA64 RID: 125540
		[Nullable(2)]
		private static InputTagModifyUtils _instance;
	}
}
