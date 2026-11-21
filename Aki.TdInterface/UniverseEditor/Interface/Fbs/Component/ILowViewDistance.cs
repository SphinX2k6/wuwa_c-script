using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA1 RID: 23201
	public struct ILowViewDistance : IFlatbufferObject
	{
		// Token: 0x1700A90E RID: 43278
		// (get) Token: 0x06026077 RID: 155767 RVA: 0x00536291 File Offset: 0x00534491
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026078 RID: 155768 RVA: 0x0053629E File Offset: 0x0053449E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026079 RID: 155769 RVA: 0x005362A8 File Offset: 0x005344A8
		public static ILowViewDistance GetRootAsILowViewDistance(ByteBuffer _bb)
		{
			return ILowViewDistance.GetRootAsILowViewDistance(_bb, default(ILowViewDistance));
		}

		// Token: 0x0602607A RID: 155770 RVA: 0x005362C4 File Offset: 0x005344C4
		public static ILowViewDistance GetRootAsILowViewDistance(ByteBuffer _bb, ILowViewDistance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602607B RID: 155771 RVA: 0x005362E1 File Offset: 0x005344E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602607C RID: 155772 RVA: 0x005362F0 File Offset: 0x005344F0
		public ILowViewDistance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A90F RID: 43279
		// (get) Token: 0x0602607D RID: 155773 RVA: 0x00536300 File Offset: 0x00534500
		public EViewDistanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EViewDistanceType.Low;
				}
				return (EViewDistanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602607E RID: 155774 RVA: 0x0053633C File Offset: 0x0053453C
		public static Offset<ILowViewDistance> CreateILowViewDistance(FlatBufferBuilder builder, EViewDistanceType Type = EViewDistanceType.Low)
		{
			builder.StartTable(1);
			ILowViewDistance.AddType(builder, Type);
			return ILowViewDistance.EndILowViewDistance(builder);
		}

		// Token: 0x0602607F RID: 155775 RVA: 0x00536352 File Offset: 0x00534552
		public static void StartILowViewDistance(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026080 RID: 155776 RVA: 0x0053635B File Offset: 0x0053455B
		public static void AddType(FlatBufferBuilder builder, EViewDistanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026081 RID: 155777 RVA: 0x00536366 File Offset: 0x00534566
		public static Offset<ILowViewDistance> EndILowViewDistance(FlatBufferBuilder builder)
		{
			return new Offset<ILowViewDistance>(builder.EndTable());
		}

		// Token: 0x06026082 RID: 155778 RVA: 0x00536374 File Offset: 0x00534574
		public ILowViewDistanceT UnPack()
		{
			ILowViewDistanceT lowViewDistanceT = new ILowViewDistanceT();
			this.UnPackTo(lowViewDistanceT);
			return lowViewDistanceT;
		}

		// Token: 0x06026083 RID: 155779 RVA: 0x0053638F File Offset: 0x0053458F
		public void UnPackTo(ILowViewDistanceT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06026084 RID: 155780 RVA: 0x005363A0 File Offset: 0x005345A0
		public static Offset<ILowViewDistance> Pack(FlatBufferBuilder builder, ILowViewDistanceT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILowViewDistance>);
			}
			return ILowViewDistance.CreateILowViewDistance(builder, _o.Type);
		}

		// Token: 0x0400F440 RID: 62528
		private Table __p;
	}
}
