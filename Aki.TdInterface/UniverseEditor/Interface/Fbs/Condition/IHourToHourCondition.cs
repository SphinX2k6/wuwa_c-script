using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005136 RID: 20790
	public struct IHourToHourCondition : IFlatbufferObject
	{
		// Token: 0x170094FC RID: 38140
		// (get) Token: 0x06020B1D RID: 133917 RVA: 0x00487BD3 File Offset: 0x00485DD3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B1E RID: 133918 RVA: 0x00487BE0 File Offset: 0x00485DE0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B1F RID: 133919 RVA: 0x00487BE8 File Offset: 0x00485DE8
		public static IHourToHourCondition GetRootAsIHourToHourCondition(ByteBuffer _bb)
		{
			return IHourToHourCondition.GetRootAsIHourToHourCondition(_bb, default(IHourToHourCondition));
		}

		// Token: 0x06020B20 RID: 133920 RVA: 0x00487C04 File Offset: 0x00485E04
		public static IHourToHourCondition GetRootAsIHourToHourCondition(ByteBuffer _bb, IHourToHourCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B21 RID: 133921 RVA: 0x00487C21 File Offset: 0x00485E21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B22 RID: 133922 RVA: 0x00487C30 File Offset: 0x00485E30
		public IHourToHourCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170094FD RID: 38141
		// (get) Token: 0x06020B23 RID: 133923 RVA: 0x00487C40 File Offset: 0x00485E40
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170094FE RID: 38142
		// (get) Token: 0x06020B24 RID: 133924 RVA: 0x00487C7C File Offset: 0x00485E7C
		public IHour? Start
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IHour?(default(IHour).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170094FF RID: 38143
		// (get) Token: 0x06020B25 RID: 133925 RVA: 0x00487CDC File Offset: 0x00485EDC
		public IHour? End
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IHour?(default(IHour).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009500 RID: 38144
		// (get) Token: 0x06020B26 RID: 133926 RVA: 0x00487D3C File Offset: 0x00485F3C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06020B27 RID: 133927 RVA: 0x00487D79 File Offset: 0x00485F79
		public static Offset<IHourToHourCondition> CreateIHourToHourCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, Offset<IHour> StartOffset = default(Offset<IHour>), Offset<IHour> EndOffset = default(Offset<IHour>), ECompare Compare = ECompare.Eq)
		{
			builder.StartTable(4);
			IHourToHourCondition.AddEnd(builder, EndOffset);
			IHourToHourCondition.AddStart(builder, StartOffset);
			IHourToHourCondition.AddCompare(builder, Compare);
			IHourToHourCondition.AddType(builder, Type);
			return IHourToHourCondition.EndIHourToHourCondition(builder);
		}

		// Token: 0x06020B28 RID: 133928 RVA: 0x00487DA5 File Offset: 0x00485FA5
		public static void StartIHourToHourCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020B29 RID: 133929 RVA: 0x00487DAE File Offset: 0x00485FAE
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020B2A RID: 133930 RVA: 0x00487DB9 File Offset: 0x00485FB9
		public static void AddStart(FlatBufferBuilder builder, Offset<IHour> startOffset)
		{
			builder.AddOffset(1, startOffset.Value, 0);
		}

		// Token: 0x06020B2B RID: 133931 RVA: 0x00487DC9 File Offset: 0x00485FC9
		public static void AddEnd(FlatBufferBuilder builder, Offset<IHour> endOffset)
		{
			builder.AddOffset(2, endOffset.Value, 0);
		}

		// Token: 0x06020B2C RID: 133932 RVA: 0x00487DD9 File Offset: 0x00485FD9
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(3, (byte)compare, 0);
		}

		// Token: 0x06020B2D RID: 133933 RVA: 0x00487DE4 File Offset: 0x00485FE4
		public static Offset<IHourToHourCondition> EndIHourToHourCondition(FlatBufferBuilder builder)
		{
			return new Offset<IHourToHourCondition>(builder.EndTable());
		}

		// Token: 0x06020B2E RID: 133934 RVA: 0x00487DF4 File Offset: 0x00485FF4
		public IHourToHourConditionT UnPack()
		{
			IHourToHourConditionT hourToHourConditionT = new IHourToHourConditionT();
			this.UnPackTo(hourToHourConditionT);
			return hourToHourConditionT;
		}

		// Token: 0x06020B2F RID: 133935 RVA: 0x00487E10 File Offset: 0x00486010
		public void UnPackTo(IHourToHourConditionT _o)
		{
			_o.Type = this.Type;
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
			_o.Compare = this.Compare;
		}

		// Token: 0x06020B30 RID: 133936 RVA: 0x00487E94 File Offset: 0x00486094
		public static Offset<IHourToHourCondition> Pack(FlatBufferBuilder builder, IHourToHourConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHourToHourCondition>);
			}
			Offset<IHour> startOffset = (_o.Start == null) ? default(Offset<IHour>) : IHour.Pack(builder, _o.Start);
			Offset<IHour> endOffset = (_o.End == null) ? default(Offset<IHour>) : IHour.Pack(builder, _o.End);
			return IHourToHourCondition.CreateIHourToHourCondition(builder, _o.Type, startOffset, endOffset, _o.Compare);
		}

		// Token: 0x0400E107 RID: 57607
		private Table __p;
	}
}
