using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A1 RID: 1953
	[NetMessage(EMessageId.HookLockPointExitResponse)]
	public sealed class HookLockPointExitResponse : IMessage<HookLockPointExitResponse>, IMessage, IEquatable<HookLockPointExitResponse>, IDeepCloneable<HookLockPointExitResponse>, IBufferMessage
	{
		// Token: 0x0600B059 RID: 45145 RVA: 0x001A73D4 File Offset: 0x001A55D4
		[NullableContext(1)]
		public static HookLockPointExitResponse Create()
		{
			return new HookLockPointExitResponse();
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x0600B05A RID: 45146 RVA: 0x001A73DB File Offset: 0x001A55DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x0600B05B RID: 45147 RVA: 0x001A73DE File Offset: 0x001A55DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointExitResponse.Descriptor;
			}
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x001A73E5 File Offset: 0x001A55E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitResponse()
		{
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x001A73ED File Offset: 0x001A55ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitResponse(HookLockPointExitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B05E RID: 45150 RVA: 0x001A7412 File Offset: 0x001A5612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointExitResponse Clone()
		{
			return new HookLockPointExitResponse(this);
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x0600B05F RID: 45151 RVA: 0x001A741A File Offset: 0x001A561A
		// (set) Token: 0x0600B060 RID: 45152 RVA: 0x001A7422 File Offset: 0x001A5622
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

		// Token: 0x0600B061 RID: 45153 RVA: 0x001A742B File Offset: 0x001A562B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointExitResponse);
		}

		// Token: 0x0600B062 RID: 45154 RVA: 0x001A7439 File Offset: 0x001A5639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointExitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B063 RID: 45155 RVA: 0x001A7468 File Offset: 0x001A5668
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

		// Token: 0x0600B064 RID: 45156 RVA: 0x001A74AD File Offset: 0x001A56AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B065 RID: 45157 RVA: 0x001A74BA File Offset: 0x001A56BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B066 RID: 45158 RVA: 0x001A74C3 File Offset: 0x001A56C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B067 RID: 45159 RVA: 0x001A74F8 File Offset: 0x001A56F8
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

		// Token: 0x0600B068 RID: 45160 RVA: 0x001A7536 File Offset: 0x001A5736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HookLockPointExitResponse other)
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

		// Token: 0x0600B069 RID: 45161 RVA: 0x001A7567 File Offset: 0x001A5767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B06A RID: 45162 RVA: 0x001A7570 File Offset: 0x001A5770
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004F96 RID: 20374
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F97 RID: 20375
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004F98 RID: 20376
		private ErrorCode errorCode_;
	}
}
