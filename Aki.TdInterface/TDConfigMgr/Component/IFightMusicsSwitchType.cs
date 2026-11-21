using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C7 RID: 967
	public class IFightMusicsSwitchType
	{
		// Token: 0x06001303 RID: 4867 RVA: 0x0003EAC4 File Offset: 0x0003CCC4
		private IFightMusicsSwitchType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFightMusicsSwitchType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFightMusicsSwitchType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFightMusicsSwitchType_SetValue());
			}
			return result;
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0003EAFC File Offset: 0x0003CCFC
		public static IFightMusicsSwitchType Create([Nullable(2)] IFightMusicsSwitchType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFightMusicsSwitchType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0003EB0F File Offset: 0x0003CD0F
		public static IFightMusicsSwitchType CreateFromSetValue([Nullable(2)] IFightMusicsSwitchType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFightMusicsSwitchType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0003EB22 File Offset: 0x0003CD22
		public IFightMusicsSwitchType_SetValue ToSetValue()
		{
			return new IFightMusicsSwitchType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x0003EB35 File Offset: 0x0003CD35
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x0003EB60 File Offset: 0x0003CD60
		public virtual EFightMusicsSwitchType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFightMusicsSwitchType.SwitchByTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F72 RID: 3954
		[Nullable(2)]
		protected IFightMusicsSwitchType FbInstance;

		// Token: 0x04000F73 RID: 3955
		[Nullable(2)]
		protected IFightMusicsSwitchType_SetValue PocoInterface;
	}
}
