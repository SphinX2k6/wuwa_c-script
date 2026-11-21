using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A0 RID: 27040
	public struct IChangeTimerType : IFlatbufferObject
	{
		// Token: 0x1700C70E RID: 50958
		// (get) Token: 0x0602E62A RID: 189994 RVA: 0x00654C50 File Offset: 0x00652E50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E62B RID: 189995 RVA: 0x00654C5D File Offset: 0x00652E5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E62C RID: 189996 RVA: 0x00654C64 File Offset: 0x00652E64
		public static IChangeTimerType GetRootAsIChangeTimerType(ByteBuffer _bb)
		{
			return IChangeTimerType.GetRootAsIChangeTimerType(_bb, default(IChangeTimerType));
		}

		// Token: 0x0602E62D RID: 189997 RVA: 0x00654C80 File Offset: 0x00652E80
		public static IChangeTimerType GetRootAsIChangeTimerType(ByteBuffer _bb, IChangeTimerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E62E RID: 189998 RVA: 0x00654C9D File Offset: 0x00652E9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E62F RID: 189999 RVA: 0x00654CAC File Offset: 0x00652EAC
		public IChangeTimerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C70F RID: 50959
		// (get) Token: 0x0602E630 RID: 190000 RVA: 0x00654CBC File Offset: 0x00652EBC
		public EChangeTimerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChangeTimerType.Add;
				}
				return (EChangeTimerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E631 RID: 190001 RVA: 0x00654CF8 File Offset: 0x00652EF8
		public static Offset<IChangeTimerType> CreateIChangeTimerType(FlatBufferBuilder builder, EChangeTimerType Type = EChangeTimerType.Add)
		{
			builder.StartTable(1);
			IChangeTimerType.AddType(builder, Type);
			return IChangeTimerType.EndIChangeTimerType(builder);
		}

		// Token: 0x0602E632 RID: 190002 RVA: 0x00654D0E File Offset: 0x00652F0E
		public static void StartIChangeTimerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E633 RID: 190003 RVA: 0x00654D17 File Offset: 0x00652F17
		public static void AddType(FlatBufferBuilder builder, EChangeTimerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E634 RID: 190004 RVA: 0x00654D22 File Offset: 0x00652F22
		public static Offset<IChangeTimerType> EndIChangeTimerType(FlatBufferBuilder builder)
		{
			return new Offset<IChangeTimerType>(builder.EndTable());
		}

		// Token: 0x0602E635 RID: 190005 RVA: 0x00654D30 File Offset: 0x00652F30
		public IChangeTimerTypeT UnPack()
		{
			IChangeTimerTypeT changeTimerTypeT = new IChangeTimerTypeT();
			this.UnPackTo(changeTimerTypeT);
			return changeTimerTypeT;
		}

		// Token: 0x0602E636 RID: 190006 RVA: 0x00654D4B File Offset: 0x00652F4B
		public void UnPackTo(IChangeTimerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E637 RID: 190007 RVA: 0x00654D5C File Offset: 0x00652F5C
		public static Offset<IChangeTimerType> Pack(FlatBufferBuilder builder, IChangeTimerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeTimerType>);
			}
			return IChangeTimerType.CreateIChangeTimerType(builder, _o.Type);
		}

		// Token: 0x04011707 RID: 71431
		private Table __p;
	}
}
