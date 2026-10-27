using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x02006352 RID: 25426
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballItemWeaponGridView : PinballItemGridView<PinballWeaponData>
	{
		// Token: 0x0603FFDA RID: 262106 RVA: 0x00F7B402 File Offset: 0x00F79602
		public void BindReduceButtonCallback(Func<IPinballItemButtonCallback, bool> callback)
		{
			this.ReduceButtonCallback = callback;
		}

		// Token: 0x0603FFDB RID: 262107 RVA: 0x00F7B40B File Offset: 0x00F7960B
		public void BindFocusListenerDelegate(Action<IPinballItemToggleCallback> callback)
		{
			this.FocusListenerCallback = callback;
		}

		// Token: 0x0603FFDC RID: 262108 RVA: 0x00F7B414 File Offset: 0x00F79614
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItemToggle().bLockStateOnSelect = true;
		}

		// Token: 0x0603FFDD RID: 262109 RVA: 0x00F7B428 File Offset: 0x00F79628
		public override UniTask RefreshAsync(PinballWeaponData data, bool isSelected, int gridIndex)
		{
			PinballItemWeaponGridView.<RefreshAsync>d__6 <RefreshAsync>d__;
			<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAsync>d__.<>4__this = this;
			<RefreshAsync>d__.data = data;
			<RefreshAsync>d__.<>1__state = -1;
			<RefreshAsync>d__.<>t__builder.Start<PinballItemWeaponGridView.<RefreshAsync>d__6>(ref <RefreshAsync>d__);
			return <RefreshAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FFDE RID: 262110 RVA: 0x00F7B473 File Offset: 0x00F79673
		public override void Refresh(PinballWeaponData data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}

		// Token: 0x040215CE RID: 136654
		[Nullable(2)]
		protected new PinballWeaponData Data;

		// Token: 0x040215CF RID: 136655
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<IPinballItemButtonCallback, bool> ReduceButtonCallback;

		// Token: 0x040215D0 RID: 136656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> FocusListenerCallback;
	}
}
