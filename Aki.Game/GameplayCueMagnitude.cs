using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Camera;

// Token: 0x02002FC7 RID: 12231
[NullableContext(2)]
[Nullable(0)]
public class GameplayCueMagnitude : GameplayCueBase
{
	// Token: 0x06019ED0 RID: 106192 RVA: 0x006C8178 File Offset: 0x006C6378
	protected override void OnInit()
	{
		this.Min = (float)this.CueConfig.Min;
		this.Max = (float)this.CueConfig.Max;
	}

	// Token: 0x06019ED1 RID: 106193 RVA: 0x006C81A0 File Offset: 0x006C63A0
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

	// Token: 0x06019ED2 RID: 106194 RVA: 0x006C8257 File Offset: 0x006C6457
	protected override void OnCreate()
	{
		this.InitComponent();
		this.IsMagnified = this.StartMagnify();
	}

	// Token: 0x06019ED3 RID: 106195 RVA: 0x006C826B File Offset: 0x006C646B
	protected override void OnDestroy()
	{
		this.StopMagnify();
	}

	// Token: 0x06019ED4 RID: 106196 RVA: 0x006C8273 File Offset: 0x006C6473
	protected virtual void OnSetMagnitude(float normalizedValue)
	{
	}

	// Token: 0x06019ED5 RID: 106197 RVA: 0x006C8275 File Offset: 0x006C6475
	[NullableContext(1)]
	public override void OnChangeRole(EntityHandle newEntityHandle)
	{
		this.StopMagnify();
		base.OnChangeRole(newEntityHandle);
		this.InitComponent();
		this.IsMagnified = this.StartMagnify();
	}

	// Token: 0x06019ED6 RID: 106198 RVA: 0x006C8296 File Offset: 0x006C6496
	protected virtual bool UseMagnitude()
	{
		return this.CueConfig.Magni != 0 && !this.IsInstant;
	}

	// Token: 0x06019ED7 RID: 106199 RVA: 0x006C82B0 File Offset: 0x006C64B0
	[NullableContext(1)]
	public virtual void SyncMagnitude(GameplayCueMagnitude cueRef)
	{
	}

	// Token: 0x06019ED8 RID: 106200 RVA: 0x006C82B2 File Offset: 0x006C64B2
	private bool HasMagnitudeComponent()
	{
		return this.AttributeComponent != null && this.BuffComponent != null && this.TagComponent != null;
	}

	// Token: 0x06019ED9 RID: 106201 RVA: 0x006C82D0 File Offset: 0x006C64D0
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

	// Token: 0x06019EDA RID: 106202 RVA: 0x006C8534 File Offset: 0x006C6734
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

	// Token: 0x06019EDB RID: 106203 RVA: 0x006C8628 File Offset: 0x006C6828
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

	// Token: 0x06019EDC RID: 106204 RVA: 0x006C866E File Offset: 0x006C686E
	private void OnTagCountChanged(int tagCount, int tagId, int exactTagId, int oldCount)
	{
		this.SetMagnitude((float)tagCount, true);
	}

	// Token: 0x06019EDD RID: 106205 RVA: 0x006C867C File Offset: 0x006C687C
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

	// Token: 0x06019EDE RID: 106206 RVA: 0x006C86C4 File Offset: 0x006C68C4
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

	// Token: 0x06019EDF RID: 106207 RVA: 0x006C8725 File Offset: 0x006C6925
	protected float ToRange(float normalizedValue)
	{
		return normalizedValue * (this.Max - this.Min) + this.Min;
	}

	// Token: 0x06019EE0 RID: 106208 RVA: 0x006C8740 File Offset: 0x006C6940
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

	// Token: 0x06019EE1 RID: 106209 RVA: 0x006C8788 File Offset: 0x006C6988
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

	// Token: 0x06019EE2 RID: 106210 RVA: 0x006C87EC File Offset: 0x006C69EC
	private void InitComponent()
	{
		this.AttributeComponent = this.EntityHandle.Entity.GetComponent<BaseAttributeComponent>();
		this.BuffComponent = this.EntityHandle.Entity.GetComponent<BaseBuffComponent>();
		this.TagComponent = this.EntityHandle.Entity.GetComponent<BaseTagComponent>();
	}

	// Token: 0x0400C437 RID: 50231
	private bool IsMagnified;

	// Token: 0x0400C438 RID: 50232
	private ITagTask TagCountChangedTask;

	// Token: 0x0400C439 RID: 50233
	private BaseAttributeComponent AttributeComponent;

	// Token: 0x0400C43A RID: 50234
	private BaseTagComponent TagComponent;

	// Token: 0x0400C43B RID: 50235
	private BaseBuffComponent BuffComponent;

	// Token: 0x0400C43C RID: 50236
	private EAttributeType? MaxAttributeId;

	// Token: 0x0400C43D RID: 50237
	private float Min;

	// Token: 0x0400C43E RID: 50238
	private float Max;

	// Token: 0x0400C43F RID: 50239
	protected float Value;

	// Token: 0x0400C440 RID: 50240
	private int BuffIdNeedTick;

	// Token: 0x0400C441 RID: 50241
	private bool CameraPitchTick;

	// Token: 0x0400C442 RID: 50242
	private float StartFlowTime;

	// Token: 0x0400C443 RID: 50243
	private bool ExistFlowTimeTick;
}
