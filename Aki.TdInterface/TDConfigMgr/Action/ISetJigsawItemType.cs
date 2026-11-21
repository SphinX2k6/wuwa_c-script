using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002059 RID: 8281
	public class ISetJigsawItemType
	{
		// Token: 0x0600AFBD RID: 44989 RVA: 0x0018BB84 File Offset: 0x00189D84
		private ISetJigsawItemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetJigsawItemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetJigsawItemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetJigsawItemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AFBE RID: 44990 RVA: 0x0018BBBC File Offset: 0x00189DBC
		public static ISetJigsawItemType Create([Nullable(2)] ISetJigsawItemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetJigsawItemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AFBF RID: 44991 RVA: 0x0018BBCF File Offset: 0x00189DCF
		public static ISetJigsawItemType CreateFromSetValue([Nullable(2)] ISetJigsawItemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetJigsawItemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AFC0 RID: 44992 RVA: 0x0018BBE2 File Offset: 0x00189DE2
		public ISetJigsawItemType_SetValue ToSetValue()
		{
			return new ISetJigsawItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600AFC1 RID: 44993 RVA: 0x0018BBF5 File Offset: 0x00189DF5
		// (set) Token: 0x0600AFC2 RID: 44994 RVA: 0x0018BC20 File Offset: 0x00189E20
		public virtual ESetJigsawItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetJigsawItemType.MoveJigsawItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006898 RID: 26776
		[Nullable(2)]
		protected ISetJigsawItemType FbInstance;

		// Token: 0x04006899 RID: 26777
		[Nullable(2)]
		protected ISetJigsawItemType_SetValue PocoInterface;
	}
}
