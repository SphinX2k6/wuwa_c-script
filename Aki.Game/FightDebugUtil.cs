using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x020031BC RID: 12732
[NullableContext(1)]
[Nullable(0)]
public class FightDebugUtil : IStaticVariableResetter
{
	// Token: 0x170025FC RID: 9724
	// (get) Token: 0x0601B724 RID: 112420 RVA: 0x007827C6 File Offset: 0x007809C6
	public static ECharacterLoadType DtSkillTypeForDebug
	{
		get
		{
			return FightDebugUtil._dtSkillTypeForDebug;
		}
	}

	// Token: 0x170025FD RID: 9725
	// (get) Token: 0x0601B725 RID: 112421 RVA: 0x007827CD File Offset: 0x007809CD
	private static HashSet<int> LoadingEntityIdsForDebug
	{
		get
		{
			return FightDebugUtil._loadingEntityIdsForDebug;
		}
	}

	// Token: 0x170025FE RID: 9726
	// (get) Token: 0x0601B726 RID: 112422 RVA: 0x007827D4 File Offset: 0x007809D4
	private static HashSet<int> LoadingSkillEntityIdsForDebug
	{
		get
		{
			return FightDebugUtil._loadingSkillEntityIdsForDebug;
		}
	}

	// Token: 0x170025FF RID: 9727
	// (get) Token: 0x0601B727 RID: 112423 RVA: 0x007827DB File Offset: 0x007809DB
	private static HashSet<int> LoadedEntityIdsForDebug
	{
		get
		{
			return FightDebugUtil._loadedEntityIdsForDebug;
		}
	}

	// Token: 0x0601B728 RID: 112424 RVA: 0x007827E4 File Offset: 0x007809E4
	public static void LoadSkillFightDtDebug(ECharacterLoadType loadType, int entityId = 0)
	{
		FightDebugUtil.<>c__DisplayClass12_0 CS$<>8__locals1 = new FightDebugUtil.<>c__DisplayClass12_0();
		CS$<>8__locals1.loadType = loadType;
		List<Entity> list = new List<Entity>();
		if (entityId > 0)
		{
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.ZFJ;
				string message = "【debug】未找到指定entity";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			list.Add(entity);
		}
		else
		{
			foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
			{
				if (entityHandle.IsInit && entityHandle.Entity != null)
				{
					list.Add(entityHandle.Entity);
				}
			}
		}
		using (List<Entity>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				FightDebugUtil.<>c__DisplayClass12_1 CS$<>8__locals2 = new FightDebugUtil.<>c__DisplayClass12_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals2.entity = enumerator2.Current;
				UniTask.Create(delegate()
				{
					FightDebugUtil.<>c__DisplayClass12_1.<<LoadSkillFightDtDebug>b__0>d <<LoadSkillFightDtDebug>b__0>d;
					<<LoadSkillFightDtDebug>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
					<<LoadSkillFightDtDebug>b__0>d.<>4__this = CS$<>8__locals2;
					<<LoadSkillFightDtDebug>b__0>d.<>1__state = -1;
					<<LoadSkillFightDtDebug>b__0>d.<>t__builder.Start<FightDebugUtil.<>c__DisplayClass12_1.<<LoadSkillFightDtDebug>b__0>d>(ref <<LoadSkillFightDtDebug>b__0>d);
					return <<LoadSkillFightDtDebug>b__0>d.<>t__builder.Task;
				}).Forget();
			}
		}
	}

	// Token: 0x0601B729 RID: 112425 RVA: 0x0078290C File Offset: 0x00780B0C
	public static UniTask LoadSkillFightDtNewPreload(Entity entity, ECharacterLoadType loadType)
	{
		FightDebugUtil.<LoadSkillFightDtNewPreload>d__13 <LoadSkillFightDtNewPreload>d__;
		<LoadSkillFightDtNewPreload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadSkillFightDtNewPreload>d__.entity = entity;
		<LoadSkillFightDtNewPreload>d__.loadType = loadType;
		<LoadSkillFightDtNewPreload>d__.<>1__state = -1;
		<LoadSkillFightDtNewPreload>d__.<>t__builder.Start<FightDebugUtil.<LoadSkillFightDtNewPreload>d__13>(ref <LoadSkillFightDtNewPreload>d__);
		return <LoadSkillFightDtNewPreload>d__.<>t__builder.Task;
	}

	// Token: 0x0601B72A RID: 112426 RVA: 0x00782958 File Offset: 0x00780B58
	public static void LoadFightDtDebug(int entityId = 0)
	{
		List<Entity> list = new List<Entity>();
		if (entityId > 0)
		{
			Entity entity = EntitySystem.Instance.Get(entityId);
			if (entity == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "【debug】未找到指定的entity";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("entityId", entityId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			list.Add(entity);
		}
		else
		{
			foreach (EntityHandle entityHandle in CreatureModel.Instance.GetAllEntities())
			{
				if (entityHandle.IsInit && entityHandle.Entity != null)
				{
					list.Add(entityHandle.Entity);
				}
			}
		}
		using (List<Entity>.Enumerator enumerator2 = list.GetEnumerator())
		{
			while (enumerator2.MoveNext())
			{
				FightDebugUtil.<>c__DisplayClass14_0 CS$<>8__locals1 = new FightDebugUtil.<>c__DisplayClass14_0();
				CS$<>8__locals1.entity = enumerator2.Current;
				UniTask.Create(delegate()
				{
					FightDebugUtil.<>c__DisplayClass14_0.<<LoadFightDtDebug>b__0>d <<LoadFightDtDebug>b__0>d;
					<<LoadFightDtDebug>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
					<<LoadFightDtDebug>b__0>d.<>4__this = CS$<>8__locals1;
					<<LoadFightDtDebug>b__0>d.<>1__state = -1;
					<<LoadFightDtDebug>b__0>d.<>t__builder.Start<FightDebugUtil.<>c__DisplayClass14_0.<<LoadFightDtDebug>b__0>d>(ref <<LoadFightDtDebug>b__0>d);
					return <<LoadFightDtDebug>b__0>d.<>t__builder.Task;
				}).Forget();
			}
		}
	}

	// Token: 0x0601B72B RID: 112427 RVA: 0x00782A68 File Offset: 0x00780C68
	public static UniTask LoadCharacterFightDtNewPreload(Entity entity)
	{
		FightDebugUtil.<LoadCharacterFightDtNewPreload>d__15 <LoadCharacterFightDtNewPreload>d__;
		<LoadCharacterFightDtNewPreload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadCharacterFightDtNewPreload>d__.entity = entity;
		<LoadCharacterFightDtNewPreload>d__.<>1__state = -1;
		<LoadCharacterFightDtNewPreload>d__.<>t__builder.Start<FightDebugUtil.<LoadCharacterFightDtNewPreload>d__15>(ref <LoadCharacterFightDtNewPreload>d__);
		return <LoadCharacterFightDtNewPreload>d__.<>t__builder.Task;
	}

	// Token: 0x0601B72C RID: 112428 RVA: 0x00782AAC File Offset: 0x00780CAC
	public static UniTask LoadFightDtNewPreload(Entity entity)
	{
		FightDebugUtil.<LoadFightDtNewPreload>d__16 <LoadFightDtNewPreload>d__;
		<LoadFightDtNewPreload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadFightDtNewPreload>d__.entity = entity;
		<LoadFightDtNewPreload>d__.<>1__state = -1;
		<LoadFightDtNewPreload>d__.<>t__builder.Start<FightDebugUtil.<LoadFightDtNewPreload>d__16>(ref <LoadFightDtNewPreload>d__);
		return <LoadFightDtNewPreload>d__.<>t__builder.Task;
	}

	// Token: 0x0601B72D RID: 112429 RVA: 0x00782AF0 File Offset: 0x00780CF0
	public static void SetFightDtTypeForDebug(ECharacterLoadType dtType = ECharacterLoadType.通用)
	{
		if (dtType != FightDebugUtil.DtSkillTypeForDebug)
		{
			FightDebugUtil._dtSkillTypeForDebug = dtType;
			ChatRequest chatRequest = ChatRequest.Create();
			chatRequest.ChannelId = 0;
			ChatRequest chatRequest2 = chatRequest;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 1);
			defaultInterpolatedStringHandler.AppendLiteral("@ChangeInstFightInfoDtType ");
			defaultInterpolatedStringHandler.AppendFormatted<ECharacterLoadType>(dtType);
			chatRequest2.Content = defaultInterpolatedStringHandler.ToStringAndClear();
			Net.Instance.Call(ERequestMessageId.ChatRequest, chatRequest, delegate(IMessage response, Net.CallbackStatus _)
			{
			}, 0);
			EventSystem.Instance.Emit(EEventName.SetFightDtTypeForDebug);
		}
	}

	// Token: 0x0601B72E RID: 112430 RVA: 0x00782B83 File Offset: 0x00780D83
	static FightDebugUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FightDebugUtil.CreateStaticDefaultValue), new Action(FightDebugUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0601B72F RID: 112431 RVA: 0x00782BA2 File Offset: 0x00780DA2
	public static void CreateStaticDefaultValue()
	{
		FightDebugUtil._dtSkillTypeForDebug = ECharacterLoadType.通用;
		FightDebugUtil._loadingEntityIdsForDebug = new HashSet<int>();
		FightDebugUtil._loadingSkillEntityIdsForDebug = new HashSet<int>();
		FightDebugUtil._loadedEntityIdsForDebug = new HashSet<int>();
	}

	// Token: 0x0601B730 RID: 112432 RVA: 0x00782BC8 File Offset: 0x00780DC8
	public static void ResetStaticDefaultValue()
	{
		FightDebugUtil._dtSkillTypeForDebug = ECharacterLoadType.通用;
		FightDebugUtil._loadingEntityIdsForDebug = null;
		FightDebugUtil._loadingSkillEntityIdsForDebug = null;
		FightDebugUtil._loadedEntityIdsForDebug = null;
	}

	// Token: 0x0400D73C RID: 55100
	private static ECharacterLoadType _dtSkillTypeForDebug;

	// Token: 0x0400D73D RID: 55101
	[Nullable(2)]
	private static HashSet<int> _loadingEntityIdsForDebug;

	// Token: 0x0400D73E RID: 55102
	[Nullable(2)]
	private static HashSet<int> _loadingSkillEntityIdsForDebug;

	// Token: 0x0400D73F RID: 55103
	[Nullable(2)]
	private static HashSet<int> _loadedEntityIdsForDebug;
}
