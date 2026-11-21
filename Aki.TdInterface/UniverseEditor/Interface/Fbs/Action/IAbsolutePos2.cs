using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C7 RID: 26311
	public struct IAbsolutePos2 : IFlatbufferObject
	{
		// Token: 0x1700BF3D RID: 48957
		// (get) Token: 0x0602C32C RID: 181036 RVA: 0x00604E28 File Offset: 0x00603028
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C32D RID: 181037 RVA: 0x00604E35 File Offset: 0x00603035
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C32E RID: 181038 RVA: 0x00604E3C File Offset: 0x0060303C
		public static IAbsolutePos2 GetRootAsIAbsolutePos2(ByteBuffer _bb)
		{
			return IAbsolutePos2.GetRootAsIAbsolutePos2(_bb, default(IAbsolutePos2));
		}

		// Token: 0x0602C32F RID: 181039 RVA: 0x00604E58 File Offset: 0x00603058
		public static IAbsolutePos2 GetRootAsIAbsolutePos2(ByteBuffer _bb, IAbsolutePos2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C330 RID: 181040 RVA: 0x00604E75 File Offset: 0x00603075
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C331 RID: 181041 RVA: 0x00604E84 File Offset: 0x00603084
		public IAbsolutePos2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF3E RID: 48958
		// (get) Token: 0x0602C332 RID: 181042 RVA: 0x00604E94 File Offset: 0x00603094
		public EPos2 Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPos2.Player;
				}
				return (EPos2)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BF3F RID: 48959
		// (get) Token: 0x0602C333 RID: 181043 RVA: 0x00604ED0 File Offset: 0x006030D0
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602C334 RID: 181044 RVA: 0x00604F2D File Offset: 0x0060312D
		public static Offset<IAbsolutePos2> CreateIAbsolutePos2(FlatBufferBuilder builder, EPos2 Type = EPos2.Player, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IAbsolutePos2.AddPos(builder, PosOffset);
			IAbsolutePos2.AddType(builder, Type);
			return IAbsolutePos2.EndIAbsolutePos2(builder);
		}

		// Token: 0x0602C335 RID: 181045 RVA: 0x00604F4A File Offset: 0x0060314A
		public static void StartIAbsolutePos2(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C336 RID: 181046 RVA: 0x00604F53 File Offset: 0x00603153
		public static void AddType(FlatBufferBuilder builder, EPos2 type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C337 RID: 181047 RVA: 0x00604F5E File Offset: 0x0060315E
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0602C338 RID: 181048 RVA: 0x00604F6E File Offset: 0x0060316E
		public static Offset<IAbsolutePos2> EndIAbsolutePos2(FlatBufferBuilder builder)
		{
			return new Offset<IAbsolutePos2>(builder.EndTable());
		}

		// Token: 0x0602C339 RID: 181049 RVA: 0x00604F7C File Offset: 0x0060317C
		public IAbsolutePos2T UnPack()
		{
			IAbsolutePos2T absolutePos2T = new IAbsolutePos2T();
			this.UnPackTo(absolutePos2T);
			return absolutePos2T;
		}

		// Token: 0x0602C33A RID: 181050 RVA: 0x00604F98 File Offset: 0x00603198
		public void UnPackTo(IAbsolutePos2T _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602C33B RID: 181051 RVA: 0x00604FE0 File Offset: 0x006031E0
		public static Offset<IAbsolutePos2> Pack(FlatBufferBuilder builder, IAbsolutePos2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IAbsolutePos2>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IAbsolutePos2.CreateIAbsolutePos2(builder, _o.Type, posOffset);
		}

		// Token: 0x0401101A RID: 69658
		private Table __p;
	}
}
