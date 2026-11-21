using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DC4 RID: 24004
	public struct IQteCallback : IFlatbufferObject
	{
		// Token: 0x1700B0C9 RID: 45257
		// (get) Token: 0x06028042 RID: 163906 RVA: 0x005790CC File Offset: 0x005772CC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028043 RID: 163907 RVA: 0x005790D9 File Offset: 0x005772D9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028044 RID: 163908 RVA: 0x005790E0 File Offset: 0x005772E0
		public static IQteCallback GetRootAsIQteCallback(ByteBuffer _bb)
		{
			return IQteCallback.GetRootAsIQteCallback(_bb, default(IQteCallback));
		}

		// Token: 0x06028045 RID: 163909 RVA: 0x005790FC File Offset: 0x005772FC
		public static IQteCallback GetRootAsIQteCallback(ByteBuffer _bb, IQteCallback obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028046 RID: 163910 RVA: 0x00579119 File Offset: 0x00577319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028047 RID: 163911 RVA: 0x00579128 File Offset: 0x00577328
		public IQteCallback __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x06028048 RID: 163912 RVA: 0x00579138 File Offset: 0x00577338
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(4);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B0CA RID: 45258
		// (get) Token: 0x06028049 RID: 163913 RVA: 0x00579198 File Offset: 0x00577398
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

		// Token: 0x1700B0CB RID: 45259
		// (get) Token: 0x0602804A RID: 163914 RVA: 0x005791C4 File Offset: 0x005773C4
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

		// Token: 0x0602804B RID: 163915 RVA: 0x005791FB File Offset: 0x005773FB
		public Span<byte> GetSendSelfEventBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602804C RID: 163916 RVA: 0x0057920A File Offset: 0x0057740A
		public byte[] GetSendSelfEventArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602804D RID: 163917 RVA: 0x00579218 File Offset: 0x00577418
		public static Offset<IQteCallback> CreateIQteCallback(FlatBufferBuilder builder, VectorOffset ActionsOffset = default(VectorOffset), StringOffset SendSelfEventOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IQteCallback.AddSendSelfEvent(builder, SendSelfEventOffset);
			IQteCallback.AddActions(builder, ActionsOffset);
			return IQteCallback.EndIQteCallback(builder);
		}

		// Token: 0x0602804E RID: 163918 RVA: 0x00579235 File Offset: 0x00577435
		public static void StartIQteCallback(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602804F RID: 163919 RVA: 0x0057923E File Offset: 0x0057743E
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(0, actionsOffset.Value, 0);
		}

		// Token: 0x06028050 RID: 163920 RVA: 0x00579250 File Offset: 0x00577450
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06028051 RID: 163921 RVA: 0x00579290 File Offset: 0x00577490
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028052 RID: 163922 RVA: 0x005792AA File Offset: 0x005774AA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06028053 RID: 163923 RVA: 0x005792C8 File Offset: 0x005774C8
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028054 RID: 163924 RVA: 0x005792E1 File Offset: 0x005774E1
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028055 RID: 163925 RVA: 0x005792EC File Offset: 0x005774EC
		public static void AddSendSelfEvent(FlatBufferBuilder builder, StringOffset sendSelfEventOffset)
		{
			builder.AddOffset(1, sendSelfEventOffset.Value, 0);
		}

		// Token: 0x06028056 RID: 163926 RVA: 0x005792FC File Offset: 0x005774FC
		public static Offset<IQteCallback> EndIQteCallback(FlatBufferBuilder builder)
		{
			return new Offset<IQteCallback>(builder.EndTable());
		}

		// Token: 0x06028057 RID: 163927 RVA: 0x0057930C File Offset: 0x0057750C
		public IQteCallbackT UnPack()
		{
			IQteCallbackT qteCallbackT = new IQteCallbackT();
			this.UnPackTo(qteCallbackT);
			return qteCallbackT;
		}

		// Token: 0x06028058 RID: 163928 RVA: 0x00579328 File Offset: 0x00577528
		public void UnPackTo(IQteCallbackT _o)
		{
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.SendSelfEvent = this.SendSelfEvent;
		}

		// Token: 0x06028059 RID: 163929 RVA: 0x00579394 File Offset: 0x00577594
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

		// Token: 0x0400F981 RID: 63873
		private Table __p;
	}
}
