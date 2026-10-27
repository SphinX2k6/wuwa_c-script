using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C37 RID: 15415
	public struct IRequestResult : IFlatbufferObject
	{
		// Token: 0x17006A29 RID: 27177
		// (get) Token: 0x0601548F RID: 87183 RVA: 0x00314BDE File Offset: 0x00312DDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015490 RID: 87184 RVA: 0x00314BEB File Offset: 0x00312DEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015491 RID: 87185 RVA: 0x00314BF4 File Offset: 0x00312DF4
		public static IRequestResult GetRootAsIRequestResult(ByteBuffer _bb)
		{
			return IRequestResult.GetRootAsIRequestResult(_bb, default(IRequestResult));
		}

		// Token: 0x06015492 RID: 87186 RVA: 0x00314C10 File Offset: 0x00312E10
		public static IRequestResult GetRootAsIRequestResult(ByteBuffer _bb, IRequestResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015493 RID: 87187 RVA: 0x00314C2D File Offset: 0x00312E2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015494 RID: 87188 RVA: 0x00314C3C File Offset: 0x00312E3C
		public IRequestResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A2A RID: 27178
		// (get) Token: 0x06015495 RID: 87189 RVA: 0x00314C4C File Offset: 0x00312E4C
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006A2B RID: 27179
		// (get) Token: 0x06015496 RID: 87190 RVA: 0x00314C8C File Offset: 0x00312E8C
		public string Reason
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

		// Token: 0x06015497 RID: 87191 RVA: 0x00314CC3 File Offset: 0x00312EC3
		public Span<byte> GetReasonBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06015498 RID: 87192 RVA: 0x00314CD2 File Offset: 0x00312ED2
		public byte[] GetReasonArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06015499 RID: 87193 RVA: 0x00314CE0 File Offset: 0x00312EE0
		public static Offset<IRequestResult> CreateIRequestResult(FlatBufferBuilder builder, bool IsSuccess = false, StringOffset ReasonOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IRequestResult.AddReason(builder, ReasonOffset);
			IRequestResult.AddIsSuccess(builder, IsSuccess);
			return IRequestResult.EndIRequestResult(builder);
		}

		// Token: 0x0601549A RID: 87194 RVA: 0x00314CFD File Offset: 0x00312EFD
		public static void StartIRequestResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601549B RID: 87195 RVA: 0x00314D06 File Offset: 0x00312F06
		public static void AddIsSuccess(FlatBufferBuilder builder, bool isSuccess)
		{
			builder.AddBool(0, isSuccess, false);
		}

		// Token: 0x0601549C RID: 87196 RVA: 0x00314D11 File Offset: 0x00312F11
		public static void AddReason(FlatBufferBuilder builder, StringOffset reasonOffset)
		{
			builder.AddOffset(1, reasonOffset.Value, 0);
		}

		// Token: 0x0601549D RID: 87197 RVA: 0x00314D21 File Offset: 0x00312F21
		public static Offset<IRequestResult> EndIRequestResult(FlatBufferBuilder builder)
		{
			return new Offset<IRequestResult>(builder.EndTable());
		}

		// Token: 0x0601549E RID: 87198 RVA: 0x00314D30 File Offset: 0x00312F30
		public IRequestResultT UnPack()
		{
			IRequestResultT requestResultT = new IRequestResultT();
			this.UnPackTo(requestResultT);
			return requestResultT;
		}

		// Token: 0x0601549F RID: 87199 RVA: 0x00314D4B File Offset: 0x00312F4B
		public void UnPackTo(IRequestResultT _o)
		{
			_o.IsSuccess = this.IsSuccess;
			_o.Reason = this.Reason;
		}

		// Token: 0x060154A0 RID: 87200 RVA: 0x00314D68 File Offset: 0x00312F68
		public static Offset<IRequestResult> Pack(FlatBufferBuilder builder, IRequestResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRequestResult>);
			}
			StringOffset reasonOffset = (_o.Reason == null) ? default(StringOffset) : builder.CreateString(_o.Reason);
			return IRequestResult.CreateIRequestResult(builder, _o.IsSuccess, reasonOffset);
		}

		// Token: 0x0400B238 RID: 45624
		private Table __p;
	}
}
