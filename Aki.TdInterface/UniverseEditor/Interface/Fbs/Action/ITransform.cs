using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C2C RID: 31788
	public struct ITransform : IFlatbufferObject
	{
		// Token: 0x1700EE00 RID: 60928
		// (get) Token: 0x060394B3 RID: 234675 RVA: 0x007BCC58 File Offset: 0x007BAE58
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060394B4 RID: 234676 RVA: 0x007BCC65 File Offset: 0x007BAE65
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060394B5 RID: 234677 RVA: 0x007BCC6C File Offset: 0x007BAE6C
		public static ITransform GetRootAsITransform(ByteBuffer _bb)
		{
			return ITransform.GetRootAsITransform(_bb, default(ITransform));
		}

		// Token: 0x060394B6 RID: 234678 RVA: 0x007BCC88 File Offset: 0x007BAE88
		public static ITransform GetRootAsITransform(ByteBuffer _bb, ITransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060394B7 RID: 234679 RVA: 0x007BCCA5 File Offset: 0x007BAEA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060394B8 RID: 234680 RVA: 0x007BCCB4 File Offset: 0x007BAEB4
		public ITransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EE01 RID: 60929
		// (get) Token: 0x060394B9 RID: 234681 RVA: 0x007BCCC4 File Offset: 0x007BAEC4
		public IVectorInfo? Pos
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

		// Token: 0x1700EE02 RID: 60930
		// (get) Token: 0x060394BA RID: 234682 RVA: 0x007BCD24 File Offset: 0x007BAF24
		public IVectorInfo? Rot
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

		// Token: 0x1700EE03 RID: 60931
		// (get) Token: 0x060394BB RID: 234683 RVA: 0x007BCD84 File Offset: 0x007BAF84
		public IVectorInfo? Scale
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

		// Token: 0x1700EE04 RID: 60932
		// (get) Token: 0x060394BC RID: 234684 RVA: 0x007BCDE4 File Offset: 0x007BAFE4
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EE05 RID: 60933
		// (get) Token: 0x060394BD RID: 234685 RVA: 0x007BCE24 File Offset: 0x007BB024
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060394BE RID: 234686 RVA: 0x007BCE61 File Offset: 0x007BB061
		public static Offset<ITransform> CreateITransform(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> ScaleOffset = default(Offset<IVectorInfo>), bool _folded = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			ITransform.AddScale(builder, ScaleOffset);
			ITransform.AddRot(builder, RotOffset);
			ITransform.AddPos(builder, PosOffset);
			ITransform.AddNullMask(builder, NullMask);
			ITransform.Add_Folded(builder, _folded);
			return ITransform.EndITransform(builder);
		}

		// Token: 0x060394BF RID: 234687 RVA: 0x007BCE95 File Offset: 0x007BB095
		public static void StartITransform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060394C0 RID: 234688 RVA: 0x007BCE9E File Offset: 0x007BB09E
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060394C1 RID: 234689 RVA: 0x007BCEAE File Offset: 0x007BB0AE
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x060394C2 RID: 234690 RVA: 0x007BCEBE File Offset: 0x007BB0BE
		public static void AddScale(FlatBufferBuilder builder, Offset<IVectorInfo> scaleOffset)
		{
			builder.AddOffset(2, scaleOffset.Value, 0);
		}

		// Token: 0x060394C3 RID: 234691 RVA: 0x007BCECE File Offset: 0x007BB0CE
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(3, _Folded, false);
		}

		// Token: 0x060394C4 RID: 234692 RVA: 0x007BCED9 File Offset: 0x007BB0D9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060394C5 RID: 234693 RVA: 0x007BCEE4 File Offset: 0x007BB0E4
		public static Offset<ITransform> EndITransform(FlatBufferBuilder builder)
		{
			return new Offset<ITransform>(builder.EndTable());
		}

		// Token: 0x060394C6 RID: 234694 RVA: 0x007BCEF4 File Offset: 0x007BB0F4
		public ITransformT UnPack()
		{
			ITransformT transformT = new ITransformT();
			this.UnPackTo(transformT);
			return transformT;
		}

		// Token: 0x060394C7 RID: 234695 RVA: 0x007BCF10 File Offset: 0x007BB110
		public void UnPackTo(ITransformT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
			_o._Folded = this._Folded;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060394C8 RID: 234696 RVA: 0x007BCFC4 File Offset: 0x007BB1C4
		public static Offset<ITransform> Pack(FlatBufferBuilder builder, ITransformT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITransform>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			Offset<IVectorInfo> scaleOffset = (_o.Scale == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Scale);
			return ITransform.CreateITransform(builder, posOffset, rotOffset, scaleOffset, _o._Folded, _o.NullMask);
		}

		// Token: 0x040132DC RID: 78556
		private Table __p;
	}
}
