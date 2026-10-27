using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689A RID: 26778
	public struct IGravityControlOption : IFlatbufferObject
	{
		// Token: 0x1700C6CA RID: 50890
		// (get) Token: 0x0602EB32 RID: 191282 RVA: 0x0065DE8C File Offset: 0x0065C08C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EB33 RID: 191283 RVA: 0x0065DE99 File Offset: 0x0065C099
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EB34 RID: 191284 RVA: 0x0065DEA0 File Offset: 0x0065C0A0
		public static IGravityControlOption GetRootAsIGravityControlOption(ByteBuffer _bb)
		{
			return IGravityControlOption.GetRootAsIGravityControlOption(_bb, default(IGravityControlOption));
		}

		// Token: 0x0602EB35 RID: 191285 RVA: 0x0065DEBC File Offset: 0x0065C0BC
		public static IGravityControlOption GetRootAsIGravityControlOption(ByteBuffer _bb, IGravityControlOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EB36 RID: 191286 RVA: 0x0065DED9 File Offset: 0x0065C0D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EB37 RID: 191287 RVA: 0x0065DEE8 File Offset: 0x0065C0E8
		public IGravityControlOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6CB RID: 50891
		// (get) Token: 0x0602EB38 RID: 191288 RVA: 0x0065DEF8 File Offset: 0x0065C0F8
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

		// Token: 0x0602EB39 RID: 191289 RVA: 0x0065DF34 File Offset: 0x0065C134
		public ISystemOption? SystemOptions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISystemOption?(default(ISystemOption).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C6CC RID: 50892
		// (get) Token: 0x0602EB3A RID: 191290 RVA: 0x0065DF94 File Offset: 0x0065C194
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

		// Token: 0x1700C6CD RID: 50893
		// (get) Token: 0x0602EB3B RID: 191291 RVA: 0x0065DFC0 File Offset: 0x0065C1C0
		public bool KeepPreTalkItem
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C6CE RID: 50894
		// (get) Token: 0x0602EB3C RID: 191292 RVA: 0x0065E000 File Offset: 0x0065C200
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

		// Token: 0x0602EB3D RID: 191293 RVA: 0x0065E03D File Offset: 0x0065C23D
		public static Offset<IGravityControlOption> CreateIGravityControlOption(FlatBufferBuilder builder, ESystemOptionType Type = ESystemOptionType.RogueRandomEvent, VectorOffset SystemOptionsOffset = default(VectorOffset), bool KeepPreTalkItem = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IGravityControlOption.AddSystemOptions(builder, SystemOptionsOffset);
			IGravityControlOption.AddNullMask(builder, NullMask);
			IGravityControlOption.AddKeepPreTalkItem(builder, KeepPreTalkItem);
			IGravityControlOption.AddType(builder, Type);
			return IGravityControlOption.EndIGravityControlOption(builder);
		}

		// Token: 0x0602EB3E RID: 191294 RVA: 0x0065E069 File Offset: 0x0065C269
		public static void StartIGravityControlOption(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602EB3F RID: 191295 RVA: 0x0065E072 File Offset: 0x0065C272
		public static void AddType(FlatBufferBuilder builder, ESystemOptionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EB40 RID: 191296 RVA: 0x0065E07D File Offset: 0x0065C27D
		public static void AddSystemOptions(FlatBufferBuilder builder, VectorOffset systemOptionsOffset)
		{
			builder.AddOffset(1, systemOptionsOffset.Value, 0);
		}

		// Token: 0x0602EB41 RID: 191297 RVA: 0x0065E090 File Offset: 0x0065C290
		public static VectorOffset CreateSystemOptionsVector(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602EB42 RID: 191298 RVA: 0x0065E0D0 File Offset: 0x0065C2D0
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, Offset<ISystemOption>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB43 RID: 191299 RVA: 0x0065E0EA File Offset: 0x0065C2EA
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISystemOption>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISystemOption>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602EB44 RID: 191300 RVA: 0x0065E108 File Offset: 0x0065C308
		public static VectorOffset CreateSystemOptionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISystemOption>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602EB45 RID: 191301 RVA: 0x0065E121 File Offset: 0x0065C321
		public static void StartSystemOptionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602EB46 RID: 191302 RVA: 0x0065E12C File Offset: 0x0065C32C
		public static void AddKeepPreTalkItem(FlatBufferBuilder builder, bool keepPreTalkItem)
		{
			builder.AddBool(2, keepPreTalkItem, false);
		}

		// Token: 0x0602EB47 RID: 191303 RVA: 0x0065E137 File Offset: 0x0065C337
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x0602EB48 RID: 191304 RVA: 0x0065E142 File Offset: 0x0065C342
		public static Offset<IGravityControlOption> EndIGravityControlOption(FlatBufferBuilder builder)
		{
			return new Offset<IGravityControlOption>(builder.EndTable());
		}

		// Token: 0x0602EB49 RID: 191305 RVA: 0x0065E150 File Offset: 0x0065C350
		public IGravityControlOptionT UnPack()
		{
			IGravityControlOptionT gravityControlOptionT = new IGravityControlOptionT();
			this.UnPackTo(gravityControlOptionT);
			return gravityControlOptionT;
		}

		// Token: 0x0602EB4A RID: 191306 RVA: 0x0065E16C File Offset: 0x0065C36C
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

		// Token: 0x0602EB4B RID: 191307 RVA: 0x0065E1F0 File Offset: 0x0065C3F0
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

		// Token: 0x04010FE8 RID: 69608
		private Table __p;
	}
}
