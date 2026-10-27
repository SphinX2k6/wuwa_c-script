using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE0 RID: 7648
	[NullableContext(1)]
	[Nullable(0)]
	[JsonConverter(typeof(ISceneInteractionOperationTypeConverter))]
	public class ISceneInteractionOperationType
	{
		// Token: 0x0600A3BB RID: 41915 RVA: 0x00173AE4 File Offset: 0x00171CE4
		private ISceneInteractionOperationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneInteractionOperationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneInteractionOperationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneInteractionOperationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3BC RID: 41916 RVA: 0x00173B1C File Offset: 0x00171D1C
		public static ISceneInteractionOperationType Create([Nullable(2)] ISceneInteractionOperationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneInteractionOperationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3BD RID: 41917 RVA: 0x00173B2F File Offset: 0x00171D2F
		public static ISceneInteractionOperationType CreateFromSetValue([Nullable(2)] ISceneInteractionOperationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneInteractionOperationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x00173B42 File Offset: 0x00171D42
		public ISceneInteractionOperationType_SetValue ToSetValue()
		{
			return new ISceneInteractionOperationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600A3BF RID: 41919 RVA: 0x00173B55 File Offset: 0x00171D55
		// (set) Token: 0x0600A3C0 RID: 41920 RVA: 0x00173B80 File Offset: 0x00171D80
		public virtual ESceneInteractionOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneInteractionOperationType.Enable;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006225 RID: 25125
		[Nullable(2)]
		protected ISceneInteractionOperationType FbInstance;

		// Token: 0x04006226 RID: 25126
		[Nullable(2)]
		protected ISceneInteractionOperationType_SetValue PocoInterface;
	}
}
