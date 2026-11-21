using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200717E RID: 29054
	public struct ILookAtPerformOverlapMontageConfig : IFlatbufferObject
	{
		// Token: 0x1700D4A8 RID: 54440
		// (get) Token: 0x06032802 RID: 206850 RVA: 0x006D33A5 File Offset: 0x006D15A5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032803 RID: 206851 RVA: 0x006D33B2 File Offset: 0x006D15B2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032804 RID: 206852 RVA: 0x006D33BC File Offset: 0x006D15BC
		public static ILookAtPerformOverlapMontageConfig GetRootAsILookAtPerformOverlapMontageConfig(ByteBuffer _bb)
		{
			return ILookAtPerformOverlapMontageConfig.GetRootAsILookAtPerformOverlapMontageConfig(_bb, default(ILookAtPerformOverlapMontageConfig));
		}

		// Token: 0x06032805 RID: 206853 RVA: 0x006D33D8 File Offset: 0x006D15D8
		public static ILookAtPerformOverlapMontageConfig GetRootAsILookAtPerformOverlapMontageConfig(ByteBuffer _bb, ILookAtPerformOverlapMontageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032806 RID: 206854 RVA: 0x006D33F5 File Offset: 0x006D15F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032807 RID: 206855 RVA: 0x006D3404 File Offset: 0x006D1604
		public ILookAtPerformOverlapMontageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D4A9 RID: 54441
		// (get) Token: 0x06032808 RID: 206856 RVA: 0x006D3414 File Offset: 0x006D1614
		public float OverlapMontageLoopDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4AA RID: 54442
		// (get) Token: 0x06032809 RID: 206857 RVA: 0x006D3454 File Offset: 0x006D1654
		public int OverlapMontageRepeatTimes
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D4AB RID: 54443
		// (get) Token: 0x0603280A RID: 206858 RVA: 0x006D3490 File Offset: 0x006D1690
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603280B RID: 206859 RVA: 0x006D34CC File Offset: 0x006D16CC
		public static Offset<ILookAtPerformOverlapMontageConfig> CreateILookAtPerformOverlapMontageConfig(FlatBufferBuilder builder, float OverlapMontageLoopDuration = 0f, int OverlapMontageRepeatTimes = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILookAtPerformOverlapMontageConfig.AddOverlapMontageRepeatTimes(builder, OverlapMontageRepeatTimes);
			ILookAtPerformOverlapMontageConfig.AddOverlapMontageLoopDuration(builder, OverlapMontageLoopDuration);
			ILookAtPerformOverlapMontageConfig.AddNullMask(builder, NullMask);
			return ILookAtPerformOverlapMontageConfig.EndILookAtPerformOverlapMontageConfig(builder);
		}

		// Token: 0x0603280C RID: 206860 RVA: 0x006D34F0 File Offset: 0x006D16F0
		public static void StartILookAtPerformOverlapMontageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603280D RID: 206861 RVA: 0x006D34F9 File Offset: 0x006D16F9
		public static void AddOverlapMontageLoopDuration(FlatBufferBuilder builder, float overlapMontageLoopDuration)
		{
			builder.AddFloat(0, overlapMontageLoopDuration, 0.0);
		}

		// Token: 0x0603280E RID: 206862 RVA: 0x006D350C File Offset: 0x006D170C
		public static void AddOverlapMontageRepeatTimes(FlatBufferBuilder builder, int overlapMontageRepeatTimes)
		{
			builder.AddInt(1, overlapMontageRepeatTimes, 0);
		}

		// Token: 0x0603280F RID: 206863 RVA: 0x006D3517 File Offset: 0x006D1717
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06032810 RID: 206864 RVA: 0x006D3522 File Offset: 0x006D1722
		public static Offset<ILookAtPerformOverlapMontageConfig> EndILookAtPerformOverlapMontageConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtPerformOverlapMontageConfig>(builder.EndTable());
		}

		// Token: 0x06032811 RID: 206865 RVA: 0x006D3530 File Offset: 0x006D1730
		public ILookAtPerformOverlapMontageConfigT UnPack()
		{
			ILookAtPerformOverlapMontageConfigT lookAtPerformOverlapMontageConfigT = new ILookAtPerformOverlapMontageConfigT();
			this.UnPackTo(lookAtPerformOverlapMontageConfigT);
			return lookAtPerformOverlapMontageConfigT;
		}

		// Token: 0x06032812 RID: 206866 RVA: 0x006D354B File Offset: 0x006D174B
		public void UnPackTo(ILookAtPerformOverlapMontageConfigT _o)
		{
			_o.OverlapMontageLoopDuration = this.OverlapMontageLoopDuration;
			_o.OverlapMontageRepeatTimes = this.OverlapMontageRepeatTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06032813 RID: 206867 RVA: 0x006D3574 File Offset: 0x006D1774
		public static Offset<ILookAtPerformOverlapMontageConfig> Pack(FlatBufferBuilder builder, ILookAtPerformOverlapMontageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtPerformOverlapMontageConfig>);
			}
			return ILookAtPerformOverlapMontageConfig.CreateILookAtPerformOverlapMontageConfig(builder, _o.OverlapMontageLoopDuration, _o.OverlapMontageRepeatTimes, _o.NullMask);
		}

		// Token: 0x04012174 RID: 74100
		private Table __p;
	}
}
