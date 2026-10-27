using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCE RID: 28622
	public struct ISetBlendAnim : IFlatbufferObject
	{
		// Token: 0x1700D47B RID: 54395
		// (get) Token: 0x06032963 RID: 207203 RVA: 0x006D35E2 File Offset: 0x006D17E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032964 RID: 207204 RVA: 0x006D35EF File Offset: 0x006D17EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032965 RID: 207205 RVA: 0x006D35F8 File Offset: 0x006D17F8
		public static ISetBlendAnim GetRootAsISetBlendAnim(ByteBuffer _bb)
		{
			return ISetBlendAnim.GetRootAsISetBlendAnim(_bb, default(ISetBlendAnim));
		}

		// Token: 0x06032966 RID: 207206 RVA: 0x006D3614 File Offset: 0x006D1814
		public static ISetBlendAnim GetRootAsISetBlendAnim(ByteBuffer _bb, ISetBlendAnim obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032967 RID: 207207 RVA: 0x006D3631 File Offset: 0x006D1831
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032968 RID: 207208 RVA: 0x006D3640 File Offset: 0x006D1840
		public ISetBlendAnim __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D47C RID: 54396
		// (get) Token: 0x06032969 RID: 207209 RVA: 0x006D3650 File Offset: 0x006D1850
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

		// Token: 0x1700D47D RID: 54397
		// (get) Token: 0x0603296A RID: 207210 RVA: 0x006D36B0 File Offset: 0x006D18B0
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

		// Token: 0x0603296B RID: 207211 RVA: 0x006D36EC File Offset: 0x006D18EC
		public TTable? BlendType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603296C RID: 207212 RVA: 0x006D3730 File Offset: 0x006D1930
		public ISetAnimSequenceBlendAnimType BlendTypeAsISetAnimSequenceBlendAnimType()
		{
			return this.BlendType<ISetAnimSequenceBlendAnimType>().Value;
		}

		// Token: 0x0603296D RID: 207213 RVA: 0x006D374C File Offset: 0x006D194C
		public ISetStateMachineBlendAnimType BlendTypeAsISetStateMachineBlendAnimType()
		{
			return this.BlendType<ISetStateMachineBlendAnimType>().Value;
		}

		// Token: 0x0603296E RID: 207214 RVA: 0x006D3767 File Offset: 0x006D1967
		public static Offset<ISetBlendAnim> CreateISetBlendAnim(FlatBufferBuilder builder, Offset<IPlayerBlendAnimTarget> TargetOffset = default(Offset<IPlayerBlendAnimTarget>), TBlendAnimType BlendType_type = TBlendAnimType.NONE, int BlendTypeOffset = 0)
		{
			builder.StartTable(3);
			ISetBlendAnim.AddBlendType(builder, BlendTypeOffset);
			ISetBlendAnim.AddTarget(builder, TargetOffset);
			ISetBlendAnim.AddBlendTypeType(builder, BlendType_type);
			return ISetBlendAnim.EndISetBlendAnim(builder);
		}

		// Token: 0x0603296F RID: 207215 RVA: 0x006D378B File Offset: 0x006D198B
		public static void StartISetBlendAnim(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032970 RID: 207216 RVA: 0x006D3794 File Offset: 0x006D1994
		public static void AddTarget(FlatBufferBuilder builder, Offset<IPlayerBlendAnimTarget> targetOffset)
		{
			builder.AddOffset(0, targetOffset.Value, 0);
		}

		// Token: 0x06032971 RID: 207217 RVA: 0x006D37A4 File Offset: 0x006D19A4
		public static void AddBlendTypeType(FlatBufferBuilder builder, TBlendAnimType blendTypeType)
		{
			builder.AddByte(1, (byte)blendTypeType, 0);
		}

		// Token: 0x06032972 RID: 207218 RVA: 0x006D37AF File Offset: 0x006D19AF
		public static void AddBlendType(FlatBufferBuilder builder, int blendTypeOffset)
		{
			builder.AddOffset(2, blendTypeOffset, 0);
		}

		// Token: 0x06032973 RID: 207219 RVA: 0x006D37BA File Offset: 0x006D19BA
		public static Offset<ISetBlendAnim> EndISetBlendAnim(FlatBufferBuilder builder)
		{
			return new Offset<ISetBlendAnim>(builder.EndTable());
		}

		// Token: 0x06032974 RID: 207220 RVA: 0x006D37C8 File Offset: 0x006D19C8
		public ISetBlendAnimT UnPack()
		{
			ISetBlendAnimT setBlendAnimT = new ISetBlendAnimT();
			this.UnPackTo(setBlendAnimT);
			return setBlendAnimT;
		}

		// Token: 0x06032975 RID: 207221 RVA: 0x006D37E4 File Offset: 0x006D19E4
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

		// Token: 0x06032976 RID: 207222 RVA: 0x006D38BC File Offset: 0x006D1ABC
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

		// Token: 0x040119D8 RID: 72152
		private Table __p;
	}
}
