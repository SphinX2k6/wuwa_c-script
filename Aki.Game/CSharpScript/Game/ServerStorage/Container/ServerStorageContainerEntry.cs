using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x02004586 RID: 17798
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ServerStorageContainerEntry<[Nullable(2)] T> : ServerStorageEntryBase
	{
		// Token: 0x0602DEB0 RID: 188080
		protected abstract T CreateContainer();

		// Token: 0x0602DEB1 RID: 188081 RVA: 0x00A8EE7D File Offset: 0x00A8D07D
		public T GetContainer()
		{
			if (this.Data == null)
			{
				this.Data = this.CreateContainer();
			}
			return this.Data;
		}

		// Token: 0x0602DEB2 RID: 188082 RVA: 0x00A8EE9E File Offset: 0x00A8D09E
		public ServerStorageContainerEntry(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x04018848 RID: 100424
		[Nullable(2)]
		private T Data;
	}
}
