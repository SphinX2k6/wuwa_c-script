using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE0 RID: 20192
	public struct IAutoConfig : IFlatbufferObject
	{
		// Token: 0x170090EE RID: 37102
		// (get) Token: 0x0601FD35 RID: 130357 RVA: 0x0046DB00 File Offset: 0x0046BD00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD36 RID: 130358 RVA: 0x0046DB0D File Offset: 0x0046BD0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD37 RID: 130359 RVA: 0x0046DB14 File Offset: 0x0046BD14
		public static IAutoConfig GetRootAsIAutoConfig(ByteBuffer _bb)
		{
			return IAutoConfig.GetRootAsIAutoConfig(_bb, default(IAutoConfig));
		}

		// Token: 0x0601FD38 RID: 130360 RVA: 0x0046DB30 File Offset: 0x0046BD30
		public static IAutoConfig GetRootAsIAutoConfig(ByteBuffer _bb, IAutoConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD39 RID: 130361 RVA: 0x0046DB4D File Offset: 0x0046BD4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD3A RID: 130362 RVA: 0x0046DB5C File Offset: 0x0046BD5C
		public IAutoConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090EF RID: 37103
		// (get) Token: 0x0601FD3B RID: 130363 RVA: 0x0046DB6C File Offset: 0x0046BD6C
		public bool IsCircle
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170090F0 RID: 37104
		// (get) Token: 0x0601FD3C RID: 130364 RVA: 0x0046DBAC File Offset: 0x0046BDAC
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

		// Token: 0x0601FD3D RID: 130365 RVA: 0x0046DBE8 File Offset: 0x0046BDE8
		public static Offset<IAutoConfig> CreateIAutoConfig(FlatBufferBuilder builder, bool IsCircle = false, int Interval = 0)
		{
			builder.StartTable(2);
			IAutoConfig.AddInterval(builder, Interval);
			IAutoConfig.AddIsCircle(builder, IsCircle);
			return IAutoConfig.EndIAutoConfig(builder);
		}

		// Token: 0x0601FD3E RID: 130366 RVA: 0x0046DC05 File Offset: 0x0046BE05
		public static void StartIAutoConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD3F RID: 130367 RVA: 0x0046DC0E File Offset: 0x0046BE0E
		public static void AddIsCircle(FlatBufferBuilder builder, bool isCircle)
		{
			builder.AddBool(0, isCircle, false);
		}

		// Token: 0x0601FD40 RID: 130368 RVA: 0x0046DC19 File Offset: 0x0046BE19
		public static void AddInterval(FlatBufferBuilder builder, int interval)
		{
			builder.AddInt(1, interval, 0);
		}

		// Token: 0x0601FD41 RID: 130369 RVA: 0x0046DC24 File Offset: 0x0046BE24
		public static Offset<IAutoConfig> EndIAutoConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAutoConfig>(builder.EndTable());
		}

		// Token: 0x0601FD42 RID: 130370 RVA: 0x0046DC34 File Offset: 0x0046BE34
		public IAutoConfigT UnPack()
		{
			IAutoConfigT autoConfigT = new IAutoConfigT();
			this.UnPackTo(autoConfigT);
			return autoConfigT;
		}

		// Token: 0x0601FD43 RID: 130371 RVA: 0x0046DC4F File Offset: 0x0046BE4F
		public void UnPackTo(IAutoConfigT _o)
		{
			_o.IsCircle = this.IsCircle;
			_o.Interval = this.Interval;
		}

		// Token: 0x0601FD44 RID: 130372 RVA: 0x0046DC6C File Offset: 0x0046BE6C
		public static Offset<IAutoConfig> Pack(FlatBufferBuilder builder, IAutoConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutoConfig>);
			}
			return IAutoConfig.CreateIAutoConfig(builder, _o.IsCircle, _o.Interval);
		}

		// Token: 0x0400DCE8 RID: 56552
		private Table __p;
	}
}
