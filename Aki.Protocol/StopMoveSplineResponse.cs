using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001305 RID: 4869
	[NetMessage(EMessageId.StopMoveSplineResponse)]
	public sealed class StopMoveSplineResponse : IMessage<StopMoveSplineResponse>, IMessage, IEquatable<StopMoveSplineResponse>, IDeepCloneable<StopMoveSplineResponse>, IBufferMessage
	{
		// Token: 0x06019F88 RID: 106376 RVA: 0x003C974B File Offset: 0x003C794B
		[NullableContext(1)]
		public static StopMoveSplineResponse Create()
		{
			return new StopMoveSplineResponse();
		}

		// Token: 0x170057F4 RID: 22516
		// (get) Token: 0x06019F89 RID: 106377 RVA: 0x003C9752 File Offset: 0x003C7952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057F5 RID: 22517
		// (get) Token: 0x06019F8A RID: 106378 RVA: 0x003C9755 File Offset: 0x003C7955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StopMoveSplineResponse.Descriptor;
			}
		}

		// Token: 0x06019F8B RID: 106379 RVA: 0x003C975C File Offset: 0x003C795C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineResponse()
		{
		}

		// Token: 0x06019F8C RID: 106380 RVA: 0x003C9764 File Offset: 0x003C7964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineResponse(StopMoveSplineResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019F8D RID: 106381 RVA: 0x003C9789 File Offset: 0x003C7989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StopMoveSplineResponse Clone()
		{
			return new StopMoveSplineResponse(this);
		}

		// Token: 0x170057F6 RID: 22518
		// (get) Token: 0x06019F8E RID: 106382 RVA: 0x003C9791 File Offset: 0x003C7991
		// (set) Token: 0x06019F8F RID: 106383 RVA: 0x003C9799 File Offset: 0x003C7999
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

		// Token: 0x06019F90 RID: 106384 RVA: 0x003C97A2 File Offset: 0x003C79A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StopMoveSplineResponse);
		}

		// Token: 0x06019F91 RID: 106385 RVA: 0x003C97B0 File Offset: 0x003C79B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StopMoveSplineResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019F92 RID: 106386 RVA: 0x003C97E0 File Offset: 0x003C79E0
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

		// Token: 0x06019F93 RID: 106387 RVA: 0x003C9825 File Offset: 0x003C7A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019F94 RID: 106388 RVA: 0x003C9832 File Offset: 0x003C7A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019F95 RID: 106389 RVA: 0x003C983B File Offset: 0x003C7A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019F96 RID: 106390 RVA: 0x003C9870 File Offset: 0x003C7A70
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

		// Token: 0x06019F97 RID: 106391 RVA: 0x003C98AE File Offset: 0x003C7AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StopMoveSplineResponse other)
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

		// Token: 0x06019F98 RID: 106392 RVA: 0x003C98DF File Offset: 0x003C7ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019F99 RID: 106393 RVA: 0x003C98E8 File Offset: 0x003C7AE8
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400990B RID: 39179
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400990C RID: 39180
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x0400990D RID: 39181
		private ErrorCode errorCode_;
	}
}
