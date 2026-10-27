using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AED RID: 19181
	public struct ICheckPlayerIsInDeadEyeProcess : IFlatbufferObject
	{
		// Token: 0x17008B15 RID: 35605
		// (get) Token: 0x0601E23E RID: 123454 RVA: 0x0043A3AE File Offset: 0x004385AE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E23F RID: 123455 RVA: 0x0043A3BB File Offset: 0x004385BB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E240 RID: 123456 RVA: 0x0043A3C4 File Offset: 0x004385C4
		public static ICheckPlayerIsInDeadEyeProcess GetRootAsICheckPlayerIsInDeadEyeProcess(ByteBuffer _bb)
		{
			return ICheckPlayerIsInDeadEyeProcess.GetRootAsICheckPlayerIsInDeadEyeProcess(_bb, default(ICheckPlayerIsInDeadEyeProcess));
		}

		// Token: 0x0601E241 RID: 123457 RVA: 0x0043A3E0 File Offset: 0x004385E0
		public static ICheckPlayerIsInDeadEyeProcess GetRootAsICheckPlayerIsInDeadEyeProcess(ByteBuffer _bb, ICheckPlayerIsInDeadEyeProcess obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E242 RID: 123458 RVA: 0x0043A3FD File Offset: 0x004385FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E243 RID: 123459 RVA: 0x0043A40C File Offset: 0x0043860C
		public ICheckPlayerIsInDeadEyeProcess __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008B16 RID: 35606
		// (get) Token: 0x0601E244 RID: 123460 RVA: 0x0043A41C File Offset: 0x0043861C
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

		// Token: 0x17008B17 RID: 35607
		// (get) Token: 0x0601E245 RID: 123461 RVA: 0x0043A458 File Offset: 0x00438658
		public bool IsInDeadEyeProcess
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601E246 RID: 123462 RVA: 0x0043A497 File Offset: 0x00438697
		public static Offset<ICheckPlayerIsInDeadEyeProcess> CreateICheckPlayerIsInDeadEyeProcess(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool IsInDeadEyeProcess = false)
		{
			builder.StartTable(2);
			ICheckPlayerIsInDeadEyeProcess.AddIsInDeadEyeProcess(builder, IsInDeadEyeProcess);
			ICheckPlayerIsInDeadEyeProcess.AddType(builder, Type);
			return ICheckPlayerIsInDeadEyeProcess.EndICheckPlayerIsInDeadEyeProcess(builder);
		}

		// Token: 0x0601E247 RID: 123463 RVA: 0x0043A4B4 File Offset: 0x004386B4
		public static void StartICheckPlayerIsInDeadEyeProcess(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601E248 RID: 123464 RVA: 0x0043A4BD File Offset: 0x004386BD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E249 RID: 123465 RVA: 0x0043A4C8 File Offset: 0x004386C8
		public static void AddIsInDeadEyeProcess(FlatBufferBuilder builder, bool isInDeadEyeProcess)
		{
			builder.AddBool(1, isInDeadEyeProcess, false);
		}

		// Token: 0x0601E24A RID: 123466 RVA: 0x0043A4D3 File Offset: 0x004386D3
		public static Offset<ICheckPlayerIsInDeadEyeProcess> EndICheckPlayerIsInDeadEyeProcess(FlatBufferBuilder builder)
		{
			return new Offset<ICheckPlayerIsInDeadEyeProcess>(builder.EndTable());
		}

		// Token: 0x0601E24B RID: 123467 RVA: 0x0043A4E0 File Offset: 0x004386E0
		public ICheckPlayerIsInDeadEyeProcessT UnPack()
		{
			ICheckPlayerIsInDeadEyeProcessT checkPlayerIsInDeadEyeProcessT = new ICheckPlayerIsInDeadEyeProcessT();
			this.UnPackTo(checkPlayerIsInDeadEyeProcessT);
			return checkPlayerIsInDeadEyeProcessT;
		}

		// Token: 0x0601E24C RID: 123468 RVA: 0x0043A4FB File Offset: 0x004386FB
		public void UnPackTo(ICheckPlayerIsInDeadEyeProcessT _o)
		{
			_o.Type = this.Type;
			_o.IsInDeadEyeProcess = this.IsInDeadEyeProcess;
		}

		// Token: 0x0601E24D RID: 123469 RVA: 0x0043A518 File Offset: 0x00438718
		public static Offset<ICheckPlayerIsInDeadEyeProcess> Pack(FlatBufferBuilder builder, ICheckPlayerIsInDeadEyeProcessT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckPlayerIsInDeadEyeProcess>);
			}
			return ICheckPlayerIsInDeadEyeProcess.CreateICheckPlayerIsInDeadEyeProcess(builder, _o.Type, _o.IsInDeadEyeProcess);
		}

		// Token: 0x0400D37E RID: 54142
		private Table __p;
	}
}
