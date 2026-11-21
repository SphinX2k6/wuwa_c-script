using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061A5 RID: 24997
	public struct IWoodenOxenAndFlowingHorsesPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700BA6D RID: 47725
		// (get) Token: 0x0602A7CD RID: 174029 RVA: 0x005CB9F9 File Offset: 0x005C9BF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A7CE RID: 174030 RVA: 0x005CBA06 File Offset: 0x005C9C06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A7CF RID: 174031 RVA: 0x005CBA10 File Offset: 0x005C9C10
		public static IWoodenOxenAndFlowingHorsesPerformConfig GetRootAsIWoodenOxenAndFlowingHorsesPerformConfig(ByteBuffer _bb)
		{
			return IWoodenOxenAndFlowingHorsesPerformConfig.GetRootAsIWoodenOxenAndFlowingHorsesPerformConfig(_bb, default(IWoodenOxenAndFlowingHorsesPerformConfig));
		}

		// Token: 0x0602A7D0 RID: 174032 RVA: 0x005CBA2C File Offset: 0x005C9C2C
		public static IWoodenOxenAndFlowingHorsesPerformConfig GetRootAsIWoodenOxenAndFlowingHorsesPerformConfig(ByteBuffer _bb, IWoodenOxenAndFlowingHorsesPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A7D1 RID: 174033 RVA: 0x005CBA49 File Offset: 0x005C9C49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A7D2 RID: 174034 RVA: 0x005CBA58 File Offset: 0x005C9C58
		public IWoodenOxenAndFlowingHorsesPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA6E RID: 47726
		// (get) Token: 0x0602A7D3 RID: 174035 RVA: 0x005CBA68 File Offset: 0x005C9C68
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

		// Token: 0x1700BA6F RID: 47727
		// (get) Token: 0x0602A7D4 RID: 174036 RVA: 0x005CBAC8 File Offset: 0x005C9CC8
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

		// Token: 0x0602A7D5 RID: 174037 RVA: 0x005CBAFF File Offset: 0x005C9CFF
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602A7D6 RID: 174038 RVA: 0x005CBB0E File Offset: 0x005C9D0E
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700BA70 RID: 47728
		// (get) Token: 0x0602A7D7 RID: 174039 RVA: 0x005CBB1C File Offset: 0x005C9D1C
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

		// Token: 0x0602A7D8 RID: 174040 RVA: 0x005CBB79 File Offset: 0x005C9D79
		public static Offset<IWoodenOxenAndFlowingHorsesPerformConfig> CreateIWoodenOxenAndFlowingHorsesPerformConfig(FlatBufferBuilder builder, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), StringOffset MontageOffset = default(StringOffset), Offset<IVectorInfo> RelativeRotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IWoodenOxenAndFlowingHorsesPerformConfig.AddRelativeRot(builder, RelativeRotOffset);
			IWoodenOxenAndFlowingHorsesPerformConfig.AddMontage(builder, MontageOffset);
			IWoodenOxenAndFlowingHorsesPerformConfig.AddOffset(builder, OffsetOffset);
			return IWoodenOxenAndFlowingHorsesPerformConfig.EndIWoodenOxenAndFlowingHorsesPerformConfig(builder);
		}

		// Token: 0x0602A7D9 RID: 174041 RVA: 0x005CBB9D File Offset: 0x005C9D9D
		public static void StartIWoodenOxenAndFlowingHorsesPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A7DA RID: 174042 RVA: 0x005CBBA6 File Offset: 0x005C9DA6
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(0, offsetOffset.Value, 0);
		}

		// Token: 0x0602A7DB RID: 174043 RVA: 0x005CBBB6 File Offset: 0x005C9DB6
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(1, montageOffset.Value, 0);
		}

		// Token: 0x0602A7DC RID: 174044 RVA: 0x005CBBC6 File Offset: 0x005C9DC6
		public static void AddRelativeRot(FlatBufferBuilder builder, Offset<IVectorInfo> relativeRotOffset)
		{
			builder.AddOffset(2, relativeRotOffset.Value, 0);
		}

		// Token: 0x0602A7DD RID: 174045 RVA: 0x005CBBD6 File Offset: 0x005C9DD6
		public static Offset<IWoodenOxenAndFlowingHorsesPerformConfig> EndIWoodenOxenAndFlowingHorsesPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWoodenOxenAndFlowingHorsesPerformConfig>(builder.EndTable());
		}

		// Token: 0x0602A7DE RID: 174046 RVA: 0x005CBBE4 File Offset: 0x005C9DE4
		public IWoodenOxenAndFlowingHorsesPerformConfigT UnPack()
		{
			IWoodenOxenAndFlowingHorsesPerformConfigT woodenOxenAndFlowingHorsesPerformConfigT = new IWoodenOxenAndFlowingHorsesPerformConfigT();
			this.UnPackTo(woodenOxenAndFlowingHorsesPerformConfigT);
			return woodenOxenAndFlowingHorsesPerformConfigT;
		}

		// Token: 0x0602A7DF RID: 174047 RVA: 0x005CBC00 File Offset: 0x005C9E00
		public void UnPackTo(IWoodenOxenAndFlowingHorsesPerformConfigT _o)
		{
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.Montage = this.Montage;
			_o.RelativeRot = ((this.RelativeRot != null) ? this.RelativeRot.Value.UnPack() : null);
		}

		// Token: 0x0602A7E0 RID: 174048 RVA: 0x005CBC78 File Offset: 0x005C9E78
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

		// Token: 0x0400FFF6 RID: 65526
		private Table __p;
	}
}
