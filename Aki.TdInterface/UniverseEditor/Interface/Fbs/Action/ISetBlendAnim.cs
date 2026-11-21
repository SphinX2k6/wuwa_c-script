using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007797 RID: 30615
	public struct ISetBlendAnim : IFlatbufferObject
	{
		// Token: 0x1700E04F RID: 57423
		// (get) Token: 0x06035BC9 RID: 220105 RVA: 0x00733226 File Offset: 0x00731426
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035BCA RID: 220106 RVA: 0x00733233 File Offset: 0x00731433
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035BCB RID: 220107 RVA: 0x0073323C File Offset: 0x0073143C
		public static ISetBlendAnim GetRootAsISetBlendAnim(ByteBuffer _bb)
		{
			return ISetBlendAnim.GetRootAsISetBlendAnim(_bb, default(ISetBlendAnim));
		}

		// Token: 0x06035BCC RID: 220108 RVA: 0x00733258 File Offset: 0x00731458
		public static ISetBlendAnim GetRootAsISetBlendAnim(ByteBuffer _bb, ISetBlendAnim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035BCD RID: 220109 RVA: 0x00733275 File Offset: 0x00731475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035BCE RID: 220110 RVA: 0x00733284 File Offset: 0x00731484
		public ISetBlendAnim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E050 RID: 57424
		// (get) Token: 0x06035BCF RID: 220111 RVA: 0x00733294 File Offset: 0x00731494
		public IPlayerBlendAnimTarget? Target
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPlayerBlendAnimTarget?(default(IPlayerBlendAnimTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E051 RID: 57425
		// (get) Token: 0x06035BD0 RID: 220112 RVA: 0x007332F4 File Offset: 0x007314F4
		public TBlendAnimType BlendTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TBlendAnimType.NONE;
				}
				return (TBlendAnimType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035BD1 RID: 220113 RVA: 0x00733330 File Offset: 0x00731530
		public TTable? BlendType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035BD2 RID: 220114 RVA: 0x00733374 File Offset: 0x00731574
		public ISetAnimSequenceBlendAnimType BlendTypeAsISetAnimSequenceBlendAnimType()
		{
			return this.BlendType<ISetAnimSequenceBlendAnimType>().Value;
		}

		// Token: 0x06035BD3 RID: 220115 RVA: 0x00733390 File Offset: 0x00731590
		public ISetStateMachineBlendAnimType BlendTypeAsISetStateMachineBlendAnimType()
		{
			return this.BlendType<ISetStateMachineBlendAnimType>().Value;
		}

		// Token: 0x06035BD4 RID: 220116 RVA: 0x007333AB File Offset: 0x007315AB
		public static Offset<ISetBlendAnim> CreateISetBlendAnim(FlatBufferBuilder builder, Offset<IPlayerBlendAnimTarget> TargetOffset = default(Offset<IPlayerBlendAnimTarget>), TBlendAnimType BlendType_type = TBlendAnimType.NONE, int BlendTypeOffset = 0)
		{
			builder.StartTable(3);
			ISetBlendAnim.AddBlendType(builder, BlendTypeOffset);
			ISetBlendAnim.AddTarget(builder, TargetOffset);
			ISetBlendAnim.AddBlendTypeType(builder, BlendType_type);
			return ISetBlendAnim.EndISetBlendAnim(builder);
		}

		// Token: 0x06035BD5 RID: 220117 RVA: 0x007333CF File Offset: 0x007315CF
		public static void StartISetBlendAnim(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06035BD6 RID: 220118 RVA: 0x007333D8 File Offset: 0x007315D8
		public static void AddTarget(FlatBufferBuilder builder, Offset<IPlayerBlendAnimTarget> targetOffset)
		{
			builder.AddOffset(0, targetOffset.Value, 0);
		}

		// Token: 0x06035BD7 RID: 220119 RVA: 0x007333E8 File Offset: 0x007315E8
		public static void AddBlendTypeType(FlatBufferBuilder builder, TBlendAnimType blendTypeType)
		{
			builder.AddByte(1, (byte)blendTypeType, 0);
		}

		// Token: 0x06035BD8 RID: 220120 RVA: 0x007333F3 File Offset: 0x007315F3
		public static void AddBlendType(FlatBufferBuilder builder, int blendTypeOffset)
		{
			builder.AddOffset(2, blendTypeOffset, 0);
		}

		// Token: 0x06035BD9 RID: 220121 RVA: 0x007333FE File Offset: 0x007315FE
		public static Offset<ISetBlendAnim> EndISetBlendAnim(FlatBufferBuilder builder)
		{
			return new Offset<ISetBlendAnim>(builder.EndTable());
		}

		// Token: 0x06035BDA RID: 220122 RVA: 0x0073340C File Offset: 0x0073160C
		public ISetBlendAnimT UnPack()
		{
			ISetBlendAnimT setBlendAnimT = new ISetBlendAnimT();
			this.UnPackTo(setBlendAnimT);
			return setBlendAnimT;
		}

		// Token: 0x06035BDB RID: 220123 RVA: 0x00733428 File Offset: 0x00731628
		public void UnPackTo(ISetBlendAnimT _o)
		{
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.BlendType = new TBlendAnimTypeUnion();
			_o.BlendType.Type = this.BlendTypeType;
			TBlendAnimType blendTypeType = this.BlendTypeType;
			if (blendTypeType == TBlendAnimType.ISetAnimSequenceBlendAnimType)
			{
				_o.BlendType.Value = ((this.BlendType<ISetAnimSequenceBlendAnimType>() != null) ? this.BlendType<ISetAnimSequenceBlendAnimType>().Value.UnPack() : null);
				return;
			}
			if (blendTypeType != TBlendAnimType.ISetStateMachineBlendAnimType)
			{
				return;
			}
			_o.BlendType.Value = ((this.BlendType<ISetStateMachineBlendAnimType>() != null) ? this.BlendType<ISetStateMachineBlendAnimType>().Value.UnPack() : null);
		}

		// Token: 0x06035BDC RID: 220124 RVA: 0x00733500 File Offset: 0x00731700
		public static Offset<ISetBlendAnim> Pack(FlatBufferBuilder builder, ISetBlendAnimT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetBlendAnim>);
			}
			Offset<IPlayerBlendAnimTarget> targetOffset = (_o.Target == null) ? default(Offset<IPlayerBlendAnimTarget>) : IPlayerBlendAnimTarget.Pack(builder, _o.Target);
			TBlendAnimType blendType_type = (_o.BlendType == null) ? TBlendAnimType.NONE : _o.BlendType.Type;
			int blendTypeOffset = (_o.BlendType == null) ? 0 : TBlendAnimTypeUnion.Pack(builder, _o.BlendType);
			return ISetBlendAnim.CreateISetBlendAnim(builder, targetOffset, blendType_type, blendTypeOffset);
		}

		// Token: 0x040129BD RID: 76221
		private Table __p;
	}
}
