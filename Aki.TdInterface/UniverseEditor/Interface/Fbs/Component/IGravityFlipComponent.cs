using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005321 RID: 21281
	public struct IGravityFlipComponent : IFlatbufferObject
	{
		// Token: 0x17009C42 RID: 40002
		// (get) Token: 0x06022C54 RID: 142420 RVA: 0x004D131E File Offset: 0x004CF51E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022C55 RID: 142421 RVA: 0x004D132B File Offset: 0x004CF52B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022C56 RID: 142422 RVA: 0x004D1334 File Offset: 0x004CF534
		public static IGravityFlipComponent GetRootAsIGravityFlipComponent(ByteBuffer _bb)
		{
			return IGravityFlipComponent.GetRootAsIGravityFlipComponent(_bb, default(IGravityFlipComponent));
		}

		// Token: 0x06022C57 RID: 142423 RVA: 0x004D1350 File Offset: 0x004CF550
		public static IGravityFlipComponent GetRootAsIGravityFlipComponent(ByteBuffer _bb, IGravityFlipComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022C58 RID: 142424 RVA: 0x004D136D File Offset: 0x004CF56D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022C59 RID: 142425 RVA: 0x004D137C File Offset: 0x004CF57C
		public IGravityFlipComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C43 RID: 40003
		// (get) Token: 0x06022C5A RID: 142426 RVA: 0x004D138C File Offset: 0x004CF58C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022C5B RID: 142427 RVA: 0x004D13CC File Offset: 0x004CF5CC
		public IGravityFlipConfig? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IGravityFlipConfig?(default(IGravityFlipConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009C44 RID: 40004
		// (get) Token: 0x06022C5C RID: 142428 RVA: 0x004D142C File Offset: 0x004CF62C
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

		// Token: 0x17009C45 RID: 40005
		// (get) Token: 0x06022C5D RID: 142429 RVA: 0x004D1458 File Offset: 0x004CF658
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

		// Token: 0x17009C46 RID: 40006
		// (get) Token: 0x06022C5E RID: 142430 RVA: 0x004D1494 File Offset: 0x004CF694
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

		// Token: 0x06022C5F RID: 142431 RVA: 0x004D14D1 File Offset: 0x004CF6D1
		public static Offset<IGravityFlipComponent> CreateIGravityFlipComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ConfigOffset = default(VectorOffset), EGravityFlipType DefaultGravity = EGravityFlipType.None, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGravityFlipComponent.AddConfig(builder, ConfigOffset);
			IGravityFlipComponent.AddNullMask(builder, NullMask);
			IGravityFlipComponent.AddDefaultGravity(builder, DefaultGravity);
			IGravityFlipComponent.AddDisabled(builder, Disabled);
			return IGravityFlipComponent.EndIGravityFlipComponent(builder);
		}

		// Token: 0x06022C60 RID: 142432 RVA: 0x004D14FD File Offset: 0x004CF6FD
		public static void StartIGravityFlipComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022C61 RID: 142433 RVA: 0x004D1506 File Offset: 0x004CF706
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022C62 RID: 142434 RVA: 0x004D1511 File Offset: 0x004CF711
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06022C63 RID: 142435 RVA: 0x004D1524 File Offset: 0x004CF724
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IGravityFlipConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022C64 RID: 142436 RVA: 0x004D1564 File Offset: 0x004CF764
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IGravityFlipConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGravityFlipConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C65 RID: 142437 RVA: 0x004D157E File Offset: 0x004CF77E
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGravityFlipConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGravityFlipConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06022C66 RID: 142438 RVA: 0x004D159C File Offset: 0x004CF79C
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGravityFlipConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022C67 RID: 142439 RVA: 0x004D15B5 File Offset: 0x004CF7B5
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022C68 RID: 142440 RVA: 0x004D15C0 File Offset: 0x004CF7C0
		public static void AddDefaultGravity(FlatBufferBuilder builder, EGravityFlipType defaultGravity)
		{
			builder.AddByte(2, (byte)defaultGravity, 0);
		}

		// Token: 0x06022C69 RID: 142441 RVA: 0x004D15CB File Offset: 0x004CF7CB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06022C6A RID: 142442 RVA: 0x004D15D6 File Offset: 0x004CF7D6
		public static Offset<IGravityFlipComponent> EndIGravityFlipComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGravityFlipComponent>(builder.EndTable());
		}

		// Token: 0x06022C6B RID: 142443 RVA: 0x004D15E4 File Offset: 0x004CF7E4
		public IGravityFlipComponentT UnPack()
		{
			IGravityFlipComponentT gravityFlipComponentT = new IGravityFlipComponentT();
			this.UnPackTo(gravityFlipComponentT);
			return gravityFlipComponentT;
		}

		// Token: 0x06022C6C RID: 142444 RVA: 0x004D1600 File Offset: 0x004CF800
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

		// Token: 0x06022C6D RID: 142445 RVA: 0x004D1684 File Offset: 0x004CF884
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

		// Token: 0x0400E4DB RID: 58587
		private Table __p;
	}
}
