using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004533 RID: 17715
	public struct INoneRewardParam : IFlatbufferObject
	{
		// Token: 0x17007DA6 RID: 32166
		// (get) Token: 0x0601AA3D RID: 109117 RVA: 0x003CD425 File Offset: 0x003CB625
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AA3E RID: 109118 RVA: 0x003CD432 File Offset: 0x003CB632
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AA3F RID: 109119 RVA: 0x003CD43C File Offset: 0x003CB63C
		public static INoneRewardParam GetRootAsINoneRewardParam(ByteBuffer _bb)
		{
			return INoneRewardParam.GetRootAsINoneRewardParam(_bb, default(INoneRewardParam));
		}

		// Token: 0x0601AA40 RID: 109120 RVA: 0x003CD458 File Offset: 0x003CB658
		public static INoneRewardParam GetRootAsINoneRewardParam(ByteBuffer _bb, INoneRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AA41 RID: 109121 RVA: 0x003CD475 File Offset: 0x003CB675
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AA42 RID: 109122 RVA: 0x003CD484 File Offset: 0x003CB684
		public INoneRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DA7 RID: 32167
		// (get) Token: 0x0601AA43 RID: 109123 RVA: 0x003CD494 File Offset: 0x003CB694
		public ELevelPlayRewardType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelPlayRewardType.None;
				}
				return (ELevelPlayRewardType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AA44 RID: 109124 RVA: 0x003CD4D0 File Offset: 0x003CB6D0
		public static Offset<INoneRewardParam> CreateINoneRewardParam(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None)
		{
			builder.StartTable(1);
			INoneRewardParam.AddType(builder, Type);
			return INoneRewardParam.EndINoneRewardParam(builder);
		}

		// Token: 0x0601AA45 RID: 109125 RVA: 0x003CD4E6 File Offset: 0x003CB6E6
		public static void StartINoneRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601AA46 RID: 109126 RVA: 0x003CD4EF File Offset: 0x003CB6EF
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AA47 RID: 109127 RVA: 0x003CD4FA File Offset: 0x003CB6FA
		public static Offset<INoneRewardParam> EndINoneRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<INoneRewardParam>(builder.EndTable());
		}

		// Token: 0x0601AA48 RID: 109128 RVA: 0x003CD508 File Offset: 0x003CB708
		public INoneRewardParamT UnPack()
		{
			INoneRewardParamT noneRewardParamT = new INoneRewardParamT();
			this.UnPackTo(noneRewardParamT);
			return noneRewardParamT;
		}

		// Token: 0x0601AA49 RID: 109129 RVA: 0x003CD523 File Offset: 0x003CB723
		public void UnPackTo(INoneRewardParamT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601AA4A RID: 109130 RVA: 0x003CD534 File Offset: 0x003CB734
		public static Offset<INoneRewardParam> Pack(FlatBufferBuilder builder, INoneRewardParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoneRewardParam>);
			}
			return INoneRewardParam.CreateINoneRewardParam(builder, _o.Type);
		}

		// Token: 0x0400C5B8 RID: 50616
		private Table __p;
	}
}
