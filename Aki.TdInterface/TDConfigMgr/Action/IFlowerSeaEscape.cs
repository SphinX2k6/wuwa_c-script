using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A8F RID: 6799
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowerSeaEscape : IUiGame
	{
		// Token: 0x06009198 RID: 37272 RVA: 0x00152C98 File Offset: 0x00150E98
		private IFlowerSeaEscape_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowerSeaEscape 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowerSeaEscape_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowerSeaEscape_SetValue());
			}
			return result;
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x00152CD0 File Offset: 0x00150ED0
		public static IFlowerSeaEscape Create([Nullable(2)] IFlowerSeaEscape instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowerSeaEscape
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x00152CE3 File Offset: 0x00150EE3
		public static IFlowerSeaEscape CreateFromSetValue([Nullable(2)] IFlowerSeaEscape_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowerSeaEscape
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x00152CF8 File Offset: 0x00150EF8
		public new IFlowerSeaEscape_SetValue ToSetValue()
		{
			return new IFlowerSeaEscape_SetValue
			{
				Type = this.Type,
				EndAreaEntityId = this.EndAreaEntityId,
				ConfigDa = this.ConfigDa,
				SpreadingState = this.SpreadingState,
				PausedState = this.PausedState,
				ResetState = this.ResetState
			};
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600919C RID: 37276 RVA: 0x00152D52 File Offset: 0x00150F52
		// (set) Token: 0x0600919D RID: 37277 RVA: 0x00152D7D File Offset: 0x00150F7D
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E4C RID: 11852
		// (get) Token: 0x0600919E RID: 37278 RVA: 0x00152D8B File Offset: 0x00150F8B
		// (set) Token: 0x0600919F RID: 37279 RVA: 0x00152DB6 File Offset: 0x00150FB6
		public virtual int EndAreaEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EndAreaEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EndAreaEntityId;
			}
			set
			{
				this.GetOrCreatePoco().EndAreaEntityId = value;
			}
		}

		// Token: 0x17002E4D RID: 11853
		// (get) Token: 0x060091A0 RID: 37280 RVA: 0x00152DC4 File Offset: 0x00150FC4
		// (set) Token: 0x060091A1 RID: 37281 RVA: 0x00152DEF File Offset: 0x00150FEF
		public virtual string ConfigDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ConfigDa;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ConfigDa;
			}
			set
			{
				this.GetOrCreatePoco().ConfigDa = value;
			}
		}

		// Token: 0x17002E4E RID: 11854
		// (get) Token: 0x060091A2 RID: 37282 RVA: 0x00152DFD File Offset: 0x00150FFD
		// (set) Token: 0x060091A3 RID: 37283 RVA: 0x00152E28 File Offset: 0x00151028
		public virtual string SpreadingState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpreadingState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SpreadingState;
			}
			set
			{
				this.GetOrCreatePoco().SpreadingState = value;
			}
		}

		// Token: 0x17002E4F RID: 11855
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x00152E36 File Offset: 0x00151036
		// (set) Token: 0x060091A5 RID: 37285 RVA: 0x00152E61 File Offset: 0x00151061
		public virtual string PausedState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PausedState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.PausedState;
			}
			set
			{
				this.GetOrCreatePoco().PausedState = value;
			}
		}

		// Token: 0x17002E50 RID: 11856
		// (get) Token: 0x060091A6 RID: 37286 RVA: 0x00152E6F File Offset: 0x0015106F
		// (set) Token: 0x060091A7 RID: 37287 RVA: 0x00152E9A File Offset: 0x0015109A
		public virtual string ResetState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ResetState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ResetState;
			}
			set
			{
				this.GetOrCreatePoco().ResetState = value;
			}
		}

		// Token: 0x040059C0 RID: 22976
		[Nullable(2)]
		protected new IFlowerSeaEscape FbInstance;

		// Token: 0x040059C1 RID: 22977
		[Nullable(2)]
		protected new IFlowerSeaEscape_SetValue PocoInterface;
	}
}
