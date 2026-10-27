using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF4 RID: 3828
	[NetMessage(EMessageId.RemoveBuffS2cResponsePush)]
	public sealed class RemoveBuffS2cResponsePush : IMessage<RemoveBuffS2cResponsePush>, IMessage, IEquatable<RemoveBuffS2cResponsePush>, IDeepCloneable<RemoveBuffS2cResponsePush>, IBufferMessage
	{
		// Token: 0x06014834 RID: 84020 RVA: 0x002FB0E4 File Offset: 0x002F92E4
		[NullableContext(1)]
		public static RemoveBuffS2cResponsePush Create()
		{
			return new RemoveBuffS2cResponsePush();
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x06014835 RID: 84021 RVA: 0x002FB0EB File Offset: 0x002F92EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x06014836 RID: 84022 RVA: 0x002FB0EE File Offset: 0x002F92EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveBuffS2cResponsePush.Descriptor;
			}
		}

		// Token: 0x06014837 RID: 84023 RVA: 0x002FB0F5 File Offset: 0x002F92F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cResponsePush()
		{
		}

		// Token: 0x06014838 RID: 84024 RVA: 0x002FB0FD File Offset: 0x002F92FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cResponsePush(RemoveBuffS2cResponsePush other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014839 RID: 84025 RVA: 0x002FB122 File Offset: 0x002F9322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveBuffS2cResponsePush Clone()
		{
			return new RemoveBuffS2cResponsePush(this);
		}

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x0601483A RID: 84026 RVA: 0x002FB12A File Offset: 0x002F932A
		// (set) Token: 0x0601483B RID: 84027 RVA: 0x002FB132 File Offset: 0x002F9332
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

		// Token: 0x0601483C RID: 84028 RVA: 0x002FB13B File Offset: 0x002F933B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveBuffS2cResponsePush);
		}

		// Token: 0x0601483D RID: 84029 RVA: 0x002FB149 File Offset: 0x002F9349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveBuffS2cResponsePush other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601483E RID: 84030 RVA: 0x002FB178 File Offset: 0x002F9378
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

		// Token: 0x0601483F RID: 84031 RVA: 0x002FB1BD File Offset: 0x002F93BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014840 RID: 84032 RVA: 0x002FB1CA File Offset: 0x002F93CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014841 RID: 84033 RVA: 0x002FB1D3 File Offset: 0x002F93D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014842 RID: 84034 RVA: 0x002FB208 File Offset: 0x002F9408
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

		// Token: 0x06014843 RID: 84035 RVA: 0x002FB246 File Offset: 0x002F9446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveBuffS2cResponsePush other)
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

		// Token: 0x06014844 RID: 84036 RVA: 0x002FB277 File Offset: 0x002F9477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014845 RID: 84037 RVA: 0x002FB280 File Offset: 0x002F9480
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007C62 RID: 31842
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C63 RID: 31843
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007C64 RID: 31844
		private ErrorCode errorCode_;
	}
}
