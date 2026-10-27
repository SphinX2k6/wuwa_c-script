using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF9 RID: 16121
	public struct ILevelPlayInformation : IFlatbufferObject
	{
		// Token: 0x17006FD3 RID: 28627
		// (get) Token: 0x06016CFA RID: 93434 RVA: 0x0034A4E0 File Offset: 0x003486E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016CFB RID: 93435 RVA: 0x0034A4ED File Offset: 0x003486ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016CFC RID: 93436 RVA: 0x0034A4F4 File Offset: 0x003486F4
		public static ILevelPlayInformation GetRootAsILevelPlayInformation(ByteBuffer _bb)
		{
			return ILevelPlayInformation.GetRootAsILevelPlayInformation(_bb, default(ILevelPlayInformation));
		}

		// Token: 0x06016CFD RID: 93437 RVA: 0x0034A510 File Offset: 0x00348710
		public static ILevelPlayInformation GetRootAsILevelPlayInformation(ByteBuffer _bb, ILevelPlayInformation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016CFE RID: 93438 RVA: 0x0034A52D File Offset: 0x0034872D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016CFF RID: 93439 RVA: 0x0034A53C File Offset: 0x0034873C
		public ILevelPlayInformation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FD4 RID: 28628
		// (get) Token: 0x06016D00 RID: 93440 RVA: 0x0034A54C File Offset: 0x0034874C
		public string TidMainTitle
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

		// Token: 0x06016D01 RID: 93441 RVA: 0x0034A583 File Offset: 0x00348783
		public Span<byte> GetTidMainTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06016D02 RID: 93442 RVA: 0x0034A592 File Offset: 0x00348792
		public byte[] GetTidMainTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06016D03 RID: 93443 RVA: 0x0034A5A0 File Offset: 0x003487A0
		public IInformationSubTitle? SubTitles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInformationSubTitle?(default(IInformationSubTitle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17006FD5 RID: 28629
		// (get) Token: 0x06016D04 RID: 93444 RVA: 0x0034A600 File Offset: 0x00348800
		public int SubTitlesLength
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

		// Token: 0x06016D05 RID: 93445 RVA: 0x0034A62B File Offset: 0x0034882B
		public static Offset<ILevelPlayInformation> CreateILevelPlayInformation(FlatBufferBuilder builder, StringOffset TidMainTitleOffset = default(StringOffset), VectorOffset SubTitlesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlayInformation.AddSubTitles(builder, SubTitlesOffset);
			ILevelPlayInformation.AddTidMainTitle(builder, TidMainTitleOffset);
			return ILevelPlayInformation.EndILevelPlayInformation(builder);
		}

		// Token: 0x06016D06 RID: 93446 RVA: 0x0034A648 File Offset: 0x00348848
		public static void StartILevelPlayInformation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016D07 RID: 93447 RVA: 0x0034A651 File Offset: 0x00348851
		public static void AddTidMainTitle(FlatBufferBuilder builder, StringOffset tidMainTitleOffset)
		{
			builder.AddOffset(0, tidMainTitleOffset.Value, 0);
		}

		// Token: 0x06016D08 RID: 93448 RVA: 0x0034A661 File Offset: 0x00348861
		public static void AddSubTitles(FlatBufferBuilder builder, VectorOffset subTitlesOffset)
		{
			builder.AddOffset(1, subTitlesOffset.Value, 0);
		}

		// Token: 0x06016D09 RID: 93449 RVA: 0x0034A674 File Offset: 0x00348874
		public static VectorOffset CreateSubTitlesVector(FlatBufferBuilder builder, Offset<IInformationSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06016D0A RID: 93450 RVA: 0x0034A6B4 File Offset: 0x003488B4
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, Offset<IInformationSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInformationSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D0B RID: 93451 RVA: 0x0034A6CE File Offset: 0x003488CE
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInformationSubTitle>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInformationSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06016D0C RID: 93452 RVA: 0x0034A6EC File Offset: 0x003488EC
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInformationSubTitle>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06016D0D RID: 93453 RVA: 0x0034A705 File Offset: 0x00348905
		public static void StartSubTitlesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06016D0E RID: 93454 RVA: 0x0034A710 File Offset: 0x00348910
		public static Offset<ILevelPlayInformation> EndILevelPlayInformation(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInformation>(builder.EndTable());
		}

		// Token: 0x06016D0F RID: 93455 RVA: 0x0034A720 File Offset: 0x00348920
		public ILevelPlayInformationT UnPack()
		{
			ILevelPlayInformationT levelPlayInformationT = new ILevelPlayInformationT();
			this.UnPackTo(levelPlayInformationT);
			return levelPlayInformationT;
		}

		// Token: 0x06016D10 RID: 93456 RVA: 0x0034A73C File Offset: 0x0034893C
		public void UnPackTo(ILevelPlayInformationT _o)
		{
			_o.TidMainTitle = this.TidMainTitle;
			_o.SubTitles = new List<IInformationSubTitleT>();
			for (int i = 0; i < this.SubTitlesLength; i++)
			{
				_o.SubTitles.Add((this.SubTitles(i) != null) ? this.SubTitles(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06016D11 RID: 93457 RVA: 0x0034A7A8 File Offset: 0x003489A8
		public static Offset<ILevelPlayInformation> Pack(FlatBufferBuilder builder, ILevelPlayInformationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelPlayInformation>);
			}
			StringOffset tidMainTitleOffset = (_o.TidMainTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidMainTitle);
			VectorOffset subTitlesOffset = default(VectorOffset);
			if (_o.SubTitles != null)
			{
				Offset<IInformationSubTitle>[] array = new Offset<IInformationSubTitle>[_o.SubTitles.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInformationSubTitle.Pack(builder, _o.SubTitles[i]);
				}
				subTitlesOffset = ILevelPlayInformation.CreateSubTitlesVector(builder, array);
			}
			return ILevelPlayInformation.CreateILevelPlayInformation(builder, tidMainTitleOffset, subTitlesOffset);
		}

		// Token: 0x0400B8D6 RID: 47318
		private Table __p;
	}
}
