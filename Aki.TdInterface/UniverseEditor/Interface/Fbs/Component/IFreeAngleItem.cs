using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583E RID: 22590
	public struct IFreeAngleItem : IFlatbufferObject
	{
		// Token: 0x1700A398 RID: 41880
		// (get) Token: 0x06024949 RID: 149833 RVA: 0x00506B8B File Offset: 0x00504D8B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602494A RID: 149834 RVA: 0x00506B98 File Offset: 0x00504D98
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602494B RID: 149835 RVA: 0x00506BA0 File Offset: 0x00504DA0
		public static IFreeAngleItem GetRootAsIFreeAngleItem(ByteBuffer _bb)
		{
			return IFreeAngleItem.GetRootAsIFreeAngleItem(_bb, default(IFreeAngleItem));
		}

		// Token: 0x0602494C RID: 149836 RVA: 0x00506BBC File Offset: 0x00504DBC
		public static IFreeAngleItem GetRootAsIFreeAngleItem(ByteBuffer _bb, IFreeAngleItem obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602494D RID: 149837 RVA: 0x00506BD9 File Offset: 0x00504DD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602494E RID: 149838 RVA: 0x00506BE8 File Offset: 0x00504DE8
		public IFreeAngleItem __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A399 RID: 41881
		// (get) Token: 0x0602494F RID: 149839 RVA: 0x00506BF8 File Offset: 0x00504DF8
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

		// Token: 0x1700A39A RID: 41882
		// (get) Token: 0x06024950 RID: 149840 RVA: 0x00506C34 File Offset: 0x00504E34
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

		// Token: 0x06024951 RID: 149841 RVA: 0x00506C70 File Offset: 0x00504E70
		public static Offset<IFreeAngleItem> CreateIFreeAngleItem(FlatBufferBuilder builder, int InitAngle = 0, int TargetAngle = 0)
		{
			builder.StartTable(2);
			IFreeAngleItem.AddTargetAngle(builder, TargetAngle);
			IFreeAngleItem.AddInitAngle(builder, InitAngle);
			return IFreeAngleItem.EndIFreeAngleItem(builder);
		}

		// Token: 0x06024952 RID: 149842 RVA: 0x00506C8D File Offset: 0x00504E8D
		public static void StartIFreeAngleItem(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06024953 RID: 149843 RVA: 0x00506C96 File Offset: 0x00504E96
		public static void AddInitAngle(FlatBufferBuilder builder, int initAngle)
		{
			builder.AddInt(0, initAngle, 0);
		}

		// Token: 0x06024954 RID: 149844 RVA: 0x00506CA1 File Offset: 0x00504EA1
		public static void AddTargetAngle(FlatBufferBuilder builder, int targetAngle)
		{
			builder.AddInt(1, targetAngle, 0);
		}

		// Token: 0x06024955 RID: 149845 RVA: 0x00506CAC File Offset: 0x00504EAC
		public static Offset<IFreeAngleItem> EndIFreeAngleItem(FlatBufferBuilder builder)
		{
			return new Offset<IFreeAngleItem>(builder.EndTable());
		}

		// Token: 0x06024956 RID: 149846 RVA: 0x00506CBC File Offset: 0x00504EBC
		public IFreeAngleItemT UnPack()
		{
			IFreeAngleItemT freeAngleItemT = new IFreeAngleItemT();
			this.UnPackTo(freeAngleItemT);
			return freeAngleItemT;
		}

		// Token: 0x06024957 RID: 149847 RVA: 0x00506CD7 File Offset: 0x00504ED7
		public void UnPackTo(IFreeAngleItemT _o)
		{
			_o.InitAngle = this.InitAngle;
			_o.TargetAngle = this.TargetAngle;
		}

		// Token: 0x06024958 RID: 149848 RVA: 0x00506CF4 File Offset: 0x00504EF4
		public static Offset<IFreeAngleItem> Pack(FlatBufferBuilder builder, IFreeAngleItemT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFreeAngleItem>);
			}
			return IFreeAngleItem.CreateIFreeAngleItem(builder, _o.InitAngle, _o.TargetAngle);
		}

		// Token: 0x0400F074 RID: 61556
		private Table __p;
	}
}
