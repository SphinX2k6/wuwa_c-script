using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubItems
{
	// Token: 0x0200484D RID: 18509
	[NullableContext(2)]
	[Nullable(0)]
	public class HandleCursorButton : UiPanelBase
	{
		// Token: 0x060306FE RID: 198398 RVA: 0x00B3F0E0 File Offset: 0x00B3D2E0
		[NullableContext(1)]
		public UniTask Initialize(UUIItem rootItem, Action onClickCall)
		{
			HandleCursorButton.<Initialize>d__3 <Initialize>d__;
			<Initialize>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Initialize>d__.<>4__this = this;
			<Initialize>d__.rootItem = rootItem;
			<Initialize>d__.onClickCall = onClickCall;
			<Initialize>d__.<>1__state = -1;
			<Initialize>d__.<>t__builder.Start<HandleCursorButton.<Initialize>d__3>(ref <Initialize>d__);
			return <Initialize>d__.<>t__builder.Task;
		}

		// Token: 0x060306FF RID: 198399 RVA: 0x00B3F134 File Offset: 0x00B3D334
		protected override void OnStart()
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetRaycastTarget(false);
			}
			this.Button = (base.GetRootActor().GetComponentByClass(UUIButtonComponent.StaticClass()) as UUIButtonComponent);
			this.Button.OnClickCallBack.Bind(this.ClickCall);
		}

		// Token: 0x06030700 RID: 198400 RVA: 0x00B3F189 File Offset: 0x00B3D389
		protected override void OnBeforeDestroy()
		{
			this.Button.OnClickCallBack.Unbind();
		}

		// Token: 0x06030701 RID: 198401 RVA: 0x00B3F19B File Offset: 0x00B3D39B
		public void SetSelected(bool isSet)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (this.IsSet == isSet)
			{
				return;
			}
			this.IsSet = isSet;
			if (isSet)
			{
				this.Button.SetSelectionState(EUISelectableSelectionState.Highlighted);
				return;
			}
			this.Button.SetSelectionState(EUISelectableSelectionState.Normal);
		}

		// Token: 0x06030702 RID: 198402 RVA: 0x00B3F1D7 File Offset: 0x00B3D3D7
		public void SetCursorActive(bool value)
		{
			if (Info.Instance.IsInGamepad() && value)
			{
				this.SetActive(true);
				return;
			}
			this.SetActive(false);
		}

		// Token: 0x0401A076 RID: 106614
		private bool IsSet;

		// Token: 0x0401A077 RID: 106615
		private UUIButtonComponent Button;

		// Token: 0x0401A078 RID: 106616
		private Action ClickCall;
	}
}
