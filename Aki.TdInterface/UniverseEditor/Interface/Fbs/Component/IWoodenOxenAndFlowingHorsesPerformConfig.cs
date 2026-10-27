using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B8F RID: 23439
	public struct IWoodenOxenAndFlowingHorsesPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700B125 RID: 45349
		// (get) Token: 0x06028209 RID: 164361 RVA: 0x00583F69 File Offset: 0x00582169
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602820A RID: 164362 RVA: 0x00583F76 File Offset: 0x00582176
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602820B RID: 164363 RVA: 0x00583F80 File Offset: 0x00582180
		public static IWoodenOxenAndFlowingHorsesPerformConfig GetRootAsIWoodenOxenAndFlowingHorsesPerformConfig(ByteBuffer _bb)
		{
			return IWoodenOxenAndFlowingHorsesPerformConfig.GetRootAsIWoodenOxenAndFlowingHorsesPerformConfig(_bb, default(IWoodenOxenAndFlowingHorsesPerformConfig));
		}

		// Token: 0x0602820C RID: 164364 RVA: 0x00583F9C File Offset: 0x0058219C
		public static IWoodenOxenAndFlowingHorsesPerformConfig GetRootAsIWoodenOxenAndFlowingHorsesPerformConfig(ByteBuffer _bb, IWoodenOxenAndFlowingHorsesPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602820D RID: 164365 RVA: 0x00583FB9 File Offset: 0x005821B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602820E RID: 164366 RVA: 0x00583FC8 File Offset: 0x005821C8
		public IWoodenOxenAndFlowingHorsesPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B126 RID: 45350
		// (get) Token: 0x0602820F RID: 164367 RVA: 0x00583FD8 File Offset: 0x005821D8
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B127 RID: 45351
		// (get) Token: 0x06028210 RID: 164368 RVA: 0x00584038 File Offset: 0x00582238
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028211 RID: 164369 RVA: 0x0058406F File Offset: 0x0058226F
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06028212 RID: 164370 RVA: 0x0058407E File Offset: 0x0058227E
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B128 RID: 45352
		// (get) Token: 0x06028213 RID: 164371 RVA: 0x0058408C File Offset: 0x0058228C
		public IVectorInfo? RelativeRot
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06028214 RID: 164372 RVA: 0x005840E9 File Offset: 0x005822E9
		public static Offset<IWoodenOxenAndFlowingHorsesPerformConfig> CreateIWoodenOxenAndFlowingHorsesPerformConfig(FlatBufferBuilder builder, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), StringOffset MontageOffset = default(StringOffset), Offset<IVectorInfo> RelativeRotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IWoodenOxenAndFlowingHorsesPerformConfig.AddRelativeRot(builder, RelativeRotOffset);
			IWoodenOxenAndFlowingHorsesPerformConfig.AddMontage(builder, MontageOffset);
			IWoodenOxenAndFlowingHorsesPerformConfig.AddOffset(builder, OffsetOffset);
			return IWoodenOxenAndFlowingHorsesPerformConfig.EndIWoodenOxenAndFlowingHorsesPerformConfig(builder);
		}

		// Token: 0x06028215 RID: 164373 RVA: 0x0058410D File Offset: 0x0058230D
		public static void StartIWoodenOxenAndFlowingHorsesPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06028216 RID: 164374 RVA: 0x00584116 File Offset: 0x00582316
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(0, offsetOffset.Value, 0);
		}

		// Token: 0x06028217 RID: 164375 RVA: 0x00584126 File Offset: 0x00582326
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x06028218 RID: 164376 RVA: 0x00584136 File Offset: 0x00582336
		public static void AddRelativeRot(FlatBufferBuilder builder, Offset<IVectorInfo> relativeRotOffset)
		{
			builder.AddOffset(2, relativeRotOffset.Value, 0);
		}

		// Token: 0x06028219 RID: 164377 RVA: 0x00584146 File Offset: 0x00582346
		public static Offset<IWoodenOxenAndFlowingHorsesPerformConfig> EndIWoodenOxenAndFlowingHorsesPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenOxenAndFlowingHorsesPerformConfig>(builder.EndTable());
		}

		// Token: 0x0602821A RID: 164378 RVA: 0x00584154 File Offset: 0x00582354
		public IWoodenOxenAndFlowingHorsesPerformConfigT UnPack()
		{
			IWoodenOxenAndFlowingHorsesPerformConfigT woodenOxenAndFlowingHorsesPerformConfigT = new IWoodenOxenAndFlowingHorsesPerformConfigT();
			this.UnPackTo(woodenOxenAndFlowingHorsesPerformConfigT);
			return woodenOxenAndFlowingHorsesPerformConfigT;
		}

		// Token: 0x0602821B RID: 164379 RVA: 0x00584170 File Offset: 0x00582370
		public void UnPackTo(IWoodenOxenAndFlowingHorsesPerformConfigT _o)
		{
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.Montage = this.Montage;
			_o.RelativeRot = ((this.RelativeRot != null) ? this.RelativeRot.Value.UnPack() : null);
		}

		// Token: 0x0602821C RID: 164380 RVA: 0x005841E8 File Offset: 0x005823E8
		public static Offset<IWoodenOxenAndFlowingHorsesPerformConfig> Pack(FlatBufferBuilder builder, IWoodenOxenAndFlowingHorsesPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWoodenOxenAndFlowingHorsesPerformConfig>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			Offset<IVectorInfo> relativeRotOffset = (_o.RelativeRot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativeRot);
			return IWoodenOxenAndFlowingHorsesPerformConfig.CreateIWoodenOxenAndFlowingHorsesPerformConfig(builder, offsetOffset, montageOffset, relativeRotOffset);
		}

		// Token: 0x0400F2F0 RID: 62192
		private Table __p;
	}
}
