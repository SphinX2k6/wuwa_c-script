using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007112 RID: 28946
	public struct ISimpleMove : IFlatbufferObject
	{
		// Token: 0x1700D729 RID: 55081
		// (get) Token: 0x0603350D RID: 210189 RVA: 0x006EAF0A File Offset: 0x006E910A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603350E RID: 210190 RVA: 0x006EAF17 File Offset: 0x006E9117
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603350F RID: 210191 RVA: 0x006EAF20 File Offset: 0x006E9120
		public static ISimpleMove GetRootAsISimpleMove(ByteBuffer _bb)
		{
			return ISimpleMove.GetRootAsISimpleMove(_bb, default(ISimpleMove));
		}

		// Token: 0x06033510 RID: 210192 RVA: 0x006EAF3C File Offset: 0x006E913C
		public static ISimpleMove GetRootAsISimpleMove(ByteBuffer _bb, ISimpleMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033511 RID: 210193 RVA: 0x006EAF59 File Offset: 0x006E9159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033512 RID: 210194 RVA: 0x006EAF68 File Offset: 0x006E9168
		public ISimpleMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D72A RID: 55082
		// (get) Token: 0x06033513 RID: 210195 RVA: 0x006EAF78 File Offset: 0x006E9178
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

		// Token: 0x1700D72B RID: 55083
		// (get) Token: 0x06033514 RID: 210196 RVA: 0x006EAFB4 File Offset: 0x006E91B4
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

		// Token: 0x1700D72C RID: 55084
		// (get) Token: 0x06033515 RID: 210197 RVA: 0x006EAFF4 File Offset: 0x006E91F4
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

		// Token: 0x06033516 RID: 210198 RVA: 0x006EB051 File Offset: 0x006E9251
		public static Offset<ISimpleMove> CreateISimpleMove(FlatBufferBuilder builder, int Who = 0, float UseTime = 0f, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(3);
			ISimpleMove.AddPos(builder, PosOffset);
			ISimpleMove.AddUseTime(builder, UseTime);
			ISimpleMove.AddWho(builder, Who);
			return ISimpleMove.EndISimpleMove(builder);
		}

		// Token: 0x06033517 RID: 210199 RVA: 0x006EB075 File Offset: 0x006E9275
		public static void StartISimpleMove(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033518 RID: 210200 RVA: 0x006EB07E File Offset: 0x006E927E
		public static void AddWho(FlatBufferBuilder builder, int who)
		{
			builder.AddInt(0, who, 0);
		}

		// Token: 0x06033519 RID: 210201 RVA: 0x006EB089 File Offset: 0x006E9289
		public static void AddUseTime(FlatBufferBuilder builder, float useTime)
		{
			builder.AddFloat(1, useTime, 0.0);
		}

		// Token: 0x0603351A RID: 210202 RVA: 0x006EB09C File Offset: 0x006E929C
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0603351B RID: 210203 RVA: 0x006EB0AC File Offset: 0x006E92AC
		public static Offset<ISimpleMove> EndISimpleMove(FlatBufferBuilder builder)
		{
			return new Offset<ISimpleMove>(builder.EndTable());
		}

		// Token: 0x0603351C RID: 210204 RVA: 0x006EB0BC File Offset: 0x006E92BC
		public ISimpleMoveT UnPack()
		{
			ISimpleMoveT simpleMoveT = new ISimpleMoveT();
			this.UnPackTo(simpleMoveT);
			return simpleMoveT;
		}

		// Token: 0x0603351D RID: 210205 RVA: 0x006EB0D8 File Offset: 0x006E92D8
		public void UnPackTo(ISimpleMoveT _o)
		{
			_o.Who = this.Who;
			_o.UseTime = this.UseTime;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0603351E RID: 210206 RVA: 0x006EB12C File Offset: 0x006E932C
		public static Offset<ISimpleMove> Pack(FlatBufferBuilder builder, ISimpleMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISimpleMove>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ISimpleMove.CreateISimpleMove(builder, _o.Who, _o.UseTime, posOffset);
		}

		// Token: 0x04011BA0 RID: 72608
		private Table __p;
	}
}
