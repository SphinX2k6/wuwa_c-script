using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Framework;
using CSharpScript.Game;
using UnrealEngine;

// Token: 0x0200131E RID: 4894
[NullableContext(1)]
[Nullable(0)]
[TickController(0)]
public class HideActorController : ControllerBase
{
	// Token: 0x0600C057 RID: 49239 RVA: 0x0038D324 File Offset: 0x0038B524
	protected override bool OnInit()
	{
		this.IsHideMesh = false;
		this.IsHideEffect = false;
		this.HiddenEffectSet.Clear();
		this.HiddenMeshMap.Clear();
		this.IsHideNpcMesh = false;
		this.IsHideNpcEffect = false;
		this.HiddenNpcEffectSet.Clear();
		this.HiddenNpcMeshMap.Clear();
		this.HideActorParameterDirty = false;
		this.HideNpcParameterDirty = false;
		base.PauseTick();
		return true;
	}

	// Token: 0x0600C058 RID: 49240 RVA: 0x0038D390 File Offset: 0x0038B590
	protected override void OnTick(float delta)
	{
		if (this.IsHideMesh || this.IsHideEffect || this.IsHideNpcMesh || this.IsHideNpcEffect)
		{
			if (this.HideActorParameterDirty || this.HideNpcParameterDirty)
			{
				this.HideActorInternal(this.IsHideMesh, this.IsHideEffect, true);
				this.HideNpcActorInternal(this.IsHideMesh, this.IsHideEffect, true);
				return;
			}
			if (this.HideDistance > 0f)
			{
				TsBaseCharacter baseCharacter = Global.BaseCharacter;
				if (baseCharacter != null && baseCharacter.IsValid() && this.HideBasisBoneName != FNameUtil.NONE)
				{
					USkeletalMeshComponent mesh = Global.BaseCharacter.Mesh;
					if (mesh != null && mesh.DoesSocketExist(this.HideBasisBoneName))
					{
						Vector tmpVector = this.TmpVector;
						Vector vector = tmpVector;
						FVectorDouble fvectorDouble = Global.BaseCharacter.Mesh.D_GetSocketLocation(this.HideBasisBoneName);
						vector.FromUeVector(fvectorDouble);
						if (!this.HideLocation.Equals(tmpVector, 0.0001))
						{
							this.HideActorInternal(this.IsHideMesh, this.IsHideEffect, true);
							this.HideNpcActorInternal(this.IsHideMesh, this.IsHideEffect, true);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C059 RID: 49241 RVA: 0x0038D4B2 File Offset: 0x0038B6B2
	public void HideMesh()
	{
		if (this.IsHideMesh)
		{
			return;
		}
		this.IsHideMesh = true;
		this.HideActorInternal(true, false, false);
		base.ResumeTick();
	}

	// Token: 0x0600C05A RID: 49242 RVA: 0x0038D4D3 File Offset: 0x0038B6D3
	public void HideEffect()
	{
		if (this.IsHideEffect)
		{
			return;
		}
		this.IsHideEffect = true;
		this.HideActorInternal(false, true, false);
		base.ResumeTick();
	}

	// Token: 0x0600C05B RID: 49243 RVA: 0x0038D4F4 File Offset: 0x0038B6F4
	public void HideNpcMesh()
	{
		if (this.IsHideNpcMesh)
		{
			return;
		}
		this.IsHideNpcMesh = true;
		this.HideNpcActorInternal(true, false, false);
		base.ResumeTick();
	}

	// Token: 0x0600C05C RID: 49244 RVA: 0x0038D515 File Offset: 0x0038B715
	public void HideNpcEffect()
	{
		if (this.IsHideNpcEffect)
		{
			return;
		}
		this.IsHideNpcEffect = true;
		this.HideNpcActorInternal(false, true, false);
		base.ResumeTick();
	}

	// Token: 0x0600C05D RID: 49245 RVA: 0x0038D536 File Offset: 0x0038B736
	public void ShowMesh()
	{
		if (!this.IsHideMesh)
		{
			return;
		}
		this.IsHideMesh = false;
		this.ShowActorInternal(true, false);
	}

	// Token: 0x0600C05E RID: 49246 RVA: 0x0038D550 File Offset: 0x0038B750
	public void ShowEffect()
	{
		if (!this.IsHideEffect)
		{
			return;
		}
		this.IsHideEffect = false;
		this.ShowActorInternal(false, true);
	}

	// Token: 0x0600C05F RID: 49247 RVA: 0x0038D56A File Offset: 0x0038B76A
	public void ShowNpcMesh()
	{
		if (!this.IsHideNpcMesh)
		{
			return;
		}
		this.IsHideNpcMesh = false;
		this.ShowNpcActorInternal(true, false);
	}

	// Token: 0x0600C060 RID: 49248 RVA: 0x0038D584 File Offset: 0x0038B784
	public void ShowNpcEffect()
	{
		if (!this.IsHideNpcEffect)
		{
			return;
		}
		this.IsHideNpcEffect = false;
		this.ShowNpcActorInternal(false, true);
	}

	// Token: 0x0600C061 RID: 49249 RVA: 0x0038D59E File Offset: 0x0038B79E
	public void SetHideParameter(float distance, FName boneName)
	{
		if (this.HideDistance == distance && this.HideBasisBoneName == boneName)
		{
			return;
		}
		this.HideDistance = distance;
		this.HideBasisBoneName = boneName;
		this.HideActorParameterDirty = true;
		this.HideNpcParameterDirty = true;
		base.ResumeTick();
	}

	// Token: 0x0600C062 RID: 49250 RVA: 0x0038D5DA File Offset: 0x0038B7DA
	public void ResetHideParameter()
	{
		this.HideDistance = 0f;
		this.HideBasisBoneName = FNameUtil.NONE;
		this.HideActorParameterDirty = false;
		this.HideNpcParameterDirty = false;
		base.PauseTick();
	}

	// Token: 0x0600C063 RID: 49251 RVA: 0x0038D608 File Offset: 0x0038B808
	private void HideActorInternal(bool hideMesh, bool hideEffect, bool forceUpdateEntity = false)
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		HashSet<EntityHandle> characterValidHandles = this.GetCharacterValidHandles(forceUpdateEntity);
		if (this.HiddenMeshMap.Count > 0)
		{
			List<EntityHandle> list = new List<EntityHandle>();
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!characterValidHandles.Contains(key))
				{
					list.Add(key);
					if (key.Valid)
					{
						key.Entity.GetComponent<CharacterActorComponent>().EnableActor(value);
					}
				}
			}
			foreach (EntityHandle key2 in list)
			{
				this.HiddenMeshMap.Remove(key2);
			}
		}
		if (this.HiddenEffectSet.Count > 0)
		{
			List<EntityHandle> list2 = new List<EntityHandle>();
			foreach (EntityHandle entityHandle in this.HiddenEffectSet)
			{
				if (!characterValidHandles.Contains(entityHandle))
				{
					list2.Add(entityHandle);
					if (entityHandle.Valid)
					{
						this.HideEffectInternal(entityHandle, false);
					}
				}
			}
			foreach (EntityHandle item in list2)
			{
				this.HiddenEffectSet.Remove(item);
			}
		}
		foreach (EntityHandle entityHandle2 in characterValidHandles)
		{
			if (entityHandle2.Valid && entityHandle2.IsInit && entityHandle2.Entity.Active)
			{
				CharacterActorComponent component = entityHandle2.Entity.GetComponent<CharacterActorComponent>();
				TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
				if (tsBaseCharacter != null && tsBaseCharacter != Global.BaseCharacter && CampUtils.GetCampRelationship(tsBaseCharacter.Camp, Global.BaseCharacter.Camp) != ERelation.Friend)
				{
					if (!this.HiddenMeshMap.ContainsKey(entityHandle2) && hideMesh)
					{
						int value2 = component.DisableActor("[HideActorController] 隐藏Mesh");
						this.HiddenMeshMap[entityHandle2] = value2;
					}
					if (!this.HiddenEffectSet.Contains(entityHandle2) && hideEffect)
					{
						this.HideEffectInternal(entityHandle2, true);
						this.HiddenEffectSet.Add(entityHandle2);
					}
				}
			}
		}
	}

	// Token: 0x0600C064 RID: 49252 RVA: 0x0038D8CC File Offset: 0x0038BACC
	private void HideNpcActorInternal(bool hideMesh, bool hideEffect, bool forceUpdateEntity = false)
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		HashSet<EntityHandle> npcValidHandles = this.GetNpcValidHandles(forceUpdateEntity);
		if (this.HiddenNpcMeshMap.Count > 0)
		{
			List<EntityHandle> list = new List<EntityHandle>();
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenNpcMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (!npcValidHandles.Contains(key))
				{
					list.Add(key);
					if (key.Valid)
					{
						key.Entity.GetComponent<BaseCharacterComponent>().EnableActor(value);
						this.HideHeadInfoInternal(key, false);
					}
				}
			}
			foreach (EntityHandle key2 in list)
			{
				this.HiddenNpcMeshMap.Remove(key2);
			}
		}
		if (this.HiddenNpcEffectSet.Count > 0)
		{
			List<EntityHandle> list2 = new List<EntityHandle>();
			foreach (EntityHandle entityHandle in this.HiddenNpcEffectSet)
			{
				if (!npcValidHandles.Contains(entityHandle))
				{
					list2.Add(entityHandle);
					if (entityHandle.Valid)
					{
						this.HideEffectInternal(entityHandle, false);
					}
				}
			}
			foreach (EntityHandle item in list2)
			{
				this.HiddenNpcEffectSet.Remove(item);
			}
		}
		foreach (EntityHandle entityHandle2 in npcValidHandles)
		{
			if (entityHandle2.Valid && entityHandle2.IsInit && entityHandle2.Entity.Active)
			{
				BaseCharacterComponent component = entityHandle2.Entity.GetComponent<BaseCharacterComponent>();
				TsBaseCharacter tsBaseCharacter = (component != null) ? component.Actor : null;
				if (tsBaseCharacter != null && tsBaseCharacter != Global.BaseCharacter)
				{
					CreatureDataComponent component2 = entityHandle2.Entity.GetComponent<CreatureDataComponent>();
					if (component2 != null && component2.Valid && component2.IsNpc())
					{
						if (!this.HiddenNpcMeshMap.ContainsKey(entityHandle2) && hideMesh)
						{
							this.HideHeadInfoInternal(entityHandle2, true);
							int value2 = component.DisableActor("[HideNpcActorController] 隐藏NpcMesh");
							this.HiddenNpcMeshMap[entityHandle2] = value2;
						}
						if (!this.HiddenNpcEffectSet.Contains(entityHandle2) && hideEffect)
						{
							this.HideEffectInternal(entityHandle2, true);
							this.HiddenNpcEffectSet.Add(entityHandle2);
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C065 RID: 49253 RVA: 0x0038DBF4 File Offset: 0x0038BDF4
	private void ShowActorInternal(bool showMesh, bool showEffect)
	{
		if (showMesh)
		{
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (key.Valid)
				{
					key.Entity.GetComponent<CharacterActorComponent>().EnableActor(value);
				}
			}
			this.HiddenMeshMap.Clear();
		}
		if (showEffect)
		{
			foreach (EntityHandle entityHandle in this.HiddenEffectSet)
			{
				if (entityHandle.Valid)
				{
					this.HideEffectInternal(entityHandle, false);
				}
			}
			this.HiddenEffectSet.Clear();
		}
	}

	// Token: 0x0600C066 RID: 49254 RVA: 0x0038DCD8 File Offset: 0x0038BED8
	private void ShowNpcActorInternal(bool showMesh, bool showEffect)
	{
		if (showMesh)
		{
			foreach (KeyValuePair<EntityHandle, int> keyValuePair in this.HiddenNpcMeshMap)
			{
				EntityHandle key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (key.Valid)
				{
					key.Entity.GetComponent<BaseCharacterComponent>().EnableActor(value);
					this.HideHeadInfoInternal(key, false);
				}
			}
			this.HiddenNpcMeshMap.Clear();
		}
		if (showEffect)
		{
			foreach (EntityHandle entityHandle in this.HiddenNpcEffectSet)
			{
				if (entityHandle.Valid)
				{
					this.HideEffectInternal(entityHandle, false);
				}
			}
			this.HiddenNpcEffectSet.Clear();
		}
	}

	// Token: 0x0600C067 RID: 49255 RVA: 0x0038DDC4 File Offset: 0x0038BFC4
	private unsafe HashSet<EntityHandle> GetCharacterValidHandles(bool forceUpdateEntity)
	{
		if (this.LastFrameUpdateActor == (long)Time.Instance.Frame && !this.HideActorParameterDirty && !forceUpdateEntity)
		{
			return this.CharacterHandles;
		}
		this.LastFrameUpdateActor = (long)Time.Instance.Frame;
		this.HideActorParameterDirty = false;
		this.CharacterHandles.Clear();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (this.HideDistance > 0f && baseCharacter != null && baseCharacter.IsValid() && this.HideBasisBoneName != FNameUtil.NONE)
		{
			USkeletalMeshComponent mesh = baseCharacter.Mesh;
			if (mesh != null && mesh.DoesSocketExist(this.HideBasisBoneName))
			{
				Vector hideLocation = this.HideLocation;
				Vector vector = hideLocation;
				FVectorDouble fvectorDouble = baseCharacter.Mesh.D_GetSocketLocation(this.HideBasisBoneName);
				vector.FromUeVector(fvectorDouble);
				CreatureModel.Instance.GetEntitiesInRangeWithLocation(hideLocation, this.HideDistance, HideActorController.CHARACTER, this.CharacterHandles, true);
				return this.CharacterHandles;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[HideActorController][Actor]隐藏全部角色";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("baseCharacter", (baseCharacter != null) ? new bool?(baseCharacter.IsValid()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HideDistance", this.HideDistance);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HideBasisBoneName", this.HideBasisBoneName);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item = "SocketExist";
		bool? flag;
		if (baseCharacter == null)
		{
			flag = null;
		}
		else
		{
			USkeletalMeshComponent mesh2 = baseCharacter.Mesh;
			flag = ((mesh2 != null) ? new bool?(mesh2.DoesSocketExist(this.HideBasisBoneName)) : null);
		}
		ptr = new ValueTuple<string, object>(item, flag);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities != null)
		{
			foreach (EntityHandle item2 in allEntities)
			{
				this.CharacterHandles.Add(item2);
			}
		}
		return this.CharacterHandles;
	}

	// Token: 0x0600C068 RID: 49256 RVA: 0x0038DFF4 File Offset: 0x0038C1F4
	private unsafe HashSet<EntityHandle> GetNpcValidHandles(bool forceUpdateEntity)
	{
		if (this.LastFrameUpdateNpc == (long)Time.Instance.Frame && !this.HideNpcParameterDirty && !forceUpdateEntity)
		{
			return this.NpcHandles;
		}
		this.LastFrameUpdateNpc = (long)Time.Instance.Frame;
		this.HideNpcParameterDirty = false;
		this.NpcHandles.Clear();
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (this.HideDistance > 0f && baseCharacter != null && baseCharacter.IsValid() && this.HideBasisBoneName != FNameUtil.NONE)
		{
			USkeletalMeshComponent mesh = baseCharacter.Mesh;
			if (mesh != null && mesh.DoesSocketExist(this.HideBasisBoneName))
			{
				Vector hideLocation = this.HideLocation;
				Vector vector = hideLocation;
				FVectorDouble fvectorDouble = baseCharacter.Mesh.D_GetSocketLocation(this.HideBasisBoneName);
				vector.FromUeVector(fvectorDouble);
				CreatureModel.Instance.GetEntitiesInRangeWithLocation(hideLocation, this.HideDistance, HideActorController.NPC, this.NpcHandles, true);
				return this.NpcHandles;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Character;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[HideActorController][Npc]隐藏全部角色";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("baseCharacter", (baseCharacter != null) ? new bool?(baseCharacter.IsValid()) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HideDistance", this.HideDistance);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HideBasisBoneName", this.HideBasisBoneName);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item = "SocketExist";
		bool? flag;
		if (baseCharacter == null)
		{
			flag = null;
		}
		else
		{
			USkeletalMeshComponent mesh2 = baseCharacter.Mesh;
			flag = ((mesh2 != null) ? new bool?(mesh2.DoesSocketExist(this.HideBasisBoneName)) : null);
		}
		ptr = new ValueTuple<string, object>(item, flag);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
		if (allEntities != null)
		{
			foreach (EntityHandle item2 in allEntities)
			{
				this.NpcHandles.Add(item2);
			}
		}
		return this.NpcHandles;
	}

	// Token: 0x0600C069 RID: 49257 RVA: 0x0038E224 File Offset: 0x0038C424
	private void HideEffectInternal(EntityHandle handle, bool hidden)
	{
		CharacterSkillComponent component = handle.Entity.GetComponent<CharacterSkillComponent>();
		if (component != null)
		{
			Skill currentSkill = component.CurrentSkill;
			if (currentSkill != null)
			{
				currentSkill.SetEffectHidden(hidden);
			}
		}
		CharacterGameplayCueComponent component2 = handle.Entity.GetComponent<CharacterGameplayCueComponent>();
		if (component2 == null)
		{
			return;
		}
		component2.SetHidden(hidden);
	}

	// Token: 0x0600C06A RID: 49258 RVA: 0x0038E25E File Offset: 0x0038C45E
	private void HideHeadInfoInternal(EntityHandle handle, bool hidden)
	{
		PawnHeadInfoComponent component = handle.Entity.GetComponent<PawnHeadInfoComponent>();
		if (component == null)
		{
			return;
		}
		component.EnableHeadInfo(!hidden);
	}

	// Token: 0x0600C06B RID: 49259 RVA: 0x0038E279 File Offset: 0x0038C479
	protected override bool OnClear()
	{
		this.IsHideMesh = false;
		this.IsHideEffect = false;
		this.ShowActorInternal(true, true);
		this.IsHideNpcMesh = false;
		this.IsHideNpcEffect = false;
		this.ShowNpcActorInternal(true, true);
		this.ResetHideParameter();
		return true;
	}

	// Token: 0x170012B3 RID: 4787
	// (get) Token: 0x0600C06C RID: 49260 RVA: 0x0038E2AE File Offset: 0x0038C4AE
	public static HideActorController Instance
	{
		get
		{
			return HideActorController._Instance;
		}
	}

	// Token: 0x0600C06D RID: 49261 RVA: 0x0038E2B5 File Offset: 0x0038C4B5
	public static HideActorController GetOrCreateInstance()
	{
		if (HideActorController._Instance == null)
		{
			HideActorController.CreateInstance();
		}
		return HideActorController._Instance;
	}

	// Token: 0x0600C06E RID: 49262 RVA: 0x0038E2C9 File Offset: 0x0038C4C9
	public static bool CreateInstance()
	{
		if (HideActorController._Instance != null)
		{
			return true;
		}
		HideActorController._Instance = new HideActorController();
		return true;
	}

	// Token: 0x0600C06F RID: 49263 RVA: 0x0038E2DF File Offset: 0x0038C4DF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C070 RID: 49264 RVA: 0x0038E2E1 File Offset: 0x0038C4E1
	public static void ResetStaticDefaultValue()
	{
		HideActorController._Instance = null;
	}

	// Token: 0x0600C071 RID: 49265 RVA: 0x0038E2E9 File Offset: 0x0038C4E9
	static HideActorController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HideActorController.CreateStaticDefaultValue), new Action(HideActorController.ResetStaticDefaultValue));
	}

	// Token: 0x04006E68 RID: 28264
	private static readonly EEntityTypeQuery CHARACTER = EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss | EEntityTypeQuery.Team;

	// Token: 0x04006E69 RID: 28265
	private static readonly EEntityTypeQuery NPC = EEntityTypeQuery.SimpleNPC | EEntityTypeQuery.NormalNPC | EEntityTypeQuery.PasserbyNPC;

	// Token: 0x04006E6A RID: 28266
	private bool IsHideMesh;

	// Token: 0x04006E6B RID: 28267
	private bool IsHideEffect;

	// Token: 0x04006E6C RID: 28268
	private readonly HashSet<EntityHandle> HiddenEffectSet = new HashSet<EntityHandle>();

	// Token: 0x04006E6D RID: 28269
	private readonly Dictionary<EntityHandle, int> HiddenMeshMap = new Dictionary<EntityHandle, int>();

	// Token: 0x04006E6E RID: 28270
	private bool IsHideNpcMesh;

	// Token: 0x04006E6F RID: 28271
	private bool IsHideNpcEffect;

	// Token: 0x04006E70 RID: 28272
	private readonly HashSet<EntityHandle> HiddenNpcEffectSet = new HashSet<EntityHandle>();

	// Token: 0x04006E71 RID: 28273
	private readonly Dictionary<EntityHandle, int> HiddenNpcMeshMap = new Dictionary<EntityHandle, int>();

	// Token: 0x04006E72 RID: 28274
	private float HideDistance;

	// Token: 0x04006E73 RID: 28275
	private FName HideBasisBoneName = FNameUtil.NONE;

	// Token: 0x04006E74 RID: 28276
	private long LastFrameUpdateActor;

	// Token: 0x04006E75 RID: 28277
	private long LastFrameUpdateNpc;

	// Token: 0x04006E76 RID: 28278
	private bool HideActorParameterDirty;

	// Token: 0x04006E77 RID: 28279
	private bool HideNpcParameterDirty;

	// Token: 0x04006E78 RID: 28280
	private readonly HashSet<EntityHandle> CharacterHandles = new HashSet<EntityHandle>();

	// Token: 0x04006E79 RID: 28281
	private readonly HashSet<EntityHandle> NpcHandles = new HashSet<EntityHandle>();

	// Token: 0x04006E7A RID: 28282
	private readonly Vector HideLocation = Vector.Create();

	// Token: 0x04006E7B RID: 28283
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x04006E7C RID: 28284
	private const bool Debug = false;

	// Token: 0x04006E7D RID: 28285
	[Nullable(2)]
	private static HideActorController _Instance;
}
