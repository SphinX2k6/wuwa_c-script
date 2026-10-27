using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055F8 RID: 22008
	public class MapRogueFloatTipsView : UiViewBase
	{
		// Token: 0x0603807B RID: 229499 RVA: 0x00D450C9 File Offset: 0x00D432C9
		[NullableContext(1)]
		public MapRogueFloatTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603807C RID: 229500 RVA: 0x00D450D2 File Offset: 0x00D432D2
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0603807D RID: 229501 RVA: 0x00D450F8 File Offset: 0x00D432F8
		protected override void OnStart()
		{
			this.Data = (this.OpenParam as IRogueTipsData);
			if (this.Data == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.TextId, this.Data.TextParam);
		}

		// Token: 0x0603807E RID: 229502 RVA: 0x00D45146 File Offset: 0x00D43346
		protected override void OnAfterShow()
		{
			base.CloseMe(delegate(bool _)
			{
				IRogueTipsData data = this.Data;
				if (data == null)
				{
					return;
				}
				Action finishCallback = data.FinishCallback;
				if (finishCallback == null)
				{
					return;
				}
				finishCallback();
			});
		}

		// Token: 0x0401D713 RID: 120595
		[Nullable(2)]
		protected IRogueTipsData Data;
	}
}
