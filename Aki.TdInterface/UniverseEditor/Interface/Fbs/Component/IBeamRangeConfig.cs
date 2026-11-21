using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543F RID: 21567
	public struct IBeamRangeConfig : IFlatbufferObject
	{
		// Token: 0x1700992E RID: 39214
		// (get) Token: 0x06021D2A RID: 138538 RVA: 0x004A99EE File Offset: 0x004A7BEE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021D2B RID: 138539 RVA: 0x004A99FB File Offset: 0x004A7BFB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021D2C RID: 138540 RVA: 0x004A9A04 File Offset: 0x004A7C04
		public static IBeamRangeConfig GetRootAsIBeamRangeConfig(ByteBuffer _bb)
		{
			return IBeamRangeConfig.GetRootAsIBeamRangeConfig(_bb, default(IBeamRangeConfig));
		}

		// Token: 0x06021D2D RID: 138541 RVA: 0x004A9A20 File Offset: 0x004A7C20
		public static IBeamRangeConfig GetRootAsIBeamRangeConfig(ByteBuffer _bb, IBeamRangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021D2E RID: 138542 RVA: 0x004A9A3D File Offset: 0x004A7C3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021D2F RID: 138543 RVA: 0x004A9A4C File Offset: 0x004A7C4C
		public IBeamRangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700992F RID: 39215
		// (get) Token: 0x06021D30 RID: 138544 RVA: 0x004A9A5C File Offset: 0x004A7C5C
		public float Radius
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009930 RID: 39216
		// (get) Token: 0x06021D31 RID: 138545 RVA: 0x004A9A9C File Offset: 0x004A7C9C
		public float Length
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009931 RID: 39217
		// (get) Token: 0x06021D32 RID: 138546 RVA: 0x004A9ADC File Offset: 0x004A7CDC
		public IVectorInfo? PosOffset
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

		// Token: 0x06021D33 RID: 138547 RVA: 0x004A9B39 File Offset: 0x004A7D39
		public static Offset<IBeamRangeConfig> CreateIBeamRangeConfig(FlatBufferBuilder builder, float Radius = 0f, float Length = 0f, Offset<IVectorInfo> PosOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IBeamRangeConfig.AddPosOffset(builder, PosOffsetOffset);
			IBeamRangeConfig.AddLength(builder, Length);
			IBeamRangeConfig.AddRadius(builder, Radius);
			return IBeamRangeConfig.EndIBeamRangeConfig(builder);
		}

		// Token: 0x06021D34 RID: 138548 RVA: 0x004A9B5D File Offset: 0x004A7D5D
		public static void StartIBeamRangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06021D35 RID: 138549 RVA: 0x004A9B66 File Offset: 0x004A7D66
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x06021D36 RID: 138550 RVA: 0x004A9B79 File Offset: 0x004A7D79
		public static void AddLength(FlatBufferBuilder builder, float length)
		{
			builder.AddFloat(1, length, 0.0);
		}

		// Token: 0x06021D37 RID: 138551 RVA: 0x004A9B8C File Offset: 0x004A7D8C
		public static void AddPosOffset(FlatBufferBuilder builder, Offset<IVectorInfo> posOffsetOffset)
		{
			builder.AddOffset(2, posOffsetOffset.Value, 0);
		}

		// Token: 0x06021D38 RID: 138552 RVA: 0x004A9B9C File Offset: 0x004A7D9C
		public static Offset<IBeamRangeConfig> EndIBeamRangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBeamRangeConfig>(builder.EndTable());
		}

		// Token: 0x06021D39 RID: 138553 RVA: 0x004A9BAC File Offset: 0x004A7DAC
		public IBeamRangeConfigT UnPack()
		{
			IBeamRangeConfigT beamRangeConfigT = new IBeamRangeConfigT();
			this.UnPackTo(beamRangeConfigT);
			return beamRangeConfigT;
		}

		// Token: 0x06021D3A RID: 138554 RVA: 0x004A9BC8 File Offset: 0x004A7DC8
		public void UnPackTo(IBeamRangeConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.Length = this.Length;
			_o.PosOffset = ((this.PosOffset != null) ? this.PosOffset.Value.UnPack() : null);
		}

		// Token: 0x06021D3B RID: 138555 RVA: 0x004A9C1C File Offset: 0x004A7E1C
		public static Offset<IBeamRangeConfig> Pack(FlatBufferBuilder builder, IBeamRangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamRangeConfig>);
			}
			Offset<IVectorInfo> posOffsetOffset = (_o.PosOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.PosOffset);
			return IBeamRangeConfig.CreateIBeamRangeConfig(builder, _o.Radius, _o.Length, posOffsetOffset);
		}

		// Token: 0x0400E902 RID: 59650
		private Table __p;
	}
}
