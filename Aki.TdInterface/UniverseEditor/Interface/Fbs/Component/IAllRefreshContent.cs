using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E98 RID: 20120
	public struct IAllRefreshContent : IFlatbufferObject
	{
		// Token: 0x17009048 RID: 36936
		// (get) Token: 0x0601FA90 RID: 129680 RVA: 0x00468AC9 File Offset: 0x00466CC9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FA91 RID: 129681 RVA: 0x00468AD6 File Offset: 0x00466CD6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FA92 RID: 129682 RVA: 0x00468AE0 File Offset: 0x00466CE0
		public static IAllRefreshContent GetRootAsIAllRefreshContent(ByteBuffer _bb)
		{
			return IAllRefreshContent.GetRootAsIAllRefreshContent(_bb, default(IAllRefreshContent));
		}

		// Token: 0x0601FA93 RID: 129683 RVA: 0x00468AFC File Offset: 0x00466CFC
		public static IAllRefreshContent GetRootAsIAllRefreshContent(ByteBuffer _bb, IAllRefreshContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FA94 RID: 129684 RVA: 0x00468B19 File Offset: 0x00466D19
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FA95 RID: 129685 RVA: 0x00468B28 File Offset: 0x00466D28
		public IAllRefreshContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009049 RID: 36937
		// (get) Token: 0x0601FA96 RID: 129686 RVA: 0x00468B38 File Offset: 0x00466D38
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

		// Token: 0x0601FA97 RID: 129687 RVA: 0x00468B74 File Offset: 0x00466D74
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700904A RID: 36938
		// (get) Token: 0x0601FA98 RID: 129688 RVA: 0x00468BB4 File Offset: 0x00466DB4
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

		// Token: 0x0601FA99 RID: 129689 RVA: 0x00468BDF File Offset: 0x00466DDF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0601FA9A RID: 129690 RVA: 0x00468BEE File Offset: 0x00466DEE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x0601FA9B RID: 129691 RVA: 0x00468BFC File Offset: 0x00466DFC
		public static Offset<IAllRefreshContent> CreateIAllRefreshContent(FlatBufferBuilder builder, ERefreshContent Type = ERefreshContent.All, VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IAllRefreshContent.AddEntityIds(builder, EntityIdsOffset);
			IAllRefreshContent.AddType(builder, Type);
			return IAllRefreshContent.EndIAllRefreshContent(builder);
		}

		// Token: 0x0601FA9C RID: 129692 RVA: 0x00468C19 File Offset: 0x00466E19
		public static void StartIAllRefreshContent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FA9D RID: 129693 RVA: 0x00468C22 File Offset: 0x00466E22
		public static void AddType(FlatBufferBuilder builder, ERefreshContent type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FA9E RID: 129694 RVA: 0x00468C2D File Offset: 0x00466E2D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(1, entityIdsOffset.Value, 0);
		}

		// Token: 0x0601FA9F RID: 129695 RVA: 0x00468C40 File Offset: 0x00466E40
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0601FAA0 RID: 129696 RVA: 0x00468C77 File Offset: 0x00466E77
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FAA1 RID: 129697 RVA: 0x00468C91 File Offset: 0x00466E91
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0601FAA2 RID: 129698 RVA: 0x00468CAF File Offset: 0x00466EAF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601FAA3 RID: 129699 RVA: 0x00468CC8 File Offset: 0x00466EC8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601FAA4 RID: 129700 RVA: 0x00468CD3 File Offset: 0x00466ED3
		public static Offset<IAllRefreshContent> EndIAllRefreshContent(FlatBufferBuilder builder)
		{
			return new Offset<IAllRefreshContent>(builder.EndTable());
		}

		// Token: 0x0601FAA5 RID: 129701 RVA: 0x00468CE0 File Offset: 0x00466EE0
		public IAllRefreshContentT UnPack()
		{
			IAllRefreshContentT allRefreshContentT = new IAllRefreshContentT();
			this.UnPackTo(allRefreshContentT);
			return allRefreshContentT;
		}

		// Token: 0x0601FAA6 RID: 129702 RVA: 0x00468CFC File Offset: 0x00466EFC
		public void UnPackTo(IAllRefreshContentT _o)
		{
			_o.Type = this.Type;
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x0601FAA7 RID: 129703 RVA: 0x00468D44 File Offset: 0x00466F44
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

		// Token: 0x0400DC71 RID: 56433
		private Table __p;
	}
}
