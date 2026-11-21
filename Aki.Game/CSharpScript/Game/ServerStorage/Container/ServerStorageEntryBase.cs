using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x020034AF RID: 13487
	public abstract class ServerStorageEntryBase
	{
		// Token: 0x0602259D RID: 140701 RVA: 0x009BB0C7 File Offset: 0x009B92C7
		public ServerStorageEntryBase(EClientStorageSystemIdType key)
		{
			this.Key = key;
		}

		// Token: 0x0602259E RID: 140702
		[NullableContext(1)]
		public abstract void Serialize(ClientStorageInfo info);

		// Token: 0x0602259F RID: 140703
		[NullableContext(2)]
		public abstract ClientStorageInfo Deserialize();

		// Token: 0x060225A0 RID: 140704 RVA: 0x009BB0D6 File Offset: 0x009B92D6
		public void MarkDirty()
		{
			ServerStorageModel.Instance.MarkDirty(this.Key);
		}

		// Token: 0x04012E84 RID: 77444
		protected EClientStorageSystemIdType Key;
	}
}
