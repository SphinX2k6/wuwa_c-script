using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B23 RID: 6947
	[NullableContext(1)]
	[Nullable(0)]
	public class IICenterTextShowAll : ICenterTextShowType
	{
		// Token: 0x060094BC RID: 38076 RVA: 0x001583A4 File Offset: 0x001565A4
		private IICenterTextShowAll_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IICenterTextShowAll 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IICenterTextShowAll_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IICenterTextShowAll_SetValue());
			}
			return result;
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x001583DC File Offset: 0x001565DC
		public static IICenterTextShowAll Create([Nullable(2)] IICenterTextShowAll instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IICenterTextShowAll
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x001583EF File Offset: 0x001565EF
		public static IICenterTextShowAll CreateFromSetValue([Nullable(2)] IICenterTextShowAll_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IICenterTextShowAll
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x00158402 File Offset: 0x00156602
		public new IICenterTextShowAll_SetValue ToSetValue()
		{
			return new IICenterTextShowAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002EFF RID: 12031
		// (get) Token: 0x060094C0 RID: 38080 RVA: 0x00158415 File Offset: 0x00156615
		// (set) Token: 0x060094C1 RID: 38081 RVA: 0x00158440 File Offset: 0x00156640
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

		// Token: 0x04005B20 RID: 23328
		[Nullable(2)]
		protected new IICenterTextShowAll FbInstance;

		// Token: 0x04005B21 RID: 23329
		[Nullable(2)]
		protected new IICenterTextShowAll_SetValue PocoInterface;
	}
}
