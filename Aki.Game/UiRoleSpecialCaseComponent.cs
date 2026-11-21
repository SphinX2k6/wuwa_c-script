using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x02002210 RID: 8720
[NullableContext(1)]
[Nullable(0)]
public class UiRoleSpecialCaseComponent : UiModelComponentBase
{
	// Token: 0x06015741 RID: 87873 RVA: 0x0063B2F4 File Offset: 0x006394F4
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.TagComponent = base.Owner.CheckGetComponent<UiModelTagComponent>();
	}

	// Token: 0x06015742 RID: 87874 RVA: 0x0063B318 File Offset: 0x00639518
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelRoleConfigIdChange, new Action(this.OnRoleConfigIdChange));
		this.Refresh();
	}

	// Token: 0x06015743 RID: 87875 RVA: 0x0063B342 File Offset: 0x00639542
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelRoleConfigIdChange, new Action(this.OnRoleConfigIdChange));
		this.LastApplied = null;
		this.LastSkinTagIds = new List<int>();
	}

	// Token: 0x06015744 RID: 87876 RVA: 0x0063B378 File Offset: 0x00639578
	private void OnRoleConfigIdChange()
	{
		this.Refresh();
	}

	// Token: 0x06015745 RID: 87877 RVA: 0x0063B380 File Offset: 0x00639580
	private void Refresh()
	{
		UiRoleDataComponent roleDataComponent = this.RoleDataComponent;
		int key = (roleDataComponent != null) ? roleDataComponent.RoleConfigId : 0;
		RoleSpecialCaseData roleSpecialCaseData;
		RoleSpecialCaseConfig.RoleSpecialCaseMap.TryGetValue(key, out roleSpecialCaseData);
		if (roleSpecialCaseData != this.LastApplied)
		{
			this.Revert(this.LastApplied);
			this.Apply(roleSpecialCaseData);
			this.LastApplied = roleSpecialCaseData;
		}
		this.RefreshSkinTags();
	}

	// Token: 0x06015746 RID: 87878 RVA: 0x0063B3D8 File Offset: 0x006395D8
	private void RefreshSkinTags()
	{
		if (this.TagComponent == null)
		{
			return;
		}
		List<int> list = this.ResolveSkinTagIds();
		if (this.IsSameTagIds(list, this.LastSkinTagIds))
		{
			return;
		}
		foreach (int tagId in this.LastSkinTagIds)
		{
			this.TagComponent.ReduceTagById(tagId, Array.Empty<object>());
		}
		foreach (int tagId2 in list)
		{
			this.TagComponent.AddTagById(tagId2, Array.Empty<object>());
		}
		this.LastSkinTagIds = list;
	}

	// Token: 0x06015747 RID: 87879 RVA: 0x0063B4A4 File Offset: 0x006396A4
	private static string[] ToTagNames(ICollection<int> tagIds)
	{
		string[] array = new string[tagIds.Count];
		int num = 0;
		foreach (int tagId in tagIds)
		{
			array[num++] = GameplayTagUtils.GetNameByTagId(tagId);
		}
		return array;
	}

	// Token: 0x06015748 RID: 87880 RVA: 0x0063B504 File Offset: 0x00639704
	private List<int> ResolveSkinTagIds()
	{
		List<int> list = new List<int>();
		UiRoleDataComponent roleDataComponent = this.RoleDataComponent;
		int num = (roleDataComponent != null) ? roleDataComponent.RoleSkinId : 0;
		if (num <= 0)
		{
			return list;
		}
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(num);
		if (roleSkinData == null)
		{
			return list;
		}
		RoleSkin roleSkinConfig = roleSkinData.GetRoleSkinConfig();
		for (int i = 0; i < roleSkinConfig.UiModelEquipTagsLength; i++)
		{
			int? num2 = this.ResolveTagId(roleSkinConfig.UiModelEquipTags(i));
			if (num2 != null)
			{
				list.Add(num2.Value);
			}
		}
		return list;
	}

	// Token: 0x06015749 RID: 87881 RVA: 0x0063B588 File Offset: 0x00639788
	private bool IsSameTagIds(List<int> a, List<int> b)
	{
		if (a.Count != b.Count)
		{
			return false;
		}
		for (int i = 0; i < a.Count; i++)
		{
			if (a[i] != b[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601574A RID: 87882 RVA: 0x0063B5CC File Offset: 0x006397CC
	[NullableContext(2)]
	private void Apply(RoleSpecialCaseData data)
	{
		if (data == null || this.TagComponent == null)
		{
			return;
		}
		if (data.Tags != null)
		{
			foreach (string tagName in data.Tags)
			{
				int? num = this.ResolveTagId(tagName);
				if (num != null)
				{
					this.TagComponent.AddTagById(num.Value, Array.Empty<object>());
				}
			}
		}
	}

	// Token: 0x0601574B RID: 87883 RVA: 0x0063B650 File Offset: 0x00639850
	[NullableContext(2)]
	private void Revert(RoleSpecialCaseData data)
	{
		if (data == null || this.TagComponent == null)
		{
			return;
		}
		if (data.Tags != null)
		{
			foreach (string tagName in data.Tags)
			{
				int? num = this.ResolveTagId(tagName);
				if (num != null)
				{
					this.TagComponent.ReduceTagById(num.Value, Array.Empty<object>());
				}
			}
		}
	}

	// Token: 0x0601574C RID: 87884 RVA: 0x0063B6D4 File Offset: 0x006398D4
	private unsafe int? ResolveTagId(string tagName)
	{
		int tagIdByName = GameplayTagUtils.GetTagIdByName(tagName);
		if (GameplayTagUtils.GetGameplayTagById(tagIdByName) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiComponent;
			ELogAuthor author = ELogAuthor.LJS;
			string message = "UiRoleSpecialCaseComponent: GameplayTag 不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tagName", tagName);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "roleConfigId";
			UiRoleDataComponent roleDataComponent = this.RoleDataComponent;
			ptr = new ValueTuple<string, object>(item, (roleDataComponent != null) ? new int?(roleDataComponent.RoleConfigId) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return new int?(tagIdByName);
	}

	// Token: 0x0400B5C2 RID: 46530
	[Nullable(2)]
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B5C3 RID: 46531
	[Nullable(2)]
	private UiModelTagComponent TagComponent;

	// Token: 0x0400B5C4 RID: 46532
	[Nullable(2)]
	private RoleSpecialCaseData LastApplied;

	// Token: 0x0400B5C5 RID: 46533
	private List<int> LastSkinTagIds = new List<int>();
}
