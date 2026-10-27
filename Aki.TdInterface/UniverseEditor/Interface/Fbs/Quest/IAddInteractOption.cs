using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003CF2 RID: 15602
	public struct IAddInteractOption : IFlatbufferObject
	{
		// Token: 0x17006AEE RID: 27374
		// (get) Token: 0x060157C5 RID: 88005 RVA: 0x0031A996 File Offset: 0x00318B96
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060157C6 RID: 88006 RVA: 0x0031A9A3 File Offset: 0x00318BA3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060157C7 RID: 88007 RVA: 0x0031A9AC File Offset: 0x00318BAC
		public static IAddInteractOption GetRootAsIAddInteractOption(ByteBuffer _bb)
		{
			return IAddInteractOption.GetRootAsIAddInteractOption(_bb, default(IAddInteractOption));
		}

		// Token: 0x060157C8 RID: 88008 RVA: 0x0031A9C8 File Offset: 0x00318BC8
		public static IAddInteractOption GetRootAsIAddInteractOption(ByteBuffer _bb, IAddInteractOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060157C9 RID: 88009 RVA: 0x0031A9E5 File Offset: 0x00318BE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060157CA RID: 88010 RVA: 0x0031A9F4 File Offset: 0x00318BF4
		public IAddInteractOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006AEF RID: 27375
		// (get) Token: 0x060157CB RID: 88011 RVA: 0x0031AA04 File Offset: 0x00318C04
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

		// Token: 0x17006AF0 RID: 27376
		// (get) Token: 0x060157CC RID: 88012 RVA: 0x0031AA64 File Offset: 0x00318C64
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

		// Token: 0x17006AF1 RID: 27377
		// (get) Token: 0x060157CD RID: 88013 RVA: 0x0031AAA0 File Offset: 0x00318CA0
		public bool IsManualFinish
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006AF2 RID: 27378
		// (get) Token: 0x060157CE RID: 88014 RVA: 0x0031AAE0 File Offset: 0x00318CE0
		public bool IsManualDelete
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006AF3 RID: 27379
		// (get) Token: 0x060157CF RID: 88015 RVA: 0x0031AB20 File Offset: 0x00318D20
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

		// Token: 0x060157D0 RID: 88016 RVA: 0x0031AB58 File Offset: 0x00318D58
		public Span<byte> GetInteractTokenBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060157D1 RID: 88017 RVA: 0x0031AB68 File Offset: 0x00318D68
		public byte[] GetInteractTokenArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x17006AF4 RID: 27380
		// (get) Token: 0x060157D2 RID: 88018 RVA: 0x0031AB78 File Offset: 0x00318D78
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

		// Token: 0x060157D3 RID: 88019 RVA: 0x0031ABB5 File Offset: 0x00318DB5
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

		// Token: 0x060157D4 RID: 88020 RVA: 0x0031ABF1 File Offset: 0x00318DF1
		public static void StartIAddInteractOption(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060157D5 RID: 88021 RVA: 0x0031ABFA File Offset: 0x00318DFA
		public static void AddOption(FlatBufferBuilder builder, Offset<IInteractOption> optionOffset)
		{
			builder.AddOffset(0, optionOffset.Value, 0);
		}

		// Token: 0x060157D6 RID: 88022 RVA: 0x0031AC0A File Offset: 0x00318E0A
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x060157D7 RID: 88023 RVA: 0x0031AC15 File Offset: 0x00318E15
		public static void AddIsManualFinish(FlatBufferBuilder builder, bool isManualFinish)
		{
			builder.AddBool(2, isManualFinish, false);
		}

		// Token: 0x060157D8 RID: 88024 RVA: 0x0031AC20 File Offset: 0x00318E20
		public static void AddIsManualDelete(FlatBufferBuilder builder, bool isManualDelete)
		{
			builder.AddBool(3, isManualDelete, false);
		}

		// Token: 0x060157D9 RID: 88025 RVA: 0x0031AC2B File Offset: 0x00318E2B
		public static void AddInteractToken(FlatBufferBuilder builder, StringOffset interactTokenOffset)
		{
			builder.AddOffset(4, interactTokenOffset.Value, 0);
		}

		// Token: 0x060157DA RID: 88026 RVA: 0x0031AC3B File Offset: 0x00318E3B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x060157DB RID: 88027 RVA: 0x0031AC46 File Offset: 0x00318E46
		public static Offset<IAddInteractOption> EndIAddInteractOption(FlatBufferBuilder builder)
		{
			return new Offset<IAddInteractOption>(builder.EndTable());
		}

		// Token: 0x060157DC RID: 88028 RVA: 0x0031AC54 File Offset: 0x00318E54
		public IAddInteractOptionT UnPack()
		{
			IAddInteractOptionT addInteractOptionT = new IAddInteractOptionT();
			this.UnPackTo(addInteractOptionT);
			return addInteractOptionT;
		}

		// Token: 0x060157DD RID: 88029 RVA: 0x0031AC70 File Offset: 0x00318E70
		public void UnPackTo(IAddInteractOptionT _o)
		{
			_o.Option = ((this.Option != null) ? this.Option.Value.UnPack() : null);
			_o.EntityId = this.EntityId;
			_o.IsManualFinish = this.IsManualFinish;
			_o.IsManualDelete = this.IsManualDelete;
			_o.InteractToken = this.InteractToken;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060157DE RID: 88030 RVA: 0x0031ACE8 File Offset: 0x00318EE8
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

		// Token: 0x0400B592 RID: 46482
		private Table __p;
	}
}
