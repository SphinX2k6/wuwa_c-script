using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057E4 RID: 22500
	public struct IRandomEntityRefreshContent : IFlatbufferObject
	{
		// Token: 0x1700A80F RID: 43023
		// (get) Token: 0x06025CE0 RID: 154848 RVA: 0x00536D64 File Offset: 0x00534F64
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025CE1 RID: 154849 RVA: 0x00536D71 File Offset: 0x00534F71
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025CE2 RID: 154850 RVA: 0x00536D78 File Offset: 0x00534F78
		public static IRandomEntityRefreshContent GetRootAsIRandomEntityRefreshContent(ByteBuffer _bb)
		{
			return IRandomEntityRefreshContent.GetRootAsIRandomEntityRefreshContent(_bb, default(IRandomEntityRefreshContent));
		}

		// Token: 0x06025CE3 RID: 154851 RVA: 0x00536D94 File Offset: 0x00534F94
		public static IRandomEntityRefreshContent GetRootAsIRandomEntityRefreshContent(ByteBuffer _bb, IRandomEntityRefreshContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025CE4 RID: 154852 RVA: 0x00536DB1 File Offset: 0x00534FB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025CE5 RID: 154853 RVA: 0x00536DC0 File Offset: 0x00534FC0
		public IRandomEntityRefreshContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A810 RID: 43024
		// (get) Token: 0x06025CE6 RID: 154854 RVA: 0x00536DD0 File Offset: 0x00534FD0
		public ERefreshContent Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERefreshContent.All;
				}
				return (ERefreshContent)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025CE7 RID: 154855 RVA: 0x00536E0C File Offset: 0x0053500C
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A811 RID: 43025
		// (get) Token: 0x06025CE8 RID: 154856 RVA: 0x00536E4C File Offset: 0x0053504C
		public int EntityIdsLength
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

		// Token: 0x06025CE9 RID: 154857 RVA: 0x00536E77 File Offset: 0x00535077
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06025CEA RID: 154858 RVA: 0x00536E86 File Offset: 0x00535086
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06025CEB RID: 154859 RVA: 0x00536E94 File Offset: 0x00535094
		public static Offset<IRandomEntityRefreshContent> CreateIRandomEntityRefreshContent(FlatBufferBuilder builder, ERefreshContent Type = ERefreshContent.All, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomEntityRefreshContent.AddEntityIds(builder, EntityIdsOffset);
			IRandomEntityRefreshContent.AddType(builder, Type);
			return IRandomEntityRefreshContent.EndIRandomEntityRefreshContent(builder);
		}

		// Token: 0x06025CEC RID: 154860 RVA: 0x00536EB1 File Offset: 0x005350B1
		public static void StartIRandomEntityRefreshContent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025CED RID: 154861 RVA: 0x00536EBA File Offset: 0x005350BA
		public static void AddType(FlatBufferBuilder builder, ERefreshContent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025CEE RID: 154862 RVA: 0x00536EC5 File Offset: 0x005350C5
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06025CEF RID: 154863 RVA: 0x00536ED8 File Offset: 0x005350D8
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025CF0 RID: 154864 RVA: 0x00536F0F File Offset: 0x0053510F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CF1 RID: 154865 RVA: 0x00536F29 File Offset: 0x00535129
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025CF2 RID: 154866 RVA: 0x00536F47 File Offset: 0x00535147
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025CF3 RID: 154867 RVA: 0x00536F60 File Offset: 0x00535160
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025CF4 RID: 154868 RVA: 0x00536F6B File Offset: 0x0053516B
		public static Offset<IRandomEntityRefreshContent> EndIRandomEntityRefreshContent(FlatBufferBuilder builder)
		{
			return new Offset<IRandomEntityRefreshContent>(builder.EndTable());
		}

		// Token: 0x06025CF5 RID: 154869 RVA: 0x00536F78 File Offset: 0x00535178
		public IRandomEntityRefreshContentT UnPack()
		{
			IRandomEntityRefreshContentT randomEntityRefreshContentT = new IRandomEntityRefreshContentT();
			this.UnPackTo(randomEntityRefreshContentT);
			return randomEntityRefreshContentT;
		}

		// Token: 0x06025CF6 RID: 154870 RVA: 0x00536F94 File Offset: 0x00535194
		public void UnPackTo(IRandomEntityRefreshContentT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06025CF7 RID: 154871 RVA: 0x00536FDC File Offset: 0x005351DC
		public static Offset<IRandomEntityRefreshContent> Pack(FlatBufferBuilder builder, IRandomEntityRefreshContentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRandomEntityRefreshContent>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IRandomEntityRefreshContent.CreateEntityIdsVector(builder, data);
			}
			return IRandomEntityRefreshContent.CreateIRandomEntityRefreshContent(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400ECD6 RID: 60630
		private Table __p;
	}
}
