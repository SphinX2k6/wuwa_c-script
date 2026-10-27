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

// Token: 0x02001279 RID: 4729
[NullableContext(1)]
[Nullable(0)]
public class FightPhotoEventTipView : UiTickViewBase
{
	// Token: 0x060080FC RID: 33020 RVA: 0x001B53F6 File Offset: 0x001B35F6
	public FightPhotoEventTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060080FD RID: 33021 RVA: 0x001B5418 File Offset: 0x001B3618
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
	}

	// Token: 0x060080FE RID: 33022 RVA: 0x001B5474 File Offset: 0x001B3674
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoEventTipView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoEventTipView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060080FF RID: 33023 RVA: 0x001B54B8 File Offset: 0x001B36B8
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

	// Token: 0x06008100 RID: 33024 RVA: 0x001B55A7 File Offset: 0x001B37A7
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x06008101 RID: 33025 RVA: 0x001B55C5 File Offset: 0x001B37C5
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnPreparePhotoScreenShot, new Action<bool>(this.OnPreparePhotoScreenShot));
	}

	// Token: 0x06008102 RID: 33026 RVA: 0x001B55E3 File Offset: 0x001B37E3
	protected override void OnBeforeDestroy()
	{
		this.PatternTextureMap.Clear();
		this.NumberTextureMap.Clear();
	}

	// Token: 0x06008103 RID: 33027 RVA: 0x001B55FB File Offset: 0x001B37FB
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

	// Token: 0x06008104 RID: 33028 RVA: 0x001B5630 File Offset: 0x001B3830
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

	// Token: 0x06008105 RID: 33029 RVA: 0x001B56D0 File Offset: 0x001B38D0
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

	// Token: 0x06008106 RID: 33030 RVA: 0x001B572B File Offset: 0x001B392B
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

	// Token: 0x04003A7E RID: 14974
	[StaticVariableRuleIgnore]
	private static readonly string[] PatternTextureList = new string[]
	{
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoPatternNum01.T_BattlePhotoPatternNum01",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoPatternNum02.T_BattlePhotoPatternNum02",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoPatternNum03.T_BattlePhotoPatternNum03"
	};

	// Token: 0x04003A7F RID: 14975
	[StaticVariableRuleIgnore]
	private static readonly string[] NumberTextureList = new string[]
	{
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoNum01.T_BattlePhotoNum01",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoNum02.T_BattlePhotoNum02",
		"/Game/Aki/UI/UIResources/Common/Image/Com/Photo/T_BattlePhotoNum03.T_BattlePhotoNum03"
	};

	// Token: 0x04003A80 RID: 14976
	private const int DEFAULT_TIP_DURATION = 3;

	// Token: 0x04003A81 RID: 14977
	private readonly Dictionary<int, UTexture2D> PatternTextureMap = new Dictionary<int, UTexture2D>();

	// Token: 0x04003A82 RID: 14978
	private readonly Dictionary<int, UTexture2D> NumberTextureMap = new Dictionary<int, UTexture2D>();

	// Token: 0x04003A83 RID: 14979
	private float Duration;

	// Token: 0x04003A84 RID: 14980
	private float TickTime;

	// Token: 0x04003A85 RID: 14981
	private bool IsOverTime;

	// Token: 0x0200788B RID: 30859
	[NullableContext(0)]
	private enum EComponentType
	{
		// Token: 0x04027B6E RID: 162670
		PatternTexture,
		// Token: 0x04027B6F RID: 162671
		NumberTexture,
		// Token: 0x04027B70 RID: 162672
		TipText
	}
}
