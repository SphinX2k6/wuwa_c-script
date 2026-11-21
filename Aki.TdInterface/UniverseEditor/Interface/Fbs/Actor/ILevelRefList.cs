using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02006540 RID: 25920
	public struct ILevelRefList : IFlatbufferObject
	{
		// Token: 0x1700BF35 RID: 48949
		// (get) Token: 0x0602C2F8 RID: 180984 RVA: 0x00604760 File Offset: 0x00602960
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C2F9 RID: 180985 RVA: 0x0060476D File Offset: 0x0060296D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C2FA RID: 180986 RVA: 0x00604774 File Offset: 0x00602974
		public static ILevelRefList GetRootAsILevelRefList(ByteBuffer _bb)
		{
			return ILevelRefList.GetRootAsILevelRefList(_bb, default(ILevelRefList));
		}

		// Token: 0x0602C2FB RID: 180987 RVA: 0x00604790 File Offset: 0x00602990
		public static ILevelRefList GetRootAsILevelRefList(ByteBuffer _bb, ILevelRefList obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C2FC RID: 180988 RVA: 0x006047AD File Offset: 0x006029AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C2FD RID: 180989 RVA: 0x006047BC File Offset: 0x006029BC
		public ILevelRefList __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602C2FE RID: 180990 RVA: 0x006047CC File Offset: 0x006029CC
		public ILevelRefData? LevelRefList(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new ILevelRefData?(default(ILevelRefData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BF36 RID: 48950
		// (get) Token: 0x0602C2FF RID: 180991 RVA: 0x0060482C File Offset: 0x00602A2C
		public int LevelRefListLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C300 RID: 180992 RVA: 0x00604857 File Offset: 0x00602A57
		public static Offset<ILevelRefList> CreateILevelRefList(FlatBufferBuilder builder, VectorOffset LevelRefListOffset = default(VectorOffset))
		{
			builder.StartTable(1);
			ILevelRefList.AddLevelRefList(builder, LevelRefListOffset);
			return ILevelRefList.EndILevelRefList(builder);
		}

		// Token: 0x0602C301 RID: 180993 RVA: 0x0060486D File Offset: 0x00602A6D
		public static void StartILevelRefList(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C302 RID: 180994 RVA: 0x00604876 File Offset: 0x00602A76
		public static void AddLevelRefList(FlatBufferBuilder builder, VectorOffset levelRefListOffset)
		{
			builder.AddOffset(0, levelRefListOffset.Value, 0);
		}

		// Token: 0x0602C303 RID: 180995 RVA: 0x00604888 File Offset: 0x00602A88
		public static VectorOffset CreateLevelRefListVector(FlatBufferBuilder builder, Offset<ILevelRefData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C304 RID: 180996 RVA: 0x006048C8 File Offset: 0x00602AC8
		public static VectorOffset CreateLevelRefListVectorBlock(FlatBufferBuilder builder, Offset<ILevelRefData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILevelRefData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C305 RID: 180997 RVA: 0x006048E2 File Offset: 0x00602AE2
		public static VectorOffset CreateLevelRefListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILevelRefData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILevelRefData>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C306 RID: 180998 RVA: 0x00604900 File Offset: 0x00602B00
		public static VectorOffset CreateLevelRefListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILevelRefData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C307 RID: 180999 RVA: 0x00604919 File Offset: 0x00602B19
		public static void StartLevelRefListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C308 RID: 181000 RVA: 0x00604924 File Offset: 0x00602B24
		public static Offset<ILevelRefList> EndILevelRefList(FlatBufferBuilder builder)
		{
			return new Offset<ILevelRefList>(builder.EndTable());
		}

		// Token: 0x0602C309 RID: 181001 RVA: 0x00604934 File Offset: 0x00602B34
		public ILevelRefListT UnPack()
		{
			ILevelRefListT levelRefListT = new ILevelRefListT();
			this.UnPackTo(levelRefListT);
			return levelRefListT;
		}

		// Token: 0x0602C30A RID: 181002 RVA: 0x00604950 File Offset: 0x00602B50
		public void UnPackTo(ILevelRefListT _o)
		{
			_o.LevelRefList = new List<ILevelRefDataT>();
			for (int i = 0; i < this.LevelRefListLength; i++)
			{
				_o.LevelRefList.Add((this.LevelRefList(i) != null) ? this.LevelRefList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C30B RID: 181003 RVA: 0x006049B0 File Offset: 0x00602BB0
		public static Offset<ILevelRefList> Pack(FlatBufferBuilder builder, ILevelRefListT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelRefList>);
			}
			VectorOffset levelRefListOffset = default(VectorOffset);
			if (_o.LevelRefList != null)
			{
				Offset<ILevelRefData>[] array = new Offset<ILevelRefData>[_o.LevelRefList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ILevelRefData.Pack(builder, _o.LevelRefList[i]);
				}
				levelRefListOffset = ILevelRefList.CreateLevelRefListVector(builder, array);
			}
			return ILevelRefList.CreateILevelRefList(builder, levelRefListOffset);
		}

		// Token: 0x04010767 RID: 67431
		private Table __p;
	}
}
