using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x0200146A RID: 5226
	[NullableContext(1)]
	[Nullable(0)]
	public class ITetrisPlayModeMainLine : ITetrisPlayModeBase
	{
		// Token: 0x060076EA RID: 30442 RVA: 0x0011C412 File Offset: 0x0011A612
		public static ITetrisPlayModeMainLine Create(ITetrisPlayModeMainLine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITetrisPlayModeMainLine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170027E9 RID: 10217
		// (get) Token: 0x060076EB RID: 30443 RVA: 0x0011C431 File Offset: 0x0011A631
		public override ETetrisPlayMode Type
		{
			get
			{
				return (ETetrisPlayMode)this.Instance.Type;
			}
		}

		// Token: 0x170027EA RID: 10218
		// (get) Token: 0x060076EC RID: 30444 RVA: 0x0011C43E File Offset: 0x0011A63E
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170027EB RID: 10219
		// (get) Token: 0x060076ED RID: 30445 RVA: 0x0011C44B File Offset: 0x0011A64B
		public virtual string EntityState
		{
			get
			{
				return this.Instance.EntityState;
			}
		}

		// Token: 0x170027EC RID: 10220
		// (get) Token: 0x060076EE RID: 30446 RVA: 0x0011C458 File Offset: 0x0011A658
		public virtual int? FieldHeight
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new int?(this.Instance.FieldHeight);
			}
		}

		// Token: 0x04004520 RID: 17696
		private ITetrisPlayModeMainLine Instance;
	}
}
