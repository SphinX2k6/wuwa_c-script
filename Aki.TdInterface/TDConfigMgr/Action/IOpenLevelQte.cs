using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C9E RID: 7326
	[NullableContext(1)]
	[Nullable(0)]
	public class IOpenLevelQte : IOpenQteConfig
	{
		// Token: 0x06009D37 RID: 40247 RVA: 0x001682F0 File Offset: 0x001664F0
		private IOpenLevelQte_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenLevelQte 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenLevelQte_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenLevelQte_SetValue());
			}
			return result;
		}

		// Token: 0x06009D38 RID: 40248 RVA: 0x00168328 File Offset: 0x00166528
		public static IOpenLevelQte Create([Nullable(2)] IOpenLevelQte instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenLevelQte
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009D39 RID: 40249 RVA: 0x0016833B File Offset: 0x0016653B
		public static IOpenLevelQte CreateFromSetValue([Nullable(2)] IOpenLevelQte_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenLevelQte
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x0016834E File Offset: 0x0016654E
		public new IOpenLevelQte_SetValue ToSetValue()
		{
			return new IOpenLevelQte_SetValue
			{
				Type = this.Type,
				LevelQteEntity = this.LevelQteEntity
			};
		}

		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x06009D3B RID: 40251 RVA: 0x0016836D File Offset: 0x0016656D
		// (set) Token: 0x06009D3C RID: 40252 RVA: 0x00168398 File Offset: 0x00166598
		public override EOpenQteType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EOpenQteType.PanelQte;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x06009D3D RID: 40253 RVA: 0x001683A6 File Offset: 0x001665A6
		// (set) Token: 0x06009D3E RID: 40254 RVA: 0x001683CD File Offset: 0x001665CD
		public virtual ITargetEntityType LevelQteEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.LevelQteEntity;
				}
				IOpenLevelQte_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.LevelQteEntity;
			}
			set
			{
				this.GetOrCreatePoco().LevelQteEntity = value;
			}
		}

		// Token: 0x04005F34 RID: 24372
		[Nullable(2)]
		protected new IOpenLevelQte FbInstance;

		// Token: 0x04005F35 RID: 24373
		[Nullable(2)]
		protected new IOpenLevelQte_SetValue PocoInterface;
	}
}
