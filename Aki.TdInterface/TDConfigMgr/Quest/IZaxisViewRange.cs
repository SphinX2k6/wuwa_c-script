using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200121A RID: 4634
	[NullableContext(1)]
	[Nullable(0)]
	public class IZaxisViewRange
	{
		// Token: 0x06006916 RID: 26902 RVA: 0x000FA854 File Offset: 0x000F8A54
		private IZaxisViewRange_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IZaxisViewRange 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IZaxisViewRange_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IZaxisViewRange_SetValue());
			}
			return result;
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x000FA88C File Offset: 0x000F8A8C
		public static IZaxisViewRange Create([Nullable(2)] IZaxisViewRange instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IZaxisViewRange
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006918 RID: 26904 RVA: 0x000FA89F File Offset: 0x000F8A9F
		public static IZaxisViewRange CreateFromSetValue([Nullable(2)] IZaxisViewRange_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IZaxisViewRange
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x000FA8B2 File Offset: 0x000F8AB2
		public IZaxisViewRange_SetValue ToSetValue()
		{
			return new IZaxisViewRange_SetValue
			{
				Up = this.Up,
				Down = this.Down
			};
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600691A RID: 26906 RVA: 0x000FA8D4 File Offset: 0x000F8AD4
		// (set) Token: 0x0600691B RID: 26907 RVA: 0x000FA90E File Offset: 0x000F8B0E
		public virtual int? Up
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Up;
				}
				IZaxisViewRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Up;
			}
			set
			{
				this.GetOrCreatePoco().Up = value;
			}
		}

		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x0600691C RID: 26908 RVA: 0x000FA91C File Offset: 0x000F8B1C
		// (set) Token: 0x0600691D RID: 26909 RVA: 0x000FA956 File Offset: 0x000F8B56
		public virtual int? Down
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Down;
				}
				IZaxisViewRange_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Down;
			}
			set
			{
				this.GetOrCreatePoco().Down = value;
			}
		}

		// Token: 0x04003ED6 RID: 16086
		[Nullable(2)]
		protected IZaxisViewRange FbInstance;

		// Token: 0x04003ED7 RID: 16087
		[Nullable(2)]
		protected IZaxisViewRange_SetValue PocoInterface;
	}
}
