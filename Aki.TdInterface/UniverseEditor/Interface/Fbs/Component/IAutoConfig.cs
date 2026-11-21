using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200540F RID: 21519
	public struct IAutoConfig : IFlatbufferObject
	{
		// Token: 0x17009861 RID: 39009
		// (get) Token: 0x06021A79 RID: 137849 RVA: 0x004A38D0 File Offset: 0x004A1AD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A7A RID: 137850 RVA: 0x004A38DD File Offset: 0x004A1ADD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A7B RID: 137851 RVA: 0x004A38E4 File Offset: 0x004A1AE4
		public static IAutoConfig GetRootAsIAutoConfig(ByteBuffer _bb)
		{
			return IAutoConfig.GetRootAsIAutoConfig(_bb, default(IAutoConfig));
		}

		// Token: 0x06021A7C RID: 137852 RVA: 0x004A3900 File Offset: 0x004A1B00
		public static IAutoConfig GetRootAsIAutoConfig(ByteBuffer _bb, IAutoConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A7D RID: 137853 RVA: 0x004A391D File Offset: 0x004A1B1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A7E RID: 137854 RVA: 0x004A392C File Offset: 0x004A1B2C
		public IAutoConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009862 RID: 39010
		// (get) Token: 0x06021A7F RID: 137855 RVA: 0x004A393C File Offset: 0x004A1B3C
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009863 RID: 39011
		// (get) Token: 0x06021A80 RID: 137856 RVA: 0x004A397C File Offset: 0x004A1B7C
		public int Interval
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

		// Token: 0x06021A81 RID: 137857 RVA: 0x004A39B8 File Offset: 0x004A1BB8
		public static Offset<IAutoConfig> CreateIAutoConfig(FlatBufferBuilder builder, bool IsCircle = false, int Interval = 0)
		{
			builder.StartTable(2);
			IAutoConfig.AddInterval(builder, Interval);
			IAutoConfig.AddIsCircle(builder, IsCircle);
			return IAutoConfig.EndIAutoConfig(builder);
		}

		// Token: 0x06021A82 RID: 137858 RVA: 0x004A39D5 File Offset: 0x004A1BD5
		public static void StartIAutoConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021A83 RID: 137859 RVA: 0x004A39DE File Offset: 0x004A1BDE
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(0, isCircle, false);
		}

		// Token: 0x06021A84 RID: 137860 RVA: 0x004A39E9 File Offset: 0x004A1BE9
		public static void AddInterval(FlatBufferBuilder builder, int interval)
		{
			builder.AddInt(1, interval, 0);
		}

		// Token: 0x06021A85 RID: 137861 RVA: 0x004A39F4 File Offset: 0x004A1BF4
		public static Offset<IAutoConfig> EndIAutoConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAutoConfig>(builder.EndTable());
		}

		// Token: 0x06021A86 RID: 137862 RVA: 0x004A3A04 File Offset: 0x004A1C04
		public IAutoConfigT UnPack()
		{
			IAutoConfigT autoConfigT = new IAutoConfigT();
			this.UnPackTo(autoConfigT);
			return autoConfigT;
		}

		// Token: 0x06021A87 RID: 137863 RVA: 0x004A3A1F File Offset: 0x004A1C1F
		public void UnPackTo(IAutoConfigT _o)
		{
			_o.IsCircle = this.IsCircle;
			_o.Interval = this.Interval;
		}

		// Token: 0x06021A88 RID: 137864 RVA: 0x004A3A3C File Offset: 0x004A1C3C
		public static Offset<IAutoConfig> Pack(FlatBufferBuilder builder, IAutoConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutoConfig>);
			}
			return IAutoConfig.CreateIAutoConfig(builder, _o.IsCircle, _o.Interval);
		}

		// Token: 0x0400E88F RID: 59535
		private Table __p;
	}
}
