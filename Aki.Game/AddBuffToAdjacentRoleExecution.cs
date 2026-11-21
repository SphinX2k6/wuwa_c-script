using System;
using System.Runtime.CompilerServices;

// Token: 0x020024E2 RID: 9442
[NullableContext(1)]
[Nullable(0)]
public class AddBuffToAdjacentRoleExecution : InitExecution
{
	// Token: 0x060176A9 RID: 95913 RVA: 0x006E5ED9 File Offset: 0x006E40D9
	public AddBuffToAdjacentRoleExecution(RequireAndLimits requireAndLimits) : base(requireAndLimits)
	{
	}

	// Token: 0x060176AA RID: 95914 RVA: 0x006E5EED File Offset: 0x006E40ED
	protected override bool CheckExecutable()
	{
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		return ownerBuffComponent != null && ownerBuffComponent.HasBuffAuthority();
	}

	// Token: 0x060176AB RID: 95915 RVA: 0x006E5F00 File Offset: 0x006E4100
	protected override void InitParameters(ExtraEffectParameters parameters)
	{
		string[] extraEffectParameters_ = parameters.ExtraEffectParameters_;
		if (extraEffectParameters_ == null || extraEffectParameters_.Length == 0)
		{
			return;
		}
		this.Distance = float.Parse(extraEffectParameters_[0]);
		if (extraEffectParameters_.Length > 1 && !string.IsNullOrEmpty(extraEffectParameters_[1]))
		{
			string[] array = extraEffectParameters_[1].Split('#', StringSplitOptions.None);
			this.ApplyRoleFormationType = new ERoleFormationType[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				this.ApplyRoleFormationType[i] = (ERoleFormationType)int.Parse(array[i]);
			}
		}
		else
		{
			this.ApplyRoleFormationType = new ERoleFormationType[]
			{
				ERoleFormationType.Front,
				ERoleFormationType.Back,
				ERoleFormationType.Stay
			};
		}
		if (extraEffectParameters_.Length > 2 && !string.IsNullOrEmpty(extraEffectParameters_[2]))
		{
			string[] array2 = extraEffectParameters_[2].Split('#', StringSplitOptions.None);
			this.ApplyBuffId = new long[array2.Length];
			for (int j = 0; j < array2.Length; j++)
			{
				this.ApplyBuffId[j] = long.Parse(array2[j]);
			}
			return;
		}
		this.ApplyBuffId = new long[]
		{
			this.BuffId
		};
	}

	// Token: 0x060176AC RID: 95916 RVA: 0x006E5FEC File Offset: 0x006E41EC
	[return: Nullable(2)]
	public override object OnExecute(params object[] args)
	{
		bool flag;
		bool flag2;
		if (args.Length != 0)
		{
			object obj = args[0];
			if (obj is bool)
			{
				flag = (bool)obj;
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
		}
		else
		{
			flag2 = false;
		}
		if (!flag2 || !flag)
		{
			return null;
		}
		IBuffComponent ownerBuffComponent = this.OwnerBuffComponent;
		Entity entity = (ownerBuffComponent != null) ? ownerBuffComponent.GetEntity() : null;
		int? num;
		if (entity == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			num = ((component != null) ? new int?(component.GetPlayerId()) : null);
		}
		int? num2 = num;
		int valueOrDefault = num2.GetValueOrDefault();
		ScenePlayerData scenePlayerData = CreatureModel.Instance.GetScenePlayerData(valueOrDefault);
		Vector vector = (scenePlayerData != null) ? scenePlayerData.GetLocation() : null;
		if (entity == null || vector == null)
		{
			return null;
		}
		foreach (SceneTeamItem sceneTeamItem in SceneTeamModel.Instance.GetTeamItemsInRange(vector, this.Distance))
		{
			if (sceneTeamItem.GetPlayerId() != valueOrDefault)
			{
				EntityHandle entityHandle = sceneTeamItem.EntityHandle;
				if (entityHandle != null && entityHandle.Entity != null)
				{
					CreatureDataComponent component2 = entityHandle.Entity.GetComponent<CreatureDataComponent>();
					if (component2 != null && component2.IsRole() && entityHandle.Id != entity.Id)
					{
						CharacterBuffComponent component3 = entityHandle.Entity.GetComponent<CharacterBuffComponent>();
						if (component3 != null)
						{
							foreach (long num3 in this.ApplyBuffId)
							{
								BaseBuffComponent baseBuffComponent = component3;
								long buffId = num3;
								IActiveBuff buff = this.Buff;
								int? stackCount = null;
								bool isIterable = false;
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
								defaultInterpolatedStringHandler.AppendLiteral("Buff");
								defaultInterpolatedStringHandler.AppendFormatted<long>(this.BuffId);
								defaultInterpolatedStringHandler.AppendLiteral("的额外效果导致的共享添加");
								baseBuffComponent.AddIterativeBuff(buffId, buff, stackCount, isIterable, defaultInterpolatedStringHandler.ToStringAndClear(), null, null);
							}
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x0400C6E9 RID: 50921
	public long[] ApplyBuffId = Array.Empty<long>();

	// Token: 0x0400C6EA RID: 50922
	public float Distance;

	// Token: 0x0400C6EB RID: 50923
	[Nullable(2)]
	public ERoleFormationType[] ApplyRoleFormationType;
}
