using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050B4 RID: 20660
	public struct IDragActorPlayComponent : IFlatbufferObject
	{
		// Token: 0x17009629 RID: 38441
		// (get) Token: 0x0602131B RID: 135963 RVA: 0x0049C93B File Offset: 0x0049AB3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602131C RID: 135964 RVA: 0x0049C948 File Offset: 0x0049AB48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602131D RID: 135965 RVA: 0x0049C950 File Offset: 0x0049AB50
		public static IDragActorPlayComponent GetRootAsIDragActorPlayComponent(ByteBuffer _bb)
		{
			return IDragActorPlayComponent.GetRootAsIDragActorPlayComponent(_bb, default(IDragActorPlayComponent));
		}

		// Token: 0x0602131E RID: 135966 RVA: 0x0049C96C File Offset: 0x0049AB6C
		public static IDragActorPlayComponent GetRootAsIDragActorPlayComponent(ByteBuffer _bb, IDragActorPlayComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602131F RID: 135967 RVA: 0x0049C989 File Offset: 0x0049AB89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021320 RID: 135968 RVA: 0x0049C998 File Offset: 0x0049AB98
		public IDragActorPlayComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700962A RID: 38442
		// (get) Token: 0x06021321 RID: 135969 RVA: 0x0049C9A8 File Offset: 0x0049ABA8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06021322 RID: 135970 RVA: 0x0049C9E8 File Offset: 0x0049ABE8
		public IDragActorPlayConfig? Configs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IDragActorPlayConfig?(default(IDragActorPlayConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700962B RID: 38443
		// (get) Token: 0x06021323 RID: 135971 RVA: 0x0049CA48 File Offset: 0x0049AC48
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

		// Token: 0x1700962C RID: 38444
		// (get) Token: 0x06021324 RID: 135972 RVA: 0x0049CA74 File Offset: 0x0049AC74
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

		// Token: 0x06021325 RID: 135973 RVA: 0x0049CAAB File Offset: 0x0049ACAB
		public Span<byte> GetExitSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06021326 RID: 135974 RVA: 0x0049CABA File Offset: 0x0049ACBA
		public byte[] GetExitSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700962D RID: 38445
		// (get) Token: 0x06021327 RID: 135975 RVA: 0x0049CAC8 File Offset: 0x0049ACC8
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

		// Token: 0x06021328 RID: 135976 RVA: 0x0049CB05 File Offset: 0x0049AD05
		public static Offset<IDragActorPlayComponent> CreateIDragActorPlayComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ConfigsOffset = default(VectorOffset), StringOffset ExitSendSelfEventOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IDragActorPlayComponent.AddExitSendSelfEvent(builder, ExitSendSelfEventOffset);
			IDragActorPlayComponent.AddConfigs(builder, ConfigsOffset);
			IDragActorPlayComponent.AddNullMask(builder, NullMask);
			IDragActorPlayComponent.AddDisabled(builder, Disabled);
			return IDragActorPlayComponent.EndIDragActorPlayComponent(builder);
		}

		// Token: 0x06021329 RID: 135977 RVA: 0x0049CB31 File Offset: 0x0049AD31
		public static void StartIDragActorPlayComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602132A RID: 135978 RVA: 0x0049CB3A File Offset: 0x0049AD3A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602132B RID: 135979 RVA: 0x0049CB45 File Offset: 0x0049AD45
		public static void AddConfigs(FlatBufferBuilder builder, VectorOffset configsOffset)
		{
			builder.AddOffset(1, configsOffset.Value, 0);
		}

		// Token: 0x0602132C RID: 135980 RVA: 0x0049CB58 File Offset: 0x0049AD58
		public static VectorOffset CreateConfigsVector(FlatBufferBuilder builder, Offset<IDragActorPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602132D RID: 135981 RVA: 0x0049CB98 File Offset: 0x0049AD98
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, Offset<IDragActorPlayConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IDragActorPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602132E RID: 135982 RVA: 0x0049CBB2 File Offset: 0x0049ADB2
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IDragActorPlayConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IDragActorPlayConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602132F RID: 135983 RVA: 0x0049CBD0 File Offset: 0x0049ADD0
		public static VectorOffset CreateConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IDragActorPlayConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021330 RID: 135984 RVA: 0x0049CBE9 File Offset: 0x0049ADE9
		public static void StartConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021331 RID: 135985 RVA: 0x0049CBF4 File Offset: 0x0049ADF4
		public static void AddExitSendSelfEvent(FlatBufferBuilder builder, StringOffset exitSendSelfEventOffset)
		{
			builder.AddOffset(2, exitSendSelfEventOffset.Value, 0);
		}

		// Token: 0x06021332 RID: 135986 RVA: 0x0049CC04 File Offset: 0x0049AE04
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021333 RID: 135987 RVA: 0x0049CC0F File Offset: 0x0049AE0F
		public static Offset<IDragActorPlayComponent> EndIDragActorPlayComponent(FlatBufferBuilder builder)
		{
			return new Offset<IDragActorPlayComponent>(builder.EndTable());
		}

		// Token: 0x06021334 RID: 135988 RVA: 0x0049CC1C File Offset: 0x0049AE1C
		public IDragActorPlayComponentT UnPack()
		{
			IDragActorPlayComponentT dragActorPlayComponentT = new IDragActorPlayComponentT();
			this.UnPackTo(dragActorPlayComponentT);
			return dragActorPlayComponentT;
		}

		// Token: 0x06021335 RID: 135989 RVA: 0x0049CC38 File Offset: 0x0049AE38
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

		// Token: 0x06021336 RID: 135990 RVA: 0x0049CCBC File Offset: 0x0049AEBC
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

		// Token: 0x0400E0DF RID: 57567
		private Table __p;
	}
}
