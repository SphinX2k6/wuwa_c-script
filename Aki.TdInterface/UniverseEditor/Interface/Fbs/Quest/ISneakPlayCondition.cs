using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004574 RID: 17780
	public struct ISneakPlayCondition : IFlatbufferObject
	{
		// Token: 0x17007C44 RID: 31812
		// (get) Token: 0x06019E4F RID: 106063 RVA: 0x003B18E5 File Offset: 0x003AFAE5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019E50 RID: 106064 RVA: 0x003B18F2 File Offset: 0x003AFAF2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019E51 RID: 106065 RVA: 0x003B18FC File Offset: 0x003AFAFC
		public static ISneakPlayCondition GetRootAsISneakPlayCondition(ByteBuffer _bb)
		{
			return ISneakPlayCondition.GetRootAsISneakPlayCondition(_bb, default(ISneakPlayCondition));
		}

		// Token: 0x06019E52 RID: 106066 RVA: 0x003B1918 File Offset: 0x003AFB18
		public static ISneakPlayCondition GetRootAsISneakPlayCondition(ByteBuffer _bb, ISneakPlayCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019E53 RID: 106067 RVA: 0x003B1935 File Offset: 0x003AFB35
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019E54 RID: 106068 RVA: 0x003B1944 File Offset: 0x003AFB44
		public ISneakPlayCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007C45 RID: 31813
		// (get) Token: 0x06019E55 RID: 106069 RVA: 0x003B1954 File Offset: 0x003AFB54
		public int Time
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

		// Token: 0x06019E56 RID: 106070 RVA: 0x003B1990 File Offset: 0x003AFB90
		public static Offset<ISneakPlayCondition> CreateISneakPlayCondition(FlatBufferBuilder builder, int Time = 0)
		{
			builder.StartTable(1);
			ISneakPlayCondition.AddTime(builder, Time);
			return ISneakPlayCondition.EndISneakPlayCondition(builder);
		}

		// Token: 0x06019E57 RID: 106071 RVA: 0x003B19A6 File Offset: 0x003AFBA6
		public static void StartISneakPlayCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06019E58 RID: 106072 RVA: 0x003B19AF File Offset: 0x003AFBAF
		public static void AddTime(FlatBufferBuilder builder, int time)
		{
			builder.AddInt(0, time, 0);
		}

		// Token: 0x06019E59 RID: 106073 RVA: 0x003B19BA File Offset: 0x003AFBBA
		public static Offset<ISneakPlayCondition> EndISneakPlayCondition(FlatBufferBuilder builder)
		{
			return new Offset<ISneakPlayCondition>(builder.EndTable());
		}

		// Token: 0x06019E5A RID: 106074 RVA: 0x003B19C8 File Offset: 0x003AFBC8
		public ISneakPlayConditionT UnPack()
		{
			ISneakPlayConditionT sneakPlayConditionT = new ISneakPlayConditionT();
			this.UnPackTo(sneakPlayConditionT);
			return sneakPlayConditionT;
		}

		// Token: 0x06019E5B RID: 106075 RVA: 0x003B19E3 File Offset: 0x003AFBE3
		public void UnPackTo(ISneakPlayConditionT _o)
		{
			_o.Time = this.Time;
		}

		// Token: 0x06019E5C RID: 106076 RVA: 0x003B19F4 File Offset: 0x003AFBF4
		public static Offset<ISneakPlayCondition> Pack(FlatBufferBuilder builder, ISneakPlayConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISneakPlayCondition>);
			}
			return ISneakPlayCondition.CreateISneakPlayCondition(builder, _o.Time);
		}

		// Token: 0x0400C720 RID: 50976
		private Table __p;
	}
}
