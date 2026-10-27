using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F0D RID: 20237
	public struct IBeamRangeConfig : IFlatbufferObject
	{
		// Token: 0x170091AC RID: 37292
		// (get) Token: 0x0601FFBA RID: 131002 RVA: 0x0047365A File Offset: 0x0047185A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FFBB RID: 131003 RVA: 0x00473667 File Offset: 0x00471867
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FFBC RID: 131004 RVA: 0x00473670 File Offset: 0x00471870
		public static IBeamRangeConfig GetRootAsIBeamRangeConfig(ByteBuffer _bb)
		{
			return IBeamRangeConfig.GetRootAsIBeamRangeConfig(_bb, default(IBeamRangeConfig));
		}

		// Token: 0x0601FFBD RID: 131005 RVA: 0x0047368C File Offset: 0x0047188C
		public static IBeamRangeConfig GetRootAsIBeamRangeConfig(ByteBuffer _bb, IBeamRangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FFBE RID: 131006 RVA: 0x004736A9 File Offset: 0x004718A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FFBF RID: 131007 RVA: 0x004736B8 File Offset: 0x004718B8
		public IBeamRangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091AD RID: 37293
		// (get) Token: 0x0601FFC0 RID: 131008 RVA: 0x004736C8 File Offset: 0x004718C8
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

		// Token: 0x170091AE RID: 37294
		// (get) Token: 0x0601FFC1 RID: 131009 RVA: 0x00473708 File Offset: 0x00471908
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

		// Token: 0x170091AF RID: 37295
		// (get) Token: 0x0601FFC2 RID: 131010 RVA: 0x00473748 File Offset: 0x00471948
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

		// Token: 0x0601FFC3 RID: 131011 RVA: 0x004737A5 File Offset: 0x004719A5
		public static Offset<IBeamRangeConfig> CreateIBeamRangeConfig(FlatBufferBuilder builder, float Radius = 0f, float Length = 0f, Offset<IVectorInfo> PosOffsetOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			IBeamRangeConfig.AddPosOffset(builder, PosOffsetOffset);
			IBeamRangeConfig.AddLength(builder, Length);
			IBeamRangeConfig.AddRadius(builder, Radius);
			return IBeamRangeConfig.EndIBeamRangeConfig(builder);
		}

		// Token: 0x0601FFC4 RID: 131012 RVA: 0x004737C9 File Offset: 0x004719C9
		public static void StartIBeamRangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601FFC5 RID: 131013 RVA: 0x004737D2 File Offset: 0x004719D2
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
			builder.AddFloat(0, radius, 0.0);
		}

		// Token: 0x0601FFC6 RID: 131014 RVA: 0x004737E5 File Offset: 0x004719E5
		public static void AddLength(FlatBufferBuilder builder, float length)
		{
			builder.AddFloat(1, length, 0.0);
		}

		// Token: 0x0601FFC7 RID: 131015 RVA: 0x004737F8 File Offset: 0x004719F8
		public static void AddPosOffset(FlatBufferBuilder builder, Offset<IVectorInfo> posOffsetOffset)
		{
			builder.AddOffset(2, posOffsetOffset.Value, 0);
		}

		// Token: 0x0601FFC8 RID: 131016 RVA: 0x00473808 File Offset: 0x00471A08
		public static Offset<IBeamRangeConfig> EndIBeamRangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBeamRangeConfig>(builder.EndTable());
		}

		// Token: 0x0601FFC9 RID: 131017 RVA: 0x00473818 File Offset: 0x00471A18
		public IBeamRangeConfigT UnPack()
		{
			IBeamRangeConfigT beamRangeConfigT = new IBeamRangeConfigT();
			this.UnPackTo(beamRangeConfigT);
			return beamRangeConfigT;
		}

		// Token: 0x0601FFCA RID: 131018 RVA: 0x00473834 File Offset: 0x00471A34
		public void UnPackTo(IBeamRangeConfigT _o)
		{
			_o.Radius = this.Radius;
			_o.Length = this.Length;
			_o.PosOffset = ((this.PosOffset != null) ? this.PosOffset.Value.UnPack() : null);
		}

		// Token: 0x0601FFCB RID: 131019 RVA: 0x00473888 File Offset: 0x00471A88
		public static Offset<IBeamRangeConfig> Pack(FlatBufferBuilder builder, IBeamRangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamRangeConfig>);
			}
			Offset<IVectorInfo> posOffsetOffset = (_o.PosOffset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.PosOffset);
			return IBeamRangeConfig.CreateIBeamRangeConfig(builder, _o.Radius, _o.Length, posOffsetOffset);
		}

		// Token: 0x0400DD53 RID: 56659
		private Table __p;
	}
}
