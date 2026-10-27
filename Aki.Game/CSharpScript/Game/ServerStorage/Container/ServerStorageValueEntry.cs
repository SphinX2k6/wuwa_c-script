using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.ServerStorage.Container
{
	// Token: 0x0200458F RID: 17807
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class ServerStorageValueEntry<T> : ServerStorageEntryBase
	{
		// Token: 0x0602DEE3 RID: 188131 RVA: 0x00A8FCB9 File Offset: 0x00A8DEB9
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

		// Token: 0x0602DEE4 RID: 188132 RVA: 0x00A8FCEF File Offset: 0x00A8DEEF
		public T Get()
		{
			return this.Data;
		}

		// Token: 0x0602DEE5 RID: 188133 RVA: 0x00A8FCF7 File Offset: 0x00A8DEF7
		public ServerStorageValueEntry(EClientStorageSystemIdType key) : base(key)
		{
		}

		// Token: 0x0401884A RID: 100426
		protected T Data;
	}
}
