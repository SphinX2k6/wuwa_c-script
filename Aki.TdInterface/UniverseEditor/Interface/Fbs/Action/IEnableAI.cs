using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CB0 RID: 27824
	public struct IEnableAI : IFlatbufferObject
	{
		// Token: 0x1700CC18 RID: 52248
		// (get) Token: 0x0602FF2E RID: 196398 RVA: 0x00686D16 File Offset: 0x00684F16
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF2F RID: 196399 RVA: 0x00686D23 File Offset: 0x00684F23
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF30 RID: 196400 RVA: 0x00686D2C File Offset: 0x00684F2C
		public static IEnableAI GetRootAsIEnableAI(ByteBuffer _bb)
		{
			return IEnableAI.GetRootAsIEnableAI(_bb, default(IEnableAI));
		}

		// Token: 0x0602FF31 RID: 196401 RVA: 0x00686D48 File Offset: 0x00684F48
		public static IEnableAI GetRootAsIEnableAI(ByteBuffer _bb, IEnableAI obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF32 RID: 196402 RVA: 0x00686D65 File Offset: 0x00684F65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF33 RID: 196403 RVA: 0x00686D74 File Offset: 0x00684F74
		public IEnableAI __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x0602FF34 RID: 196404 RVA: 0x00686D84 File Offset: 0x00684F84
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CC19 RID: 52249
		// (get) Token: 0x0602FF35 RID: 196405 RVA: 0x00686DC4 File Offset: 0x00684FC4
		public int EntityIdsLength
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

		// Token: 0x0602FF36 RID: 196406 RVA: 0x00686DEF File Offset: 0x00684FEF
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x0602FF37 RID: 196407 RVA: 0x00686DFE File Offset: 0x00684FFE
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700CC1A RID: 52250
		// (get) Token: 0x0602FF38 RID: 196408 RVA: 0x00686E0C File Offset: 0x0068500C
		public bool IsEnable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602FF39 RID: 196409 RVA: 0x00686E4B File Offset: 0x0068504B
		public static Offset<IEnableAI> CreateIEnableAI(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool IsEnable = false)
		{
			builder.StartTable(2);
			IEnableAI.AddEntityIds(builder, EntityIdsOffset);
			IEnableAI.AddIsEnable(builder, IsEnable);
			return IEnableAI.EndIEnableAI(builder);
		}

		// Token: 0x0602FF3A RID: 196410 RVA: 0x00686E68 File Offset: 0x00685068
		public static void StartIEnableAI(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FF3B RID: 196411 RVA: 0x00686E71 File Offset: 0x00685071
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x0602FF3C RID: 196412 RVA: 0x00686E84 File Offset: 0x00685084
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FF3D RID: 196413 RVA: 0x00686EBB File Offset: 0x006850BB
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FF3E RID: 196414 RVA: 0x00686ED5 File Offset: 0x006850D5
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FF3F RID: 196415 RVA: 0x00686EF3 File Offset: 0x006850F3
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FF40 RID: 196416 RVA: 0x00686F0C File Offset: 0x0068510C
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FF41 RID: 196417 RVA: 0x00686F17 File Offset: 0x00685117
		public static void AddIsEnable(FlatBufferBuilder builder, bool isEnable)
		{
			builder.AddBool(1, isEnable, false);
		}

		// Token: 0x0602FF42 RID: 196418 RVA: 0x00686F22 File Offset: 0x00685122
		public static Offset<IEnableAI> EndIEnableAI(FlatBufferBuilder builder)
		{
			return new Offset<IEnableAI>(builder.EndTable());
		}

		// Token: 0x0602FF43 RID: 196419 RVA: 0x00686F30 File Offset: 0x00685130
		public IEnableAIT UnPack()
		{
			IEnableAIT enableAIT = new IEnableAIT();
			this.UnPackTo(enableAIT);
			return enableAIT;
		}

		// Token: 0x0602FF44 RID: 196420 RVA: 0x00686F4C File Offset: 0x0068514C
		public void UnPackTo(IEnableAIT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.IsEnable = this.IsEnable;
		}

		// Token: 0x0602FF45 RID: 196421 RVA: 0x00686F94 File Offset: 0x00685194
		public static Offset<IEnableAI> Pack(FlatBufferBuilder builder, IEnableAIT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableAI>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEnableAI.CreateEntityIdsVector(builder, data);
			}
			return IEnableAI.CreateIEnableAI(builder, entityIdsOffset, _o.IsEnable);
		}

		// Token: 0x04011AF5 RID: 72437
		private Table __p;
	}
}
