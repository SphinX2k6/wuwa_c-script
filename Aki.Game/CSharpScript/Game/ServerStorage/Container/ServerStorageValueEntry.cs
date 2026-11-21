using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x020034B7 RID: 13495
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class ServerStorageValueEntry<T> : ServerStorageEntryBase
	{
		// Token: 0x060225CD RID: 140749 RVA: 0x009BBED9 File Offset: 0x009BA0D9
		[NullableContext(1)]
		public void Set(T value)
		{
			if (this.Data != null && this.Data.Equals(value))
			{
				return;
			}
			this.Data = value;
			base.MarkDirty();
		}

		// Token: 0x060225CE RID: 140750 RVA: 0x009BBF0F File Offset: 0x009BA10F
		public T Get()
		{
			return this.Data;
		}

		// Token: 0x060225CF RID: 140751 RVA: 0x009BBF17 File Offset: 0x009BA117
		public ServerStorageValueEntry(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x04012E85 RID: 77445
		protected T Data;
	}
}
