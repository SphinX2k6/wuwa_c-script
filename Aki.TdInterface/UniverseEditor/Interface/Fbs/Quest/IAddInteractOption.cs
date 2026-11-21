using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004109 RID: 16649
	public struct IAddInteractOption : IFlatbufferObject
	{
		// Token: 0x170070A8 RID: 28840
		// (get) Token: 0x06016CFD RID: 93437 RVA: 0x00341C0E File Offset: 0x0033FE0E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016CFE RID: 93438 RVA: 0x00341C1B File Offset: 0x0033FE1B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016CFF RID: 93439 RVA: 0x00341C24 File Offset: 0x0033FE24
		public static IAddInteractOption GetRootAsIAddInteractOption(ByteBuffer _bb)
		{
			return IAddInteractOption.GetRootAsIAddInteractOption(_bb, default(IAddInteractOption));
		}

		// Token: 0x06016D00 RID: 93440 RVA: 0x00341C40 File Offset: 0x0033FE40
		public static IAddInteractOption GetRootAsIAddInteractOption(ByteBuffer _bb, IAddInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016D01 RID: 93441 RVA: 0x00341C5D File Offset: 0x0033FE5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016D02 RID: 93442 RVA: 0x00341C6C File Offset: 0x0033FE6C
		public IAddInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070A9 RID: 28841
		// (get) Token: 0x06016D03 RID: 93443 RVA: 0x00341C7C File Offset: 0x0033FE7C
		public IInteractOption? Option
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IInteractOption?(default(IInteractOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170070AA RID: 28842
		// (get) Token: 0x06016D04 RID: 93444 RVA: 0x00341CDC File Offset: 0x0033FEDC
		public int EntityId
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

		// Token: 0x170070AB RID: 28843
		// (get) Token: 0x06016D05 RID: 93445 RVA: 0x00341D18 File Offset: 0x0033FF18
		public bool IsManualFinish
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070AC RID: 28844
		// (get) Token: 0x06016D06 RID: 93446 RVA: 0x00341D58 File Offset: 0x0033FF58
		public bool IsManualDelete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170070AD RID: 28845
		// (get) Token: 0x06016D07 RID: 93447 RVA: 0x00341D98 File Offset: 0x0033FF98
		public string InteractToken
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

		// Token: 0x06016D08 RID: 93448 RVA: 0x00341DD0 File Offset: 0x0033FFD0
		public Span<byte> GetInteractTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06016D09 RID: 93449 RVA: 0x00341DE0 File Offset: 0x0033FFE0
		public byte[] GetInteractTokenArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170070AE RID: 28846
		// (get) Token: 0x06016D0A RID: 93450 RVA: 0x00341DF0 File Offset: 0x0033FFF0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06016D0B RID: 93451 RVA: 0x00341E2D File Offset: 0x0034002D
		public static Offset<IAddInteractOption> CreateIAddInteractOption(FlatBufferBuilder builder, Offset<IInteractOption> OptionOffset = default(Offset<IInteractOption>), int EntityId = 0, bool IsManualFinish = false, bool IsManualDelete = false, StringOffset InteractTokenOffset = default(StringOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IAddInteractOption.AddInteractToken(builder, InteractTokenOffset);
			IAddInteractOption.AddEntityId(builder, EntityId);
			IAddInteractOption.AddOption(builder, OptionOffset);
			IAddInteractOption.AddNullMask(builder, NullMask);
			IAddInteractOption.AddIsManualDelete(builder, IsManualDelete);
			IAddInteractOption.AddIsManualFinish(builder, IsManualFinish);
			return IAddInteractOption.EndIAddInteractOption(builder);
		}

		// Token: 0x06016D0C RID: 93452 RVA: 0x00341E69 File Offset: 0x00340069
		public static void StartIAddInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06016D0D RID: 93453 RVA: 0x00341E72 File Offset: 0x00340072
		public static void AddOption(FlatBufferBuilder builder, Offset<IInteractOption> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x06016D0E RID: 93454 RVA: 0x00341E82 File Offset: 0x00340082
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06016D0F RID: 93455 RVA: 0x00341E8D File Offset: 0x0034008D
		public static void AddIsManualFinish(FlatBufferBuilder builder, bool isManualFinish)
		{
			builder.AddBool(2, isManualFinish, false);
		}

		// Token: 0x06016D10 RID: 93456 RVA: 0x00341E98 File Offset: 0x00340098
		public static void AddIsManualDelete(FlatBufferBuilder builder, bool isManualDelete)
		{
			builder.AddBool(3, isManualDelete, false);
		}

		// Token: 0x06016D11 RID: 93457 RVA: 0x00341EA3 File Offset: 0x003400A3
		public static void AddInteractToken(FlatBufferBuilder builder, StringOffset interactTokenOffset)
		{
			builder.AddOffset(4, interactTokenOffset.Value, 0);
		}

		// Token: 0x06016D12 RID: 93458 RVA: 0x00341EB3 File Offset: 0x003400B3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06016D13 RID: 93459 RVA: 0x00341EBE File Offset: 0x003400BE
		public static Offset<IAddInteractOption> EndIAddInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IAddInteractOption>(builder.EndTable());
		}

		// Token: 0x06016D14 RID: 93460 RVA: 0x00341ECC File Offset: 0x003400CC
		public IAddInteractOptionT UnPack()
		{
			IAddInteractOptionT addInteractOptionT = new IAddInteractOptionT();
			this.UnPackTo(addInteractOptionT);
			return addInteractOptionT;
		}

		// Token: 0x06016D15 RID: 93461 RVA: 0x00341EE8 File Offset: 0x003400E8
		public void UnPackTo(IAddInteractOptionT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.IsManualFinish = this.IsManualFinish;
			_o.IsManualDelete = this.IsManualDelete;
			_o.InteractToken = this.InteractToken;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016D16 RID: 93462 RVA: 0x00341F60 File Offset: 0x00340160
		public static Offset<IAddInteractOption> Pack(FlatBufferBuilder builder, IAddInteractOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddInteractOption>);
			}
			Offset<IInteractOption> optionOffset = (_o.Option == null) ? default(Offset<IInteractOption>) : IInteractOption.Pack(builder, _o.Option);
			StringOffset interactTokenOffset = (_o.InteractToken == null) ? default(StringOffset) : builder.CreateString(_o.InteractToken);
			return IAddInteractOption.CreateIAddInteractOption(builder, optionOffset, _o.EntityId, _o.IsManualFinish, _o.IsManualDelete, interactTokenOffset, _o.NullMask);
		}

		// Token: 0x0400BF3F RID: 48959
		private Table __p;
	}
}
