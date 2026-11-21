using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007627 RID: 30247
	public struct IResetPosByResetPoint : IFlatbufferObject
	{
		// Token: 0x1700DE39 RID: 56889
		// (get) Token: 0x06035131 RID: 217393 RVA: 0x00720F16 File Offset: 0x0071F116
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035132 RID: 217394 RVA: 0x00720F23 File Offset: 0x0071F123
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035133 RID: 217395 RVA: 0x00720F2C File Offset: 0x0071F12C
		public static IResetPosByResetPoint GetRootAsIResetPosByResetPoint(ByteBuffer _bb)
		{
			return IResetPosByResetPoint.GetRootAsIResetPosByResetPoint(_bb, default(IResetPosByResetPoint));
		}

		// Token: 0x06035134 RID: 217396 RVA: 0x00720F48 File Offset: 0x0071F148
		public static IResetPosByResetPoint GetRootAsIResetPosByResetPoint(ByteBuffer _bb, IResetPosByResetPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035135 RID: 217397 RVA: 0x00720F65 File Offset: 0x0071F165
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035136 RID: 217398 RVA: 0x00720F74 File Offset: 0x0071F174
		public IResetPosByResetPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE3A RID: 56890
		// (get) Token: 0x06035137 RID: 217399 RVA: 0x00720F84 File Offset: 0x0071F184
		public EResetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EResetPosType.PosEntity;
				}
				return (EResetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035138 RID: 217400 RVA: 0x00720FC0 File Offset: 0x0071F1C0
		public static Offset<IResetPosByResetPoint> CreateIResetPosByResetPoint(FlatBufferBuilder builder, EResetPosType Type = EResetPosType.PosEntity)
		{
			builder.StartTable(1);
			IResetPosByResetPoint.AddType(builder, Type);
			return IResetPosByResetPoint.EndIResetPosByResetPoint(builder);
		}

		// Token: 0x06035139 RID: 217401 RVA: 0x00720FD6 File Offset: 0x0071F1D6
		public static void StartIResetPosByResetPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603513A RID: 217402 RVA: 0x00720FDF File Offset: 0x0071F1DF
		public static void AddType(FlatBufferBuilder builder, EResetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603513B RID: 217403 RVA: 0x00720FEA File Offset: 0x0071F1EA
		public static Offset<IResetPosByResetPoint> EndIResetPosByResetPoint(FlatBufferBuilder builder)
		{
			return new Offset<IResetPosByResetPoint>(builder.EndTable());
		}

		// Token: 0x0603513C RID: 217404 RVA: 0x00720FF8 File Offset: 0x0071F1F8
		public IResetPosByResetPointT UnPack()
		{
			IResetPosByResetPointT resetPosByResetPointT = new IResetPosByResetPointT();
			this.UnPackTo(resetPosByResetPointT);
			return resetPosByResetPointT;
		}

		// Token: 0x0603513D RID: 217405 RVA: 0x00721013 File Offset: 0x0071F213
		public void UnPackTo(IResetPosByResetPointT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603513E RID: 217406 RVA: 0x00721024 File Offset: 0x0071F224
		public static Offset<IResetPosByResetPoint> Pack(FlatBufferBuilder builder, IResetPosByResetPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResetPosByResetPoint>);
			}
			return IResetPosByResetPoint.CreateIResetPosByResetPoint(builder, _o.Type);
		}

		// Token: 0x0401281B RID: 75803
		private Table __p;
	}
}
