using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Camera;

// Token: 0x0200251B RID: 9499
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueMagnitude : GameplayCueBase
{
	// Token: 0x060177E2 RID: 96226 RVA: 0x006EEA4C File Offset: 0x006ECC4C
	protected override void OnInit()
	{
		this.Min = (float)this.CueConfig.Min;
		this.Max = (float)this.CueConfig.Max;
	}

	// Token: 0x060177E3 RID: 96227 RVA: 0x006EEA74 File Offset: 0x006ECC74
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (this.BuffIdNeedTick != 0)
		{
			float num = this.ComputeMagnitudeValueByBuff();
			this.SetMagnitude(num, false);
			if (num == 0f)
			{
				this.BuffIdNeedTick = 0;
				return;
			}
		}
		else if (this.CameraPitchTick)
		{
			if (!MathUtils.Instance.IsNearlyEqual((double)this.Value, (double)CameraController.Instance.MainModel.CameraRotator.Pitch, null))
			{
				this.SetMagnitude(CameraController.Instance.MainModel.CameraRotator.Pitch, false);
				return;
			}
		}
		else if (this.ExistFlowTimeTick)
		{
			this.SetMagnitude((float)Time.Instance.FlowTime - this.StartFlowTime, false);
		}
	}

	// Token: 0x060177E4 RID: 96228 RVA: 0x006EEB2B File Offset: 0x006ECD2B
	protected override void OnCreate()
	{
		this.InitComponent();
		this.IsMagnified = this.StartMagnify();
	}

	// Token: 0x060177E5 RID: 96229 RVA: 0x006EEB3F File Offset: 0x006ECD3F
	protected override void OnDestroy()
	{
		this.StopMagnify();
	}

	// Token: 0x060177E6 RID: 96230 RVA: 0x006EEB47 File Offset: 0x006ECD47
	protected virtual void OnSetMagnitude(float normalizedValue)
	{
	}

	// Token: 0x060177E7 RID: 96231 RVA: 0x006EEB49 File Offset: 0x006ECD49
	[NullableContext(1)]
	public override void OnChangeRole(EntityHandle newEntityHandle)
	{
		this.StopMagnify();
		base.OnChangeRole(newEntityHandle);
		this.InitComponent();
		this.IsMagnified = this.StartMagnify();
	}

	// Token: 0x060177E8 RID: 96232 RVA: 0x006EEB6A File Offset: 0x006ECD6A
	protected virtual bool UseMagnitude()
	{
		return this.CueConfig.Magni != 0 && !this.IsInstant;
	}

	// Token: 0x060177E9 RID: 96233 RVA: 0x006EEB84 File Offset: 0x006ECD84
	[NullableContext(1)]
	public virtual void SyncMagnitude(GameplayCueMagnitude cueRef)
	{
	}

	// Token: 0x060177EA RID: 96234 RVA: 0x006EEB86 File Offset: 0x006ECD86
	private bool HasMagnitudeComponent()
	{
		return this.AttributeComponent != null && this.BuffComponent != null && this.TagComponent != null;
	}

	// Token: 0x060177EB RID: 96235 RVA: 0x006EEBA4 File Offset: 0x006ECDA4
	private bool StartMagnify()
	{
		if (!this.UseMagnitude() || !this.HasMagnitudeComponent())
		{
			return false;
		}
		float value;
		switch (this.CueConfig.Magni)
		{
		case 1:
			if (!this.Check(this.CueConfig.AttrId != 0, "属性Id没填！"))
			{
				return false;
			}
			this.MaxAttributeId = CharacterAttributeTypes.attributeIdsWithMax.GetValueOrNull((EAttributeType)this.CueConfig.AttrId);
			if (this.CueConfig.BListenAttr)
			{
				this.AttributeComponent.AddListener((EAttributeType)this.CueConfig.AttrId, new Action<EAttributeType, float, float>(this.OnAttributeChanged), "GameplayCueMagnitude");
				if (this.MaxAttributeId != null)
				{
					this.AttributeComponent.AddListener(this.MaxAttributeId.Value, new Action<EAttributeType, float, float>(this.OnAttributeChanged), "GameplayCueMagnitudeMax");
				}
			}
			value = this.AttributeComponent.GetCurrentValue((EAttributeType)this.CueConfig.AttrId);
			if (this.MaxAttributeId != null)
			{
				this.Max = this.AttributeComponent.GetCurrentValue(this.MaxAttributeId.Value);
			}
			break;
		case 2:
		{
			if (!this.Check(!string.IsNullOrEmpty(this.CueConfig.Tag), "Tag没填！"))
			{
				return false;
			}
			int tagIdByName = GameplayTagUtils.GetTagIdByName(this.CueConfig.Tag);
			if (this.CueConfig.BListenAttr)
			{
				this.TagCountChangedTask = this.TagComponent.ListenForTagAnyCountChanged(tagIdByName, new BaseTagComponent.TTagChangedCallback(this.OnTagCountChanged));
			}
			value = (float)this.TagComponent.GetTagCount(tagIdByName);
			break;
		}
		case 3:
		{
			IActiveBuff buffByHandle = this.BuffComponent.GetBuffByHandle(this.BuffHandleId);
			int? num = (buffByHandle != null) ? new int?(buffByHandle.Level) : null;
			value = ((num != null) ? ((float)num.GetValueOrDefault()) : 1f);
			break;
		}
		case 4:
			if (this.CueConfig.BListenAttr)
			{
				this.BuffIdNeedTick = this.BuffHandleId;
			}
			value = this.ComputeMagnitudeValueByBuff();
			break;
		case 5:
			this.CameraPitchTick = this.CueConfig.BListenAttr;
			value = CameraController.Instance.MainModel.CameraRotator.Pitch;
			break;
		case 6:
			this.StartFlowTime = (float)Time.Instance.FlowTime;
			this.ExistFlowTimeTick = true;
			value = 0f;
			break;
		default:
			return false;
		}
		return this.SetMagnitude(value, true);
	}

	// Token: 0x060177EC RID: 96236 RVA: 0x006EEE08 File Offset: 0x006ED008
	private void StopMagnify()
	{
		if (!this.IsMagnified)
		{
			return;
		}
		switch (this.CueConfig.Magni)
		{
		case 1:
			if (this.CueConfig.BListenAttr)
			{
				this.AttributeComponent.RemoveListener((EAttributeType)this.CueConfig.AttrId, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
				if (this.MaxAttributeId != null)
				{
					this.AttributeComponent.RemoveListener(this.MaxAttributeId.Value, new Action<EAttributeType, float, float>(this.OnAttributeChanged));
					return;
				}
			}
			break;
		case 2:
			if (this.CueConfig.BListenAttr && this.TagCountChangedTask != null)
			{
				this.TagCountChangedTask.EndTask();
				this.TagCountChangedTask = null;
				return;
			}
			break;
		case 3:
			break;
		case 4:
			if (this.CueConfig.BListenAttr)
			{
				this.BuffIdNeedTick = 0;
				return;
			}
			break;
		case 5:
			this.CameraPitchTick = false;
			return;
		case 6:
			this.ExistFlowTimeTick = false;
			break;
		default:
			return;
		}
	}

	// Token: 0x060177ED RID: 96237 RVA: 0x006EEEFC File Offset: 0x006ED0FC
	private void OnAttributeChanged(EAttributeType attributeId, float newValue, float oldValue)
	{
		EAttributeType? maxAttributeId = this.MaxAttributeId;
		if (attributeId == maxAttributeId.GetValueOrDefault() & maxAttributeId != null)
		{
			this.Max = newValue;
		}
		else
		{
			this.Value = newValue;
		}
		this.SetMagnitude(this.Value, true);
	}

	// Token: 0x060177EE RID: 96238 RVA: 0x006EEF42 File Offset: 0x006ED142
	private void OnTagCountChanged(int tagCount, int tagId, int exactTagId, int oldCount)
	{
		this.SetMagnitude((float)tagCount, true);
	}

	// Token: 0x060177EF RID: 96239 RVA: 0x006EEF50 File Offset: 0x006ED150
	private bool SetMagnitude(float value, bool isLog = true)
	{
		if (!this.Check(this.Max >= this.Min, "Buff特效表Min>Max！有问题"))
		{
			return false;
		}
		this.Value = value;
		float normalizedValue = this.Normalize();
		this.OnSetMagnitude(normalizedValue);
		return true;
	}

	// Token: 0x060177F0 RID: 96240 RVA: 0x006EEF98 File Offset: 0x006ED198
	protected virtual float Normalize()
	{
		if (this.BuffIdNeedTick != 0)
		{
			return this.Value;
		}
		if (this.Min == this.Max)
		{
			return 0f;
		}
		return (MathUtils.Instance.Clamp(this.Value, this.Min, this.Max) - this.Min) / (this.Max - this.Min);
	}

	// Token: 0x060177F1 RID: 96241 RVA: 0x006EEFF9 File Offset: 0x006ED1F9
	protected float ToRange(float normalizedValue)
	{
		return normalizedValue * (this.Max - this.Min) + this.Min;
	}

	// Token: 0x060177F2 RID: 96242 RVA: 0x006EF014 File Offset: 0x006ED214
	[NullableContext(1)]
	private bool Check(bool toCheck, string message)
	{
		if (!toCheck)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Battle;
			ELogAuthor author = ELogAuthor.HXY;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CueId", this.CueConfig.Id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		return true;
	}

	// Token: 0x060177F3 RID: 96243 RVA: 0x006EF05C File Offset: 0x006ED25C
	private float ComputeMagnitudeValueByBuff()
	{
		IActiveBuff buffByHandle = this.BuffComponent.GetBuffByHandle(this.BuffHandleId);
		float num = (buffByHandle != null) ? buffByHandle.GetRemainDuration() : 0f;
		IActiveBuff buffByHandle2 = this.BuffComponent.GetBuffByHandle(this.BuffHandleId);
		float num2 = (buffByHandle2 != null) ? buffByHandle2.Duration : 1f;
		if (num2 > 0f)
		{
			return num / num2;
		}
		return 0f;
	}

	// Token: 0x060177F4 RID: 96244 RVA: 0x006EF0C0 File Offset: 0x006ED2C0
	private void InitComponent()
	{
		this.AttributeComponent = this.EntityHandle.Entity.GetComponent<BaseAttributeComponent>();
		this.BuffComponent = this.EntityHandle.Entity.GetComponent<BaseBuffComponent>();
		this.TagComponent = this.EntityHandle.Entity.GetComponent<BaseTagComponent>();
	}

	// Token: 0x0400C7E0 RID: 51168
	private bool IsMagnified;

	// Token: 0x0400C7E1 RID: 51169
	private ITagTask TagCountChangedTask;

	// Token: 0x0400C7E2 RID: 51170
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400C7E3 RID: 51171
	private BaseTagComponent TagComponent;

	// Token: 0x0400C7E4 RID: 51172
	private BaseBuffComponent BuffComponent;

	// Token: 0x0400C7E5 RID: 51173
	private EAttributeType? MaxAttributeId;

	// Token: 0x0400C7E6 RID: 51174
	private float Min;

	// Token: 0x0400C7E7 RID: 51175
	private float Max;

	// Token: 0x0400C7E8 RID: 51176
	protected float Value;

	// Token: 0x0400C7E9 RID: 51177
	private int BuffIdNeedTick;

	// Token: 0x0400C7EA RID: 51178
	private bool CameraPitchTick;

	// Token: 0x0400C7EB RID: 51179
	private float StartFlowTime;

	// Token: 0x0400C7EC RID: 51180
	private bool ExistFlowTimeTick;
}
