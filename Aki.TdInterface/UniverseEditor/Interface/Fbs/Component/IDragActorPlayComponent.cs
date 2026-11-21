using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005619 RID: 22041
	public struct IDragActorPlayComponent : IFlatbufferObject
	{
		// Token: 0x17009E16 RID: 40470
		// (get) Token: 0x0602326F RID: 143983 RVA: 0x004D68C7 File Offset: 0x004D4AC7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023270 RID: 143984 RVA: 0x004D68D4 File Offset: 0x004D4AD4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023271 RID: 143985 RVA: 0x004D68DC File Offset: 0x004D4ADC
		public static IDragActorPlayComponent GetRootAsIDragActorPlayComponent(ByteBuffer _bb)
		{
			return IDragActorPlayComponent.GetRootAsIDragActorPlayComponent(_bb, default(IDragActorPlayComponent));
		}

		// Token: 0x06023272 RID: 143986 RVA: 0x004D68F8 File Offset: 0x004D4AF8
		public static IDragActorPlayComponent GetRootAsIDragActorPlayComponent(ByteBuffer _bb, IDragActorPlayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023273 RID: 143987 RVA: 0x004D6915 File Offset: 0x004D4B15
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023274 RID: 143988 RVA: 0x004D6924 File Offset: 0x004D4B24
		public IDragActorPlayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009E17 RID: 40471
		// (get) Token: 0x06023275 RID: 143989 RVA: 0x004D6934 File Offset: 0x004D4B34
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023276 RID: 143990 RVA: 0x004D6974 File Offset: 0x004D4B74
		public IDragActorPlayConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDragActorPlayConfig?(default(IDragActorPlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009E18 RID: 40472
		// (get) Token: 0x06023277 RID: 143991 RVA: 0x004D69D4 File Offset: 0x004D4BD4
		public int ConfigsLength
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

		// Token: 0x17009E19 RID: 40473
		// (get) Token: 0x06023278 RID: 143992 RVA: 0x004D6A00 File Offset: 0x004D4C00
		public string ExitSendSelfEvent
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023279 RID: 143993 RVA: 0x004D6A37 File Offset: 0x004D4C37
		public Span<byte> GetExitSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0602327A RID: 143994 RVA: 0x004D6A46 File Offset: 0x004D4C46
		public byte[] GetExitSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009E1A RID: 40474
		// (get) Token: 0x0602327B RID: 143995 RVA: 0x004D6A54 File Offset: 0x004D4C54
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

		// Token: 0x0602327C RID: 143996 RVA: 0x004D6A91 File Offset: 0x004D4C91
		public static Offset<IDragActorPlayComponent> CreateIDragActorPlayComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ConfigsOffset = default(VectorOffset), StringOffset ExitSendSelfEventOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDragActorPlayComponent.AddExitSendSelfEvent(builder, ExitSendSelfEventOffset);
			IDragActorPlayComponent.AddConfigs(builder, ConfigsOffset);
			IDragActorPlayComponent.AddNullMask(builder, NullMask);
			IDragActorPlayComponent.AddDisabled(builder, Disabled);
			return IDragActorPlayComponent.EndIDragActorPlayComponent(builder);
		}

		// Token: 0x0602327D RID: 143997 RVA: 0x004D6ABD File Offset: 0x004D4CBD
		public static void StartIDragActorPlayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602327E RID: 143998 RVA: 0x004D6AC6 File Offset: 0x004D4CC6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602327F RID: 143999 RVA: 0x004D6AD1 File Offset: 0x004D4CD1
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x06023280 RID: 144000 RVA: 0x004D6AE4 File Offset: 0x004D4CE4
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IDragActorPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023281 RID: 144001 RVA: 0x004D6B24 File Offset: 0x004D4D24
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDragActorPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDragActorPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023282 RID: 144002 RVA: 0x004D6B3E File Offset: 0x004D4D3E
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDragActorPlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDragActorPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023283 RID: 144003 RVA: 0x004D6B5C File Offset: 0x004D4D5C
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDragActorPlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023284 RID: 144004 RVA: 0x004D6B75 File Offset: 0x004D4D75
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023285 RID: 144005 RVA: 0x004D6B80 File Offset: 0x004D4D80
		public static void AddExitSendSelfEvent(FlatBufferBuilder builder, StringOffset exitSendSelfEventOffset)
		{
			builder.AddOffset(2, exitSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06023286 RID: 144006 RVA: 0x004D6B90 File Offset: 0x004D4D90
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06023287 RID: 144007 RVA: 0x004D6B9B File Offset: 0x004D4D9B
		public static Offset<IDragActorPlayComponent> EndIDragActorPlayComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDragActorPlayComponent>(builder.EndTable());
		}

		// Token: 0x06023288 RID: 144008 RVA: 0x004D6BA8 File Offset: 0x004D4DA8
		public IDragActorPlayComponentT UnPack()
		{
			IDragActorPlayComponentT dragActorPlayComponentT = new IDragActorPlayComponentT();
			this.UnPackTo(dragActorPlayComponentT);
			return dragActorPlayComponentT;
		}

		// Token: 0x06023289 RID: 144009 RVA: 0x004D6BC4 File Offset: 0x004D4DC4
		public void UnPackTo(IDragActorPlayComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Configs = new List<IDragActorPlayConfigT>();
			for (int i = 0; i < this.ConfigsLength; i++)
			{
				_o.Configs.Add((this.Configs(i) != null) ? this.Configs(i).Value.UnPack() : null);
			}
			_o.ExitSendSelfEvent = this.ExitSendSelfEvent;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602328A RID: 144010 RVA: 0x004D6C48 File Offset: 0x004D4E48
		public static Offset<IDragActorPlayComponent> Pack(FlatBufferBuilder builder, IDragActorPlayComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDragActorPlayComponent>);
			}
			VectorOffset configsOffset = default(VectorOffset);
			if (_o.Configs != null)
			{
				Offset<IDragActorPlayConfig>[] array = new Offset<IDragActorPlayConfig>[_o.Configs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IDragActorPlayConfig.Pack(builder, _o.Configs[i]);
				}
				configsOffset = IDragActorPlayComponent.CreateConfigsVector(builder, array);
			}
			StringOffset exitSendSelfEventOffset = (_o.ExitSendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.ExitSendSelfEvent);
			return IDragActorPlayComponent.CreateIDragActorPlayComponent(builder, _o.Disabled, configsOffset, exitSendSelfEventOffset, _o.NullMask);
		}

		// Token: 0x0400ECDC RID: 60636
		private Table __p;
	}
}
