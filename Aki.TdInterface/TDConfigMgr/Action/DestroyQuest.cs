using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001563 RID: 5475
	[NullableContext(1)]
	[Nullable(0)]
	public class DestroyQuest : ActionParams
	{
		// Token: 0x06007BA5 RID: 31653 RVA: 0x00129CB0 File Offset: 0x00127EB0
		private DestroyQuest_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("DestroyQuest 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			DestroyQuest_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new DestroyQuest_SetValue());
			}
			return result;
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x00129CE8 File Offset: 0x00127EE8
		public static DestroyQuest Create([Nullable(2)] DestroyQuest instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyQuest
			{
				FbInstance = instance
			};
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x00129CFB File Offset: 0x00127EFB
		public static DestroyQuest CreateFromSetValue([Nullable(2)] DestroyQuest_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new DestroyQuest
			{
				PocoInterface = value
			};
		}

		// Token: 0x06007BA8 RID: 31656 RVA: 0x00129D0E File Offset: 0x00127F0E
		public DestroyQuest_SetValue ToSetValue()
		{
			return new DestroyQuest_SetValue
			{
				QuestId = this.QuestId,
				IsDestroy = this.IsDestroy
			};
		}

		// Token: 0x170028F9 RID: 10489
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x00129D2D File Offset: 0x00127F2D
		// (set) Token: 0x06007BAA RID: 31658 RVA: 0x00129D58 File Offset: 0x00127F58
		public virtual int QuestId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.QuestId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.QuestId;
			}
			set
			{
				this.GetOrCreatePoco().QuestId = value;
			}
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x00129D68 File Offset: 0x00127F68
		// (set) Token: 0x06007BAC RID: 31660 RVA: 0x00129DA2 File Offset: 0x00127FA2
		public virtual bool? IsDestroy
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsDestroy;
				}
				DestroyQuest_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsDestroy;
			}
			set
			{
				this.GetOrCreatePoco().IsDestroy = value;
			}
		}

		// Token: 0x04004732 RID: 18226
		[Nullable(2)]
		protected new DestroyQuest FbInstance;

		// Token: 0x04004733 RID: 18227
		[Nullable(2)]
		protected DestroyQuest_SetValue PocoInterface;
	}
}
