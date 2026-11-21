using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02005689 RID: 22153
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayRoleMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06036AA1 RID: 223905 RVA: 0x00F416A3 File Offset: 0x00F3F8A3
		[NullableContext(1)]
		public DropCatchGameplayRoleMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06036AA2 RID: 223906 RVA: 0x00F416AC File Offset: 0x00F3F8AC
		public override void Init()
		{
			DropCatchGameplay? gameplayConfig = this.Context.GetProxy().GetGameplayConfig();
			if (gameplayConfig == null)
			{
				Log.Instance.Error(ELogModule.DropCatch, ELogAuthor.CB, "GameplayConfig is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.Role == null)
			{
				this.Role = new DropCatchGameplayRole();
			}
			this.Role.Init(new IDropCatchRoleParams
			{
				RoleId = gameplayConfig.Value.RoleId,
				Context = this.Context
			});
		}

		// Token: 0x06036AA3 RID: 223907 RVA: 0x00F41737 File Offset: 0x00F3F937
		public override void OnReadyTick(float deltaTime)
		{
			IRoleInstance role = this.Role;
			if (role == null)
			{
				return;
			}
			role.OnReadyTick(deltaTime);
		}

		// Token: 0x06036AA4 RID: 223908 RVA: 0x00F4174A File Offset: 0x00F3F94A
		public override void OnTick(float deltaTime)
		{
			IRoleInstance role = this.Role;
			if (role == null)
			{
				return;
			}
			role.OnTick(deltaTime);
		}

		// Token: 0x06036AA5 RID: 223909 RVA: 0x00F4175D File Offset: 0x00F3F95D
		public IRoleInstance GetRole()
		{
			return this.Role;
		}

		// Token: 0x06036AA6 RID: 223910 RVA: 0x00F41765 File Offset: 0x00F3F965
		public override void Destroy()
		{
			this.Role = null;
		}

		// Token: 0x0401CE36 RID: 118326
		private IRoleInstance Role;
	}
}
