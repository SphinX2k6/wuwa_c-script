using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AA7 RID: 6823
	public class ICommonTipMissionComplete : ICommonTipType
	{
		// Token: 0x06009101 RID: 37121 RVA: 0x00154AB4 File Offset: 0x00152CB4
		private ICommonTipMissionComplete_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipMissionComplete 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipMissionComplete_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipMissionComplete_SetValue());
			}
			return result;
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x00154AEC File Offset: 0x00152CEC
		public static ICommonTipMissionComplete Create([Nullable(2)] ICommonTipMissionComplete instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipMissionComplete
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x00154AFF File Offset: 0x00152CFF
		public static ICommonTipMissionComplete CreateFromSetValue([Nullable(2)] ICommonTipMissionComplete_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipMissionComplete
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x00154B14 File Offset: 0x00152D14
		public new ICommonTipMissionComplete_SetValue ToSetValue()
		{
			return new ICommonTipMissionComplete_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x06009105 RID: 37125 RVA: 0x00154B62 File Offset: 0x00152D62
		// (set) Token: 0x06009106 RID: 37126 RVA: 0x00154B8D File Offset: 0x00152D8D
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x06009107 RID: 37127 RVA: 0x00154B9B File Offset: 0x00152D9B
		// (set) Token: 0x06009108 RID: 37128 RVA: 0x00154BC6 File Offset: 0x00152DC6
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x06009109 RID: 37129 RVA: 0x00154BD4 File Offset: 0x00152DD4
		// (set) Token: 0x0600910A RID: 37130 RVA: 0x00154BFF File Offset: 0x00152DFF
		public virtual string TidSubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidSubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidSubText;
			}
			set
			{
				this.GetOrCreatePoco().TidSubText = value;
			}
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600910B RID: 37131 RVA: 0x00154C0D File Offset: 0x00152E0D
		// (set) Token: 0x0600910C RID: 37132 RVA: 0x00154C24 File Offset: 0x00152E24
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x17002E96 RID: 11926
		// (get) Token: 0x0600910D RID: 37133 RVA: 0x00154C32 File Offset: 0x00152E32
		// (set) Token: 0x0600910E RID: 37134 RVA: 0x00154C49 File Offset: 0x00152E49
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidSubText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidSubText = value;
			}
		}

		// Token: 0x04005A97 RID: 23191
		[Nullable(2)]
		protected new ICommonTipMissionComplete FbInstance;

		// Token: 0x04005A98 RID: 23192
		[Nullable(2)]
		protected new ICommonTipMissionComplete_SetValue PocoInterface;
	}
}
