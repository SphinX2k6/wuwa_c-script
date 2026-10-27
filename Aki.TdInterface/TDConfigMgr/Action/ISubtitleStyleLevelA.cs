using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EE7 RID: 7911
	[NullableContext(1)]
	[Nullable(0)]
	public class ISubtitleStyleLevelA : ISubtitleStyleBase
	{
		// Token: 0x0600A93E RID: 43326 RVA: 0x0017DBC8 File Offset: 0x0017BDC8
		private ISubtitleStyleLevelA_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubtitleStyleLevelA 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubtitleStyleLevelA_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubtitleStyleLevelA_SetValue());
			}
			return result;
		}

		// Token: 0x0600A93F RID: 43327 RVA: 0x0017DC00 File Offset: 0x0017BE00
		public static ISubtitleStyleLevelA Create([Nullable(2)] ISubtitleStyleLevelA instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleLevelA
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A940 RID: 43328 RVA: 0x0017DC13 File Offset: 0x0017BE13
		public static ISubtitleStyleLevelA CreateFromSetValue([Nullable(2)] ISubtitleStyleLevelA_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubtitleStyleLevelA
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x0017DC26 File Offset: 0x0017BE26
		public new ISubtitleStyleLevelA_SetValue ToSetValue()
		{
			return new ISubtitleStyleLevelA_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700339C RID: 13212
		// (get) Token: 0x0600A942 RID: 43330 RVA: 0x0017DC39 File Offset: 0x0017BE39
		// (set) Token: 0x0600A943 RID: 43331 RVA: 0x0017DC64 File Offset: 0x0017BE64
		public override ESubtitleStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESubtitleStyle.LevelA;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040064B9 RID: 25785
		[Nullable(2)]
		protected new ISubtitleStyleLevelA FbInstance;

		// Token: 0x040064BA RID: 25786
		[Nullable(2)]
		protected new ISubtitleStyleLevelA_SetValue PocoInterface;
	}
}
