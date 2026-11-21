using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Mono.HotReload
{
	// Token: 0x02000A07 RID: 2567
	internal sealed class InstanceFieldTable
	{
		// Token: 0x0600943A RID: 37946 RVA: 0x00171B3F File Offset: 0x0016FD3F
		internal static FieldStore GetInstanceFieldFieldStore(object inst, IntPtr type, uint fielddef_token)
		{
			return InstanceFieldTable._singleton.GetOrCreateInstanceFields(inst).LookupOrAdd(new RuntimeTypeHandle(type), fielddef_token);
		}

		// Token: 0x0600943B RID: 37947 RVA: 0x00171B58 File Offset: 0x0016FD58
		private InstanceFieldTable()
		{
			this._table = new ConditionalWeakTable<object, InstanceFieldTable.InstanceFields>();
		}

		// Token: 0x0600943C RID: 37948 RVA: 0x00171B6B File Offset: 0x0016FD6B
		private InstanceFieldTable.InstanceFields GetOrCreateInstanceFields(object key)
		{
			return this._table.GetOrCreateValue(key);
		}

		// Token: 0x040022FC RID: 8956
		private static readonly InstanceFieldTable _singleton = new InstanceFieldTable();

		// Token: 0x040022FD RID: 8957
		private readonly ConditionalWeakTable<object, InstanceFieldTable.InstanceFields> _table;

		// Token: 0x02000A08 RID: 2568
		private sealed class InstanceFields
		{
			// Token: 0x0600943E RID: 37950 RVA: 0x00171B85 File Offset: 0x0016FD85
			public InstanceFields()
			{
				this._fields = new Dictionary<uint, FieldStore>();
				this._lock = new object();
			}

			// Token: 0x0600943F RID: 37951 RVA: 0x00171BA4 File Offset: 0x0016FDA4
			[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Hot reload required untrimmed apps")]
			public FieldStore LookupOrAdd(RuntimeTypeHandle type, uint key)
			{
				FieldStore result;
				if (this._fields.TryGetValue(key, out result))
				{
					return result;
				}
				object @lock = this._lock;
				FieldStore result2;
				lock (@lock)
				{
					FieldStore fieldStore;
					if (this._fields.TryGetValue(key, out fieldStore))
					{
						result2 = fieldStore;
					}
					else
					{
						FieldStore fieldStore2 = FieldStore.Create(type);
						this._fields.Add(key, fieldStore2);
						result2 = fieldStore2;
					}
				}
				return result2;
			}

			// Token: 0x040022FE RID: 8958
			private readonly Dictionary<uint, FieldStore> _fields;

			// Token: 0x040022FF RID: 8959
			private readonly object _lock;
		}
	}
}
