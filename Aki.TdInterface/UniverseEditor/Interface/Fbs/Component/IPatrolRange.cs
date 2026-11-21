using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D14 RID: 23828
	public struct IPatrolRange : IFlatbufferObject
	{
		// Token: 0x1700AF05 RID: 44805
		// (get) Token: 0x06027924 RID: 162084 RVA: 0x00569B9E File Offset: 0x00567D9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027925 RID: 162085 RVA: 0x00569BAB File Offset: 0x00567DAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027926 RID: 162086 RVA: 0x00569BB4 File Offset: 0x00567DB4
		public static IPatrolRange GetRootAsIPatrolRange(ByteBuffer _bb)
		{
			return IPatrolRange.GetRootAsIPatrolRange(_bb, default(IPatrolRange));
		}

		// Token: 0x06027927 RID: 162087 RVA: 0x00569BD0 File Offset: 0x00567DD0
		public static IPatrolRange GetRootAsIPatrolRange(ByteBuffer _bb, IPatrolRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027928 RID: 162088 RVA: 0x00569BED File Offset: 0x00567DED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027929 RID: 162089 RVA: 0x00569BFC File Offset: 0x00567DFC
		public IPatrolRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF06 RID: 44806
		// (get) Token: 0x0602792A RID: 162090 RVA: 0x00569C0C File Offset: 0x00567E0C
		public IVectorInfo? Center
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF07 RID: 44807
		// (get) Token: 0x0602792B RID: 162091 RVA: 0x00569C6C File Offset: 0x00567E6C
		public int Radius
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

		// Token: 0x0602792C RID: 162092 RVA: 0x00569CA8 File Offset: 0x00567EA8
		public static Offset<IPatrolRange> CreateIPatrolRange(FlatBufferBuilder builder, Offset<IVectorInfo> CenterOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(2);
			IPatrolRange.AddRadius(builder, Radius);
			IPatrolRange.AddCenter(builder, CenterOffset);
			return IPatrolRange.EndIPatrolRange(builder);
		}

		// Token: 0x0602792D RID: 162093 RVA: 0x00569CC5 File Offset: 0x00567EC5
		public static void StartIPatrolRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602792E RID: 162094 RVA: 0x00569CCE File Offset: 0x00567ECE
		public static void AddCenter(FlatBufferBuilder builder, Offset<IVectorInfo> centerOffset)
		{
			builder.AddOffset(0, centerOffset.Value, 0);
		}

		// Token: 0x0602792F RID: 162095 RVA: 0x00569CDE File Offset: 0x00567EDE
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(1, radius, 0);
		}

		// Token: 0x06027930 RID: 162096 RVA: 0x00569CE9 File Offset: 0x00567EE9
		public static Offset<IPatrolRange> EndIPatrolRange(FlatBufferBuilder builder)
		{
			return new Offset<IPatrolRange>(builder.EndTable());
		}

		// Token: 0x06027931 RID: 162097 RVA: 0x00569CF8 File Offset: 0x00567EF8
		public IPatrolRangeT UnPack()
		{
			IPatrolRangeT patrolRangeT = new IPatrolRangeT();
			this.UnPackTo(patrolRangeT);
			return patrolRangeT;
		}

		// Token: 0x06027932 RID: 162098 RVA: 0x00569D14 File Offset: 0x00567F14
		public void UnPackTo(IPatrolRangeT _o)
		{
			_o.Center = ((this.Center != null) ? this.Center.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06027933 RID: 162099 RVA: 0x00569D5C File Offset: 0x00567F5C
		public static Offset<IPatrolRange> Pack(FlatBufferBuilder builder, IPatrolRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPatrolRange>);
			}
			Offset<IVectorInfo> centerOffset = (_o.Center == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Center);
			return IPatrolRange.CreateIPatrolRange(builder, centerOffset, _o.Radius);
		}

		// Token: 0x0400F853 RID: 63571
		private Table __p;
	}
}
