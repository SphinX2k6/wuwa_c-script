using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE9 RID: 19177
	public struct IRecordCombatOperationCaptureCheckpoint : IFlatbufferObject
	{
		// Token: 0x1700866B RID: 34411
		// (get) Token: 0x0601CE42 RID: 118338 RVA: 0x004110C4 File Offset: 0x0040F2C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601CE43 RID: 118339 RVA: 0x004110D1 File Offset: 0x0040F2D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601CE44 RID: 118340 RVA: 0x004110D8 File Offset: 0x0040F2D8
		public static IRecordCombatOperationCaptureCheckpoint GetRootAsIRecordCombatOperationCaptureCheckpoint(ByteBuffer _bb)
		{
			return IRecordCombatOperationCaptureCheckpoint.GetRootAsIRecordCombatOperationCaptureCheckpoint(_bb, default(IRecordCombatOperationCaptureCheckpoint));
		}

		// Token: 0x0601CE45 RID: 118341 RVA: 0x004110F4 File Offset: 0x0040F2F4
		public static IRecordCombatOperationCaptureCheckpoint GetRootAsIRecordCombatOperationCaptureCheckpoint(ByteBuffer _bb, IRecordCombatOperationCaptureCheckpoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601CE46 RID: 118342 RVA: 0x00411111 File Offset: 0x0040F311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601CE47 RID: 118343 RVA: 0x00411120 File Offset: 0x0040F320
		public IRecordCombatOperationCaptureCheckpoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700866C RID: 34412
		// (get) Token: 0x0601CE48 RID: 118344 RVA: 0x00411130 File Offset: 0x0040F330
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

		// Token: 0x0601CE49 RID: 118345 RVA: 0x0041116C File Offset: 0x0040F36C
		public static Offset<IRecordCombatOperationCaptureCheckpoint> CreateIRecordCombatOperationCaptureCheckpoint(FlatBufferBuilder builder, EGmCommand Type = EGmCommand.SkipToLevelPlayNode)
		{
			builder.StartTable(1);
			IRecordCombatOperationCaptureCheckpoint.AddType(builder, Type);
			return IRecordCombatOperationCaptureCheckpoint.EndIRecordCombatOperationCaptureCheckpoint(builder);
		}

		// Token: 0x0601CE4A RID: 118346 RVA: 0x00411182 File Offset: 0x0040F382
		public static void StartIRecordCombatOperationCaptureCheckpoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601CE4B RID: 118347 RVA: 0x0041118B File Offset: 0x0040F38B
		public static void AddType(FlatBufferBuilder builder, EGmCommand type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601CE4C RID: 118348 RVA: 0x00411196 File Offset: 0x0040F396
		public static Offset<IRecordCombatOperationCaptureCheckpoint> EndIRecordCombatOperationCaptureCheckpoint(FlatBufferBuilder builder)
		{
			return new Offset<IRecordCombatOperationCaptureCheckpoint>(builder.EndTable());
		}

		// Token: 0x0601CE4D RID: 118349 RVA: 0x004111A4 File Offset: 0x0040F3A4
		public IRecordCombatOperationCaptureCheckpointT UnPack()
		{
			IRecordCombatOperationCaptureCheckpointT recordCombatOperationCaptureCheckpointT = new IRecordCombatOperationCaptureCheckpointT();
			this.UnPackTo(recordCombatOperationCaptureCheckpointT);
			return recordCombatOperationCaptureCheckpointT;
		}

		// Token: 0x0601CE4E RID: 118350 RVA: 0x004111BF File Offset: 0x0040F3BF
		public void UnPackTo(IRecordCombatOperationCaptureCheckpointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601CE4F RID: 118351 RVA: 0x004111D0 File Offset: 0x0040F3D0
		public static Offset<IRecordCombatOperationCaptureCheckpoint> Pack(FlatBufferBuilder builder, IRecordCombatOperationCaptureCheckpointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecordCombatOperationCaptureCheckpoint>);
			}
			return IRecordCombatOperationCaptureCheckpoint.CreateIRecordCombatOperationCaptureCheckpoint(builder, _o.Type);
		}

		// Token: 0x0400D273 RID: 53875
		private Table __p;
	}
}
