using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x020044E4 RID: 17636
	[NullableContext(1)]
	[Nullable(0)]
	public class KscActionBuffsAdd : KscActionBase
	{
		// Token: 0x0602D6DF RID: 186079 RVA: 0x00A410FC File Offset: 0x00A3F2FC
		public KscActionBuffsAdd(SimpleCombatEntitySubTypeChangeNotify params_) : base(params_.EntityId)
		{
			this.Params = params_;
		}

		// Token: 0x0602D6E0 RID: 186080 RVA: 0x00A41114 File Offset: 0x00A3F314
		protected override UniTask RunContent()
		{
			KscActionBuffsAdd.<RunContent>d__2 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionBuffsAdd.<RunContent>d__2>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6E1 RID: 186081 RVA: 0x00A41158 File Offset: 0x00A3F358
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

		// Token: 0x040184B1 RID: 99505
		public SimpleCombatEntitySubTypeChangeNotify Params;
	}
}
