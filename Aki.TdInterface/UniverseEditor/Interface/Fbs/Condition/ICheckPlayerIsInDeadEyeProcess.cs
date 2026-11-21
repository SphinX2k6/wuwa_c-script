using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FC8 RID: 20424
	public struct ICheckPlayerIsInDeadEyeProcess : IFlatbufferObject
	{
		// Token: 0x17009216 RID: 37398
		// (get) Token: 0x0601FD7F RID: 130431 RVA: 0x0046C45A File Offset: 0x0046A65A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD80 RID: 130432 RVA: 0x0046C467 File Offset: 0x0046A667
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD81 RID: 130433 RVA: 0x0046C470 File Offset: 0x0046A670
		public static ICheckPlayerIsInDeadEyeProcess GetRootAsICheckPlayerIsInDeadEyeProcess(ByteBuffer _bb)
		{
			return ICheckPlayerIsInDeadEyeProcess.GetRootAsICheckPlayerIsInDeadEyeProcess(_bb, default(ICheckPlayerIsInDeadEyeProcess));
		}

		// Token: 0x0601FD82 RID: 130434 RVA: 0x0046C48C File Offset: 0x0046A68C
		public static ICheckPlayerIsInDeadEyeProcess GetRootAsICheckPlayerIsInDeadEyeProcess(ByteBuffer _bb, ICheckPlayerIsInDeadEyeProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD83 RID: 130435 RVA: 0x0046C4A9 File Offset: 0x0046A6A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD84 RID: 130436 RVA: 0x0046C4B8 File Offset: 0x0046A6B8
		public ICheckPlayerIsInDeadEyeProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009217 RID: 37399
		// (get) Token: 0x0601FD85 RID: 130437 RVA: 0x0046C4C8 File Offset: 0x0046A6C8
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

		// Token: 0x17009218 RID: 37400
		// (get) Token: 0x0601FD86 RID: 130438 RVA: 0x0046C504 File Offset: 0x0046A704
		public bool IsInDeadEyeProcess
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601FD87 RID: 130439 RVA: 0x0046C543 File Offset: 0x0046A743
		public static Offset<ICheckPlayerIsInDeadEyeProcess> CreateICheckPlayerIsInDeadEyeProcess(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsInDeadEyeProcess = false)
		{
			builder.StartTable(2);
			ICheckPlayerIsInDeadEyeProcess.AddIsInDeadEyeProcess(builder, IsInDeadEyeProcess);
			ICheckPlayerIsInDeadEyeProcess.AddType(builder, Type);
			return ICheckPlayerIsInDeadEyeProcess.EndICheckPlayerIsInDeadEyeProcess(builder);
		}

		// Token: 0x0601FD88 RID: 130440 RVA: 0x0046C560 File Offset: 0x0046A760
		public static void StartICheckPlayerIsInDeadEyeProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD89 RID: 130441 RVA: 0x0046C569 File Offset: 0x0046A769
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601FD8A RID: 130442 RVA: 0x0046C574 File Offset: 0x0046A774
		public static void AddIsInDeadEyeProcess(FlatBufferBuilder builder, bool isInDeadEyeProcess)
		{
			builder.AddBool(1, isInDeadEyeProcess, false);
		}

		// Token: 0x0601FD8B RID: 130443 RVA: 0x0046C57F File Offset: 0x0046A77F
		public static Offset<ICheckPlayerIsInDeadEyeProcess> EndICheckPlayerIsInDeadEyeProcess(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerIsInDeadEyeProcess>(builder.EndTable());
		}

		// Token: 0x0601FD8C RID: 130444 RVA: 0x0046C58C File Offset: 0x0046A78C
		public ICheckPlayerIsInDeadEyeProcessT UnPack()
		{
			ICheckPlayerIsInDeadEyeProcessT checkPlayerIsInDeadEyeProcessT = new ICheckPlayerIsInDeadEyeProcessT();
			this.UnPackTo(checkPlayerIsInDeadEyeProcessT);
			return checkPlayerIsInDeadEyeProcessT;
		}

		// Token: 0x0601FD8D RID: 130445 RVA: 0x0046C5A7 File Offset: 0x0046A7A7
		public void UnPackTo(ICheckPlayerIsInDeadEyeProcessT _o)
		{
			_o.Type = this.Type;
			_o.IsInDeadEyeProcess = this.IsInDeadEyeProcess;
		}

		// Token: 0x0601FD8E RID: 130446 RVA: 0x0046C5C4 File Offset: 0x0046A7C4
		public static Offset<ICheckPlayerIsInDeadEyeProcess> Pack(FlatBufferBuilder builder, ICheckPlayerIsInDeadEyeProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerIsInDeadEyeProcess>);
			}
			return ICheckPlayerIsInDeadEyeProcess.CreateICheckPlayerIsInDeadEyeProcess(builder, _o.Type, _o.IsInDeadEyeProcess);
		}

		// Token: 0x0400DE6F RID: 56943
		private Table __p;
	}
}
