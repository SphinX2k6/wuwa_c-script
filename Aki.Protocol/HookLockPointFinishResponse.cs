using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A3 RID: 1955
	[NetMessage(EMessageId.HookLockPointFinishResponse)]
	public sealed class HookLockPointFinishResponse : IMessage<HookLockPointFinishResponse>, IMessage, IEquatable<HookLockPointFinishResponse>, IDeepCloneable<HookLockPointFinishResponse>, IBufferMessage
	{
		// Token: 0x0600B07D RID: 45181 RVA: 0x001A778D File Offset: 0x001A598D
		[NullableContext(1)]
		public static HookLockPointFinishResponse Create()
		{
			return new HookLockPointFinishResponse();
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x0600B07E RID: 45182 RVA: 0x001A7794 File Offset: 0x001A5994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x0600B07F RID: 45183 RVA: 0x001A7797 File Offset: 0x001A5997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HookLockPointFinishResponse.Descriptor;
			}
		}

		// Token: 0x0600B080 RID: 45184 RVA: 0x001A779E File Offset: 0x001A599E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishResponse()
		{
		}

		// Token: 0x0600B081 RID: 45185 RVA: 0x001A77A6 File Offset: 0x001A59A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishResponse(HookLockPointFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B082 RID: 45186 RVA: 0x001A77CB File Offset: 0x001A59CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HookLockPointFinishResponse Clone()
		{
			return new HookLockPointFinishResponse(this);
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x0600B083 RID: 45187 RVA: 0x001A77D3 File Offset: 0x001A59D3
		// (set) Token: 0x0600B084 RID: 45188 RVA: 0x001A77DB File Offset: 0x001A59DB
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

		// Token: 0x0600B085 RID: 45189 RVA: 0x001A77E4 File Offset: 0x001A59E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HookLockPointFinishResponse);
		}

		// Token: 0x0600B086 RID: 45190 RVA: 0x001A77F2 File Offset: 0x001A59F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HookLockPointFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B087 RID: 45191 RVA: 0x001A7820 File Offset: 0x001A5A20
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

		// Token: 0x0600B088 RID: 45192 RVA: 0x001A7865 File Offset: 0x001A5A65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B089 RID: 45193 RVA: 0x001A7872 File Offset: 0x001A5A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B08A RID: 45194 RVA: 0x001A787B File Offset: 0x001A5A7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B08B RID: 45195 RVA: 0x001A78B0 File Offset: 0x001A5AB0
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

		// Token: 0x0600B08C RID: 45196 RVA: 0x001A78EE File Offset: 0x001A5AEE
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

		// Token: 0x0600B08D RID: 45197 RVA: 0x001A791F File Offset: 0x001A5B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B08E RID: 45198 RVA: 0x001A7928 File Offset: 0x001A5B28
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004F9C RID: 20380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F9D RID: 20381
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004F9E RID: 20382
		private ErrorCode errorCode_;
	}
}
