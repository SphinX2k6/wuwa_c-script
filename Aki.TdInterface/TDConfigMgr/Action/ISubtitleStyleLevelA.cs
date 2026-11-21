using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002120 RID: 8480
	public class ISubtitleStyleLevelA : ISubtitleStyleBase
	{
		// Token: 0x0600B410 RID: 46096 RVA: 0x00193BC0 File Offset: 0x00191DC0
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

		// Token: 0x0600B411 RID: 46097 RVA: 0x00193BF8 File Offset: 0x00191DF8
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

		// Token: 0x0600B412 RID: 46098 RVA: 0x00193C0B File Offset: 0x00191E0B
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

		// Token: 0x0600B413 RID: 46099 RVA: 0x00193C1E File Offset: 0x00191E1E
		public new ISubtitleStyleLevelA_SetValue ToSetValue()
		{
			return new ISubtitleStyleLevelA_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600B414 RID: 46100 RVA: 0x00193C31 File Offset: 0x00191E31
		// (set) Token: 0x0600B415 RID: 46101 RVA: 0x00193C5C File Offset: 0x00191E5C
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

		// Token: 0x04006AA8 RID: 27304
		[Nullable(2)]
		protected new ISubtitleStyleLevelA FbInstance;

		// Token: 0x04006AA9 RID: 27305
		[Nullable(2)]
		protected new ISubtitleStyleLevelA_SetValue PocoInterface;
	}
}
