using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D9E RID: 28062
	public struct IPreloadSubLevels : IFlatbufferObject
	{
		// Token: 0x1700D150 RID: 53584
		// (get) Token: 0x06031923 RID: 203043 RVA: 0x006B7DCE File Offset: 0x006B5FCE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031924 RID: 203044 RVA: 0x006B7DDB File Offset: 0x006B5FDB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031925 RID: 203045 RVA: 0x006B7DE4 File Offset: 0x006B5FE4
		public static IPreloadSubLevels GetRootAsIPreloadSubLevels(ByteBuffer _bb)
		{
			return IPreloadSubLevels.GetRootAsIPreloadSubLevels(_bb, default(IPreloadSubLevels));
		}

		// Token: 0x06031926 RID: 203046 RVA: 0x006B7E00 File Offset: 0x006B6000
		public static IPreloadSubLevels GetRootAsIPreloadSubLevels(ByteBuffer _bb, IPreloadSubLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031927 RID: 203047 RVA: 0x006B7E1D File Offset: 0x006B601D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031928 RID: 203048 RVA: 0x006B7E2C File Offset: 0x006B602C
		public IPreloadSubLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D151 RID: 53585
		// (get) Token: 0x06031929 RID: 203049 RVA: 0x006B7E3C File Offset: 0x006B603C
		public ESwitchSubLevelsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return (ESwitchSubLevelsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603192A RID: 203050 RVA: 0x006B7E78 File Offset: 0x006B6078
		public string PreloadLevels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D152 RID: 53586
		// (get) Token: 0x0603192B RID: 203051 RVA: 0x006B7EB4 File Offset: 0x006B60B4
		public int PreloadLevelsLength
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

		// Token: 0x0603192C RID: 203052 RVA: 0x006B7EDF File Offset: 0x006B60DF
		public static Offset<IPreloadSubLevels> CreateIPreloadSubLevels(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly, VectorOffset PreloadLevelsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPreloadSubLevels.AddPreloadLevels(builder, PreloadLevelsOffset);
			IPreloadSubLevels.AddType(builder, Type);
			return IPreloadSubLevels.EndIPreloadSubLevels(builder);
		}

		// Token: 0x0603192D RID: 203053 RVA: 0x006B7EFC File Offset: 0x006B60FC
		public static void StartIPreloadSubLevels(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603192E RID: 203054 RVA: 0x006B7F05 File Offset: 0x006B6105
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603192F RID: 203055 RVA: 0x006B7F10 File Offset: 0x006B6110
		public static void AddPreloadLevels(FlatBufferBuilder builder, VectorOffset preloadLevelsOffset)
		{
			builder.AddOffset(1, preloadLevelsOffset.Value, 0);
		}

		// Token: 0x06031930 RID: 203056 RVA: 0x006B7F20 File Offset: 0x006B6120
		public static VectorOffset CreatePreloadLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06031931 RID: 203057 RVA: 0x006B7F60 File Offset: 0x006B6160
		public static VectorOffset CreatePreloadLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06031932 RID: 203058 RVA: 0x006B7F7A File Offset: 0x006B617A
		public static VectorOffset CreatePreloadLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06031933 RID: 203059 RVA: 0x006B7F98 File Offset: 0x006B6198
		public static VectorOffset CreatePreloadLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031934 RID: 203060 RVA: 0x006B7FB1 File Offset: 0x006B61B1
		public static void StartPreloadLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031935 RID: 203061 RVA: 0x006B7FBC File Offset: 0x006B61BC
		public static Offset<IPreloadSubLevels> EndIPreloadSubLevels(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadSubLevels>(builder.EndTable());
		}

		// Token: 0x06031936 RID: 203062 RVA: 0x006B7FCC File Offset: 0x006B61CC
		public IPreloadSubLevelsT UnPack()
		{
			IPreloadSubLevelsT preloadSubLevelsT = new IPreloadSubLevelsT();
			this.UnPackTo(preloadSubLevelsT);
			return preloadSubLevelsT;
		}

		// Token: 0x06031937 RID: 203063 RVA: 0x006B7FE8 File Offset: 0x006B61E8
		public void UnPackTo(IPreloadSubLevelsT _o)
		{
			_o.Type = this.Type;
			_o.PreloadLevels = new List<string>();
			for (int i = 0; i < this.PreloadLevelsLength; i++)
			{
				_o.PreloadLevels.Add(this.PreloadLevels(i));
			}
		}

		// Token: 0x06031938 RID: 203064 RVA: 0x006B8030 File Offset: 0x006B6230
		public static Offset<IPreloadSubLevels> Pack(FlatBufferBuilder builder, IPreloadSubLevelsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadSubLevels>);
			}
			VectorOffset preloadLevelsOffset = default(VectorOffset);
			if (_o.PreloadLevels != null)
			{
				StringOffset[] array = new StringOffset[_o.PreloadLevels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.PreloadLevels[i]);
				}
				preloadLevelsOffset = IPreloadSubLevels.CreatePreloadLevelsVector(builder, array);
			}
			return IPreloadSubLevels.CreateIPreloadSubLevels(builder, _o.Type, preloadLevelsOffset);
		}

		// Token: 0x04011771 RID: 71537
		private Table __p;
	}
}
