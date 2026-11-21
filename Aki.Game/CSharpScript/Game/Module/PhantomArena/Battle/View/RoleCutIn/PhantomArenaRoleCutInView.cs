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
	// Token: 0x02004223 RID: 16931
	public class PhantomArenaRoleCutInView : UiTickViewBase
	{
		// Token: 0x0602AC9A RID: 175258 RVA: 0x00C0BAB9 File Offset: 0x00C09CB9
		[NullableContext(1)]
		public PhantomArenaRoleCutInView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602AC9B RID: 175259 RVA: 0x00C0BACD File Offset: 0x00C09CCD
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602AC9C RID: 175260 RVA: 0x00C0BB08 File Offset: 0x00C09D08
		protected UniTask LoadRoleSkillTexture()
		{
			PhantomArenaRoleCutInView.<LoadRoleSkillTexture>d__5 <LoadRoleSkillTexture>d__;
			<LoadRoleSkillTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadRoleSkillTexture>d__.<>4__this = this;
			<LoadRoleSkillTexture>d__.<>1__state = -1;
			<LoadRoleSkillTexture>d__.<>t__builder.Start<PhantomArenaRoleCutInView.<LoadRoleSkillTexture>d__5>(ref <LoadRoleSkillTexture>d__);
			return <LoadRoleSkillTexture>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC9D RID: 175261 RVA: 0x00C0BB4C File Offset: 0x00C09D4C
		protected void RefreshSkillName()
		{
			int roleId = PhantomArenaBattleModel.Instance.OwnData.RoleId;
			PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId);
			int num = phantomBattleCardRole.GetActiveSkillIdBytes().IndexOf(this.Data.SkillId);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), phantomBattleCardRole.SkillNameList()[num], Array.Empty<object>());
		}

		// Token: 0x0602AC9E RID: 175262 RVA: 0x00C0BBAC File Offset: 0x00C09DAC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaRoleCutInView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaRoleCutInView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AC9F RID: 175263 RVA: 0x00C0BBEF File Offset: 0x00C09DEF
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

		// Token: 0x0602ACA0 RID: 175264 RVA: 0x00C0BC0B File Offset: 0x00C09E0B
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

		// Token: 0x040172DF RID: 94943
		protected float TickTime = 2000f;

		// Token: 0x040172E0 RID: 94944
		[Nullable(1)]
		protected IPhantomArenaRoleCutInData Data;

		// Token: 0x02009E3F RID: 40511
		private class EComponentDefine
		{
			// Token: 0x04031328 RID: 201512
			public const int RoleTexture = 0;

			// Token: 0x04031329 RID: 201513
			public const int SkillName = 1;
		}
	}
}
