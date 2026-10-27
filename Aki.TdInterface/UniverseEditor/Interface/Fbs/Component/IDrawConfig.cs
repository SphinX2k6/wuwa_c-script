using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050BD RID: 20669
	public struct IDrawConfig : IFlatbufferObject
	{
		// Token: 0x17009664 RID: 38500
		// (get) Token: 0x060213D5 RID: 136149 RVA: 0x0049E4A4 File Offset: 0x0049C6A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060213D6 RID: 136150 RVA: 0x0049E4B1 File Offset: 0x0049C6B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060213D7 RID: 136151 RVA: 0x0049E4B8 File Offset: 0x0049C6B8
		public static IDrawConfig GetRootAsIDrawConfig(ByteBuffer _bb)
		{
			return IDrawConfig.GetRootAsIDrawConfig(_bb, default(IDrawConfig));
		}

		// Token: 0x060213D8 RID: 136152 RVA: 0x0049E4D4 File Offset: 0x0049C6D4
		public static IDrawConfig GetRootAsIDrawConfig(ByteBuffer _bb, IDrawConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060213D9 RID: 136153 RVA: 0x0049E4F1 File Offset: 0x0049C6F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060213DA RID: 136154 RVA: 0x0049E500 File Offset: 0x0049C700
		public IDrawConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009665 RID: 38501
		// (get) Token: 0x060213DB RID: 136155 RVA: 0x0049E510 File Offset: 0x0049C710
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

		// Token: 0x17009666 RID: 38502
		// (get) Token: 0x060213DC RID: 136156 RVA: 0x0049E54C File Offset: 0x0049C74C
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

		// Token: 0x17009667 RID: 38503
		// (get) Token: 0x060213DD RID: 136157 RVA: 0x0049E588 File Offset: 0x0049C788
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

		// Token: 0x17009668 RID: 38504
		// (get) Token: 0x060213DE RID: 136158 RVA: 0x0049E5C4 File Offset: 0x0049C7C4
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

		// Token: 0x17009669 RID: 38505
		// (get) Token: 0x060213DF RID: 136159 RVA: 0x0049E604 File Offset: 0x0049C804
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

		// Token: 0x060213E0 RID: 136160 RVA: 0x0049E63C File Offset: 0x0049C83C
		public Span<byte> GetDrawCameraShakeBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060213E1 RID: 136161 RVA: 0x0049E64C File Offset: 0x0049C84C
		public byte[] GetDrawCameraShakeArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x060213E2 RID: 136162 RVA: 0x0049E65B File Offset: 0x0049C85B
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

		// Token: 0x060213E3 RID: 136163 RVA: 0x0049E68F File Offset: 0x0049C88F
		public static void StartIDrawConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060213E4 RID: 136164 RVA: 0x0049E698 File Offset: 0x0049C898
		public static void AddDrawDelay(FlatBufferBuilder builder, int drawDelay)
		{
			builder.AddInt(0, drawDelay, 0);
		}

		// Token: 0x060213E5 RID: 136165 RVA: 0x0049E6A3 File Offset: 0x0049C8A3
		public static void AddDrawTime(FlatBufferBuilder builder, int drawTime)
		{
			builder.AddInt(1, drawTime, 0);
		}

		// Token: 0x060213E6 RID: 136166 RVA: 0x0049E6AE File Offset: 0x0049C8AE
		public static void AddDrawAlignTime(FlatBufferBuilder builder, int drawAlignTime)
		{
			builder.AddInt(2, drawAlignTime, 0);
		}

		// Token: 0x060213E7 RID: 136167 RVA: 0x0049E6B9 File Offset: 0x0049C8B9
		public static void AddDrawAlignHeight(FlatBufferBuilder builder, int drawAlignHeight)
		{
			builder.AddInt(3, drawAlignHeight, 0);
		}

		// Token: 0x060213E8 RID: 136168 RVA: 0x0049E6C4 File Offset: 0x0049C8C4
		public static void AddDrawCameraShake(FlatBufferBuilder builder, StringOffset drawCameraShakeOffset)
		{
			builder.AddOffset(4, drawCameraShakeOffset.Value, 0);
		}

		// Token: 0x060213E9 RID: 136169 RVA: 0x0049E6D4 File Offset: 0x0049C8D4
		public static Offset<IDrawConfig> EndIDrawConfig(FlatBufferBuilder builder)
		{
			return new Offset<IDrawConfig>(builder.EndTable());
		}

		// Token: 0x060213EA RID: 136170 RVA: 0x0049E6E4 File Offset: 0x0049C8E4
		public IDrawConfigT UnPack()
		{
			IDrawConfigT drawConfigT = new IDrawConfigT();
			this.UnPackTo(drawConfigT);
			return drawConfigT;
		}

		// Token: 0x060213EB RID: 136171 RVA: 0x0049E6FF File Offset: 0x0049C8FF
		public void UnPackTo(IDrawConfigT _o)
		{
			_o.DrawDelay = this.DrawDelay;
			_o.DrawTime = this.DrawTime;
			_o.DrawAlignTime = this.DrawAlignTime;
			_o.DrawAlignHeight = this.DrawAlignHeight;
			_o.DrawCameraShake = this.DrawCameraShake;
		}

		// Token: 0x060213EC RID: 136172 RVA: 0x0049E740 File Offset: 0x0049C940
		public static Offset<IDrawConfig> Pack(FlatBufferBuilder builder, IDrawConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDrawConfig>);
			}
			StringOffset drawCameraShakeOffset = (_o.DrawCameraShake == null) ? default(StringOffset) : builder.CreateString(_o.DrawCameraShake);
			return IDrawConfig.CreateIDrawConfig(builder, _o.DrawDelay, _o.DrawTime, _o.DrawAlignTime, _o.DrawAlignHeight, drawCameraShakeOffset);
		}

		// Token: 0x0400E0FE RID: 57598
		private Table __p;
	}
}
