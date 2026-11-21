using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C05 RID: 27653
	public struct IDestroySelf : IFlatbufferObject
	{
		// Token: 0x1700CABE RID: 51902
		// (get) Token: 0x0602F981 RID: 194945 RVA: 0x0067C870 File Offset: 0x0067AA70
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F982 RID: 194946 RVA: 0x0067C87D File Offset: 0x0067AA7D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F983 RID: 194947 RVA: 0x0067C884 File Offset: 0x0067AA84
		public static IDestroySelf GetRootAsIDestroySelf(ByteBuffer _bb)
		{
			return IDestroySelf.GetRootAsIDestroySelf(_bb, default(IDestroySelf));
		}

		// Token: 0x0602F984 RID: 194948 RVA: 0x0067C8A0 File Offset: 0x0067AAA0
		public static IDestroySelf GetRootAsIDestroySelf(ByteBuffer _bb, IDestroySelf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F985 RID: 194949 RVA: 0x0067C8BD File Offset: 0x0067AABD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F986 RID: 194950 RVA: 0x0067C8CC File Offset: 0x0067AACC
		public IDestroySelf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CABF RID: 51903
		// (get) Token: 0x0602F987 RID: 194951 RVA: 0x0067C8DC File Offset: 0x0067AADC
		public bool DelayDestroy
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700CAC0 RID: 51904
		// (get) Token: 0x0602F988 RID: 194952 RVA: 0x0067C91C File Offset: 0x0067AB1C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F989 RID: 194953 RVA: 0x0067C958 File Offset: 0x0067AB58
		public static Offset<IDestroySelf> CreateIDestroySelf(FlatBufferBuilder builder, bool DelayDestroy = false, byte NullMask = 0)
		{
			builder.StartTable(2);
			IDestroySelf.AddNullMask(builder, NullMask);
			IDestroySelf.AddDelayDestroy(builder, DelayDestroy);
			return IDestroySelf.EndIDestroySelf(builder);
		}

		// Token: 0x0602F98A RID: 194954 RVA: 0x0067C975 File Offset: 0x0067AB75
		public static void StartIDestroySelf(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F98B RID: 194955 RVA: 0x0067C97E File Offset: 0x0067AB7E
		public static void AddDelayDestroy(FlatBufferBuilder builder, bool delayDestroy)
		{
			builder.AddBool(0, delayDestroy, false);
		}

		// Token: 0x0602F98C RID: 194956 RVA: 0x0067C989 File Offset: 0x0067AB89
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x0602F98D RID: 194957 RVA: 0x0067C994 File Offset: 0x0067AB94
		public static Offset<IDestroySelf> EndIDestroySelf(FlatBufferBuilder builder)
		{
			return new Offset<IDestroySelf>(builder.EndTable());
		}

		// Token: 0x0602F98E RID: 194958 RVA: 0x0067C9A4 File Offset: 0x0067ABA4
		public IDestroySelfT UnPack()
		{
			IDestroySelfT destroySelfT = new IDestroySelfT();
			this.UnPackTo(destroySelfT);
			return destroySelfT;
		}

		// Token: 0x0602F98F RID: 194959 RVA: 0x0067C9BF File Offset: 0x0067ABBF
		public void UnPackTo(IDestroySelfT _o)
		{
			_o.DelayDestroy = this.DelayDestroy;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F990 RID: 194960 RVA: 0x0067C9DC File Offset: 0x0067ABDC
		public static Offset<IDestroySelf> Pack(FlatBufferBuilder builder, IDestroySelfT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDestroySelf>);
			}
			return IDestroySelf.CreateIDestroySelf(builder, _o.DelayDestroy, _o.NullMask);
		}

		// Token: 0x04011A09 RID: 72201
		private Table __p;
	}
}
