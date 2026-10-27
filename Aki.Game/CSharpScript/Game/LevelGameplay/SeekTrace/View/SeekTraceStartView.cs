using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02006A66 RID: 27238
	public class SeekTraceStartView : UiViewBase
	{
		// Token: 0x06043B93 RID: 277395 RVA: 0x01093CD2 File Offset: 0x01091ED2
		[NullableContext(1)]
		public SeekTraceStartView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043B94 RID: 277396 RVA: 0x01093CDB File Offset: 0x01091EDB
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06043B95 RID: 277397 RVA: 0x01093D00 File Offset: 0x01091F00
		protected override UniTask OnBeforeStartAsync()
		{
			SeekTraceStartView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SeekTraceStartView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06043B96 RID: 277398 RVA: 0x01093D43 File Offset: 0x01091F43
		protected override void OnStart()
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UiManager.Instance.OpenView(EUiViewName.SeekTraceView, null, null);
				base.CloseMe(null);
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x04023619 RID: 144921
		public const int DELAY_TIME = 2000;

		// Token: 0x0402361A RID: 144922
		[Nullable(2)]
		private SeekTraceClawItem ClawItem;

		// Token: 0x0200CB85 RID: 52101
		public enum EComponentType
		{
			// Token: 0x0403D717 RID: 251671
			ClawItem
		}
	}
}
