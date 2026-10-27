using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007439 RID: 29753
	public struct ITransform : IFlatbufferObject
	{
		// Token: 0x1700E1E3 RID: 57827
		// (get) Token: 0x060360CA RID: 221386 RVA: 0x00759F2C File Offset: 0x0075812C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060360CB RID: 221387 RVA: 0x00759F39 File Offset: 0x00758139
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060360CC RID: 221388 RVA: 0x00759F40 File Offset: 0x00758140
		public static ITransform GetRootAsITransform(ByteBuffer _bb)
		{
			return ITransform.GetRootAsITransform(_bb, default(ITransform));
		}

		// Token: 0x060360CD RID: 221389 RVA: 0x00759F5C File Offset: 0x0075815C
		public static ITransform GetRootAsITransform(ByteBuffer _bb, ITransform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060360CE RID: 221390 RVA: 0x00759F79 File Offset: 0x00758179
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060360CF RID: 221391 RVA: 0x00759F88 File Offset: 0x00758188
		public ITransform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1E4 RID: 57828
		// (get) Token: 0x060360D0 RID: 221392 RVA: 0x00759F98 File Offset: 0x00758198
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

		// Token: 0x1700E1E5 RID: 57829
		// (get) Token: 0x060360D1 RID: 221393 RVA: 0x00759FF8 File Offset: 0x007581F8
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

		// Token: 0x1700E1E6 RID: 57830
		// (get) Token: 0x060360D2 RID: 221394 RVA: 0x0075A058 File Offset: 0x00758258
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

		// Token: 0x1700E1E7 RID: 57831
		// (get) Token: 0x060360D3 RID: 221395 RVA: 0x0075A0B8 File Offset: 0x007582B8
		public bool _Folded
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E1E8 RID: 57832
		// (get) Token: 0x060360D4 RID: 221396 RVA: 0x0075A0F8 File Offset: 0x007582F8
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

		// Token: 0x060360D5 RID: 221397 RVA: 0x0075A135 File Offset: 0x00758335
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

		// Token: 0x060360D6 RID: 221398 RVA: 0x0075A169 File Offset: 0x00758369
		public static void StartITransform(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060360D7 RID: 221399 RVA: 0x0075A172 File Offset: 0x00758372
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x060360D8 RID: 221400 RVA: 0x0075A182 File Offset: 0x00758382
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x060360D9 RID: 221401 RVA: 0x0075A192 File Offset: 0x00758392
		public static void AddScale(FlatBufferBuilder builder, Offset<IVectorInfo> scaleOffset)
		{
			builder.AddOffset(2, scaleOffset.Value, 0);
		}

		// Token: 0x060360DA RID: 221402 RVA: 0x0075A1A2 File Offset: 0x007583A2
		public static void Add_Folded(FlatBufferBuilder builder, bool _Folded)
		{
			builder.AddBool(3, _Folded, false);
		}

		// Token: 0x060360DB RID: 221403 RVA: 0x0075A1AD File Offset: 0x007583AD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060360DC RID: 221404 RVA: 0x0075A1B8 File Offset: 0x007583B8
		public static Offset<ITransform> EndITransform(FlatBufferBuilder builder)
		{
			return new Offset<ITransform>(builder.EndTable());
		}

		// Token: 0x060360DD RID: 221405 RVA: 0x0075A1C8 File Offset: 0x007583C8
		public ITransformT UnPack()
		{
			ITransformT transformT = new ITransformT();
			this.UnPackTo(transformT);
			return transformT;
		}

		// Token: 0x060360DE RID: 221406 RVA: 0x0075A1E4 File Offset: 0x007583E4
		public void UnPackTo(ITransformT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.Scale = ((this.Scale != null) ? this.Scale.Value.UnPack() : null);
			_o._Folded = this._Folded;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060360DF RID: 221407 RVA: 0x0075A298 File Offset: 0x00758498
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

		// Token: 0x040122B5 RID: 74421
		private Table __p;
	}
}
