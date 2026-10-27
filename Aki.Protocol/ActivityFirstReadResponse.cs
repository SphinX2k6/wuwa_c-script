using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000086 RID: 134
	[NetMessage(EMessageId.ActivityFirstReadResponse)]
	public sealed class ActivityFirstReadResponse : IMessage<ActivityFirstReadResponse>, IMessage, IEquatable<ActivityFirstReadResponse>, IDeepCloneable<ActivityFirstReadResponse>, IBufferMessage
	{
		// Token: 0x06001A33 RID: 6707 RVA: 0x0004A30D File Offset: 0x0004850D
		[NullableContext(1)]
		public static ActivityFirstReadResponse Create()
		{
			return new ActivityFirstReadResponse();
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06001A34 RID: 6708 RVA: 0x0004A314 File Offset: 0x00048514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x0004A317 File Offset: 0x00048517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityFirstReadResponse.Descriptor;
			}
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0004A31E File Offset: 0x0004851E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadResponse()
		{
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x0004A326 File Offset: 0x00048526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadResponse(ActivityFirstReadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0004A34B File Offset: 0x0004854B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityFirstReadResponse Clone()
		{
			return new ActivityFirstReadResponse(this);
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x0004A353 File Offset: 0x00048553
		// (set) Token: 0x06001A3A RID: 6714 RVA: 0x0004A35B File Offset: 0x0004855B
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

		// Token: 0x06001A3B RID: 6715 RVA: 0x0004A364 File Offset: 0x00048564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityFirstReadResponse);
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0004A372 File Offset: 0x00048572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityFirstReadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0004A3A0 File Offset: 0x000485A0
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

		// Token: 0x06001A3E RID: 6718 RVA: 0x0004A3E5 File Offset: 0x000485E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0004A3F2 File Offset: 0x000485F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0004A3FB File Offset: 0x000485FB
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

		// Token: 0x06001A41 RID: 6721 RVA: 0x0004A430 File Offset: 0x00048630
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

		// Token: 0x06001A42 RID: 6722 RVA: 0x0004A46E File Offset: 0x0004866E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityFirstReadResponse other)
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

		// Token: 0x06001A43 RID: 6723 RVA: 0x0004A49F File Offset: 0x0004869F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0004A4A8 File Offset: 0x000486A8
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

		// Token: 0x04002240 RID: 8768
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002241 RID: 8769
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002242 RID: 8770
		private ErrorCode errorCode_;
	}
}
