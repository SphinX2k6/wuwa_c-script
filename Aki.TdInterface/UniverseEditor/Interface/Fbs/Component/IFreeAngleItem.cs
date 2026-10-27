using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D3 RID: 21203
	public struct IFreeAngleItem : IFlatbufferObject
	{
		// Token: 0x17009B8F RID: 39823
		// (get) Token: 0x06022985 RID: 141701 RVA: 0x004CBA8F File Offset: 0x004C9C8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022986 RID: 141702 RVA: 0x004CBA9C File Offset: 0x004C9C9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022987 RID: 141703 RVA: 0x004CBAA4 File Offset: 0x004C9CA4
		public static IFreeAngleItem GetRootAsIFreeAngleItem(ByteBuffer _bb)
		{
			return IFreeAngleItem.GetRootAsIFreeAngleItem(_bb, default(IFreeAngleItem));
		}

		// Token: 0x06022988 RID: 141704 RVA: 0x004CBAC0 File Offset: 0x004C9CC0
		public static IFreeAngleItem GetRootAsIFreeAngleItem(ByteBuffer _bb, IFreeAngleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022989 RID: 141705 RVA: 0x004CBADD File Offset: 0x004C9CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602298A RID: 141706 RVA: 0x004CBAEC File Offset: 0x004C9CEC
		public IFreeAngleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B90 RID: 39824
		// (get) Token: 0x0602298B RID: 141707 RVA: 0x004CBAFC File Offset: 0x004C9CFC
		public int InitAngle
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009B91 RID: 39825
		// (get) Token: 0x0602298C RID: 141708 RVA: 0x004CBB38 File Offset: 0x004C9D38
		public int TargetAngle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602298D RID: 141709 RVA: 0x004CBB74 File Offset: 0x004C9D74
		public static Offset<IFreeAngleItem> CreateIFreeAngleItem(FlatBufferBuilder builder, int InitAngle = 0, int TargetAngle = 0)
		{
			builder.StartTable(2);
			IFreeAngleItem.AddTargetAngle(builder, TargetAngle);
			IFreeAngleItem.AddInitAngle(builder, InitAngle);
			return IFreeAngleItem.EndIFreeAngleItem(builder);
		}

		// Token: 0x0602298E RID: 141710 RVA: 0x004CBB91 File Offset: 0x004C9D91
		public static void StartIFreeAngleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602298F RID: 141711 RVA: 0x004CBB9A File Offset: 0x004C9D9A
		public static void AddInitAngle(FlatBufferBuilder builder, int initAngle)
		{
			builder.AddInt(0, initAngle, 0);
		}

		// Token: 0x06022990 RID: 141712 RVA: 0x004CBBA5 File Offset: 0x004C9DA5
		public static void AddTargetAngle(FlatBufferBuilder builder, int targetAngle)
		{
			builder.AddInt(1, targetAngle, 0);
		}

		// Token: 0x06022991 RID: 141713 RVA: 0x004CBBB0 File Offset: 0x004C9DB0
		public static Offset<IFreeAngleItem> EndIFreeAngleItem(FlatBufferBuilder builder)
		{
			return new Offset<IFreeAngleItem>(builder.EndTable());
		}

		// Token: 0x06022992 RID: 141714 RVA: 0x004CBBC0 File Offset: 0x004C9DC0
		public IFreeAngleItemT UnPack()
		{
			IFreeAngleItemT freeAngleItemT = new IFreeAngleItemT();
			this.UnPackTo(freeAngleItemT);
			return freeAngleItemT;
		}

		// Token: 0x06022993 RID: 141715 RVA: 0x004CBBDB File Offset: 0x004C9DDB
		public void UnPackTo(IFreeAngleItemT _o)
		{
			_o.InitAngle = this.InitAngle;
			_o.TargetAngle = this.TargetAngle;
		}

		// Token: 0x06022994 RID: 141716 RVA: 0x004CBBF8 File Offset: 0x004C9DF8
		public static Offset<IFreeAngleItem> Pack(FlatBufferBuilder builder, IFreeAngleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFreeAngleItem>);
			}
			return IFreeAngleItem.CreateIFreeAngleItem(builder, _o.InitAngle, _o.TargetAngle);
		}

		// Token: 0x0400E467 RID: 58471
		private Table __p;
	}
}
