using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02006DF2 RID: 28146
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectEffectBase
	{
		// Token: 0x06044AB5 RID: 281269 RVA: 0x010F34B0 File Offset: 0x010F16B0
		public void ExecuteEffect(IInteractEffect @params, Action<bool, ItemInspectEffectBase> onFinish)
		{
			this.Params = @params;
			this.OnFinish = onFinish;
			float valueOrDefault = @params.DelayTime.GetValueOrDefault();
			if (valueOrDefault <= 0f)
			{
				this.Execute(@params);
				return;
			}
			TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Execute(@params);
			}, valueOrDefault * 1000f, null, null, true, 1f);
		}

		// Token: 0x06044AB6 RID: 281270 RVA: 0x010F3534 File Offset: 0x010F1734
		public EInteractEffectType? GetEffectType()
		{
			IInteractEffect @params = this.Params;
			if (@params == null)
			{
				return null;
			}
			return new EInteractEffectType?(@params.Type);
		}

		// Token: 0x06044AB7 RID: 281271
		protected abstract void Execute(IInteractEffect @params);

		// Token: 0x06044AB8 RID: 281272 RVA: 0x010F355F File Offset: 0x010F175F
		protected void FinishExecute(bool result)
		{
			Action<bool, ItemInspectEffectBase> onFinish = this.OnFinish;
			if (onFinish == null)
			{
				return;
			}
			onFinish(result, this);
		}

		// Token: 0x04023B9C RID: 146332
		[Nullable(2)]
		private IInteractEffect Params;

		// Token: 0x04023B9D RID: 146333
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<bool, ItemInspectEffectBase> OnFinish;
	}
}
