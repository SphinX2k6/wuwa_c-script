using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200270C RID: 9996
[NullableContext(1)]
[Nullable(0)]
public class SpecialSkillXigelika : SpecialSkillBase
{
	// Token: 0x060190E5 RID: 102629 RVA: 0x007A2104 File Offset: 0x007A0304
	public SpecialSkillXigelika(CharacterSpecialSkillComponent specialSkillComponent) : base(specialSkillComponent)
	{
	}

	// Token: 0x060190E6 RID: 102630 RVA: 0x007A228C File Offset: 0x007A048C
	public override void OnStart()
	{
		this.Entity = this.SpecialSkillComponent.Entity;
		this.TagComponent = this.Entity.GetComponent<RoleTagComponent>();
		this.BuffComponent = this.Entity.GetComponent<RoleBuffComponent>();
		EventSystem.Instance.AddWithTarget(this.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		RoleTagComponent tagComponent = this.TagComponent;
		this.ResetTagListener = ((tagComponent != null) ? tagComponent.ListenForTagAddOrRemove(new int?(this.resetTag), new BaseTagComponent.TTagSwitchedCallback(this.OnTagChange), null) : null);
	}

	// Token: 0x060190E7 RID: 102631 RVA: 0x007A2320 File Offset: 0x007A0520
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

	// Token: 0x060190E8 RID: 102632 RVA: 0x007A236F File Offset: 0x007A056F
	public override void OnDisable()
	{
	}

	// Token: 0x060190E9 RID: 102633 RVA: 0x007A2371 File Offset: 0x007A0571
	private void OnRoleDead()
	{
		this.ResetBean();
	}

	// Token: 0x060190EA RID: 102634 RVA: 0x007A2379 File Offset: 0x007A0579
	private void OnTagChange(int tagId, bool tagExists)
	{
		if (tagExists)
		{
			this.ResetBean();
		}
	}

	// Token: 0x060190EB RID: 102635 RVA: 0x007A2384 File Offset: 0x007A0584
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

	// Token: 0x060190EC RID: 102636 RVA: 0x007A256B File Offset: 0x007A076B
	private void PushBean(string bean)
	{
		if (this.BeanQueue.Size == 2)
		{
			this.BeanQueue.Pop();
		}
		this.BeanQueue.Push(bean);
	}

	// Token: 0x060190ED RID: 102637 RVA: 0x007A2594 File Offset: 0x007A0794
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

	// Token: 0x060190EE RID: 102638 RVA: 0x007A26AC File Offset: 0x007A08AC
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

	// Token: 0x060190EF RID: 102639 RVA: 0x007A281C File Offset: 0x007A0A1C
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

	// Token: 0x060190F0 RID: 102640 RVA: 0x007A2908 File Offset: 0x007A0B08
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

	// Token: 0x0400DAB9 RID: 55993
	private const int QUEUE_MAX_LENGTH = 2;

	// Token: 0x0400DABA RID: 55994
	private const string BEAN_A = "A";

	// Token: 0x0400DABB RID: 55995
	private const string BEAN_B = "B";

	// Token: 0x0400DABC RID: 55996
	private const long FUDU_BUFF = 1412301005L;

	// Token: 0x0400DABD RID: 55997
	private const long SUDU_BUFF = 1412401001L;

	// Token: 0x0400DABE RID: 55998
	private const int AA = 1;

	// Token: 0x0400DABF RID: 55999
	private const int BB = 2;

	// Token: 0x0400DAC0 RID: 56000
	private const int AB = 3;

	// Token: 0x0400DAC1 RID: 56001
	private readonly int resetTag = GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.两符文已使用"];

	// Token: 0x0400DAC2 RID: 56002
	private readonly int[] locTagA = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.A印记4"]
	};

	// Token: 0x0400DAC3 RID: 56003
	private readonly int[] locTagB = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.B印记4"]
	};

	// Token: 0x0400DAC4 RID: 56004
	private readonly int[] locUsedTagA = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用A印记4"]
	};

	// Token: 0x0400DAC5 RID: 56005
	private readonly int[] locUsedTagB = new int[]
	{
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记1"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记2"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记3"],
		GameplayTagDefine.EGameplayTagId["角色.R2T1XigelikaMd10011.状态标识.已使用B印记4"]
	};

	// Token: 0x0400DAC6 RID: 56006
	private readonly Queue<string> BeanQueue = new Queue<string>(4);

	// Token: 0x0400DAC7 RID: 56007
	private bool BeanUsing;

	// Token: 0x0400DAC8 RID: 56008
	private bool BeanFull;

	// Token: 0x0400DAC9 RID: 56009
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x0400DACA RID: 56010
	[Nullable(2)]
	private RoleTagComponent TagComponent;

	// Token: 0x0400DACB RID: 56011
	[Nullable(2)]
	private RoleBuffComponent BuffComponent;

	// Token: 0x0400DACC RID: 56012
	[Nullable(2)]
	private ITagTask ResetTagListener;
}
