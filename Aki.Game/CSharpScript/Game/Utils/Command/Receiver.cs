using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x0200349C RID: 13468
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class Receiver<[Nullable(0)] T> : IReceiver<T> where T : ICommandType
	{
		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x06022539 RID: 140601 RVA: 0x009B917B File Offset: 0x009B737B
		// (set) Token: 0x0602253A RID: 140602 RVA: 0x009B9183 File Offset: 0x009B7383
		[RequiredMember]
		public Action<TCommandHandleParams<T>> ReceiveExecute { get; set; }

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x0602253B RID: 140603 RVA: 0x009B918C File Offset: 0x009B738C
		// (set) Token: 0x0602253C RID: 140604 RVA: 0x009B9194 File Offset: 0x009B7394
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<TCommandHandleParams<T>> ReceiveUndo { [return: Nullable(new byte[]
		{
			2,
			1,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1,
			1
		})] set; }

		// Token: 0x0602253D RID: 140605 RVA: 0x009B919D File Offset: 0x009B739D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Receiver()
		{
		}
	}
}
