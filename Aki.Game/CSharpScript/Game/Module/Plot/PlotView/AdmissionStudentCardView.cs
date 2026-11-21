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
	// Token: 0x02004007 RID: 16391
	[NullableContext(1)]
	[Nullable(0)]
	public class AdmissionStudentCardView : UiViewBase
	{
		// Token: 0x060297E9 RID: 169961 RVA: 0x00BB6555 File Offset: 0x00BB4755
		public AdmissionStudentCardView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060297EA RID: 169962 RVA: 0x00BB6560 File Offset: 0x00BB4760
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

		// Token: 0x060297EB RID: 169963 RVA: 0x00BB6670 File Offset: 0x00BB4870
		protected override UniTask OnBeforeStartAsync()
		{
			AdmissionStudentCardView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AdmissionStudentCardView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04016A3D RID: 92733
		private const string VAR_TEXTURE = "3_0入学拍照头像";

		// Token: 0x04016A3E RID: 92734
		private const string VAR_ADDRESS = "3_0入学联系地址";

		// Token: 0x04016A3F RID: 92735
		private const string FEMALE = "_F";

		// Token: 0x04016A40 RID: 92736
		private const string MALE = "_M";

		// Token: 0x04016A41 RID: 92737
		private const string UNKNOWN_BIRTHDAY = "StudentCard_Birthday_Unknow";

		// Token: 0x04016A42 RID: 92738
		[Nullable(2)]
		private PopupCaptionItem Caption;

		// Token: 0x02009BC2 RID: 39874
		[NullableContext(0)]
		private static class EChildComponent
		{
			// Token: 0x040307E7 RID: 198631
			public const int Caption = 0;

			// Token: 0x040307E8 RID: 198632
			public const int TitleTxt = 1;

			// Token: 0x040307E9 RID: 198633
			public const int IconTexture = 2;

			// Token: 0x040307EA RID: 198634
			public const int RoleNameTxt = 3;

			// Token: 0x040307EB RID: 198635
			public const int AcademyTxt = 4;

			// Token: 0x040307EC RID: 198636
			public const int BirthdayTxt = 5;

			// Token: 0x040307ED RID: 198637
			public const int AddressTxt = 6;
		}
	}
}
