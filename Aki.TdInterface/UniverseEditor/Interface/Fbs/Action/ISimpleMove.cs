using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078DE RID: 30942
	public struct ISimpleMove : IFlatbufferObject
	{
		// Token: 0x1700E30C RID: 58124
		// (get) Token: 0x060367AF RID: 223151 RVA: 0x0074B516 File Offset: 0x00749716
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060367B0 RID: 223152 RVA: 0x0074B523 File Offset: 0x00749723
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060367B1 RID: 223153 RVA: 0x0074B52C File Offset: 0x0074972C
		public static ISimpleMove GetRootAsISimpleMove(ByteBuffer _bb)
		{
			return ISimpleMove.GetRootAsISimpleMove(_bb, default(ISimpleMove));
		}

		// Token: 0x060367B2 RID: 223154 RVA: 0x0074B548 File Offset: 0x00749748
		public static ISimpleMove GetRootAsISimpleMove(ByteBuffer _bb, ISimpleMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060367B3 RID: 223155 RVA: 0x0074B565 File Offset: 0x00749765
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060367B4 RID: 223156 RVA: 0x0074B574 File Offset: 0x00749774
		public ISimpleMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E30D RID: 58125
		// (get) Token: 0x060367B5 RID: 223157 RVA: 0x0074B584 File Offset: 0x00749784
		public int Who
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

		// Token: 0x1700E30E RID: 58126
		// (get) Token: 0x060367B6 RID: 223158 RVA: 0x0074B5C0 File Offset: 0x007497C0
		public float UseTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E30F RID: 58127
		// (get) Token: 0x060367B7 RID: 223159 RVA: 0x0074B600 File Offset: 0x00749800
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060367B8 RID: 223160 RVA: 0x0074B65D File Offset: 0x0074985D
		public static Offset<ISimpleMove> CreateISimpleMove(FlatBufferBuilder builder, int Who = 0, float UseTime = 0f, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISimpleMove.AddPos(builder, PosOffset);
			ISimpleMove.AddUseTime(builder, UseTime);
			ISimpleMove.AddWho(builder, Who);
			return ISimpleMove.EndISimpleMove(builder);
		}

		// Token: 0x060367B9 RID: 223161 RVA: 0x0074B681 File Offset: 0x00749881
		public static void StartISimpleMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060367BA RID: 223162 RVA: 0x0074B68A File Offset: 0x0074988A
		public static void AddWho(FlatBufferBuilder builder, int who)
		{
			builder.AddInt(0, who, 0);
		}

		// Token: 0x060367BB RID: 223163 RVA: 0x0074B695 File Offset: 0x00749895
		public static void AddUseTime(FlatBufferBuilder builder, float useTime)
		{
			builder.AddFloat(1, useTime, 0.0);
		}

		// Token: 0x060367BC RID: 223164 RVA: 0x0074B6A8 File Offset: 0x007498A8
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x060367BD RID: 223165 RVA: 0x0074B6B8 File Offset: 0x007498B8
		public static Offset<ISimpleMove> EndISimpleMove(FlatBufferBuilder builder)
		{
			return new Offset<ISimpleMove>(builder.EndTable());
		}

		// Token: 0x060367BE RID: 223166 RVA: 0x0074B6C8 File Offset: 0x007498C8
		public ISimpleMoveT UnPack()
		{
			ISimpleMoveT simpleMoveT = new ISimpleMoveT();
			this.UnPackTo(simpleMoveT);
			return simpleMoveT;
		}

		// Token: 0x060367BF RID: 223167 RVA: 0x0074B6E4 File Offset: 0x007498E4
		public void UnPackTo(ISimpleMoveT _o)
		{
			_o.Who = this.Who;
			_o.UseTime = this.UseTime;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x060367C0 RID: 223168 RVA: 0x0074B738 File Offset: 0x00749938
		public static Offset<ISimpleMove> Pack(FlatBufferBuilder builder, ISimpleMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISimpleMove>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ISimpleMove.CreateISimpleMove(builder, _o.Who, _o.UseTime, posOffset);
		}

		// Token: 0x04012B8E RID: 76686
		private Table __p;
	}
}
