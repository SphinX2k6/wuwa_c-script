using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x020060D5 RID: 24789
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRolePanel : SolarSpeedRolePanelBase
	{
		// Token: 0x0603EAA1 RID: 256673 RVA: 0x00F22880 File Offset: 0x00F20A80
		private UniTask InitDescContent()
		{
			TowerDefenseRolePanel.<InitDescContent>d__1 <InitDescContent>d__;
			<InitDescContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescContent>d__.<>4__this = this;
			<InitDescContent>d__.<>1__state = -1;
			<InitDescContent>d__.<>t__builder.Start<TowerDefenseRolePanel.<InitDescContent>d__1>(ref <InitDescContent>d__);
			return <InitDescContent>d__.<>t__builder.Task;
		}

		// Token: 0x0603EAA2 RID: 256674 RVA: 0x00F228C4 File Offset: 0x00F20AC4
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRolePanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRolePanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EAA3 RID: 256675 RVA: 0x00F22907 File Offset: 0x00F20B07
		protected override void OnRefresh(ISolarSpeedRolePanelData data)
		{
			this.DescContent.Refresh((ITowerDefenseRolePanelData)data);
		}

		// Token: 0x04020C30 RID: 134192
		private TowerDefenseRoleDescContent DescContent;
	}
}
