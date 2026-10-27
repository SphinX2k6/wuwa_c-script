using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CF RID: 26319
	public struct IEnterRandomMovieCamera : IFlatbufferObject
	{
		// Token: 0x1700C386 RID: 50054
		// (get) Token: 0x0602DBFB RID: 187387 RVA: 0x00642066 File Offset: 0x00640266
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBFC RID: 187388 RVA: 0x00642073 File Offset: 0x00640273
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBFD RID: 187389 RVA: 0x0064207C File Offset: 0x0064027C
		public static IEnterRandomMovieCamera GetRootAsIEnterRandomMovieCamera(ByteBuffer _bb)
		{
			return IEnterRandomMovieCamera.GetRootAsIEnterRandomMovieCamera(_bb, default(IEnterRandomMovieCamera));
		}

		// Token: 0x0602DBFE RID: 187390 RVA: 0x00642098 File Offset: 0x00640298
		public static IEnterRandomMovieCamera GetRootAsIEnterRandomMovieCamera(ByteBuffer _bb, IEnterRandomMovieCamera obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBFF RID: 187391 RVA: 0x006420B5 File Offset: 0x006402B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DC00 RID: 187392 RVA: 0x006420C4 File Offset: 0x006402C4
		public IEnterRandomMovieCamera __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C387 RID: 50055
		// (get) Token: 0x0602DC01 RID: 187393 RVA: 0x006420D4 File Offset: 0x006402D4
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

		// Token: 0x0602DC02 RID: 187394 RVA: 0x00642110 File Offset: 0x00640310
		public string RowNames(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700C388 RID: 50056
		// (get) Token: 0x0602DC03 RID: 187395 RVA: 0x0064214C File Offset: 0x0064034C
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

		// Token: 0x0602DC04 RID: 187396 RVA: 0x00642177 File Offset: 0x00640377
		public static Offset<IEnterRandomMovieCamera> CreateIEnterRandomMovieCamera(FlatBufferBuilder builder, EMovieCameraType Type = EMovieCameraType.Common, VectorOffset RowNamesOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IEnterRandomMovieCamera.AddRowNames(builder, RowNamesOffset);
			IEnterRandomMovieCamera.AddType(builder, Type);
			return IEnterRandomMovieCamera.EndIEnterRandomMovieCamera(builder);
		}

		// Token: 0x0602DC05 RID: 187397 RVA: 0x00642194 File Offset: 0x00640394
		public static void StartIEnterRandomMovieCamera(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DC06 RID: 187398 RVA: 0x0064219D File Offset: 0x0064039D
		public static void AddType(FlatBufferBuilder builder, EMovieCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DC07 RID: 187399 RVA: 0x006421A8 File Offset: 0x006403A8
		public static void AddRowNames(FlatBufferBuilder builder, VectorOffset rowNamesOffset)
		{
			builder.AddOffset(1, rowNamesOffset.Value, 0);
		}

		// Token: 0x0602DC08 RID: 187400 RVA: 0x006421B8 File Offset: 0x006403B8
		public static VectorOffset CreateRowNamesVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602DC09 RID: 187401 RVA: 0x006421F8 File Offset: 0x006403F8
		public static VectorOffset CreateRowNamesVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DC0A RID: 187402 RVA: 0x00642212 File Offset: 0x00640412
		public static VectorOffset CreateRowNamesVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602DC0B RID: 187403 RVA: 0x00642230 File Offset: 0x00640430
		public static VectorOffset CreateRowNamesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602DC0C RID: 187404 RVA: 0x00642249 File Offset: 0x00640449
		public static void StartRowNamesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602DC0D RID: 187405 RVA: 0x00642254 File Offset: 0x00640454
		public static Offset<IEnterRandomMovieCamera> EndIEnterRandomMovieCamera(FlatBufferBuilder builder)
		{
			return new Offset<IEnterRandomMovieCamera>(builder.EndTable());
		}

		// Token: 0x0602DC0E RID: 187406 RVA: 0x00642264 File Offset: 0x00640464
		public IEnterRandomMovieCameraT UnPack()
		{
			IEnterRandomMovieCameraT enterRandomMovieCameraT = new IEnterRandomMovieCameraT();
			this.UnPackTo(enterRandomMovieCameraT);
			return enterRandomMovieCameraT;
		}

		// Token: 0x0602DC0F RID: 187407 RVA: 0x00642280 File Offset: 0x00640480
		public void UnPackTo(IEnterRandomMovieCameraT _o)
		{
			_o.Type = this.Type;
			_o.RowNames = new List<string>();
			for (int i = 0; i < this.RowNamesLength; i++)
			{
				_o.RowNames.Add(this.RowNames(i));
			}
		}

		// Token: 0x0602DC10 RID: 187408 RVA: 0x006422C8 File Offset: 0x006404C8
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

		// Token: 0x04010D98 RID: 69016
		private Table __p;
	}
}
