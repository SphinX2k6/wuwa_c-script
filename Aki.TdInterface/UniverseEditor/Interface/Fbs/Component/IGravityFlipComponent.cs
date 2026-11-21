using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A7 RID: 22695
	public struct IGravityFlipComponent : IFlatbufferObject
	{
		// Token: 0x1700A47A RID: 42106
		// (get) Token: 0x06024D08 RID: 150792 RVA: 0x0050E1F2 File Offset: 0x0050C3F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024D09 RID: 150793 RVA: 0x0050E1FF File Offset: 0x0050C3FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024D0A RID: 150794 RVA: 0x0050E208 File Offset: 0x0050C408
		public static IGravityFlipComponent GetRootAsIGravityFlipComponent(ByteBuffer _bb)
		{
			return IGravityFlipComponent.GetRootAsIGravityFlipComponent(_bb, default(IGravityFlipComponent));
		}

		// Token: 0x06024D0B RID: 150795 RVA: 0x0050E224 File Offset: 0x0050C424
		public static IGravityFlipComponent GetRootAsIGravityFlipComponent(ByteBuffer _bb, IGravityFlipComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024D0C RID: 150796 RVA: 0x0050E241 File Offset: 0x0050C441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024D0D RID: 150797 RVA: 0x0050E250 File Offset: 0x0050C450
		public IGravityFlipComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A47B RID: 42107
		// (get) Token: 0x06024D0E RID: 150798 RVA: 0x0050E260 File Offset: 0x0050C460
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06024D0F RID: 150799 RVA: 0x0050E2A0 File Offset: 0x0050C4A0
		public IGravityFlipConfig? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IGravityFlipConfig?(default(IGravityFlipConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A47C RID: 42108
		// (get) Token: 0x06024D10 RID: 150800 RVA: 0x0050E300 File Offset: 0x0050C500
		public int ConfigLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A47D RID: 42109
		// (get) Token: 0x06024D11 RID: 150801 RVA: 0x0050E32C File Offset: 0x0050C52C
		public EGravityFlipType DefaultGravity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EGravityFlipType.None;
				}
				return (EGravityFlipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A47E RID: 42110
		// (get) Token: 0x06024D12 RID: 150802 RVA: 0x0050E368 File Offset: 0x0050C568
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024D13 RID: 150803 RVA: 0x0050E3A5 File Offset: 0x0050C5A5
		public static Offset<IGravityFlipComponent> CreateIGravityFlipComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ConfigOffset = default(VectorOffset), EGravityFlipType DefaultGravity = EGravityFlipType.None, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGravityFlipComponent.AddConfig(builder, ConfigOffset);
			IGravityFlipComponent.AddNullMask(builder, NullMask);
			IGravityFlipComponent.AddDefaultGravity(builder, DefaultGravity);
			IGravityFlipComponent.AddDisabled(builder, Disabled);
			return IGravityFlipComponent.EndIGravityFlipComponent(builder);
		}

		// Token: 0x06024D14 RID: 150804 RVA: 0x0050E3D1 File Offset: 0x0050C5D1
		public static void StartIGravityFlipComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06024D15 RID: 150805 RVA: 0x0050E3DA File Offset: 0x0050C5DA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024D16 RID: 150806 RVA: 0x0050E3E5 File Offset: 0x0050C5E5
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06024D17 RID: 150807 RVA: 0x0050E3F8 File Offset: 0x0050C5F8
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IGravityFlipConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024D18 RID: 150808 RVA: 0x0050E438 File Offset: 0x0050C638
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IGravityFlipConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGravityFlipConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D19 RID: 150809 RVA: 0x0050E452 File Offset: 0x0050C652
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGravityFlipConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGravityFlipConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024D1A RID: 150810 RVA: 0x0050E470 File Offset: 0x0050C670
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGravityFlipConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024D1B RID: 150811 RVA: 0x0050E489 File Offset: 0x0050C689
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024D1C RID: 150812 RVA: 0x0050E494 File Offset: 0x0050C694
		public static void AddDefaultGravity(FlatBufferBuilder builder, EGravityFlipType defaultGravity)
		{
			builder.AddByte(2, (byte)defaultGravity, 0);
		}

		// Token: 0x06024D1D RID: 150813 RVA: 0x0050E49F File Offset: 0x0050C69F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06024D1E RID: 150814 RVA: 0x0050E4AA File Offset: 0x0050C6AA
		public static Offset<IGravityFlipComponent> EndIGravityFlipComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipComponent>(builder.EndTable());
		}

		// Token: 0x06024D1F RID: 150815 RVA: 0x0050E4B8 File Offset: 0x0050C6B8
		public IGravityFlipComponentT UnPack()
		{
			IGravityFlipComponentT gravityFlipComponentT = new IGravityFlipComponentT();
			this.UnPackTo(gravityFlipComponentT);
			return gravityFlipComponentT;
		}

		// Token: 0x06024D20 RID: 150816 RVA: 0x0050E4D4 File Offset: 0x0050C6D4
		public void UnPackTo(IGravityFlipComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = new List<IGravityFlipConfigT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
			_o.DefaultGravity = this.DefaultGravity;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024D21 RID: 150817 RVA: 0x0050E558 File Offset: 0x0050C758
		public static Offset<IGravityFlipComponent> Pack(FlatBufferBuilder builder, IGravityFlipComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityFlipComponent>);
			}
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				Offset<IGravityFlipConfig>[] array = new Offset<IGravityFlipConfig>[_o.Config.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGravityFlipConfig.Pack(builder, _o.Config[i]);
				}
				configOffset = IGravityFlipComponent.CreateConfigVector(builder, array);
			}
			return IGravityFlipComponent.CreateIGravityFlipComponent(builder, _o.Disabled, configOffset, _o.DefaultGravity, _o.NullMask);
		}

		// Token: 0x0400F10B RID: 61707
		private Table __p;
	}
}
