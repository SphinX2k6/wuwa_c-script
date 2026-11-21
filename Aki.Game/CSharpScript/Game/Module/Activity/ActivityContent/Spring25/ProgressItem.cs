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
	// Token: 0x0200501F RID: 20511
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ProgressItem : GridProxyAbstract<Spring25InfoProgressData>
	{
		// Token: 0x170063FA RID: 25594
		// (get) Token: 0x06033542 RID: 210242 RVA: 0x00E63F8C File Offset: 0x00E6218C
		// (set) Token: 0x06033543 RID: 210243 RVA: 0x00E63F94 File Offset: 0x00E62194
		private UiSequencePlayer Player { get; set; }

		// Token: 0x06033544 RID: 210244 RVA: 0x00E63FA0 File Offset: 0x00E621A0
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

		// Token: 0x06033545 RID: 210245 RVA: 0x00E6400C File Offset: 0x00E6220C
		protected override UniTask OnBeforeStartAsync()
		{
			ProgressItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ProgressItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033546 RID: 210246 RVA: 0x00E6404F File Offset: 0x00E6224F
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

		// Token: 0x06033547 RID: 210247 RVA: 0x00E64084 File Offset: 0x00E62284
		public UniTask PlayBlinkAsync()
		{
			ProgressItem.<PlayBlinkAsync>d__8 <PlayBlinkAsync>d__;
			<PlayBlinkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayBlinkAsync>d__.<>4__this = this;
			<PlayBlinkAsync>d__.<>1__state = -1;
			<PlayBlinkAsync>d__.<>t__builder.Start<ProgressItem.<PlayBlinkAsync>d__8>(ref <PlayBlinkAsync>d__);
			return <PlayBlinkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0200ACE7 RID: 44263
		[NullableContext(0)]
		private class EProgressComponent
		{
			// Token: 0x04035776 RID: 218998
			public const int OffTexture = 0;

			// Token: 0x04035777 RID: 218999
			public const int OnTexture = 1;
		}
	}
}
