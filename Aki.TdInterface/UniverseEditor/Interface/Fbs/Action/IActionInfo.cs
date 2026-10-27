using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200607D RID: 24701
	public struct IActionInfo : IFlatbufferObject
	{
		// Token: 0x1700B60B RID: 46603
		// (get) Token: 0x06029D5C RID: 171356 RVA: 0x005BD334 File Offset: 0x005BB534
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029D5D RID: 171357 RVA: 0x005BD341 File Offset: 0x005BB541
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029D5E RID: 171358 RVA: 0x005BD348 File Offset: 0x005BB548
		public static IActionInfo GetRootAsIActionInfo(ByteBuffer _bb)
		{
			return IActionInfo.GetRootAsIActionInfo(_bb, default(IActionInfo));
		}

		// Token: 0x06029D5F RID: 171359 RVA: 0x005BD364 File Offset: 0x005BB564
		public static IActionInfo GetRootAsIActionInfo(ByteBuffer _bb, IActionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029D60 RID: 171360 RVA: 0x005BD381 File Offset: 0x005BB581
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029D61 RID: 171361 RVA: 0x005BD390 File Offset: 0x005BB590
		public IActionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B60C RID: 46604
		// (get) Token: 0x06029D62 RID: 171362 RVA: 0x005BD3A0 File Offset: 0x005BB5A0
		public EAction Name
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAction.Undefined;
				}
				return (EAction)this.__p.bb.GetUshort(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B60D RID: 46605
		// (get) Token: 0x06029D63 RID: 171363 RVA: 0x005BD3DC File Offset: 0x005BB5DC
		public bool Async
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B60E RID: 46606
		// (get) Token: 0x06029D64 RID: 171364 RVA: 0x005BD41C File Offset: 0x005BB61C
		public IActionParams_Union? Params
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IActionParams_Union?(default(IActionParams_Union).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B60F RID: 46607
		// (get) Token: 0x06029D65 RID: 171365 RVA: 0x005BD47C File Offset: 0x005BB67C
		public int ActionId
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

		// Token: 0x1700B610 RID: 46608
		// (get) Token: 0x06029D66 RID: 171366 RVA: 0x005BD4BC File Offset: 0x005BB6BC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B611 RID: 46609
		// (get) Token: 0x06029D67 RID: 171367 RVA: 0x005BD4FC File Offset: 0x005BB6FC
		public string ActionGuid
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029D68 RID: 171368 RVA: 0x005BD534 File Offset: 0x005BB734
		public Span<byte> GetActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06029D69 RID: 171369 RVA: 0x005BD544 File Offset: 0x005BB744
		public byte[] GetActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700B612 RID: 46610
		// (get) Token: 0x06029D6A RID: 171370 RVA: 0x005BD554 File Offset: 0x005BB754
		public float Timeout
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B613 RID: 46611
		// (get) Token: 0x06029D6B RID: 171371 RVA: 0x005BD598 File Offset: 0x005BB798
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029D6C RID: 171372 RVA: 0x005BD5D8 File Offset: 0x005BB7D8
		public static Offset<IActionInfo> CreateIActionInfo(FlatBufferBuilder builder, EAction Name = EAction.Undefined, bool Async = false, Offset<IActionParams_Union> ParamsOffset = default(Offset<IActionParams_Union>), int ActionId = 0, bool Disabled = false, StringOffset ActionGuidOffset = default(StringOffset), float Timeout = 0f, byte NullMask = 0)
		{
			builder.StartTable(8);
			IActionInfo.AddTimeout(builder, Timeout);
			IActionInfo.AddActionGuid(builder, ActionGuidOffset);
			IActionInfo.AddActionId(builder, ActionId);
			IActionInfo.AddParams(builder, ParamsOffset);
			IActionInfo.AddName(builder, Name);
			IActionInfo.AddNullMask(builder, NullMask);
			IActionInfo.AddDisabled(builder, Disabled);
			IActionInfo.AddAsync(builder, Async);
			return IActionInfo.EndIActionInfo(builder);
		}

		// Token: 0x06029D6D RID: 171373 RVA: 0x005BD62F File Offset: 0x005BB82F
		public static void StartIActionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06029D6E RID: 171374 RVA: 0x005BD638 File Offset: 0x005BB838
		public static void AddName(FlatBufferBuilder builder, EAction name)
		{
			builder.AddUshort(0, (ushort)name, 0);
		}

		// Token: 0x06029D6F RID: 171375 RVA: 0x005BD643 File Offset: 0x005BB843
		public static void AddAsync(FlatBufferBuilder builder, bool async)
		{
			builder.AddBool(1, async, false);
		}

		// Token: 0x06029D70 RID: 171376 RVA: 0x005BD64E File Offset: 0x005BB84E
		public static void AddParams(FlatBufferBuilder builder, Offset<IActionParams_Union> paramsOffset)
		{
			builder.AddOffset(2, paramsOffset.Value, 0);
		}

		// Token: 0x06029D71 RID: 171377 RVA: 0x005BD65E File Offset: 0x005BB85E
		public static void AddActionId(FlatBufferBuilder builder, int actionId)
		{
			builder.AddInt(3, actionId, 0);
		}

		// Token: 0x06029D72 RID: 171378 RVA: 0x005BD669 File Offset: 0x005BB869
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(4, disabled, false);
		}

		// Token: 0x06029D73 RID: 171379 RVA: 0x005BD674 File Offset: 0x005BB874
		public static void AddActionGuid(FlatBufferBuilder builder, StringOffset actionGuidOffset)
		{
			builder.AddOffset(5, actionGuidOffset.Value, 0);
		}

		// Token: 0x06029D74 RID: 171380 RVA: 0x005BD684 File Offset: 0x005BB884
		public static void AddTimeout(FlatBufferBuilder builder, float timeout)
		{
			builder.AddFloat(6, timeout, 0.0);
		}

		// Token: 0x06029D75 RID: 171381 RVA: 0x005BD697 File Offset: 0x005BB897
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06029D76 RID: 171382 RVA: 0x005BD6A2 File Offset: 0x005BB8A2
		public static Offset<IActionInfo> EndIActionInfo(FlatBufferBuilder builder)
		{
			return new Offset<IActionInfo>(builder.EndTable());
		}

		// Token: 0x06029D77 RID: 171383 RVA: 0x005BD6B0 File Offset: 0x005BB8B0
		public IActionInfoT UnPack()
		{
			IActionInfoT actionInfoT = new IActionInfoT();
			this.UnPackTo(actionInfoT);
			return actionInfoT;
		}

		// Token: 0x06029D78 RID: 171384 RVA: 0x005BD6CC File Offset: 0x005BB8CC
		public void UnPackTo(IActionInfoT _o)
		{
			_o.Name = this.Name;
			_o.Async = this.Async;
			_o.Params = ((this.Params != null) ? this.Params.Value.UnPack() : null);
			_o.ActionId = this.ActionId;
			_o.Disabled = this.Disabled;
			_o.ActionGuid = this.ActionGuid;
			_o.Timeout = this.Timeout;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029D79 RID: 171385 RVA: 0x005BD75C File Offset: 0x005BB95C
		public static Offset<IActionInfo> Pack(FlatBufferBuilder builder, IActionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IActionInfo>);
			}
			Offset<IActionParams_Union> paramsOffset = (_o.Params == null) ? default(Offset<IActionParams_Union>) : IActionParams_Union.Pack(builder, _o.Params);
			StringOffset actionGuidOffset = (_o.ActionGuid == null) ? default(StringOffset) : builder.CreateString(_o.ActionGuid);
			return IActionInfo.CreateIActionInfo(builder, _o.Name, _o.Async, paramsOffset, _o.ActionId, _o.Disabled, actionGuidOffset, _o.Timeout, _o.NullMask);
		}

		// Token: 0x04010251 RID: 66129
		private Table __p;
	}
}
