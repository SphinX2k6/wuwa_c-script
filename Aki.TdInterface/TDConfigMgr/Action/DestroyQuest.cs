using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016C1 RID: 5825
	public class DestroyQuest : ActionParams
	{
		// Token: 0x06008283 RID: 33411 RVA: 0x00138D5C File Offset: 0x00136F5C
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

		// Token: 0x06008284 RID: 33412 RVA: 0x00138D94 File Offset: 0x00136F94
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

		// Token: 0x06008285 RID: 33413 RVA: 0x00138DA7 File Offset: 0x00136FA7
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

		// Token: 0x06008286 RID: 33414 RVA: 0x00138DBA File Offset: 0x00136FBA
		public DestroyQuest_SetValue ToSetValue()
		{
			return new DestroyQuest_SetValue
			{
				QuestId = this.QuestId,
				IsDestroy = this.IsDestroy
			};
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x06008287 RID: 33415 RVA: 0x00138DD9 File Offset: 0x00136FD9
		// (set) Token: 0x06008288 RID: 33416 RVA: 0x00138E04 File Offset: 0x00137004
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

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x06008289 RID: 33417 RVA: 0x00138E14 File Offset: 0x00137014
		// (set) Token: 0x0600828A RID: 33418 RVA: 0x00138E4E File Offset: 0x0013704E
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

		// Token: 0x04004AD2 RID: 19154
		[Nullable(2)]
		protected new DestroyQuest FbInstance;

		// Token: 0x04004AD3 RID: 19155
		[Nullable(2)]
		protected DestroyQuest_SetValue PocoInterface;
	}
}
