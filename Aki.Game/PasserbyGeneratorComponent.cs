using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game;
using CSharpScript.Game.LevelGamePlay.Common;
using Google.Protobuf;

// Token: 0x020031E8 RID: 12776
[NullableContext(1)]
[Nullable(0)]
public class PasserbyGeneratorComponent : EntityComponent
{
	// Token: 0x0601B909 RID: 112905 RVA: 0x00790968 File Offset: 0x0078EB68
	protected unsafe override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
		PasserbyNpcSpawnComponent component = TdUtils.GetComponent<PasserbyNpcSpawnComponent>(this.CreatureDataComp.GetPbEntityInitData().ComponentsData, EConfigComponent.PasserbyNpcSpawnComponent);
		if (component == null || component.SpawnConfig.MinDistance == null || component.SpawnConfig.MinDistance.Value == 0)
		{
			this.NeedCheckRange = false;
			return true;
		}
		this.MinDistanceSquared = (double)(component.SpawnConfig.MinDistance.Value * component.SpawnConfig.MinDistance.Value);
		foreach (IPasserbyNpcSpline passerbyNpcSpline in component.MoveConfig.Routes)
		{
			int splineEntityId = passerbyNpcSpline.SplineEntityId;
			GameSplineComponent gameSplineComponent = new GameSplineComponent(splineEntityId);
			if (!gameSplineComponent.Initialize())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "行人生成器获取样条信息错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplinePbDataId", splineEntityId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else if (gameSplineComponent.GetNumberOfSplinePoints() != 0)
			{
				this.SplineInfos.Add(new SplineStateInfo(splineEntityId, gameSplineComponent.GetWorldLocationAtSplinePoint(0)));
			}
		}
		if (this.SplineInfos.Count == 0)
		{
			this.NeedCheckRange = false;
		}
		return true;
	}

	// Token: 0x0601B90A RID: 112906 RVA: 0x00790B38 File Offset: 0x0078ED38
	protected override void OnTick(float delta)
	{
		if (!this.NeedCheckRange)
		{
			return;
		}
		foreach (SplineStateInfo splineStateInfo in this.SplineInfos)
		{
			if (this.IsNearestPlayerInRange(splineStateInfo.Location))
			{
				if (!splineStateInfo.InRange)
				{
					splineStateInfo.InRange = true;
					this.CreateAndSendRequest(splineStateInfo.PbDataId, true);
				}
			}
			else if (splineStateInfo.InRange)
			{
				splineStateInfo.InRange = false;
				this.CreateAndSendRequest(splineStateInfo.PbDataId, false);
			}
		}
	}

	// Token: 0x0601B90B RID: 112907 RVA: 0x00790BD8 File Offset: 0x0078EDD8
	private bool IsNearestPlayerInRange(global::Vector checkLocation)
	{
		double num = 3.402823466E+38;
		if (GameModeModel.Instance.IsMulti)
		{
			num = this.GetMinPlayerDistSquared(checkLocation).Item2;
		}
		else
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null && baseCharacter.IsValid())
			{
				baseCharacter.CharacterActorComponent.ActorLocationProxy.Subtraction(checkLocation, this.VectorCache);
				num = this.VectorCache.SizeSquared2D();
			}
		}
		return num < this.MinDistanceSquared;
	}

	// Token: 0x0601B90C RID: 112908 RVA: 0x00790C48 File Offset: 0x0078EE48
	private unsafe void CreateAndSendRequest(int splineId, bool inRange)
	{
		AccessPasserbyNpcSpawnerRequest accessPasserbyNpcSpawnerRequest = AccessPasserbyNpcSpawnerRequest.Create();
		accessPasserbyNpcSpawnerRequest.EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId());
		accessPasserbyNpcSpawnerRequest.SplineConfigId = splineId;
		accessPasserbyNpcSpawnerRequest.IsSplneNotValid = inRange;
		Net.Instance.Call(ERequestMessageId.AccessPasserbyNpcSpawnerRequest, accessPasserbyNpcSpawnerRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			AccessPasserbyNpcSpawnerResponse accessPasserbyNpcSpawnerResponse = (AccessPasserbyNpcSpawnerResponse)msg;
			if (accessPasserbyNpcSpawnerResponse == null)
			{
				return;
			}
			if (accessPasserbyNpcSpawnerResponse.ErrorCode != ErrorCode.Success)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.NPC;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "请求行人生成器生成NPC失败";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "CreatureId";
				BaseActorComponent actorComp = this.ActorComp;
				ptr = new ValueTuple<string, object>(item, (actorComp != null) ? new long?(actorComp.CreatureData.GetCreatureDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("SplineId", splineId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ErrorCode", accessPasserbyNpcSpawnerResponse.ErrorCode);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}, 0);
	}

	// Token: 0x0601B90D RID: 112909 RVA: 0x00790CC0 File Offset: 0x0078EEC0
	[return: TupleElementNames(new string[]
	{
		"PlayerEntity",
		"MinDistSquared"
	})]
	[return: Nullable(new byte[]
	{
		0,
		2
	})]
	private ValueTuple<EntityHandle, double> GetMinPlayerDistSquared(global::Vector selfLocation)
	{
		Dictionary<int, ScenePlayerData> scenePlayerDataMap = CreatureModel.Instance.ScenePlayerDataMap;
		SceneTeamModel instance = SceneTeamModel.Instance;
		EntityHandle item = null;
		double num = 3.402823466E+38;
		foreach (KeyValuePair<int, ScenePlayerData> keyValuePair in scenePlayerDataMap)
		{
			SceneTeamItem teamItem = instance.GetTeamItem((long)keyValuePair.Key, new GetTeamItemOptions
			{
				ParamType = ETeamParamType.PlayerId,
				IsControl = new bool?(true)
			});
			EntityHandle entityHandle = (teamItem != null) ? teamItem.EntityHandle : null;
			if (entityHandle != null)
			{
				entityHandle.Entity.GetComponent<CharacterActorComponent>().ActorLocationProxy.Subtraction(selfLocation, this.VectorCache);
				double num2 = this.VectorCache.SizeSquared2D();
				if (num2 < num)
				{
					num = num2;
					item = entityHandle;
				}
			}
		}
		return new ValueTuple<EntityHandle, double>(item, num);
	}

	// Token: 0x0601B90E RID: 112910 RVA: 0x00790D98 File Offset: 0x0078EF98
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		PasserbyGeneratorComponent passerbyGeneratorComponent = (PasserbyGeneratorComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (passerbyGeneratorComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CreatureDataComp"))
		{
			if (passerbyGeneratorComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SplineInfos") && passerbyGeneratorComponent.SplineInfos != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<SplineStateInfo>>(this.SplineInfos), "SplineInfos"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("MinDistanceSquared"))
		{
			this.MinDistanceSquared = passerbyGeneratorComponent.MinDistanceSquared;
		}
		if (base.CanResetComponentProperty("NeedCheckRange"))
		{
			this.NeedCheckRange = passerbyGeneratorComponent.NeedCheckRange;
		}
		return !base.CanResetComponentProperty("VectorCache") || passerbyGeneratorComponent.VectorCache == null || base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.VectorCache), "VectorCache");
	}

	// Token: 0x0400D8A9 RID: 55465
	[Nullable(2)]
	private BaseActorComponent ActorComp;

	// Token: 0x0400D8AA RID: 55466
	[Nullable(2)]
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400D8AB RID: 55467
	private readonly List<SplineStateInfo> SplineInfos = new List<SplineStateInfo>();

	// Token: 0x0400D8AC RID: 55468
	private double MinDistanceSquared;

	// Token: 0x0400D8AD RID: 55469
	private bool NeedCheckRange = true;

	// Token: 0x0400D8AE RID: 55470
	private readonly global::Vector VectorCache = global::Vector.Create();
}
