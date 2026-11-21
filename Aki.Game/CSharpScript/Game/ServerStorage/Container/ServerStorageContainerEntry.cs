using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x020034AE RID: 13486
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ServerStorageContainerEntry<[Nullable(2)] T> : ServerStorageEntryBase
	{
		// Token: 0x0602259A RID: 140698
		protected abstract T CreateContainer();

		// Token: 0x0602259B RID: 140699 RVA: 0x009BB09D File Offset: 0x009B929D
		public T GetContainer()
		{
			if (this.Data == null)
			{
				this.Data = this.CreateContainer();
			}
			return this.Data;
		}

		// Token: 0x0602259C RID: 140700 RVA: 0x009BB0BE File Offset: 0x009B92BE
		public ServerStorageContainerEntry(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x04012E83 RID: 77443
		[Nullable(2)]
		private T Data;
	}
}
