using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Interaction;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x020026D4 RID: 9940
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDiceCommand : RacingBetsCommandBase
{
	// Token: 0x17001A6D RID: 6765
	// (get) Token: 0x06014622 RID: 83490 RVA: 0x005277A2 File Offset: 0x005259A2
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.Dice;
		}
	}

	// Token: 0x06014623 RID: 83491 RVA: 0x005277A8 File Offset: 0x005259A8
	public void Init(int round, List<DangoIdToDiceNum> dangoDiceList)
	{
		this.Round = round;
		this.DangoDiceList = dangoDiceList;
		this.DiceOutlineBp = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("DiceBp").Value, ECollectActorType.UI) as BP_DiceOL_C);
		this.DiceCamera = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("DiceCamera").Value, ECollectActorType.UI) as ACineCameraActor);
	}

	// Token: 0x06014624 RID: 83492 RVA: 0x0052780C File Offset: 0x00525A0C
	public override UniTask OnExecute()
	{
		RacingBetsDiceCommand.<OnExecute>d__12 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDiceCommand.<OnExecute>d__12>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06014625 RID: 83493 RVA: 0x00527850 File Offset: 0x00525A50
	private void InitDiceParameter(List<DangoIdToDiceNum> dangoDiceList)
	{
		this.ProcessName = FNameUtil.GetDynamicFName("Ani_Process").Value;
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.DiceMaterialParameterCollection, this.ProcessName, 0f);
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.DiceMaterialParameterCollection, FNameUtil.GetDynamicFName("DiceNub").Value, (float)dangoDiceList.Count);
		int num = Random.Shared.Next(RacingBetsDefine.RacingBetsDiceIndexList.Length);
		UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.GameInstance.GetWorld(), this.DiceMaterialParameterCollection, FNameUtil.GetDynamicFName("Ani_Num").Value, (float)RacingBetsDefine.RacingBetsDiceIndexList[num]);
		for (int i = 0; i < dangoDiceList.Count; i++)
		{
			UObject world = GlobalData.GameInstance.GetWorld();
			UMaterialParameterCollection diceMaterialParameterCollection = this.DiceMaterialParameterCollection;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(11, 1);
			defaultInterpolatedStringHandler.AppendLiteral("DicePoints_");
			defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
			UKismetMaterialLibrary.SetScalarParameterValue(world, diceMaterialParameterCollection, FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear()).Value, (float)dangoDiceList[i].Num);
			DangoConfig instance = DangoConfig.Instance;
			Dice? dice = (instance != null) ? instance.GetDiceById(dangoDiceList[i].DiceId) : null;
			if (dice != null)
			{
				FLinearColor? flinearColor = this.ParseLineColorString(dice.Value.DiceColor);
				if (flinearColor != null)
				{
					UObject world2 = GlobalData.GameInstance.GetWorld();
					UMaterialParameterCollection diceMaterialParameterCollection2 = this.DiceMaterialParameterCollection;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(10, 1);
					defaultInterpolatedStringHandler.AppendLiteral("DiceColor_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
					FName value = FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear()).Value;
					FLinearColor value2 = flinearColor.Value;
					UKismetMaterialLibrary.SetVectorParameterValue(world2, diceMaterialParameterCollection2, value, value2);
				}
				FLinearColor? flinearColor2 = this.ParseLineColorString(dice.Value.DiceNumColor);
				if (flinearColor2 != null)
				{
					UObject world3 = GlobalData.GameInstance.GetWorld();
					UMaterialParameterCollection diceMaterialParameterCollection3 = this.DiceMaterialParameterCollection;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 1);
					defaultInterpolatedStringHandler.AppendLiteral("NumColor_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
					FName value3 = FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear()).Value;
					FLinearColor value2 = flinearColor2.Value;
					UKismetMaterialLibrary.SetVectorParameterValue(world3, diceMaterialParameterCollection3, value3, value2);
				}
				FLinearColor? flinearColor3 = this.ParseLineColorString(dice.Value.DiceHighLightColor);
				if (flinearColor3 != null)
				{
					UObject world4 = GlobalData.GameInstance.GetWorld();
					UMaterialParameterCollection diceMaterialParameterCollection4 = this.DiceMaterialParameterCollection;
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 1);
					defaultInterpolatedStringHandler.AppendLiteral("HeighLightColor_");
					defaultInterpolatedStringHandler.AppendFormatted<int>(i + 1);
					FName value4 = FNameUtil.GetDynamicFName(defaultInterpolatedStringHandler.ToStringAndClear()).Value;
					FLinearColor value2 = flinearColor3.Value;
					UKismetMaterialLibrary.SetVectorParameterValue(world4, diceMaterialParameterCollection4, value4, value2);
				}
			}
		}
	}

	// Token: 0x06014626 RID: 83494 RVA: 0x00527B04 File Offset: 0x00525D04
	private UniTask PlayDiceOrderAnim()
	{
		RacingBetsDiceCommand.<PlayDiceOrderAnim>d__14 <PlayDiceOrderAnim>d__;
		<PlayDiceOrderAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDiceOrderAnim>d__.<>4__this = this;
		<PlayDiceOrderAnim>d__.<>1__state = -1;
		<PlayDiceOrderAnim>d__.<>t__builder.Start<RacingBetsDiceCommand.<PlayDiceOrderAnim>d__14>(ref <PlayDiceOrderAnim>d__);
		return <PlayDiceOrderAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06014627 RID: 83495 RVA: 0x00527B48 File Offset: 0x00525D48
	private UniTask PlayFreeCameraBlend()
	{
		RacingBetsDiceCommand.<PlayFreeCameraBlend>d__15 <PlayFreeCameraBlend>d__;
		<PlayFreeCameraBlend>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFreeCameraBlend>d__.<>4__this = this;
		<PlayFreeCameraBlend>d__.<>1__state = -1;
		<PlayFreeCameraBlend>d__.<>t__builder.Start<RacingBetsDiceCommand.<PlayFreeCameraBlend>d__15>(ref <PlayFreeCameraBlend>d__);
		return <PlayFreeCameraBlend>d__.<>t__builder.Task;
	}

	// Token: 0x06014628 RID: 83496 RVA: 0x00527B8C File Offset: 0x00525D8C
	private UniTask PlayDiceAnim()
	{
		RacingBetsDiceCommand.<PlayDiceAnim>d__16 <PlayDiceAnim>d__;
		<PlayDiceAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDiceAnim>d__.<>4__this = this;
		<PlayDiceAnim>d__.<>1__state = -1;
		<PlayDiceAnim>d__.<>t__builder.Start<RacingBetsDiceCommand.<PlayDiceAnim>d__16>(ref <PlayDiceAnim>d__);
		return <PlayDiceAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06014629 RID: 83497 RVA: 0x00527BCF File Offset: 0x00525DCF
	public override string LogInfo()
	{
		return "RacingBetsDiceCommand";
	}

	// Token: 0x0601462A RID: 83498 RVA: 0x00527BD8 File Offset: 0x00525DD8
	private FLinearColor? ParseLineColorString(string colorString)
	{
		Match match = this.DiceColorRegex.Match(colorString);
		if (!match.Success)
		{
			return null;
		}
		float r = float.Parse(match.Groups[1].Value);
		float g = float.Parse(match.Groups[2].Value);
		float b = float.Parse(match.Groups[3].Value);
		float a = float.Parse(match.Groups[4].Value);
		return new FLinearColor?(new FLinearColor(r, g, b, a));
	}

	// Token: 0x0601462B RID: 83499 RVA: 0x00527C74 File Offset: 0x00525E74
	private float GetDynamicFov(UCineCameraComponent cameraComponent)
	{
		float sensorAspectRatio = cameraComponent.Filmback.SensorAspectRatio;
		float fieldOfView = cameraComponent.FieldOfView;
		Vector2D viewportSize = UiLayer.Instance.GetViewportSize();
		if (viewportSize.X / viewportSize.Y > (double)sensorAspectRatio)
		{
			return fieldOfView;
		}
		return this.GetDynamicVerticalFieldOfView(fieldOfView, sensorAspectRatio);
	}

	// Token: 0x0601462C RID: 83500 RVA: 0x00527CBC File Offset: 0x00525EBC
	private float GetDynamicVerticalFieldOfView(float fov, float aspectRatio)
	{
		Vector2D viewportSize = UiLayer.Instance.GetViewportSize();
		float num = MathCommon.DegreeToRadian(fov);
		double num2 = viewportSize.X / viewportSize.Y;
		return MathCommon.RadianToDegree((float)(Math.Atan((double)aspectRatio / num2 * Math.Tan((double)(num / 2f))) * 2.0));
	}

	// Token: 0x04009920 RID: 39200
	private int Round;

	// Token: 0x04009921 RID: 39201
	private List<DangoIdToDiceNum> DangoDiceList;

	// Token: 0x04009922 RID: 39202
	[Nullable(2)]
	private UMaterialParameterCollection DiceMaterialParameterCollection;

	// Token: 0x04009923 RID: 39203
	[Nullable(2)]
	private BP_DiceOL_C DiceOutlineBp;

	// Token: 0x04009924 RID: 39204
	[Nullable(2)]
	private ACineCameraActor DiceCamera;

	// Token: 0x04009925 RID: 39205
	private FName ProcessName;

	// Token: 0x04009926 RID: 39206
	protected readonly global::Vector Location = global::Vector.Create();

	// Token: 0x04009927 RID: 39207
	protected readonly global::Rotator Rotator = global::Rotator.Create();

	// Token: 0x04009928 RID: 39208
	private readonly Regex DiceColorRegex = new Regex("R=([\\d.]+),G=([\\d.]+),B=([\\d.]+),A=([\\d.]+)");
}
