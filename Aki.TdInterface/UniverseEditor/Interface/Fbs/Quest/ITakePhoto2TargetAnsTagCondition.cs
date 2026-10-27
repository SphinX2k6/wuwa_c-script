using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004190 RID: 16784
	public struct ITakePhoto2TargetAnsTagCondition : IFlatbufferObject
	{
		// Token: 0x17007706 RID: 30470
		// (get) Token: 0x06018B0F RID: 101135 RVA: 0x0038E5C7 File Offset: 0x0038C7C7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B10 RID: 101136 RVA: 0x0038E5D4 File Offset: 0x0038C7D4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B11 RID: 101137 RVA: 0x0038E5DC File Offset: 0x0038C7DC
		public static ITakePhoto2TargetAnsTagCondition GetRootAsITakePhoto2TargetAnsTagCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetAnsTagCondition.GetRootAsITakePhoto2TargetAnsTagCondition(_bb, default(ITakePhoto2TargetAnsTagCondition));
		}

		// Token: 0x06018B12 RID: 101138 RVA: 0x0038E5F8 File Offset: 0x0038C7F8
		public static ITakePhoto2TargetAnsTagCondition GetRootAsITakePhoto2TargetAnsTagCondition(ByteBuffer _bb, ITakePhoto2TargetAnsTagCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B13 RID: 101139 RVA: 0x0038E615 File Offset: 0x0038C815
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B14 RID: 101140 RVA: 0x0038E624 File Offset: 0x0038C824
		public ITakePhoto2TargetAnsTagCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007707 RID: 30471
		// (get) Token: 0x06018B15 RID: 101141 RVA: 0x0038E634 File Offset: 0x0038C834
		public string MontageTag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018B16 RID: 101142 RVA: 0x0038E66B File Offset: 0x0038C86B
		public Span<byte> GetMontageTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018B17 RID: 101143 RVA: 0x0038E67A File Offset: 0x0038C87A
		public byte[] GetMontageTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06018B18 RID: 101144 RVA: 0x0038E688 File Offset: 0x0038C888
		public static Offset<ITakePhoto2TargetAnsTagCondition> CreateITakePhoto2TargetAnsTagCondition(FlatBufferBuilder builder, StringOffset MontageTagOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITakePhoto2TargetAnsTagCondition.AddMontageTag(builder, MontageTagOffset);
			return ITakePhoto2TargetAnsTagCondition.EndITakePhoto2TargetAnsTagCondition(builder);
		}

		// Token: 0x06018B19 RID: 101145 RVA: 0x0038E69E File Offset: 0x0038C89E
		public static void StartITakePhoto2TargetAnsTagCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018B1A RID: 101146 RVA: 0x0038E6A7 File Offset: 0x0038C8A7
		public static void AddMontageTag(FlatBufferBuilder builder, StringOffset montageTagOffset)
		{
			builder.AddOffset(0, montageTagOffset.Value, 0);
		}

		// Token: 0x06018B1B RID: 101147 RVA: 0x0038E6B7 File Offset: 0x0038C8B7
		public static Offset<ITakePhoto2TargetAnsTagCondition> EndITakePhoto2TargetAnsTagCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetAnsTagCondition>(builder.EndTable());
		}

		// Token: 0x06018B1C RID: 101148 RVA: 0x0038E6C4 File Offset: 0x0038C8C4
		public ITakePhoto2TargetAnsTagConditionT UnPack()
		{
			ITakePhoto2TargetAnsTagConditionT takePhoto2TargetAnsTagConditionT = new ITakePhoto2TargetAnsTagConditionT();
			this.UnPackTo(takePhoto2TargetAnsTagConditionT);
			return takePhoto2TargetAnsTagConditionT;
		}

		// Token: 0x06018B1D RID: 101149 RVA: 0x0038E6DF File Offset: 0x0038C8DF
		public void UnPackTo(ITakePhoto2TargetAnsTagConditionT _o)
		{
			_o.MontageTag = this.MontageTag;
		}

		// Token: 0x06018B1E RID: 101150 RVA: 0x0038E6F0 File Offset: 0x0038C8F0
		public static Offset<ITakePhoto2TargetAnsTagCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetAnsTagConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetAnsTagCondition>);
			}
			StringOffset montageTagOffset = (_o.MontageTag == null) ? default(StringOffset) : builder.CreateString(_o.MontageTag);
			return ITakePhoto2TargetAnsTagCondition.CreateITakePhoto2TargetAnsTagCondition(builder, montageTagOffset);
		}

		// Token: 0x0400BDC5 RID: 48581
		private Table __p;
	}
}
