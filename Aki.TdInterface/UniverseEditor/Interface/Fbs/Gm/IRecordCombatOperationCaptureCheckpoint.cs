using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004681 RID: 18049
	public struct IRecordCombatOperationCaptureCheckpoint : IFlatbufferObject
	{
		// Token: 0x1700802A RID: 32810
		// (get) Token: 0x0601B66D RID: 112237 RVA: 0x003E4E28 File Offset: 0x003E3028
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B66E RID: 112238 RVA: 0x003E4E35 File Offset: 0x003E3035
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B66F RID: 112239 RVA: 0x003E4E3C File Offset: 0x003E303C
		public static IRecordCombatOperationCaptureCheckpoint GetRootAsIRecordCombatOperationCaptureCheckpoint(ByteBuffer _bb)
		{
			return IRecordCombatOperationCaptureCheckpoint.GetRootAsIRecordCombatOperationCaptureCheckpoint(_bb, default(IRecordCombatOperationCaptureCheckpoint));
		}

		// Token: 0x0601B670 RID: 112240 RVA: 0x003E4E58 File Offset: 0x003E3058
		public static IRecordCombatOperationCaptureCheckpoint GetRootAsIRecordCombatOperationCaptureCheckpoint(ByteBuffer _bb, IRecordCombatOperationCaptureCheckpoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B671 RID: 112241 RVA: 0x003E4E75 File Offset: 0x003E3075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B672 RID: 112242 RVA: 0x003E4E84 File Offset: 0x003E3084
		public IRecordCombatOperationCaptureCheckpoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700802B RID: 32811
		// (get) Token: 0x0601B673 RID: 112243 RVA: 0x003E4E94 File Offset: 0x003E3094
		public EGmCommand Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGmCommand.SkipToLevelPlayNode;
				}
				return (EGmCommand)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601B674 RID: 112244 RVA: 0x003E4ED0 File Offset: 0x003E30D0
		public static Offset<IRecordCombatOperationCaptureCheckpoint> CreateIRecordCombatOperationCaptureCheckpoint(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IRecordCombatOperationCaptureCheckpoint.AddType(builder, Type);
			return IRecordCombatOperationCaptureCheckpoint.EndIRecordCombatOperationCaptureCheckpoint(builder);
		}

		// Token: 0x0601B675 RID: 112245 RVA: 0x003E4EE6 File Offset: 0x003E30E6
		public static void StartIRecordCombatOperationCaptureCheckpoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601B676 RID: 112246 RVA: 0x003E4EEF File Offset: 0x003E30EF
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B677 RID: 112247 RVA: 0x003E4EFA File Offset: 0x003E30FA
		public static Offset<IRecordCombatOperationCaptureCheckpoint> EndIRecordCombatOperationCaptureCheckpoint(FlatBufferBuilder builder)
		{
			return new Offset<IRecordCombatOperationCaptureCheckpoint>(builder.EndTable());
		}

		// Token: 0x0601B678 RID: 112248 RVA: 0x003E4F08 File Offset: 0x003E3108
		public IRecordCombatOperationCaptureCheckpointT UnPack()
		{
			IRecordCombatOperationCaptureCheckpointT recordCombatOperationCaptureCheckpointT = new IRecordCombatOperationCaptureCheckpointT();
			this.UnPackTo(recordCombatOperationCaptureCheckpointT);
			return recordCombatOperationCaptureCheckpointT;
		}

		// Token: 0x0601B679 RID: 112249 RVA: 0x003E4F23 File Offset: 0x003E3123
		public void UnPackTo(IRecordCombatOperationCaptureCheckpointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601B67A RID: 112250 RVA: 0x003E4F34 File Offset: 0x003E3134
		public static Offset<IRecordCombatOperationCaptureCheckpoint> Pack(FlatBufferBuilder builder, IRecordCombatOperationCaptureCheckpointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecordCombatOperationCaptureCheckpoint>);
			}
			return IRecordCombatOperationCaptureCheckpoint.CreateIRecordCombatOperationCaptureCheckpoint(builder, _o.Type);
		}

		// Token: 0x0400C844 RID: 51268
		private Table __p;
	}
}
