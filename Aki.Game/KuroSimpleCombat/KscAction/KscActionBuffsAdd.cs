using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x02003030 RID: 12336
	[NullableContext(1)]
	[Nullable(0)]
	public class KscActionBuffsAdd : KscActionBase
	{
		// Token: 0x0601D429 RID: 119849 RVA: 0x008EEF94 File Offset: 0x008ED194
		public KscActionBuffsAdd(SimpleCombatEntitySubTypeChangeNotify params_) : base(params_.EntityId)
		{
			this.Params = params_;
		}

		// Token: 0x0601D42A RID: 119850 RVA: 0x008EEFAC File Offset: 0x008ED1AC
		protected override UniTask RunContent()
		{
			KscActionBuffsAdd.<RunContent>d__2 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionBuffsAdd.<RunContent>d__2>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0601D42B RID: 119851 RVA: 0x008EEFF0 File Offset: 0x008ED1F0
		private UniTask AddBuffsAsync(int kscEntityId)
		{
			KscActionBuffsAdd.<AddBuffsAsync>d__3 <AddBuffsAsync>d__;
			<AddBuffsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddBuffsAsync>d__.<>4__this = this;
			<AddBuffsAsync>d__.kscEntityId = kscEntityId;
			<AddBuffsAsync>d__.<>1__state = -1;
			<AddBuffsAsync>d__.<>t__builder.Start<KscActionBuffsAdd.<AddBuffsAsync>d__3>(ref <AddBuffsAsync>d__);
			return <AddBuffsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0400F67C RID: 63100
		public SimpleCombatEntitySubTypeChangeNotify Params;
	}
}
