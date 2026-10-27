using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;

// Token: 0x02002302 RID: 8962
public class PanelQteTimeDilation
{
	// Token: 0x06011AE6 RID: 72422 RVA: 0x004586B9 File Offset: 0x004568B9
	public void Init()
	{
		this.WorldTimeDilation = 1f;
		this.EntityTimeDilation = 1;
	}

	// Token: 0x06011AE7 RID: 72423 RVA: 0x004586D2 File Offset: 0x004568D2
	public void Clear()
	{
	}

	// Token: 0x06011AE8 RID: 72424 RVA: 0x004586D4 File Offset: 0x004568D4
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

	// Token: 0x06011AE9 RID: 72425 RVA: 0x004587B4 File Offset: 0x004569B4
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

	// Token: 0x06011AEA RID: 72426 RVA: 0x00458859 File Offset: 0x00456A59
	public Number GetWorldTimeDilation()
	{
		return this.WorldTimeDilation;
	}

	// Token: 0x06011AEB RID: 72427 RVA: 0x00458866 File Offset: 0x00456A66
	public Number GetEntityTimeDilation()
	{
		return this.EntityTimeDilation;
	}

	// Token: 0x04008626 RID: 34342
	private float WorldTimeDilation;

	// Token: 0x04008627 RID: 34343
	private Number EntityTimeDilation = 0;

	// Token: 0x04008628 RID: 34344
	[Nullable(2)]
	private EntityHandle EntityHandle;

	// Token: 0x04008629 RID: 34345
	private int TimeScaleId;

	// Token: 0x0400862A RID: 34346
	private const int MAX_TIME_SCALE_TIME = 20;

	// Token: 0x0400862B RID: 34347
	private const int TIME_SCALE_PRIORITY = 100;
}
