using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C3 RID: 22979
	public struct IInteractCameraOffsetConfig : IFlatbufferObject
	{
		// Token: 0x1700A6D1 RID: 42705
		// (get) Token: 0x0602578F RID: 153487 RVA: 0x00523A48 File Offset: 0x00521C48
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025790 RID: 153488 RVA: 0x00523A55 File Offset: 0x00521C55
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025791 RID: 153489 RVA: 0x00523A5C File Offset: 0x00521C5C
		public static IInteractCameraOffsetConfig GetRootAsIInteractCameraOffsetConfig(ByteBuffer _bb)
		{
			return IInteractCameraOffsetConfig.GetRootAsIInteractCameraOffsetConfig(_bb, default(IInteractCameraOffsetConfig));
		}

		// Token: 0x06025792 RID: 153490 RVA: 0x00523A78 File Offset: 0x00521C78
		public static IInteractCameraOffsetConfig GetRootAsIInteractCameraOffsetConfig(ByteBuffer _bb, IInteractCameraOffsetConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025793 RID: 153491 RVA: 0x00523A95 File Offset: 0x00521C95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025794 RID: 153492 RVA: 0x00523AA4 File Offset: 0x00521CA4
		public IInteractCameraOffsetConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6D2 RID: 42706
		// (get) Token: 0x06025795 RID: 153493 RVA: 0x00523AB4 File Offset: 0x00521CB4
		public int CenterOffsetPercent
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

		// Token: 0x1700A6D3 RID: 42707
		// (get) Token: 0x06025796 RID: 153494 RVA: 0x00523AF0 File Offset: 0x00521CF0
		public float OffsetZ
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A6D4 RID: 42708
		// (get) Token: 0x06025797 RID: 153495 RVA: 0x00523B30 File Offset: 0x00521D30
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

		// Token: 0x06025798 RID: 153496 RVA: 0x00523B6C File Offset: 0x00521D6C
		public static Offset<IInteractCameraOffsetConfig> CreateIInteractCameraOffsetConfig(FlatBufferBuilder builder, int CenterOffsetPercent = 0, float OffsetZ = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			IInteractCameraOffsetConfig.AddOffsetZ(builder, OffsetZ);
			IInteractCameraOffsetConfig.AddCenterOffsetPercent(builder, CenterOffsetPercent);
			IInteractCameraOffsetConfig.AddNullMask(builder, NullMask);
			return IInteractCameraOffsetConfig.EndIInteractCameraOffsetConfig(builder);
		}

		// Token: 0x06025799 RID: 153497 RVA: 0x00523B90 File Offset: 0x00521D90
		public static void StartIInteractCameraOffsetConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602579A RID: 153498 RVA: 0x00523B99 File Offset: 0x00521D99
		public static void AddCenterOffsetPercent(FlatBufferBuilder builder, int centerOffsetPercent)
		{
			builder.AddInt(0, centerOffsetPercent, 0);
		}

		// Token: 0x0602579B RID: 153499 RVA: 0x00523BA4 File Offset: 0x00521DA4
		public static void AddOffsetZ(FlatBufferBuilder builder, float offsetZ)
		{
			builder.AddFloat(1, offsetZ, 0.0);
		}

		// Token: 0x0602579C RID: 153500 RVA: 0x00523BB7 File Offset: 0x00521DB7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602579D RID: 153501 RVA: 0x00523BC2 File Offset: 0x00521DC2
		public static Offset<IInteractCameraOffsetConfig> EndIInteractCameraOffsetConfig(FlatBufferBuilder builder)
		{
			return new Offset<IInteractCameraOffsetConfig>(builder.EndTable());
		}

		// Token: 0x0602579E RID: 153502 RVA: 0x00523BD0 File Offset: 0x00521DD0
		public IInteractCameraOffsetConfigT UnPack()
		{
			IInteractCameraOffsetConfigT interactCameraOffsetConfigT = new IInteractCameraOffsetConfigT();
			this.UnPackTo(interactCameraOffsetConfigT);
			return interactCameraOffsetConfigT;
		}

		// Token: 0x0602579F RID: 153503 RVA: 0x00523BEB File Offset: 0x00521DEB
		public void UnPackTo(IInteractCameraOffsetConfigT _o)
		{
			_o.CenterOffsetPercent = this.CenterOffsetPercent;
			_o.OffsetZ = this.OffsetZ;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060257A0 RID: 153504 RVA: 0x00523C14 File Offset: 0x00521E14
		public static Offset<IInteractCameraOffsetConfig> Pack(FlatBufferBuilder builder, IInteractCameraOffsetConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractCameraOffsetConfig>);
			}
			return IInteractCameraOffsetConfig.CreateIInteractCameraOffsetConfig(builder, _o.CenterOffsetPercent, _o.OffsetZ, _o.NullMask);
		}

		// Token: 0x0400F2C5 RID: 62149
		private Table __p;
	}
}
