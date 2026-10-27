using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200503A RID: 20538
	[NullableContext(1)]
	[Nullable(0)]
	public class AdmissionStudentCardView : UiViewBase
	{
		// Token: 0x0603492B RID: 215339 RVA: 0x00C6A0C5 File Offset: 0x00C682C5
		public AdmissionStudentCardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603492C RID: 215340 RVA: 0x00C6A0D0 File Offset: 0x00C682D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603492D RID: 215341 RVA: 0x00C6A1E0 File Offset: 0x00C683E0
		protected override UniTask OnBeforeStartAsync()
		{
			AdmissionStudentCardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdmissionStudentCardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401C032 RID: 114738
		private const string VAR_TEXTURE = "3_0入学拍照头像";

		// Token: 0x0401C033 RID: 114739
		private const string VAR_ADDRESS = "3_0入学联系地址";

		// Token: 0x0401C034 RID: 114740
		private const string FEMALE = "_F";

		// Token: 0x0401C035 RID: 114741
		private const string MALE = "_M";

		// Token: 0x0401C036 RID: 114742
		private const string UNKNOWN_BIRTHDAY = "StudentCard_Birthday_Unknow";

		// Token: 0x0401C037 RID: 114743
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x0200B188 RID: 45448
		[NullableContext(0)]
		private static class EChildComponent
		{
			// Token: 0x04035D92 RID: 220562
			public const int Caption = 0;

			// Token: 0x04035D93 RID: 220563
			public const int TitleTxt = 1;

			// Token: 0x04035D94 RID: 220564
			public const int IconTexture = 2;

			// Token: 0x04035D95 RID: 220565
			public const int RoleNameTxt = 3;

			// Token: 0x04035D96 RID: 220566
			public const int AcademyTxt = 4;

			// Token: 0x04035D97 RID: 220567
			public const int BirthdayTxt = 5;

			// Token: 0x04035D98 RID: 220568
			public const int AddressTxt = 6;
		}
	}
}
