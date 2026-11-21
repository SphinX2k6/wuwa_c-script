using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E7A RID: 15994
	public struct IEnergyFishState : IFlatbufferObject
	{
		// Token: 0x17006C13 RID: 27667
		// (get) Token: 0x0601592C RID: 88364 RVA: 0x0031C1D7 File Offset: 0x0031A3D7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601592D RID: 88365 RVA: 0x0031C1E4 File Offset: 0x0031A3E4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601592E RID: 88366 RVA: 0x0031C1EC File Offset: 0x0031A3EC
		public static IEnergyFishState GetRootAsIEnergyFishState(ByteBuffer _bb)
		{
			return IEnergyFishState.GetRootAsIEnergyFishState(_bb, default(IEnergyFishState));
		}

		// Token: 0x0601592F RID: 88367 RVA: 0x0031C208 File Offset: 0x0031A408
		public static IEnergyFishState GetRootAsIEnergyFishState(ByteBuffer _bb, IEnergyFishState obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015930 RID: 88368 RVA: 0x0031C225 File Offset: 0x0031A425
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015931 RID: 88369 RVA: 0x0031C234 File Offset: 0x0031A434
		public IEnergyFishState __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006C14 RID: 27668
		// (get) Token: 0x06015932 RID: 88370 RVA: 0x0031C244 File Offset: 0x0031A444
		public EEnergyFishState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnergyFishState.Spline;
				}
				return (EEnergyFishState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015933 RID: 88371 RVA: 0x0031C280 File Offset: 0x0031A480
		public static Offset<IEnergyFishState> CreateIEnergyFishState(FlatBufferBuilder builder, EEnergyFishState Type = EEnergyFishState.Spline)
		{
			builder.StartTable(1);
			IEnergyFishState.AddType(builder, Type);
			return IEnergyFishState.EndIEnergyFishState(builder);
		}

		// Token: 0x06015934 RID: 88372 RVA: 0x0031C296 File Offset: 0x0031A496
		public static void StartIEnergyFishState(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015935 RID: 88373 RVA: 0x0031C29F File Offset: 0x0031A49F
		public static void AddType(FlatBufferBuilder builder, EEnergyFishState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015936 RID: 88374 RVA: 0x0031C2AA File Offset: 0x0031A4AA
		public static Offset<IEnergyFishState> EndIEnergyFishState(FlatBufferBuilder builder)
		{
			return new Offset<IEnergyFishState>(builder.EndTable());
		}

		// Token: 0x06015937 RID: 88375 RVA: 0x0031C2B8 File Offset: 0x0031A4B8
		public IEnergyFishStateT UnPack()
		{
			IEnergyFishStateT energyFishStateT = new IEnergyFishStateT();
			this.UnPackTo(energyFishStateT);
			return energyFishStateT;
		}

		// Token: 0x06015938 RID: 88376 RVA: 0x0031C2D3 File Offset: 0x0031A4D3
		public void UnPackTo(IEnergyFishStateT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015939 RID: 88377 RVA: 0x0031C2E4 File Offset: 0x0031A4E4
		public static Offset<IEnergyFishState> Pack(FlatBufferBuilder builder, IEnergyFishStateT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnergyFishState>);
			}
			return IEnergyFishState.CreateIEnergyFishState(builder, _o.Type);
		}

		// Token: 0x0400B84B RID: 47179
		private Table __p;
	}
}
