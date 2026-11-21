using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005436 RID: 21558
	public struct IBeamLayoutConfig : IFlatbufferObject
	{
		// Token: 0x17009922 RID: 39202
		// (get) Token: 0x06021CF2 RID: 138482 RVA: 0x004A94DB File Offset: 0x004A76DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021CF3 RID: 138483 RVA: 0x004A94E8 File Offset: 0x004A76E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021CF4 RID: 138484 RVA: 0x004A94F0 File Offset: 0x004A76F0
		public static IBeamLayoutConfig GetRootAsIBeamLayoutConfig(ByteBuffer _bb)
		{
			return IBeamLayoutConfig.GetRootAsIBeamLayoutConfig(_bb, default(IBeamLayoutConfig));
		}

		// Token: 0x06021CF5 RID: 138485 RVA: 0x004A950C File Offset: 0x004A770C
		public static IBeamLayoutConfig GetRootAsIBeamLayoutConfig(ByteBuffer _bb, IBeamLayoutConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021CF6 RID: 138486 RVA: 0x004A9529 File Offset: 0x004A7729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021CF7 RID: 138487 RVA: 0x004A9538 File Offset: 0x004A7738
		public IBeamLayoutConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009923 RID: 39203
		// (get) Token: 0x06021CF8 RID: 138488 RVA: 0x004A9548 File Offset: 0x004A7748
		public EBeamLayoutType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBeamLayoutType.BeamWall;
				}
				return (EBeamLayoutType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021CF9 RID: 138489 RVA: 0x004A9584 File Offset: 0x004A7784
		public static Offset<IBeamLayoutConfig> CreateIBeamLayoutConfig(FlatBufferBuilder builder, EBeamLayoutType Type = EBeamLayoutType.BeamWall)
		{
			builder.StartTable(1);
			IBeamLayoutConfig.AddType(builder, Type);
			return IBeamLayoutConfig.EndIBeamLayoutConfig(builder);
		}

		// Token: 0x06021CFA RID: 138490 RVA: 0x004A959A File Offset: 0x004A779A
		public static void StartIBeamLayoutConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06021CFB RID: 138491 RVA: 0x004A95A3 File Offset: 0x004A77A3
		public static void AddType(FlatBufferBuilder builder, EBeamLayoutType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021CFC RID: 138492 RVA: 0x004A95AE File Offset: 0x004A77AE
		public static Offset<IBeamLayoutConfig> EndIBeamLayoutConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBeamLayoutConfig>(builder.EndTable());
		}

		// Token: 0x06021CFD RID: 138493 RVA: 0x004A95BC File Offset: 0x004A77BC
		public IBeamLayoutConfigT UnPack()
		{
			IBeamLayoutConfigT beamLayoutConfigT = new IBeamLayoutConfigT();
			this.UnPackTo(beamLayoutConfigT);
			return beamLayoutConfigT;
		}

		// Token: 0x06021CFE RID: 138494 RVA: 0x004A95D7 File Offset: 0x004A77D7
		public void UnPackTo(IBeamLayoutConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06021CFF RID: 138495 RVA: 0x004A95E8 File Offset: 0x004A77E8
		public static Offset<IBeamLayoutConfig> Pack(FlatBufferBuilder builder, IBeamLayoutConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBeamLayoutConfig>);
			}
			return IBeamLayoutConfig.CreateIBeamLayoutConfig(builder, _o.Type);
		}

		// Token: 0x0400E8F6 RID: 59638
		private Table __p;
	}
}
