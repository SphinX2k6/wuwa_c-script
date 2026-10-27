using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D5B RID: 19803
	public class TTargetEntityUnion
	{
		// Token: 0x17008F57 RID: 36695
		// (get) Token: 0x0601F6AE RID: 128686 RVA: 0x004608C0 File Offset: 0x0045EAC0
		// (set) Token: 0x0601F6AF RID: 128687 RVA: 0x004608C8 File Offset: 0x0045EAC8
		public TTargetEntity Type { get; set; }

		// Token: 0x17008F58 RID: 36696
		// (get) Token: 0x0601F6B0 RID: 128688 RVA: 0x004608D1 File Offset: 0x0045EAD1
		// (set) Token: 0x0601F6B1 RID: 128689 RVA: 0x004608D9 File Offset: 0x0045EAD9
		public object Value { get; set; }

		// Token: 0x0601F6B2 RID: 128690 RVA: 0x004608E2 File Offset: 0x0045EAE2
		public TTargetEntityUnion()
		{
			this.Type = TTargetEntity.NONE;
			this.Value = null;
		}

		// Token: 0x0601F6B3 RID: 128691 RVA: 0x004608F8 File Offset: 0x0045EAF8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F6B4 RID: 128692 RVA: 0x0046090A File Offset: 0x0045EB0A
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x0601F6B5 RID: 128693 RVA: 0x00460912 File Offset: 0x0045EB12
		public static TTargetEntityUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x0601F6B6 RID: 128694 RVA: 0x00460927 File Offset: 0x0045EB27
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x0601F6B7 RID: 128695 RVA: 0x0046092F File Offset: 0x0045EB2F
		public static TTargetEntityUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x0601F6B8 RID: 128696 RVA: 0x00460944 File Offset: 0x0045EB44
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x0601F6B9 RID: 128697 RVA: 0x0046094C File Offset: 0x0045EB4C
		public static TTargetEntityUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x0601F6BA RID: 128698 RVA: 0x00460961 File Offset: 0x0045EB61
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x0601F6BB RID: 128699 RVA: 0x00460969 File Offset: 0x0045EB69
		public static TTargetEntityUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x0601F6BC RID: 128700 RVA: 0x00460980 File Offset: 0x0045EB80
		public static int Pack(FlatBufferBuilder builder, TTargetEntityUnion _o)
		{
			switch (_o.Type)
			{
			case TTargetEntity.IPlayerEntity:
				return IPlayerEntity.Pack(builder, _o.AsIPlayerEntity()).Value;
			case TTargetEntity.ISelfEntity:
				return ISelfEntity.Pack(builder, _o.AsISelfEntity()).Value;
			case TTargetEntity.ITargetEntity:
				return ITargetEntity.Pack(builder, _o.AsITargetEntity()).Value;
			case TTargetEntity.ITriggeredEntity:
				return ITriggeredEntity.Pack(builder, _o.AsITriggeredEntity()).Value;
			default:
				return 0;
			}
		}
	}
}
