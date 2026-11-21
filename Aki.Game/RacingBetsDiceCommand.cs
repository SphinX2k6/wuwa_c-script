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

// Token: 0x02001BBF RID: 7103
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDiceCommand : RacingBetsCommandBase
{
	// Token: 0x17001AA5 RID: 6821
	// (get) Token: 0x06011B04 RID: 72452 RVA: 0x005364DA File Offset: 0x005346DA
	public override ERacingBetsCommandType CommandType
	{
		get
		{
			return ERacingBetsCommandType.Dice;
		}
	}

	// Token: 0x06011B05 RID: 72453 RVA: 0x005364E0 File Offset: 0x005346E0
	public void Init(int round, List<DangoIdToDiceNum> dangoDiceList)
	{
		this.Round = round;
		this.DangoDiceList = dangoDiceList;
		this.DiceOutlineBp = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("DiceBp").Value, ECollectActorType.UI) as BP_DiceOL_C);
		this.DiceCamera = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("DiceCamera").Value, ECollectActorType.UI) as ACineCameraActor);
	}

	// Token: 0x06011B06 RID: 72454 RVA: 0x00536544 File Offset: 0x00534744
	public override UniTask OnExecute()
	{
		RacingBetsDiceCommand.<OnExecute>d__12 <OnExecute>d__;
		<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnExecute>d__.<>4__this = this;
		<OnExecute>d__.<>1__state = -1;
		<OnExecute>d__.<>t__builder.Start<RacingBetsDiceCommand.<OnExecute>d__12>(ref <OnExecute>d__);
		return <OnExecute>d__.<>t__builder.Task;
	}

	// Token: 0x06011B07 RID: 72455 RVA: 0x00536588 File Offset: 0x00534788
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

	// Token: 0x06011B08 RID: 72456 RVA: 0x0053683C File Offset: 0x00534A3C
	private UniTask PlayDiceOrderAnim()
	{
		RacingBetsDiceCommand.<PlayDiceOrderAnim>d__14 <PlayDiceOrderAnim>d__;
		<PlayDiceOrderAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDiceOrderAnim>d__.<>4__this = this;
		<PlayDiceOrderAnim>d__.<>1__state = -1;
		<PlayDiceOrderAnim>d__.<>t__builder.Start<RacingBetsDiceCommand.<PlayDiceOrderAnim>d__14>(ref <PlayDiceOrderAnim>d__);
		return <PlayDiceOrderAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06011B09 RID: 72457 RVA: 0x00536880 File Offset: 0x00534A80
	private UniTask PlayFreeCameraBlend()
	{
		RacingBetsDiceCommand.<PlayFreeCameraBlend>d__15 <PlayFreeCameraBlend>d__;
		<PlayFreeCameraBlend>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFreeCameraBlend>d__.<>4__this = this;
		<PlayFreeCameraBlend>d__.<>1__state = -1;
		<PlayFreeCameraBlend>d__.<>t__builder.Start<RacingBetsDiceCommand.<PlayFreeCameraBlend>d__15>(ref <PlayFreeCameraBlend>d__);
		return <PlayFreeCameraBlend>d__.<>t__builder.Task;
	}

	// Token: 0x06011B0A RID: 72458 RVA: 0x005368C4 File Offset: 0x00534AC4
	private UniTask PlayDiceAnim()
	{
		RacingBetsDiceCommand.<PlayDiceAnim>d__16 <PlayDiceAnim>d__;
		<PlayDiceAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayDiceAnim>d__.<>4__this = this;
		<PlayDiceAnim>d__.<>1__state = -1;
		<PlayDiceAnim>d__.<>t__builder.Start<RacingBetsDiceCommand.<PlayDiceAnim>d__16>(ref <PlayDiceAnim>d__);
		return <PlayDiceAnim>d__.<>t__builder.Task;
	}

	// Token: 0x06011B0B RID: 72459 RVA: 0x00536907 File Offset: 0x00534B07
	public override string LogInfo()
	{
		return "RacingBetsDiceCommand";
	}

	// Token: 0x06011B0C RID: 72460 RVA: 0x00536910 File Offset: 0x00534B10
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

	// Token: 0x06011B0D RID: 72461 RVA: 0x005369AC File Offset: 0x00534BAC
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

	// Token: 0x06011B0E RID: 72462 RVA: 0x005369F4 File Offset: 0x00534BF4
	private float GetDynamicVerticalFieldOfView(float fov, float aspectRatio)
	{
		Vector2D viewportSize = UiLayer.Instance.GetViewportSize();
		float num = MathCommon.DegreeToRadian(fov);
		double num2 = viewportSize.X / viewportSize.Y;
		return MathCommon.RadianToDegree((float)(Math.Atan((double)aspectRatio / num2 * Math.Tan((double)(num / 2f))) * 2.0));
	}

	// Token: 0x04009A78 RID: 39544
	private int Round;

	// Token: 0x04009A79 RID: 39545
	private List<DangoIdToDiceNum> DangoDiceList;

	// Token: 0x04009A7A RID: 39546
	[Nullable(2)]
	private UMaterialParameterCollection DiceMaterialParameterCollection;

	// Token: 0x04009A7B RID: 39547
	[Nullable(2)]
	private BP_DiceOL_C DiceOutlineBp;

	// Token: 0x04009A7C RID: 39548
	[Nullable(2)]
	private ACineCameraActor DiceCamera;

	// Token: 0x04009A7D RID: 39549
	private FName ProcessName;

	// Token: 0x04009A7E RID: 39550
	protected readonly global::Vector Location = global::Vector.Create();

	// Token: 0x04009A7F RID: 39551
	protected readonly global::Rotator Rotator = global::Rotator.Create();

	// Token: 0x04009A80 RID: 39552
	private readonly Regex DiceColorRegex = new Regex("R=([\\d.]+),G=([\\d.]+),B=([\\d.]+),A=([\\d.]+)");
}
