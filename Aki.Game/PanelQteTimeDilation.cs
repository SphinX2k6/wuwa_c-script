using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x020017E6 RID: 6118
public class PanelQteTimeDilation
{
	// Token: 0x0600EF7E RID: 61310 RVA: 0x00465399 File Offset: 0x00463599
	public void Init()
	{
		this.WorldTimeDilation = 1f;
		this.EntityTimeDilation = 1;
	}

	// Token: 0x0600EF7F RID: 61311 RVA: 0x004653B2 File Offset: 0x004635B2
	public void Clear()
	{
	}

	// Token: 0x0600EF80 RID: 61312 RVA: 0x004653B4 File Offset: 0x004635B4
	[NullableContext(1)]
	public void Start(PanelQteContext context)
	{
		this.WorldTimeDilation = context.Config.WorldTimeDilation;
		if (this.WorldTimeDilation >= 1f || this.WorldTimeDilation < 0f)
		{
			this.WorldTimeDilation = 1f;
			return;
		}
		if (GameModeModel.Instance.IsMulti)
		{
			this.EntityTimeDilation = this.WorldTimeDilation;
			this.WorldTimeDilation = 1f;
			this.EntityHandle = SceneTeamModel.Instance.GetCurrentEntity;
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.IsInit)
			{
				PawnTimeScaleComponent component = this.EntityHandle.Entity.GetComponent<PawnTimeScaleComponent>();
				if (component != null)
				{
					this.TimeScaleId = component.SetTimeScale(100, this.EntityTimeDilation, null, 20f, ETimeScaleSourceType.PanelQte, false, false);
					return;
				}
			}
		}
		else
		{
			EventSystem.Instance.Emit<float>(EEventName.UpdatePanelQteWorldTimeDilation, this.WorldTimeDilation);
		}
	}

	// Token: 0x0600EF81 RID: 61313 RVA: 0x00465494 File Offset: 0x00463694
	public void Stop()
	{
		if (this.WorldTimeDilation != 1f)
		{
			this.WorldTimeDilation = 1f;
			EventSystem.Instance.Emit<float>(EEventName.UpdatePanelQteWorldTimeDilation, this.WorldTimeDilation);
		}
		if (this.EntityTimeDilation != 1)
		{
			this.EntityTimeDilation = 1;
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.IsInit && this.TimeScaleId > 0)
			{
				PawnTimeScaleComponent component = this.EntityHandle.Entity.GetComponent<PawnTimeScaleComponent>();
				if (component != null)
				{
					component.RemoveTimeScale(this.TimeScaleId);
				}
			}
			this.EntityHandle = null;
			this.TimeScaleId = 0;
		}
	}

	// Token: 0x0600EF82 RID: 61314 RVA: 0x00465539 File Offset: 0x00463739
	public Number GetWorldTimeDilation()
	{
		return this.WorldTimeDilation;
	}

	// Token: 0x0600EF83 RID: 61315 RVA: 0x00465546 File Offset: 0x00463746
	public Number GetEntityTimeDilation()
	{
		return this.EntityTimeDilation;
	}

	// Token: 0x04008764 RID: 34660
	private float WorldTimeDilation;

	// Token: 0x04008765 RID: 34661
	private Number EntityTimeDilation = 0;

	// Token: 0x04008766 RID: 34662
	[Nullable(2)]
	private EntityHandle EntityHandle;

	// Token: 0x04008767 RID: 34663
	private int TimeScaleId;

	// Token: 0x04008768 RID: 34664
	private const int MAX_TIME_SCALE_TIME = 20;

	// Token: 0x04008769 RID: 34665
	private const int TIME_SCALE_PRIORITY = 100;
}
