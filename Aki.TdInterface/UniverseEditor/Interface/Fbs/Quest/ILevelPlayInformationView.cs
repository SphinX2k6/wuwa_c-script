using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200433A RID: 17210
	public struct ILevelPlayInformationView : IFlatbufferObject
	{
		// Token: 0x170075C7 RID: 30151
		// (get) Token: 0x0601836F RID: 99183 RVA: 0x00373A98 File Offset: 0x00371C98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018370 RID: 99184 RVA: 0x00373AA5 File Offset: 0x00371CA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018371 RID: 99185 RVA: 0x00373AAC File Offset: 0x00371CAC
		public static ILevelPlayInformationView GetRootAsILevelPlayInformationView(ByteBuffer _bb)
		{
			return ILevelPlayInformationView.GetRootAsILevelPlayInformationView(_bb, default(ILevelPlayInformationView));
		}

		// Token: 0x06018372 RID: 99186 RVA: 0x00373AC8 File Offset: 0x00371CC8
		public static ILevelPlayInformationView GetRootAsILevelPlayInformationView(ByteBuffer _bb, ILevelPlayInformationView obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018373 RID: 99187 RVA: 0x00373AE5 File Offset: 0x00371CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018374 RID: 99188 RVA: 0x00373AF4 File Offset: 0x00371CF4
		public ILevelPlayInformationView __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170075C8 RID: 30152
		// (get) Token: 0x06018375 RID: 99189 RVA: 0x00373B04 File Offset: 0x00371D04
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

		// Token: 0x06018376 RID: 99190 RVA: 0x00373B40 File Offset: 0x00371D40
		public ILevelPlayInformation? InformationConfig(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ILevelPlayInformation?(default(ILevelPlayInformation).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170075C9 RID: 30153
		// (get) Token: 0x06018377 RID: 99191 RVA: 0x00373BA0 File Offset: 0x00371DA0
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

		// Token: 0x06018378 RID: 99192 RVA: 0x00373BCB File Offset: 0x00371DCB
		public static Offset<ILevelPlayInformationView> CreateILevelPlayInformationView(FlatBufferBuilder builder, EInformationViewType Type = EInformationViewType.LevelPlay, VectorOffset InformationConfigOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ILevelPlayInformationView.AddInformationConfig(builder, InformationConfigOffset);
			ILevelPlayInformationView.AddType(builder, Type);
			return ILevelPlayInformationView.EndILevelPlayInformationView(builder);
		}

		// Token: 0x06018379 RID: 99193 RVA: 0x00373BE8 File Offset: 0x00371DE8
		public static void StartILevelPlayInformationView(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601837A RID: 99194 RVA: 0x00373BF1 File Offset: 0x00371DF1
		public static void AddType(FlatBufferBuilder builder, EInformationViewType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601837B RID: 99195 RVA: 0x00373BFC File Offset: 0x00371DFC
		public static void AddInformationConfig(FlatBufferBuilder builder, VectorOffset informationConfigOffset)
		{
			builder.AddOffset(1, informationConfigOffset.Value, 0);
		}

		// Token: 0x0601837C RID: 99196 RVA: 0x00373C0C File Offset: 0x00371E0C
		public static VectorOffset CreateInformationConfigVector(FlatBufferBuilder builder, Offset<ILevelPlayInformation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601837D RID: 99197 RVA: 0x00373C4C File Offset: 0x00371E4C
		public static VectorOffset CreateInformationConfigVectorBlock(FlatBufferBuilder builder, Offset<ILevelPlayInformation>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelPlayInformation>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601837E RID: 99198 RVA: 0x00373C66 File Offset: 0x00371E66
		public static VectorOffset CreateInformationConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelPlayInformation>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelPlayInformation>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601837F RID: 99199 RVA: 0x00373C84 File Offset: 0x00371E84
		public static VectorOffset CreateInformationConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelPlayInformation>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06018380 RID: 99200 RVA: 0x00373C9D File Offset: 0x00371E9D
		public static void StartInformationConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06018381 RID: 99201 RVA: 0x00373CA8 File Offset: 0x00371EA8
		public static Offset<ILevelPlayInformationView> EndILevelPlayInformationView(FlatBufferBuilder builder)
		{
			return new Offset<ILevelPlayInformationView>(builder.EndTable());
		}

		// Token: 0x06018382 RID: 99202 RVA: 0x00373CB8 File Offset: 0x00371EB8
		public ILevelPlayInformationViewT UnPack()
		{
			ILevelPlayInformationViewT levelPlayInformationViewT = new ILevelPlayInformationViewT();
			this.UnPackTo(levelPlayInformationViewT);
			return levelPlayInformationViewT;
		}

		// Token: 0x06018383 RID: 99203 RVA: 0x00373CD4 File Offset: 0x00371ED4
		public void UnPackTo(ILevelPlayInformationViewT _o)
		{
			_o.Type = this.Type;
			_o.InformationConfig = new List<ILevelPlayInformationT>();
			for (int i = 0; i < this.InformationConfigLength; i++)
			{
				_o.InformationConfig.Add((this.InformationConfig(i) != null) ? this.InformationConfig(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06018384 RID: 99204 RVA: 0x00373D40 File Offset: 0x00371F40
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

		// Token: 0x0400C2B6 RID: 49846
		private Table __p;
	}
}
