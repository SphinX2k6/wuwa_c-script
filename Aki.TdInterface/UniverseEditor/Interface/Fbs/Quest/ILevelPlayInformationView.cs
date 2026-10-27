using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EFC RID: 16124
	public struct ILevelPlayInformationView : IFlatbufferObject
	{
		// Token: 0x17006FD8 RID: 28632
		// (get) Token: 0x06016D18 RID: 93464 RVA: 0x0034A8CC File Offset: 0x00348ACC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016D19 RID: 93465 RVA: 0x0034A8D9 File Offset: 0x00348AD9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016D1A RID: 93466 RVA: 0x0034A8E0 File Offset: 0x00348AE0
		public static ILevelPlayInformationView GetRootAsILevelPlayInformationView(ByteBuffer _bb)
		{
			return ILevelPlayInformationView.GetRootAsILevelPlayInformationView(_bb, default(ILevelPlayInformationView));
		}

		// Token: 0x06016D1B RID: 93467 RVA: 0x0034A8FC File Offset: 0x00348AFC
		public static ILevelPlayInformationView GetRootAsILevelPlayInformationView(ByteBuffer _bb, ILevelPlayInformationView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D1C RID: 93468 RVA: 0x0034A919 File Offset: 0x00348B19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D1D RID: 93469 RVA: 0x0034A928 File Offset: 0x00348B28
		public ILevelPlayInformationView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FD9 RID: 28633
		// (get) Token: 0x06016D1E RID: 93470 RVA: 0x0034A938 File Offset: 0x00348B38
		public EInformationViewType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInformationViewType.LevelPlay;
				}
				return (EInformationViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016D1F RID: 93471 RVA: 0x0034A974 File Offset: 0x00348B74
		public ILevelPlayInformation? InformationConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelPlayInformation?(default(ILevelPlayInformation).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006FDA RID: 28634
		// (get) Token: 0x06016D20 RID: 93472 RVA: 0x0034A9D4 File Offset: 0x00348BD4
		public int InformationConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06016D21 RID: 93473 RVA: 0x0034A9FF File Offset: 0x00348BFF
		public static Offset<ILevelPlayInformationView> CreateILevelPlayInformationView(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay, VectorOffset InformationConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlayInformationView.AddInformationConfig(builder, InformationConfigOffset);
			ILevelPlayInformationView.AddType(builder, Type);
			return ILevelPlayInformationView.EndILevelPlayInformationView(builder);
		}

		// Token: 0x06016D22 RID: 93474 RVA: 0x0034AA1C File Offset: 0x00348C1C
		public static void StartILevelPlayInformationView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016D23 RID: 93475 RVA: 0x0034AA25 File Offset: 0x00348C25
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016D24 RID: 93476 RVA: 0x0034AA30 File Offset: 0x00348C30
		public static void AddInformationConfig(FlatBufferBuilder builder, VectorOffset informationConfigOffset)
		{
			builder.AddOffset(1, informationConfigOffset.Value, 0);
		}

		// Token: 0x06016D25 RID: 93477 RVA: 0x0034AA40 File Offset: 0x00348C40
		public static VectorOffset CreateInformationConfigVector(FlatBufferBuilder builder, Offset<ILevelPlayInformation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016D26 RID: 93478 RVA: 0x0034AA80 File Offset: 0x00348C80
		public static VectorOffset CreateInformationConfigVectorBlock(FlatBufferBuilder builder, Offset<ILevelPlayInformation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelPlayInformation>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D27 RID: 93479 RVA: 0x0034AA9A File Offset: 0x00348C9A
		public static VectorOffset CreateInformationConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelPlayInformation>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelPlayInformation>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D28 RID: 93480 RVA: 0x0034AAB8 File Offset: 0x00348CB8
		public static VectorOffset CreateInformationConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelPlayInformation>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016D29 RID: 93481 RVA: 0x0034AAD1 File Offset: 0x00348CD1
		public static void StartInformationConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016D2A RID: 93482 RVA: 0x0034AADC File Offset: 0x00348CDC
		public static Offset<ILevelPlayInformationView> EndILevelPlayInformationView(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInformationView>(builder.EndTable());
		}

		// Token: 0x06016D2B RID: 93483 RVA: 0x0034AAEC File Offset: 0x00348CEC
		public ILevelPlayInformationViewT UnPack()
		{
			ILevelPlayInformationViewT levelPlayInformationViewT = new ILevelPlayInformationViewT();
			this.UnPackTo(levelPlayInformationViewT);
			return levelPlayInformationViewT;
		}

		// Token: 0x06016D2C RID: 93484 RVA: 0x0034AB08 File Offset: 0x00348D08
		public void UnPackTo(ILevelPlayInformationViewT _o)
		{
			_o.Type = this.Type;
			_o.InformationConfig = new List<ILevelPlayInformationT>();
			for (int i = 0; i < this.InformationConfigLength; i++)
			{
				_o.InformationConfig.Add((this.InformationConfig(i) != null) ? this.InformationConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016D2D RID: 93485 RVA: 0x0034AB74 File Offset: 0x00348D74
		public static Offset<ILevelPlayInformationView> Pack(FlatBufferBuilder builder, ILevelPlayInformationViewT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInformationView>);
			}
			VectorOffset informationConfigOffset = default(VectorOffset);
			if (_o.InformationConfig != null)
			{
				Offset<ILevelPlayInformation>[] array = new Offset<ILevelPlayInformation>[_o.InformationConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelPlayInformation.Pack(builder, _o.InformationConfig[i]);
				}
				informationConfigOffset = ILevelPlayInformationView.CreateInformationConfigVector(builder, array);
			}
			return ILevelPlayInformationView.CreateILevelPlayInformationView(builder, _o.Type, informationConfigOffset);
		}

		// Token: 0x0400B8D9 RID: 47321
		private Table __p;
	}
}
