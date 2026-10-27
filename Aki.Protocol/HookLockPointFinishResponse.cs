using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B7 RID: 1975
	[NetMessage(EMessageId.HookLockPointFinishResponse)]
	public sealed class HookLockPointFinishResponse : IMessage<HookLockPointFinishResponse>, IMessage, IEquatable<HookLockPointFinishResponse>, IDeepCloneable<HookLockPointFinishResponse>, IBufferMessage
	{
		// Token: 0x0600B1D3 RID: 45523 RVA: 0x001AA1BC File Offset: 0x001A83BC
		[NullableContext(1)]
		public static HookLockPointFinishResponse Create()
		{
			return new HookLockPointFinishResponse();
		}

		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x0600B1D4 RID: 45524 RVA: 0x001AA1C3 File Offset: 0x001A83C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023E2 RID: 9186
		// (get) Token: 0x0600B1D5 RID: 45525 RVA: 0x001AA1C6 File Offset: 0x001A83C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x001AA1CD File Offset: 0x001A83CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishResponse()
		{
		}

		// Token: 0x0600B1D7 RID: 45527 RVA: 0x001AA1D5 File Offset: 0x001A83D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishResponse(HookLockPointFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x001AA1FA File Offset: 0x001A83FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishResponse Clone()
		{
			return new HookLockPointFinishResponse(this);
		}

		// Token: 0x170023E3 RID: 9187
		// (get) Token: 0x0600B1D9 RID: 45529 RVA: 0x001AA202 File Offset: 0x001A8402
		// (set) Token: 0x0600B1DA RID: 45530 RVA: 0x001AA20A File Offset: 0x001A840A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x001AA213 File Offset: 0x001A8413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointFinishResponse);
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x001AA221 File Offset: 0x001A8421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x001AA250 File Offset: 0x001A8450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x001AA295 File Offset: 0x001A8495
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x001AA2A2 File Offset: 0x001A84A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x001AA2AB File Offset: 0x001A84AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x001AA2E0 File Offset: 0x001A84E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x001AA31E File Offset: 0x001A851E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointFinishResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B1E3 RID: 45539 RVA: 0x001AA34F File Offset: 0x001A854F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x001AA358 File Offset: 0x001A8558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004FA3 RID: 20387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004FA4 RID: 20388
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04004FA5 RID: 20389
		private ErrorCode errorCode_;
	}
}
