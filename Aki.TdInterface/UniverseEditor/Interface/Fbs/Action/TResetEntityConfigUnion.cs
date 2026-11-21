using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F95 RID: 32661
	public class TResetEntityConfigUnion
	{
		// Token: 0x1700F2DB RID: 62171
		// (get) Token: 0x0603ADA1 RID: 241057 RVA: 0x007E8ADA File Offset: 0x007E6CDA
		// (set) Token: 0x0603ADA2 RID: 241058 RVA: 0x007E8AE2 File Offset: 0x007E6CE2
		public TResetEntityConfig Type { get; set; }

		// Token: 0x1700F2DC RID: 62172
		// (get) Token: 0x0603ADA3 RID: 241059 RVA: 0x007E8AEB File Offset: 0x007E6CEB
		// (set) Token: 0x0603ADA4 RID: 241060 RVA: 0x007E8AF3 File Offset: 0x007E6CF3
		public object Value { get; set; }

		// Token: 0x0603ADA5 RID: 241061 RVA: 0x007E8AFC File Offset: 0x007E6CFC
		public TResetEntityConfigUnion()
		{
			this.Type = TResetEntityConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADA6 RID: 241062 RVA: 0x007E8B12 File Offset: 0x007E6D12
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADA7 RID: 241063 RVA: 0x007E8B24 File Offset: 0x007E6D24
		public IJigsawItemEntityT AsIJigsawItemEntity()
		{
			return this.As<IJigsawItemEntityT>();
		}

		// Token: 0x0603ADA8 RID: 241064 RVA: 0x007E8B2C File Offset: 0x007E6D2C
		public static TResetEntityConfigUnion FromIJigsawItemEntity(IJigsawItemEntityT _ijigsawitementity)
		{
			return new TResetEntityConfigUnion
			{
				Type = TResetEntityConfig.IJigsawItemEntity,
				Value = _ijigsawitementity
			};
		}

		// Token: 0x0603ADA9 RID: 241065 RVA: 0x007E8B41 File Offset: 0x007E6D41
		public IResetTeleControlEntityT AsIResetTeleControlEntity()
		{
			return this.As<IResetTeleControlEntityT>();
		}

		// Token: 0x0603ADAA RID: 241066 RVA: 0x007E8B49 File Offset: 0x007E6D49
		public static TResetEntityConfigUnion FromIResetTeleControlEntity(IResetTeleControlEntityT _iresettelecontrolentity)
		{
			return new TResetEntityConfigUnion
			{
				Type = TResetEntityConfig.IResetTeleControlEntity,
				Value = _iresettelecontrolentity
			};
		}

		// Token: 0x0603ADAB RID: 241067 RVA: 0x007E8B60 File Offset: 0x007E6D60
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
