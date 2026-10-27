using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006582 RID: 25986
	public struct IDestroyDynamicEntities : IFlatbufferObject
	{
		// Token: 0x1700C107 RID: 49415
		// (get) Token: 0x0602D137 RID: 184631 RVA: 0x0062F1D6 File Offset: 0x0062D3D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D138 RID: 184632 RVA: 0x0062F1E3 File Offset: 0x0062D3E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D139 RID: 184633 RVA: 0x0062F1EC File Offset: 0x0062D3EC
		public static IDestroyDynamicEntities GetRootAsIDestroyDynamicEntities(ByteBuffer _bb)
		{
			return IDestroyDynamicEntities.GetRootAsIDestroyDynamicEntities(_bb, default(IDestroyDynamicEntities));
		}

		// Token: 0x0602D13A RID: 184634 RVA: 0x0062F208 File Offset: 0x0062D408
		public static IDestroyDynamicEntities GetRootAsIDestroyDynamicEntities(ByteBuffer _bb, IDestroyDynamicEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D13B RID: 184635 RVA: 0x0062F225 File Offset: 0x0062D425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D13C RID: 184636 RVA: 0x0062F234 File Offset: 0x0062D434
		public IDestroyDynamicEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C108 RID: 49416
		// (get) Token: 0x0602D13D RID: 184637 RVA: 0x0062F244 File Offset: 0x0062D444
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

		// Token: 0x0602D13E RID: 184638 RVA: 0x0062F2A1 File Offset: 0x0062D4A1
		public static Offset<IDestroyDynamicEntities> CreateIDestroyDynamicEntities(FlatBufferBuilder builder, Offset<IDestroyVisionDisplay> DestroyEntitiesConfigOffset = default(Offset<IDestroyVisionDisplay>))
		{
			builder.StartTable(1);
			IDestroyDynamicEntities.AddDestroyEntitiesConfig(builder, DestroyEntitiesConfigOffset);
			return IDestroyDynamicEntities.EndIDestroyDynamicEntities(builder);
		}

		// Token: 0x0602D13F RID: 184639 RVA: 0x0062F2B7 File Offset: 0x0062D4B7
		public static void StartIDestroyDynamicEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602D140 RID: 184640 RVA: 0x0062F2C0 File Offset: 0x0062D4C0
		public static void AddDestroyEntitiesConfig(FlatBufferBuilder builder, Offset<IDestroyVisionDisplay> destroyEntitiesConfigOffset)
		{
			builder.AddOffset(0, destroyEntitiesConfigOffset.Value, 0);
		}

		// Token: 0x0602D141 RID: 184641 RVA: 0x0062F2D0 File Offset: 0x0062D4D0
		public static Offset<IDestroyDynamicEntities> EndIDestroyDynamicEntities(FlatBufferBuilder builder)
		{
			return new Offset<IDestroyDynamicEntities>(builder.EndTable());
		}

		// Token: 0x0602D142 RID: 184642 RVA: 0x0062F2E0 File Offset: 0x0062D4E0
		public IDestroyDynamicEntitiesT UnPack()
		{
			IDestroyDynamicEntitiesT destroyDynamicEntitiesT = new IDestroyDynamicEntitiesT();
			this.UnPackTo(destroyDynamicEntitiesT);
			return destroyDynamicEntitiesT;
		}

		// Token: 0x0602D143 RID: 184643 RVA: 0x0062F2FC File Offset: 0x0062D4FC
		public void UnPackTo(IDestroyDynamicEntitiesT _o)
		{
			_o.DestroyEntitiesConfig = ((this.DestroyEntitiesConfig != null) ? this.DestroyEntitiesConfig.Value.UnPack() : null);
		}

		// Token: 0x0602D144 RID: 184644 RVA: 0x0062F338 File Offset: 0x0062D538
		public static Offset<IDestroyDynamicEntities> Pack(FlatBufferBuilder builder, IDestroyDynamicEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroyDynamicEntities>);
			}
			Offset<IDestroyVisionDisplay> destroyEntitiesConfigOffset = (_o.DestroyEntitiesConfig == null) ? default(Offset<IDestroyVisionDisplay>) : IDestroyVisionDisplay.Pack(builder, _o.DestroyEntitiesConfig);
			return IDestroyDynamicEntities.CreateIDestroyDynamicEntities(builder, destroyEntitiesConfigOffset);
		}

		// Token: 0x04010BDA RID: 68570
		private Table __p;
	}
}
