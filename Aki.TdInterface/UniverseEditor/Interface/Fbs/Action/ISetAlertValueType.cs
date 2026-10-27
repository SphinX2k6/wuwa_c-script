using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F96 RID: 28566
	public struct ISetAlertValueType : IFlatbufferObject
	{
		// Token: 0x1700D42B RID: 54315
		// (get) Token: 0x060327BF RID: 206783 RVA: 0x006D0878 File Offset: 0x006CEA78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060327C0 RID: 206784 RVA: 0x006D0885 File Offset: 0x006CEA85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060327C1 RID: 206785 RVA: 0x006D088C File Offset: 0x006CEA8C
		public static ISetAlertValueType GetRootAsISetAlertValueType(ByteBuffer _bb)
		{
			return ISetAlertValueType.GetRootAsISetAlertValueType(_bb, default(ISetAlertValueType));
		}

		// Token: 0x060327C2 RID: 206786 RVA: 0x006D08A8 File Offset: 0x006CEAA8
		public static ISetAlertValueType GetRootAsISetAlertValueType(ByteBuffer _bb, ISetAlertValueType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060327C3 RID: 206787 RVA: 0x006D08C5 File Offset: 0x006CEAC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060327C4 RID: 206788 RVA: 0x006D08D4 File Offset: 0x006CEAD4
		public ISetAlertValueType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D42C RID: 54316
		// (get) Token: 0x060327C5 RID: 206789 RVA: 0x006D08E4 File Offset: 0x006CEAE4
		public EValueChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EValueChangeType.AddOrSub;
				}
				return (EValueChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060327C6 RID: 206790 RVA: 0x006D0920 File Offset: 0x006CEB20
		public static Offset<ISetAlertValueType> CreateISetAlertValueType(FlatBufferBuilder builder, EValueChangeType Type = EValueChangeType.AddOrSub)
		{
			builder.StartTable(1);
			ISetAlertValueType.AddType(builder, Type);
			return ISetAlertValueType.EndISetAlertValueType(builder);
		}

		// Token: 0x060327C7 RID: 206791 RVA: 0x006D0936 File Offset: 0x006CEB36
		public static void StartISetAlertValueType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060327C8 RID: 206792 RVA: 0x006D093F File Offset: 0x006CEB3F
		public static void AddType(FlatBufferBuilder builder, EValueChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060327C9 RID: 206793 RVA: 0x006D094A File Offset: 0x006CEB4A
		public static Offset<ISetAlertValueType> EndISetAlertValueType(FlatBufferBuilder builder)
		{
			return new Offset<ISetAlertValueType>(builder.EndTable());
		}

		// Token: 0x060327CA RID: 206794 RVA: 0x006D0958 File Offset: 0x006CEB58
		public ISetAlertValueTypeT UnPack()
		{
			ISetAlertValueTypeT setAlertValueTypeT = new ISetAlertValueTypeT();
			this.UnPackTo(setAlertValueTypeT);
			return setAlertValueTypeT;
		}

		// Token: 0x060327CB RID: 206795 RVA: 0x006D0973 File Offset: 0x006CEB73
		public void UnPackTo(ISetAlertValueTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060327CC RID: 206796 RVA: 0x006D0984 File Offset: 0x006CEB84
		public static Offset<ISetAlertValueType> Pack(FlatBufferBuilder builder, ISetAlertValueTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAlertValueType>);
			}
			return ISetAlertValueType.CreateISetAlertValueType(builder, _o.Type);
		}

		// Token: 0x04011993 RID: 72083
		private Table __p;
	}
}
