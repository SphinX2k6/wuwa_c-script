using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CFC RID: 23804
	public struct IPatrolPositionRefresh : IFlatbufferObject
	{
		// Token: 0x1700AEEC RID: 44780
		// (get) Token: 0x0602788A RID: 161930 RVA: 0x00568BB5 File Offset: 0x00566DB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602788B RID: 161931 RVA: 0x00568BC2 File Offset: 0x00566DC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602788C RID: 161932 RVA: 0x00568BCC File Offset: 0x00566DCC
		public static IPatrolPositionRefresh GetRootAsIPatrolPositionRefresh(ByteBuffer _bb)
		{
			return IPatrolPositionRefresh.GetRootAsIPatrolPositionRefresh(_bb, default(IPatrolPositionRefresh));
		}

		// Token: 0x0602788D RID: 161933 RVA: 0x00568BE8 File Offset: 0x00566DE8
		public static IPatrolPositionRefresh GetRootAsIPatrolPositionRefresh(ByteBuffer _bb, IPatrolPositionRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602788E RID: 161934 RVA: 0x00568C05 File Offset: 0x00566E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602788F RID: 161935 RVA: 0x00568C14 File Offset: 0x00566E14
		public IPatrolPositionRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEED RID: 44781
		// (get) Token: 0x06027890 RID: 161936 RVA: 0x00568C24 File Offset: 0x00566E24
		public EPatrolPositionRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPatrolPositionRefreshType.NearestSplinePointToPlayer;
				}
				return (EPatrolPositionRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027891 RID: 161937 RVA: 0x00568C60 File Offset: 0x00566E60
		public static Offset<IPatrolPositionRefresh> CreateIPatrolPositionRefresh(FlatBufferBuilder builder, EPatrolPositionRefreshType Type = EPatrolPositionRefreshType.NearestSplinePointToPlayer)
		{
			builder.StartTable(1);
			IPatrolPositionRefresh.AddType(builder, Type);
			return IPatrolPositionRefresh.EndIPatrolPositionRefresh(builder);
		}

		// Token: 0x06027892 RID: 161938 RVA: 0x00568C76 File Offset: 0x00566E76
		public static void StartIPatrolPositionRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027893 RID: 161939 RVA: 0x00568C7F File Offset: 0x00566E7F
		public static void AddType(FlatBufferBuilder builder, EPatrolPositionRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027894 RID: 161940 RVA: 0x00568C8A File Offset: 0x00566E8A
		public static Offset<IPatrolPositionRefresh> EndIPatrolPositionRefresh(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolPositionRefresh>(builder.EndTable());
		}

		// Token: 0x06027895 RID: 161941 RVA: 0x00568C98 File Offset: 0x00566E98
		public IPatrolPositionRefreshT UnPack()
		{
			IPatrolPositionRefreshT patrolPositionRefreshT = new IPatrolPositionRefreshT();
			this.UnPackTo(patrolPositionRefreshT);
			return patrolPositionRefreshT;
		}

		// Token: 0x06027896 RID: 161942 RVA: 0x00568CB3 File Offset: 0x00566EB3
		public void UnPackTo(IPatrolPositionRefreshT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027897 RID: 161943 RVA: 0x00568CC4 File Offset: 0x00566EC4
		public static Offset<IPatrolPositionRefresh> Pack(FlatBufferBuilder builder, IPatrolPositionRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolPositionRefresh>);
			}
			return IPatrolPositionRefresh.CreateIPatrolPositionRefresh(builder, _o.Type);
		}

		// Token: 0x0400F839 RID: 63545
		private Table __p;
	}
}
