using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Views;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006735 RID: 26421
	[NullableContext(1)]
	[Nullable(0)]
	public class DropCatchGameplayInputMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06041EF6 RID: 270070 RVA: 0x00FFEAC5 File Offset: 0x00FFCCC5
		public DropCatchGameplayInputMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06041EF7 RID: 270071 RVA: 0x00FFEAD9 File Offset: 0x00FFCCD9
		public override void Init()
		{
			this.Reset();
			this.RegisterAllChannels();
		}

		// Token: 0x06041EF8 RID: 270072 RVA: 0x00FFEAE7 File Offset: 0x00FFCCE7
		public void Reset()
		{
			this.UnregisterAllChannels();
		}

		// Token: 0x06041EF9 RID: 270073 RVA: 0x00FFEAF0 File Offset: 0x00FFCCF0
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

		// Token: 0x06041EFA RID: 270074 RVA: 0x00FFEB48 File Offset: 0x00FFCD48
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

		// Token: 0x06041EFB RID: 270075 RVA: 0x00FFEBA0 File Offset: 0x00FFCDA0
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

		// Token: 0x06041EFC RID: 270076 RVA: 0x00FFEBF4 File Offset: 0x00FFCDF4
		public override void Destroy()
		{
			this.UnregisterAllChannels();
		}

		// Token: 0x06041EFD RID: 270077 RVA: 0x00FFEBFC File Offset: 0x00FFCDFC
		private void RegisterAllChannels()
		{
			this.RegisterChannel(EDropCatchGameplayInputChannel.MoveDirection);
		}

		// Token: 0x06041EFE RID: 270078 RVA: 0x00FFEC05 File Offset: 0x00FFCE05
		private void UnregisterAllChannels()
		{
			this.UnregisterChannel(EDropCatchGameplayInputChannel.MoveDirection);
		}

		// Token: 0x06041EFF RID: 270079 RVA: 0x00FFEC10 File Offset: 0x00FFCE10
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

		// Token: 0x06041F00 RID: 270080 RVA: 0x00FFEC7F File Offset: 0x00FFCE7F
		private void UnregisterChannel(EDropCatchGameplayInputChannel channel)
		{
			this.Channels.Remove(channel);
		}

		// Token: 0x06041F01 RID: 270081 RVA: 0x00FFEC90 File Offset: 0x00FFCE90
		public override void OnReadyTick(float deltaTime)
		{
			DropCatchGameplayInput<EDropCatchRoleDirection> dropCatchGameplayInput;
			if (this.Channels.TryGetValue(EDropCatchGameplayInputChannel.MoveDirection, out dropCatchGameplayInput))
			{
				dropCatchGameplayInput.OnTick();
			}
		}

		// Token: 0x06041F02 RID: 270082 RVA: 0x00FFECB4 File Offset: 0x00FFCEB4
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

		// Token: 0x06041F03 RID: 270083 RVA: 0x00FFED38 File Offset: 0x00FFCF38
		public void SetMoveDirectionCommand(EDropCatchRoleDirection direction, float duration)
		{
			this.CommandMoveRemainingTime = duration * (float)TimeUtil.Instance.InverseMillisecond;
			this.Set(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchGameplayInputSource.Command, direction);
		}

		// Token: 0x06041F04 RID: 270084 RVA: 0x00FFED56 File Offset: 0x00FFCF56
		private void ClearCommandMoveDirection()
		{
			this.CommandMoveRemainingTime = 0f;
			this.Delete(EDropCatchGameplayInputChannel.MoveDirection, EDropCatchGameplayInputSource.Command);
		}

		// Token: 0x040225AD RID: 140717
		private readonly Dictionary<EDropCatchGameplayInputChannel, DropCatchGameplayInput<EDropCatchRoleDirection>> Channels = new Dictionary<EDropCatchGameplayInputChannel, DropCatchGameplayInput<EDropCatchRoleDirection>>();

		// Token: 0x040225AE RID: 140718
		private float CommandMoveRemainingTime;
	}
}
