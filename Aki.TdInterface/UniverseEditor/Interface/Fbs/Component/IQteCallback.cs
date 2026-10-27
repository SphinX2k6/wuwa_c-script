using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057BD RID: 22461
	public struct IQteCallback : IFlatbufferObject
	{
		// Token: 0x1700A7A5 RID: 42917
		// (get) Token: 0x06025B22 RID: 154402 RVA: 0x00532F40 File Offset: 0x00531140
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025B23 RID: 154403 RVA: 0x00532F4D File Offset: 0x0053114D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025B24 RID: 154404 RVA: 0x00532F54 File Offset: 0x00531154
		public static IQteCallback GetRootAsIQteCallback(ByteBuffer _bb)
		{
			return IQteCallback.GetRootAsIQteCallback(_bb, default(IQteCallback));
		}

		// Token: 0x06025B25 RID: 154405 RVA: 0x00532F70 File Offset: 0x00531170
		public static IQteCallback GetRootAsIQteCallback(ByteBuffer _bb, IQteCallback obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025B26 RID: 154406 RVA: 0x00532F8D File Offset: 0x0053118D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025B27 RID: 154407 RVA: 0x00532F9C File Offset: 0x0053119C
		public IQteCallback __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06025B28 RID: 154408 RVA: 0x00532FAC File Offset: 0x005311AC
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A7A6 RID: 42918
		// (get) Token: 0x06025B29 RID: 154409 RVA: 0x0053300C File Offset: 0x0053120C
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A7A7 RID: 42919
		// (get) Token: 0x06025B2A RID: 154410 RVA: 0x00533038 File Offset: 0x00531238
		public string SendSelfEvent
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025B2B RID: 154411 RVA: 0x0053306F File Offset: 0x0053126F
		public Span<byte> GetSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06025B2C RID: 154412 RVA: 0x0053307E File Offset: 0x0053127E
		public byte[] GetSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06025B2D RID: 154413 RVA: 0x0053308C File Offset: 0x0053128C
		public static Offset<IQteCallback> CreateIQteCallback(FlatBufferBuilder builder, VectorOffset ActionsOffset = default(VectorOffset), StringOffset SendSelfEventOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IQteCallback.AddSendSelfEvent(builder, SendSelfEventOffset);
			IQteCallback.AddActions(builder, ActionsOffset);
			return IQteCallback.EndIQteCallback(builder);
		}

		// Token: 0x06025B2E RID: 154414 RVA: 0x005330A9 File Offset: 0x005312A9
		public static void StartIQteCallback(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06025B2F RID: 154415 RVA: 0x005330B2 File Offset: 0x005312B2
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(0, actionsOffset.Value, 0);
		}

		// Token: 0x06025B30 RID: 154416 RVA: 0x005330C4 File Offset: 0x005312C4
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025B31 RID: 154417 RVA: 0x00533104 File Offset: 0x00531304
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B32 RID: 154418 RVA: 0x0053311E File Offset: 0x0053131E
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06025B33 RID: 154419 RVA: 0x0053313C File Offset: 0x0053133C
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025B34 RID: 154420 RVA: 0x00533155 File Offset: 0x00531355
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025B35 RID: 154421 RVA: 0x00533160 File Offset: 0x00531360
		public static void AddSendSelfEvent(FlatBufferBuilder builder, StringOffset sendSelfEventOffset)
		{
			builder.AddOffset(1, sendSelfEventOffset.Value, 0);
		}

		// Token: 0x06025B36 RID: 154422 RVA: 0x00533170 File Offset: 0x00531370
		public static Offset<IQteCallback> EndIQteCallback(FlatBufferBuilder builder)
		{
			return new Offset<IQteCallback>(builder.EndTable());
		}

		// Token: 0x06025B37 RID: 154423 RVA: 0x00533180 File Offset: 0x00531380
		public IQteCallbackT UnPack()
		{
			IQteCallbackT qteCallbackT = new IQteCallbackT();
			this.UnPackTo(qteCallbackT);
			return qteCallbackT;
		}

		// Token: 0x06025B38 RID: 154424 RVA: 0x0053319C File Offset: 0x0053139C
		public void UnPackTo(IQteCallbackT _o)
		{
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.SendSelfEvent = this.SendSelfEvent;
		}

		// Token: 0x06025B39 RID: 154425 RVA: 0x00533208 File Offset: 0x00531408
		public static Offset<IQteCallback> Pack(FlatBufferBuilder builder, IQteCallbackT _o)
		{
			if (_o == null)
			{
				return default(Offset<IQteCallback>);
			}
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IQteCallback.CreateActionsVector(builder, array);
			}
			StringOffset sendSelfEventOffset = (_o.SendSelfEvent == null) ? default(StringOffset) : builder.CreateString(_o.SendSelfEvent);
			return IQteCallback.CreateIQteCallback(builder, actionsOffset, sendSelfEventOffset);
		}

		// Token: 0x0400EC96 RID: 60566
		private Table __p;
	}
}
