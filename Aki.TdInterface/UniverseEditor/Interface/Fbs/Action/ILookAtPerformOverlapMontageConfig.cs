using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A5C RID: 27228
	public struct ILookAtPerformOverlapMontageConfig : IFlatbufferObject
	{
		// Token: 0x1700C9FD RID: 51709
		// (get) Token: 0x0602FADC RID: 195292 RVA: 0x0067D2E5 File Offset: 0x0067B4E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FADD RID: 195293 RVA: 0x0067D2F2 File Offset: 0x0067B4F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FADE RID: 195294 RVA: 0x0067D2FC File Offset: 0x0067B4FC
		public static ILookAtPerformOverlapMontageConfig GetRootAsILookAtPerformOverlapMontageConfig(ByteBuffer _bb)
		{
			return ILookAtPerformOverlapMontageConfig.GetRootAsILookAtPerformOverlapMontageConfig(_bb, default(ILookAtPerformOverlapMontageConfig));
		}

		// Token: 0x0602FADF RID: 195295 RVA: 0x0067D318 File Offset: 0x0067B518
		public static ILookAtPerformOverlapMontageConfig GetRootAsILookAtPerformOverlapMontageConfig(ByteBuffer _bb, ILookAtPerformOverlapMontageConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FAE0 RID: 195296 RVA: 0x0067D335 File Offset: 0x0067B535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FAE1 RID: 195297 RVA: 0x0067D344 File Offset: 0x0067B544
		public ILookAtPerformOverlapMontageConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9FE RID: 51710
		// (get) Token: 0x0602FAE2 RID: 195298 RVA: 0x0067D354 File Offset: 0x0067B554
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

		// Token: 0x1700C9FF RID: 51711
		// (get) Token: 0x0602FAE3 RID: 195299 RVA: 0x0067D394 File Offset: 0x0067B594
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

		// Token: 0x1700CA00 RID: 51712
		// (get) Token: 0x0602FAE4 RID: 195300 RVA: 0x0067D3D0 File Offset: 0x0067B5D0
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

		// Token: 0x0602FAE5 RID: 195301 RVA: 0x0067D40C File Offset: 0x0067B60C
		public static Offset<ILookAtPerformOverlapMontageConfig> CreateILookAtPerformOverlapMontageConfig(FlatBufferBuilder builder, float OverlapMontageLoopDuration = 0f, int OverlapMontageRepeatTimes = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILookAtPerformOverlapMontageConfig.AddOverlapMontageRepeatTimes(builder, OverlapMontageRepeatTimes);
			ILookAtPerformOverlapMontageConfig.AddOverlapMontageLoopDuration(builder, OverlapMontageLoopDuration);
			ILookAtPerformOverlapMontageConfig.AddNullMask(builder, NullMask);
			return ILookAtPerformOverlapMontageConfig.EndILookAtPerformOverlapMontageConfig(builder);
		}

		// Token: 0x0602FAE6 RID: 195302 RVA: 0x0067D430 File Offset: 0x0067B630
		public static void StartILookAtPerformOverlapMontageConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FAE7 RID: 195303 RVA: 0x0067D439 File Offset: 0x0067B639
		public static void AddOverlapMontageLoopDuration(FlatBufferBuilder builder, float overlapMontageLoopDuration)
		{
			builder.AddFloat(0, overlapMontageLoopDuration, 0.0);
		}

		// Token: 0x0602FAE8 RID: 195304 RVA: 0x0067D44C File Offset: 0x0067B64C
		public static void AddOverlapMontageRepeatTimes(FlatBufferBuilder builder, int overlapMontageRepeatTimes)
		{
			builder.AddInt(1, overlapMontageRepeatTimes, 0);
		}

		// Token: 0x0602FAE9 RID: 195305 RVA: 0x0067D457 File Offset: 0x0067B657
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602FAEA RID: 195306 RVA: 0x0067D462 File Offset: 0x0067B662
		public static Offset<ILookAtPerformOverlapMontageConfig> EndILookAtPerformOverlapMontageConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILookAtPerformOverlapMontageConfig>(builder.EndTable());
		}

		// Token: 0x0602FAEB RID: 195307 RVA: 0x0067D470 File Offset: 0x0067B670
		public ILookAtPerformOverlapMontageConfigT UnPack()
		{
			ILookAtPerformOverlapMontageConfigT lookAtPerformOverlapMontageConfigT = new ILookAtPerformOverlapMontageConfigT();
			this.UnPackTo(lookAtPerformOverlapMontageConfigT);
			return lookAtPerformOverlapMontageConfigT;
		}

		// Token: 0x0602FAEC RID: 195308 RVA: 0x0067D48B File Offset: 0x0067B68B
		public void UnPackTo(ILookAtPerformOverlapMontageConfigT _o)
		{
			_o.OverlapMontageLoopDuration = this.OverlapMontageLoopDuration;
			_o.OverlapMontageRepeatTimes = this.OverlapMontageRepeatTimes;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FAED RID: 195309 RVA: 0x0067D4B4 File Offset: 0x0067B6B4
		public static Offset<ILookAtPerformOverlapMontageConfig> Pack(FlatBufferBuilder builder, ILookAtPerformOverlapMontageConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILookAtPerformOverlapMontageConfig>);
			}
			return ILookAtPerformOverlapMontageConfig.CreateILookAtPerformOverlapMontageConfig(builder, _o.OverlapMontageLoopDuration, _o.OverlapMontageRepeatTimes, _o.NullMask);
		}

		// Token: 0x0401127C RID: 70268
		private Table __p;
	}
}
