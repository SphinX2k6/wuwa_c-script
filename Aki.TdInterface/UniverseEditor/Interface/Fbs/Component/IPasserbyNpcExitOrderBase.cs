using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6C RID: 23660
	public struct IPasserbyNpcExitOrderBase : IFlatbufferObject
	{
		// Token: 0x1700ADE0 RID: 44512
		// (get) Token: 0x06027403 RID: 160771 RVA: 0x005606D6 File Offset: 0x0055E8D6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027404 RID: 160772 RVA: 0x005606E3 File Offset: 0x0055E8E3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027405 RID: 160773 RVA: 0x005606EC File Offset: 0x0055E8EC
		public static IPasserbyNpcExitOrderBase GetRootAsIPasserbyNpcExitOrderBase(ByteBuffer _bb)
		{
			return IPasserbyNpcExitOrderBase.GetRootAsIPasserbyNpcExitOrderBase(_bb, default(IPasserbyNpcExitOrderBase));
		}

		// Token: 0x06027406 RID: 160774 RVA: 0x00560708 File Offset: 0x0055E908
		public static IPasserbyNpcExitOrderBase GetRootAsIPasserbyNpcExitOrderBase(ByteBuffer _bb, IPasserbyNpcExitOrderBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027407 RID: 160775 RVA: 0x00560725 File Offset: 0x0055E925
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027408 RID: 160776 RVA: 0x00560734 File Offset: 0x0055E934
		public IPasserbyNpcExitOrderBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADE1 RID: 44513
		// (get) Token: 0x06027409 RID: 160777 RVA: 0x00560744 File Offset: 0x0055E944
		public EPasserbyNpcExitOrderType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPasserbyNpcExitOrderType.NearSplineStartFirst;
				}
				return (EPasserbyNpcExitOrderType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602740A RID: 160778 RVA: 0x00560780 File Offset: 0x0055E980
		public static Offset<IPasserbyNpcExitOrderBase> CreateIPasserbyNpcExitOrderBase(FlatBufferBuilder builder, EPasserbyNpcExitOrderType Type = EPasserbyNpcExitOrderType.NearSplineStartFirst)
		{
			builder.StartTable(1);
			IPasserbyNpcExitOrderBase.AddType(builder, Type);
			return IPasserbyNpcExitOrderBase.EndIPasserbyNpcExitOrderBase(builder);
		}

		// Token: 0x0602740B RID: 160779 RVA: 0x00560796 File Offset: 0x0055E996
		public static void StartIPasserbyNpcExitOrderBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602740C RID: 160780 RVA: 0x0056079F File Offset: 0x0055E99F
		public static void AddType(FlatBufferBuilder builder, EPasserbyNpcExitOrderType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602740D RID: 160781 RVA: 0x005607AA File Offset: 0x0055E9AA
		public static Offset<IPasserbyNpcExitOrderBase> EndIPasserbyNpcExitOrderBase(FlatBufferBuilder builder)
		{
			return new Offset<IPasserbyNpcExitOrderBase>(builder.EndTable());
		}

		// Token: 0x0602740E RID: 160782 RVA: 0x005607B8 File Offset: 0x0055E9B8
		public IPasserbyNpcExitOrderBaseT UnPack()
		{
			IPasserbyNpcExitOrderBaseT passerbyNpcExitOrderBaseT = new IPasserbyNpcExitOrderBaseT();
			this.UnPackTo(passerbyNpcExitOrderBaseT);
			return passerbyNpcExitOrderBaseT;
		}

		// Token: 0x0602740F RID: 160783 RVA: 0x005607D3 File Offset: 0x0055E9D3
		public void UnPackTo(IPasserbyNpcExitOrderBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027410 RID: 160784 RVA: 0x005607E4 File Offset: 0x0055E9E4
		public static Offset<IPasserbyNpcExitOrderBase> Pack(FlatBufferBuilder builder, IPasserbyNpcExitOrderBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPasserbyNpcExitOrderBase>);
			}
			return IPasserbyNpcExitOrderBase.CreateIPasserbyNpcExitOrderBase(builder, _o.Type);
		}

		// Token: 0x0400F76C RID: 63340
		private Table __p;
	}
}
