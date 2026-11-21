using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D49 RID: 27977
	public struct IEnterRandomMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700CD37 RID: 52535
		// (get) Token: 0x06030418 RID: 197656 RVA: 0x0068F31A File Offset: 0x0068D51A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030419 RID: 197657 RVA: 0x0068F327 File Offset: 0x0068D527
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603041A RID: 197658 RVA: 0x0068F330 File Offset: 0x0068D530
		public static IEnterRandomMovieCamera GetRootAsIEnterRandomMovieCamera(ByteBuffer _bb)
		{
			return IEnterRandomMovieCamera.GetRootAsIEnterRandomMovieCamera(_bb, default(IEnterRandomMovieCamera));
		}

		// Token: 0x0603041B RID: 197659 RVA: 0x0068F34C File Offset: 0x0068D54C
		public static IEnterRandomMovieCamera GetRootAsIEnterRandomMovieCamera(ByteBuffer _bb, IEnterRandomMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603041C RID: 197660 RVA: 0x0068F369 File Offset: 0x0068D569
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603041D RID: 197661 RVA: 0x0068F378 File Offset: 0x0068D578
		public IEnterRandomMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD38 RID: 52536
		// (get) Token: 0x0603041E RID: 197662 RVA: 0x0068F388 File Offset: 0x0068D588
		public EMovieCameraType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMovieCameraType.Common;
				}
				return (EMovieCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603041F RID: 197663 RVA: 0x0068F3C4 File Offset: 0x0068D5C4
		public string RowNames(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CD39 RID: 52537
		// (get) Token: 0x06030420 RID: 197664 RVA: 0x0068F400 File Offset: 0x0068D600
		public int RowNamesLength
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

		// Token: 0x06030421 RID: 197665 RVA: 0x0068F42B File Offset: 0x0068D62B
		public static Offset<IEnterRandomMovieCamera> CreateIEnterRandomMovieCamera(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common, VectorOffset RowNamesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEnterRandomMovieCamera.AddRowNames(builder, RowNamesOffset);
			IEnterRandomMovieCamera.AddType(builder, Type);
			return IEnterRandomMovieCamera.EndIEnterRandomMovieCamera(builder);
		}

		// Token: 0x06030422 RID: 197666 RVA: 0x0068F448 File Offset: 0x0068D648
		public static void StartIEnterRandomMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030423 RID: 197667 RVA: 0x0068F451 File Offset: 0x0068D651
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030424 RID: 197668 RVA: 0x0068F45C File Offset: 0x0068D65C
		public static void AddRowNames(FlatBufferBuilder builder, VectorOffset rowNamesOffset)
		{
			builder.AddOffset(1, rowNamesOffset.Value, 0);
		}

		// Token: 0x06030425 RID: 197669 RVA: 0x0068F46C File Offset: 0x0068D66C
		public static VectorOffset CreateRowNamesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030426 RID: 197670 RVA: 0x0068F4AC File Offset: 0x0068D6AC
		public static VectorOffset CreateRowNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030427 RID: 197671 RVA: 0x0068F4C6 File Offset: 0x0068D6C6
		public static VectorOffset CreateRowNamesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06030428 RID: 197672 RVA: 0x0068F4E4 File Offset: 0x0068D6E4
		public static VectorOffset CreateRowNamesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030429 RID: 197673 RVA: 0x0068F4FD File Offset: 0x0068D6FD
		public static void StartRowNamesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603042A RID: 197674 RVA: 0x0068F508 File Offset: 0x0068D708
		public static Offset<IEnterRandomMovieCamera> EndIEnterRandomMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterRandomMovieCamera>(builder.EndTable());
		}

		// Token: 0x0603042B RID: 197675 RVA: 0x0068F518 File Offset: 0x0068D718
		public IEnterRandomMovieCameraT UnPack()
		{
			IEnterRandomMovieCameraT enterRandomMovieCameraT = new IEnterRandomMovieCameraT();
			this.UnPackTo(enterRandomMovieCameraT);
			return enterRandomMovieCameraT;
		}

		// Token: 0x0603042C RID: 197676 RVA: 0x0068F534 File Offset: 0x0068D734
		public void UnPackTo(IEnterRandomMovieCameraT _o)
		{
			_o.Type = this.Type;
			_o.RowNames = new List<string>();
			for (int i = 0; i < this.RowNamesLength; i++)
			{
				_o.RowNames.Add(this.RowNames(i));
			}
		}

		// Token: 0x0603042D RID: 197677 RVA: 0x0068F57C File Offset: 0x0068D77C
		public static Offset<IEnterRandomMovieCamera> Pack(FlatBufferBuilder builder, IEnterRandomMovieCameraT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterRandomMovieCamera>);
			}
			VectorOffset rowNamesOffset = default(VectorOffset);
			if (_o.RowNames != null)
			{
				StringOffset[] array = new StringOffset[_o.RowNames.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.RowNames[i]);
				}
				rowNamesOffset = IEnterRandomMovieCamera.CreateRowNamesVector(builder, array);
			}
			return IEnterRandomMovieCamera.CreateIEnterRandomMovieCamera(builder, _o.Type, rowNamesOffset);
		}

		// Token: 0x04011BBE RID: 72638
		private Table __p;
	}
}
