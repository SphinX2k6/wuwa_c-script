using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007519 RID: 29977
	public struct IPreloadSubLevels : IFlatbufferObject
	{
		// Token: 0x1700DC98 RID: 56472
		// (get) Token: 0x0603491F RID: 215327 RVA: 0x007134B6 File Offset: 0x007116B6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034920 RID: 215328 RVA: 0x007134C3 File Offset: 0x007116C3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034921 RID: 215329 RVA: 0x007134CC File Offset: 0x007116CC
		public static IPreloadSubLevels GetRootAsIPreloadSubLevels(ByteBuffer _bb)
		{
			return IPreloadSubLevels.GetRootAsIPreloadSubLevels(_bb, default(IPreloadSubLevels));
		}

		// Token: 0x06034922 RID: 215330 RVA: 0x007134E8 File Offset: 0x007116E8
		public static IPreloadSubLevels GetRootAsIPreloadSubLevels(ByteBuffer _bb, IPreloadSubLevels obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034923 RID: 215331 RVA: 0x00713505 File Offset: 0x00711705
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034924 RID: 215332 RVA: 0x00713514 File Offset: 0x00711714
		public IPreloadSubLevels __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC99 RID: 56473
		// (get) Token: 0x06034925 RID: 215333 RVA: 0x00713524 File Offset: 0x00711724
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

		// Token: 0x06034926 RID: 215334 RVA: 0x00713560 File Offset: 0x00711760
		public string PreloadLevels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DC9A RID: 56474
		// (get) Token: 0x06034927 RID: 215335 RVA: 0x0071359C File Offset: 0x0071179C
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

		// Token: 0x06034928 RID: 215336 RVA: 0x007135C7 File Offset: 0x007117C7
		public static Offset<IPreloadSubLevels> CreateIPreloadSubLevels(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly, VectorOffset PreloadLevelsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPreloadSubLevels.AddPreloadLevels(builder, PreloadLevelsOffset);
			IPreloadSubLevels.AddType(builder, Type);
			return IPreloadSubLevels.EndIPreloadSubLevels(builder);
		}

		// Token: 0x06034929 RID: 215337 RVA: 0x007135E4 File Offset: 0x007117E4
		public static void StartIPreloadSubLevels(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603492A RID: 215338 RVA: 0x007135ED File Offset: 0x007117ED
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603492B RID: 215339 RVA: 0x007135F8 File Offset: 0x007117F8
		public static void AddPreloadLevels(FlatBufferBuilder builder, VectorOffset preloadLevelsOffset)
		{
			builder.AddOffset(1, preloadLevelsOffset.Value, 0);
		}

		// Token: 0x0603492C RID: 215340 RVA: 0x00713608 File Offset: 0x00711808
		public static VectorOffset CreatePreloadLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603492D RID: 215341 RVA: 0x00713648 File Offset: 0x00711848
		public static VectorOffset CreatePreloadLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603492E RID: 215342 RVA: 0x00713662 File Offset: 0x00711862
		public static VectorOffset CreatePreloadLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603492F RID: 215343 RVA: 0x00713680 File Offset: 0x00711880
		public static VectorOffset CreatePreloadLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06034930 RID: 215344 RVA: 0x00713699 File Offset: 0x00711899
		public static void StartPreloadLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06034931 RID: 215345 RVA: 0x007136A4 File Offset: 0x007118A4
		public static Offset<IPreloadSubLevels> EndIPreloadSubLevels(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadSubLevels>(builder.EndTable());
		}

		// Token: 0x06034932 RID: 215346 RVA: 0x007136B4 File Offset: 0x007118B4
		public IPreloadSubLevelsT UnPack()
		{
			IPreloadSubLevelsT preloadSubLevelsT = new IPreloadSubLevelsT();
			this.UnPackTo(preloadSubLevelsT);
			return preloadSubLevelsT;
		}

		// Token: 0x06034933 RID: 215347 RVA: 0x007136D0 File Offset: 0x007118D0
		public void UnPackTo(IPreloadSubLevelsT _o)
		{
			_o.Type = this.Type;
			_o.PreloadLevels = new List<string>();
			for (int i = 0; i < this.PreloadLevelsLength; i++)
			{
				_o.PreloadLevels.Add(this.PreloadLevels(i));
			}
		}

		// Token: 0x06034934 RID: 215348 RVA: 0x00713718 File Offset: 0x00711918
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

		// Token: 0x040126ED RID: 75501
		private Table __p;
	}
}
