using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DEB RID: 24043
	public struct IRandomEntityRefreshContent : IFlatbufferObject
	{
		// Token: 0x1700B133 RID: 45363
		// (get) Token: 0x06028200 RID: 164352 RVA: 0x0057CEF0 File Offset: 0x0057B0F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028201 RID: 164353 RVA: 0x0057CEFD File Offset: 0x0057B0FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028202 RID: 164354 RVA: 0x0057CF04 File Offset: 0x0057B104
		public static IRandomEntityRefreshContent GetRootAsIRandomEntityRefreshContent(ByteBuffer _bb)
		{
			return IRandomEntityRefreshContent.GetRootAsIRandomEntityRefreshContent(_bb, default(IRandomEntityRefreshContent));
		}

		// Token: 0x06028203 RID: 164355 RVA: 0x0057CF20 File Offset: 0x0057B120
		public static IRandomEntityRefreshContent GetRootAsIRandomEntityRefreshContent(ByteBuffer _bb, IRandomEntityRefreshContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028204 RID: 164356 RVA: 0x0057CF3D File Offset: 0x0057B13D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028205 RID: 164357 RVA: 0x0057CF4C File Offset: 0x0057B14C
		public IRandomEntityRefreshContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B134 RID: 45364
		// (get) Token: 0x06028206 RID: 164358 RVA: 0x0057CF5C File Offset: 0x0057B15C
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

		// Token: 0x06028207 RID: 164359 RVA: 0x0057CF98 File Offset: 0x0057B198
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B135 RID: 45365
		// (get) Token: 0x06028208 RID: 164360 RVA: 0x0057CFD8 File Offset: 0x0057B1D8
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

		// Token: 0x06028209 RID: 164361 RVA: 0x0057D003 File Offset: 0x0057B203
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0602820A RID: 164362 RVA: 0x0057D012 File Offset: 0x0057B212
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0602820B RID: 164363 RVA: 0x0057D020 File Offset: 0x0057B220
		public static Offset<IRandomEntityRefreshContent> CreateIRandomEntityRefreshContent(FlatBufferBuilder builder, ERefreshContent Type = ERefreshContent.All, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRandomEntityRefreshContent.AddEntityIds(builder, EntityIdsOffset);
			IRandomEntityRefreshContent.AddType(builder, Type);
			return IRandomEntityRefreshContent.EndIRandomEntityRefreshContent(builder);
		}

		// Token: 0x0602820C RID: 164364 RVA: 0x0057D03D File Offset: 0x0057B23D
		public static void StartIRandomEntityRefreshContent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602820D RID: 164365 RVA: 0x0057D046 File Offset: 0x0057B246
		public static void AddType(FlatBufferBuilder builder, ERefreshContent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602820E RID: 164366 RVA: 0x0057D051 File Offset: 0x0057B251
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602820F RID: 164367 RVA: 0x0057D064 File Offset: 0x0057B264
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028210 RID: 164368 RVA: 0x0057D09B File Offset: 0x0057B29B
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028211 RID: 164369 RVA: 0x0057D0B5 File Offset: 0x0057B2B5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028212 RID: 164370 RVA: 0x0057D0D3 File Offset: 0x0057B2D3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028213 RID: 164371 RVA: 0x0057D0EC File Offset: 0x0057B2EC
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028214 RID: 164372 RVA: 0x0057D0F7 File Offset: 0x0057B2F7
		public static Offset<IRandomEntityRefreshContent> EndIRandomEntityRefreshContent(FlatBufferBuilder builder)
		{
			return new Offset<IRandomEntityRefreshContent>(builder.EndTable());
		}

		// Token: 0x06028215 RID: 164373 RVA: 0x0057D104 File Offset: 0x0057B304
		public IRandomEntityRefreshContentT UnPack()
		{
			IRandomEntityRefreshContentT randomEntityRefreshContentT = new IRandomEntityRefreshContentT();
			this.UnPackTo(randomEntityRefreshContentT);
			return randomEntityRefreshContentT;
		}

		// Token: 0x06028216 RID: 164374 RVA: 0x0057D120 File Offset: 0x0057B320
		public void UnPackTo(IRandomEntityRefreshContentT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06028217 RID: 164375 RVA: 0x0057D168 File Offset: 0x0057B368
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

		// Token: 0x0400F9C1 RID: 63937
		private Table __p;
	}
}
