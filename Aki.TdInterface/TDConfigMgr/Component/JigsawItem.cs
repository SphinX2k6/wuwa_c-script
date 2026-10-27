using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200081F RID: 2079
	[NullableContext(2)]
	[Nullable(0)]
	public class JigsawItem : IComponentBase
	{
		// Token: 0x06002D33 RID: 11571 RVA: 0x0007529C File Offset: 0x0007349C
		[NullableContext(1)]
		private JigsawItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("JigsawItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			JigsawItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new JigsawItem_SetValue());
			}
			return result;
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000752D4 File Offset: 0x000734D4
		[NullableContext(1)]
		public static JigsawItem Create([Nullable(2)] JigsawItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new JigsawItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x000752E7 File Offset: 0x000734E7
		[NullableContext(1)]
		public static JigsawItem CreateFromSetValue([Nullable(2)] JigsawItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new JigsawItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x000752FA File Offset: 0x000734FA
		[NullableContext(1)]
		public new JigsawItem_SetValue ToSetValue()
		{
			return new JigsawItem_SetValue
			{
				Disabled = this.Disabled,
				EdIsLocked = this.EdIsLocked,
				FillCfg = this.FillCfg
			};
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x00075328 File Offset: 0x00073528
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x00075362 File Offset: 0x00073562
		public override bool? Disabled
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Disabled;
				}
				JigsawItem_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x00075370 File Offset: 0x00073570
		// (set) Token: 0x06002D3A RID: 11578 RVA: 0x0007539A File Offset: 0x0007359A
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

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000753A8 File Offset: 0x000735A8
		// (set) Token: 0x06002D3C RID: 11580 RVA: 0x000753CF File Offset: 0x000735CF
		public virtual IFillType FillCfg
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FillCfg;
				}
				JigsawItem_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.FillCfg;
			}
			set
			{
				this.GetOrCreatePoco().FillCfg = value;
			}
		}

		// Token: 0x04001DEE RID: 7662
		protected new JigsawItem FbInstance;

		// Token: 0x04001DEF RID: 7663
		protected new JigsawItem_SetValue PocoInterface;
	}
}
