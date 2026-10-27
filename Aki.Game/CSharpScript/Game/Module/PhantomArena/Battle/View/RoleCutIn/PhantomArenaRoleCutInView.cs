using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.RoleCutIn
{
	// Token: 0x02005253 RID: 21075
	public class PhantomArenaRoleCutInView : UiTickViewBase
	{
		// Token: 0x06035D9F RID: 220575 RVA: 0x00CBE429 File Offset: 0x00CBC629
		[NullableContext(1)]
		public PhantomArenaRoleCutInView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06035DA0 RID: 220576 RVA: 0x00CBE43D File Offset: 0x00CBC63D
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035DA1 RID: 220577 RVA: 0x00CBE478 File Offset: 0x00CBC678
		protected UniTask LoadRoleSkillTexture()
		{
			PhantomArenaRoleCutInView.<LoadRoleSkillTexture>d__5 <LoadRoleSkillTexture>d__;
			<LoadRoleSkillTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRoleSkillTexture>d__.<>4__this = this;
			<LoadRoleSkillTexture>d__.<>1__state = -1;
			<LoadRoleSkillTexture>d__.<>t__builder.Start<PhantomArenaRoleCutInView.<LoadRoleSkillTexture>d__5>(ref <LoadRoleSkillTexture>d__);
			return <LoadRoleSkillTexture>d__.<>t__builder.Task;
		}

		// Token: 0x06035DA2 RID: 220578 RVA: 0x00CBE4BC File Offset: 0x00CBC6BC
		protected void RefreshSkillName()
		{
			int roleId = PhantomArenaBattleModel.Instance.OwnData.RoleId;
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId);
			int num = phantomBattleCardRole.GetActiveSkillIdBytes().IndexOf(this.Data.SkillId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomBattleCardRole.SkillNameList()[num], Array.Empty<object>());
		}

		// Token: 0x06035DA3 RID: 220579 RVA: 0x00CBE51C File Offset: 0x00CBC71C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleCutInView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleCutInView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035DA4 RID: 220580 RVA: 0x00CBE55F File Offset: 0x00CBC75F
		protected override void OnBeforeDestroy()
		{
			IPhantomArenaRoleCutInData data = this.Data;
			if (data == null)
			{
				return;
			}
			Action closeCallback = data.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x06035DA5 RID: 220581 RVA: 0x00CBE57B File Offset: 0x00CBC77B
		protected override void OnTick(float deltaTime)
		{
			if (this.TickTime < 0f)
			{
				return;
			}
			this.TickTime -= deltaTime;
			if (this.TickTime > 0f)
			{
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0401C8AA RID: 116906
		protected float TickTime = 2000f;

		// Token: 0x0401C8AB RID: 116907
		[Nullable(1)]
		protected IPhantomArenaRoleCutInData Data;

		// Token: 0x0200B407 RID: 46087
		private class EComponentDefine
		{
			// Token: 0x040368D5 RID: 223445
			public const int RoleTexture = 0;

			// Token: 0x040368D6 RID: 223446
			public const int SkillName = 1;
		}
	}
}
