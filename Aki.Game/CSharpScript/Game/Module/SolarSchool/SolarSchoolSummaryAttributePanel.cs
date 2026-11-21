using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A64 RID: 23140
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolSummaryAttributePanel : UiPanelBase
	{
		// Token: 0x06039013 RID: 233491 RVA: 0x00FF7944 File Offset: 0x00FF5B44
		public SolarSchoolSummaryAttributePanel()
		{
			this.AttrItemComponents = new int[]
			{
				4,
				5,
				6,
				7,
				8
			};
		}

		// Token: 0x06039014 RID: 233492 RVA: 0x00FF799C File Offset: 0x00FF5B9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039015 RID: 233493 RVA: 0x00FF7BBC File Offset: 0x00FF5DBC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolSummaryAttributePanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolSummaryAttributePanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039016 RID: 233494 RVA: 0x00FF7C00 File Offset: 0x00FF5E00
		public void SetAttrChangeTuples([Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<ESolarSchoolSecondAttr, int>> attrTuples)
		{
			if (attrTuples.Count != SolarSchoolDefine.AttrsShowList.Length)
			{
				return;
			}
			int[] attrList = SolarSchoolGamePlayModel.Instance.PlayerData.GetAttrList();
			int[] array = new int[attrTuples.Count];
			for (int i = 0; i < attrTuples.Count; i++)
			{
				array[i] = attrList[i] - attrTuples[i].Item2;
				this.AttrItems[i].RefreshAttr(attrTuples[i]);
			}
			float calcRadarDisplayMax = this.CalcRadarDisplayMax(attrTuples);
			this.CurRadiiValues = this.BuildAttrDisplayRadii(calcRadarDisplayMax, attrList);
			this.PreRadiiValues = this.BuildAttrDisplayRadii(calcRadarDisplayMax, array);
			this.SetPreviousAttr(this.PreRadiiValues);
			this.SetCurrentAttr(this.CurRadiiValues);
		}

		// Token: 0x06039017 RID: 233495 RVA: 0x00FF7CB4 File Offset: 0x00FF5EB4
		private float[] BuildAttrDisplayRadii(float calcRadarDisplayMax, int[] attrValues)
		{
			ESolarSchoolSecondAttr[] attrsShowList = SolarSchoolDefine.AttrsShowList;
			float[] array = new float[attrsShowList.Length];
			for (int i = 0; i < attrsShowList.Length; i++)
			{
				array[i] = ((calcRadarDisplayMax > 0f) ? Math.Clamp((float)attrValues[i] / calcRadarDisplayMax, 0f, 1f) : 0f);
			}
			return array;
		}

		// Token: 0x06039018 RID: 233496 RVA: 0x00FF7D08 File Offset: 0x00FF5F08
		private float CalcRadarDisplayMax([Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<ESolarSchoolSecondAttr, int>> attrTuples)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			SolarSchoolPlayerData playerData = SolarSchoolGamePlayModel.Instance.PlayerData;
			float num = 0f;
			int num2 = 0;
			for (int i = 0; i < attrTuples.Count; i++)
			{
				ESolarSchoolSecondAttr item = attrTuples[i].Item1;
				int item2 = attrTuples[i].Item2;
				int attr = playerData.GetAttr(attrTuples[i].Item1);
				int val = attr - item2;
				int num3 = Math.Max(attr, val);
				num = Math.Max(num, (float)num3);
				SolarSchoolAttr? solarSchoolAttr = SolarSchoolConfig.Instance.TryGetAttrByType(activityId, (int)item);
				num2 = Math.Max(num2, (solarSchoolAttr != null) ? solarSchoolAttr.GetValueOrDefault().MaxValue : 0);
			}
			float num4 = num * 1.15f;
			if (num2 <= 0)
			{
				return num4;
			}
			return Math.Min(num4, (float)num2);
		}

		// Token: 0x06039019 RID: 233497 RVA: 0x00FF7DE4 File Offset: 0x00FF5FE4
		public void SetPreviousAttr(float[] radii)
		{
			UUITexture texture = base.GetTexture(3);
			if (radii.Length != SolarSchoolDefine.AttrsShowList.Length)
			{
				return;
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA0"), radii[0]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA1"), radii[1]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA2"), radii[2]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA3"), radii[3]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioA4"), radii[4]);
			}
		}

		// Token: 0x0603901A RID: 233498 RVA: 0x00FF7E74 File Offset: 0x00FF6074
		public void SetCurrentAttr(float[] radii)
		{
			UUITexture texture = base.GetTexture(3);
			if (radii.Length != SolarSchoolDefine.AttrsShowList.Length)
			{
				return;
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB0"), radii[0]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB1"), radii[1]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB2"), radii[2]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB3"), radii[3]);
			}
			if (texture != null)
			{
				texture.SetCustomMaterialScalarParameter(new FName("RatioB4"), radii[4]);
			}
		}

		// Token: 0x0603901B RID: 233499 RVA: 0x00FF7F04 File Offset: 0x00FF6104
		public UniTask PlayShowAnim()
		{
			SolarSchoolSummaryAttributePanel.<PlayShowAnim>d__18 <PlayShowAnim>d__;
			<PlayShowAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayShowAnim>d__.<>4__this = this;
			<PlayShowAnim>d__.<>1__state = -1;
			<PlayShowAnim>d__.<>t__builder.Start<SolarSchoolSummaryAttributePanel.<PlayShowAnim>d__18>(ref <PlayShowAnim>d__);
			return <PlayShowAnim>d__.<>t__builder.Task;
		}

		// Token: 0x0603901C RID: 233500 RVA: 0x00FF7F48 File Offset: 0x00FF6148
		public void SetAttrItemsTextVisible(bool isVisible)
		{
			foreach (SolarSchoolSummaryAttributeItem solarSchoolSummaryAttributeItem in this.AttrItems)
			{
				solarSchoolSummaryAttributeItem.SetTextVisible(isVisible);
			}
		}

		// Token: 0x0603901D RID: 233501 RVA: 0x00FF7F9C File Offset: 0x00FF619C
		private UniTask PlayRadarAnimAsync(Action<float> progressCallback)
		{
			UniTaskCompletionSource radarAnimPromise = this.RadarAnimPromise;
			if (radarAnimPromise != null)
			{
				radarAnimPromise.TrySetResult();
			}
			UniTaskCompletionSource promise = new UniTaskCompletionSource();
			this.RadarAnimPromise = promise;
			this.NumberTool.Init(0f, 1f, progressCallback, 1000, delegate
			{
				if (this.RadarAnimPromise == promise)
				{
					this.RadarAnimPromise = null;
				}
				promise.TrySetResult();
			});
			this.NumberTool.StartScrolling();
			return promise.Task;
		}

		// Token: 0x0603901E RID: 233502 RVA: 0x00FF801C File Offset: 0x00FF621C
		private float[] ScaleRadii(float[] target, float progress)
		{
			float[] array = new float[target.Length];
			for (int i = 0; i < target.Length; i++)
			{
				array[i] = target[i] * progress;
			}
			return array;
		}

		// Token: 0x0603901F RID: 233503 RVA: 0x00FF8049 File Offset: 0x00FF6249
		protected override void OnBeforeDestroy()
		{
			this.NumberTool.Clear();
		}

		// Token: 0x0401E006 RID: 122886
		private const string AnimCurveSourceId = "SolarSchoolCurve_Map";

		// Token: 0x0401E007 RID: 122887
		private readonly int[] AttrItemComponents;

		// Token: 0x0401E008 RID: 122888
		private readonly List<SolarSchoolSummaryAttributeItem> AttrItems = new List<SolarSchoolSummaryAttributeItem>();

		// Token: 0x0401E009 RID: 122889
		private const float RadarExtraRatio = 0.15f;

		// Token: 0x0401E00A RID: 122890
		private readonly ScrollingNumberTool NumberTool = new ScrollingNumberTool();

		// Token: 0x0401E00B RID: 122891
		[Nullable(2)]
		private UniTaskCompletionSource RadarAnimPromise;

		// Token: 0x0401E00C RID: 122892
		[Nullable(2)]
		private Action StartAnimFinishCallBack;

		// Token: 0x0401E00D RID: 122893
		private float[] CurRadiiValues = Array.Empty<float>();

		// Token: 0x0401E00E RID: 122894
		private float[] PreRadiiValues = Array.Empty<float>();

		// Token: 0x0200B652 RID: 46674
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04038667 RID: 231015
			public const int PnlAttrComplete = 0;

			// Token: 0x04038668 RID: 231016
			public const int TxtRatioName = 1;

			// Token: 0x04038669 RID: 231017
			public const int TxtRatio = 2;

			// Token: 0x0403866A RID: 231018
			public const int TexEventAttrRadar = 3;

			// Token: 0x0403866B RID: 231019
			public const int AttrItem01 = 4;

			// Token: 0x0403866C RID: 231020
			public const int AttrItem02 = 5;

			// Token: 0x0403866D RID: 231021
			public const int AttrItem03 = 6;

			// Token: 0x0403866E RID: 231022
			public const int AttrItem04 = 7;

			// Token: 0x0403866F RID: 231023
			public const int AttrItem05 = 8;

			// Token: 0x04038670 RID: 231024
			public const int PanelPoint = 9;

			// Token: 0x04038671 RID: 231025
			public const int ItemPointGoing = 10;

			// Token: 0x04038672 RID: 231026
			public const int ItemPointSuccess = 11;

			// Token: 0x04038673 RID: 231027
			public const int ItemPointFail = 12;

			// Token: 0x04038674 RID: 231028
			public const int PnlResult = 13;

			// Token: 0x04038675 RID: 231029
			public const int PnlMyAttr = 14;
		}
	}
}
