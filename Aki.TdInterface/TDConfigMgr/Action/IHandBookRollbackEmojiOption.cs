using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C92 RID: 7314
	public class IHandBookRollbackEmojiOption : IHandBookProgressOption
	{
		// Token: 0x06009B62 RID: 39778 RVA: 0x00166FB8 File Offset: 0x001651B8
		private IHandBookRollbackEmojiOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandBookRollbackEmojiOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandBookRollbackEmojiOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandBookRollbackEmojiOption_SetValue());
			}
			return result;
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x00166FF0 File Offset: 0x001651F0
		public static IHandBookRollbackEmojiOption Create([Nullable(2)] IHandBookRollbackEmojiOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandBookRollbackEmojiOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x00167003 File Offset: 0x00165203
		public static IHandBookRollbackEmojiOption CreateFromSetValue([Nullable(2)] IHandBookRollbackEmojiOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandBookRollbackEmojiOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x00167016 File Offset: 0x00165216
		public new IHandBookRollbackEmojiOption_SetValue ToSetValue()
		{
			return new IHandBookRollbackEmojiOption_SetValue
			{
				Type = this.Type,
				EmojiIds = this.EmojiIds
			};
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06009B66 RID: 39782 RVA: 0x00167035 File Offset: 0x00165235
		// (set) Token: 0x06009B67 RID: 39783 RVA: 0x00167060 File Offset: 0x00165260
		public override EHandBookProgressType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHandBookProgressType.GrantEmoji;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x06009B68 RID: 39784 RVA: 0x0016706E File Offset: 0x0016526E
		// (set) Token: 0x06009B69 RID: 39785 RVA: 0x00167095 File Offset: 0x00165295
		public virtual List<int> EmojiIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmojiIds;
				}
				IHandBookRollbackEmojiOption_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.EmojiIds;
			}
			set
			{
				this.GetOrCreatePoco().EmojiIds = value;
			}
		}

		// Token: 0x04005F3A RID: 24378
		[Nullable(2)]
		protected new IHandBookRollbackEmojiOption FbInstance;

		// Token: 0x04005F3B RID: 24379
		[Nullable(2)]
		protected new IHandBookRollbackEmojiOption_SetValue PocoInterface;
	}
}
