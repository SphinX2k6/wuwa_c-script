using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E9 RID: 17897
	public struct ITakePhoto2TargetAnsTagCondition : IFlatbufferObject
	{
		// Token: 0x17007D32 RID: 32050
		// (get) Token: 0x0601A265 RID: 107109 RVA: 0x003B9A1B File Offset: 0x003B7C1B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A266 RID: 107110 RVA: 0x003B9A28 File Offset: 0x003B7C28
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A267 RID: 107111 RVA: 0x003B9A30 File Offset: 0x003B7C30
		public static ITakePhoto2TargetAnsTagCondition GetRootAsITakePhoto2TargetAnsTagCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetAnsTagCondition.GetRootAsITakePhoto2TargetAnsTagCondition(_bb, default(ITakePhoto2TargetAnsTagCondition));
		}

		// Token: 0x0601A268 RID: 107112 RVA: 0x003B9A4C File Offset: 0x003B7C4C
		public static ITakePhoto2TargetAnsTagCondition GetRootAsITakePhoto2TargetAnsTagCondition(ByteBuffer _bb, ITakePhoto2TargetAnsTagCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A269 RID: 107113 RVA: 0x003B9A69 File Offset: 0x003B7C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A26A RID: 107114 RVA: 0x003B9A78 File Offset: 0x003B7C78
		public ITakePhoto2TargetAnsTagCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007D33 RID: 32051
		// (get) Token: 0x0601A26B RID: 107115 RVA: 0x003B9A88 File Offset: 0x003B7C88
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

		// Token: 0x0601A26C RID: 107116 RVA: 0x003B9ABF File Offset: 0x003B7CBF
		public Span<byte> GetMontageTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0601A26D RID: 107117 RVA: 0x003B9ACE File Offset: 0x003B7CCE
		public byte[] GetMontageTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0601A26E RID: 107118 RVA: 0x003B9ADC File Offset: 0x003B7CDC
		public static Offset<ITakePhoto2TargetAnsTagCondition> CreateITakePhoto2TargetAnsTagCondition(FlatBufferBuilder builder, StringOffset MontageTagOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITakePhoto2TargetAnsTagCondition.AddMontageTag(builder, MontageTagOffset);
			return ITakePhoto2TargetAnsTagCondition.EndITakePhoto2TargetAnsTagCondition(builder);
		}

		// Token: 0x0601A26F RID: 107119 RVA: 0x003B9AF2 File Offset: 0x003B7CF2
		public static void StartITakePhoto2TargetAnsTagCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A270 RID: 107120 RVA: 0x003B9AFB File Offset: 0x003B7CFB
		public static void AddMontageTag(FlatBufferBuilder builder, StringOffset montageTagOffset)
		{
			builder.AddOffset(0, montageTagOffset.Value, 0);
		}

		// Token: 0x0601A271 RID: 107121 RVA: 0x003B9B0B File Offset: 0x003B7D0B
		public static Offset<ITakePhoto2TargetAnsTagCondition> EndITakePhoto2TargetAnsTagCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetAnsTagCondition>(builder.EndTable());
		}

		// Token: 0x0601A272 RID: 107122 RVA: 0x003B9B18 File Offset: 0x003B7D18
		public ITakePhoto2TargetAnsTagConditionT UnPack()
		{
			ITakePhoto2TargetAnsTagConditionT takePhoto2TargetAnsTagConditionT = new ITakePhoto2TargetAnsTagConditionT();
			this.UnPackTo(takePhoto2TargetAnsTagConditionT);
			return takePhoto2TargetAnsTagConditionT;
		}

		// Token: 0x0601A273 RID: 107123 RVA: 0x003B9B33 File Offset: 0x003B7D33
		public void UnPackTo(ITakePhoto2TargetAnsTagConditionT _o)
		{
			_o.MontageTag = this.MontageTag;
		}

		// Token: 0x0601A274 RID: 107124 RVA: 0x003B9B44 File Offset: 0x003B7D44
		public static Offset<ITakePhoto2TargetAnsTagCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetAnsTagConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetAnsTagCondition>);
			}
			StringOffset montageTagOffset = (_o.MontageTag == null) ? default(StringOffset) : builder.CreateString(_o.MontageTag);
			return ITakePhoto2TargetAnsTagCondition.CreateITakePhoto2TargetAnsTagCondition(builder, montageTagOffset);
		}

		// Token: 0x0400C7CF RID: 51151
		private Table __p;
	}
}
