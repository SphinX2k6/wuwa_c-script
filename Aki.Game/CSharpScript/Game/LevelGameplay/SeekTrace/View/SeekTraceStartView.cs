using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SeekTrace.View
{
	// Token: 0x02005BC3 RID: 23491
	public class SeekTraceStartView : UiViewBase
	{
		// Token: 0x06039BE1 RID: 236513 RVA: 0x01038506 File Offset: 0x01036706
		[NullableContext(1)]
		public SeekTraceStartView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039BE2 RID: 236514 RVA: 0x0103850F File Offset: 0x0103670F
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem))
			};
		}

		// Token: 0x06039BE3 RID: 236515 RVA: 0x01038534 File Offset: 0x01036734
		protected override UniTask OnBeforeStartAsync()
		{
			SeekTraceStartView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SeekTraceStartView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039BE4 RID: 236516 RVA: 0x01038577 File Offset: 0x01036777
		protected override void OnStart()
		{
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UiManager.Instance.OpenView(EUiViewName.SeekTraceView, null, null);
				base.CloseMe(null);
			}, 2000f, null, null, true, 1f);
		}

		// Token: 0x0401E80B RID: 124939
		public const int DELAY_TIME = 2000;

		// Token: 0x0401E80C RID: 124940
		[Nullable(2)]
		private SeekTraceClawItem ClawItem;

		// Token: 0x0200B764 RID: 46948
		public enum EComponentType
		{
			// Token: 0x04038AF9 RID: 232185
			ClawItem
		}
	}
}
