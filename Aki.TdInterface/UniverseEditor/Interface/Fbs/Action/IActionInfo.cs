using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066DF RID: 26335
	public struct IActionInfo : IFlatbufferObject
	{
		// Token: 0x1700BF76 RID: 49014
		// (get) Token: 0x0602C410 RID: 181264 RVA: 0x00606818 File Offset: 0x00604A18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C411 RID: 181265 RVA: 0x00606825 File Offset: 0x00604A25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C412 RID: 181266 RVA: 0x0060682C File Offset: 0x00604A2C
		public static IActionInfo GetRootAsIActionInfo(ByteBuffer _bb)
		{
			return IActionInfo.GetRootAsIActionInfo(_bb, default(IActionInfo));
		}

		// Token: 0x0602C413 RID: 181267 RVA: 0x00606848 File Offset: 0x00604A48
		public static IActionInfo GetRootAsIActionInfo(ByteBuffer _bb, IActionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C414 RID: 181268 RVA: 0x00606865 File Offset: 0x00604A65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C415 RID: 181269 RVA: 0x00606874 File Offset: 0x00604A74
		public IActionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF77 RID: 49015
		// (get) Token: 0x0602C416 RID: 181270 RVA: 0x00606884 File Offset: 0x00604A84
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

		// Token: 0x1700BF78 RID: 49016
		// (get) Token: 0x0602C417 RID: 181271 RVA: 0x006068C0 File Offset: 0x00604AC0
		public bool Async
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF79 RID: 49017
		// (get) Token: 0x0602C418 RID: 181272 RVA: 0x00606900 File Offset: 0x00604B00
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

		// Token: 0x1700BF7A RID: 49018
		// (get) Token: 0x0602C419 RID: 181273 RVA: 0x00606960 File Offset: 0x00604B60
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

		// Token: 0x1700BF7B RID: 49019
		// (get) Token: 0x0602C41A RID: 181274 RVA: 0x006069A0 File Offset: 0x00604BA0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BF7C RID: 49020
		// (get) Token: 0x0602C41B RID: 181275 RVA: 0x006069E0 File Offset: 0x00604BE0
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

		// Token: 0x0602C41C RID: 181276 RVA: 0x00606A18 File Offset: 0x00604C18
		public Span<byte> GetActionGuidBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0602C41D RID: 181277 RVA: 0x00606A28 File Offset: 0x00604C28
		public byte[] GetActionGuidArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700BF7D RID: 49021
		// (get) Token: 0x0602C41E RID: 181278 RVA: 0x00606A38 File Offset: 0x00604C38
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

		// Token: 0x1700BF7E RID: 49022
		// (get) Token: 0x0602C41F RID: 181279 RVA: 0x00606A7C File Offset: 0x00604C7C
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

		// Token: 0x0602C420 RID: 181280 RVA: 0x00606ABC File Offset: 0x00604CBC
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

		// Token: 0x0602C421 RID: 181281 RVA: 0x00606B13 File Offset: 0x00604D13
		public static void StartIActionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602C422 RID: 181282 RVA: 0x00606B1C File Offset: 0x00604D1C
		public static void AddName(FlatBufferBuilder builder, EAction name)
		{
			builder.AddUshort(0, (ushort)name, 0);
		}

		// Token: 0x0602C423 RID: 181283 RVA: 0x00606B27 File Offset: 0x00604D27
		public static void AddAsync(FlatBufferBuilder builder, bool async)
		{
			builder.AddBool(1, async, false);
		}

		// Token: 0x0602C424 RID: 181284 RVA: 0x00606B32 File Offset: 0x00604D32
		public static void AddParams(FlatBufferBuilder builder, Offset<IActionParams_Union> paramsOffset)
		{
			builder.AddOffset(2, paramsOffset.Value, 0);
		}

		// Token: 0x0602C425 RID: 181285 RVA: 0x00606B42 File Offset: 0x00604D42
		public static void AddActionId(FlatBufferBuilder builder, int actionId)
		{
			builder.AddInt(3, actionId, 0);
		}

		// Token: 0x0602C426 RID: 181286 RVA: 0x00606B4D File Offset: 0x00604D4D
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(4, disabled, false);
		}

		// Token: 0x0602C427 RID: 181287 RVA: 0x00606B58 File Offset: 0x00604D58
		public static void AddActionGuid(FlatBufferBuilder builder, StringOffset actionGuidOffset)
		{
			builder.AddOffset(5, actionGuidOffset.Value, 0);
		}

		// Token: 0x0602C428 RID: 181288 RVA: 0x00606B68 File Offset: 0x00604D68
		public static void AddTimeout(FlatBufferBuilder builder, float timeout)
		{
			builder.AddFloat(6, timeout, 0.0);
		}

		// Token: 0x0602C429 RID: 181289 RVA: 0x00606B7B File Offset: 0x00604D7B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602C42A RID: 181290 RVA: 0x00606B86 File Offset: 0x00604D86
		public static Offset<IActionInfo> EndIActionInfo(FlatBufferBuilder builder)
		{
			return new Offset<IActionInfo>(builder.EndTable());
		}

		// Token: 0x0602C42B RID: 181291 RVA: 0x00606B94 File Offset: 0x00604D94
		public IActionInfoT UnPack()
		{
			IActionInfoT actionInfoT = new IActionInfoT();
			this.UnPackTo(actionInfoT);
			return actionInfoT;
		}

		// Token: 0x0602C42C RID: 181292 RVA: 0x00606BB0 File Offset: 0x00604DB0
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

		// Token: 0x0602C42D RID: 181293 RVA: 0x00606C40 File Offset: 0x00604E40
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

		// Token: 0x04011046 RID: 69702
		private Table __p;
	}
}
