using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B25 RID: 6949
	[NullableContext(1)]
	[Nullable(0)]
	public class IICenterTextTypeWriter : ICenterTextShowType
	{
		// Token: 0x060094C4 RID: 38084 RVA: 0x00158460 File Offset: 0x00156660
		private IICenterTextTypeWriter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IICenterTextTypeWriter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IICenterTextTypeWriter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IICenterTextTypeWriter_SetValue());
			}
			return result;
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x00158498 File Offset: 0x00156698
		public static IICenterTextTypeWriter Create([Nullable(2)] IICenterTextTypeWriter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextTypeWriter
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x001584AB File Offset: 0x001566AB
		public static IICenterTextTypeWriter CreateFromSetValue([Nullable(2)] IICenterTextTypeWriter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IICenterTextTypeWriter
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x001584BE File Offset: 0x001566BE
		public new IICenterTextTypeWriter_SetValue ToSetValue()
		{
			return new IICenterTextTypeWriter_SetValue
			{
				Type = this.Type,
				TextCountPerSecond = this.TextCountPerSecond
			};
		}

		// Token: 0x17002F00 RID: 12032
		// (get) Token: 0x060094C8 RID: 38088 RVA: 0x001584DD File Offset: 0x001566DD
		// (set) Token: 0x060094C9 RID: 38089 RVA: 0x00158508 File Offset: 0x00156708
		public override ECenterTextShowAnim Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECenterTextShowAnim.ShowAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F01 RID: 12033
		// (get) Token: 0x060094CA RID: 38090 RVA: 0x00158516 File Offset: 0x00156716
		// (set) Token: 0x060094CB RID: 38091 RVA: 0x00158541 File Offset: 0x00156741
		public virtual int TextCountPerSecond
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextCountPerSecond;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TextCountPerSecond;
			}
			set
			{
				this.GetOrCreatePoco().TextCountPerSecond = value;
			}
		}

		// Token: 0x04005B23 RID: 23331
		[Nullable(2)]
		protected new IICenterTextTypeWriter FbInstance;

		// Token: 0x04005B24 RID: 23332
		[Nullable(2)]
		protected new IICenterTextTypeWriter_SetValue PocoInterface;
	}
}
