using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002011 RID: 8209
	public class ISceneUiSubtitlePositionEntity : ISceneUiSubtitlePositionBase
	{
		// Token: 0x0600AE4D RID: 44621 RVA: 0x00189154 File Offset: 0x00187354
		private ISceneUiSubtitlePositionEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitlePositionEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitlePositionEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitlePositionEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x0018918C File Offset: 0x0018738C
		public static ISceneUiSubtitlePositionEntity Create([Nullable(2)] ISceneUiSubtitlePositionEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePositionEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x0018919F File Offset: 0x0018739F
		public static ISceneUiSubtitlePositionEntity CreateFromSetValue([Nullable(2)] ISceneUiSubtitlePositionEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePositionEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x001891B2 File Offset: 0x001873B2
		public new ISceneUiSubtitlePositionEntity_SetValue ToSetValue()
		{
			return new ISceneUiSubtitlePositionEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600AE51 RID: 44625 RVA: 0x001891D1 File Offset: 0x001873D1
		// (set) Token: 0x0600AE52 RID: 44626 RVA: 0x001891FC File Offset: 0x001873FC
		public override ESceneUiSubtitlePositionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitlePositionType.Position;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600AE53 RID: 44627 RVA: 0x0018920A File Offset: 0x0018740A
		// (set) Token: 0x0600AE54 RID: 44628 RVA: 0x00189235 File Offset: 0x00187435
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x040067EC RID: 26604
		[Nullable(2)]
		protected new ISceneUiSubtitlePositionEntity FbInstance;

		// Token: 0x040067ED RID: 26605
		[Nullable(2)]
		protected new ISceneUiSubtitlePositionEntity_SetValue PocoInterface;
	}
}
