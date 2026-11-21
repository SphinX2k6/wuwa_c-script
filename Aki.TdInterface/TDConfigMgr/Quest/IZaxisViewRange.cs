using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001356 RID: 4950
	public class IZaxisViewRange
	{
		// Token: 0x06006F57 RID: 28503 RVA: 0x00108160 File Offset: 0x00106360
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

		// Token: 0x06006F58 RID: 28504 RVA: 0x00108198 File Offset: 0x00106398
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

		// Token: 0x06006F59 RID: 28505 RVA: 0x001081AB File Offset: 0x001063AB
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

		// Token: 0x06006F5A RID: 28506 RVA: 0x001081BE File Offset: 0x001063BE
		public IZaxisViewRange_SetValue ToSetValue()
		{
			return new IZaxisViewRange_SetValue
			{
				Up = this.Up,
				Down = this.Down
			};
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x06006F5B RID: 28507 RVA: 0x001081E0 File Offset: 0x001063E0
		// (set) Token: 0x06006F5C RID: 28508 RVA: 0x0010821A File Offset: 0x0010641A
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

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x06006F5D RID: 28509 RVA: 0x00108228 File Offset: 0x00106428
		// (set) Token: 0x06006F5E RID: 28510 RVA: 0x00108262 File Offset: 0x00106462
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

		// Token: 0x04004244 RID: 16964
		[Nullable(2)]
		protected IZaxisViewRange FbInstance;

		// Token: 0x04004245 RID: 16965
		[Nullable(2)]
		protected IZaxisViewRange_SetValue PocoInterface;
	}
}
