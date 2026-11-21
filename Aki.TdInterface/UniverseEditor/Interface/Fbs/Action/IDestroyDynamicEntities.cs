using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BEA RID: 27626
	public struct IDestroyDynamicEntities : IFlatbufferObject
	{
		// Token: 0x1700CA96 RID: 51862
		// (get) Token: 0x0602F8BB RID: 194747 RVA: 0x0067B39A File Offset: 0x0067959A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F8BC RID: 194748 RVA: 0x0067B3A7 File Offset: 0x006795A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F8BD RID: 194749 RVA: 0x0067B3B0 File Offset: 0x006795B0
		public static IDestroyDynamicEntities GetRootAsIDestroyDynamicEntities(ByteBuffer _bb)
		{
			return IDestroyDynamicEntities.GetRootAsIDestroyDynamicEntities(_bb, default(IDestroyDynamicEntities));
		}

		// Token: 0x0602F8BE RID: 194750 RVA: 0x0067B3CC File Offset: 0x006795CC
		public static IDestroyDynamicEntities GetRootAsIDestroyDynamicEntities(ByteBuffer _bb, IDestroyDynamicEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F8BF RID: 194751 RVA: 0x0067B3E9 File Offset: 0x006795E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F8C0 RID: 194752 RVA: 0x0067B3F8 File Offset: 0x006795F8
		public IDestroyDynamicEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA97 RID: 51863
		// (get) Token: 0x0602F8C1 RID: 194753 RVA: 0x0067B408 File Offset: 0x00679608
		public IDestroyVisionDisplay? DestroyEntitiesConfig
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDestroyVisionDisplay?(default(IDestroyVisionDisplay).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602F8C2 RID: 194754 RVA: 0x0067B465 File Offset: 0x00679665
		public static Offset<IDestroyDynamicEntities> CreateIDestroyDynamicEntities(FlatBufferBuilder builder, Offset<IDestroyVisionDisplay> DestroyEntitiesConfigOffset = default(Offset<IDestroyVisionDisplay>))
		{
			builder.StartTable(1);
			IDestroyDynamicEntities.AddDestroyEntitiesConfig(builder, DestroyEntitiesConfigOffset);
			return IDestroyDynamicEntities.EndIDestroyDynamicEntities(builder);
		}

		// Token: 0x0602F8C3 RID: 194755 RVA: 0x0067B47B File Offset: 0x0067967B
		public static void StartIDestroyDynamicEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F8C4 RID: 194756 RVA: 0x0067B484 File Offset: 0x00679684
		public static void AddDestroyEntitiesConfig(FlatBufferBuilder builder, Offset<IDestroyVisionDisplay> destroyEntitiesConfigOffset)
		{
			builder.AddOffset(0, destroyEntitiesConfigOffset.Value, 0);
		}

		// Token: 0x0602F8C5 RID: 194757 RVA: 0x0067B494 File Offset: 0x00679694
		public static Offset<IDestroyDynamicEntities> EndIDestroyDynamicEntities(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyDynamicEntities>(builder.EndTable());
		}

		// Token: 0x0602F8C6 RID: 194758 RVA: 0x0067B4A4 File Offset: 0x006796A4
		public IDestroyDynamicEntitiesT UnPack()
		{
			IDestroyDynamicEntitiesT destroyDynamicEntitiesT = new IDestroyDynamicEntitiesT();
			this.UnPackTo(destroyDynamicEntitiesT);
			return destroyDynamicEntitiesT;
		}

		// Token: 0x0602F8C7 RID: 194759 RVA: 0x0067B4C0 File Offset: 0x006796C0
		public void UnPackTo(IDestroyDynamicEntitiesT _o)
		{
			_o.DestroyEntitiesConfig = ((this.DestroyEntitiesConfig != null) ? this.DestroyEntitiesConfig.Value.UnPack() : null);
		}

		// Token: 0x0602F8C8 RID: 194760 RVA: 0x0067B4FC File Offset: 0x006796FC
		public static Offset<IDestroyDynamicEntities> Pack(FlatBufferBuilder builder, IDestroyDynamicEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyDynamicEntities>);
			}
			Offset<IDestroyVisionDisplay> destroyEntitiesConfigOffset = (_o.DestroyEntitiesConfig == null) ? default(Offset<IDestroyVisionDisplay>) : IDestroyVisionDisplay.Pack(builder, _o.DestroyEntitiesConfig);
			return IDestroyDynamicEntities.CreateIDestroyDynamicEntities(builder, destroyEntitiesConfigOffset);
		}

		// Token: 0x040119EC RID: 72172
		private Table __p;
	}
}
