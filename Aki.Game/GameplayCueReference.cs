using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002FCF RID: 12239
public class GameplayCueReference : GameplayCueBase
{
	// Token: 0x06019F23 RID: 106275 RVA: 0x006C9C48 File Offset: 0x006C7E48
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

	// Token: 0x06019F24 RID: 106276 RVA: 0x006C9CB8 File Offset: 0x006C7EB8
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

	// Token: 0x06019F25 RID: 106277 RVA: 0x006C9D60 File Offset: 0x006C7F60
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

	// Token: 0x06019F26 RID: 106278 RVA: 0x006C9DF8 File Offset: 0x006C7FF8
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

	// Token: 0x0400C463 RID: 50275
	private GameplayCueReference.EOtherEntityType OtherEntityType = GameplayCueReference.EOtherEntityType.None;

	// Token: 0x0400C464 RID: 50276
	[Nullable(1)]
	private readonly List<long> ReferenceCueConfigIds = new List<long>();

	// Token: 0x0400C465 RID: 50277
	[Nullable(1)]
	private readonly List<int> ReferenceCueHandles = new List<int>();

	// Token: 0x0400C466 RID: 50278
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private WeakReference<BaseGameplayCueComponent> OtherEntityCueComp;

	// Token: 0x02009618 RID: 38424
	private enum EOtherEntityType
	{
		// Token: 0x0403029C RID: 197276
		None = -1,
		// Token: 0x0403029D RID: 197277
		Vehicle
	}
}
