using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDE RID: 27614
	public struct IDeliverItemProbeCollectibleViewStyle : IFlatbufferObject
	{
		// Token: 0x1700CA8B RID: 51851
		// (get) Token: 0x0602F87A RID: 194682 RVA: 0x0067AE3C File Offset: 0x0067903C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F87B RID: 194683 RVA: 0x0067AE49 File Offset: 0x00679049
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F87C RID: 194684 RVA: 0x0067AE50 File Offset: 0x00679050
		public static IDeliverItemProbeCollectibleViewStyle GetRootAsIDeliverItemProbeCollectibleViewStyle(ByteBuffer _bb)
		{
			return IDeliverItemProbeCollectibleViewStyle.GetRootAsIDeliverItemProbeCollectibleViewStyle(_bb, default(IDeliverItemProbeCollectibleViewStyle));
		}

		// Token: 0x0602F87D RID: 194685 RVA: 0x0067AE6C File Offset: 0x0067906C
		public static IDeliverItemProbeCollectibleViewStyle GetRootAsIDeliverItemProbeCollectibleViewStyle(ByteBuffer _bb, IDeliverItemProbeCollectibleViewStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F87E RID: 194686 RVA: 0x0067AE89 File Offset: 0x00679089
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F87F RID: 194687 RVA: 0x0067AE98 File Offset: 0x00679098
		public IDeliverItemProbeCollectibleViewStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA8C RID: 51852
		// (get) Token: 0x0602F880 RID: 194688 RVA: 0x0067AEA8 File Offset: 0x006790A8
		public EDeliverItemProbeCollectibleViewStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDeliverItemProbeCollectibleViewStyle.HandInItemStyle;
				}
				return (EDeliverItemProbeCollectibleViewStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F881 RID: 194689 RVA: 0x0067AEE4 File Offset: 0x006790E4
		public static Offset<IDeliverItemProbeCollectibleViewStyle> CreateIDeliverItemProbeCollectibleViewStyle(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle Type = EDeliverItemProbeCollectibleViewStyle.HandInItemStyle)
		{
			builder.StartTable(1);
			IDeliverItemProbeCollectibleViewStyle.AddType(builder, Type);
			return IDeliverItemProbeCollectibleViewStyle.EndIDeliverItemProbeCollectibleViewStyle(builder);
		}

		// Token: 0x0602F882 RID: 194690 RVA: 0x0067AEFA File Offset: 0x006790FA
		public static void StartIDeliverItemProbeCollectibleViewStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602F883 RID: 194691 RVA: 0x0067AF03 File Offset: 0x00679103
		public static void AddType(FlatBufferBuilder builder, EDeliverItemProbeCollectibleViewStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F884 RID: 194692 RVA: 0x0067AF0E File Offset: 0x0067910E
		public static Offset<IDeliverItemProbeCollectibleViewStyle> EndIDeliverItemProbeCollectibleViewStyle(FlatBufferBuilder builder)
		{
			return new Offset<IDeliverItemProbeCollectibleViewStyle>(builder.EndTable());
		}

		// Token: 0x0602F885 RID: 194693 RVA: 0x0067AF1C File Offset: 0x0067911C
		public IDeliverItemProbeCollectibleViewStyleT UnPack()
		{
			IDeliverItemProbeCollectibleViewStyleT deliverItemProbeCollectibleViewStyleT = new IDeliverItemProbeCollectibleViewStyleT();
			this.UnPackTo(deliverItemProbeCollectibleViewStyleT);
			return deliverItemProbeCollectibleViewStyleT;
		}

		// Token: 0x0602F886 RID: 194694 RVA: 0x0067AF37 File Offset: 0x00679137
		public void UnPackTo(IDeliverItemProbeCollectibleViewStyleT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602F887 RID: 194695 RVA: 0x0067AF48 File Offset: 0x00679148
		public static Offset<IDeliverItemProbeCollectibleViewStyle> Pack(FlatBufferBuilder builder, IDeliverItemProbeCollectibleViewStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDeliverItemProbeCollectibleViewStyle>);
			}
			return IDeliverItemProbeCollectibleViewStyle.CreateIDeliverItemProbeCollectibleViewStyle(builder, _o.Type);
		}

		// Token: 0x040119E0 RID: 72160
		private Table __p;
	}
}
