using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B36 RID: 27446
	public struct IMotorSoarInWindFieldControlType : IFlatbufferObject
	{
		// Token: 0x1700CBEF RID: 52207
		// (get) Token: 0x060302BF RID: 197311 RVA: 0x0068C155 File Offset: 0x0068A355
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060302C0 RID: 197312 RVA: 0x0068C162 File Offset: 0x0068A362
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060302C1 RID: 197313 RVA: 0x0068C16C File Offset: 0x0068A36C
		public static IMotorSoarInWindFieldControlType GetRootAsIMotorSoarInWindFieldControlType(ByteBuffer _bb)
		{
			return IMotorSoarInWindFieldControlType.GetRootAsIMotorSoarInWindFieldControlType(_bb, default(IMotorSoarInWindFieldControlType));
		}

		// Token: 0x060302C2 RID: 197314 RVA: 0x0068C188 File Offset: 0x0068A388
		public static IMotorSoarInWindFieldControlType GetRootAsIMotorSoarInWindFieldControlType(ByteBuffer _bb, IMotorSoarInWindFieldControlType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060302C3 RID: 197315 RVA: 0x0068C1A5 File Offset: 0x0068A3A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060302C4 RID: 197316 RVA: 0x0068C1B4 File Offset: 0x0068A3B4
		public IMotorSoarInWindFieldControlType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBF0 RID: 52208
		// (get) Token: 0x060302C5 RID: 197317 RVA: 0x0068C1C4 File Offset: 0x0068A3C4
		public EMotorSoarInWindFieldControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorSoarInWindFieldControlType.EnterWindField;
				}
				return (EMotorSoarInWindFieldControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060302C6 RID: 197318 RVA: 0x0068C200 File Offset: 0x0068A400
		public static Offset<IMotorSoarInWindFieldControlType> CreateIMotorSoarInWindFieldControlType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType Type = EMotorSoarInWindFieldControlType.EnterWindField)
		{
			builder.StartTable(1);
			IMotorSoarInWindFieldControlType.AddType(builder, Type);
			return IMotorSoarInWindFieldControlType.EndIMotorSoarInWindFieldControlType(builder);
		}

		// Token: 0x060302C7 RID: 197319 RVA: 0x0068C216 File Offset: 0x0068A416
		public static void StartIMotorSoarInWindFieldControlType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060302C8 RID: 197320 RVA: 0x0068C21F File Offset: 0x0068A41F
		public static void AddType(FlatBufferBuilder builder, EMotorSoarInWindFieldControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060302C9 RID: 197321 RVA: 0x0068C22A File Offset: 0x0068A42A
		public static Offset<IMotorSoarInWindFieldControlType> EndIMotorSoarInWindFieldControlType(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSoarInWindFieldControlType>(builder.EndTable());
		}

		// Token: 0x060302CA RID: 197322 RVA: 0x0068C238 File Offset: 0x0068A438
		public IMotorSoarInWindFieldControlTypeT UnPack()
		{
			IMotorSoarInWindFieldControlTypeT motorSoarInWindFieldControlTypeT = new IMotorSoarInWindFieldControlTypeT();
			this.UnPackTo(motorSoarInWindFieldControlTypeT);
			return motorSoarInWindFieldControlTypeT;
		}

		// Token: 0x060302CB RID: 197323 RVA: 0x0068C253 File Offset: 0x0068A453
		public void UnPackTo(IMotorSoarInWindFieldControlTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060302CC RID: 197324 RVA: 0x0068C264 File Offset: 0x0068A464
		public static Offset<IMotorSoarInWindFieldControlType> Pack(FlatBufferBuilder builder, IMotorSoarInWindFieldControlTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSoarInWindFieldControlType>);
			}
			return IMotorSoarInWindFieldControlType.CreateIMotorSoarInWindFieldControlType(builder, _o.Type);
		}

		// Token: 0x040113CD RID: 70605
		private Table __p;
	}
}
