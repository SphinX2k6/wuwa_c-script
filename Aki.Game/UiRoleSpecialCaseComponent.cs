using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

// Token: 0x02002CB7 RID: 11447
[NullableContext(2)]
[Nullable(0)]
public class UiRoleSpecialCaseComponent : UiModelComponentBase
{
	// Token: 0x06017ECA RID: 97994 RVA: 0x006156D8 File Offset: 0x006138D8
	protected override void OnInit()
	{
		this.RoleDataComponent = base.Owner.CheckGetComponent<UiRoleDataComponent>();
		this.TagComponent = base.Owner.CheckGetComponent<UiModelTagComponent>();
	}

	// Token: 0x06017ECB RID: 97995 RVA: 0x006156FC File Offset: 0x006138FC
	protected override void OnStart()
	{
		EventSystem.Instance.AddWithTarget(base.Owner, EEventName.OnUiModelRoleConfigIdChange, new Action(this.OnRoleConfigIdChange));
		this.Refresh();
	}

	// Token: 0x06017ECC RID: 97996 RVA: 0x00615726 File Offset: 0x00613926
	protected override void OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Owner, EEventName.OnUiModelRoleConfigIdChange, new Action(this.OnRoleConfigIdChange));
		this.LastApplied = null;
		this.LastSkinTagIds = new List<int>();
	}

	// Token: 0x06017ECD RID: 97997 RVA: 0x0061575C File Offset: 0x0061395C
	private void OnRoleConfigIdChange()
	{
		this.Refresh();
	}

	// Token: 0x06017ECE RID: 97998 RVA: 0x00615764 File Offset: 0x00613964
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

	// Token: 0x06017ECF RID: 97999 RVA: 0x006157BC File Offset: 0x006139BC
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

	// Token: 0x06017ED0 RID: 98000 RVA: 0x00615888 File Offset: 0x00613A88
	[NullableContext(1)]
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

	// Token: 0x06017ED1 RID: 98001 RVA: 0x0061590C File Offset: 0x00613B0C
	[NullableContext(1)]
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

	// Token: 0x06017ED2 RID: 98002 RVA: 0x00615950 File Offset: 0x00613B50
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

	// Token: 0x06017ED3 RID: 98003 RVA: 0x006159D4 File Offset: 0x00613BD4
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

	// Token: 0x06017ED4 RID: 98004 RVA: 0x00615A58 File Offset: 0x00613C58
	[NullableContext(1)]
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

	// Token: 0x0400B257 RID: 45655
	private UiRoleDataComponent RoleDataComponent;

	// Token: 0x0400B258 RID: 45656
	private UiModelTagComponent TagComponent;

	// Token: 0x0400B259 RID: 45657
	private RoleSpecialCaseData LastApplied;

	// Token: 0x0400B25A RID: 45658
	[Nullable(1)]
	private List<int> LastSkinTagIds = new List<int>();
}
