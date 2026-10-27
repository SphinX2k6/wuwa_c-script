using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D19 RID: 15641
	public struct IAtomicProcessBase : IFlatbufferObject
	{
		// Token: 0x17006B4E RID: 27470
		// (get) Token: 0x06015955 RID: 88405 RVA: 0x0031DF6E File Offset: 0x0031C16E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015956 RID: 88406 RVA: 0x0031DF7B File Offset: 0x0031C17B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015957 RID: 88407 RVA: 0x0031DF84 File Offset: 0x0031C184
		public static IAtomicProcessBase GetRootAsIAtomicProcessBase(ByteBuffer _bb)
		{
			return IAtomicProcessBase.GetRootAsIAtomicProcessBase(_bb, default(IAtomicProcessBase));
		}

		// Token: 0x06015958 RID: 88408 RVA: 0x0031DFA0 File Offset: 0x0031C1A0
		public static IAtomicProcessBase GetRootAsIAtomicProcessBase(ByteBuffer _bb, IAtomicProcessBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015959 RID: 88409 RVA: 0x0031DFBD File Offset: 0x0031C1BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601595A RID: 88410 RVA: 0x0031DFCC File Offset: 0x0031C1CC
		public IAtomicProcessBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006B4F RID: 27471
		// (get) Token: 0x0601595B RID: 88411 RVA: 0x0031DFDC File Offset: 0x0031C1DC
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

		// Token: 0x0601595C RID: 88412 RVA: 0x0031E018 File Offset: 0x0031C218
		public static Offset<IAtomicProcessBase> CreateIAtomicProcessBase(FlatBufferBuilder builder, EAtomicProcess Type = EAtomicProcess.StoveCoreFall)
		{
			builder.StartTable(1);
			IAtomicProcessBase.AddType(builder, Type);
			return IAtomicProcessBase.EndIAtomicProcessBase(builder);
		}

		// Token: 0x0601595D RID: 88413 RVA: 0x0031E02E File Offset: 0x0031C22E
		public static void StartIAtomicProcessBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601595E RID: 88414 RVA: 0x0031E037 File Offset: 0x0031C237
		public static void AddType(FlatBufferBuilder builder, EAtomicProcess type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601595F RID: 88415 RVA: 0x0031E042 File Offset: 0x0031C242
		public static Offset<IAtomicProcessBase> EndIAtomicProcessBase(FlatBufferBuilder builder)
		{
			return new Offset<IAtomicProcessBase>(builder.EndTable());
		}

		// Token: 0x06015960 RID: 88416 RVA: 0x0031E050 File Offset: 0x0031C250
		public IAtomicProcessBaseT UnPack()
		{
			IAtomicProcessBaseT atomicProcessBaseT = new IAtomicProcessBaseT();
			this.UnPackTo(atomicProcessBaseT);
			return atomicProcessBaseT;
		}

		// Token: 0x06015961 RID: 88417 RVA: 0x0031E06B File Offset: 0x0031C26B
		public void UnPackTo(IAtomicProcessBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015962 RID: 88418 RVA: 0x0031E07C File Offset: 0x0031C27C
		public static Offset<IAtomicProcessBase> Pack(FlatBufferBuilder builder, IAtomicProcessBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAtomicProcessBase>);
			}
			return IAtomicProcessBase.CreateIAtomicProcessBase(builder, _o.Type);
		}

		// Token: 0x0400B5CE RID: 46542
		private Table __p;
	}
}
