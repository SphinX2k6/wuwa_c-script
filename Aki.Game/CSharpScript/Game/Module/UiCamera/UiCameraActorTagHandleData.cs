using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiCameraAnimation.Struct;
using UnrealEngine;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x02003994 RID: 14740
	public class UiCameraActorTagHandleData : UiCameraReplaceActorHandleData
	{
		// Token: 0x06025F54 RID: 155476 RVA: 0x00AA77C0 File Offset: 0x00AA59C0
		[NullableContext(1)]
		public override bool Refresh(UiCameraModel model)
		{
			return base.RefreshConfigData(model) && base.RefreshReplaceCameraData(this.FindReplaceCameraActor());
		}

		// Token: 0x06025F55 RID: 155477 RVA: 0x00AA77DC File Offset: 0x00AA59DC
		[NullableContext(2)]
		protected unsafe ACineCameraActor FindReplaceCameraActor()
		{
			SUiCameraAnimationSettings cameraSettings = base.CameraSettings;
			string text = (cameraSettings != null) ? cameraSettings.ReplaceCameraTag : null;
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			UGameplayStatics.GetAllActorsOfClassWithTag(GlobalData.World, ACineCameraActor.StaticClass(), FNameUtil.GetDynamicFName(text).Value, ref tarray);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.UiCamera;
			ELogAuthor author = ELogAuthor.BB;
			string message = "查找替换相机Actor";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleData", this.ToString());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ReplaceCameraTag", text);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CameraActorCount", tarray.Num());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			for (int i = 0; i < tarray.Num(); i++)
			{
				ACineCameraActor acineCameraActor = tarray.Get(i) as ACineCameraActor;
				UCineCameraComponent ucineCameraComponent = (acineCameraActor != null) ? acineCameraActor.GetCineCameraComponent() : null;
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "替换相机Actor候选";
				<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray7<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Index", i);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CameraActor", (acineCameraActor != null) ? acineCameraActor.GetName() : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("FieldOfView", (ucineCameraComponent != null) ? new float?(ucineCameraComponent.FieldOfView) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("AspectRatio", (ucineCameraComponent != null) ? new float?(ucineCameraComponent.AspectRatio) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("FilmbackAspectRatio", (ucineCameraComponent != null) ? new float?(ucineCameraComponent.Filmback.SensorAspectRatio) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("FocalLength", (ucineCameraComponent != null) ? new float?(ucineCameraComponent.CurrentFocalLength) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("Aperture", (ucineCameraComponent != null) ? new float?(ucineCameraComponent.CurrentAperture) : null);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 7));
			}
			if (tarray.Num() <= 0)
			{
				return null;
			}
			return tarray.Get(0) as ACineCameraActor;
		}
	}
}
