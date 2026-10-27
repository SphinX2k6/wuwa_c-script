using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x02006739 RID: 26425
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchGameplayRoleMgr : DropCatchGameplayBaseMgr
	{
		// Token: 0x06041F55 RID: 270165 RVA: 0x010002F3 File Offset: 0x00FFE4F3
		[NullableContext(1)]
		public DropCatchGameplayRoleMgr(IGameplayLogicContext context) : base(context)
		{
		}

		// Token: 0x06041F56 RID: 270166 RVA: 0x010002FC File Offset: 0x00FFE4FC
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

		// Token: 0x06041F57 RID: 270167 RVA: 0x01000387 File Offset: 0x00FFE587
		public override void OnReadyTick(float deltaTime)
		{
			IRoleInstance role = this.Role;
			if (role == null)
			{
				return;
			}
			role.OnReadyTick(deltaTime);
		}

		// Token: 0x06041F58 RID: 270168 RVA: 0x0100039A File Offset: 0x00FFE59A
		public override void OnTick(float deltaTime)
		{
			IRoleInstance role = this.Role;
			if (role == null)
			{
				return;
			}
			role.OnTick(deltaTime);
		}

		// Token: 0x06041F59 RID: 270169 RVA: 0x010003AD File Offset: 0x00FFE5AD
		public IRoleInstance GetRole()
		{
			return this.Role;
		}

		// Token: 0x06041F5A RID: 270170 RVA: 0x010003B5 File Offset: 0x00FFE5B5
		public override void Destroy()
		{
			this.Role = null;
		}

		// Token: 0x040225DD RID: 140765
		private IRoleInstance Role;
	}
}
