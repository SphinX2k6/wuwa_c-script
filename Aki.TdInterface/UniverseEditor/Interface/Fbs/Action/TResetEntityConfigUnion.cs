using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007769 RID: 30569
	public class TResetEntityConfigUnion
	{
		// Token: 0x1700E689 RID: 59017
		// (get) Token: 0x06037858 RID: 227416 RVA: 0x00783A0A File Offset: 0x00781C0A
		// (set) Token: 0x06037859 RID: 227417 RVA: 0x00783A12 File Offset: 0x00781C12
		public TResetEntityConfig Type { get; set; }

		// Token: 0x1700E68A RID: 59018
		// (get) Token: 0x0603785A RID: 227418 RVA: 0x00783A1B File Offset: 0x00781C1B
		// (set) Token: 0x0603785B RID: 227419 RVA: 0x00783A23 File Offset: 0x00781C23
		public object Value { get; set; }

		// Token: 0x0603785C RID: 227420 RVA: 0x00783A2C File Offset: 0x00781C2C
		public TResetEntityConfigUnion()
		{
			this.Type = TResetEntityConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603785D RID: 227421 RVA: 0x00783A42 File Offset: 0x00781C42
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603785E RID: 227422 RVA: 0x00783A54 File Offset: 0x00781C54
		public IJigsawItemEntityT AsIJigsawItemEntity()
		{
			return this.As<IJigsawItemEntityT>();
		}

		// Token: 0x0603785F RID: 227423 RVA: 0x00783A5C File Offset: 0x00781C5C
		public static TResetEntityConfigUnion FromIJigsawItemEntity(IJigsawItemEntityT _ijigsawitementity)
		{
			return new TResetEntityConfigUnion
			{
				Type = TResetEntityConfig.IJigsawItemEntity,
				Value = _ijigsawitementity
			};
		}

		// Token: 0x06037860 RID: 227424 RVA: 0x00783A71 File Offset: 0x00781C71
		public IResetTeleControlEntityT AsIResetTeleControlEntity()
		{
			return this.As<IResetTeleControlEntityT>();
		}

		// Token: 0x06037861 RID: 227425 RVA: 0x00783A79 File Offset: 0x00781C79
		public static TResetEntityConfigUnion FromIResetTeleControlEntity(IResetTeleControlEntityT _iresettelecontrolentity)
		{
			return new TResetEntityConfigUnion
			{
				Type = TResetEntityConfig.IResetTeleControlEntity,
				Value = _iresettelecontrolentity
			};
		}

		// Token: 0x06037862 RID: 227426 RVA: 0x00783A90 File Offset: 0x00781C90
		public static int Pack(FlatBufferBuilder builder, TResetEntityConfigUnion _o)
		{
			TResetEntityConfig type = _o.Type;
			if (type == TResetEntityConfig.IJigsawItemEntity)
			{
				return IJigsawItemEntity.Pack(builder, _o.AsIJigsawItemEntity()).Value;
			}
			if (type != TResetEntityConfig.IResetTeleControlEntity)
			{
				return 0;
			}
			return IResetTeleControlEntity.Pack(builder, _o.AsIResetTeleControlEntity()).Value;
		}
	}
}
