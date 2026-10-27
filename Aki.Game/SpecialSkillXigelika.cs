using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200319E RID: 12702
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillXigelika : SpecialSkillBase
{
	// Token: 0x0601B5C5 RID: 112069 RVA: 0x00779E78 File Offset: 0x00778078
	public SpecialSkillXigelika(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x0601B5C6 RID: 112070 RVA: 0x0077A000 File Offset: 0x00778200
	public override void OnStart()
	{
		this.Entity = this.SpecialSkillComponent.Entity;
		this.TagComponent = this.Entity.GetComponent<RoleTagComponent>();
		this.BuffComponent = this.Entity.GetComponent<RoleBuffComponent>();
		EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		RoleTagComponent tagComponent = this.TagComponent;
		this.ResetTagListener = ((tagComponent != null) ? tagComponent.ListenForTagAddOrRemove(new int?(this.resetTag), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), null) : null);
	}

	// Token: 0x0601B5C7 RID: 112071 RVA: 0x0077A094 File Offset: 0x00778294
	public override void OnEnd()
	{
		if (this.Entity != null)
		{
			EventSystem.Instance.RemoveWithTarget(this.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		}
		ITagTask resetTagListener = this.ResetTagListener;
		if (resetTagListener != null)
		{
			resetTagListener.EndTask();
		}
		this.ResetTagListener = null;
	}

	// Token: 0x0601B5C8 RID: 112072 RVA: 0x0077A0E3 File Offset: 0x007782E3
	public override void OnDisable()
	{
	}

	// Token: 0x0601B5C9 RID: 112073 RVA: 0x0077A0E5 File Offset: 0x007782E5
	private void OnRoleDead()
	{
		this.ResetBean();
	}

	// Token: 0x0601B5CA RID: 112074 RVA: 0x0077A0ED File Offset: 0x007782ED
	private void OnTagChange(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			this.ResetBean();
		}
	}

	// Token: 0x0601B5CB RID: 112075 RVA: 0x0077A0F8 File Offset: 0x007782F8
	public int AddBean(string bean)
	{
		if (this.BeanFull)
		{
			return 0;
		}
		if (bean != "A" && bean != "B")
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.ZFJ;
			string message = "[SpecialSkillXigelika]印记名字错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", bean);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return 0;
		}
		int size = this.BeanQueue.Size;
		this.PushBean(bean);
		Log instance2 = Log.Instance;
		ELogModule module2 = ELogModule.Battle;
		ELogAuthor author2 = ELogAuthor.ZFJ;
		string message2 = "[SpecialSkillXigelika]普通加印记";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("印记", bean);
		instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		RoleTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.复读"]))
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Battle;
			ELogAuthor author3 = ELogAuthor.ZFJ;
			string message3 = "[SpecialSkillXigelika]复读加印记";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("印记", bean);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			this.PushBean(bean);
			RoleBuffComponent buffComponent = this.BuffComponent;
			if (buffComponent != null)
			{
				buffComponent.RemoveBuff(1412301005L, -1, "Xigelika复读消耗", null, null, null);
			}
		}
		else
		{
			RoleTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.速读"]))
			{
				string text = (bean == "A") ? "B" : "A";
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Battle;
				ELogAuthor author4 = ELogAuthor.ZFJ;
				string message4 = "[SpecialSkillXigelika]速读加印记";
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("印记", text);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
				this.PushBean(text);
				RoleBuffComponent buffComponent2 = this.BuffComponent;
				if (buffComponent2 != null)
				{
					buffComponent2.RemoveBuff(1412401001L, -1, "Xigelika速读消耗", null, null, null);
				}
			}
		}
		this.RefreshBeanTag();
		return this.BeanQueue.Size - size;
	}

	// Token: 0x0601B5CC RID: 112076 RVA: 0x0077A2DF File Offset: 0x007784DF
	private void PushBean(string bean)
	{
		if (this.BeanQueue.Size == 2)
		{
			this.BeanQueue.Pop();
		}
		this.BeanQueue.Push(bean);
	}

	// Token: 0x0601B5CD RID: 112077 RVA: 0x0077A308 File Offset: 0x00778508
	public int GetBeanResultant()
	{
		RoleTagComponent tagComponent = this.TagComponent;
		int num;
		if (tagComponent == null || !tagComponent.HasAllTag(new <>z__ReadOnlyArray<int>(new int[]
		{
			this.locTagA[0],
			this.locTagA[1]
		})))
		{
			RoleTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 == null || !tagComponent2.HasAllTag(new <>z__ReadOnlyArray<int>(new int[]
			{
				this.locTagA[2],
				this.locTagA[3]
			})))
			{
				RoleTagComponent tagComponent3 = this.TagComponent;
				if (tagComponent3 == null || !tagComponent3.HasAllTag(new <>z__ReadOnlyArray<int>(new int[]
				{
					this.locTagB[0],
					this.locTagB[1]
				})))
				{
					RoleTagComponent tagComponent4 = this.TagComponent;
					if (tagComponent4 == null || !tagComponent4.HasAllTag(new <>z__ReadOnlyArray<int>(new int[]
					{
						this.locTagB[2],
						this.locTagB[3]
					})))
					{
						num = 3;
						goto IL_DE;
					}
				}
				num = 2;
				goto IL_DE;
			}
		}
		num = 1;
		IL_DE:
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Battle;
		ELogAuthor author = ELogAuthor.ZFJ;
		string message = "[SpecialSkillXigelika]印记组合结果";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("结果", num);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return num;
	}

	// Token: 0x0601B5CE RID: 112078 RVA: 0x0077A420 File Offset: 0x00778620
	public void ConsumeBean()
	{
		Log.Instance.Info(ELogModule.Battle, ELogAuthor.ZFJ, "[SpecialSkillXigelika]消耗印记", default(ReadOnlySpan<ValueTuple<string, object>>));
		foreach (int num in this.locTagA)
		{
			RoleTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(num))
			{
				this.TagComponent.RemoveTag(new int?(num));
			}
		}
		foreach (int num2 in this.locTagB)
		{
			RoleTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(num2))
			{
				this.TagComponent.RemoveTag(new int?(num2));
			}
		}
		int num3 = this.BeanUsing ? 2 : 0;
		for (int j = 0; j < 2; j++)
		{
			if (this.BeanQueue.Size > j)
			{
				string text = this.BeanQueue.Get(j);
				if (text != null)
				{
					int num4 = (text == "A") ? this.locUsedTagA[j + num3] : this.locUsedTagB[j + num3];
					RoleTagComponent tagComponent3 = this.TagComponent;
					if (tagComponent3 == null || !tagComponent3.HasTag(num4))
					{
						RoleTagComponent tagComponent4 = this.TagComponent;
						if (tagComponent4 != null)
						{
							tagComponent4.AddTag(new int?(num4));
						}
					}
				}
			}
		}
		this.BeanQueue.Clear();
		if (this.BeanUsing)
		{
			this.BeanFull = true;
		}
		this.BeanUsing = true;
	}

	// Token: 0x0601B5CF RID: 112079 RVA: 0x0077A590 File Offset: 0x00778790
	private void RefreshBeanTag()
	{
		int num = this.BeanUsing ? 2 : 0;
		for (int i = 0; i < this.BeanQueue.Size; i++)
		{
			string text = this.BeanQueue.Get(i);
			if (text != null)
			{
				int num2 = (text == "A") ? this.locTagA[i + num] : this.locTagB[i + num];
				int num3 = (text == "A") ? this.locTagB[i + num] : this.locTagA[i + num];
				RoleTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null && tagComponent.HasTag(num3))
				{
					this.TagComponent.RemoveTag(new int?(num3));
				}
				RoleTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null || !tagComponent2.HasTag(num2))
				{
					RoleTagComponent tagComponent3 = this.TagComponent;
					if (tagComponent3 != null)
					{
						tagComponent3.AddTag(new int?(num2));
					}
				}
			}
		}
	}

	// Token: 0x0601B5D0 RID: 112080 RVA: 0x0077A67C File Offset: 0x0077887C
	public void ResetBean()
	{
		Log.Instance.Info(ELogModule.Battle, ELogAuthor.ZFJ, "[SpecialSkillXigelika]重置印记", default(ReadOnlySpan<ValueTuple<string, object>>));
		foreach (int num in this.locTagA)
		{
			RoleTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null && tagComponent.HasTag(num))
			{
				this.TagComponent.RemoveTag(new int?(num));
			}
		}
		foreach (int num2 in this.locTagB)
		{
			RoleTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(num2))
			{
				this.TagComponent.RemoveTag(new int?(num2));
			}
		}
		foreach (int num3 in this.locUsedTagA)
		{
			RoleTagComponent tagComponent3 = this.TagComponent;
			if (tagComponent3 != null && tagComponent3.HasTag(num3))
			{
				this.TagComponent.RemoveTag(new int?(num3));
			}
		}
		foreach (int num4 in this.locUsedTagB)
		{
			RoleTagComponent tagComponent4 = this.TagComponent;
			if (tagComponent4 != null && tagComponent4.HasTag(num4))
			{
				this.TagComponent.RemoveTag(new int?(num4));
			}
		}
		this.BeanQueue.Clear();
		this.BeanFull = false;
		this.BeanUsing = false;
	}

	// Token: 0x0400D636 RID: 54838
	private const int QUEUE_MAX_LENGTH = 2;

	// Token: 0x0400D637 RID: 54839
	private const string BEAN_A = "A";

	// Token: 0x0400D638 RID: 54840
	private const string BEAN_B = "B";

	// Token: 0x0400D639 RID: 54841
	private const long FUDU_BUFF = 1412301005L;

	// Token: 0x0400D63A RID: 54842
	private const long SUDU_BUFF = 1412401001L;

	// Token: 0x0400D63B RID: 54843
	private const int AA = 1;

	// Token: 0x0400D63C RID: 54844
	private const int BB = 2;

	// Token: 0x0400D63D RID: 54845
	private const int AB = 3;

	// Token: 0x0400D63E RID: 54846
	private readonly int resetTag = GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.两符文已使用"];

	// Token: 0x0400D63F RID: 54847
	private readonly int[] locTagA = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记4"]
	};

	// Token: 0x0400D640 RID: 54848
	private readonly int[] locTagB = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记4"]
	};

	// Token: 0x0400D641 RID: 54849
	private readonly int[] locUsedTagA = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记4"]
	};

	// Token: 0x0400D642 RID: 54850
	private readonly int[] locUsedTagB = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记4"]
	};

	// Token: 0x0400D643 RID: 54851
	private readonly Queue<string> BeanQueue = new Queue<string>(4);

	// Token: 0x0400D644 RID: 54852
	private bool BeanUsing;

	// Token: 0x0400D645 RID: 54853
	private bool BeanFull;

	// Token: 0x0400D646 RID: 54854
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x0400D647 RID: 54855
	[Nullable(2)]
	private RoleTagComponent TagComponent;

	// Token: 0x0400D648 RID: 54856
	[Nullable(2)]
	private RoleBuffComponent BuffComponent;

	// Token: 0x0400D649 RID: 54857
	[Nullable(2)]
	private ITagTask ResetTagListener;
}
