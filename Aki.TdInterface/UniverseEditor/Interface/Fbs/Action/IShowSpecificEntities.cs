using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070E8 RID: 28904
	public struct IShowSpecificEntities : IFlatbufferObject
	{
		// Token: 0x1700D6C9 RID: 54985
		// (get) Token: 0x0603335B RID: 209755 RVA: 0x006E72F4 File Offset: 0x006E54F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603335C RID: 209756 RVA: 0x006E7301 File Offset: 0x006E5501
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603335D RID: 209757 RVA: 0x006E7308 File Offset: 0x006E5508
		public static IShowSpecificEntities GetRootAsIShowSpecificEntities(ByteBuffer _bb)
		{
			return IShowSpecificEntities.GetRootAsIShowSpecificEntities(_bb, default(IShowSpecificEntities));
		}

		// Token: 0x0603335E RID: 209758 RVA: 0x006E7324 File Offset: 0x006E5524
		public static IShowSpecificEntities GetRootAsIShowSpecificEntities(ByteBuffer _bb, IShowSpecificEntities obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603335F RID: 209759 RVA: 0x006E7341 File Offset: 0x006E5541
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033360 RID: 209760 RVA: 0x006E7350 File Offset: 0x006E5550
		public IShowSpecificEntities __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06033361 RID: 209761 RVA: 0x006E7360 File Offset: 0x006E5560
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D6CA RID: 54986
		// (get) Token: 0x06033362 RID: 209762 RVA: 0x006E73A0 File Offset: 0x006E55A0
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

		// Token: 0x06033363 RID: 209763 RVA: 0x006E73CB File Offset: 0x006E55CB
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(4, 4);
		}

		// Token: 0x06033364 RID: 209764 RVA: 0x006E73DA File Offset: 0x006E55DA
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(4);
		}

		// Token: 0x1700D6CB RID: 54987
		// (get) Token: 0x06033365 RID: 209765 RVA: 0x006E73E8 File Offset: 0x006E55E8
		public bool DelayShow
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06033366 RID: 209766 RVA: 0x006E7427 File Offset: 0x006E5627
		public static Offset<IShowSpecificEntities> CreateIShowSpecificEntities(FlatBufferBuilder builder, VectorOffset EntityIdsOffset = default(VectorOffset), bool DelayShow = false)
		{
			builder.StartTable(2);
			IShowSpecificEntities.AddEntityIds(builder, EntityIdsOffset);
			IShowSpecificEntities.AddDelayShow(builder, DelayShow);
			return IShowSpecificEntities.EndIShowSpecificEntities(builder);
		}

		// Token: 0x06033367 RID: 209767 RVA: 0x006E7444 File Offset: 0x006E5644
		public static void StartIShowSpecificEntities(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033368 RID: 209768 RVA: 0x006E744D File Offset: 0x006E564D
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(0, entityIdsOffset.Value, 0);
		}

		// Token: 0x06033369 RID: 209769 RVA: 0x006E7460 File Offset: 0x006E5660
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603336A RID: 209770 RVA: 0x006E7497 File Offset: 0x006E5697
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603336B RID: 209771 RVA: 0x006E74B1 File Offset: 0x006E56B1
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603336C RID: 209772 RVA: 0x006E74CF File Offset: 0x006E56CF
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603336D RID: 209773 RVA: 0x006E74E8 File Offset: 0x006E56E8
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603336E RID: 209774 RVA: 0x006E74F3 File Offset: 0x006E56F3
		public static void AddDelayShow(FlatBufferBuilder builder, bool delayShow)
		{
			builder.AddBool(1, delayShow, false);
		}

		// Token: 0x0603336F RID: 209775 RVA: 0x006E74FE File Offset: 0x006E56FE
		public static Offset<IShowSpecificEntities> EndIShowSpecificEntities(FlatBufferBuilder builder)
		{
			return new Offset<IShowSpecificEntities>(builder.EndTable());
		}

		// Token: 0x06033370 RID: 209776 RVA: 0x006E750C File Offset: 0x006E570C
		public IShowSpecificEntitiesT UnPack()
		{
			IShowSpecificEntitiesT showSpecificEntitiesT = new IShowSpecificEntitiesT();
			this.UnPackTo(showSpecificEntitiesT);
			return showSpecificEntitiesT;
		}

		// Token: 0x06033371 RID: 209777 RVA: 0x006E7528 File Offset: 0x006E5728
		public void UnPackTo(IShowSpecificEntitiesT _o)
		{
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
			_o.DelayShow = this.DelayShow;
		}

		// Token: 0x06033372 RID: 209778 RVA: 0x006E7570 File Offset: 0x006E5770
		public static Offset<IShowSpecificEntities> Pack(FlatBufferBuilder builder, IShowSpecificEntitiesT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowSpecificEntities>);
			}
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IShowSpecificEntities.CreateEntityIdsVector(builder, data);
			}
			return IShowSpecificEntities.CreateIShowSpecificEntities(builder, entityIdsOffset, _o.DelayShow);
		}

		// Token: 0x04011B64 RID: 72548
		private Table __p;
	}
}
