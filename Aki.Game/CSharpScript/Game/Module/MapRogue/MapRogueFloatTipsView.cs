using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045CE RID: 17870
	public class MapRogueFloatTipsView : UiViewBase
	{
		// Token: 0x0602CF79 RID: 184185 RVA: 0x00C92E11 File Offset: 0x00C91011
		[NullableContext(1)]
		public MapRogueFloatTipsView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602CF7A RID: 184186 RVA: 0x00C92E1A File Offset: 0x00C9101A
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText))
			};
		}

		// Token: 0x0602CF7B RID: 184187 RVA: 0x00C92E40 File Offset: 0x00C91040
		protected override void OnStart()
		{
			this.Data = (this.OpenParam as IRogueTipsData);
			if (this.Data == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), this.Data.TextId, this.Data.TextParam);
		}

		// Token: 0x0602CF7C RID: 184188 RVA: 0x00C92E8E File Offset: 0x00C9108E
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

		// Token: 0x0401819E RID: 98718
		[Nullable(2)]
		protected IRogueTipsData Data;
	}
}
