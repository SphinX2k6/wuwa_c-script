using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200082B RID: 2091
	[NullableContext(1)]
	[Nullable(0)]
	public class LevitateMagnetComponent : IComponentBase
	{
		// Token: 0x06002D87 RID: 11655 RVA: 0x00075F24 File Offset: 0x00074124
		private LevitateMagnetComponent_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LevitateMagnetComponent 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LevitateMagnetComponent_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LevitateMagnetComponent_SetValue());
			}
			return result;
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00075F5C File Offset: 0x0007415C
		public static LevitateMagnetComponent Create([Nullable(2)] LevitateMagnetComponent instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LevitateMagnetComponent
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x00075F6F File Offset: 0x0007416F
		public static LevitateMagnetComponent CreateFromSetValue([Nullable(2)] LevitateMagnetComponent_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LevitateMagnetComponent
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x00075F82 File Offset: 0x00074182
		public new LevitateMagnetComponent_SetValue ToSetValue()
		{
			return new LevitateMagnetComponent_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				MoveSpeed = this.MoveSpeed,
				Test = this.Test
			};
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00075FBC File Offset: 0x000741BC
		// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00075FF6 File Offset: 0x000741F6
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				LevitateMagnetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Disabled;
			}
			set
			{
				this.GetOrCreatePoco().Disabled = value;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002D8D RID: 11661 RVA: 0x00076004 File Offset: 0x00074204
		// (set) Token: 0x06002D8E RID: 11662 RVA: 0x0007602E File Offset: 0x0007422E
		public override bool? EdIsLocked
		{
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdIsLocked;
				}
				return null;
			}
			set
			{
				this.GetOrCreatePoco().EdIsLocked = value;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002D8F RID: 11663 RVA: 0x0007603C File Offset: 0x0007423C
		// (set) Token: 0x06002D90 RID: 11664 RVA: 0x00076067 File Offset: 0x00074267
		public virtual int MoveSpeed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveSpeed;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MoveSpeed;
			}
			set
			{
				this.GetOrCreatePoco().MoveSpeed = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002D91 RID: 11665 RVA: 0x00076078 File Offset: 0x00074278
		// (set) Token: 0x06002D92 RID: 11666 RVA: 0x000760B2 File Offset: 0x000742B2
		public virtual int? Test
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Test;
				}
				LevitateMagnetComponent_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Test;
			}
			set
			{
				this.GetOrCreatePoco().Test = value;
			}
		}

		// Token: 0x04001E22 RID: 7714
		[Nullable(2)]
		protected new LevitateMagnetComponent FbInstance;

		// Token: 0x04001E23 RID: 7715
		[Nullable(2)]
		protected new LevitateMagnetComponent_SetValue PocoInterface;
	}
}
