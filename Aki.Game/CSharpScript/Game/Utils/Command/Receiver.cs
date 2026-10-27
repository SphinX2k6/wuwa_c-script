using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Command
{
	// Token: 0x02004574 RID: 17780
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class Receiver<[Nullable(0)] T> : IReceiver<T> where T : ICommandType
	{
		// Token: 0x17007589 RID: 30089
		// (get) Token: 0x0602DE57 RID: 187991 RVA: 0x00A8DA63 File Offset: 0x00A8BC63
		// (set) Token: 0x0602DE58 RID: 187992 RVA: 0x00A8DA6B File Offset: 0x00A8BC6B
		[RequiredMember]
		public Action<TCommandHandleParams<T>> ReceiveExecute { get; set; }

		// Token: 0x1700758A RID: 30090
		// (get) Token: 0x0602DE59 RID: 187993 RVA: 0x00A8DA74 File Offset: 0x00A8BC74
		// (set) Token: 0x0602DE5A RID: 187994 RVA: 0x00A8DA7C File Offset: 0x00A8BC7C
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

		// Token: 0x0602DE5B RID: 187995 RVA: 0x00A8DA85 File Offset: 0x00A8BC85
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public Receiver()
		{
		}
	}
}
