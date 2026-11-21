using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004337 RID: 17207
	public struct ILevelPlayInformation : IFlatbufferObject
	{
		// Token: 0x170075C2 RID: 30146
		// (get) Token: 0x06018351 RID: 99153 RVA: 0x003736AC File Offset: 0x003718AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018352 RID: 99154 RVA: 0x003736B9 File Offset: 0x003718B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018353 RID: 99155 RVA: 0x003736C0 File Offset: 0x003718C0
		public static ILevelPlayInformation GetRootAsILevelPlayInformation(ByteBuffer _bb)
		{
			return ILevelPlayInformation.GetRootAsILevelPlayInformation(_bb, default(ILevelPlayInformation));
		}

		// Token: 0x06018354 RID: 99156 RVA: 0x003736DC File Offset: 0x003718DC
		public static ILevelPlayInformation GetRootAsILevelPlayInformation(ByteBuffer _bb, ILevelPlayInformation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018355 RID: 99157 RVA: 0x003736F9 File Offset: 0x003718F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018356 RID: 99158 RVA: 0x00373708 File Offset: 0x00371908
		public ILevelPlayInformation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075C3 RID: 30147
		// (get) Token: 0x06018357 RID: 99159 RVA: 0x00373718 File Offset: 0x00371918
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

		// Token: 0x06018358 RID: 99160 RVA: 0x0037374F File Offset: 0x0037194F
		public Span<byte> GetTidMainTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018359 RID: 99161 RVA: 0x0037375E File Offset: 0x0037195E
		public byte[] GetTidMainTitleArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601835A RID: 99162 RVA: 0x0037376C File Offset: 0x0037196C
		public IInformationSubTitle? SubTitles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInformationSubTitle?(default(IInformationSubTitle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170075C4 RID: 30148
		// (get) Token: 0x0601835B RID: 99163 RVA: 0x003737CC File Offset: 0x003719CC
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

		// Token: 0x0601835C RID: 99164 RVA: 0x003737F7 File Offset: 0x003719F7
		public static Offset<ILevelPlayInformation> CreateILevelPlayInformation(FlatBufferBuilder builder, StringOffset TidMainTitleOffset = default(StringOffset), VectorOffset SubTitlesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlayInformation.AddSubTitles(builder, SubTitlesOffset);
			ILevelPlayInformation.AddTidMainTitle(builder, TidMainTitleOffset);
			return ILevelPlayInformation.EndILevelPlayInformation(builder);
		}

		// Token: 0x0601835D RID: 99165 RVA: 0x00373814 File Offset: 0x00371A14
		public static void StartILevelPlayInformation(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601835E RID: 99166 RVA: 0x0037381D File Offset: 0x00371A1D
		public static void AddTidMainTitle(FlatBufferBuilder builder, StringOffset tidMainTitleOffset)
		{
			builder.AddOffset(0, tidMainTitleOffset.Value, 0);
		}

		// Token: 0x0601835F RID: 99167 RVA: 0x0037382D File Offset: 0x00371A2D
		public static void AddSubTitles(FlatBufferBuilder builder, VectorOffset subTitlesOffset)
		{
			builder.AddOffset(1, subTitlesOffset.Value, 0);
		}

		// Token: 0x06018360 RID: 99168 RVA: 0x00373840 File Offset: 0x00371A40
		public static VectorOffset CreateSubTitlesVector(FlatBufferBuilder builder, Offset<IInformationSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06018361 RID: 99169 RVA: 0x00373880 File Offset: 0x00371A80
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, Offset<IInformationSubTitle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInformationSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018362 RID: 99170 RVA: 0x0037389A File Offset: 0x00371A9A
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInformationSubTitle>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInformationSubTitle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06018363 RID: 99171 RVA: 0x003738B8 File Offset: 0x00371AB8
		public static VectorOffset CreateSubTitlesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInformationSubTitle>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018364 RID: 99172 RVA: 0x003738D1 File Offset: 0x00371AD1
		public static void StartSubTitlesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018365 RID: 99173 RVA: 0x003738DC File Offset: 0x00371ADC
		public static Offset<ILevelPlayInformation> EndILevelPlayInformation(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInformation>(builder.EndTable());
		}

		// Token: 0x06018366 RID: 99174 RVA: 0x003738EC File Offset: 0x00371AEC
		public ILevelPlayInformationT UnPack()
		{
			ILevelPlayInformationT levelPlayInformationT = new ILevelPlayInformationT();
			this.UnPackTo(levelPlayInformationT);
			return levelPlayInformationT;
		}

		// Token: 0x06018367 RID: 99175 RVA: 0x00373908 File Offset: 0x00371B08
		public void UnPackTo(ILevelPlayInformationT _o)
		{
			_o.TidMainTitle = this.TidMainTitle;
			_o.SubTitles = new List<IInformationSubTitleT>();
			for (int i = 0; i < this.SubTitlesLength; i++)
			{
				_o.SubTitles.Add((this.SubTitles(i) != null) ? this.SubTitles(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018368 RID: 99176 RVA: 0x00373974 File Offset: 0x00371B74
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

		// Token: 0x0400C2B3 RID: 49843
		private Table __p;
	}
}
