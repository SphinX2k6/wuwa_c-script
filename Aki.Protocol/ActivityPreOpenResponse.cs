using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200008E RID: 142
	[NetMessage(EMessageId.ActivityPreOpenResponse)]
	public sealed class ActivityPreOpenResponse : IMessage<ActivityPreOpenResponse>, IMessage, IEquatable<ActivityPreOpenResponse>, IDeepCloneable<ActivityPreOpenResponse>, IBufferMessage
	{
		// Token: 0x06001B0B RID: 6923 RVA: 0x0004C27D File Offset: 0x0004A47D
		[NullableContext(1)]
		public static ActivityPreOpenResponse Create()
		{
			return new ActivityPreOpenResponse();
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x0004C284 File Offset: 0x0004A484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x0004C287 File Offset: 0x0004A487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityPreOpenResponse.Descriptor;
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0004C28E File Offset: 0x0004A48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenResponse()
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0004C296 File Offset: 0x0004A496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenResponse(ActivityPreOpenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0004C2BB File Offset: 0x0004A4BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityPreOpenResponse Clone()
		{
			return new ActivityPreOpenResponse(this);
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06001B11 RID: 6929 RVA: 0x0004C2C3 File Offset: 0x0004A4C3
		// (set) Token: 0x06001B12 RID: 6930 RVA: 0x0004C2CB File Offset: 0x0004A4CB
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

		// Token: 0x06001B13 RID: 6931 RVA: 0x0004C2D4 File Offset: 0x0004A4D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityPreOpenResponse);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0004C2E2 File Offset: 0x0004A4E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityPreOpenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0004C310 File Offset: 0x0004A510
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

		// Token: 0x06001B16 RID: 6934 RVA: 0x0004C355 File Offset: 0x0004A555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0004C362 File Offset: 0x0004A562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0004C36B File Offset: 0x0004A56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
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

		// Token: 0x06001B1A RID: 6938 RVA: 0x0004C3DE File Offset: 0x0004A5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityPreOpenResponse other)
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

		// Token: 0x06001B1B RID: 6939 RVA: 0x0004C40F File Offset: 0x0004A60F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0004C418 File Offset: 0x0004A618
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040022CC RID: 8908
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022CD RID: 8909
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040022CE RID: 8910
		private ErrorCode errorCode_;
	}
}
