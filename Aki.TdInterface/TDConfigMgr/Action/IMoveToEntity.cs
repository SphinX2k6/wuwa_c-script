using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E2F RID: 7727
	public class IMoveToEntity : IMoveSceneItemType
	{
		// Token: 0x0600A44F RID: 42063 RVA: 0x001775B8 File Offset: 0x001757B8
		private IMoveToEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoveToEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoveToEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoveToEntity_SetValue());
			}
			return result;
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x001775F0 File Offset: 0x001757F0
		public static IMoveToEntity Create([Nullable(2)] IMoveToEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveToEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x00177603 File Offset: 0x00175803
		public static IMoveToEntity CreateFromSetValue([Nullable(2)] IMoveToEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoveToEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x00177616 File Offset: 0x00175816
		public new IMoveToEntity_SetValue ToSetValue()
		{
			return new IMoveToEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				MoveMotion = this.MoveMotion
			};
		}

		// Token: 0x170032EF RID: 13039
		// (get) Token: 0x0600A453 RID: 42067 RVA: 0x00177641 File Offset: 0x00175841
		// (set) Token: 0x0600A454 RID: 42068 RVA: 0x0017766C File Offset: 0x0017586C
		public override EMoveSceneItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveSceneItemType.MoveToPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032F0 RID: 13040
		// (get) Token: 0x0600A455 RID: 42069 RVA: 0x0017767A File Offset: 0x0017587A
		// (set) Token: 0x0600A456 RID: 42070 RVA: 0x001776A5 File Offset: 0x001758A5
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

		// Token: 0x170032F1 RID: 13041
		// (get) Token: 0x0600A457 RID: 42071 RVA: 0x001776B3 File Offset: 0x001758B3
		// (set) Token: 0x0600A458 RID: 42072 RVA: 0x001776DA File Offset: 0x001758DA
		[Nullable(2)]
		public virtual ISceneItemMoveMotionType MoveMotion
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveMotion;
				}
				IMoveToEntity_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveMotion;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().MoveMotion = value;
			}
		}

		// Token: 0x04006366 RID: 25446
		[Nullable(2)]
		protected new IMoveToEntity FbInstance;

		// Token: 0x04006367 RID: 25447
		[Nullable(2)]
		protected new IMoveToEntity_SetValue PocoInterface;
	}
}
