using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EA5 RID: 20133
	public struct ICheckElementalWaterBoxStagnationSeq : IFlatbufferObject
	{
		// Token: 0x17008F9E RID: 36766
		// (get) Token: 0x0601F343 RID: 127811 RVA: 0x00459C2E File Offset: 0x00457E2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F344 RID: 127812 RVA: 0x00459C3B File Offset: 0x00457E3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F345 RID: 127813 RVA: 0x00459C44 File Offset: 0x00457E44
		public static ICheckElementalWaterBoxStagnationSeq GetRootAsICheckElementalWaterBoxStagnationSeq(ByteBuffer _bb)
		{
			return ICheckElementalWaterBoxStagnationSeq.GetRootAsICheckElementalWaterBoxStagnationSeq(_bb, default(ICheckElementalWaterBoxStagnationSeq));
		}

		// Token: 0x0601F346 RID: 127814 RVA: 0x00459C60 File Offset: 0x00457E60
		public static ICheckElementalWaterBoxStagnationSeq GetRootAsICheckElementalWaterBoxStagnationSeq(ByteBuffer _bb, ICheckElementalWaterBoxStagnationSeq obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F347 RID: 127815 RVA: 0x00459C7D File Offset: 0x00457E7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F348 RID: 127816 RVA: 0x00459C8C File Offset: 0x00457E8C
		public ICheckElementalWaterBoxStagnationSeq __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F9F RID: 36767
		// (get) Token: 0x0601F349 RID: 127817 RVA: 0x00459C9C File Offset: 0x00457E9C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FA0 RID: 36768
		// (get) Token: 0x0601F34A RID: 127818 RVA: 0x00459CD8 File Offset: 0x00457ED8
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008FA1 RID: 36769
		// (get) Token: 0x0601F34B RID: 127819 RVA: 0x00459D14 File Offset: 0x00457F14
		public string StartMark
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F34C RID: 127820 RVA: 0x00459D4B File Offset: 0x00457F4B
		public Span<byte> GetStartMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0601F34D RID: 127821 RVA: 0x00459D5A File Offset: 0x00457F5A
		public byte[] GetStartMarkArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17008FA2 RID: 36770
		// (get) Token: 0x0601F34E RID: 127822 RVA: 0x00459D68 File Offset: 0x00457F68
		public string EndMark
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601F34F RID: 127823 RVA: 0x00459DA0 File Offset: 0x00457FA0
		public Span<byte> GetEndMarkBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0601F350 RID: 127824 RVA: 0x00459DB0 File Offset: 0x00457FB0
		public byte[] GetEndMarkArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x0601F351 RID: 127825 RVA: 0x00459DBF File Offset: 0x00457FBF
		public static Offset<ICheckElementalWaterBoxStagnationSeq> CreateICheckElementalWaterBoxStagnationSeq(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int EntityId = 0, StringOffset StartMarkOffset = default(StringOffset), StringOffset EndMarkOffset = default(StringOffset))
		{
			builder.StartTable(4);
			ICheckElementalWaterBoxStagnationSeq.AddEndMark(builder, EndMarkOffset);
			ICheckElementalWaterBoxStagnationSeq.AddStartMark(builder, StartMarkOffset);
			ICheckElementalWaterBoxStagnationSeq.AddEntityId(builder, EntityId);
			ICheckElementalWaterBoxStagnationSeq.AddType(builder, Type);
			return ICheckElementalWaterBoxStagnationSeq.EndICheckElementalWaterBoxStagnationSeq(builder);
		}

		// Token: 0x0601F352 RID: 127826 RVA: 0x00459DEB File Offset: 0x00457FEB
		public static void StartICheckElementalWaterBoxStagnationSeq(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601F353 RID: 127827 RVA: 0x00459DF4 File Offset: 0x00457FF4
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F354 RID: 127828 RVA: 0x00459DFF File Offset: 0x00457FFF
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x0601F355 RID: 127829 RVA: 0x00459E0A File Offset: 0x0045800A
		public static void AddStartMark(FlatBufferBuilder builder, StringOffset startMarkOffset)
		{
			builder.AddOffset(2, startMarkOffset.Value, 0);
		}

		// Token: 0x0601F356 RID: 127830 RVA: 0x00459E1A File Offset: 0x0045801A
		public static void AddEndMark(FlatBufferBuilder builder, StringOffset endMarkOffset)
		{
			builder.AddOffset(3, endMarkOffset.Value, 0);
		}

		// Token: 0x0601F357 RID: 127831 RVA: 0x00459E2A File Offset: 0x0045802A
		public static Offset<ICheckElementalWaterBoxStagnationSeq> EndICheckElementalWaterBoxStagnationSeq(FlatBufferBuilder builder)
		{
			return new Offset<ICheckElementalWaterBoxStagnationSeq>(builder.EndTable());
		}

		// Token: 0x0601F358 RID: 127832 RVA: 0x00459E38 File Offset: 0x00458038
		public ICheckElementalWaterBoxStagnationSeqT UnPack()
		{
			ICheckElementalWaterBoxStagnationSeqT checkElementalWaterBoxStagnationSeqT = new ICheckElementalWaterBoxStagnationSeqT();
			this.UnPackTo(checkElementalWaterBoxStagnationSeqT);
			return checkElementalWaterBoxStagnationSeqT;
		}

		// Token: 0x0601F359 RID: 127833 RVA: 0x00459E53 File Offset: 0x00458053
		public void UnPackTo(ICheckElementalWaterBoxStagnationSeqT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.StartMark = this.StartMark;
			_o.EndMark = this.EndMark;
		}

		// Token: 0x0601F35A RID: 127834 RVA: 0x00459E88 File Offset: 0x00458088
		public static Offset<ICheckElementalWaterBoxStagnationSeq> Pack(FlatBufferBuilder builder, ICheckElementalWaterBoxStagnationSeqT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckElementalWaterBoxStagnationSeq>);
			}
			StringOffset startMarkOffset = (_o.StartMark == null) ? default(StringOffset) : builder.CreateString(_o.StartMark);
			StringOffset endMarkOffset = (_o.EndMark == null) ? default(StringOffset) : builder.CreateString(_o.EndMark);
			return ICheckElementalWaterBoxStagnationSeq.CreateICheckElementalWaterBoxStagnationSeq(builder, _o.Type, _o.EntityId, startMarkOffset, endMarkOffset);
		}

		// Token: 0x0400DCE9 RID: 56553
		private Table __p;
	}
}
