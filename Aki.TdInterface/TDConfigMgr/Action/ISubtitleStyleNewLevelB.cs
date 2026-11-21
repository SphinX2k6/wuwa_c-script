using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002122 RID: 8482
	public class ISubtitleStyleNewLevelB : ISubtitleStyleBase
	{
		// Token: 0x0600B418 RID: 46104 RVA: 0x00193C7C File Offset: 0x00191E7C
		private ISubtitleStyleNewLevelB_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISubtitleStyleNewLevelB 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISubtitleStyleNewLevelB_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISubtitleStyleNewLevelB_SetValue());
			}
			return result;
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x00193CB4 File Offset: 0x00191EB4
		public static ISubtitleStyleNewLevelB Create([Nullable(2)] ISubtitleStyleNewLevelB instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleNewLevelB
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x00193CC7 File Offset: 0x00191EC7
		public static ISubtitleStyleNewLevelB CreateFromSetValue([Nullable(2)] ISubtitleStyleNewLevelB_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISubtitleStyleNewLevelB
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x00193CDA File Offset: 0x00191EDA
		public new ISubtitleStyleNewLevelB_SetValue ToSetValue()
		{
			return new ISubtitleStyleNewLevelB_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600B41C RID: 46108 RVA: 0x00193CED File Offset: 0x00191EED
		// (set) Token: 0x0600B41D RID: 46109 RVA: 0x00193D18 File Offset: 0x00191F18
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

		// Token: 0x04006AAB RID: 27307
		[Nullable(2)]
		protected new ISubtitleStyleNewLevelB FbInstance;

		// Token: 0x04006AAC RID: 27308
		[Nullable(2)]
		protected new ISubtitleStyleNewLevelB_SetValue PocoInterface;
	}
}
