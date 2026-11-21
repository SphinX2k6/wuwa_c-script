using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.SkillButtonUi
{
	// Token: 0x02003BBA RID: 15290
	[NullableContext(1)]
	[Nullable(0)]
	public class SkillButtonIndexData
	{
		// Token: 0x060273BA RID: 160698 RVA: 0x00AFE834 File Offset: 0x00AFCA34
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

		// Token: 0x060273BB RID: 160699 RVA: 0x00AFE954 File Offset: 0x00AFCB54
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

		// Token: 0x060273BC RID: 160700 RVA: 0x00AFE9BC File Offset: 0x00AFCBBC
		public void UpdateSkillButtonIndexConfigList(IReadOnlyList<SkillButtonIndex> skillButtonIndexConfigList, bool isDesktop)
		{
			this.ButtonIndexIsDesktop = isDesktop;
			this.ButtonIndexConfigList.Clear();
			this.ButtonIndexConfigList.AddRange(skillButtonIndexConfigList);
			this.ButtonIndexConfigList.Sort((SkillButtonIndex a, SkillButtonIndex b) => a.Id.CompareTo(b.Id));
			this.UpdateConfigInner();
		}

		// Token: 0x060273BD RID: 160701 RVA: 0x00AFEA17 File Offset: 0x00AFCC17
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

		// Token: 0x060273BE RID: 160702 RVA: 0x00AFEA4C File Offset: 0x00AFCC4C
		public void UpdateIsDesktop(bool isDesktop)
		{
			if (this.ButtonIndexIsDesktop == isDesktop)
			{
				return;
			}
			this.ButtonIndexIsDesktop = isDesktop;
			this.UpdateConfigInner();
		}

		// Token: 0x060273BF RID: 160703 RVA: 0x00AFEA68 File Offset: 0x00AFCC68
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

		// Token: 0x060273C0 RID: 160704 RVA: 0x00AFF07C File Offset: 0x00AFD27C
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

		// Token: 0x060273C1 RID: 160705 RVA: 0x00AFF110 File Offset: 0x00AFD310
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

		// Token: 0x0401563F RID: 87615
		public bool IsNormalButtonTypeList;

		// Token: 0x04015640 RID: 87616
		public IList<int> ButtonTypeList = new List<int>();

		// Token: 0x04015641 RID: 87617
		public List<SkillButtonIndex> ButtonIndexConfigList = new List<SkillButtonIndex>();

		// Token: 0x04015642 RID: 87618
		public bool ButtonIndexIsDesktop;

		// Token: 0x04015643 RID: 87619
		public List<int> DefaultButtonTypeList = new List<int>();

		// Token: 0x04015644 RID: 87620
		public readonly List<int[]> ButtonIndexTagIdList = new List<int[]>();

		// Token: 0x04015645 RID: 87621
		public readonly HashSet<int> ButtonIndexTagIdSet = new HashSet<int>();

		// Token: 0x04015646 RID: 87622
		public readonly List<List<int>> ButtonIndexTypeList = new List<List<int>>();

		// Token: 0x04015647 RID: 87623
		public readonly Dictionary<int, List<int>> ButtonTypeTagMap = new Dictionary<int, List<int>>();

		// Token: 0x04015648 RID: 87624
		public int[] MotorPadButtonTypeList = Array.Empty<int>();

		// Token: 0x04015649 RID: 87625
		public bool IsRoundJoystick;

		// Token: 0x0401564A RID: 87626
		public readonly Dictionary<int, int[]> MotorPadButtonTypeTagMap = new Dictionary<int, int[]>();

		// Token: 0x0401564B RID: 87627
		public readonly Dictionary<int, int[]> MotorJoystickPadButtonTypeTagMap = new Dictionary<int, int[]>();
	}
}
