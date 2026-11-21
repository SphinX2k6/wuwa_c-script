using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005622 RID: 22050
	public struct IDrawConfig : IFlatbufferObject
	{
		// Token: 0x17009E51 RID: 40529
		// (get) Token: 0x06023329 RID: 144169 RVA: 0x004D8430 File Offset: 0x004D6630
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602332A RID: 144170 RVA: 0x004D843D File Offset: 0x004D663D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602332B RID: 144171 RVA: 0x004D8444 File Offset: 0x004D6644
		public static IDrawConfig GetRootAsIDrawConfig(ByteBuffer _bb)
		{
			return IDrawConfig.GetRootAsIDrawConfig(_bb, default(IDrawConfig));
		}

		// Token: 0x0602332C RID: 144172 RVA: 0x004D8460 File Offset: 0x004D6660
		public static IDrawConfig GetRootAsIDrawConfig(ByteBuffer _bb, IDrawConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602332D RID: 144173 RVA: 0x004D847D File Offset: 0x004D667D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602332E RID: 144174 RVA: 0x004D848C File Offset: 0x004D668C
		public IDrawConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E52 RID: 40530
		// (get) Token: 0x0602332F RID: 144175 RVA: 0x004D849C File Offset: 0x004D669C
		public int DrawDelay
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

		// Token: 0x17009E53 RID: 40531
		// (get) Token: 0x06023330 RID: 144176 RVA: 0x004D84D8 File Offset: 0x004D66D8
		public int DrawTime
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

		// Token: 0x17009E54 RID: 40532
		// (get) Token: 0x06023331 RID: 144177 RVA: 0x004D8514 File Offset: 0x004D6714
		public int DrawAlignTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E55 RID: 40533
		// (get) Token: 0x06023332 RID: 144178 RVA: 0x004D8550 File Offset: 0x004D6750
		public int DrawAlignHeight
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009E56 RID: 40534
		// (get) Token: 0x06023333 RID: 144179 RVA: 0x004D8590 File Offset: 0x004D6790
		public string DrawCameraShake
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023334 RID: 144180 RVA: 0x004D85C8 File Offset: 0x004D67C8
		public Span<byte> GetDrawCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06023335 RID: 144181 RVA: 0x004D85D8 File Offset: 0x004D67D8
		public byte[] GetDrawCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x06023336 RID: 144182 RVA: 0x004D85E7 File Offset: 0x004D67E7
		public static Offset<IDrawConfig> CreateIDrawConfig(FlatBufferBuilder builder, int DrawDelay = 0, int DrawTime = 0, int DrawAlignTime = 0, int DrawAlignHeight = 0, StringOffset DrawCameraShakeOffset = default(StringOffset))
		{
			builder.StartTable(5);
			IDrawConfig.AddDrawCameraShake(builder, DrawCameraShakeOffset);
			IDrawConfig.AddDrawAlignHeight(builder, DrawAlignHeight);
			IDrawConfig.AddDrawAlignTime(builder, DrawAlignTime);
			IDrawConfig.AddDrawTime(builder, DrawTime);
			IDrawConfig.AddDrawDelay(builder, DrawDelay);
			return IDrawConfig.EndIDrawConfig(builder);
		}

		// Token: 0x06023337 RID: 144183 RVA: 0x004D861B File Offset: 0x004D681B
		public static void StartIDrawConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06023338 RID: 144184 RVA: 0x004D8624 File Offset: 0x004D6824
		public static void AddDrawDelay(FlatBufferBuilder builder, int drawDelay)
		{
			builder.AddInt(0, drawDelay, 0);
		}

		// Token: 0x06023339 RID: 144185 RVA: 0x004D862F File Offset: 0x004D682F
		public static void AddDrawTime(FlatBufferBuilder builder, int drawTime)
		{
			builder.AddInt(1, drawTime, 0);
		}

		// Token: 0x0602333A RID: 144186 RVA: 0x004D863A File Offset: 0x004D683A
		public static void AddDrawAlignTime(FlatBufferBuilder builder, int drawAlignTime)
		{
			builder.AddInt(2, drawAlignTime, 0);
		}

		// Token: 0x0602333B RID: 144187 RVA: 0x004D8645 File Offset: 0x004D6845
		public static void AddDrawAlignHeight(FlatBufferBuilder builder, int drawAlignHeight)
		{
			builder.AddInt(3, drawAlignHeight, 0);
		}

		// Token: 0x0602333C RID: 144188 RVA: 0x004D8650 File Offset: 0x004D6850
		public static void AddDrawCameraShake(FlatBufferBuilder builder, StringOffset drawCameraShakeOffset)
		{
			builder.AddOffset(4, drawCameraShakeOffset.Value, 0);
		}

		// Token: 0x0602333D RID: 144189 RVA: 0x004D8660 File Offset: 0x004D6860
		public static Offset<IDrawConfig> EndIDrawConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDrawConfig>(builder.EndTable());
		}

		// Token: 0x0602333E RID: 144190 RVA: 0x004D8670 File Offset: 0x004D6870
		public IDrawConfigT UnPack()
		{
			IDrawConfigT drawConfigT = new IDrawConfigT();
			this.UnPackTo(drawConfigT);
			return drawConfigT;
		}

		// Token: 0x0602333F RID: 144191 RVA: 0x004D868B File Offset: 0x004D688B
		public void UnPackTo(IDrawConfigT _o)
		{
			_o.DrawDelay = this.DrawDelay;
			_o.DrawTime = this.DrawTime;
			_o.DrawAlignTime = this.DrawAlignTime;
			_o.DrawAlignHeight = this.DrawAlignHeight;
			_o.DrawCameraShake = this.DrawCameraShake;
		}

		// Token: 0x06023340 RID: 144192 RVA: 0x004D86CC File Offset: 0x004D68CC
		public static Offset<IDrawConfig> Pack(FlatBufferBuilder builder, IDrawConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDrawConfig>);
			}
			StringOffset drawCameraShakeOffset = (_o.DrawCameraShake == null) ? default(StringOffset) : builder.CreateString(_o.DrawCameraShake);
			return IDrawConfig.CreateIDrawConfig(builder, _o.DrawDelay, _o.DrawTime, _o.DrawAlignTime, _o.DrawAlignHeight, drawCameraShakeOffset);
		}

		// Token: 0x0400ECFB RID: 60667
		private Table __p;
	}
}
