using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C1 RID: 21441
	public struct IAllRefreshContent : IFlatbufferObject
	{
		// Token: 0x170097A7 RID: 38823
		// (get) Token: 0x06021785 RID: 137093 RVA: 0x0049DD2D File Offset: 0x0049BF2D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021786 RID: 137094 RVA: 0x0049DD3A File Offset: 0x0049BF3A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021787 RID: 137095 RVA: 0x0049DD44 File Offset: 0x0049BF44
		public static IAllRefreshContent GetRootAsIAllRefreshContent(ByteBuffer _bb)
		{
			return IAllRefreshContent.GetRootAsIAllRefreshContent(_bb, default(IAllRefreshContent));
		}

		// Token: 0x06021788 RID: 137096 RVA: 0x0049DD60 File Offset: 0x0049BF60
		public static IAllRefreshContent GetRootAsIAllRefreshContent(ByteBuffer _bb, IAllRefreshContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021789 RID: 137097 RVA: 0x0049DD7D File Offset: 0x0049BF7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602178A RID: 137098 RVA: 0x0049DD8C File Offset: 0x0049BF8C
		public IAllRefreshContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170097A8 RID: 38824
		// (get) Token: 0x0602178B RID: 137099 RVA: 0x0049DD9C File Offset: 0x0049BF9C
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

		// Token: 0x0602178C RID: 137100 RVA: 0x0049DDD8 File Offset: 0x0049BFD8
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170097A9 RID: 38825
		// (get) Token: 0x0602178D RID: 137101 RVA: 0x0049DE18 File Offset: 0x0049C018
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

		// Token: 0x0602178E RID: 137102 RVA: 0x0049DE43 File Offset: 0x0049C043
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602178F RID: 137103 RVA: 0x0049DE52 File Offset: 0x0049C052
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x06021790 RID: 137104 RVA: 0x0049DE60 File Offset: 0x0049C060
		public static Offset<IAllRefreshContent> CreateIAllRefreshContent(FlatBufferBuilder builder, ERefreshContent Type = ERefreshContent.All, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAllRefreshContent.AddEntityIds(builder, EntityIdsOffset);
			IAllRefreshContent.AddType(builder, Type);
			return IAllRefreshContent.EndIAllRefreshContent(builder);
		}

		// Token: 0x06021791 RID: 137105 RVA: 0x0049DE7D File Offset: 0x0049C07D
		public static void StartIAllRefreshContent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021792 RID: 137106 RVA: 0x0049DE86 File Offset: 0x0049C086
		public static void AddType(FlatBufferBuilder builder, ERefreshContent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06021793 RID: 137107 RVA: 0x0049DE91 File Offset: 0x0049C091
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x06021794 RID: 137108 RVA: 0x0049DEA4 File Offset: 0x0049C0A4
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06021795 RID: 137109 RVA: 0x0049DEDB File Offset: 0x0049C0DB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021796 RID: 137110 RVA: 0x0049DEF5 File Offset: 0x0049C0F5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06021797 RID: 137111 RVA: 0x0049DF13 File Offset: 0x0049C113
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021798 RID: 137112 RVA: 0x0049DF2C File Offset: 0x0049C12C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021799 RID: 137113 RVA: 0x0049DF37 File Offset: 0x0049C137
		public static Offset<IAllRefreshContent> EndIAllRefreshContent(FlatBufferBuilder builder)
		{
			return new Offset<IAllRefreshContent>(builder.EndTable());
		}

		// Token: 0x0602179A RID: 137114 RVA: 0x0049DF44 File Offset: 0x0049C144
		public IAllRefreshContentT UnPack()
		{
			IAllRefreshContentT allRefreshContentT = new IAllRefreshContentT();
			this.UnPackTo(allRefreshContentT);
			return allRefreshContentT;
		}

		// Token: 0x0602179B RID: 137115 RVA: 0x0049DF60 File Offset: 0x0049C160
		public void UnPackTo(IAllRefreshContentT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0602179C RID: 137116 RVA: 0x0049DFA8 File Offset: 0x0049C1A8
		public static Offset<IAllRefreshContent> Pack(FlatBufferBuilder builder, IAllRefreshContentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAllRefreshContent>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IAllRefreshContent.CreateEntityIdsVector(builder, data);
			}
			return IAllRefreshContent.CreateIAllRefreshContent(builder, _o.Type, entityIdsOffset);
		}

		// Token: 0x0400E80C RID: 59404
		private Table __p;
	}
}
