using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004130 RID: 16688
	public struct IAtomicProcessBase : IFlatbufferObject
	{
		// Token: 0x17007108 RID: 28936
		// (get) Token: 0x06016E8D RID: 93837 RVA: 0x003451E6 File Offset: 0x003433E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016E8E RID: 93838 RVA: 0x003451F3 File Offset: 0x003433F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016E8F RID: 93839 RVA: 0x003451FC File Offset: 0x003433FC
		public static IAtomicProcessBase GetRootAsIAtomicProcessBase(ByteBuffer _bb)
		{
			return IAtomicProcessBase.GetRootAsIAtomicProcessBase(_bb, default(IAtomicProcessBase));
		}

		// Token: 0x06016E90 RID: 93840 RVA: 0x00345218 File Offset: 0x00343418
		public static IAtomicProcessBase GetRootAsIAtomicProcessBase(ByteBuffer _bb, IAtomicProcessBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016E91 RID: 93841 RVA: 0x00345235 File Offset: 0x00343435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016E92 RID: 93842 RVA: 0x00345244 File Offset: 0x00343444
		public IAtomicProcessBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007109 RID: 28937
		// (get) Token: 0x06016E93 RID: 93843 RVA: 0x00345254 File Offset: 0x00343454
		public EAtomicProcess Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAtomicProcess.StoveCoreFall;
				}
				return (EAtomicProcess)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016E94 RID: 93844 RVA: 0x00345290 File Offset: 0x00343490
		public static Offset<IAtomicProcessBase> CreateIAtomicProcessBase(FlatBufferBuilder builder, EAtomicProcess Type = EAtomicProcess.StoveCoreFall)
		{
			builder.StartTable(1);
			IAtomicProcessBase.AddType(builder, Type);
			return IAtomicProcessBase.EndIAtomicProcessBase(builder);
		}

		// Token: 0x06016E95 RID: 93845 RVA: 0x003452A6 File Offset: 0x003434A6
		public static void StartIAtomicProcessBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016E96 RID: 93846 RVA: 0x003452AF File Offset: 0x003434AF
		public static void AddType(FlatBufferBuilder builder, EAtomicProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016E97 RID: 93847 RVA: 0x003452BA File Offset: 0x003434BA
		public static Offset<IAtomicProcessBase> EndIAtomicProcessBase(FlatBufferBuilder builder)
		{
			return new Offset<IAtomicProcessBase>(builder.EndTable());
		}

		// Token: 0x06016E98 RID: 93848 RVA: 0x003452C8 File Offset: 0x003434C8
		public IAtomicProcessBaseT UnPack()
		{
			IAtomicProcessBaseT atomicProcessBaseT = new IAtomicProcessBaseT();
			this.UnPackTo(atomicProcessBaseT);
			return atomicProcessBaseT;
		}

		// Token: 0x06016E99 RID: 93849 RVA: 0x003452E3 File Offset: 0x003434E3
		public void UnPackTo(IAtomicProcessBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016E9A RID: 93850 RVA: 0x003452F4 File Offset: 0x003434F4
		public static Offset<IAtomicProcessBase> Pack(FlatBufferBuilder builder, IAtomicProcessBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAtomicProcessBase>);
			}
			return IAtomicProcessBase.CreateIAtomicProcessBase(builder, _o.Type);
		}

		// Token: 0x0400BF7B RID: 49019
		private Table __p;
	}
}
