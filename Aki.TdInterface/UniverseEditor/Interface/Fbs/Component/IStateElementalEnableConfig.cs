using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059A7 RID: 22951
	public struct IStateElementalEnableConfig : IFlatbufferObject
	{
		// Token: 0x1700AC3F RID: 44095
		// (get) Token: 0x06026E12 RID: 159250 RVA: 0x00559A95 File Offset: 0x00557C95
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E13 RID: 159251 RVA: 0x00559AA2 File Offset: 0x00557CA2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E14 RID: 159252 RVA: 0x00559AAC File Offset: 0x00557CAC
		public static IStateElementalEnableConfig GetRootAsIStateElementalEnableConfig(ByteBuffer _bb)
		{
			return IStateElementalEnableConfig.GetRootAsIStateElementalEnableConfig(_bb, default(IStateElementalEnableConfig));
		}

		// Token: 0x06026E15 RID: 159253 RVA: 0x00559AC8 File Offset: 0x00557CC8
		public static IStateElementalEnableConfig GetRootAsIStateElementalEnableConfig(ByteBuffer _bb, IStateElementalEnableConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E16 RID: 159254 RVA: 0x00559AE5 File Offset: 0x00557CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E17 RID: 159255 RVA: 0x00559AF4 File Offset: 0x00557CF4
		public IStateElementalEnableConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC40 RID: 44096
		// (get) Token: 0x06026E18 RID: 159256 RVA: 0x00559B04 File Offset: 0x00557D04
		public string State
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E19 RID: 159257 RVA: 0x00559B3B File Offset: 0x00557D3B
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06026E1A RID: 159258 RVA: 0x00559B4A File Offset: 0x00557D4A
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700AC41 RID: 44097
		// (get) Token: 0x06026E1B RID: 159259 RVA: 0x00559B58 File Offset: 0x00557D58
		public bool ElementalEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06026E1C RID: 159260 RVA: 0x00559B97 File Offset: 0x00557D97
		public static Offset<IStateElementalEnableConfig> CreateIStateElementalEnableConfig(FlatBufferBuilder builder, StringOffset StateOffset = default(StringOffset), bool ElementalEnable = false)
		{
			builder.StartTable(2);
			IStateElementalEnableConfig.AddState(builder, StateOffset);
			IStateElementalEnableConfig.AddElementalEnable(builder, ElementalEnable);
			return IStateElementalEnableConfig.EndIStateElementalEnableConfig(builder);
		}

		// Token: 0x06026E1D RID: 159261 RVA: 0x00559BB4 File Offset: 0x00557DB4
		public static void StartIStateElementalEnableConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06026E1E RID: 159262 RVA: 0x00559BBD File Offset: 0x00557DBD
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(0, stateOffset.Value, 0);
		}

		// Token: 0x06026E1F RID: 159263 RVA: 0x00559BCD File Offset: 0x00557DCD
		public static void AddElementalEnable(FlatBufferBuilder builder, bool elementalEnable)
		{
			builder.AddBool(1, elementalEnable, false);
		}

		// Token: 0x06026E20 RID: 159264 RVA: 0x00559BD8 File Offset: 0x00557DD8
		public static Offset<IStateElementalEnableConfig> EndIStateElementalEnableConfig(FlatBufferBuilder builder)
		{
			return new Offset<IStateElementalEnableConfig>(builder.EndTable());
		}

		// Token: 0x06026E21 RID: 159265 RVA: 0x00559BE8 File Offset: 0x00557DE8
		public IStateElementalEnableConfigT UnPack()
		{
			IStateElementalEnableConfigT stateElementalEnableConfigT = new IStateElementalEnableConfigT();
			this.UnPackTo(stateElementalEnableConfigT);
			return stateElementalEnableConfigT;
		}

		// Token: 0x06026E22 RID: 159266 RVA: 0x00559C03 File Offset: 0x00557E03
		public void UnPackTo(IStateElementalEnableConfigT _o)
		{
			_o.State = this.State;
			_o.ElementalEnable = this.ElementalEnable;
		}

		// Token: 0x06026E23 RID: 159267 RVA: 0x00559C20 File Offset: 0x00557E20
		public static Offset<IStateElementalEnableConfig> Pack(FlatBufferBuilder builder, IStateElementalEnableConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStateElementalEnableConfig>);
			}
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			return IStateElementalEnableConfig.CreateIStateElementalEnableConfig(builder, stateOffset, _o.ElementalEnable);
		}

		// Token: 0x0400EFB5 RID: 61365
		private Table __p;
	}
}
