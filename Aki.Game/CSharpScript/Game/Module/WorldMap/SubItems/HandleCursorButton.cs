using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubItems
{
	// Token: 0x0200377E RID: 14206
	[NullableContext(2)]
	[Nullable(0)]
	public class HandleCursorButton : UiPanelBase
	{
		// Token: 0x06024ECD RID: 151245 RVA: 0x00A6F324 File Offset: 0x00A6D524
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

		// Token: 0x06024ECE RID: 151246 RVA: 0x00A6F378 File Offset: 0x00A6D578
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

		// Token: 0x06024ECF RID: 151247 RVA: 0x00A6F3CD File Offset: 0x00A6D5CD
		protected override void OnBeforeDestroy()
		{
			this.Button.OnClickCallBack.Unbind();
		}

		// Token: 0x06024ED0 RID: 151248 RVA: 0x00A6F3DF File Offset: 0x00A6D5DF
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

		// Token: 0x06024ED1 RID: 151249 RVA: 0x00A6F41B File Offset: 0x00A6D61B
		public void SetCursorActive(bool value)
		{
			if (Info.Instance.IsInGamepad() && value)
			{
				this.SetActive(true);
				return;
			}
			this.SetActive(false);
		}

		// Token: 0x0401472A RID: 83754
		private bool IsSet;

		// Token: 0x0401472B RID: 83755
		private UUIButtonComponent Button;

		// Token: 0x0401472C RID: 83756
		private Action ClickCall;
	}
}
