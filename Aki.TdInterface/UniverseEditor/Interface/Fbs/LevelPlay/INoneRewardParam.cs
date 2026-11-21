using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200499B RID: 18843
	public struct INoneRewardParam : IFlatbufferObject
	{
		// Token: 0x170083E7 RID: 33767
		// (get) Token: 0x0601C212 RID: 115218 RVA: 0x003F96C1 File Offset: 0x003F78C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C213 RID: 115219 RVA: 0x003F96CE File Offset: 0x003F78CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C214 RID: 115220 RVA: 0x003F96D8 File Offset: 0x003F78D8
		public static INoneRewardParam GetRootAsINoneRewardParam(ByteBuffer _bb)
		{
			return INoneRewardParam.GetRootAsINoneRewardParam(_bb, default(INoneRewardParam));
		}

		// Token: 0x0601C215 RID: 115221 RVA: 0x003F96F4 File Offset: 0x003F78F4
		public static INoneRewardParam GetRootAsINoneRewardParam(ByteBuffer _bb, INoneRewardParam obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C216 RID: 115222 RVA: 0x003F9711 File Offset: 0x003F7911
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C217 RID: 115223 RVA: 0x003F9720 File Offset: 0x003F7920
		public INoneRewardParam __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170083E8 RID: 33768
		// (get) Token: 0x0601C218 RID: 115224 RVA: 0x003F9730 File Offset: 0x003F7930
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

		// Token: 0x0601C219 RID: 115225 RVA: 0x003F976C File Offset: 0x003F796C
		public static Offset<INoneRewardParam> CreateINoneRewardParam(FlatBufferBuilder builder, ELevelPlayRewardType Type = ELevelPlayRewardType.None)
		{
			builder.StartTable(1);
			INoneRewardParam.AddType(builder, Type);
			return INoneRewardParam.EndINoneRewardParam(builder);
		}

		// Token: 0x0601C21A RID: 115226 RVA: 0x003F9782 File Offset: 0x003F7982
		public static void StartINoneRewardParam(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C21B RID: 115227 RVA: 0x003F978B File Offset: 0x003F798B
		public static void AddType(FlatBufferBuilder builder, ELevelPlayRewardType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C21C RID: 115228 RVA: 0x003F9796 File Offset: 0x003F7996
		public static Offset<INoneRewardParam> EndINoneRewardParam(FlatBufferBuilder builder)
		{
			return new Offset<INoneRewardParam>(builder.EndTable());
		}

		// Token: 0x0601C21D RID: 115229 RVA: 0x003F97A4 File Offset: 0x003F79A4
		public INoneRewardParamT UnPack()
		{
			INoneRewardParamT noneRewardParamT = new INoneRewardParamT();
			this.UnPackTo(noneRewardParamT);
			return noneRewardParamT;
		}

		// Token: 0x0601C21E RID: 115230 RVA: 0x003F97BF File Offset: 0x003F79BF
		public void UnPackTo(INoneRewardParamT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C21F RID: 115231 RVA: 0x003F97D0 File Offset: 0x003F79D0
		public static Offset<INoneRewardParam> Pack(FlatBufferBuilder builder, INoneRewardParamT _o)
		{
			if (_o == null)
			{
				return default(Offset<INoneRewardParam>);
			}
			return INoneRewardParam.CreateINoneRewardParam(builder, _o.Type);
		}

		// Token: 0x0400CFE7 RID: 53223
		private Table __p;
	}
}
