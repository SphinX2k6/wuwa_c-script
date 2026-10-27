using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419C RID: 16796
	public struct ITakePhoto2TargetPlayMontageCondition : IFlatbufferObject
	{
		// Token: 0x17007722 RID: 30498
		// (get) Token: 0x06018B7F RID: 101247 RVA: 0x0038F430 File Offset: 0x0038D630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018B80 RID: 101248 RVA: 0x0038F43D File Offset: 0x0038D63D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018B81 RID: 101249 RVA: 0x0038F444 File Offset: 0x0038D644
		public static ITakePhoto2TargetPlayMontageCondition GetRootAsITakePhoto2TargetPlayMontageCondition(ByteBuffer _bb)
		{
			return ITakePhoto2TargetPlayMontageCondition.GetRootAsITakePhoto2TargetPlayMontageCondition(_bb, default(ITakePhoto2TargetPlayMontageCondition));
		}

		// Token: 0x06018B82 RID: 101250 RVA: 0x0038F460 File Offset: 0x0038D660
		public static ITakePhoto2TargetPlayMontageCondition GetRootAsITakePhoto2TargetPlayMontageCondition(ByteBuffer _bb, ITakePhoto2TargetPlayMontageCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018B83 RID: 101251 RVA: 0x0038F47D File Offset: 0x0038D67D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018B84 RID: 101252 RVA: 0x0038F48C File Offset: 0x0038D68C
		public ITakePhoto2TargetPlayMontageCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007723 RID: 30499
		// (get) Token: 0x06018B85 RID: 101253 RVA: 0x0038F49C File Offset: 0x0038D69C
		public string MontagePath
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

		// Token: 0x06018B86 RID: 101254 RVA: 0x0038F4D3 File Offset: 0x0038D6D3
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06018B87 RID: 101255 RVA: 0x0038F4E2 File Offset: 0x0038D6E2
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06018B88 RID: 101256 RVA: 0x0038F4F0 File Offset: 0x0038D6F0
		public static Offset<ITakePhoto2TargetPlayMontageCondition> CreateITakePhoto2TargetPlayMontageCondition(FlatBufferBuilder builder, StringOffset MontagePathOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ITakePhoto2TargetPlayMontageCondition.AddMontagePath(builder, MontagePathOffset);
			return ITakePhoto2TargetPlayMontageCondition.EndITakePhoto2TargetPlayMontageCondition(builder);
		}

		// Token: 0x06018B89 RID: 101257 RVA: 0x0038F506 File Offset: 0x0038D706
		public static void StartITakePhoto2TargetPlayMontageCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018B8A RID: 101258 RVA: 0x0038F50F File Offset: 0x0038D70F
		public static void AddMontagePath(FlatBufferBuilder builder, StringOffset montagePathOffset)
		{
			builder.AddOffset(0, montagePathOffset.Value, 0);
		}

		// Token: 0x06018B8B RID: 101259 RVA: 0x0038F51F File Offset: 0x0038D71F
		public static Offset<ITakePhoto2TargetPlayMontageCondition> EndITakePhoto2TargetPlayMontageCondition(FlatBufferBuilder builder)
		{
			return new Offset<ITakePhoto2TargetPlayMontageCondition>(builder.EndTable());
		}

		// Token: 0x06018B8C RID: 101260 RVA: 0x0038F52C File Offset: 0x0038D72C
		public ITakePhoto2TargetPlayMontageConditionT UnPack()
		{
			ITakePhoto2TargetPlayMontageConditionT takePhoto2TargetPlayMontageConditionT = new ITakePhoto2TargetPlayMontageConditionT();
			this.UnPackTo(takePhoto2TargetPlayMontageConditionT);
			return takePhoto2TargetPlayMontageConditionT;
		}

		// Token: 0x06018B8D RID: 101261 RVA: 0x0038F547 File Offset: 0x0038D747
		public void UnPackTo(ITakePhoto2TargetPlayMontageConditionT _o)
		{
			_o.MontagePath = this.MontagePath;
		}

		// Token: 0x06018B8E RID: 101262 RVA: 0x0038F558 File Offset: 0x0038D758
		public static Offset<ITakePhoto2TargetPlayMontageCondition> Pack(FlatBufferBuilder builder, ITakePhoto2TargetPlayMontageConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITakePhoto2TargetPlayMontageCondition>);
			}
			StringOffset montagePathOffset = (_o.MontagePath == null) ? default(StringOffset) : builder.CreateString(_o.MontagePath);
			return ITakePhoto2TargetPlayMontageCondition.CreateITakePhoto2TargetPlayMontageCondition(builder, montagePathOffset);
		}

		// Token: 0x0400BDD5 RID: 48597
		private Table __p;
	}
}
