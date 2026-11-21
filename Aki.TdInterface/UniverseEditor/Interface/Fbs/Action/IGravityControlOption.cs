using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F3B RID: 28475
	public struct IGravityControlOption : IFlatbufferObject
	{
		// Token: 0x1700D0B0 RID: 53424
		// (get) Token: 0x0603146C RID: 201836 RVA: 0x006ACF0C File Offset: 0x006AB10C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603146D RID: 201837 RVA: 0x006ACF19 File Offset: 0x006AB119
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603146E RID: 201838 RVA: 0x006ACF20 File Offset: 0x006AB120
		public static IGravityControlOption GetRootAsIGravityControlOption(ByteBuffer _bb)
		{
			return IGravityControlOption.GetRootAsIGravityControlOption(_bb, default(IGravityControlOption));
		}

		// Token: 0x0603146F RID: 201839 RVA: 0x006ACF3C File Offset: 0x006AB13C
		public static IGravityControlOption GetRootAsIGravityControlOption(ByteBuffer _bb, IGravityControlOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031470 RID: 201840 RVA: 0x006ACF59 File Offset: 0x006AB159
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031471 RID: 201841 RVA: 0x006ACF68 File Offset: 0x006AB168
		public IGravityControlOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0B1 RID: 53425
		// (get) Token: 0x06031472 RID: 201842 RVA: 0x006ACF78 File Offset: 0x006AB178
		public ESystemOptionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESystemOptionType.RogueRandomEvent;
				}
				return (ESystemOptionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06031473 RID: 201843 RVA: 0x006ACFB4 File Offset: 0x006AB1B4
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D0B2 RID: 53426
		// (get) Token: 0x06031474 RID: 201844 RVA: 0x006AD014 File Offset: 0x006AB214
		public int SystemOptionsLength
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

		// Token: 0x1700D0B3 RID: 53427
		// (get) Token: 0x06031475 RID: 201845 RVA: 0x006AD040 File Offset: 0x006AB240
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D0B4 RID: 53428
		// (get) Token: 0x06031476 RID: 201846 RVA: 0x006AD080 File Offset: 0x006AB280
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

		// Token: 0x06031477 RID: 201847 RVA: 0x006AD0BD File Offset: 0x006AB2BD
		public static Offset<IGravityControlOption> CreateIGravityControlOption(FlatBufferBuilder builder, ESystemOptionType Type = ESystemOptionType.RogueRandomEvent, VectorOffset SystemOptionsOffset = default(VectorOffset), bool KeepPreTalkItem = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGravityControlOption.AddSystemOptions(builder, SystemOptionsOffset);
			IGravityControlOption.AddNullMask(builder, NullMask);
			IGravityControlOption.AddKeepPreTalkItem(builder, KeepPreTalkItem);
			IGravityControlOption.AddType(builder, Type);
			return IGravityControlOption.EndIGravityControlOption(builder);
		}

		// Token: 0x06031478 RID: 201848 RVA: 0x006AD0E9 File Offset: 0x006AB2E9
		public static void StartIGravityControlOption(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06031479 RID: 201849 RVA: 0x006AD0F2 File Offset: 0x006AB2F2
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603147A RID: 201850 RVA: 0x006AD0FD File Offset: 0x006AB2FD
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x0603147B RID: 201851 RVA: 0x006AD110 File Offset: 0x006AB310
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603147C RID: 201852 RVA: 0x006AD150 File Offset: 0x006AB350
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603147D RID: 201853 RVA: 0x006AD16A File Offset: 0x006AB36A
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603147E RID: 201854 RVA: 0x006AD188 File Offset: 0x006AB388
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603147F RID: 201855 RVA: 0x006AD1A1 File Offset: 0x006AB3A1
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031480 RID: 201856 RVA: 0x006AD1AC File Offset: 0x006AB3AC
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x06031481 RID: 201857 RVA: 0x006AD1B7 File Offset: 0x006AB3B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06031482 RID: 201858 RVA: 0x006AD1C2 File Offset: 0x006AB3C2
		public static Offset<IGravityControlOption> EndIGravityControlOption(FlatBufferBuilder builder)
		{
			return new Offset<IGravityControlOption>(builder.EndTable());
		}

		// Token: 0x06031483 RID: 201859 RVA: 0x006AD1D0 File Offset: 0x006AB3D0
		public IGravityControlOptionT UnPack()
		{
			IGravityControlOptionT gravityControlOptionT = new IGravityControlOptionT();
			this.UnPackTo(gravityControlOptionT);
			return gravityControlOptionT;
		}

		// Token: 0x06031484 RID: 201860 RVA: 0x006AD1EC File Offset: 0x006AB3EC
		public void UnPackTo(IGravityControlOptionT _o)
		{
			_o.Type = this.Type;
			_o.SystemOptions = new List<ISystemOptionT>();
			for (int i = 0; i < this.SystemOptionsLength; i++)
			{
				_o.SystemOptions.Add((this.SystemOptions(i) != null) ? this.SystemOptions(i).Value.UnPack() : null);
			}
			_o.KeepPreTalkItem = this.KeepPreTalkItem;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06031485 RID: 201861 RVA: 0x006AD270 File Offset: 0x006AB470
		public static Offset<IGravityControlOption> Pack(FlatBufferBuilder builder, IGravityControlOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGravityControlOption>);
			}
			VectorOffset systemOptionsOffset = default(VectorOffset);
			if (_o.SystemOptions != null)
			{
				Offset<ISystemOption>[] array = new Offset<ISystemOption>[_o.SystemOptions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISystemOption.Pack(builder, _o.SystemOptions[i]);
				}
				systemOptionsOffset = IGravityControlOption.CreateSystemOptionsVector(builder, array);
			}
			return IGravityControlOption.CreateIGravityControlOption(builder, _o.Type, systemOptionsOffset, _o.KeepPreTalkItem, _o.NullMask);
		}

		// Token: 0x04011E3D RID: 73277
		private Table __p;
	}
}
