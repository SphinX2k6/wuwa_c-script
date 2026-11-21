using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BCF RID: 31695
	public struct ITimeScaleType : IFlatbufferObject
	{
		// Token: 0x1700ED73 RID: 60787
		// (get) Token: 0x0603920A RID: 233994 RVA: 0x007B849C File Offset: 0x007B669C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603920B RID: 233995 RVA: 0x007B84A9 File Offset: 0x007B66A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603920C RID: 233996 RVA: 0x007B84B0 File Offset: 0x007B66B0
		public static ITimeScaleType GetRootAsITimeScaleType(ByteBuffer _bb)
		{
			return ITimeScaleType.GetRootAsITimeScaleType(_bb, default(ITimeScaleType));
		}

		// Token: 0x0603920D RID: 233997 RVA: 0x007B84CC File Offset: 0x007B66CC
		public static ITimeScaleType GetRootAsITimeScaleType(ByteBuffer _bb, ITimeScaleType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603920E RID: 233998 RVA: 0x007B84E9 File Offset: 0x007B66E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603920F RID: 233999 RVA: 0x007B84F8 File Offset: 0x007B66F8
		public ITimeScaleType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED74 RID: 60788
		// (get) Token: 0x06039210 RID: 234000 RVA: 0x007B8508 File Offset: 0x007B6708
		public ETimeScaleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScaleType.Global;
				}
				return (ETimeScaleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039211 RID: 234001 RVA: 0x007B8544 File Offset: 0x007B6744
		public static Offset<ITimeScaleType> CreateITimeScaleType(FlatBufferBuilder builder, ETimeScaleType Type = ETimeScaleType.Global)
		{
			builder.StartTable(1);
			ITimeScaleType.AddType(builder, Type);
			return ITimeScaleType.EndITimeScaleType(builder);
		}

		// Token: 0x06039212 RID: 234002 RVA: 0x007B855A File Offset: 0x007B675A
		public static void StartITimeScaleType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06039213 RID: 234003 RVA: 0x007B8563 File Offset: 0x007B6763
		public static void AddType(FlatBufferBuilder builder, ETimeScaleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039214 RID: 234004 RVA: 0x007B856E File Offset: 0x007B676E
		public static Offset<ITimeScaleType> EndITimeScaleType(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScaleType>(builder.EndTable());
		}

		// Token: 0x06039215 RID: 234005 RVA: 0x007B857C File Offset: 0x007B677C
		public ITimeScaleTypeT UnPack()
		{
			ITimeScaleTypeT timeScaleTypeT = new ITimeScaleTypeT();
			this.UnPackTo(timeScaleTypeT);
			return timeScaleTypeT;
		}

		// Token: 0x06039216 RID: 234006 RVA: 0x007B8597 File Offset: 0x007B6797
		public void UnPackTo(ITimeScaleTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06039217 RID: 234007 RVA: 0x007B85A8 File Offset: 0x007B67A8
		public static Offset<ITimeScaleType> Pack(FlatBufferBuilder builder, ITimeScaleTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScaleType>);
			}
			return ITimeScaleType.CreateITimeScaleType(builder, _o.Type);
		}

		// Token: 0x04013259 RID: 78425
		private Table __p;
	}
}
