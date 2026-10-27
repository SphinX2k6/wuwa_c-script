using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E7 RID: 22503
	public struct IRandomInteract : IFlatbufferObject
	{
		// Token: 0x1700A814 RID: 43028
		// (get) Token: 0x06025CFE RID: 154878 RVA: 0x0053708F File Offset: 0x0053528F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025CFF RID: 154879 RVA: 0x0053709C File Offset: 0x0053529C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D00 RID: 154880 RVA: 0x005370A4 File Offset: 0x005352A4
		public static IRandomInteract GetRootAsIRandomInteract(ByteBuffer _bb)
		{
			return IRandomInteract.GetRootAsIRandomInteract(_bb, default(IRandomInteract));
		}

		// Token: 0x06025D01 RID: 154881 RVA: 0x005370C0 File Offset: 0x005352C0
		public static IRandomInteract GetRootAsIRandomInteract(ByteBuffer _bb, IRandomInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D02 RID: 154882 RVA: 0x005370DD File Offset: 0x005352DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D03 RID: 154883 RVA: 0x005370EC File Offset: 0x005352EC
		public IRandomInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A815 RID: 43029
		// (get) Token: 0x06025D04 RID: 154884 RVA: 0x005370FC File Offset: 0x005352FC
		public int RandomCount
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025D05 RID: 154885 RVA: 0x00537138 File Offset: 0x00535338
		public IRandomInteractOption? Options(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IRandomInteractOption?(default(IRandomInteractOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A816 RID: 43030
		// (get) Token: 0x06025D06 RID: 154886 RVA: 0x00537198 File Offset: 0x00535398
		public int OptionsLength
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

		// Token: 0x06025D07 RID: 154887 RVA: 0x005371C3 File Offset: 0x005353C3
		public static Offset<IRandomInteract> CreateIRandomInteract(FlatBufferBuilder builder, int RandomCount = 0, VectorOffset OptionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomInteract.AddOptions(builder, OptionsOffset);
			IRandomInteract.AddRandomCount(builder, RandomCount);
			return IRandomInteract.EndIRandomInteract(builder);
		}

		// Token: 0x06025D08 RID: 154888 RVA: 0x005371E0 File Offset: 0x005353E0
		public static void StartIRandomInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025D09 RID: 154889 RVA: 0x005371E9 File Offset: 0x005353E9
		public static void AddRandomCount(FlatBufferBuilder builder, int randomCount)
		{
			builder.AddInt(0, randomCount, 0);
		}

		// Token: 0x06025D0A RID: 154890 RVA: 0x005371F4 File Offset: 0x005353F4
		public static void AddOptions(FlatBufferBuilder builder, VectorOffset optionsOffset)
		{
			builder.AddOffset(1, optionsOffset.Value, 0);
		}

		// Token: 0x06025D0B RID: 154891 RVA: 0x00537204 File Offset: 0x00535404
		public static VectorOffset CreateOptionsVector(FlatBufferBuilder builder, Offset<IRandomInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025D0C RID: 154892 RVA: 0x00537244 File Offset: 0x00535444
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, Offset<IRandomInteractOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRandomInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D0D RID: 154893 RVA: 0x0053725E File Offset: 0x0053545E
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRandomInteractOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRandomInteractOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025D0E RID: 154894 RVA: 0x0053727C File Offset: 0x0053547C
		public static VectorOffset CreateOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRandomInteractOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025D0F RID: 154895 RVA: 0x00537295 File Offset: 0x00535495
		public static void StartOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025D10 RID: 154896 RVA: 0x005372A0 File Offset: 0x005354A0
		public static Offset<IRandomInteract> EndIRandomInteract(FlatBufferBuilder builder)
		{
			return new Offset<IRandomInteract>(builder.EndTable());
		}

		// Token: 0x06025D11 RID: 154897 RVA: 0x005372B0 File Offset: 0x005354B0
		public IRandomInteractT UnPack()
		{
			IRandomInteractT randomInteractT = new IRandomInteractT();
			this.UnPackTo(randomInteractT);
			return randomInteractT;
		}

		// Token: 0x06025D12 RID: 154898 RVA: 0x005372CC File Offset: 0x005354CC
		public void UnPackTo(IRandomInteractT _o)
		{
			_o.RandomCount = this.RandomCount;
			_o.Options = new List<IRandomInteractOptionT>();
			for (int i = 0; i < this.OptionsLength; i++)
			{
				_o.Options.Add((this.Options(i) != null) ? this.Options(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06025D13 RID: 154899 RVA: 0x00537338 File Offset: 0x00535538
		public static Offset<IRandomInteract> Pack(FlatBufferBuilder builder, IRandomInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomInteract>);
			}
			VectorOffset optionsOffset = default(VectorOffset);
			if (_o.Options != null)
			{
				Offset<IRandomInteractOption>[] array = new Offset<IRandomInteractOption>[_o.Options.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRandomInteractOption.Pack(builder, _o.Options[i]);
				}
				optionsOffset = IRandomInteract.CreateOptionsVector(builder, array);
			}
			return IRandomInteract.CreateIRandomInteract(builder, _o.RandomCount, optionsOffset);
		}

		// Token: 0x0400ECD9 RID: 60633
		private Table __p;
	}
}
