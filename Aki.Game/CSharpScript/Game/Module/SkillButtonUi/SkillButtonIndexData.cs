using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02004C09 RID: 19465
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonIndexData
	{
		// Token: 0x0603260A RID: 206346 RVA: 0x00BB9CB0 File Offset: 0x00BB7EB0
		[NullableContext(2)]
		public void RefreshSkillButtonIndex(EntityHandle entityHandle)
		{
			this.IsNormalButtonTypeList = false;
			BaseTagComponent component = entityHandle.Entity.GetComponent<BaseTagComponent>();
			int num = 0;
			foreach (int[] array in this.ButtonIndexTagIdList)
			{
				bool flag = true;
				foreach (int tagId in array)
				{
					if (!component.HasTag(tagId))
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					this.ButtonTypeList = this.ButtonIndexTypeList[num];
					return;
				}
				num++;
			}
			foreach (KeyValuePair<int, List<int>> keyValuePair in this.ButtonTypeTagMap)
			{
				int key = keyValuePair.Key;
				List<int> value = keyValuePair.Value;
				if (component.HasTag(key))
				{
					this.ButtonTypeList = value;
					return;
				}
			}
			this.ButtonTypeList = this.DefaultButtonTypeList;
			this.IsNormalButtonTypeList = true;
		}

		// Token: 0x0603260B RID: 206347 RVA: 0x00BB9DD0 File Offset: 0x00BB7FD0
		[NullableContext(2)]
		public void RefreshSkillButtonIndexByTag(EntityHandle entityHandle, int tagId)
		{
			if (!this.IsNormalButtonTypeList)
			{
				this.RefreshSkillButtonIndex(entityHandle);
				return;
			}
			this.IsNormalButtonTypeList = false;
			if (this.ButtonIndexTagIdSet.Contains(tagId))
			{
				this.RefreshSkillButtonIndex(entityHandle);
				return;
			}
			List<int> buttonTypeList;
			if (this.ButtonTypeTagMap.TryGetValue(tagId, out buttonTypeList))
			{
				this.ButtonTypeList = buttonTypeList;
				return;
			}
			this.ButtonTypeList = this.DefaultButtonTypeList;
			this.IsNormalButtonTypeList = true;
		}

		// Token: 0x0603260C RID: 206348 RVA: 0x00BB9E38 File Offset: 0x00BB8038
		public void UpdateSkillButtonIndexConfigList(IReadOnlyList<SkillButtonIndex> skillButtonIndexConfigList, bool isDesktop)
		{
			this.ButtonIndexIsDesktop = isDesktop;
			this.ButtonIndexConfigList.Clear();
			this.ButtonIndexConfigList.AddRange(skillButtonIndexConfigList);
			this.ButtonIndexConfigList.Sort((SkillButtonIndex a, SkillButtonIndex b) => a.Id.CompareTo(b.Id));
			this.UpdateConfigInner();
		}

		// Token: 0x0603260D RID: 206349 RVA: 0x00BB9E93 File Offset: 0x00BB8093
		public void UpdateSkillButtonIndexConfig(SkillButtonIndex? skillButtonIndexConfig, bool isDesktop)
		{
			this.ButtonIndexIsDesktop = isDesktop;
			this.ButtonIndexConfigList.Clear();
			if (skillButtonIndexConfig != null)
			{
				this.ButtonIndexConfigList.Add(skillButtonIndexConfig.Value);
			}
			this.UpdateConfigInner();
		}

		// Token: 0x0603260E RID: 206350 RVA: 0x00BB9EC8 File Offset: 0x00BB80C8
		public void UpdateIsDesktop(bool isDesktop)
		{
			if (this.ButtonIndexIsDesktop == isDesktop)
			{
				return;
			}
			this.ButtonIndexIsDesktop = isDesktop;
			this.UpdateConfigInner();
		}

		// Token: 0x0603260F RID: 206351 RVA: 0x00BB9EE4 File Offset: 0x00BB80E4
		private unsafe void UpdateConfigInner()
		{
			this.ButtonIndexTagIdList.Clear();
			this.ButtonIndexTagIdSet.Clear();
			this.ButtonIndexTypeList.Clear();
			this.ButtonTypeTagMap.Clear();
			this.DefaultButtonTypeList.Clear();
			if (this.ButtonIndexConfigList.Count <= 0)
			{
				return;
			}
			foreach (SkillButtonIndex skillButtonIndex in this.ButtonIndexConfigList)
			{
				foreach (GameplayTagArray gameplayTagArray in skillButtonIndex.TagListIter())
				{
					List<int> list = new List<int>();
					int i = 0;
					while (i < gameplayTagArray.ArrayStringLength)
					{
						string text = gameplayTagArray.ArrayString(i);
						int? num = new int?(GameplayTagUtils.GetTagIdByName(text));
						if (num == null)
						{
							goto IL_EC;
						}
						int? num2 = num;
						int num3 = 0;
						if (num2.GetValueOrDefault() == num3 & num2 != null)
						{
							goto IL_EC;
						}
						list.Add(num.Value);
						this.ButtonIndexTagIdSet.Add(num.Value);
						IL_14B:
						i++;
						continue;
						IL_EC:
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.CFT;
						string message = "技能按钮索引配置了不存在的Tag";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", text);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", skillButtonIndex.Id);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						goto IL_14B;
					}
					if (list.Count == 0)
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Battle;
						ELogAuthor author2 = ELogAuthor.CFT;
						string message2 = "技能按钮索引组合Tag出现空元素，请确认改数组最后一个元素后面没有逗号";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", skillButtonIndex.Id);
						instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						break;
					}
					this.ButtonIndexTagIdList.Add(list.ToArray());
				}
				if (this.ButtonIndexIsDesktop)
				{
					using (IEnumerator<IntArray> enumerator3 = skillButtonIndex.TagDesktopButtonTypeListIter().GetEnumerator())
					{
						while (enumerator3.MoveNext())
						{
							IntArray intArray = enumerator3.Current;
							List<int> list2 = new List<int>();
							for (int j = 0; j < intArray.ArrayIntLength; j++)
							{
								list2.Add(intArray.ArrayInt(j));
							}
							this.ButtonIndexTypeList.Add(list2);
						}
						goto IL_2A3;
					}
					goto IL_239;
				}
				goto IL_239;
				IL_2A3:
				if (this.ButtonIndexTagIdList.Count != this.ButtonIndexTypeList.Count)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Battle;
					ELogAuthor author3 = ELogAuthor.CFT;
					string message3 = "技能按钮索引组合Tag和按钮索引数组的数量不匹配";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", skillButtonIndex.Id);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("TagLength", this.ButtonIndexTagIdList.Count);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("ButtonLength", this.ButtonIndexTypeList.Count);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				}
				if (this.ButtonIndexIsDesktop)
				{
					using (IEnumerator<DicIntIntArray> enumerator4 = skillButtonIndex.DesktopButtonTypeMapIter().GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							DicIntIntArray dicIntIntArray = enumerator4.Current;
							int key = dicIntIntArray.Key;
							IntArray? value = dicIntIntArray.Value;
							if (value != null)
							{
								List<int> list3 = new List<int>();
								for (int k = 0; k < value.Value.ArrayIntLength; k++)
								{
									list3.Add(value.Value.ArrayInt(k));
								}
								this.ButtonTypeTagMap[key] = list3;
							}
						}
						goto IL_492;
					}
					goto IL_3F9;
				}
				goto IL_3F9;
				IL_492:
				if (this.DefaultButtonTypeList.Count <= 0)
				{
					if (this.ButtonIndexIsDesktop)
					{
						using (IEnumerator<int> enumerator5 = skillButtonIndex.DesktopButtonTypeListIter().GetEnumerator())
						{
							while (enumerator5.MoveNext())
							{
								int item = enumerator5.Current;
								this.DefaultButtonTypeList.Add(item);
							}
							continue;
						}
					}
					foreach (int item2 in skillButtonIndex.PadButtonTypeListIter())
					{
						this.DefaultButtonTypeList.Add(item2);
					}
					continue;
				}
				continue;
				IL_3F9:
				foreach (DicIntIntArray dicIntIntArray2 in skillButtonIndex.PadButtonTypeMapIter())
				{
					int key2 = dicIntIntArray2.Key;
					IntArray? value2 = dicIntIntArray2.Value;
					if (value2 != null)
					{
						List<int> list4 = new List<int>();
						for (int l = 0; l < value2.Value.ArrayIntLength; l++)
						{
							list4.Add(value2.Value.ArrayInt(l));
						}
						this.ButtonTypeTagMap[key2] = list4;
					}
				}
				goto IL_492;
				IL_239:
				foreach (IntArray intArray2 in skillButtonIndex.TagPadButtonTypeListIter())
				{
					List<int> list5 = new List<int>();
					for (int m = 0; m < intArray2.ArrayIntLength; m++)
					{
						list5.Add(intArray2.ArrayInt(m));
					}
					this.ButtonIndexTypeList.Add(list5);
				}
				goto IL_2A3;
			}
		}

		// Token: 0x06032610 RID: 206352 RVA: 0x00BBA4F8 File Offset: 0x00BB86F8
		public void RefreshMotorPadSkillButtonIndex(EntityHandle entityHandle, bool isRoundJoystick)
		{
			this.IsRoundJoystick = isRoundJoystick;
			BaseTagComponent component = entityHandle.Entity.GetComponent<BaseTagComponent>();
			foreach (KeyValuePair<int, int[]> keyValuePair in (this.IsRoundJoystick ? this.MotorJoystickPadButtonTypeTagMap : this.MotorPadButtonTypeTagMap))
			{
				int num;
				int[] array;
				keyValuePair.Deconstruct(out num, out array);
				int tagId = num;
				int[] motorPadButtonTypeList = array;
				if (component.HasTag(tagId))
				{
					this.MotorPadButtonTypeList = motorPadButtonTypeList;
					break;
				}
			}
		}

		// Token: 0x06032611 RID: 206353 RVA: 0x00BBA58C File Offset: 0x00BB878C
		public void InitMotorPadSkillButtonIndexConfig()
		{
			this.MotorPadButtonTypeTagMap.Clear();
			this.MotorJoystickPadButtonTypeTagMap.Clear();
			foreach (SkillButtonIndex skillButtonIndex in this.ButtonIndexConfigList)
			{
				foreach (DicIntIntArray dicIntIntArray in skillButtonIndex.MotorPadButtonTypeMapIter())
				{
					this.MotorPadButtonTypeTagMap[dicIntIntArray.Key] = dicIntIntArray.Value.Value.GetArrayIntBytes().ToArray();
				}
				foreach (DicIntIntArray dicIntIntArray2 in skillButtonIndex.MotorJoystickPadButtonTypeMapIter())
				{
					this.MotorJoystickPadButtonTypeTagMap[dicIntIntArray2.Key] = dicIntIntArray2.Value.Value.GetArrayIntBytes().ToArray();
				}
			}
		}

		// Token: 0x0401ACE3 RID: 109795
		public bool IsNormalButtonTypeList;

		// Token: 0x0401ACE4 RID: 109796
		public IList<int> ButtonTypeList = new List<int>();

		// Token: 0x0401ACE5 RID: 109797
		public List<SkillButtonIndex> ButtonIndexConfigList = new List<SkillButtonIndex>();

		// Token: 0x0401ACE6 RID: 109798
		public bool ButtonIndexIsDesktop;

		// Token: 0x0401ACE7 RID: 109799
		public List<int> DefaultButtonTypeList = new List<int>();

		// Token: 0x0401ACE8 RID: 109800
		public readonly List<int[]> ButtonIndexTagIdList = new List<int[]>();

		// Token: 0x0401ACE9 RID: 109801
		public readonly HashSet<int> ButtonIndexTagIdSet = new HashSet<int>();

		// Token: 0x0401ACEA RID: 109802
		public readonly List<List<int>> ButtonIndexTypeList = new List<List<int>>();

		// Token: 0x0401ACEB RID: 109803
		public readonly Dictionary<int, List<int>> ButtonTypeTagMap = new Dictionary<int, List<int>>();

		// Token: 0x0401ACEC RID: 109804
		public int[] MotorPadButtonTypeList = Array.Empty<int>();

		// Token: 0x0401ACED RID: 109805
		public bool IsRoundJoystick;

		// Token: 0x0401ACEE RID: 109806
		public readonly Dictionary<int, int[]> MotorPadButtonTypeTagMap = new Dictionary<int, int[]>();

		// Token: 0x0401ACEF RID: 109807
		public readonly Dictionary<int, int[]> MotorJoystickPadButtonTypeTagMap = new Dictionary<int, int[]>();
	}
}
