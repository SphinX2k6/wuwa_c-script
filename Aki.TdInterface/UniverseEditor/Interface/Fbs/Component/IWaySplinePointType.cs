using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006175 RID: 24949
	public struct IWaySplinePointType : IFlatbufferObject
	{
		// Token: 0x1700BA05 RID: 47621
		// (get) Token: 0x0602A631 RID: 173617 RVA: 0x005C896E File Offset: 0x005C6B6E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A632 RID: 173618 RVA: 0x005C897B File Offset: 0x005C6B7B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A633 RID: 173619 RVA: 0x005C8984 File Offset: 0x005C6B84
		public static IWaySplinePointType GetRootAsIWaySplinePointType(ByteBuffer _bb)
		{
			return IWaySplinePointType.GetRootAsIWaySplinePointType(_bb, default(IWaySplinePointType));
		}

		// Token: 0x0602A634 RID: 173620 RVA: 0x005C89A0 File Offset: 0x005C6BA0
		public static IWaySplinePointType GetRootAsIWaySplinePointType(ByteBuffer _bb, IWaySplinePointType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A635 RID: 173621 RVA: 0x005C89BD File Offset: 0x005C6BBD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A636 RID: 173622 RVA: 0x005C89CC File Offset: 0x005C6BCC
		public IWaySplinePointType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA06 RID: 47622
		// (get) Token: 0x0602A637 RID: 173623 RVA: 0x005C89DC File Offset: 0x005C6BDC
		public EWaySplinePointType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EWaySplinePointType.Common;
				}
				return (EWaySplinePointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602A638 RID: 173624 RVA: 0x005C8A18 File Offset: 0x005C6C18
		public static Offset<IWaySplinePointType> CreateIWaySplinePointType(FlatBufferBuilder builder, EWaySplinePointType Type = EWaySplinePointType.Common)
		{
			builder.StartTable(1);
			IWaySplinePointType.AddType(builder, Type);
			return IWaySplinePointType.EndIWaySplinePointType(builder);
		}

		// Token: 0x0602A639 RID: 173625 RVA: 0x005C8A2E File Offset: 0x005C6C2E
		public static void StartIWaySplinePointType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602A63A RID: 173626 RVA: 0x005C8A37 File Offset: 0x005C6C37
		public static void AddType(FlatBufferBuilder builder, EWaySplinePointType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A63B RID: 173627 RVA: 0x005C8A42 File Offset: 0x005C6C42
		public static Offset<IWaySplinePointType> EndIWaySplinePointType(FlatBufferBuilder builder)
		{
			return new Offset<IWaySplinePointType>(builder.EndTable());
		}

		// Token: 0x0602A63C RID: 173628 RVA: 0x005C8A50 File Offset: 0x005C6C50
		public IWaySplinePointTypeT UnPack()
		{
			IWaySplinePointTypeT waySplinePointTypeT = new IWaySplinePointTypeT();
			this.UnPackTo(waySplinePointTypeT);
			return waySplinePointTypeT;
		}

		// Token: 0x0602A63D RID: 173629 RVA: 0x005C8A6B File Offset: 0x005C6C6B
		public void UnPackTo(IWaySplinePointTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602A63E RID: 173630 RVA: 0x005C8A7C File Offset: 0x005C6C7C
		public static Offset<IWaySplinePointType> Pack(FlatBufferBuilder builder, IWaySplinePointTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWaySplinePointType>);
			}
			return IWaySplinePointType.CreateIWaySplinePointType(builder, _o.Type);
		}

		// Token: 0x0400FFB0 RID: 65456
		private Table __p;
	}
}
