using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC8 RID: 19400
	public struct IHighPerformanceMode : IFlatbufferObject
	{
		// Token: 0x17008959 RID: 35161
		// (get) Token: 0x0601D9E2 RID: 121314 RVA: 0x004285FB File Offset: 0x004267FB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D9E3 RID: 121315 RVA: 0x00428608 File Offset: 0x00426808
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D9E4 RID: 121316 RVA: 0x00428610 File Offset: 0x00426810
		public static IHighPerformanceMode GetRootAsIHighPerformanceMode(ByteBuffer _bb)
		{
			return IHighPerformanceMode.GetRootAsIHighPerformanceMode(_bb, default(IHighPerformanceMode));
		}

		// Token: 0x0601D9E5 RID: 121317 RVA: 0x0042862C File Offset: 0x0042682C
		public static IHighPerformanceMode GetRootAsIHighPerformanceMode(ByteBuffer _bb, IHighPerformanceMode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D9E6 RID: 121318 RVA: 0x00428649 File Offset: 0x00426849
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D9E7 RID: 121319 RVA: 0x00428658 File Offset: 0x00426858
		public IHighPerformanceMode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700895A RID: 35162
		// (get) Token: 0x0601D9E8 RID: 121320 RVA: 0x00428668 File Offset: 0x00426868
		public EPerformanceMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformanceMode.High;
				}
				return (EPerformanceMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601D9E9 RID: 121321 RVA: 0x004286A4 File Offset: 0x004268A4
		public static Offset<IHighPerformanceMode> CreateIHighPerformanceMode(FlatBufferBuilder builder, EPerformanceMode Type = EPerformanceMode.High)
		{
			builder.StartTable(1);
			IHighPerformanceMode.AddType(builder, Type);
			return IHighPerformanceMode.EndIHighPerformanceMode(builder);
		}

		// Token: 0x0601D9EA RID: 121322 RVA: 0x004286BA File Offset: 0x004268BA
		public static void StartIHighPerformanceMode(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601D9EB RID: 121323 RVA: 0x004286C3 File Offset: 0x004268C3
		public static void AddType(FlatBufferBuilder builder, EPerformanceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601D9EC RID: 121324 RVA: 0x004286CE File Offset: 0x004268CE
		public static Offset<IHighPerformanceMode> EndIHighPerformanceMode(FlatBufferBuilder builder)
		{
			return new Offset<IHighPerformanceMode>(builder.EndTable());
		}

		// Token: 0x0601D9ED RID: 121325 RVA: 0x004286DC File Offset: 0x004268DC
		public IHighPerformanceModeT UnPack()
		{
			IHighPerformanceModeT highPerformanceModeT = new IHighPerformanceModeT();
			this.UnPackTo(highPerformanceModeT);
			return highPerformanceModeT;
		}

		// Token: 0x0601D9EE RID: 121326 RVA: 0x004286F7 File Offset: 0x004268F7
		public void UnPackTo(IHighPerformanceModeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601D9EF RID: 121327 RVA: 0x00428708 File Offset: 0x00426908
		public static Offset<IHighPerformanceMode> Pack(FlatBufferBuilder builder, IHighPerformanceModeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHighPerformanceMode>);
			}
			return IHighPerformanceMode.CreateIHighPerformanceMode(builder, _o.Type);
		}

		// Token: 0x0400D48F RID: 54415
		private Table __p;
	}
}
