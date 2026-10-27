using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551B RID: 21787
	public struct ILowViewDistance : IFlatbufferObject
	{
		// Token: 0x1700A0D4 RID: 41172
		// (get) Token: 0x06023FBD RID: 147389 RVA: 0x004F916D File Offset: 0x004F736D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023FBE RID: 147390 RVA: 0x004F917A File Offset: 0x004F737A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023FBF RID: 147391 RVA: 0x004F9184 File Offset: 0x004F7384
		public static ILowViewDistance GetRootAsILowViewDistance(ByteBuffer _bb)
		{
			return ILowViewDistance.GetRootAsILowViewDistance(_bb, default(ILowViewDistance));
		}

		// Token: 0x06023FC0 RID: 147392 RVA: 0x004F91A0 File Offset: 0x004F73A0
		public static ILowViewDistance GetRootAsILowViewDistance(ByteBuffer _bb, ILowViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023FC1 RID: 147393 RVA: 0x004F91BD File Offset: 0x004F73BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023FC2 RID: 147394 RVA: 0x004F91CC File Offset: 0x004F73CC
		public ILowViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0D5 RID: 41173
		// (get) Token: 0x06023FC3 RID: 147395 RVA: 0x004F91DC File Offset: 0x004F73DC
		public EViewDistanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EViewDistanceType.Low;
				}
				return (EViewDistanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023FC4 RID: 147396 RVA: 0x004F9218 File Offset: 0x004F7418
		public static Offset<ILowViewDistance> CreateILowViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			ILowViewDistance.AddType(builder, Type);
			return ILowViewDistance.EndILowViewDistance(builder);
		}

		// Token: 0x06023FC5 RID: 147397 RVA: 0x004F922E File Offset: 0x004F742E
		public static void StartILowViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023FC6 RID: 147398 RVA: 0x004F9237 File Offset: 0x004F7437
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023FC7 RID: 147399 RVA: 0x004F9242 File Offset: 0x004F7442
		public static Offset<ILowViewDistance> EndILowViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<ILowViewDistance>(builder.EndTable());
		}

		// Token: 0x06023FC8 RID: 147400 RVA: 0x004F9250 File Offset: 0x004F7450
		public ILowViewDistanceT UnPack()
		{
			ILowViewDistanceT lowViewDistanceT = new ILowViewDistanceT();
			this.UnPackTo(lowViewDistanceT);
			return lowViewDistanceT;
		}

		// Token: 0x06023FC9 RID: 147401 RVA: 0x004F926B File Offset: 0x004F746B
		public void UnPackTo(ILowViewDistanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023FCA RID: 147402 RVA: 0x004F927C File Offset: 0x004F747C
		public static Offset<ILowViewDistance> Pack(FlatBufferBuilder builder, ILowViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILowViewDistance>);
			}
			return ILowViewDistance.CreateILowViewDistance(builder, _o.Type);
		}

		// Token: 0x0400E80F RID: 59407
		private Table __p;
	}
}
