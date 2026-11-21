using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002523 RID: 9507
public class GameplayCueReference : GameplayCueBase
{
	// Token: 0x06017835 RID: 96309 RVA: 0x006F053C File Offset: 0x006EE73C
	protected override void OnInit()
	{
		int parametersLength = this.CueConfig.ParametersLength;
		if (parametersLength > 0)
		{
			this.OtherEntityType = (GameplayCueReference.EOtherEntityType)int.Parse(this.CueConfig.Parameters(0));
		}
		if (parametersLength > 1)
		{
			foreach (string s in this.CueConfig.Parameters(1).Split('#', StringSplitOptions.None))
			{
				this.ReferenceCueConfigIds.Add(long.Parse(s));
			}
		}
	}

	// Token: 0x06017836 RID: 96310 RVA: 0x006F05AC File Offset: 0x006EE7AC
	protected override void OnCreate()
	{
		if (this.ReferenceCueConfigIds.Count > 0)
		{
			BaseGameplayCueComponent gameplayCueComponent = this.GetGameplayCueComponent();
			if (gameplayCueComponent != null)
			{
				this.OtherEntityCueComp = new WeakReference<BaseGameplayCueComponent>(gameplayCueComponent);
				foreach (long cueId in this.ReferenceCueConfigIds)
				{
					int num = gameplayCueComponent.AddCue(cueId, new GameplayCueParam?(new GameplayCueParam
					{
						Instant = this.IsInstant
					}));
					if (num != 0 && num != -1)
					{
						this.ReferenceCueHandles.Add(num);
					}
				}
			}
		}
	}

	// Token: 0x06017837 RID: 96311 RVA: 0x006F0654 File Offset: 0x006EE854
	protected override void OnDestroy()
	{
		BaseGameplayCueComponent baseGameplayCueComponent;
		if (this.ReferenceCueHandles.Count > 0 && this.OtherEntityCueComp != null && this.OtherEntityCueComp.TryGetTarget(out baseGameplayCueComponent))
		{
			foreach (int num in this.ReferenceCueHandles)
			{
				baseGameplayCueComponent.RemoveCueByHandle((long)num);
			}
		}
		this.ReferenceCueConfigIds.Clear();
		this.ReferenceCueHandles.Clear();
		this.OtherEntityCueComp = null;
	}

	// Token: 0x06017838 RID: 96312 RVA: 0x006F06EC File Offset: 0x006EE8EC
	[NullableContext(2)]
	private BaseGameplayCueComponent GetGameplayCueComponent()
	{
		if (this.OtherEntityType != GameplayCueReference.EOtherEntityType.Vehicle)
		{
			return null;
		}
		WorldEntity entity = this.EntityHandle.Entity;
		if (entity == null)
		{
			return null;
		}
		CharacterDriveVehicleComponent component = entity.GetComponent<CharacterDriveVehicleComponent>();
		if (component == null)
		{
			return null;
		}
		Entity vehicleEntity = component.VehicleEntity;
		if (vehicleEntity == null)
		{
			return null;
		}
		return vehicleEntity.GetComponent<BaseGameplayCueComponent>();
	}

	// Token: 0x0400C80C RID: 51212
	private GameplayCueReference.EOtherEntityType OtherEntityType = GameplayCueReference.EOtherEntityType.None;

	// Token: 0x0400C80D RID: 51213
	[Nullable(1)]
	private readonly List<long> ReferenceCueConfigIds = new List<long>();

	// Token: 0x0400C80E RID: 51214
	[Nullable(1)]
	private readonly List<int> ReferenceCueHandles = new List<int>();

	// Token: 0x0400C80F RID: 51215
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private WeakReference<BaseGameplayCueComponent> OtherEntityCueComp;

	// Token: 0x02008839 RID: 34873
	private enum EOtherEntityType
	{
		// Token: 0x0402B929 RID: 178473
		None = -1,
		// Token: 0x0402B92A RID: 178474
		Vehicle
	}
}
