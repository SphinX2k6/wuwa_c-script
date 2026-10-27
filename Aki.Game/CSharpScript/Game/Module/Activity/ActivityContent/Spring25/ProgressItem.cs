using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x020060A1 RID: 24737
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ProgressItem : GridProxyAbstract<Spring25InfoProgressData>
	{
		// Token: 0x17009098 RID: 37016
		// (get) Token: 0x0603E87E RID: 256126 RVA: 0x00F1D1C8 File Offset: 0x00F1B3C8
		// (set) Token: 0x0603E87F RID: 256127 RVA: 0x00F1D1D0 File Offset: 0x00F1B3D0
		private UiSequencePlayer Player { get; set; }

		// Token: 0x0603E880 RID: 256128 RVA: 0x00F1D1DC File Offset: 0x00F1B3DC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603E881 RID: 256129 RVA: 0x00F1D248 File Offset: 0x00F1B448
		protected override UniTask OnBeforeStartAsync()
		{
			ProgressItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ProgressItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E882 RID: 256130 RVA: 0x00F1D28B File Offset: 0x00F1B48B
		public override void Refresh(Spring25InfoProgressData data, bool isSelected, int gridIndex)
		{
			UUITexture texture = base.GetTexture(0);
			if (texture != null)
			{
				texture.SetUIActive(!data.IsLight);
			}
			UUITexture texture2 = base.GetTexture(1);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(data.IsLight);
		}

		// Token: 0x0603E883 RID: 256131 RVA: 0x00F1D2C0 File Offset: 0x00F1B4C0
		public UniTask PlayBlinkAsync()
		{
			ProgressItem.<PlayBlinkAsync>d__8 <PlayBlinkAsync>d__;
			<PlayBlinkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBlinkAsync>d__.<>4__this = this;
			<PlayBlinkAsync>d__.<>1__state = -1;
			<PlayBlinkAsync>d__.<>t__builder.Start<ProgressItem.<PlayBlinkAsync>d__8>(ref <PlayBlinkAsync>d__);
			return <PlayBlinkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0200C2FC RID: 49916
		[NullableContext(0)]
		private class EProgressComponent
		{
			// Token: 0x0403AE0E RID: 241166
			public const int OffTexture = 0;

			// Token: 0x0403AE0F RID: 241167
			public const int OnTexture = 1;
		}
	}
}
