using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02005F71 RID: 24433
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ItemInspectEffectBase
	{
		// Token: 0x0603AC19 RID: 240665 RVA: 0x0109D778 File Offset: 0x0109B978
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

		// Token: 0x0603AC1A RID: 240666 RVA: 0x0109D7FC File Offset: 0x0109B9FC
		public EInteractEffectType? GetEffectType()
		{
			IInteractEffect @params = this.Params;
			if (@params == null)
			{
				return null;
			}
			return new EInteractEffectType?(@params.Type);
		}

		// Token: 0x0603AC1B RID: 240667
		protected abstract void Execute(IInteractEffect @params);

		// Token: 0x0603AC1C RID: 240668 RVA: 0x0109D827 File Offset: 0x0109BA27
		protected void FinishExecute(bool result)
		{
			Action<bool, ItemInspectEffectBase> onFinish = this.OnFinish;
			if (onFinish == null)
			{
				return;
			}
			onFinish(result, this);
		}

		// Token: 0x0401EE3E RID: 126526
		[Nullable(2)]
		private IInteractEffect Params;

		// Token: 0x0401EE3F RID: 126527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Action<bool, ItemInspectEffectBase> OnFinish;
	}
}
