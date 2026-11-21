using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005257 RID: 21079
	public class TTargetEntityUnion
	{
		// Token: 0x17009690 RID: 38544
		// (get) Token: 0x060212F7 RID: 135927 RVA: 0x00494894 File Offset: 0x00492A94
		// (set) Token: 0x060212F8 RID: 135928 RVA: 0x0049489C File Offset: 0x00492A9C
		public TTargetEntity Type { get; set; }

		// Token: 0x17009691 RID: 38545
		// (get) Token: 0x060212F9 RID: 135929 RVA: 0x004948A5 File Offset: 0x00492AA5
		// (set) Token: 0x060212FA RID: 135930 RVA: 0x004948AD File Offset: 0x00492AAD
		public object Value { get; set; }

		// Token: 0x060212FB RID: 135931 RVA: 0x004948B6 File Offset: 0x00492AB6
		public TTargetEntityUnion()
		{
			this.Type = TTargetEntity.NONE;
			this.Value = null;
		}

		// Token: 0x060212FC RID: 135932 RVA: 0x004948CC File Offset: 0x00492ACC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060212FD RID: 135933 RVA: 0x004948DE File Offset: 0x00492ADE
		public IPlayerEntityT AsIPlayerEntity()
		{
			return this.As<IPlayerEntityT>();
		}

		// Token: 0x060212FE RID: 135934 RVA: 0x004948E6 File Offset: 0x00492AE6
		public static TTargetEntityUnion FromIPlayerEntity(IPlayerEntityT _iplayerentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.IPlayerEntity,
				Value = _iplayerentity
			};
		}

		// Token: 0x060212FF RID: 135935 RVA: 0x004948FB File Offset: 0x00492AFB
		public ISelfEntityT AsISelfEntity()
		{
			return this.As<ISelfEntityT>();
		}

		// Token: 0x06021300 RID: 135936 RVA: 0x00494903 File Offset: 0x00492B03
		public static TTargetEntityUnion FromISelfEntity(ISelfEntityT _iselfentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ISelfEntity,
				Value = _iselfentity
			};
		}

		// Token: 0x06021301 RID: 135937 RVA: 0x00494918 File Offset: 0x00492B18
		public ITargetEntityT AsITargetEntity()
		{
			return this.As<ITargetEntityT>();
		}

		// Token: 0x06021302 RID: 135938 RVA: 0x00494920 File Offset: 0x00492B20
		public static TTargetEntityUnion FromITargetEntity(ITargetEntityT _itargetentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITargetEntity,
				Value = _itargetentity
			};
		}

		// Token: 0x06021303 RID: 135939 RVA: 0x00494935 File Offset: 0x00492B35
		public ITriggeredEntityT AsITriggeredEntity()
		{
			return this.As<ITriggeredEntityT>();
		}

		// Token: 0x06021304 RID: 135940 RVA: 0x0049493D File Offset: 0x00492B3D
		public static TTargetEntityUnion FromITriggeredEntity(ITriggeredEntityT _itriggeredentity)
		{
			return new TTargetEntityUnion
			{
				Type = TTargetEntity.ITriggeredEntity,
				Value = _itriggeredentity
			};
		}

		// Token: 0x06021305 RID: 135941 RVA: 0x00494954 File Offset: 0x00492B54
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
