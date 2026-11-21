using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Item
{
	// Token: 0x020052D0 RID: 21200
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballItemWeaponGridView : PinballItemGridView<PinballWeaponData>
	{
		// Token: 0x06034C9B RID: 216219 RVA: 0x00EC2362 File Offset: 0x00EC0562
		public void BindReduceButtonCallback(Func<IPinballItemButtonCallback, bool> callback)
		{
			this.ReduceButtonCallback = callback;
		}

		// Token: 0x06034C9C RID: 216220 RVA: 0x00EC236B File Offset: 0x00EC056B
		public void BindFocusListenerDelegate(Action<IPinballItemToggleCallback> callback)
		{
			this.FocusListenerCallback = callback;
		}

		// Token: 0x06034C9D RID: 216221 RVA: 0x00EC2374 File Offset: 0x00EC0574
		protected override void OnStart()
		{
			base.OnStart();
			base.GetItemToggle().bLockStateOnSelect = true;
		}

		// Token: 0x06034C9E RID: 216222 RVA: 0x00EC2388 File Offset: 0x00EC0588
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

		// Token: 0x06034C9F RID: 216223 RVA: 0x00EC23D3 File Offset: 0x00EC05D3
		public override void Refresh(PinballWeaponData data, bool isSelected, int gridIndex)
		{
			this.RefreshAsync(data, isSelected, gridIndex).Forget();
		}

		// Token: 0x0401BEFD RID: 114429
		[Nullable(2)]
		protected new PinballWeaponData Data;

		// Token: 0x0401BEFE RID: 114430
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<IPinballItemButtonCallback, bool> ReduceButtonCallback;

		// Token: 0x0401BEFF RID: 114431
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<IPinballItemToggleCallback> FocusListenerCallback;
	}
}
