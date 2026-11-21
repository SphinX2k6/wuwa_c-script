using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005685 RID: 22149
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayInputMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06036A42 RID: 223810 RVA: 0x00F3FE91 File Offset: 0x00F3E091
		public DropCatchGameplayInputMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06036A43 RID: 223811 RVA: 0x00F3FEA5 File Offset: 0x00F3E0A5
		public override void Init()
		{
			this.Reset();
			this.RegisterAllChannels();
		}

		// Token: 0x06036A44 RID: 223812 RVA: 0x00F3FEB3 File Offset: 0x00F3E0B3
		public void Reset()
		{
			this.UnregisterAllChannels();
		}

		// Token: 0x06036A45 RID: 223813 RVA: 0x00F3FEBC File Offset: 0x00F3E0BC
		public void Set(EDropCatchGameplayInputChannel channel, EDropCatchGameplayInputSource source, EDropCatchRoleDirection value)
		{
			DropCatchGameplayInput<EDropCatchRoleDirection> dropCatchGameplayInput;
			if (!this.Channels.TryGetValue(channel, out dropCatchGameplayInput))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "InputChannel未注册";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("channel:", channel);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			dropCatchGameplayInput.Set(source, value);
		}

		// Token: 0x06036A46 RID: 223814 RVA: 0x00F3FF14 File Offset: 0x00F3E114
		public EDropCatchRoleDirection Get(EDropCatchGameplayInputChannel channel, EDropCatchRoleDirection fallback)
		{
			DropCatchGameplayInput<EDropCatchRoleDirection> dropCatchGameplayInput;
			if (!this.Channels.TryGetValue(channel, out dropCatchGameplayInput))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "InputChannel未注册";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("channel:", channel);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return fallback;
			}
			return dropCatchGameplayInput.Get(fallback);
		}

		// Token: 0x06036A47 RID: 223815 RVA: 0x00F3FF6C File Offset: 0x00F3E16C
		public void Delete(EDropCatchGameplayInputChannel channel, EDropCatchGameplayInputSource source)
		{
			DropCatchGameplayInput<EDropCatchRoleDirection> dropCatchGameplayInput;
			if (!this.Channels.TryGetValue(channel, out dropCatchGameplayInput))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DropCatch;
				ELogAuthor author = ELogAuthor.CB;
				string message = "InputChannel未注册";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("channel:", channel);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			dropCatchGameplayInput.Delete(source);
		}

		// Token: 0x06036A48 RID: 223816 RVA: 0x00F3FFC0 File Offset: 0x00F3E1C0
		public override void Destroy()
		{
			this.UnregisterAllChannels();
		}

		// Token: 0x06036A49 RID: 223817 RVA: 0x00F3FFC8 File Offset: 0x00F3E1C8
		private void RegisterAllChannels()
		{
			this.RegisterChannel(EDropCatchGameplayInputChannel.MoveDirection);
		}

		// Token: 0x06036A4A RID: 223818 RVA: 0x00F3FFD1 File Offset: 0x00F3E1D1
		private void UnregisterAllChannels()
		{
			this.UnregisterChannel(EDropCatchGameplayInputChannel.MoveDirection);
		}

		// Token: 0x06036A4B RID: 223819 RVA: 0x00F3FFDC File Offset: 0x00F3E1DC
		private void RegisterChannel(EDropCatchGameplayInputChannel channel)
		{
			DropCatchGameplayInput<EDropCatchRoleDirection> input = new DropCatchGameplayInput<EDropCatchRoleDirection>();
			input.Init(delegate(EDropCatchGameplayInputSource? source)
			{
				if (source != null)
				{
					if (source.GetValueOrDefault() == EDropCatchGameplayInputSource.Command)
					{
						DropCatchGameplayView gameplayView = this.Context.GetProxy().GetGameplayView();
						if (gameplayView == null)
						{
							return;
						}
						DropCatchGameplayJoystickView joystickView = gameplayView.GetJoystickView();
						if (joystickView == null)
						{
							return;
						}
						joystickView.SetHandleByDirection(input.Get(EDropCatchRoleDirection.None));
					}
					return;
				}
				DropCatchGameplayView gameplayView2 = this.Context.GetProxy().GetGameplayView();
				if (gameplayView2 == null)
				{
					return;
				}
				DropCatchGameplayJoystickView joystickView2 = gameplayView2.GetJoystickView();
				if (joystickView2 == null)
				{
					return;
				}
				joystickView2.SetHandleByDirection(EDropCatchRoleDirection.None);
			});
			if (this.Channels.ContainsKey(channel))
			{
				this.Channels[channel] = input;
				return;
			}
			this.Channels.Add(channel, input);
		}

		// Token: 0x06036A4C RID: 223820 RVA: 0x00F4004B File Offset: 0x00F3E24B
		private void UnregisterChannel(EDropCatchGameplayInputChannel channel)
		{
			this.Channels.Remove(channel);
		}

		// Token: 0x06036A4D RID: 223821 RVA: 0x00F4005C File Offset: 0x00F3E25C
		public override void OnReadyTick(float deltaTime)
		{
			DropCatchGameplayInput<EDropCatchRoleDirection> dropCatchGameplayInput;
			if (this.Channels.TryGetValue(EDropCatchGameplayInputChannel.MoveDirection, out dropCatchGameplayInput))
			{
				dropCatchGameplayInput.OnTick();
			}
		}

		// Token: 0x06036A4E RID: 223822 RVA: 0x00F40080 File Offset: 0x00F3E280
		public override void OnTick(float deltaTime)
		{
			foreach (DropCatchGameplayInput<EDropCatchRoleDirection> dropCatchGameplayInput in this.Channels.Values)
			{
				dropCatchGameplayInput.OnTick();
			}
			if (this.CommandMoveRemainingTime > 0f)
			{
				this.CommandMoveRemainingTime -= deltaTime;
				if (this.CommandMoveRemainingTime <= 0f)
				{
					this.ClearCommandMoveDirection();
				}
			}
		}

		// Token: 0x06036A4F RID: 223823 RVA: 0x00F40104 File Offset: 0x00F3E304
		public void SetMoveDirectionCommand(EDropCatchRoleDirection direction, float duration)
		{
			this.CommandMoveRemainingTime = duration * (float)TimeUtil.Instance.InverseMillisecond;
			this.Set(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchGameplayInputSource.Command, direction);
		}

		// Token: 0x06036A50 RID: 223824 RVA: 0x00F40122 File Offset: 0x00F3E322
		private void ClearCommandMoveDirection()
		{
			this.CommandMoveRemainingTime = 0f;
			this.Delete(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchGameplayInputSource.Command);
		}

		// Token: 0x0401CE06 RID: 118278
		private readonly Dictionary<EDropCatchGameplayInputChannel, DropCatchGameplayInput<EDropCatchRoleDirection>> Channels = new Dictionary<EDropCatchGameplayInputChannel, DropCatchGameplayInput<EDropCatchRoleDirection>>();

		// Token: 0x0401CE07 RID: 118279
		private float CommandMoveRemainingTime;
	}
}
