using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000292 RID: 658
	public class ICombineDaNpcModel : INpcModelConfig
	{
		// Token: 0x06000BBE RID: 3006 RVA: 0x0002EB5C File Offset: 0x0002CD5C
		private ICombineDaNpcModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICombineDaNpcModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICombineDaNpcModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICombineDaNpcModel_SetValue());
			}
			return result;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0002EB94 File Offset: 0x0002CD94
		public static ICombineDaNpcModel Create([Nullable(2)] ICombineDaNpcModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICombineDaNpcModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0002EBA7 File Offset: 0x0002CDA7
		public static ICombineDaNpcModel CreateFromSetValue([Nullable(2)] ICombineDaNpcModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICombineDaNpcModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0002EBBA File Offset: 0x0002CDBA
		public new ICombineDaNpcModel_SetValue ToSetValue()
		{
			return new ICombineDaNpcModel_SetValue
			{
				Type = this.Type,
				Da = this.Da,
				InitialHiddenAttachTypes = this.InitialHiddenAttachTypes
			};
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0002EBE5 File Offset: 0x0002CDE5
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0002EC10 File Offset: 0x0002CE10
		public override ENpcModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0002EC1E File Offset: 0x0002CE1E
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x0002EC49 File Offset: 0x0002CE49
		public virtual string Da
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Da;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Da;
			}
			set
			{
				this.GetOrCreatePoco().Da = value;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0002EC57 File Offset: 0x0002CE57
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x0002EC7E File Offset: 0x0002CE7E
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<string> InitialHiddenAttachTypes
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InitialHiddenAttachTypes;
				}
				ICombineDaNpcModel_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.InitialHiddenAttachTypes;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().InitialHiddenAttachTypes = value;
			}
		}

		// Token: 0x04000B68 RID: 2920
		[Nullable(2)]
		protected new ICombineDaNpcModel FbInstance;

		// Token: 0x04000B69 RID: 2921
		[Nullable(2)]
		protected new ICombineDaNpcModel_SetValue PocoInterface;
	}
}
