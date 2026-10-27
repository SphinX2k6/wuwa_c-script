using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DCA RID: 7626
	[NullableContext(1)]
	[Nullable(0)]
	public class IRogueSelectRoomType
	{
		// Token: 0x0600A353 RID: 41811 RVA: 0x00172EFC File Offset: 0x001710FC
		private IRogueSelectRoomType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRogueSelectRoomType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRogueSelectRoomType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRogueSelectRoomType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x00172F34 File Offset: 0x00171134
		public static IRogueSelectRoomType Create([Nullable(2)] IRogueSelectRoomType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRogueSelectRoomType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x00172F47 File Offset: 0x00171147
		public static IRogueSelectRoomType CreateFromSetValue([Nullable(2)] IRogueSelectRoomType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRogueSelectRoomType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x00172F5A File Offset: 0x0017115A
		public IRogueSelectRoomType_SetValue ToSetValue()
		{
			return new IRogueSelectRoomType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003251 RID: 12881
		// (get) Token: 0x0600A357 RID: 41815 RVA: 0x00172F6D File Offset: 0x0017116D
		// (set) Token: 0x0600A358 RID: 41816 RVA: 0x00172F98 File Offset: 0x00171198
		public virtual ERogueSelectRoomType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERogueSelectRoomType.Role;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061F2 RID: 25074
		[Nullable(2)]
		protected IRogueSelectRoomType FbInstance;

		// Token: 0x040061F3 RID: 25075
		[Nullable(2)]
		protected IRogueSelectRoomType_SetValue PocoInterface;
	}
}
