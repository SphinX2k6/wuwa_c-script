using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C8E RID: 7310
	public class IHandBookGrantEmojiOption : IHandBookProgressOption
	{
		// Token: 0x06009B50 RID: 39760 RVA: 0x00166E00 File Offset: 0x00165000
		private IHandBookGrantEmojiOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHandBookGrantEmojiOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHandBookGrantEmojiOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHandBookGrantEmojiOption_SetValue());
			}
			return result;
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x00166E38 File Offset: 0x00165038
		public static IHandBookGrantEmojiOption Create([Nullable(2)] IHandBookGrantEmojiOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHandBookGrantEmojiOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x00166E4B File Offset: 0x0016504B
		public static IHandBookGrantEmojiOption CreateFromSetValue([Nullable(2)] IHandBookGrantEmojiOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHandBookGrantEmojiOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x00166E5E File Offset: 0x0016505E
		public new IHandBookGrantEmojiOption_SetValue ToSetValue()
		{
			return new IHandBookGrantEmojiOption_SetValue
			{
				Type = this.Type,
				EmojiIds = this.EmojiIds
			};
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06009B54 RID: 39764 RVA: 0x00166E7D File Offset: 0x0016507D
		// (set) Token: 0x06009B55 RID: 39765 RVA: 0x00166EA8 File Offset: 0x001650A8
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

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06009B56 RID: 39766 RVA: 0x00166EB6 File Offset: 0x001650B6
		// (set) Token: 0x06009B57 RID: 39767 RVA: 0x00166EDD File Offset: 0x001650DD
		public virtual List<int> EmojiIds
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EmojiIds;
				}
				IHandBookGrantEmojiOption_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005F33 RID: 24371
		[Nullable(2)]
		protected new IHandBookGrantEmojiOption FbInstance;

		// Token: 0x04005F34 RID: 24372
		[Nullable(2)]
		protected new IHandBookGrantEmojiOption_SetValue PocoInterface;
	}
}
