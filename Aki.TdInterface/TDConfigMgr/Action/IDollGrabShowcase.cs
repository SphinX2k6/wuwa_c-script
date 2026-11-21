using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B4B RID: 6987
	public class IDollGrabShowcase : IUiGame
	{
		// Token: 0x06009471 RID: 38001 RVA: 0x0015AA9C File Offset: 0x00158C9C
		private IDollGrabShowcase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDollGrabShowcase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDollGrabShowcase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDollGrabShowcase_SetValue());
			}
			return result;
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x0015AAD4 File Offset: 0x00158CD4
		public static IDollGrabShowcase Create([Nullable(2)] IDollGrabShowcase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDollGrabShowcase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x0015AAE7 File Offset: 0x00158CE7
		public static IDollGrabShowcase CreateFromSetValue([Nullable(2)] IDollGrabShowcase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDollGrabShowcase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x0015AAFA File Offset: 0x00158CFA
		public new IDollGrabShowcase_SetValue ToSetValue()
		{
			return new IDollGrabShowcase_SetValue
			{
				Type = this.Type,
				ShowcaseEntityId = this.ShowcaseEntityId
			};
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x06009475 RID: 38005 RVA: 0x0015AB19 File Offset: 0x00158D19
		// (set) Token: 0x06009476 RID: 38006 RVA: 0x0015AB44 File Offset: 0x00158D44
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x06009477 RID: 38007 RVA: 0x0015AB52 File Offset: 0x00158D52
		// (set) Token: 0x06009478 RID: 38008 RVA: 0x0015AB7D File Offset: 0x00158D7D
		public virtual int ShowcaseEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ShowcaseEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ShowcaseEntityId;
			}
			set
			{
				this.GetOrCreatePoco().ShowcaseEntityId = value;
			}
		}

		// Token: 0x04005C17 RID: 23575
		[Nullable(2)]
		protected new IDollGrabShowcase FbInstance;

		// Token: 0x04005C18 RID: 23576
		[Nullable(2)]
		protected new IDollGrabShowcase_SetValue PocoInterface;
	}
}
