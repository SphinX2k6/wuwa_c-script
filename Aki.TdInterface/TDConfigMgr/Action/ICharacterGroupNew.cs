using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A09 RID: 6665
	public class ICharacterGroupNew
	{
		// Token: 0x06008DDF RID: 36319 RVA: 0x0014F594 File Offset: 0x0014D794
		private ICharacterGroupNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterGroupNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterGroupNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterGroupNew_SetValue());
			}
			return result;
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x0014F5CC File Offset: 0x0014D7CC
		public static ICharacterGroupNew Create([Nullable(2)] ICharacterGroupNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterGroupNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008DE1 RID: 36321 RVA: 0x0014F5DF File Offset: 0x0014D7DF
		public static ICharacterGroupNew CreateFromSetValue([Nullable(2)] ICharacterGroupNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterGroupNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x0014F5F2 File Offset: 0x0014D7F2
		public ICharacterGroupNew_SetValue ToSetValue()
		{
			return new ICharacterGroupNew_SetValue
			{
				CharacterId = this.CharacterId,
				IsAiCharacter = this.IsAiCharacter
			};
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x06008DE3 RID: 36323 RVA: 0x0014F611 File Offset: 0x0014D811
		// (set) Token: 0x06008DE4 RID: 36324 RVA: 0x0014F63C File Offset: 0x0014D83C
		public virtual int CharacterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CharacterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CharacterId;
			}
			set
			{
				this.GetOrCreatePoco().CharacterId = value;
			}
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x06008DE5 RID: 36325 RVA: 0x0014F64A File Offset: 0x0014D84A
		// (set) Token: 0x06008DE6 RID: 36326 RVA: 0x0014F675 File Offset: 0x0014D875
		public virtual bool IsAiCharacter
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAiCharacter;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAiCharacter;
			}
			set
			{
				this.GetOrCreatePoco().IsAiCharacter = value;
			}
		}

		// Token: 0x04005937 RID: 22839
		[Nullable(2)]
		protected ICharacterGroupNew FbInstance;

		// Token: 0x04005938 RID: 22840
		[Nullable(2)]
		protected ICharacterGroupNew_SetValue PocoInterface;
	}
}
