using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x02004587 RID: 17799
	public abstract class ServerStorageEntryBase
	{
		// Token: 0x0602DEB3 RID: 188083 RVA: 0x00A8EEA7 File Offset: 0x00A8D0A7
		public ServerStorageEntryBase(EClientStorageSystemIdType key)
		{
			this.Key = key;
		}

		// Token: 0x0602DEB4 RID: 188084
		[NullableContext(1)]
		public abstract void Serialize(ClientStorageInfo info);

		// Token: 0x0602DEB5 RID: 188085
		[NullableContext(2)]
		public abstract ClientStorageInfo Deserialize();

		// Token: 0x0602DEB6 RID: 188086 RVA: 0x00A8EEB6 File Offset: 0x00A8D0B6
		public void MarkDirty()
		{
			ServerStorageModel.Instance.MarkDirty(this.Key);
		}

		// Token: 0x04018849 RID: 100425
		protected EClientStorageSystemIdType Key;
	}
}
