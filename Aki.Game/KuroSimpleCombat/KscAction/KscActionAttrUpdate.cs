using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace KuroSimpleCombat.KscAction
{
	// Token: 0x020044E0 RID: 17632
	[NullableContext(1)]
	[Nullable(0)]
	public class KscActionAttrUpdate : KscActionBase
	{
		// Token: 0x0602D6CA RID: 186058 RVA: 0x00A40AC5 File Offset: 0x00A3ECC5
		public KscActionAttrUpdate(long creatureId, SimpleCombatEntityAttributeUpdateNotify data) : base(creatureId)
		{
			this.Data = data;
		}

		// Token: 0x0602D6CB RID: 186059 RVA: 0x00A40AD8 File Offset: 0x00A3ECD8
		protected override UniTask RunContent()
		{
			KscActionAttrUpdate.<RunContent>d__2 <RunContent>d__;
			<RunContent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RunContent>d__.<>4__this = this;
			<RunContent>d__.<>1__state = -1;
			<RunContent>d__.<>t__builder.Start<KscActionAttrUpdate.<RunContent>d__2>(ref <RunContent>d__);
			return <RunContent>d__.<>t__builder.Task;
		}

		// Token: 0x040184A7 RID: 99495
		public SimpleCombatEntityAttributeUpdateNotify Data;
	}
}
