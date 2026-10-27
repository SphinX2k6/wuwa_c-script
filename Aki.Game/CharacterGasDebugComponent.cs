using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using Aki.Protocol.Ai;
using Aki.Protocol.Debug;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Vehicle.Motorcycle;
using CSharpScript.Game.World.Model;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine;

// Token: 0x02002EC8 RID: 11976
[NullableContext(1)]
[Nullable(0)]
public class CharacterGasDebugComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x060198E4 RID: 104676 RVA: 0x0069C5C4 File Offset: 0x0069A7C4
	static CharacterGasDebugComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterGasDebugComponent.CreateStaticDefaultValue), new Action(CharacterGasDebugComponent.ResetStaticDefaultValue));
	}

	// Token: 0x060198E5 RID: 104677 RVA: 0x0069C6B4 File Offset: 0x0069A8B4
	public static void CreateStaticDefaultValue()
	{
		EAttributeType[] array = new EAttributeType[66];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.90066994069708F4BE5C0F6E5772312598BCB9848418CD9C1798F16C878742E0).FieldHandle);
		CharacterGasDebugComponent._attributeIdArray = array;
		CharacterGasDebugComponent._moveRecordStrings = new List<string>();
		CharacterGasDebugComponent._damageRecordStrings = new List<string>();
		CharacterGasDebugComponent._moveSumTable = new Dictionary<int, RecordMoveSum>();
		CharacterGasDebugComponent._roleDamageSumTable = new Dictionary<string, RecordDamageSum>();
		CharacterGasDebugComponent._monsterDamageSumTable = new Dictionary<string, RecordDamageSum>();
		CharacterGasDebugComponent._bulletCreateMap = new Dictionary<int, string[]>();
		CharacterGasDebugComponent._bulletCreateEntityId = new List<int>();
		CharacterGasDebugComponent._buffRecordArray = new List<string>();
		CharacterGasDebugComponent._damageRecordSnipeshotArray = new List<string>();
		CharacterGasDebugComponent._damageRecordAttrArray = new List<string>();
	}

	// Token: 0x060198E6 RID: 104678 RVA: 0x0069C73C File Offset: 0x0069A93C
	public static void ResetStaticDefaultValue()
	{
		CharacterGasDebugComponent._attributeIdArray = null;
		CharacterGasDebugComponent.IsServerLogOnInternal = false;
		CharacterGasDebugComponent.ShouldRecord = false;
		CharacterGasDebugComponent.RecordStartTime = 0.0;
		CharacterGasDebugComponent.RecordStartTimeStamp = 0.0;
		CharacterGasDebugComponent._moveRecordStrings = null;
		CharacterGasDebugComponent._damageRecordStrings = null;
		CharacterGasDebugComponent._moveSumTable = null;
		CharacterGasDebugComponent._roleDamageSumTable = null;
		CharacterGasDebugComponent._monsterDamageSumTable = null;
		CharacterGasDebugComponent._bulletCreateMap = null;
		CharacterGasDebugComponent._bulletCreateEntityId = null;
		CharacterGasDebugComponent._buffRecordArray = null;
		CharacterGasDebugComponent._damageRecordSnipeshotArray = null;
		CharacterGasDebugComponent._damageRecordAttrArray = null;
		CharacterGasDebugComponent.DamageRecordDspMap = null;
		CharacterGasDebugComponent.InTimeStop = false;
		CharacterGasDebugComponent.TimeStopSpanTime = 0f;
		CharacterGasDebugComponent.FrameUpdateSpanTime = 0L;
	}

	// Token: 0x17002344 RID: 9028
	// (get) Token: 0x060198E7 RID: 104679 RVA: 0x0069C7D0 File Offset: 0x0069A9D0
	private static EAttributeType[] AttributeIdArray
	{
		get
		{
			return CharacterGasDebugComponent._attributeIdArray;
		}
	}

	// Token: 0x060198E8 RID: 104680 RVA: 0x0069C7D8 File Offset: 0x0069A9D8
	protected override bool OnStart()
	{
		CharacterActorComponent component = base.Entity.GetComponent<CharacterActorComponent>();
		this.DebugGasComponent = ((component != null) ? component.Actor.AbilitySystemComponent : null);
		this.BeginDebugTask();
		this.StartListenMovementHistory();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharRecordOperate, new Action<EntityHandle, int, IReadOnlyList<ESkillGenre>>(this.RecordMove));
		EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnBeginSkill));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.BulletCreate, new Action<BulletInfo>(this.OnBulletCreate));
		return true;
	}

	// Token: 0x060198E9 RID: 104681 RVA: 0x0069C878 File Offset: 0x0069AA78
	protected override void OnTick(float delta)
	{
		if (CharacterGasDebugComponent.InTimeStop && (long)Time.Instance.Frame > CharacterGasDebugComponent.FrameUpdateSpanTime)
		{
			CharacterGasDebugComponent.TimeStopSpanTime += delta * 0.001f;
			CharacterGasDebugComponent.FrameUpdateSpanTime = (long)Time.Instance.Frame;
		}
		if (this.EnableCollisionDebugDraw)
		{
			BaseActorComponent component = base.Entity.GetComponent<BaseActorComponent>();
			if (component != null)
			{
				AActor owner = component.Owner;
				TArray<UActorComponent> tarray = (owner != null) ? owner.K2_GetComponentsByClass(UCapsuleComponent.StaticClass()) : null;
				int num = 0;
				while (tarray != null && num < tarray.Num())
				{
					UCapsuleComponent ucapsuleComponent = tarray.Get(num) as UCapsuleComponent;
					UKismetSystemLibrary.D_DrawDebugCapsule(component.Owner, ucapsuleComponent.D_K2_GetComponentLocation(), ucapsuleComponent.CapsuleHalfHeight, ucapsuleComponent.CapsuleRadius, ucapsuleComponent.K2_GetComponentRotation(), new FLinearColor?(new FLinearColor(1f, 1f, 0f, 1f)), 0f, 1f);
					num++;
				}
			}
		}
	}

	// Token: 0x060198EA RID: 104682 RVA: 0x0069C968 File Offset: 0x0069AB68
	protected override bool OnEnd()
	{
		UAsyncTaskEffectDebugString geDebugTask = this.GeDebugTask;
		if (geDebugTask != null)
		{
			geDebugTask.EndTask();
		}
		this.GeDebugTask = null;
		this.EndListenMovementHistory();
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharRecordOperate, new Action<EntityHandle, int, IReadOnlyList<ESkillGenre>>(this.RecordMove));
		EventSystem.Instance.RemoveWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnBeginSkill));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.BulletCreate, new Action<BulletInfo>(this.OnBulletCreate));
		return true;
	}

	// Token: 0x060198EB RID: 104683 RVA: 0x0069C9F7 File Offset: 0x0069ABF7
	private void BeginDebugTask()
	{
		if (this.DebugGasComponent == null)
		{
			return;
		}
		this.GeDebugTask = UAsyncTaskEffectDebugString.ListenForGameplayEffectExecutedDebugString(this.DebugGasComponent);
		UAsyncTaskEffectDebugString geDebugTask = this.GeDebugTask;
		if (geDebugTask == null)
		{
			return;
		}
		geDebugTask.OnAnyGameplayEffectExecuted.Add(new Action<string>(this.GeDebugTaskCallback));
	}

	// Token: 0x060198EC RID: 104684 RVA: 0x0069CA34 File Offset: 0x0069AC34
	private void GeDebugTaskCallback(string debugInfo)
	{
		if (debugInfo.Contains("Tag"))
		{
			return;
		}
		this.GeDebugId++;
		this.DebugStrings.Insert(0, "Num " + this.GeDebugId.ToString() + ": " + debugInfo);
		if (this.DebugStrings.Count > 50)
		{
			this.DebugStrings.RemoveAt(this.DebugStrings.Count - 1);
		}
	}

	// Token: 0x060198ED RID: 104685 RVA: 0x0069CAAB File Offset: 0x0069ACAB
	public string GetGeDebugStrings()
	{
		return string.Join(" ", this.DebugStrings);
	}

	// Token: 0x060198EE RID: 104686 RVA: 0x0069CABD File Offset: 0x0069ACBD
	public string GetTagDebugStrings()
	{
		BaseTagComponent component = base.Entity.GetComponent<BaseTagComponent>();
		return ((component != null) ? component.TagContainer.GetDebugString() : null) ?? "找不到tag组件";
	}

	// Token: 0x060198EF RID: 104687 RVA: 0x0069CAE4 File Offset: 0x0069ACE4
	public unsafe void AddSkillLogString(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		if (this.SkillLogStrings.Count >= 50)
		{
			this.SkillLogStrings.RemoveAt(0);
		}
		StringBuilder sb = CharacterGasDebugComponent.Sb;
		sb.Clear();
		sb.Append('#');
		sb.Append(message);
		ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			ValueTuple<string, object> valueTuple = *readOnlySpan[i];
			string item = valueTuple.Item1;
			object item2 = valueTuple.Item2;
			sb.Append(' ');
			StringBuilder stringBuilder = sb;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder);
			appendInterpolatedStringHandler.AppendLiteral("[");
			appendInterpolatedStringHandler.AppendFormatted(item);
			appendInterpolatedStringHandler.AppendLiteral(": ");
			appendInterpolatedStringHandler.AppendFormatted((item2 != null) ? item2.ToString() : "null");
			appendInterpolatedStringHandler.AppendLiteral("]");
			stringBuilder2.Append(ref appendInterpolatedStringHandler);
		}
		string text = sb.ToString();
		if (text.Contains("BeginSkill"))
		{
			text = "\n" + text;
		}
		this.SkillLogStrings.Add(text);
	}

	// Token: 0x060198F0 RID: 104688 RVA: 0x0069CBF4 File Offset: 0x0069ADF4
	public string GetSkillLogString(string filterStr)
	{
		List<string> list = new List<string>();
		if (!string.IsNullOrEmpty(filterStr))
		{
			MatchCollection matchCollection = Regex.Matches(filterStr, "[0-9]+");
			for (int i = 0; i < matchCollection.Count; i++)
			{
				string value = matchCollection[i].Value;
				list.Add(value);
			}
		}
		List<string> list2 = new List<string>();
		int j = 0;
		while (j < this.SkillLogStrings.Count)
		{
			string text = this.SkillLogStrings[j];
			if (list.Count <= 0)
			{
				goto IL_9A;
			}
			bool flag = false;
			for (int k = 0; k < list.Count; k++)
			{
				string value2 = list[k];
				if (text.Contains(value2))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				goto IL_9A;
			}
			IL_A2:
			j++;
			continue;
			IL_9A:
			list2.Add(text);
			goto IL_A2;
		}
		return string.Join("\n", list2);
	}

	// Token: 0x060198F1 RID: 104689 RVA: 0x0069CCC3 File Offset: 0x0069AEC3
	public void ClearSkillLogString()
	{
		this.SkillLogStrings.Clear();
	}

	// Token: 0x060198F2 RID: 104690 RVA: 0x0069CCD0 File Offset: 0x0069AED0
	public unsafe void AddSkillBehaviorLogString(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		if (this.SkillBehaviorLogStrings.Count >= 50)
		{
			this.SkillBehaviorLogStrings.RemoveAt(0);
		}
		StringBuilder sb = CharacterGasDebugComponent.Sb;
		sb.Clear();
		sb.Append('#');
		sb.Append(message);
		ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			ValueTuple<string, object> valueTuple = *readOnlySpan[i];
			string item = valueTuple.Item1;
			object item2 = valueTuple.Item2;
			sb.Append(' ');
			StringBuilder stringBuilder = sb;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder);
			appendInterpolatedStringHandler.AppendLiteral("[");
			appendInterpolatedStringHandler.AppendFormatted(item);
			appendInterpolatedStringHandler.AppendLiteral(": ");
			appendInterpolatedStringHandler.AppendFormatted((item2 != null) ? item2.ToString() : "null");
			appendInterpolatedStringHandler.AppendLiteral("]");
			stringBuilder2.Append(ref appendInterpolatedStringHandler);
		}
		string item3 = sb.ToString();
		this.SkillBehaviorLogStrings.Add(item3);
	}

	// Token: 0x060198F3 RID: 104691 RVA: 0x0069CDC8 File Offset: 0x0069AFC8
	public string GetSkillBehaviorLogString(string filterStr)
	{
		List<string> list = new List<string>();
		foreach (object obj in Regex.Matches(filterStr, "[0-9]+"))
		{
			Match match = (Match)obj;
			list.Add(match.Value);
		}
		List<string> list2 = new List<string>();
		foreach (string text in this.SkillBehaviorLogStrings)
		{
			if (list.Count > 0)
			{
				bool flag = false;
				foreach (string value in list)
				{
					if (text.Contains(value))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			list2.Add(text);
		}
		return string.Join("\n", list2);
	}

	// Token: 0x060198F4 RID: 104692 RVA: 0x0069CEE4 File Offset: 0x0069B0E4
	public void ClearSkillBehaviorLogString()
	{
		this.SkillBehaviorLogStrings.Clear();
	}

	// Token: 0x060198F5 RID: 104693 RVA: 0x0069CEF4 File Offset: 0x0069B0F4
	public unsafe void AddBulletDebugLogString(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		if (this.BulletDebugStrings.Count >= 50)
		{
			this.BulletDebugStrings.RemoveAt(0);
		}
		StringBuilder sb = CharacterGasDebugComponent.Sb;
		sb.Clear();
		sb.Append('#');
		sb.Append(message);
		if (pairs.Length > 0)
		{
			sb.Append(' ');
			ReadOnlySpan<ValueTuple<string, object>> readOnlySpan = pairs;
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				ValueTuple<string, object> valueTuple = *readOnlySpan[i];
				StringBuilder stringBuilder = sb;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder);
				appendInterpolatedStringHandler.AppendLiteral("[");
				appendInterpolatedStringHandler.AppendFormatted(valueTuple.Item1);
				appendInterpolatedStringHandler.AppendLiteral(": ");
				appendInterpolatedStringHandler.AppendFormatted((valueTuple.Item2 != null) ? valueTuple.Item2.ToString() : "null");
				appendInterpolatedStringHandler.AppendLiteral("]");
				stringBuilder2.Append(ref appendInterpolatedStringHandler);
			}
		}
		this.BulletDebugStrings.Add(sb.ToString());
	}

	// Token: 0x060198F6 RID: 104694 RVA: 0x0069CFF0 File Offset: 0x0069B1F0
	public void AddBulletDebugLogString(string message, [ParamCollection] [Nullable(new byte[]
	{
		1,
		0,
		1,
		2
	})] IReadOnlyCollection<ValueTuple<string, object>> pairs)
	{
		if (this.BulletDebugStrings.Count >= 50)
		{
			this.BulletDebugStrings.RemoveAt(0);
		}
		StringBuilder sb = CharacterGasDebugComponent.Sb;
		sb.Clear();
		sb.Append("#");
		sb.Append(message);
		if (pairs.Count > 0)
		{
			sb.Append(' ');
			foreach (ValueTuple<string, object> valueTuple in pairs)
			{
				StringBuilder stringBuilder = sb;
				StringBuilder stringBuilder2 = stringBuilder;
				StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(4, 2, stringBuilder);
				appendInterpolatedStringHandler.AppendLiteral("[");
				appendInterpolatedStringHandler.AppendFormatted(valueTuple.Item1);
				appendInterpolatedStringHandler.AppendLiteral(": ");
				appendInterpolatedStringHandler.AppendFormatted((valueTuple.Item2 != null) ? valueTuple.Item2.ToString() : "null");
				appendInterpolatedStringHandler.AppendLiteral("]");
				stringBuilder2.Append(ref appendInterpolatedStringHandler);
			}
		}
		this.BulletDebugStrings.Add(sb.ToString());
	}

	// Token: 0x060198F7 RID: 104695 RVA: 0x0069D0FC File Offset: 0x0069B2FC
	public string GetBulletLogString(string filterStr)
	{
		List<string> list = new List<string>();
		foreach (object obj in Regex.Matches(filterStr, "[0-9]+"))
		{
			Match match = (Match)obj;
			list.Add(match.Value);
		}
		List<string> list2 = new List<string>();
		foreach (string text in this.BulletDebugStrings)
		{
			if (list.Count > 0)
			{
				bool flag = false;
				foreach (string value in list)
				{
					if (text.Contains(value))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					continue;
				}
			}
			list2.Add(text);
		}
		return string.Join("\n", list2);
	}

	// Token: 0x060198F8 RID: 104696 RVA: 0x0069D218 File Offset: 0x0069B418
	public void ClearBulletLogString()
	{
		this.BulletDebugStrings.Clear();
	}

	// Token: 0x060198F9 RID: 104697 RVA: 0x0069D228 File Offset: 0x0069B428
	public string GetTagContainerDebugString(FGameplayTagContainer tagContainer)
	{
		TArray<FGameplayTag> gameplayTags = tagContainer.GameplayTags;
		int num = (gameplayTags != null) ? gameplayTags.Num() : 0;
		if (num <= 0)
		{
			return "";
		}
		string text = "";
		for (int i = 0; i < num; i++)
		{
			text = text + tagContainer.GameplayTags.Get(i).TagName.ToString() + " ";
		}
		return text;
	}

	// Token: 0x060198FA RID: 104698 RVA: 0x0069D290 File Offset: 0x0069B490
	public string GetBuffEffectDebugString(string searchStr)
	{
		string text = "";
		foreach (BuffEffect buffEffect in base.Entity.GetComponent<CharacterBuffComponent>().BuffEffectManager.GetAllEffects())
		{
			if (this.MatchBuffId(searchStr, buffEffect.BuffId.ToString()))
			{
				string str = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 3);
				defaultInterpolatedStringHandler.AppendFormatted(buffEffect.GetType().Name);
				defaultInterpolatedStringHandler.AppendLiteral(" buffId:");
				defaultInterpolatedStringHandler.AppendFormatted<long>(buffEffect.BuffId);
				defaultInterpolatedStringHandler.AppendLiteral(" handle:");
				defaultInterpolatedStringHandler.AppendFormatted<int>(buffEffect.ActiveHandleId);
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}
		return text;
	}

	// Token: 0x060198FB RID: 104699 RVA: 0x0069D370 File Offset: 0x0069B570
	public string GetShieldDebugString(string filterStr = "")
	{
		this.ShieldDebugStrings.Clear();
		string[] array = (from match in Regex.Matches(filterStr, "[0-9]+")
		select match.Value).ToArray<string>();
		CharacterShieldComponent component = base.Entity.GetComponent<CharacterShieldComponent>();
		if (component != null)
		{
			foreach (KeyValuePair<int, CharacterShield> keyValuePair in component.GetDebugShieldInfo())
			{
				int num;
				CharacterShield shield2;
				keyValuePair.Deconstruct(out num, out shield2);
				CharacterShield shield = shield2;
				if (array.Length == 0 || array.Any((string key) => shield.TemplateId.ToString().StartsWith(key)))
				{
					float shieldValue = shield.ShieldValue;
					int priority = shield.Priority;
					int templateId = shield.TemplateId;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(42, 3);
					defaultInterpolatedStringHandler.AppendLiteral("Shield magnitude: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(shieldValue);
					defaultInterpolatedStringHandler.AppendLiteral(" priority: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(priority);
					defaultInterpolatedStringHandler.AppendLiteral(" templateId: ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(templateId);
					string item = defaultInterpolatedStringHandler.ToStringAndClear();
					this.ShieldDebugStrings.Add(item);
				}
			}
		}
		BaseAttributeComponent component2 = base.Entity.GetComponent<BaseAttributeComponent>();
		string str = ((component2 != null) ? component2.GetLockDebugString(array) : null) ?? "";
		return "\n\nShields:\n" + string.Join("\n", this.ShieldDebugStrings) + str;
	}

	// Token: 0x060198FC RID: 104700 RVA: 0x0069D50C File Offset: 0x0069B70C
	public string GetAttributeDebugStrings()
	{
		BaseAttributeComponent component = base.Entity.GetComponent<BaseAttributeComponent>();
		if (component == null)
		{
			return "Invalid";
		}
		string text = "";
		for (int i = 1; i < 143; i++)
		{
			float baseValue = component.GetBaseValue((EAttributeType)i);
			float currentValue = component.GetCurrentValue((EAttributeType)i);
			EAttributeType eattributeType = (EAttributeType)i;
			string value = eattributeType.ToString();
			if (CharacterAttributeTypes.stateAttributeIds.Contains((EAttributeType)i) || currentValue == baseValue)
			{
				string str = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 3);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("\t= ");
				defaultInterpolatedStringHandler.AppendFormatted(currentValue.ToString("F0"));
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else if (currentValue > baseValue)
			{
				string str2 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 4);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("\t= ");
				defaultInterpolatedStringHandler.AppendFormatted(currentValue.ToString("F0"));
				defaultInterpolatedStringHandler.AppendLiteral("(+");
				defaultInterpolatedStringHandler.AppendFormatted((currentValue - baseValue).ToString("F0"));
				defaultInterpolatedStringHandler.AppendLiteral(")\n");
				text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				string str3 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 4);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("\t= ");
				defaultInterpolatedStringHandler.AppendFormatted(currentValue.ToString("F0"));
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted((currentValue - baseValue).ToString("F0"));
				defaultInterpolatedStringHandler.AppendLiteral(")\n");
				text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}
		return text + "\n队伍属性：\n" + CharacterGasDebugComponent.GetFormationAttributeDebugStrings();
	}

	// Token: 0x060198FD RID: 104701 RVA: 0x0069D730 File Offset: 0x0069B930
	public string GetAllAttributeDebugStrings()
	{
		this.AttributeDebugStrings.Clear();
		BaseAttributeComponent component = base.Entity.GetComponent<BaseAttributeComponent>();
		for (int i = 1; i < 143; i++)
		{
			float baseValue = component.GetBaseValue((EAttributeType)i);
			float currentValue = component.GetCurrentValue((EAttributeType)i);
			EAttributeType eattributeType = (EAttributeType)i;
			string value = eattributeType.ToString();
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(45, 4);
			defaultInterpolatedStringHandler.AppendLiteral("Attribute ID: ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i);
			defaultInterpolatedStringHandler.AppendLiteral("   ");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("  \n    Base: ");
			defaultInterpolatedStringHandler.AppendFormatted(baseValue.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral("    Current: ");
			defaultInterpolatedStringHandler.AppendFormatted(currentValue.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral(" \n");
			string item = defaultInterpolatedStringHandler.ToStringAndClear();
			this.AttributeDebugStrings.Add(item);
		}
		return string.Join("\n", this.AttributeDebugStrings);
	}

	// Token: 0x060198FE RID: 104702 RVA: 0x0069D830 File Offset: 0x0069BA30
	public static string GetFormationAttributeDebugStrings()
	{
		string text = "";
		foreach (FormationProperty formationProperty in ConfigFormationPropertyAll.GetConfigList(true))
		{
			int id = formationProperty.Id;
			EFormationAttributeId attrId = (EFormationAttributeId)id;
			float value = FormationAttributeController.Instance.GetValue(attrId);
			float max = FormationAttributeController.Instance.GetMax(attrId);
			float speed = FormationAttributeController.Instance.GetSpeed(attrId);
			string str = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 4);
			defaultInterpolatedStringHandler.AppendLiteral("#");
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			defaultInterpolatedStringHandler.AppendLiteral(" = ");
			defaultInterpolatedStringHandler.AppendFormatted(value.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(max.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(speed.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral("/s)\n");
			text = str + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text;
	}

	// Token: 0x060198FF RID: 104703 RVA: 0x0069D950 File Offset: 0x0069BB50
	public string GetAllAttributeDebugInfo()
	{
		BaseAttributeComponent component = base.Entity.GetComponent<BaseAttributeComponent>();
		if (component == null)
		{
			return "Invalid";
		}
		string text = "";
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		RepeatedField<GameplayAttributeData> repeatedField = (serverDebugInfo != null) ? serverDebugInfo.Attributes : null;
		GameplayAttributeData[] array = new GameplayAttributeData[143];
		if (repeatedField != null)
		{
			foreach (GameplayAttributeData gameplayAttributeData in repeatedField)
			{
				array[gameplayAttributeData.AttributeType] = gameplayAttributeData;
			}
		}
		for (int i = 1; i < 143; i++)
		{
			float baseValue = component.GetBaseValue((EAttributeType)i);
			float currentValue = component.GetCurrentValue((EAttributeType)i);
			string value = currentValue.ToString("F0");
			string text2 = (currentValue - baseValue).ToString("F0");
			if (currentValue >= baseValue)
			{
				text2 = "+" + text2;
			}
			text2 = ((currentValue == baseValue) ? "" : ("(" + text2 + ")"));
			EAttributeType eattributeType = (EAttributeType)i;
			string value2 = eattributeType.ToString().Replace("Proto_", "");
			GameplayAttributeData gameplayAttributeData2 = array[i];
			string value3 = ((gameplayAttributeData2 != null) ? gameplayAttributeData2.CurrentValue.ToString("F0") : null) ?? "0";
			string text3 = (gameplayAttributeData2 != null) ? (gameplayAttributeData2.CurrentValue - gameplayAttributeData2.BaseValue).ToString("F0") : "0";
			if (gameplayAttributeData2 != null && gameplayAttributeData2.CurrentValue > gameplayAttributeData2.BaseValue)
			{
				text3 = "+" + text3;
			}
			int? num = (gameplayAttributeData2 != null) ? new int?(gameplayAttributeData2.CurrentValue) : null;
			int? num2 = (gameplayAttributeData2 != null) ? new int?(gameplayAttributeData2.BaseValue) : null;
			text3 = ((num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null)) ? "" : ("(" + text3 + ")"));
			if (CharacterAttributeTypes.stateAttributeIds.Contains((EAttributeType)i) || currentValue == baseValue)
			{
				string str = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 4);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				defaultInterpolatedStringHandler.AppendLiteral("\t C:");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral(" | S:");
				defaultInterpolatedStringHandler.AppendFormatted(value3);
				defaultInterpolatedStringHandler.AppendLiteral("\n");
				text = str + defaultInterpolatedStringHandler.ToStringAndClear();
			}
			else
			{
				string str2 = text;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 6);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(i);
				defaultInterpolatedStringHandler.AppendLiteral(" ");
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				defaultInterpolatedStringHandler.AppendLiteral("\t C:");
				defaultInterpolatedStringHandler.AppendFormatted(value);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted(text2);
				defaultInterpolatedStringHandler.AppendLiteral(") | S:");
				defaultInterpolatedStringHandler.AppendFormatted(value3);
				defaultInterpolatedStringHandler.AppendLiteral("(");
				defaultInterpolatedStringHandler.AppendFormatted(text3);
				defaultInterpolatedStringHandler.AppendLiteral(")\n");
				text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}
		text += "\n队伍属性：\n";
		EntityBattleInfoResponse serverDebugInfo2 = this.ServerDebugInfo;
		RepeatedField<FormationAttr> repeatedField2 = (serverDebugInfo2 != null) ? serverDebugInfo2.FormationAttrs : null;
		Dictionary<int, FormationAttr> dictionary = new Dictionary<int, FormationAttr>();
		if (repeatedField2 != null)
		{
			foreach (FormationAttr formationAttr in repeatedField2)
			{
				dictionary[formationAttr.AttrId] = formationAttr;
			}
		}
		foreach (FormationProperty formationProperty in ConfigFormationPropertyAll.GetConfigList(true))
		{
			int id = formationProperty.Id;
			EFormationAttributeId attrId = (EFormationAttributeId)id;
			float value4 = FormationAttributeController.Instance.GetValue(attrId);
			float max = FormationAttributeController.Instance.GetMax(attrId);
			float speed = FormationAttributeController.Instance.GetSpeed(attrId);
			FormationAttr formationAttr2;
			dictionary.TryGetValue(id, out formationAttr2);
			string value5 = ((formationAttr2 != null) ? formationAttr2.CurrentValue.ToString("F0") : null) ?? "???";
			string value6 = ((formationAttr2 != null) ? formationAttr2.MaxValue.ToString("F0") : null) ?? "???";
			string value7 = ((formationAttr2 != null) ? formationAttr2.Ratio.ToString("F0") : null) ?? "???";
			string str3 = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(23, 7);
			defaultInterpolatedStringHandler.AppendLiteral("#");
			defaultInterpolatedStringHandler.AppendFormatted<int>(id);
			defaultInterpolatedStringHandler.AppendLiteral("\t C:");
			defaultInterpolatedStringHandler.AppendFormatted(value4.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(max.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(speed.ToString("F0"));
			defaultInterpolatedStringHandler.AppendLiteral("/s)");
			defaultInterpolatedStringHandler.AppendLiteral(" | S:");
			defaultInterpolatedStringHandler.AppendFormatted(value5);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted(value6);
			defaultInterpolatedStringHandler.AppendLiteral(" (");
			defaultInterpolatedStringHandler.AppendFormatted(value7);
			defaultInterpolatedStringHandler.AppendLiteral("/s)\n");
			text = str3 + defaultInterpolatedStringHandler.ToStringAndClear();
		}
		return text;
	}

	// Token: 0x06019900 RID: 104704 RVA: 0x0069DF1C File Offset: 0x0069C11C
	private void StartListenMovementHistory()
	{
		EventSystem.Instance.AddWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.MoveStateChangeHandler));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.PositionStateChangeHandler));
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CharOnSetNewBeHit, new Action<bool>(this.NewBeHitChangeHandler));
	}

	// Token: 0x06019901 RID: 104705 RVA: 0x0069DFB4 File Offset: 0x0069C1B4
	private void EndListenMovementHistory()
	{
		EventSystem.Instance.RemoveWithTarget<int, EMovementMode, EMovementMode, byte, byte>(base.Entity, EEventName.CharMovementModeChanged, new Action<int, EMovementMode, EMovementMode, byte, byte>(this.OnCharacterMovementModeChanged));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnUnifiedMoveStateChanged, new Action<global::ECharMoveState, global::ECharMoveState>(this.MoveStateChangeHandler));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnPositionStateChanged, new Action<global::ECharPositionState, global::ECharPositionState>(this.PositionStateChangeHandler));
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CharOnSetNewBeHit, new Action<bool>(this.NewBeHitChangeHandler));
	}

	// Token: 0x06019902 RID: 104706 RVA: 0x0069E04C File Offset: 0x0069C24C
	private void OnCharacterMovementModeChanged(int charId, EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
	{
		int num = (int)prevMovementMode;
		int num2 = (int)newMovementMode;
		string text;
		if (num < 0 || num >= Enum.GetNames<EMovementModeName>().Length)
		{
			text = prevMovementMode.ToString();
		}
		else
		{
			EMovementModeName emovementModeName = (EMovementModeName)num;
			text = emovementModeName.ToString();
		}
		string text2 = text;
		string text3;
		if (num2 < 0 || num2 >= Enum.GetNames<EMovementModeName>().Length)
		{
			text3 = newMovementMode.ToString();
		}
		else
		{
			EMovementModeName emovementModeName = (EMovementModeName)num2;
			text3 = emovementModeName.ToString();
		}
		string text4 = text3;
		this.MovementDebugStrings.Insert(0, string.Concat(new string[]
		{
			text2,
			".",
			prevCustomMode.ToString(),
			" ->",
			text4,
			".",
			newCustomMode.ToString()
		}));
	}

	// Token: 0x06019903 RID: 104707 RVA: 0x0069E104 File Offset: 0x0069C304
	private void MoveStateChangeHandler(global::ECharMoveState oldState, global::ECharMoveState newState)
	{
		this.MovementDebugStrings.Insert(0, oldState.ToString() + " ->" + newState.ToString());
	}

	// Token: 0x06019904 RID: 104708 RVA: 0x0069E136 File Offset: 0x0069C336
	private void PositionStateChangeHandler(global::ECharPositionState oldState, global::ECharPositionState newState)
	{
		this.MovementDebugStrings.Insert(0, oldState.ToString() + " ->" + newState.ToString());
	}

	// Token: 0x06019905 RID: 104709 RVA: 0x0069E168 File Offset: 0x0069C368
	private void NewBeHitChangeHandler(bool beHit)
	{
		this.MovementDebugStrings.Insert(0, "Set NewBeHit:" + beHit.ToString());
	}

	// Token: 0x06019906 RID: 104710 RVA: 0x0069E187 File Offset: 0x0069C387
	public string GetAllMovementHistory()
	{
		if (this.MovementDebugStrings.Count > 50)
		{
			this.MovementDebugStrings.RemoveAt(this.MovementDebugStrings.Count - 1);
		}
		return string.Join("\n", this.MovementDebugStrings);
	}

	// Token: 0x06019907 RID: 104711 RVA: 0x0069E1C0 File Offset: 0x0069C3C0
	public void DebugResetBaseValue(int id, float val)
	{
		if (id >= 1 && id < 143)
		{
			BaseAttributeComponent component = base.Entity.GetComponent<BaseAttributeComponent>();
			if (component == null)
			{
				return;
			}
			component.SetBaseValue((EAttributeType)id, val);
		}
	}

	// Token: 0x17002345 RID: 9029
	// (get) Token: 0x06019908 RID: 104712 RVA: 0x0069E1E5 File Offset: 0x0069C3E5
	public static bool IsServerLogOff
	{
		get
		{
			return CharacterGasDebugComponent.IsServerLogOnInternal;
		}
	}

	// Token: 0x06019909 RID: 104713 RVA: 0x0069E1EC File Offset: 0x0069C3EC
	public static void ReceiveSwitchServerLogMode(bool isClientControl)
	{
		CharacterGasDebugComponent.IsServerLogOnInternal = isClientControl;
	}

	// Token: 0x0601990A RID: 104714 RVA: 0x0069E1F4 File Offset: 0x0069C3F4
	public static void RequestSwitchServerMode(bool isClientControl)
	{
		SwitchBattleModeRequest switchBattleModeRequest = SwitchBattleModeRequest.Create();
		switchBattleModeRequest.Client = isClientControl;
		switchBattleModeRequest.ClientControllerModule = BattleModule.Log;
		Net.Instance.Call(ERequestMessageId.SwitchBattleModeRequest, switchBattleModeRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			SwitchBattleModeResponse switchBattleModeResponse = (SwitchBattleModeResponse)msg;
			if (switchBattleModeResponse != null)
			{
				CharacterGasDebugComponent.ReceiveSwitchServerLogMode(switchBattleModeResponse.Client);
			}
		}, 0);
	}

	// Token: 0x0601990B RID: 104715 RVA: 0x0069E248 File Offset: 0x0069C448
	public static string SecondsSinceStartup()
	{
		return (Time.Instance.WorldTimeSeconds - CharacterGasDebugComponent.RecordStartTime - (double)CharacterGasDebugComponent.TimeStopSpanTime).ToString("F2");
	}

	// Token: 0x0601990C RID: 104716 RVA: 0x0069E279 File Offset: 0x0069C479
	public static void SetDistanceMax(float max)
	{
	}

	// Token: 0x0601990D RID: 104717 RVA: 0x0069E27C File Offset: 0x0069C47C
	public static void BeginRecord()
	{
		CharacterGasDebugComponent.TimeStopSpanTime = 0f;
		CharacterGasDebugComponent.ShouldRecord = true;
		CharacterGasDebugComponent.RecordStartTime = Time.Instance.WorldTimeSeconds;
		CharacterGasDebugComponent.RecordStartTimeStamp = Time.Instance.ServerTimeStamp;
		CharacterGasDebugComponent.SetDamageRecord(true);
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.OnChangeRole;
		Action<EntityHandle, EntityHandle> handle;
		if ((handle = CharacterGasDebugComponent.<>O.<0>__OnChangeRole) == null)
		{
			handle = (CharacterGasDebugComponent.<>O.<0>__OnChangeRole = new Action<EntityHandle, EntityHandle>(CharacterGasDebugComponent.OnChangeRole));
		}
		instance.Add<EntityHandle, EntityHandle>(name, handle);
		CharacterGasDebugComponent.DamageRecordDspMap = null;
		CharacterGasDebugComponent.OnChangeRoleInternal(Global.BaseCharacter.EntityId, true, false);
		EventSystem instance2 = EventSystem.Instance;
		EEventName name2 = EEventName.OnAbsoluteTimeStop;
		Action<bool, float> handle2;
		if ((handle2 = CharacterGasDebugComponent.<>O.<1>__OnAbsoluteTimeStop) == null)
		{
			handle2 = (CharacterGasDebugComponent.<>O.<1>__OnAbsoluteTimeStop = new Action<bool, float>(CharacterGasDebugComponent.OnAbsoluteTimeStop));
		}
		instance2.Add<bool, float>(name2, handle2);
	}

	// Token: 0x0601990E RID: 104718 RVA: 0x0069E32C File Offset: 0x0069C52C
	public static string EndRecord()
	{
		if (CharacterGasDebugComponent.ShouldRecord)
		{
			CharacterGasDebugComponent.ShouldRecord = false;
			CharacterGasDebugComponent.SetDamageRecord(false);
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnChangeRole;
			Action<EntityHandle, EntityHandle> handle;
			if ((handle = CharacterGasDebugComponent.<>O.<0>__OnChangeRole) == null)
			{
				handle = (CharacterGasDebugComponent.<>O.<0>__OnChangeRole = new Action<EntityHandle, EntityHandle>(CharacterGasDebugComponent.OnChangeRole));
			}
			instance.Remove(name, handle);
			EventSystem instance2 = EventSystem.Instance;
			EEventName name2 = EEventName.OnAbsoluteTimeStop;
			Action<bool, float> handle2;
			if ((handle2 = CharacterGasDebugComponent.<>O.<1>__OnAbsoluteTimeStop) == null)
			{
				handle2 = (CharacterGasDebugComponent.<>O.<1>__OnAbsoluteTimeStop = new Action<bool, float>(CharacterGasDebugComponent.OnAbsoluteTimeStop));
			}
			instance2.Remove(name2, handle2);
			string result = CharacterGasDebugComponent.Output();
			CharacterGasDebugComponent.CleanupRecord();
			return result;
		}
		return "";
	}

	// Token: 0x17002346 RID: 9030
	// (get) Token: 0x0601990F RID: 104719 RVA: 0x0069E3B2 File Offset: 0x0069C5B2
	private static List<string> MoveRecordStrings
	{
		get
		{
			return CharacterGasDebugComponent._moveRecordStrings;
		}
	}

	// Token: 0x17002347 RID: 9031
	// (get) Token: 0x06019910 RID: 104720 RVA: 0x0069E3B9 File Offset: 0x0069C5B9
	private static List<string> DamageRecordStrings
	{
		get
		{
			return CharacterGasDebugComponent._damageRecordStrings;
		}
	}

	// Token: 0x17002348 RID: 9032
	// (get) Token: 0x06019911 RID: 104721 RVA: 0x0069E3C0 File Offset: 0x0069C5C0
	private static Dictionary<int, RecordMoveSum> MoveSumTable
	{
		get
		{
			return CharacterGasDebugComponent._moveSumTable;
		}
	}

	// Token: 0x17002349 RID: 9033
	// (get) Token: 0x06019912 RID: 104722 RVA: 0x0069E3C7 File Offset: 0x0069C5C7
	private static Dictionary<string, RecordDamageSum> RoleDamageSumTable
	{
		get
		{
			return CharacterGasDebugComponent._roleDamageSumTable;
		}
	}

	// Token: 0x1700234A RID: 9034
	// (get) Token: 0x06019913 RID: 104723 RVA: 0x0069E3CE File Offset: 0x0069C5CE
	private static Dictionary<string, RecordDamageSum> MonsterDamageSumTable
	{
		get
		{
			return CharacterGasDebugComponent._monsterDamageSumTable;
		}
	}

	// Token: 0x1700234B RID: 9035
	// (get) Token: 0x06019914 RID: 104724 RVA: 0x0069E3D5 File Offset: 0x0069C5D5
	private static Dictionary<int, string[]> BulletCreateMap
	{
		get
		{
			return CharacterGasDebugComponent._bulletCreateMap;
		}
	}

	// Token: 0x1700234C RID: 9036
	// (get) Token: 0x06019915 RID: 104725 RVA: 0x0069E3DC File Offset: 0x0069C5DC
	private static List<int> BulletCreateEntityId
	{
		get
		{
			return CharacterGasDebugComponent._bulletCreateEntityId;
		}
	}

	// Token: 0x06019916 RID: 104726 RVA: 0x0069E3E4 File Offset: 0x0069C5E4
	private static string Output()
	{
		List<string> list = new List<string>();
		string text = "";
		string str = "X秒,当前时间,对象,对象ID,对象名称,技能ID,技能类型,攻击,暴击,爆伤,生命,防御,伤害加成\n";
		UKuroStaticLibrary.SaveStringToFile(str + string.Join("\n", CharacterGasDebugComponent.MoveRecordStrings), UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/SkillRecord.csv", true);
		List<string> list2 = new List<string>();
		str = "X秒,当前时间,对象,对象ID,对象名称,子弹ID,子弹名称,伤害ID,技能ID,技能类型,子弹是否命中\n";
		foreach (int num in CharacterGasDebugComponent.BulletCreateEntityId)
		{
			string[] array = CharacterGasDebugComponent.BulletCreateMap[num];
			string[] array2 = new string[array.Length + 1];
			Array.Copy(array, array2, array.Length);
			array2[array.Length] = (BulletModel.Instance.IsBulletHit(num) ? "1" : "0");
			list2.Add(string.Join(",", array2));
		}
		UKuroStaticLibrary.SaveStringToFile(str + string.Join("\n", list2), UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/BulletRecord.csv", true);
		str = "X秒,当前时间,对象,对象ID,对象名称,伤害来源,结算ID,子弹名称,伤害值,技能ID,技能名称,唯一ID,Config ID,攻击,暴击,爆伤,生命,防御,伤害加成\n";
		UKuroStaticLibrary.SaveStringToFile(str + string.Join("\n", CharacterGasDebugComponent.DamageRecordStrings), UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/DamageRecord.csv", true);
		str = "X秒,当前时间,对象,对象ID,对象名称,伤害来源,结算ID,子弹名称,伤害值,期望伤害,技能ID,技能名称,是否暴击,唯一ID,协奏能量,基础攻击,倍率系数,当前生效增伤,伤害总深,伤害加深,受击者集协buff层数,集协乘区伤害提升,防御承伤系数,抗性承伤系数,实际生效防御值,共鸣能量变动,实时暴击率,是否弱点伤害类型,弱点伤害增幅系数,怪物类型系数,受击方通用伤害减免,受击方属性伤害减免,偏谐值,实时当前生命值,实时生命值上限,实时攻击,暴击,实时暴击伤害,实时防御,实时共鸣效率,实时共鸣能量上限,实时共鸣能量,实时普攻速度,实时重击速度,实时共鸣技能伤害加成,实时通用伤害加成,实时声骸技能伤害加成,实时普攻伤害加成,实时蓄力攻击伤害加成,实时共鸣解放伤害加成,实时连携技能伤害加成,实时物理伤害加成,实时冷凝伤害加成,实时热熔伤害加成,实时导电伤害加成,实时气动伤害加成,实时衍射伤害加成,实时解离伤害加成,实时无视物理伤害抗性,实时无视属性1伤害抗性,实时无视属性2伤害抗性,实时无视属性3伤害抗性,实时无视属性4伤害抗性,实时无视属性5伤害抗性,实时无视属性6伤害抗性,实时物理伤害抗性,实时冷凝伤害抗性,实时热熔伤害抗性,实时导电伤害抗性,实时气动伤害抗性,实时衍射伤害抗性,实时解离伤害抗性,实时治疗效果加成,实时受治疗效果加成,实时通用受伤减免,实时物理伤害减免,实时冷凝伤害减免,实时热熔伤害减免,实时导电伤害减免,实时气动伤害减免,实时衍射伤害减免,实时解离伤害减免,实时韧性上限,实时韧性,实时韧性恢复速度,实时削韧倍率,实时被削韧倍率,实时狂暴上限,实时狂暴,实时狂暴恢复,实时空狂暴惩罚时间,实时破狂暴倍率,实时被破狂暴倍率,实时共振度上限,实时共振度上限,实时共振度恢复速度,实时空共振度惩罚时间,实时破共振度倍率,实时被破共振度倍率,实时弱点击破速率,实时弱点增幅,当前生命值,生命值上限,攻击,暴击,暴击伤害,防御,共鸣效率,共鸣能量上限,共鸣能量,普攻速度,重击速度,共鸣技能伤害加成,通用伤害加成,声骸技能伤害加成,普攻伤害加成,蓄力攻击伤害加成,共鸣解放伤害加成,连携技能伤害加成,物理伤害加成,冷凝伤害加成,热熔伤害加成,导电伤害加成,气动伤害加成,衍射伤害加成,解离伤害加成,无视物理伤害抗性,无视属性1伤害抗性,无视属性2伤害抗性,无视属性3伤害抗性,无视属性4伤害抗性,无视属性5伤害抗性,无视属性6伤害抗性,物理伤害抗性,冷凝伤害抗性,热熔伤害抗性,导电伤害抗性,气动伤害抗性,衍射伤害抗性,解离伤害抗性,治疗效果加成,受治疗效果加成,通用受伤减免,物理伤害减免,冷凝伤害减免,热熔伤害减免,导电伤害减免,气动伤害减免,衍射伤害减免,解离伤害减免,韧性上限,韧性,韧性恢复速度,削韧倍率,被削韧倍率,狂暴上限,狂暴,狂暴恢复,空狂暴惩罚时间,破狂暴倍率,被破狂暴倍率,共振度上限,共振度上限,共振度恢复速度,空共振度惩罚时间,破共振度倍率,被破共振度倍率,弱点击破速率,弱点增幅,被击者实时当前生命值,被击者实时生命值上限,被击者实时攻击,被击者实时暴击,被击者实时暴击伤害,被击者实时防御,被击者实时共鸣效率,被击者实时共鸣能量上限,被击者实时共鸣能量,被击者实时普攻速度,被击者实时重击速度,被击者实时共鸣技能伤害加成,被击者实时通用伤害加成,被击者实时声骸技能伤害加成,被击者实时普攻伤害加成,被击者实时蓄力攻击伤害加成,被击者实时共鸣解放伤害加成,被击者实时连携技能伤害加成,被击者实时物理伤害加成,被击者实时冷凝伤害加成,被击者实时热熔伤害加成,被击者实时导电伤害加成,被击者实时气动伤害加成,被击者实时衍射伤害加成,被击者实时解离伤害加成,被击者实时无视物理伤害抗性,被击者实时无视属性1伤害抗性,被击者实时无视属性2伤害抗性,被击者实时无视属性3伤害抗性,被击者实时无视属性4伤害抗性,被击者实时无视属性5伤害抗性,被击者实时无视属性6伤害抗性,被击者实时物理伤害抗性,被击者实时冷凝伤害抗性,被击者实时热熔伤害抗性,被击者实时导电伤害抗性,被击者实时气动伤害抗性,被击者实时衍射伤害抗性,被击者实时解离伤害抗性,被击者实时治疗效果加成,被击者实时受治疗效果加成,被击者实时通用受伤减免,被击者实时物理伤害减免,被击者实时冷凝伤害减免,被击者实时热熔伤害减免,被击者实时导电伤害减免,被击者实时气动伤害减免,被击者实时衍射伤害减免,被击者实时解离伤害减免,被击者实时韧性上限,被击者实时韧性,被击者实时韧性恢复速度,被击者实时削韧倍率,被击者实时被削韧倍率,被击者实时狂暴上限,被击者实时狂暴,被击者实时狂暴恢复,被击者实时空狂暴惩罚时间,被击者实时破狂暴倍率,被击者实时被破狂暴倍率,被击者实时共振度上限,被击者实时共振度上限,被击者实时共振度恢复速度,被击者实时空共振度惩罚时间,被击者实时破共振度倍率,被击者实时被破共振度倍率,被击者实时弱点击破速率,被击者实时弱点增幅,被击者当前生命值,被击者生命值上限,被击者攻击,被击者暴击,被击者暴击伤害,被击者防御,被击者共鸣效率,被击者共鸣能量上限,被击者共鸣能量,被击者普攻速度,被击者重击速度,被击者共鸣技能伤害加成,被击者通用伤害加成,被击者声骸技能伤害加成,被击者普攻伤害加成,被击者蓄力攻击伤害加成,被击者共鸣解放伤害加成,被击者连携技能伤害加成,被击者物理伤害加成,被击者冷凝伤害加成,被击者热熔伤害加成,被击者导电伤害加成,被击者气动伤害加成,被击者衍射伤害加成,被击者解离伤害加成,被击者无视物理伤害抗性,被击者无视属性1伤害抗性,被击者无视属性2伤害抗性,被击者无视属性3伤害抗性,被击者无视属性4伤害抗性,被击者无视属性5伤害抗性,被击者无视属性6伤害抗性,被击者物理伤害抗性,被击者冷凝伤害抗性,被击者热熔伤害抗性,被击者导电伤害抗性,被击者气动伤害抗性,被击者衍射伤害抗性,被击者解离伤害抗性,被击者治疗效果加成,被击者受治疗效果加成,被击者通用受伤减免,被击者物理伤害减免,被击者冷凝伤害减免,被击者热熔伤害减免,被击者导电伤害减免,被击者气动伤害减免,被击者衍射伤害减免,被击者解离伤害减免,被击者韧性上限,被击者韧性,被击者韧性恢复速度,被击者削韧倍率,被击者被削韧倍率,被击者狂暴上限,被击者狂暴,被击者狂暴恢复,被击者空狂暴惩罚时间,被击者破狂暴倍率,被击者被破狂暴倍率,被击者共振度上限,被击者共振度上限,被击者共振度恢复速度,被击者空共振度惩罚时间,被击者破共振度倍率,被击者被破共振度倍率,被击者弱点击破速率,被击者弱点增幅,结算表HardnessLv,结算表Percent0,结算表Percent1,结算表ToughLv,结算表Energy,结算表ElementPowerType,结算表ElementPower,攻击者BuffID,攻击者Buff名称,受击者存在的BuffID,受击者存在的Buff名称\n";
		UKuroStaticLibrary.SaveStringToFile(str + string.Join("\n", CharacterGasDebugComponent.DamageRecordAttrArray), UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/DamageRecord_Attr.csv", true);
		str = "X秒,当前时间,对象,对象ID,对象名称,伤害来源,结算ID,子弹名称,伤害值,技能ID,技能名称,唯一ID,是否暴击,当前生命值,生命值上限,攻击,暴击,暴击伤害,防御,共鸣效率,共鸣能量上限,共鸣能量,普攻速度,重击速度,共鸣技能伤害加成,通用伤害加成,声骸技能伤害加成,普攻伤害加成,蓄力攻击伤害加成,共鸣解放伤害加成,连携技能伤害加成,物理伤害加成,冷凝伤害加成,热熔伤害加成,导电伤害加成,气动伤害加成,衍射伤害加成,解离伤害加成,无视物理伤害抗性,无视属性1伤害抗性,无视属性2伤害抗性,无视属性3伤害抗性,无视属性4伤害抗性,无视属性5伤害抗性,无视属性6伤害抗性,物理伤害抗性,冷凝伤害抗性,热熔伤害抗性,导电伤害抗性,气动伤害抗性,衍射伤害抗性,解离伤害抗性,治疗效果加成,受治疗效果加成,通用受伤减免,物理伤害减免,冷凝伤害减免,热熔伤害减免,导电伤害减免,气动伤害减免,衍射伤害减免,解离伤害减免,韧性上限,韧性,韧性恢复速度,削韧倍率,被削韧倍率,狂暴上限,狂暴,狂暴恢复,空狂暴惩罚时间,破狂暴倍率,被破狂暴倍率,共振度上限,共振度上限,共振度恢复速度,空共振度惩罚时间,破共振度倍率,被破共振度倍率,弱点击破速率,弱点增幅,当前生命值,生命值上限,攻击,暴击,暴击伤害,防御,共鸣效率,共鸣能量上限,共鸣能量,普攻速度,重击速度,共鸣技能伤害加成,通用伤害加成,声骸技能伤害加成,普攻伤害加成,蓄力攻击伤害加成,共鸣解放伤害加成,连携技能伤害加成,物理伤害加成,冷凝伤害加成,热熔伤害加成,导电伤害加成,气动伤害加成,衍射伤害加成,解离伤害加成,无视物理伤害抗性,无视属性1伤害抗性,无视属性2伤害抗性,无视属性3伤害抗性,无视属性4伤害抗性,无视属性5伤害抗性,无视属性6伤害抗性,物理伤害抗性,冷凝伤害抗性,热熔伤害抗性,导电伤害抗性,气动伤害抗性,衍射伤害抗性,解离伤害抗性,治疗效果加成,受治疗效果加成,通用受伤减免,物理伤害减免,冷凝伤害减免,热熔伤害减免,导电伤害减免,气动伤害减免,衍射伤害减免,解离伤害减免,韧性上限,韧性,韧性恢复速度,削韧倍率,被削韧倍率,狂暴上限,狂暴,狂暴恢复,空狂暴惩罚时间,破狂暴倍率,被破狂暴倍率,共振度上限,共振度上限,共振度恢复速度,空共振度惩罚时间,破共振度倍率,被破共振度倍率,弱点击破速率,弱点增幅,削刃,大招能量,元素能量类型,元素能量,存在的BuffID,存在的Buff名称,存在的BuffID,存在的Buff名称\n";
		UKuroStaticLibrary.SaveStringToFile(str + string.Join("\n", CharacterGasDebugComponent.DamageRecordSnipeshotArray), UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/DamageRecord_Snipeshot.csv", true);
		str = "X秒,当前时间,对象,对象ID,对象名称,BuffId,Buff名称,添加or删除\n";
		string text2 = str + string.Join("\n", CharacterGasDebugComponent.BuffRecordArray);
		UKuroStaticLibrary.SaveStringToFile(text2, UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/BuffRecord.csv", true);
		foreach (RecordMoveSum recordMoveSum in CharacterGasDebugComponent.MoveSumTable.Values)
		{
			list.Add(string.Join(",", recordMoveSum.ToCsv()));
		}
		str = "对象ID,对象名称,唯一Id,普攻,蓄力,E技能,大招,QTE,极限闪避反击,地面闪避,极限闪避,被动技能,战斗幻想技,探索幻象技,空中闪避\n";
		text2 = str + string.Join("\n", list);
		UKuroStaticLibrary.SaveStringToFile(text2, UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/MoveSum.csv", true);
		list.Clear();
		text = text + text2 + "\n";
		str = "角色ID,角色名称,受伤来源ConfigId,受伤来源名称,受伤来源唯一ID,总伤害,普攻,蓄力,E技能,大招,QTE,极限闪避反击,地面闪避,极限闪避,被动技能,战斗幻想技,探索幻象技,空中闪避\n";
		foreach (RecordDamageSum recordDamageSum in CharacterGasDebugComponent.RoleDamageSumTable.Values)
		{
			list.Add(string.Join(",", recordDamageSum.ToCsvForRole()));
		}
		text2 = str + string.Join("\n", list);
		UKuroStaticLibrary.SaveStringToFile(text2, UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/RoleDamageSum.csv", true);
		list.Clear();
		text = text + text2 + "\n";
		str = "怪物ConfigID,怪物名称,怪物唯一Id,攻击者ConfigId,攻击者名称,总伤害,普攻,蓄力,E技能,大招,QTE,极限闪避反击,地面闪避,极限闪避,被动技能,战斗幻想技,探索幻象技,空中闪避\n";
		foreach (RecordDamageSum recordDamageSum2 in CharacterGasDebugComponent.MonsterDamageSumTable.Values)
		{
			list.Add(string.Join(",", recordDamageSum2.ToCsvForMonster()));
		}
		text2 = str + string.Join("\n", list);
		UKuroStaticLibrary.SaveStringToFile(text2, UBlueprintPathsLibrary.ProjectSavedDir() + "Statistics/FightDataRecord/MonsterDamageSum.csv", true);
		list.Clear();
		text = text + text2 + "\n";
		CharacterGasDebugComponent.SaveRoleDsp();
		return text;
	}

	// Token: 0x06019917 RID: 104727 RVA: 0x0069E79C File Offset: 0x0069C99C
	private static void SaveRoleDsp()
	{
		bool isPlayInEditor = Info.Instance.IsPlayInEditor;
	}

	// Token: 0x06019918 RID: 104728 RVA: 0x0069E7A9 File Offset: 0x0069C9A9
	private bool CheckDistance(Entity entity)
	{
		return CharacterStatisticsComponent.IsInRecordArea(entity);
	}

	// Token: 0x06019919 RID: 104729 RVA: 0x0069E7B4 File Offset: 0x0069C9B4
	private static string SkillGenreNames(IReadOnlyList<ESkillGenre> skillGenres)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < skillGenres.Count; i++)
		{
			int num = (int)skillGenres[i];
			List<string> list2 = list;
			string item;
			if (num < 0 || num >= Enum.GetNames<ESkillGenreName>().Length)
			{
				item = "";
			}
			else
			{
				ESkillGenreName eskillGenreName = (ESkillGenreName)num;
				item = eskillGenreName.ToString();
			}
			list2.Add(item);
		}
		return string.Join("|", list);
	}

	// Token: 0x0601991A RID: 104730 RVA: 0x0069E815 File Offset: 0x0069CA15
	private static string DamageIdToDesc(long damageId)
	{
		if (CharacterGasDebugComponent.DamageIdToString.ContainsKey(damageId))
		{
			return CharacterGasDebugComponent.DamageIdToString[damageId];
		}
		return damageId.ToString();
	}

	// Token: 0x0601991B RID: 104731 RVA: 0x0069E838 File Offset: 0x0069CA38
	public static void RecordDamage(Entity attackerEntity, DamageRecordNotify data, string secondSinceStartup, string currTimeString)
	{
		List<string> list = new List<string>();
		list.Add(secondSinceStartup);
		list.Add(currTimeString);
		CharacterGasDebugComponent.EntityInfo entityInfo = CharacterGasDebugComponent.GetEntityInfo(attackerEntity);
		if (entityInfo == null)
		{
			return;
		}
		list.Add(entityInfo.Type);
		list.Add(entityInfo.ConfigId);
		list.Add(entityInfo.Name);
		if (attackerEntity.GetComponent<RoleGrowComponent>() != null)
		{
			list.Add("角色");
		}
		else
		{
			CreatureDataComponent component = attackerEntity.GetComponent<CreatureDataComponent>();
			if (component != null && component.GetEntityType() == EEntityType.SceneEntity)
			{
				list.Add("场景伤害");
			}
			else
			{
				list.Add("怪物");
			}
		}
		list.Add(CharacterGasDebugComponent.DamageIdToDesc(data.DamageConfId));
		BulletDataMain bulletData = BulletConfig.Instance.GetBulletData(attackerEntity, data.BulletId.ToString(), false);
		Entity entity = null;
		if (bulletData == null)
		{
			int customEntityId = WorldController.Instance.GetCustomEntityId(attackerEntity.Id, 1);
			entity = EntitySystem.Instance.Get(customEntityId);
			if (entity != null && entity.Valid)
			{
				bulletData = BulletConfig.Instance.GetBulletData(entity, data.BulletId.ToString(), true);
			}
		}
		int skillId = (int)data.SkillId;
		list.Add(((bulletData != null) ? bulletData.BulletName : null) ?? "");
		list.Add(data.DamageValue.ToString("F0"));
		list.Add(skillId.ToString("F0"));
		BaseSkillComponent baseSkillComponent = attackerEntity.GetComponent<BaseSkillComponent>();
		SSkillInfo sskillInfo = (baseSkillComponent != null) ? baseSkillComponent.GetSkillInfo(skillId) : null;
		if (sskillInfo == null)
		{
			baseSkillComponent = ((entity != null) ? entity.GetComponent<BaseSkillComponent>() : null);
			sskillInfo = ((baseSkillComponent != null) ? baseSkillComponent.GetSkillInfo(skillId) : null);
		}
		list.Add(((sskillInfo != null) ? sskillInfo.SkillName.ToString() : null) ?? "");
		list.Add(data.Attacker.EntityId.ToString());
		string item = attackerEntity.GetComponent<CreatureDataComponent>().GetPbDataId().ToString();
		list.Add(item);
		int count = list.Count;
		foreach (GameplayAttributeData gameplayAttributeData in data.Victim.Attr)
		{
			if (gameplayAttributeData.AttributeType == 7)
			{
				while (list.Count <= count)
				{
					list.Add("");
				}
				list[count] = gameplayAttributeData.CurrentValue.ToString("F0");
			}
			else if (gameplayAttributeData.AttributeType == 8)
			{
				while (list.Count <= count + 1)
				{
					list.Add("");
				}
				list[count + 1] = gameplayAttributeData.CurrentValue.ToString("F0");
			}
			else if (gameplayAttributeData.AttributeType == 9)
			{
				while (list.Count <= count + 2)
				{
					list.Add("");
				}
				list[count + 2] = gameplayAttributeData.CurrentValue.ToString("F0");
			}
			else if (gameplayAttributeData.AttributeType == 3)
			{
				while (list.Count <= count + 3)
				{
					list.Add("");
				}
				list[count + 3] = gameplayAttributeData.CurrentValue.ToString("F0");
			}
			else if (gameplayAttributeData.AttributeType == 10)
			{
				while (list.Count <= count + 4)
				{
					list.Add("");
				}
				list[count + 4] = gameplayAttributeData.CurrentValue.ToString("F0");
			}
			else if (gameplayAttributeData.AttributeType == 15)
			{
				while (list.Count <= count + 5)
				{
					list.Add("");
				}
				list[count + 5] = gameplayAttributeData.CurrentValue.ToString("F0");
			}
		}
		CharacterGasDebugComponent.DamageRecordStrings.Add(string.Join(",", list));
		int entityId = CreatureModel.Instance.GetEntityId(MathUtils.Instance.LongToNumber(data.Victim.EntityId));
		CharacterGasDebugComponent.RecordDamageSumTable(EntitySystem.Instance.Get(entityId), attackerEntity, (float)data.DamageValue, ((baseSkillComponent != null) ? baseSkillComponent.GetSkillGenres(skillId) : null) ?? Array.Empty<ESkillGenre>());
	}

	// Token: 0x0601991C RID: 104732 RVA: 0x0069ECA8 File Offset: 0x0069CEA8
	private void OnBulletCreate(BulletInfo bulletInfo)
	{
		if (!CharacterGasDebugComponent.ShouldRecord)
		{
			return;
		}
		Entity attacker = bulletInfo.Attacker;
		if (!this.CheckDistance(attacker))
		{
			return;
		}
		List<string> list = new List<string>();
		list.Add(CharacterGasDebugComponent.SecondsSinceStartup());
		list.Add(CharacterGasDebugComponent.TimeStringFromStamp(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()));
		CreatureDataComponent component = attacker.GetComponent<CreatureDataComponent>();
		EEntityType entityType = component.GetEntityType();
		if (entityType == EEntityType.Player)
		{
			list.Add("角色");
			list.Add(component.GetPbDataId().ToString("F0"));
			int id = component.Valid ? component.GetRoleId() : 0;
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
			if (baseRoleId == 0)
			{
				return;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
			string item = (roleConfig != null) ? RoleConfig.Instance.GetRoleName(roleConfig.Value.Name) : "";
			list.Add(item);
		}
		else if (entityType == EEntityType.Monster)
		{
			list.Add("怪物");
			list.Add(component.GetPbDataId().ToString("F0"));
			string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
			list.Add(configTextByKey);
		}
		else
		{
			if (entityType != EEntityType.Vehicle)
			{
				return;
			}
			if (!CharacterGasDebugComponent.IsMoto(attacker))
			{
				return;
			}
			string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
			list.Add("摩托车");
			list.Add(component.GetPbDataId().ToString("F0"));
			list.Add(configTextByKey2);
		}
		list.Add(bulletInfo.BulletRowName);
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		list.Add(((bulletDataMain != null) ? bulletDataMain.BulletName : null) ?? "0");
		list.Add(bulletInfo.CollisionInfo.DamageId.ToString());
		int skillId = bulletInfo.BulletInitParams.SkillId;
		list.Add((skillId != 0) ? skillId.ToString() : "");
		BaseSkillComponent component2 = attacker.GetComponent<BaseSkillComponent>();
		List<string> list2 = list;
		IReadOnlyList<ESkillGenre> skillGenres;
		if (skillId == 0)
		{
			IReadOnlyList<ESkillGenre> readOnlyList = Array.Empty<ESkillGenre>();
			skillGenres = readOnlyList;
		}
		else
		{
			skillGenres = component2.GetSkillGenres(skillId);
		}
		list2.Add(CharacterGasDebugComponent.SkillGenreNames(skillGenres));
		int id2 = bulletInfo.Entity.Id;
		CharacterGasDebugComponent.BulletCreateMap[id2] = list.ToArray();
		CharacterGasDebugComponent.BulletCreateEntityId.Add(id2);
	}

	// Token: 0x0601991D RID: 104733 RVA: 0x0069EF08 File Offset: 0x0069D108
	private static void RecordDamageSumTable([Nullable(2)] Entity target, Entity source, float damageMagnitude, IReadOnlyList<ESkillGenre> skillGenres)
	{
		Dictionary<string, RecordDamageSum> dictionary = CharacterGasDebugComponent.RoleDamageSumTable;
		if (((target != null) ? target.GetComponent<RoleGrowComponent>() : null) == null)
		{
			dictionary = CharacterGasDebugComponent.MonsterDamageSumTable;
		}
		string key = target.Id.ToString() + source.Id.ToString();
		RecordDamageSum recordDamageSum = dictionary.ContainsKey(key) ? dictionary[key] : null;
		if (recordDamageSum != null)
		{
			recordDamageSum.TotalDamage += (int)damageMagnitude;
			for (int i = 0; i < skillGenres.Count; i++)
			{
				ESkillGenre key2 = skillGenres[i];
				int num = recordDamageSum.RecordDamage.ContainsKey(key2) ? recordDamageSum.RecordDamage[key2] : 0;
				recordDamageSum.RecordDamage[key2] = num + (int)damageMagnitude;
			}
			return;
		}
		RecordDamageSum recordDamageSum2 = new RecordDamageSum();
		int? num2;
		if (target == null)
		{
			num2 = null;
		}
		else
		{
			CreatureDataComponent component = target.GetComponent<CreatureDataComponent>();
			num2 = ((component != null) ? new int?(component.GetPbDataId()) : null);
		}
		int? num3 = num2;
		recordDamageSum2.ConfigId = num3.GetValueOrDefault();
		recordDamageSum2.UniqueId = target.Id;
		RecordDamageSum recordDamageSum3 = recordDamageSum2;
		string text;
		if (target == null)
		{
			text = null;
		}
		else
		{
			BaseActorComponent component2 = target.GetComponent<BaseActorComponent>();
			if (component2 == null)
			{
				text = null;
			}
			else
			{
				AActor owner = component2.Owner;
				text = ((owner != null) ? owner.GetName() : null);
			}
		}
		recordDamageSum3.Name = (text ?? "");
		CreatureDataComponent component3 = source.GetComponent<CreatureDataComponent>();
		recordDamageSum2.DamageSourceConfigId = ((component3 != null) ? new int?(component3.GetPbDataId()) : null).GetValueOrDefault();
		RecordDamageSum recordDamageSum4 = recordDamageSum2;
		BaseActorComponent component4 = source.GetComponent<BaseActorComponent>();
		string text2;
		if (component4 == null)
		{
			text2 = null;
		}
		else
		{
			AActor owner2 = component4.Owner;
			text2 = ((owner2 != null) ? owner2.GetName() : null);
		}
		recordDamageSum4.SourceName = (text2 ?? "");
		recordDamageSum2.SourceUniqueId = source.Id;
		recordDamageSum2.TotalDamage = (int)damageMagnitude;
		for (int j = 0; j < skillGenres.Count; j++)
		{
			ESkillGenre key3 = skillGenres[j];
			int num4 = recordDamageSum2.RecordDamage.ContainsKey(key3) ? recordDamageSum2.RecordDamage[key3] : 0;
			recordDamageSum2.RecordDamage[key3] = num4 + (int)damageMagnitude;
		}
		dictionary[key] = recordDamageSum2;
	}

	// Token: 0x0601991E RID: 104734 RVA: 0x0069F118 File Offset: 0x0069D318
	public void RecordMove([Nullable(2)] EntityHandle handle, int skillId, IReadOnlyList<ESkillGenre> skillGenres)
	{
		if (!CharacterGasDebugComponent.ShouldRecord)
		{
			return;
		}
		if (handle == null || !handle.Valid || !this.CheckDistance(base.Entity))
		{
			return;
		}
		Entity entity = base.Entity;
		List<string> list = new List<string>();
		list.Add(CharacterGasDebugComponent.SecondsSinceStartup());
		list.Add(CharacterGasDebugComponent.TimeStringFromStamp(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()));
		if (((entity != null) ? entity.GetComponent<RoleGrowComponent>() : null) != null)
		{
			list.Add("角色");
		}
		else
		{
			list.Add("怪物");
		}
		int? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new int?(component.GetPbDataId()) : null);
		}
		int? num2 = num;
		list.Add(num2.GetValueOrDefault().ToString("F0"));
		string text;
		if (entity == null)
		{
			text = null;
		}
		else
		{
			CharacterActorComponent component2 = entity.GetComponent<CharacterActorComponent>();
			text = ((component2 != null) ? component2.Actor.GetName() : null);
		}
		string item = text ?? "";
		list.Add(item);
		list.Add(skillId.ToString());
		list.Add(CharacterGasDebugComponent.SkillGenreNames(skillGenres));
		BaseAttributeComponent component3 = entity.GetComponent<BaseAttributeComponent>();
		list.Add(component3.GetCurrentValue(EAttributeType.Atk).ToString("F0"));
		list.Add(component3.GetCurrentValue(EAttributeType.Crit).ToString("F0"));
		list.Add(component3.GetCurrentValue(EAttributeType.CritDamage).ToString("F0"));
		list.Add(component3.GetCurrentValue(EAttributeType.Life).ToString("F0"));
		list.Add(component3.GetCurrentValue(EAttributeType.Def).ToString("F0"));
		list.Add(component3.GetCurrentValue(EAttributeType.DamageChange).ToString("F0"));
		CharacterGasDebugComponent.MoveRecordStrings.Add(string.Join(",", list));
		for (int i = 0; i < skillGenres.Count; i++)
		{
			CharacterGasDebugComponent.RecordMoveSumTable(entity, handle.Entity, skillGenres[i]);
		}
	}

	// Token: 0x0601991F RID: 104735 RVA: 0x0069F328 File Offset: 0x0069D528
	[NullableContext(2)]
	private static void RecordMoveSumTable(Entity entity1, Entity entity2, ESkillGenre skillGenre)
	{
		string name = ((entity1 != null) ? entity1.GetComponent<CharacterActorComponent>().Actor.GetName() : null) ?? "";
		int num = (entity1 != null) ? entity1.GetComponent<CreatureDataComponent>().GetPbDataId() : 0;
		long num2 = (long)((entity2 != null) ? entity2.Id : 0);
		RecordMoveSum recordMoveSum = CharacterGasDebugComponent.MoveSumTable.ContainsKey(num + (int)num2) ? CharacterGasDebugComponent.MoveSumTable[num + (int)num2] : null;
		if (recordMoveSum != null)
		{
			int num3;
			recordMoveSum.RecordNum[skillGenre] = (recordMoveSum.RecordNum.TryGetValue(skillGenre, out num3) ? (num3 + 1) : 1);
			return;
		}
		RecordMoveSum recordMoveSum2 = new RecordMoveSum();
		recordMoveSum2.ConfigId = num;
		recordMoveSum2.Name = name;
		recordMoveSum2.TargetUniqueId = (int)num2;
		recordMoveSum2.RecordNum[skillGenre] = 1;
		CharacterGasDebugComponent.MoveSumTable[num + (int)num2] = recordMoveSum2;
	}

	// Token: 0x06019920 RID: 104736 RVA: 0x0069F3FC File Offset: 0x0069D5FC
	private bool MatchBuffId(string searchStr, string buffId)
	{
		return string.IsNullOrEmpty(searchStr) || buffId.Contains(searchStr) || searchStr.Contains(buffId);
	}

	// Token: 0x06019921 RID: 104737 RVA: 0x0069F418 File Offset: 0x0069D618
	public string GetServerBuffString()
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		bool flag;
		if (serverDebugInfo == null)
		{
			flag = (null != null);
		}
		else
		{
			FightBuffComponentPb fightBuffComponentPb = serverDebugInfo.FightBuffComponentPb;
			flag = (((fightBuffComponentPb != null) ? fightBuffComponentPb.FightBuffInfos : null) != null);
		}
		if (!flag)
		{
			return "";
		}
		string text = "";
		foreach (FightBuffInformation fightBuffInformation in this.ServerDebugInfo.FightBuffComponentPb.FightBuffInfos)
		{
			long buffId = fightBuffInformation.BuffId;
			string instigatorId = fightBuffInformation.InstigatorId.ToString();
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(buffId, null);
			string desc = (buffDefinition != null) ? buffDefinition.Desc : "";
			text += this.GetServerBuffInfoString(buffId.ToString(), fightBuffInformation.HandleId, desc, fightBuffInformation.StackCount, fightBuffInformation.Level, fightBuffInformation.IsActive, instigatorId, fightBuffInformation.LeftDuration, fightBuffInformation.Duration);
		}
		if (this.ServerDebugInfo.FightBuffComponentPb.ListBuffEffectCd.Count > 0)
		{
			text += "\nCD : \n";
			foreach (BuffEffectCd buffEffectCd in this.ServerDebugInfo.FightBuffComponentPb.ListBuffEffectCd)
			{
				if (buffEffectCd.ListCdRemaining.Count > 0)
				{
					text = text + "[" + buffEffectCd.BuffId.ToString() + "] ";
					foreach (int num in buffEffectCd.ListCdRemaining)
					{
						text = text + num.ToString("F0") + ", ";
					}
				}
			}
		}
		return text;
	}

	// Token: 0x06019922 RID: 104738 RVA: 0x0069F604 File Offset: 0x0069D804
	public float GetServerBuffRemainDuration(int handle)
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		bool flag;
		if (serverDebugInfo == null)
		{
			flag = (null != null);
		}
		else
		{
			FightBuffComponentPb fightBuffComponentPb = serverDebugInfo.FightBuffComponentPb;
			flag = (((fightBuffComponentPb != null) ? fightBuffComponentPb.FightBuffInfos : null) != null);
		}
		if (!flag)
		{
			return -1f;
		}
		float result = -1f;
		foreach (FightBuffInformation fightBuffInformation in this.ServerDebugInfo.FightBuffComponentPb.FightBuffInfos)
		{
			if (fightBuffInformation.HandleId == handle)
			{
				result = fightBuffInformation.LeftDuration;
				break;
			}
		}
		return result;
	}

	// Token: 0x06019923 RID: 104739 RVA: 0x0069F694 File Offset: 0x0069D894
	public float GetServerBuffTotalDuration(int handle)
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		bool flag;
		if (serverDebugInfo == null)
		{
			flag = (null != null);
		}
		else
		{
			FightBuffComponentPb fightBuffComponentPb = serverDebugInfo.FightBuffComponentPb;
			flag = (((fightBuffComponentPb != null) ? fightBuffComponentPb.FightBuffInfos : null) != null);
		}
		if (!flag)
		{
			return -1f;
		}
		float result = 0f;
		foreach (FightBuffInformation fightBuffInformation in this.ServerDebugInfo.FightBuffComponentPb.FightBuffInfos)
		{
			if (fightBuffInformation.HandleId == handle)
			{
				result = fightBuffInformation.Duration;
				break;
			}
		}
		return result;
	}

	// Token: 0x06019924 RID: 104740 RVA: 0x0069F724 File Offset: 0x0069D924
	public bool HasBuffRequest(int handle)
	{
		return this.HasRequestServerBuff.Contains(handle);
	}

	// Token: 0x06019925 RID: 104741 RVA: 0x0069F734 File Offset: 0x0069D934
	public bool HasServerBuff(int handle)
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		bool flag;
		if (serverDebugInfo == null)
		{
			flag = (null != null);
		}
		else
		{
			FightBuffComponentPb fightBuffComponentPb = serverDebugInfo.FightBuffComponentPb;
			flag = (((fightBuffComponentPb != null) ? fightBuffComponentPb.FightBuffInfos : null) != null);
		}
		if (!flag)
		{
			return false;
		}
		using (IEnumerator<FightBuffInformation> enumerator = this.ServerDebugInfo.FightBuffComponentPb.FightBuffInfos.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.HandleId == handle)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06019926 RID: 104742 RVA: 0x0069F7B4 File Offset: 0x0069D9B4
	private string GetServerBuffInfoString(string id, int handle, string desc, int stackCount, int level, bool isActive, string instigatorId, float leftDuration, float duration)
	{
		return string.Concat(new string[]
		{
			"[",
			id,
			", ",
			handle.ToString(),
			"] ",
			stackCount.ToString(),
			"层,",
			level.ToString(),
			"级,",
			isActive ? "激活. " : "失效. ",
			"施:",
			instigatorId,
			". 时:",
			leftDuration.ToString("F1"),
			"/",
			duration.ToString(),
			". ",
			desc,
			"\n"
		});
	}

	// Token: 0x06019927 RID: 104743 RVA: 0x0069F880 File Offset: 0x0069DA80
	public string GetServerTagString()
	{
		string text = "";
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		if (((serverDebugInfo != null) ? serverDebugInfo.EntityBattleTagInfo : null) != null)
		{
			foreach (EntityBattleTagInfo entityBattleTagInfo in this.ServerDebugInfo.EntityBattleTagInfo)
			{
				text = string.Concat(new string[]
				{
					text,
					GameplayTagUtils.GetNameByTagId(entityBattleTagInfo.TagId),
					" ",
					entityBattleTagInfo.Count.ToString(),
					"\n"
				});
			}
		}
		EntityBattleInfoResponse serverDebugInfo2 = this.ServerDebugInfo;
		if (((serverDebugInfo2 != null) ? serverDebugInfo2.PlayerTagInfos : null) != null)
		{
			foreach (EntityBattleTagInfo entityBattleTagInfo2 in this.ServerDebugInfo.PlayerTagInfos)
			{
				text = string.Concat(new string[]
				{
					text,
					"[编] ",
					GameplayTagUtils.GetNameByTagId(entityBattleTagInfo2.TagId),
					" ",
					entityBattleTagInfo2.Count.ToString(),
					"\n"
				});
			}
		}
		return text;
	}

	// Token: 0x06019928 RID: 104744 RVA: 0x0069F9C0 File Offset: 0x0069DBC0
	public string GetServerAttributeString()
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		if (((serverDebugInfo != null) ? serverDebugInfo.Attributes : null) == null)
		{
			return "";
		}
		string text = "";
		foreach (GameplayAttributeData gameplayAttributeData in this.ServerDebugInfo.Attributes)
		{
			text = string.Concat(new string[]
			{
				text,
				gameplayAttributeData.AttributeType.ToString(),
				" ",
				((EAttributeType)gameplayAttributeData.AttributeType).ToString(),
				":[",
				gameplayAttributeData.BaseValue.ToString(),
				"][",
				gameplayAttributeData.CurrentValue.ToString(),
				"]\n"
			});
		}
		text += "\n队伍属性：\n";
		foreach (FormationAttr formationAttr in this.ServerDebugInfo.FormationAttrs)
		{
			text = string.Concat(new string[]
			{
				text,
				formationAttr.AttrId.ToString(),
				"=",
				formationAttr.CurrentValue.ToString(),
				"/",
				formationAttr.MaxValue.ToString(),
				"(",
				formationAttr.Ratio.ToString(),
				"/s)\n"
			});
		}
		return text;
	}

	// Token: 0x06019929 RID: 104745 RVA: 0x0069FB7C File Offset: 0x0069DD7C
	public string GetServerPartString()
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		bool flag;
		if (serverDebugInfo == null)
		{
			flag = (null != null);
		}
		else
		{
			PartComponentPb partComponentPb = serverDebugInfo.PartComponentPb;
			flag = (((partComponentPb != null) ? partComponentPb.PartLifeInfos : null) != null);
		}
		if (!flag)
		{
			return "";
		}
		string text = "";
		foreach (PartInformation partInformation in this.ServerDebugInfo.PartComponentPb.PartLifeInfos)
		{
			text = string.Concat(new string[]
			{
				text,
				partInformation.PartId.ToString(),
				" :  ",
				partInformation.LifeValue.ToString("F1"),
				" / ",
				partInformation.LifeMax.ToString("F1"),
				", ",
				partInformation.Activated.ToString(),
				"\n"
			});
		}
		return text;
	}

	// Token: 0x0601992A RID: 104746 RVA: 0x0069FC84 File Offset: 0x0069DE84
	public string GetServerHateString()
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		if (((serverDebugInfo != null) ? serverDebugInfo.HateList : null) == null)
		{
			return "";
		}
		string text = "";
		foreach (AiHateEntity aiHateEntity in this.ServerDebugInfo.HateList)
		{
			text = string.Concat(new string[]
			{
				text,
				aiHateEntity.EntityId.ToString(),
				" : ",
				aiHateEntity.HatredValue.ToString("F1"),
				"\n"
			});
		}
		return text;
	}

	// Token: 0x0601992B RID: 104747 RVA: 0x0069FD38 File Offset: 0x0069DF38
	public string GetServerShieldString()
	{
		EntityBattleInfoResponse serverDebugInfo = this.ServerDebugInfo;
		if (((serverDebugInfo != null) ? serverDebugInfo.ShieldComponentPb : null) == null)
		{
			return "";
		}
		string text = "护盾总值: " + this.ServerDebugInfo.ShieldComponentPb.ShieldValueTotal.ToString() + "\n";
		foreach (ShieldInfoPb shieldInfoPb in this.ServerDebugInfo.ShieldComponentPb.ShieldInfoPbList)
		{
			text = string.Concat(new string[]
			{
				text,
				"[",
				shieldInfoPb.ConfigId.ToString(),
				",",
				shieldInfoPb.Handle.ToString(),
				"] ",
				shieldInfoPb.IsValid ? "生效" : "失效",
				", ",
				shieldInfoPb.ShieldValue.ToString(),
				",",
				shieldInfoPb.BuffHandle.ToString(),
				",",
				shieldInfoPb.Priority.ToString(),
				"\n"
			});
		}
		return text;
	}

	// Token: 0x0601992C RID: 104748 RVA: 0x0069FE8C File Offset: 0x0069E08C
	public HashSet<int> GetCltBuffHandleSet()
	{
		HashSet<int> result = new HashSet<int>();
		BaseBuffComponent component = base.Entity.GetComponent<BaseBuffComponent>();
		if (component != null)
		{
			IActiveBuff[] allBuffs = component.GetAllBuffs();
			if (allBuffs != null)
			{
				allBuffs.ToList<IActiveBuff>().ForEach(delegate(IActiveBuff buff)
				{
					result.Add(buff.Handle);
				});
			}
		}
		return result;
	}

	// Token: 0x0601992D RID: 104749 RVA: 0x0069FEE4 File Offset: 0x0069E0E4
	public void Union(HashSet<int> left, HashSet<int> right)
	{
		foreach (int item in right)
		{
			if (!left.Contains(item))
			{
				left.Add(item);
			}
		}
	}

	// Token: 0x0601992E RID: 104750 RVA: 0x0069FF3C File Offset: 0x0069E13C
	public void ServerDebugInfoRequest()
	{
		this.InnerRequestHandle++;
		int key = this.InnerRequestHandle;
		HashSet<int> cltBuffHandleSet = this.GetCltBuffHandleSet();
		List<int> list = new List<int>();
		foreach (int item in this.HasRequestServerBuff)
		{
			if (!cltBuffHandleSet.Contains(item))
			{
				list.Add(item);
			}
		}
		foreach (int item2 in list)
		{
			this.HasRequestServerBuff.Remove(item2);
		}
		this.WaitResponseBuff[key] = cltBuffHandleSet;
		EntityBattleInfoRequest entityBattleInfoRequest = EntityBattleInfoRequest.Create();
		entityBattleInfoRequest.EntityId = MathUtils.Instance.NumberToLong(CreatureModel.Instance.GetCreatureDataId(base.Entity.Id));
		Net.Instance.Call(ERequestMessageId.EntityBattleInfoRequest, entityBattleInfoRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			EntityBattleInfoResponse entityBattleInfoResponse = (EntityBattleInfoResponse)msg;
			if (this.WaitResponseBuff.ContainsKey(key))
			{
				this.Union(this.HasRequestServerBuff, this.WaitResponseBuff[key]);
				this.WaitResponseBuff.Remove(key);
			}
			if (entityBattleInfoResponse == null)
			{
				return;
			}
			this.ServerDebugInfo = entityBattleInfoResponse;
			this.ServerDebugInfoDirty = true;
		}, 0);
	}

	// Token: 0x1700234D RID: 9037
	// (get) Token: 0x0601992F RID: 104751 RVA: 0x006A0070 File Offset: 0x0069E270
	private static List<string> BuffRecordArray
	{
		get
		{
			return CharacterGasDebugComponent._buffRecordArray;
		}
	}

	// Token: 0x06019930 RID: 104752 RVA: 0x006A0078 File Offset: 0x0069E278
	public void OnBuffAdded(ActiveBuffInternal buff)
	{
		if (!CharacterGasDebugComponent.ShouldRecord)
		{
			return;
		}
		string[] array = this.OnBuffRecord(buff, "添加");
		if (array != null)
		{
			CharacterGasDebugComponent.BuffRecordArray.Add(string.Join(",", array));
		}
	}

	// Token: 0x06019931 RID: 104753 RVA: 0x006A00B4 File Offset: 0x0069E2B4
	public void OnBuffRemoved(ActiveBuffInternal buff)
	{
		if (!CharacterGasDebugComponent.ShouldRecord)
		{
			return;
		}
		string[] array = this.OnBuffRecord(buff, "删除");
		if (array != null)
		{
			CharacterGasDebugComponent.BuffRecordArray.Add(string.Join(",", array));
		}
	}

	// Token: 0x06019932 RID: 104754 RVA: 0x006A00F0 File Offset: 0x0069E2F0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] OnBuffRecord(ActiveBuffInternal buff, string opt)
	{
		List<string> list = new List<string>();
		list.Add(CharacterGasDebugComponent.SecondsSinceStartup());
		list.Add(CharacterGasDebugComponent.TimeStringFromStamp(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()));
		Entity instigator = buff.GetInstigator();
		CharacterGasDebugComponent.EntityInfo entityInfo = (instigator != null) ? CharacterGasDebugComponent.GetEntityInfo(instigator) : null;
		if (entityInfo == null)
		{
			return null;
		}
		list.Add(entityInfo.Type);
		list.Add(entityInfo.ConfigId);
		list.Add(entityInfo.Name);
		list.Add(buff.Config.Id.ToString());
		list.Add(buff.Config.Desc);
		list.Add(opt);
		return list.ToArray();
	}

	// Token: 0x06019933 RID: 104755 RVA: 0x006A01A0 File Offset: 0x0069E3A0
	[return: Nullable(2)]
	private static CharacterGasDebugComponent.EntityInfo GetEntityInfo(Entity attacker)
	{
		CreatureDataComponent component = attacker.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return null;
		}
		EEntityType entityType = component.GetEntityType();
		if (entityType == EEntityType.Player)
		{
			int id = component.Valid ? component.GetRoleId() : 0;
			int baseRoleId = RoleConfig.Instance.GetBaseRoleId(id);
			if (baseRoleId == 0)
			{
				return null;
			}
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(baseRoleId);
			string name = (roleConfig != null) ? RoleConfig.Instance.GetRoleName(roleConfig.Value.Name) : "";
			return new CharacterGasDebugComponent.EntityInfo
			{
				Name = name,
				Type = "角色",
				ConfigId = component.GetPbDataId().ToString()
			};
		}
		else
		{
			if (entityType == EEntityType.Monster)
			{
				string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
				return new CharacterGasDebugComponent.EntityInfo
				{
					Name = configTextByKey,
					Type = "怪物",
					ConfigId = component.GetPbDataId().ToString()
				};
			}
			if (entityType == EEntityType.SceneEntity)
			{
				string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
				return new CharacterGasDebugComponent.EntityInfo
				{
					Name = configTextByKey2,
					Type = "场景实体",
					ConfigId = component.GetPbDataId().ToString()
				};
			}
			if (entityType == EEntityType.Vehicle && CharacterGasDebugComponent.IsMoto(attacker))
			{
				string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey(component.GetEntityTidName() ?? "");
				return new CharacterGasDebugComponent.EntityInfo
				{
					Name = configTextByKey3,
					Type = "摩托车",
					ConfigId = component.GetPbDataId().ToString()
				};
			}
			return null;
		}
	}

	// Token: 0x06019934 RID: 104756 RVA: 0x006A0344 File Offset: 0x0069E544
	public static void SetDamageRecord(bool enable)
	{
		EnableDamageRecordRequest enableDamageRecordRequest = EnableDamageRecordRequest.Create();
		enableDamageRecordRequest.Enable = enable;
		Net.Instance.Call(ERequestMessageId.EnableDamageRecordRequest, enableDamageRecordRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			EnableDamageRecordResponse enableDamageRecordResponse = (EnableDamageRecordResponse)msg;
		}, 0);
	}

	// Token: 0x06019935 RID: 104757 RVA: 0x006A0390 File Offset: 0x0069E590
	[NullableContext(2)]
	[CombatListen(ENotifyMessageId.DamageRecordNotify, true, false)]
	public static void OnDamageRecordNotify(Entity owner, [Nullable(1)] DamageRecordNotify data, CombatCommon combatCommon = null)
	{
		Entity entity = EntitySystem.Instance.Get(CreatureModel.Instance.GetEntityId(data.Attacker.EntityId));
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null || component.GetEntityType() != EEntityType.SceneEntity)
		{
			CreatureDataComponent component2 = entity.GetComponent<CreatureDataComponent>();
			if (component2 == null || component2.GetEntityType() != EEntityType.Vehicle || !CharacterGasDebugComponent.IsMoto(entity))
			{
				CharacterStatisticsComponent component3 = entity.GetComponent<CharacterStatisticsComponent>();
				if (component3 == null || !component3.GetStatisticsEnable())
				{
					return;
				}
			}
		}
		string secondSinceStartup = (((double)data.TimestampMs - CharacterGasDebugComponent.RecordStartTimeStamp) * 0.0010000000474974513 - (double)CharacterGasDebugComponent.TimeStopSpanTime).ToString("F2");
		string currTimeString = CharacterGasDebugComponent.TimeStringFromStamp(data.TimestampMs);
		CharacterGasDebugComponent.RecordDamage(entity, data, secondSinceStartup, currTimeString);
		CharacterGasDebugComponent.OnDamageRecordAttr(entity, data, secondSinceStartup, currTimeString);
		CharacterGasDebugComponent.OnDamageRecordSnapshot(entity, data, secondSinceStartup, currTimeString);
		CharacterGasDebugComponent.OnDamageRecordDsp(entity, data);
	}

	// Token: 0x06019936 RID: 104758 RVA: 0x006A046A File Offset: 0x0069E66A
	private static bool IsMoto(Entity entity)
	{
		return entity.GetComponent<MotorcyclePerformComponent>() != null;
	}

	// Token: 0x06019937 RID: 104759 RVA: 0x006A0475 File Offset: 0x0069E675
	private static int RecordDspCompare(DamageRecordDsp a, DamageRecordDsp b)
	{
		return (int)(a.TimeStamp - b.TimeStamp);
	}

	// Token: 0x06019938 RID: 104760 RVA: 0x006A0488 File Offset: 0x0069E688
	private static void OnDamageRecordDsp(Entity attackerEntity, DamageRecordNotify data)
	{
		CreatureDataComponent component = attackerEntity.GetComponent<CreatureDataComponent>();
		if (component == null || component.GetEntityType() != EEntityType.Player)
		{
			return;
		}
		if (CharacterGasDebugComponent.DamageRecordDspMap == null)
		{
			CharacterGasDebugComponent.DamageRecordDspMap = new Dictionary<int, PriorityQueue<DamageRecordDsp>>();
		}
		int id = attackerEntity.Id;
		PriorityQueue<DamageRecordDsp> priorityQueue = CharacterGasDebugComponent.DamageRecordDspMap.ContainsKey(id) ? CharacterGasDebugComponent.DamageRecordDspMap[id] : null;
		if (priorityQueue == null)
		{
			Comparison<DamageRecordDsp> compare;
			if ((compare = CharacterGasDebugComponent.<>O.<2>__RecordDspCompare) == null)
			{
				compare = (CharacterGasDebugComponent.<>O.<2>__RecordDspCompare = new Comparison<DamageRecordDsp>(CharacterGasDebugComponent.RecordDspCompare));
			}
			priorityQueue = new PriorityQueue<DamageRecordDsp>(compare);
			CharacterGasDebugComponent.DamageRecordDspMap[id] = priorityQueue;
		}
		DamageRecordDsp item = new DamageRecordDsp((float)(Time.Instance.WorldTimeSeconds - (double)CharacterGasDebugComponent.TimeStopSpanTime), (float)data.DamageValue, false, false, false, false);
		priorityQueue.Push(item);
	}

	// Token: 0x06019939 RID: 104761 RVA: 0x006A0538 File Offset: 0x0069E738
	private void OnBeginSkill(int entityId, int skillId, bool isAutonomousProxy)
	{
		BaseSkillComponent component = base.Entity.GetComponent<BaseSkillComponent>();
		if (CharacterGasDebugComponent.DamageRecordDspMap == null)
		{
			CharacterGasDebugComponent.DamageRecordDspMap = new Dictionary<int, PriorityQueue<DamageRecordDsp>>();
		}
		int id = base.Entity.Id;
		IReadOnlyList<ESkillGenre> source = ((component != null) ? component.GetSkillGenres(skillId) : null) ?? Array.Empty<ESkillGenre>();
		if (source.Contains(ESkillGenre.QTE4))
		{
			PriorityQueue<DamageRecordDsp> priorityQueue = CharacterGasDebugComponent.DamageRecordDspMap.ContainsKey(id) ? CharacterGasDebugComponent.DamageRecordDspMap[id] : null;
			if (priorityQueue == null)
			{
				Comparison<DamageRecordDsp> compare;
				if ((compare = CharacterGasDebugComponent.<>O.<2>__RecordDspCompare) == null)
				{
					compare = (CharacterGasDebugComponent.<>O.<2>__RecordDspCompare = new Comparison<DamageRecordDsp>(CharacterGasDebugComponent.RecordDspCompare));
				}
				priorityQueue = new PriorityQueue<DamageRecordDsp>(compare);
				CharacterGasDebugComponent.DamageRecordDspMap[id] = priorityQueue;
			}
			DamageRecordDsp item = new DamageRecordDsp((float)(Time.Instance.WorldTimeSeconds - (double)CharacterGasDebugComponent.TimeStopSpanTime), -1f, true, false, false, false);
			priorityQueue.Push(item);
		}
		if (source.Contains(ESkillGenre.退场技12))
		{
			PriorityQueue<DamageRecordDsp> priorityQueue2 = CharacterGasDebugComponent.DamageRecordDspMap.ContainsKey(id) ? CharacterGasDebugComponent.DamageRecordDspMap[id] : null;
			if (priorityQueue2 == null)
			{
				Comparison<DamageRecordDsp> compare2;
				if ((compare2 = CharacterGasDebugComponent.<>O.<2>__RecordDspCompare) == null)
				{
					compare2 = (CharacterGasDebugComponent.<>O.<2>__RecordDspCompare = new Comparison<DamageRecordDsp>(CharacterGasDebugComponent.RecordDspCompare));
				}
				priorityQueue2 = new PriorityQueue<DamageRecordDsp>(compare2);
				CharacterGasDebugComponent.DamageRecordDspMap[id] = priorityQueue2;
			}
			DamageRecordDsp item2 = new DamageRecordDsp((float)(Time.Instance.WorldTimeSeconds - (double)CharacterGasDebugComponent.TimeStopSpanTime), -1f, false, false, false, true);
			priorityQueue2.Push(item2);
		}
	}

	// Token: 0x0601993A RID: 104762 RVA: 0x006A067F File Offset: 0x0069E87F
	private static void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		CharacterGasDebugComponent.OnChangeRoleInternal(newEntity.Id, true, false);
		if (oldEntity != null)
		{
			CharacterGasDebugComponent.OnChangeRoleInternal(oldEntity.Id, false, true);
		}
	}

	// Token: 0x0601993B RID: 104763 RVA: 0x006A06A0 File Offset: 0x0069E8A0
	private static void OnChangeRoleInternal(int entityId, bool inGame, bool outGame)
	{
		if (CharacterGasDebugComponent.DamageRecordDspMap == null)
		{
			CharacterGasDebugComponent.DamageRecordDspMap = new Dictionary<int, PriorityQueue<DamageRecordDsp>>();
		}
		PriorityQueue<DamageRecordDsp> priorityQueue = CharacterGasDebugComponent.DamageRecordDspMap.ContainsKey(entityId) ? CharacterGasDebugComponent.DamageRecordDspMap[entityId] : null;
		if (priorityQueue == null)
		{
			Comparison<DamageRecordDsp> compare;
			if ((compare = CharacterGasDebugComponent.<>O.<2>__RecordDspCompare) == null)
			{
				compare = (CharacterGasDebugComponent.<>O.<2>__RecordDspCompare = new Comparison<DamageRecordDsp>(CharacterGasDebugComponent.RecordDspCompare));
			}
			priorityQueue = new PriorityQueue<DamageRecordDsp>(compare);
			CharacterGasDebugComponent.DamageRecordDspMap[entityId] = priorityQueue;
		}
		DamageRecordDsp item = new DamageRecordDsp((float)(Time.Instance.WorldTimeSeconds - (double)CharacterGasDebugComponent.TimeStopSpanTime), -1f, false, inGame, outGame, false);
		priorityQueue.Push(item);
	}

	// Token: 0x1700234E RID: 9038
	// (get) Token: 0x0601993C RID: 104764 RVA: 0x006A0734 File Offset: 0x0069E934
	private static List<string> DamageRecordSnipeshotArray
	{
		get
		{
			return CharacterGasDebugComponent._damageRecordSnipeshotArray;
		}
	}

	// Token: 0x0601993D RID: 104765 RVA: 0x006A073C File Offset: 0x0069E93C
	private unsafe static void OnDamageRecordSnapshot(Entity attackerEntity, DamageRecordNotify data, string secondSinceStartup, string currTimeString)
	{
		long damageConfId = data.DamageConfId;
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageConfId);
		if (damageConfigById == null)
		{
			string item = "";
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "伤害配置为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("伤害ID", damageConfId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", item);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Damage value = damageConfigById.Value;
		List<string> list = new List<string>();
		list.Add(secondSinceStartup);
		list.Add(currTimeString);
		CharacterGasDebugComponent.EntityInfo entityInfo = CharacterGasDebugComponent.GetEntityInfo(attackerEntity);
		if (entityInfo == null)
		{
			return;
		}
		list.Add(entityInfo.Type);
		list.Add(entityInfo.ConfigId);
		list.Add(entityInfo.Name);
		list.Add((data.DamageSourceType == DamageSourceType.FromBullet) ? "子弹" : "Buff");
		list.Add(CharacterGasDebugComponent.DamageIdToDesc(data.DamageConfId));
		BulletDataMain bulletData = BulletConfig.Instance.GetBulletData(attackerEntity, data.BulletId.ToString(), false);
		Entity entity = null;
		if (bulletData == null)
		{
			int customEntityId = WorldController.Instance.GetCustomEntityId(attackerEntity.Id, 1);
			entity = EntitySystem.Instance.Get(customEntityId);
			if (entity != null && entity.Valid)
			{
				bulletData = BulletConfig.Instance.GetBulletData(entity, data.BulletId.ToString(), true);
			}
		}
		list.Add(((bulletData != null) ? bulletData.BulletName : null) ?? "");
		list.Add(data.DamageValue.ToString("F0"));
		int skillId = (int)data.SkillId;
		list.Add(skillId.ToString("F0"));
		BaseSkillComponent component = attackerEntity.GetComponent<BaseSkillComponent>();
		string text;
		if (component == null)
		{
			text = null;
		}
		else
		{
			SSkillInfo skillInfo = component.GetSkillInfo(skillId);
			text = ((skillInfo != null) ? skillInfo.SkillName.ToString() : null);
		}
		string text2 = text;
		if (string.IsNullOrEmpty(text2))
		{
			string text3;
			if (entity == null)
			{
				text3 = null;
			}
			else
			{
				BaseSkillComponent component2 = entity.GetComponent<BaseSkillComponent>();
				if (component2 == null)
				{
					text3 = null;
				}
				else
				{
					SSkillInfo skillInfo2 = component2.GetSkillInfo(skillId);
					text3 = ((skillInfo2 != null) ? skillInfo2.SkillName.ToString() : null);
				}
			}
			text2 = text3;
		}
		list.Add(text2 ?? "");
		list.Add(data.Attacker.EntityId.ToString());
		list.Add(data.IsCritical ? "1" : "0");
		int count = list.Count;
		int num = CharacterGasDebugComponent.AttributeIdArray.Length;
		CharacterGasDebugComponent.ColletSnapshot(data.Victim.AttrSnapshot.ToArray<GameplayAttributeData>(), list, count);
		CharacterGasDebugComponent.ColletSnapshot(data.Attacker.AttrSnapshot.ToArray<GameplayAttributeData>(), list, count + num);
		int skillLevel = data.SkillLevel;
		int num2 = count + num * 2;
		int index = num2 + 1;
		int index2 = num2 + 2;
		int index3 = num2 + 3;
		int index4 = num2 + 4;
		int index5 = num2 + 5;
		int index6 = num2 + 6;
		int num3 = num2 + 7;
		while (list.Count <= num3)
		{
			list.Add("");
		}
		list[num2] = AbilityUtils.GetLevelValue<int>(value.GetToughLvArray(), skillLevel, 0).ToString();
		list[index] = AbilityUtils.GetLevelValue<int>(value.GetEnergyArray(), skillLevel, 0).ToString();
		list[index2] = value.ElementPowerType.ToString();
		list[index3] = AbilityUtils.GetLevelValue<int>(value.GetElementPowerArray(), skillLevel, 0).ToString();
		List<string> list2 = new List<string>();
		List<long> list3 = new List<long>();
		foreach (long num4 in data.Attacker.BuffIds)
		{
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(num4, null);
			list2.Add(((buffDefinition != null) ? buffDefinition.Desc : null) ?? "");
			list3.Add(num4);
		}
		list[index4] = string.Join<long>("|", list3);
		list[index5] = string.Join("|", list2);
		list2.Clear();
		list3.Clear();
		foreach (long num5 in data.Victim.BuffIds)
		{
			BuffDefinition buffDefinition2 = BuffController.Instance.GetBuffDefinition(num5, null);
			list2.Add(((buffDefinition2 != null) ? buffDefinition2.Desc : null) ?? "");
			list3.Add(num5);
		}
		list[index6] = string.Join<long>("|", list3);
		list[num3] = string.Join("|", list2);
		string item2 = string.Join(",", list);
		CharacterGasDebugComponent.DamageRecordSnipeshotArray.Add(item2);
	}

	// Token: 0x0601993E RID: 104766 RVA: 0x006A0C40 File Offset: 0x0069EE40
	private static void ColletSnapshot(GameplayAttributeData[] attrsSnapshot, List<string> result, int baseIndexBase)
	{
		foreach (GameplayAttributeData gameplayAttributeData in attrsSnapshot)
		{
			int j = 0;
			int num = CharacterGasDebugComponent.AttributeIdArray.Length;
			while (j < num)
			{
				if (gameplayAttributeData.AttributeType == (int)CharacterGasDebugComponent.AttributeIdArray[j])
				{
					while (result.Count <= baseIndexBase + j)
					{
						result.Add("");
					}
					result[baseIndexBase + j] = CharacterGasDebugComponent.ResolveSnapshotValue(gameplayAttributeData).ToString();
					break;
				}
				j++;
			}
		}
	}

	// Token: 0x0601993F RID: 104767 RVA: 0x006A0CB4 File Offset: 0x0069EEB4
	private static string TimeStringFromStamp(long timestampMs)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds((double)MathUtils.Instance.LongToNumber(timestampMs));
		return StringUtils.Format("{0}月{1}日{2}:{3}:{4}:{5}", new string[]
		{
			(dateTime.Month - 1).ToString(),
			dateTime.Day.ToString(),
			dateTime.Hour.ToString(),
			dateTime.Minute.ToString(),
			dateTime.Second.ToString(),
			dateTime.Millisecond.ToString()
		});
	}

	// Token: 0x1700234F RID: 9039
	// (get) Token: 0x06019940 RID: 104768 RVA: 0x006A0D64 File Offset: 0x0069EF64
	private static List<string> DamageRecordAttrArray
	{
		get
		{
			return CharacterGasDebugComponent._damageRecordAttrArray;
		}
	}

	// Token: 0x06019941 RID: 104769 RVA: 0x006A0D6C File Offset: 0x0069EF6C
	private unsafe static void OnDamageRecordAttr(Entity attackerEntity, DamageRecordNotify data, string secondSinceStartup, string currTimeString)
	{
		long damageConfId = data.DamageConfId;
		Damage? damageConfigById = DamageModel.Instance.GetDamageConfigById(damageConfId);
		if (damageConfigById == null)
		{
			string item = "";
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "伤害配置为空";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("伤害ID", damageConfId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Name", item);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		Damage value = damageConfigById.Value;
		List<string> list = new List<string>();
		list.Add(secondSinceStartup);
		list.Add(currTimeString);
		CharacterGasDebugComponent.EntityInfo entityInfo = CharacterGasDebugComponent.GetEntityInfo(attackerEntity);
		if (entityInfo == null)
		{
			return;
		}
		list.Add(entityInfo.Type);
		list.Add(entityInfo.ConfigId);
		list.Add(entityInfo.Name);
		list.Add((data.DamageSourceType == DamageSourceType.FromBullet) ? "子弹" : "Buff");
		list.Add(CharacterGasDebugComponent.DamageIdToDesc(data.DamageConfId));
		BulletDataMain bulletData = BulletConfig.Instance.GetBulletData(attackerEntity, data.BulletId.ToString(), false);
		Entity entity = null;
		if (bulletData == null)
		{
			int customEntityId = WorldController.Instance.GetCustomEntityId(attackerEntity.Id, 1);
			entity = EntitySystem.Instance.Get(customEntityId);
			if (entity != null && entity.Valid)
			{
				bulletData = BulletConfig.Instance.GetBulletData(entity, data.BulletId.ToString(), true);
			}
		}
		list.Add(((bulletData != null) ? bulletData.BulletName : null) ?? "");
		list.Add(data.DamageValue.ToString("F0"));
		list.Add(data.DamageCalculationDetails.ExceptedDamageValue.ToString("F2"));
		int skillId = (int)data.SkillId;
		list.Add(skillId.ToString());
		BaseSkillComponent component = attackerEntity.GetComponent<BaseSkillComponent>();
		string text;
		if (component == null)
		{
			text = null;
		}
		else
		{
			SSkillInfo skillInfo = component.GetSkillInfo(skillId);
			text = ((skillInfo != null) ? skillInfo.SkillName.ToString() : null);
		}
		string text2 = text;
		if (string.IsNullOrEmpty(text2))
		{
			string text3;
			if (entity == null)
			{
				text3 = null;
			}
			else
			{
				BaseSkillComponent component2 = entity.GetComponent<BaseSkillComponent>();
				if (component2 == null)
				{
					text3 = null;
				}
				else
				{
					SSkillInfo skillInfo2 = component2.GetSkillInfo(skillId);
					text3 = ((skillInfo2 != null) ? skillInfo2.SkillName.ToString() : null);
				}
			}
			text2 = text3;
		}
		list.Add(text2 ?? "");
		list.Add(data.IsCritical ? "1" : "0");
		list.Add(data.Attacker.EntityId.ToString());
		int count = list.Count;
		list.Add("0");
		foreach (GameplayAttributeData gameplayAttributeData in data.Attacker.Attr)
		{
			if (gameplayAttributeData.AttributeType == 77)
			{
				list[count] = gameplayAttributeData.BaseValue.ToString("F0");
				break;
			}
		}
		DamageCalculationDetails damageCalculationDetails = data.DamageCalculationDetails;
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.ABaseAttackValue : 0L).ToString());
		list.Add((((damageCalculationDetails != null) ? damageCalculationDetails.ARate : 0f) * 100f).ToString("F2"));
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.ADamageFactor : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.ADamageBonusRate : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.HitDamageBonusRate : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.VWeaknessBuffStack : 0).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.WeakDamageBonusRate : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.VDefFactor : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.VResistanceFactor : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.VEffectiveDefense : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.AEnergyChange : 0L).ToString());
		list.Add((damageCalculationDetails != null && damageCalculationDetails.ACritChance != 0L) ? MathUtils.Instance.LongToNumber(damageCalculationDetails.ACritChance).ToString() : "0");
		list.Add(data.IsWeakness ? "1" : "0");
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.AWeaknessMasteryCoefficient : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.VMonsterTypeRate : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.VbDamageReduce : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.VbElementReduce : 0f).ToString());
		list.Add(((damageCalculationDetails != null) ? damageCalculationDetails.WeaknessLvValue : 0f).ToString());
		count = list.Count;
		int num = CharacterGasDebugComponent.AttributeIdArray.Length;
		CharacterGasDebugComponent.CollectAttr(data.Attacker.Attr.ToArray<GameplayAttributeData>(), data.Attacker.AttrSnapshot.ToArray<GameplayAttributeData>(), list, count, count + num);
		CharacterGasDebugComponent.CollectAttr(data.Victim.Attr.ToArray<GameplayAttributeData>(), data.Victim.AttrSnapshot.ToArray<GameplayAttributeData>(), list, count + num * 2, count + num * 3);
		int skillLevel = data.SkillLevel;
		int num2 = count + num * 4;
		while (list.Count <= num2)
		{
			list.Add("");
		}
		list[num2] = AbilityUtils.GetLevelValue<int>(value.GetHardnessLvArray(), skillLevel, 0).ToString();
		list.Add(AbilityUtils.GetLevelValue<int>(value.GetPercent0Array(), skillLevel, 0).ToString());
		list.Add(AbilityUtils.GetLevelValue<int>(value.GetPercent1Array(), skillLevel, 0).ToString());
		list.Add(AbilityUtils.GetLevelValue<int>(value.GetToughLvArray(), skillLevel, 0).ToString());
		list.Add(AbilityUtils.GetLevelValue<int>(value.GetEnergyArray(), skillLevel, 0).ToString());
		list.Add(value.ElementPowerType.ToString());
		list.Add(AbilityUtils.GetLevelValue<int>(value.GetElementPowerArray(), skillLevel, 0).ToString());
		List<string> list2 = new List<string>();
		List<long> list3 = new List<long>();
		foreach (long num3 in data.Attacker.BuffIds)
		{
			BuffDefinition buffDefinition = BuffController.Instance.GetBuffDefinition(num3, null);
			list2.Add(((buffDefinition != null) ? buffDefinition.Desc : null) ?? "");
			list3.Add(num3);
		}
		list.Add(string.Join<long>("|", list3));
		list.Add(string.Join("|", list2));
		list2.Clear();
		list3.Clear();
		foreach (long num4 in data.Victim.BuffIds)
		{
			BuffDefinition buffDefinition2 = BuffController.Instance.GetBuffDefinition(num4, null);
			list2.Add(((buffDefinition2 != null) ? buffDefinition2.Desc : null) ?? "");
			list3.Add(num4);
		}
		list.Add(string.Join<long>("|", list3));
		list.Add(string.Join("|", list2));
		string item2 = string.Join(",", list);
		CharacterGasDebugComponent.DamageRecordAttrArray.Add(item2);
	}

	// Token: 0x06019942 RID: 104770 RVA: 0x006A15BC File Offset: 0x0069F7BC
	private static int ResolveSnapshotValue(GameplayAttributeData attrSnapshot)
	{
		if (attrSnapshot.CurrentValue == -2147483648)
		{
			return 0;
		}
		if (attrSnapshot.CurrentValue == 0)
		{
			return attrSnapshot.BaseValue;
		}
		return attrSnapshot.CurrentValue;
	}

	// Token: 0x06019943 RID: 104771 RVA: 0x006A15E4 File Offset: 0x0069F7E4
	private static void CollectAttr(GameplayAttributeData[] attrs, GameplayAttributeData[] attrsSnapshot, List<string> result, int baseIndexCurrent, int baseIndexBase)
	{
		int i = 0;
		int num = CharacterGasDebugComponent.AttributeIdArray.Length;
		while (i < num)
		{
			foreach (GameplayAttributeData gameplayAttributeData in attrsSnapshot)
			{
				if (gameplayAttributeData.AttributeType == (int)CharacterGasDebugComponent.AttributeIdArray[i])
				{
					while (result.Count <= baseIndexCurrent + i)
					{
						result.Add("");
					}
					result[baseIndexCurrent + i] = CharacterGasDebugComponent.ResolveSnapshotValue(gameplayAttributeData).ToString();
					break;
				}
			}
			foreach (GameplayAttributeData gameplayAttributeData2 in attrs)
			{
				if (gameplayAttributeData2.AttributeType == (int)CharacterGasDebugComponent.AttributeIdArray[i])
				{
					while (result.Count <= baseIndexBase + i)
					{
						result.Add("");
					}
					result[baseIndexBase + i] = gameplayAttributeData2.BaseValue.ToString();
					break;
				}
			}
			i++;
		}
	}

	// Token: 0x06019944 RID: 104772 RVA: 0x006A16C0 File Offset: 0x0069F8C0
	public static void CleanupRecord()
	{
		CharacterGasDebugComponent.InTimeStop = false;
		CharacterGasDebugComponent.TimeStopSpanTime = 0f;
		CharacterGasDebugComponent.MoveRecordStrings.Clear();
		CharacterGasDebugComponent.DamageRecordStrings.Clear();
		CharacterGasDebugComponent.MoveSumTable.Clear();
		CharacterGasDebugComponent.RoleDamageSumTable.Clear();
		CharacterGasDebugComponent.MonsterDamageSumTable.Clear();
		CharacterGasDebugComponent.BulletCreateMap.Clear();
		CharacterGasDebugComponent.BulletCreateEntityId.Clear();
		CharacterGasDebugComponent.BuffRecordArray.Clear();
		Dictionary<int, PriorityQueue<DamageRecordDsp>> damageRecordDspMap = CharacterGasDebugComponent.DamageRecordDspMap;
		if (damageRecordDspMap != null)
		{
			damageRecordDspMap.Clear();
		}
		CharacterGasDebugComponent.DamageRecordSnipeshotArray.Clear();
		CharacterGasDebugComponent.DamageRecordAttrArray.Clear();
	}

	// Token: 0x06019945 RID: 104773 RVA: 0x006A1751 File Offset: 0x0069F951
	private static void OnAbsoluteTimeStop(bool open, float _)
	{
		CharacterGasDebugComponent.InTimeStop = open;
	}

	// Token: 0x06019946 RID: 104774 RVA: 0x006A175C File Offset: 0x0069F95C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterGasDebugComponent characterGasDebugComponent = (CharacterGasDebugComponent)componentTemplate;
		if (base.CanResetComponentProperty("DebugGasComponent"))
		{
			if (characterGasDebugComponent.DebugGasComponent == null)
			{
				this.DebugGasComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UBaseAbilitySystemComponent>(this.DebugGasComponent), "DebugGasComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("EnableCollisionDebugDraw"))
		{
			this.EnableCollisionDebugDraw = characterGasDebugComponent.EnableCollisionDebugDraw;
		}
		if (base.CanResetComponentProperty("GeDebugId"))
		{
			this.GeDebugId = characterGasDebugComponent.GeDebugId;
		}
		if (base.CanResetComponentProperty("GeDebugTask"))
		{
			if (characterGasDebugComponent.GeDebugTask == null)
			{
				this.GeDebugTask = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UAsyncTaskEffectDebugString>(this.GeDebugTask), "GeDebugTask"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DebugStrings") && characterGasDebugComponent.DebugStrings != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<string>>(this.DebugStrings), "DebugStrings"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SkillLogStrings") && characterGasDebugComponent.SkillLogStrings != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<string>>(this.SkillLogStrings), "SkillLogStrings"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SkillBehaviorLogStrings") && characterGasDebugComponent.SkillBehaviorLogStrings != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<string>>(this.SkillBehaviorLogStrings), "SkillBehaviorLogStrings"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ShieldDebugStrings") && characterGasDebugComponent.ShieldDebugStrings != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<string>>(this.ShieldDebugStrings), "ShieldDebugStrings"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("BulletDebugStrings") && characterGasDebugComponent.BulletDebugStrings != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<string>>(this.BulletDebugStrings), "BulletDebugStrings"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("AttributeDebugStrings") && characterGasDebugComponent.AttributeDebugStrings != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<string>>(this.AttributeDebugStrings), "AttributeDebugStrings"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("MovementDebugStrings") && characterGasDebugComponent.MovementDebugStrings != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<string>>(this.MovementDebugStrings), "MovementDebugStrings"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ServerDebugInfo"))
		{
			if (characterGasDebugComponent.ServerDebugInfo == null)
			{
				this.ServerDebugInfo = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityBattleInfoResponse>(this.ServerDebugInfo), "ServerDebugInfo"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ServerDebugInfoDirty"))
		{
			this.ServerDebugInfoDirty = characterGasDebugComponent.ServerDebugInfoDirty;
		}
		if (base.CanResetComponentProperty("HasRequestServerBuff") && characterGasDebugComponent.HasRequestServerBuff != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.HasRequestServerBuff), "HasRequestServerBuff"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("WaitResponseBuff") && characterGasDebugComponent.WaitResponseBuff != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, HashSet<int>>>(this.WaitResponseBuff), "WaitResponseBuff"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("InnerRequestHandle"))
		{
			this.InnerRequestHandle = characterGasDebugComponent.InnerRequestHandle;
		}
		return true;
	}

	// Token: 0x0400BF2B RID: 48939
	[StaticVariableRuleIgnore]
	private static readonly StringBuilder Sb = new StringBuilder(256);

	// Token: 0x0400BF2C RID: 48940
	private const int MAX_DEBUG_STRING_NUMS = 50;

	// Token: 0x0400BF2D RID: 48941
	[Nullable(2)]
	private static EAttributeType[] _attributeIdArray;

	// Token: 0x0400BF2E RID: 48942
	[Nullable(2)]
	private UBaseAbilitySystemComponent DebugGasComponent;

	// Token: 0x0400BF2F RID: 48943
	public bool EnableCollisionDebugDraw;

	// Token: 0x0400BF30 RID: 48944
	private int GeDebugId;

	// Token: 0x0400BF31 RID: 48945
	[Nullable(2)]
	private UAsyncTaskEffectDebugString GeDebugTask;

	// Token: 0x0400BF32 RID: 48946
	private readonly List<string> DebugStrings = new List<string>();

	// Token: 0x0400BF33 RID: 48947
	private readonly List<string> SkillLogStrings = new List<string>();

	// Token: 0x0400BF34 RID: 48948
	private readonly List<string> SkillBehaviorLogStrings = new List<string>();

	// Token: 0x0400BF35 RID: 48949
	private readonly List<string> ShieldDebugStrings = new List<string>();

	// Token: 0x0400BF36 RID: 48950
	private readonly List<string> BulletDebugStrings = new List<string>();

	// Token: 0x0400BF37 RID: 48951
	private readonly List<string> AttributeDebugStrings = new List<string>();

	// Token: 0x0400BF38 RID: 48952
	private readonly List<string> MovementDebugStrings = new List<string>();

	// Token: 0x0400BF39 RID: 48953
	private static bool IsServerLogOnInternal = false;

	// Token: 0x0400BF3A RID: 48954
	private static bool ShouldRecord = false;

	// Token: 0x0400BF3B RID: 48955
	private static double RecordStartTime = 0.0;

	// Token: 0x0400BF3C RID: 48956
	private static double RecordStartTimeStamp = 0.0;

	// Token: 0x0400BF3D RID: 48957
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> _moveRecordStrings;

	// Token: 0x0400BF3E RID: 48958
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> _damageRecordStrings;

	// Token: 0x0400BF3F RID: 48959
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<int, RecordMoveSum> _moveSumTable;

	// Token: 0x0400BF40 RID: 48960
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, RecordDamageSum> _roleDamageSumTable;

	// Token: 0x0400BF41 RID: 48961
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, RecordDamageSum> _monsterDamageSumTable;

	// Token: 0x0400BF42 RID: 48962
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, string[]> _bulletCreateMap;

	// Token: 0x0400BF43 RID: 48963
	[Nullable(2)]
	private static List<int> _bulletCreateEntityId;

	// Token: 0x0400BF44 RID: 48964
	private const string SavePath = "Statistics/FightDataRecord/";

	// Token: 0x0400BF45 RID: 48965
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<long, string> DamageIdToString = new Dictionary<long, string>
	{
		{
			1001L,
			"1001(风蚀)"
		},
		{
			1002L,
			"1002(电磁)"
		},
		{
			1003L,
			"1003(霜渐)"
		},
		{
			1004L,
			"1004(聚爆)"
		},
		{
			1005L,
			"1005(光噪)"
		},
		{
			1006L,
			"1006(虚湮)"
		}
	};

	// Token: 0x0400BF46 RID: 48966
	[Nullable(2)]
	public EntityBattleInfoResponse ServerDebugInfo;

	// Token: 0x0400BF47 RID: 48967
	public bool ServerDebugInfoDirty;

	// Token: 0x0400BF48 RID: 48968
	private readonly HashSet<int> HasRequestServerBuff = new HashSet<int>();

	// Token: 0x0400BF49 RID: 48969
	private readonly Dictionary<int, HashSet<int>> WaitResponseBuff = new Dictionary<int, HashSet<int>>();

	// Token: 0x0400BF4A RID: 48970
	private int InnerRequestHandle;

	// Token: 0x0400BF4B RID: 48971
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> _buffRecordArray;

	// Token: 0x0400BF4C RID: 48972
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<int, PriorityQueue<DamageRecordDsp>> DamageRecordDspMap = null;

	// Token: 0x0400BF4D RID: 48973
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> _damageRecordSnipeshotArray;

	// Token: 0x0400BF4E RID: 48974
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> _damageRecordAttrArray;

	// Token: 0x0400BF4F RID: 48975
	private static bool InTimeStop = false;

	// Token: 0x0400BF50 RID: 48976
	private static float TimeStopSpanTime = 0f;

	// Token: 0x0400BF51 RID: 48977
	private static long FrameUpdateSpanTime = 0L;

	// Token: 0x020095EE RID: 38382
	[Nullable(0)]
	public class EntityInfo
	{
		// Token: 0x040301F9 RID: 197113
		public string Name = "";

		// Token: 0x040301FA RID: 197114
		public string Type = "";

		// Token: 0x040301FB RID: 197115
		public string ConfigId = "";
	}

	// Token: 0x020095EF RID: 38383
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040301FC RID: 197116
		[Nullable(new byte[]
		{
			0,
			1,
			2
		})]
		public static Action<EntityHandle, EntityHandle> <0>__OnChangeRole;

		// Token: 0x040301FD RID: 197117
		[Nullable(0)]
		public static Action<bool, float> <1>__OnAbsoluteTimeStop;

		// Token: 0x040301FE RID: 197118
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<DamageRecordDsp> <2>__RecordDspCompare;
	}
}
