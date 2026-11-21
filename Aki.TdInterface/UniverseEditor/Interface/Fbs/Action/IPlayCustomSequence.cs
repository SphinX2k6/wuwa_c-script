using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200744E RID: 29774
	public struct IPlayCustomSequence : IFlatbufferObject
	{
		// Token: 0x1700DAC0 RID: 56000
		// (get) Token: 0x060341C5 RID: 213445 RVA: 0x0070585F File Offset: 0x00703A5F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060341C6 RID: 213446 RVA: 0x0070586C File Offset: 0x00703A6C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060341C7 RID: 213447 RVA: 0x00705874 File Offset: 0x00703A74
		public static IPlayCustomSequence GetRootAsIPlayCustomSequence(ByteBuffer _bb)
		{
			return IPlayCustomSequence.GetRootAsIPlayCustomSequence(_bb, default(IPlayCustomSequence));
		}

		// Token: 0x060341C8 RID: 213448 RVA: 0x00705890 File Offset: 0x00703A90
		public static IPlayCustomSequence GetRootAsIPlayCustomSequence(ByteBuffer _bb, IPlayCustomSequence obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060341C9 RID: 213449 RVA: 0x007058AD File Offset: 0x00703AAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060341CA RID: 213450 RVA: 0x007058BC File Offset: 0x00703ABC
		public IPlayCustomSequence __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DAC1 RID: 56001
		// (get) Token: 0x060341CB RID: 213451 RVA: 0x007058CC File Offset: 0x00703ACC
		public int CustomSeqId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060341CC RID: 213452 RVA: 0x00705908 File Offset: 0x00703B08
		public int WhoIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700DAC2 RID: 56002
		// (get) Token: 0x060341CD RID: 213453 RVA: 0x00705948 File Offset: 0x00703B48
		public int WhoIdsLength
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

		// Token: 0x060341CE RID: 213454 RVA: 0x00705973 File Offset: 0x00703B73
		public Span<int> GetWhoIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060341CF RID: 213455 RVA: 0x00705982 File Offset: 0x00703B82
		public int[] GetWhoIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700DAC3 RID: 56003
		// (get) Token: 0x060341D0 RID: 213456 RVA: 0x00705990 File Offset: 0x00703B90
		public bool ResetCamera
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DAC4 RID: 56004
		// (get) Token: 0x060341D1 RID: 213457 RVA: 0x007059D0 File Offset: 0x00703BD0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060341D2 RID: 213458 RVA: 0x00705A0D File Offset: 0x00703C0D
		public static Offset<IPlayCustomSequence> CreateIPlayCustomSequence(FlatBufferBuilder builder, int CustomSeqId = 0, VectorOffset WhoIdsOffset = default(VectorOffset), bool ResetCamera = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPlayCustomSequence.AddWhoIds(builder, WhoIdsOffset);
			IPlayCustomSequence.AddCustomSeqId(builder, CustomSeqId);
			IPlayCustomSequence.AddNullMask(builder, NullMask);
			IPlayCustomSequence.AddResetCamera(builder, ResetCamera);
			return IPlayCustomSequence.EndIPlayCustomSequence(builder);
		}

		// Token: 0x060341D3 RID: 213459 RVA: 0x00705A39 File Offset: 0x00703C39
		public static void StartIPlayCustomSequence(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060341D4 RID: 213460 RVA: 0x00705A42 File Offset: 0x00703C42
		public static void AddCustomSeqId(FlatBufferBuilder builder, int customSeqId)
		{
			builder.AddInt(0, customSeqId, 0);
		}

		// Token: 0x060341D5 RID: 213461 RVA: 0x00705A4D File Offset: 0x00703C4D
		public static void AddWhoIds(FlatBufferBuilder builder, VectorOffset whoIdsOffset)
		{
			builder.AddOffset(1, whoIdsOffset.Value, 0);
		}

		// Token: 0x060341D6 RID: 213462 RVA: 0x00705A60 File Offset: 0x00703C60
		public static VectorOffset CreateWhoIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060341D7 RID: 213463 RVA: 0x00705A97 File Offset: 0x00703C97
		public static VectorOffset CreateWhoIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060341D8 RID: 213464 RVA: 0x00705AB1 File Offset: 0x00703CB1
		public static VectorOffset CreateWhoIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060341D9 RID: 213465 RVA: 0x00705ACF File Offset: 0x00703CCF
		public static VectorOffset CreateWhoIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060341DA RID: 213466 RVA: 0x00705AE8 File Offset: 0x00703CE8
		public static void StartWhoIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060341DB RID: 213467 RVA: 0x00705AF3 File Offset: 0x00703CF3
		public static void AddResetCamera(FlatBufferBuilder builder, bool resetCamera)
		{
			builder.AddBool(2, resetCamera, false);
		}

		// Token: 0x060341DC RID: 213468 RVA: 0x00705AFE File Offset: 0x00703CFE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060341DD RID: 213469 RVA: 0x00705B09 File Offset: 0x00703D09
		public static Offset<IPlayCustomSequence> EndIPlayCustomSequence(FlatBufferBuilder builder)
		{
			return new Offset<IPlayCustomSequence>(builder.EndTable());
		}

		// Token: 0x060341DE RID: 213470 RVA: 0x00705B18 File Offset: 0x00703D18
		public IPlayCustomSequenceT UnPack()
		{
			IPlayCustomSequenceT playCustomSequenceT = new IPlayCustomSequenceT();
			this.UnPackTo(playCustomSequenceT);
			return playCustomSequenceT;
		}

		// Token: 0x060341DF RID: 213471 RVA: 0x00705B34 File Offset: 0x00703D34
		public void UnPackTo(IPlayCustomSequenceT _o)
		{
			_o.CustomSeqId = this.CustomSeqId;
			_o.WhoIds = new List<int>();
			for (int i = 0; i < this.WhoIdsLength; i++)
			{
				_o.WhoIds.Add(this.WhoIds(i));
			}
			_o.ResetCamera = this.ResetCamera;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060341E0 RID: 213472 RVA: 0x00705B94 File Offset: 0x00703D94
		public static Offset<IPlayCustomSequence> Pack(FlatBufferBuilder builder, IPlayCustomSequenceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayCustomSequence>);
			}
			VectorOffset whoIdsOffset = default(VectorOffset);
			if (_o.WhoIds != null)
			{
				int[] data = _o.WhoIds.ToArray();
				whoIdsOffset = IPlayCustomSequence.CreateWhoIdsVector(builder, data);
			}
			return IPlayCustomSequence.CreateIPlayCustomSequence(builder, _o.CustomSeqId, whoIdsOffset, _o.ResetCamera, _o.NullMask);
		}

		// Token: 0x040125B8 RID: 75192
		private Table __p;
	}
}
