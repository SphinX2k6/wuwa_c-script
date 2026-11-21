using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200072D RID: 1837
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoEventTipView : UiTickViewBase
{
	// Token: 0x06005493 RID: 21651 RVA: 0x001BE0C6 File Offset: 0x001BC2C6
	public FightPhotoEventTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06005494 RID: 21652 RVA: 0x001BE0E8 File Offset: 0x001BC2E8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x06005495 RID: 21653 RVA: 0x001BE144 File Offset: 0x001BC344
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoEventTipView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoEventTipView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005496 RID: 21654 RVA: 0x001BE188 File Offset: 0x001BC388
	protected override void OnStart()
	{
		IPromptParamHub promptParamHub = (IPromptParamHub)this.OpenParam;
		TableTextArgNew mainTextObj = promptParamHub.MainTextObj;
		string text = ((mainTextObj != null) ? mainTextObj.TextKey : null) ?? "";
		if (!string.IsNullOrEmpty(text))
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), text, Array.Empty<object>());
		}
		int tipType = Array.IndexOf<string>(FightPhotoController.Instance.StepTextIdList, text);
		this.SetTipType(tipType);
		int num = 3;
		if (promptParamHub.Duration != null && promptParamHub.Duration.Value != 0f)
		{
			num = (int)promptParamHub.Duration.Value;
		}
		else if (promptParamHub.TypeId != 0)
		{
			GenericPromptTypes? promptTypeInfo = GenericPromptConfig.Instance.GetPromptTypeInfo(promptParamHub.TypeId);
			if (promptTypeInfo != null)
			{
				num = promptTypeInfo.Value.Duration;
			}
		}
		this.Duration = (float)(num * TimeUtil.Instance.InverseMillisecond);
	}

	// Token: 0x06005497 RID: 21655 RVA: 0x001BE277 File Offset: 0x001BC477
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x06005498 RID: 21656 RVA: 0x001BE295 File Offset: 0x001BC495
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x06005499 RID: 21657 RVA: 0x001BE2B3 File Offset: 0x001BC4B3
	protected override void OnBeforeDestroy()
	{
		this.PatternTextureMap.Clear();
		this.NumberTextureMap.Clear();
	}

	// Token: 0x0600549A RID: 21658 RVA: 0x001BE2CB File Offset: 0x001BC4CB
	protected override void OnTick(float delta)
	{
		if (this.IsOverTime)
		{
			return;
		}
		this.TickTime += delta;
		if (this.TickTime > this.Duration)
		{
			this.IsOverTime = true;
			base.CloseMe(null);
		}
	}

	// Token: 0x0600549B RID: 21659 RVA: 0x001BE300 File Offset: 0x001BC500
	private void SetTipType(int tipType)
	{
		UTexture2D texture;
		if (this.PatternTextureMap.TryGetValue(tipType, out texture))
		{
			UUITexture texture2 = base.GetTexture(0);
			if (texture2 != null)
			{
				texture2.SetTexture(texture);
			}
			UUITexture texture3 = base.GetTexture(0);
			if (texture3 != null)
			{
				texture3.SetUIActive(true);
			}
		}
		else
		{
			UUITexture texture4 = base.GetTexture(0);
			if (texture4 != null)
			{
				texture4.SetUIActive(false);
			}
		}
		UTexture2D texture5;
		if (this.NumberTextureMap.TryGetValue(tipType, out texture5))
		{
			UUITexture texture6 = base.GetTexture(1);
			if (texture6 != null)
			{
				texture6.SetTexture(texture5);
			}
			UUITexture texture7 = base.GetTexture(1);
			if (texture7 == null)
			{
				return;
			}
			texture7.SetUIActive(true);
			return;
		}
		else
		{
			UUITexture texture8 = base.GetTexture(1);
			if (texture8 == null)
			{
				return;
			}
			texture8.SetUIActive(false);
			return;
		}
	}

	// Token: 0x0600549C RID: 21660 RVA: 0x001BE3A0 File Offset: 0x001BC5A0
	private UniTask LoadTexture(string path, Dictionary<int, UTexture2D> container, int key)
	{
		FightPhotoEventTipView.<LoadTexture>d__18 <LoadTexture>d__;
		<LoadTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<LoadTexture>d__.<>4__this = this;
		<LoadTexture>d__.path = path;
		<LoadTexture>d__.container = container;
		<LoadTexture>d__.key = key;
		<LoadTexture>d__.<>1__state = -1;
		<LoadTexture>d__.<>t__builder.Start<FightPhotoEventTipView.<LoadTexture>d__18>(ref <LoadTexture>d__);
		return <LoadTexture>d__.<>t__builder.Task;
	}

	// Token: 0x0600549D RID: 21661 RVA: 0x001BE3FB File Offset: 0x001BC5FB
	public void OnPreparePhotoScreenShot(bool bShow)
	{
		if (base.IsShowOrShowing)
		{
			UUIItem rootItem = base.GetRootItem();
			if (rootItem == null)
			{
				return;
			}
			rootItem.SetUIActive(bShow);
		}
	}

	// Token: 0x04003B16 RID: 15126
	[StaticVariableRuleIgnore]
	private static readonly string[] PatternTextureList = new string[]
	{
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoPatternNum01.T_BattlePhotoPatternNum01",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoPatternNum02.T_BattlePhotoPatternNum02",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoPatternNum03.T_BattlePhotoPatternNum03"
	};

	// Token: 0x04003B17 RID: 15127
	[StaticVariableRuleIgnore]
	private static readonly string[] NumberTextureList = new string[]
	{
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoNum01.T_BattlePhotoNum01",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoNum02.T_BattlePhotoNum02",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoNum03.T_BattlePhotoNum03"
	};

	// Token: 0x04003B18 RID: 15128
	private const int DEFAULT_TIP_DURATION = 3;

	// Token: 0x04003B19 RID: 15129
	private readonly Dictionary<int, UTexture2D> PatternTextureMap = new Dictionary<int, UTexture2D>();

	// Token: 0x04003B1A RID: 15130
	private readonly Dictionary<int, UTexture2D> NumberTextureMap = new Dictionary<int, UTexture2D>();

	// Token: 0x04003B1B RID: 15131
	private float Duration;

	// Token: 0x04003B1C RID: 15132
	private float TickTime;

	// Token: 0x04003B1D RID: 15133
	private bool IsOverTime;

	// Token: 0x02006A16 RID: 27158
	[NullableContext(0)]
	private enum EComponentType
	{
		// Token: 0x04022E9F RID: 143007
		PatternTexture,
		// Token: 0x04022EA0 RID: 143008
		NumberTexture,
		// Token: 0x04022EA1 RID: 143009
		TipText
	}
}
