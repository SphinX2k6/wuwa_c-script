using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed
{
	// Token: 0x02005053 RID: 20563
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenseRolePanel : SolarSpeedRolePanelBase
	{
		// Token: 0x06033765 RID: 210789 RVA: 0x00E69648 File Offset: 0x00E67848
		private UniTask InitDescContent()
		{
			TowerDefenseRolePanel.<InitDescContent>d__1 <InitDescContent>d__;
			<InitDescContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitDescContent>d__.<>4__this = this;
			<InitDescContent>d__.<>1__state = -1;
			<InitDescContent>d__.<>t__builder.Start<TowerDefenseRolePanel.<InitDescContent>d__1>(ref <InitDescContent>d__);
			return <InitDescContent>d__.<>t__builder.Task;
		}

		// Token: 0x06033766 RID: 210790 RVA: 0x00E6968C File Offset: 0x00E6788C
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenseRolePanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenseRolePanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033767 RID: 210791 RVA: 0x00E696CF File Offset: 0x00E678CF
		protected override void OnRefresh(ISolarSpeedRolePanelData data)
		{
			this.DescContent.Refresh((ITowerDefenseRolePanelData)data);
		}

		// Token: 0x0401B55D RID: 111965
		private TowerDefenseRoleDescContent DescContent;
	}
}
