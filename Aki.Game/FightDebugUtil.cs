using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

// Token: 0x0200272B RID: 10027
[NullableContext(1)]
[Nullable(0)]
public class FightDebugUtil : IStaticVariableResetter
{
	// Token: 0x170027FA RID: 10234
	// (get) Token: 0x06019258 RID: 103000 RVA: 0x007AA9D2 File Offset: 0x007A8BD2
	public static ECharacterLoadType DtSkillTypeForDebug
	{
		get
		{
			return FightDebugUtil._dtSkillTypeForDebug;
		}
	}

	// Token: 0x170027FB RID: 10235
	// (get) Token: 0x06019259 RID: 103001 RVA: 0x007AA9D9 File Offset: 0x007A8BD9
	private static HashSet<int> LoadingEntityIdsForDebug
	{
		get
		{
			return FightDebugUtil._loadingEntityIdsForDebug;
		}
	}

	// Token: 0x170027FC RID: 10236
	// (get) Token: 0x0601925A RID: 103002 RVA: 0x007AA9E0 File Offset: 0x007A8BE0
	private static HashSet<int> LoadingSkillEntityIdsForDebug
	{
		get
		{
			return FightDebugUtil._loadingSkillEntityIdsForDebug;
		}
	}

	// Token: 0x170027FD RID: 10237
	// (get) Token: 0x0601925B RID: 103003 RVA: 0x007AA9E7 File Offset: 0x007A8BE7
	private static HashSet<int> LoadedEntityIdsForDebug
	{
		get
		{
			return FightDebugUtil._loadedEntityIdsForDebug;
		}
	}

	// Token: 0x0601925C RID: 103004 RVA: 0x007AA9F0 File Offset: 0x007A8BF0
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

	// Token: 0x0601925D RID: 103005 RVA: 0x007AAB18 File Offset: 0x007A8D18
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

	// Token: 0x0601925E RID: 103006 RVA: 0x007AAB64 File Offset: 0x007A8D64
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

	// Token: 0x0601925F RID: 103007 RVA: 0x007AAC74 File Offset: 0x007A8E74
	public static UniTask LoadCharacterFightDtNewPreload(Entity entity)
	{
		FightDebugUtil.<LoadCharacterFightDtNewPreload>d__15 <LoadCharacterFightDtNewPreload>d__;
		<LoadCharacterFightDtNewPreload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadCharacterFightDtNewPreload>d__.entity = entity;
		<LoadCharacterFightDtNewPreload>d__.<>1__state = -1;
		<LoadCharacterFightDtNewPreload>d__.<>t__builder.Start<FightDebugUtil.<LoadCharacterFightDtNewPreload>d__15>(ref <LoadCharacterFightDtNewPreload>d__);
		return <LoadCharacterFightDtNewPreload>d__.<>t__builder.Task;
	}

	// Token: 0x06019260 RID: 103008 RVA: 0x007AACB8 File Offset: 0x007A8EB8
	public static UniTask LoadFightDtNewPreload(Entity entity)
	{
		FightDebugUtil.<LoadFightDtNewPreload>d__16 <LoadFightDtNewPreload>d__;
		<LoadFightDtNewPreload>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadFightDtNewPreload>d__.entity = entity;
		<LoadFightDtNewPreload>d__.<>1__state = -1;
		<LoadFightDtNewPreload>d__.<>t__builder.Start<FightDebugUtil.<LoadFightDtNewPreload>d__16>(ref <LoadFightDtNewPreload>d__);
		return <LoadFightDtNewPreload>d__.<>t__builder.Task;
	}

	// Token: 0x06019261 RID: 103009 RVA: 0x007AACFC File Offset: 0x007A8EFC
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

	// Token: 0x06019262 RID: 103010 RVA: 0x007AAD8F File Offset: 0x007A8F8F
	static FightDebugUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FightDebugUtil.CreateStaticDefaultValue), new Action(FightDebugUtil.ResetStaticDefaultValue));
	}

	// Token: 0x06019263 RID: 103011 RVA: 0x007AADAE File Offset: 0x007A8FAE
	public static void CreateStaticDefaultValue()
	{
		FightDebugUtil._dtSkillTypeForDebug = ECharacterLoadType.通用;
		FightDebugUtil._loadingEntityIdsForDebug = new HashSet<int>();
		FightDebugUtil._loadingSkillEntityIdsForDebug = new HashSet<int>();
		FightDebugUtil._loadedEntityIdsForDebug = new HashSet<int>();
	}

	// Token: 0x06019264 RID: 103012 RVA: 0x007AADD4 File Offset: 0x007A8FD4
	public static void ResetStaticDefaultValue()
	{
		FightDebugUtil._dtSkillTypeForDebug = ECharacterLoadType.通用;
		FightDebugUtil._loadingEntityIdsForDebug = null;
		FightDebugUtil._loadingSkillEntityIdsForDebug = null;
		FightDebugUtil._loadedEntityIdsForDebug = null;
	}

	// Token: 0x0400DBC3 RID: 56259
	private static ECharacterLoadType _dtSkillTypeForDebug;

	// Token: 0x0400DBC4 RID: 56260
	[Nullable(2)]
	private static HashSet<int> _loadingEntityIdsForDebug;

	// Token: 0x0400DBC5 RID: 56261
	[Nullable(2)]
	private static HashSet<int> _loadingSkillEntityIdsForDebug;

	// Token: 0x0400DBC6 RID: 56262
	[Nullable(2)]
	private static HashSet<int> _loadedEntityIdsForDebug;
}
