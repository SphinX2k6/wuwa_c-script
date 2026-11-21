using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000701 RID: 1793
	[NetMessage(EMessageId.GravityHookLockPointChangeGravityResponse)]
	public sealed class GravityHookLockPointChangeGravityResponse : IMessage<GravityHookLockPointChangeGravityResponse>, IMessage, IEquatable<GravityHookLockPointChangeGravityResponse>, IDeepCloneable<GravityHookLockPointChangeGravityResponse>, IBufferMessage
	{
		// Token: 0x0600A37A RID: 41850 RVA: 0x0018B0D5 File Offset: 0x001892D5
		[NullableContext(1)]
		public static GravityHookLockPointChangeGravityResponse Create()
		{
			return new GravityHookLockPointChangeGravityResponse();
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x0600A37B RID: 41851 RVA: 0x0018B0DC File Offset: 0x001892DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600A37C RID: 41852 RVA: 0x0018B0DF File Offset: 0x001892DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityHookLockPointChangeGravityResponse.Descriptor;
			}
		}

		// Token: 0x0600A37D RID: 41853 RVA: 0x0018B0E6 File Offset: 0x001892E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityResponse()
		{
		}

		// Token: 0x0600A37E RID: 41854 RVA: 0x0018B0EE File Offset: 0x001892EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityResponse(GravityHookLockPointChangeGravityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A37F RID: 41855 RVA: 0x0018B113 File Offset: 0x00189313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityResponse Clone()
		{
			return new GravityHookLockPointChangeGravityResponse(this);
		}

		// Token: 0x170020DA RID: 8410
		// (get) Token: 0x0600A380 RID: 41856 RVA: 0x0018B11B File Offset: 0x0018931B
		// (set) Token: 0x0600A381 RID: 41857 RVA: 0x0018B123 File Offset: 0x00189323
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

		// Token: 0x0600A382 RID: 41858 RVA: 0x0018B12C File Offset: 0x0018932C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityHookLockPointChangeGravityResponse);
		}

		// Token: 0x0600A383 RID: 41859 RVA: 0x0018B13A File Offset: 0x0018933A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityHookLockPointChangeGravityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x0018B168 File Offset: 0x00189368
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

		// Token: 0x0600A385 RID: 41861 RVA: 0x0018B1AD File Offset: 0x001893AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x0018B1BA File Offset: 0x001893BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x0018B1C3 File Offset: 0x001893C3
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

		// Token: 0x0600A388 RID: 41864 RVA: 0x0018B1F8 File Offset: 0x001893F8
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

		// Token: 0x0600A389 RID: 41865 RVA: 0x0018B236 File Offset: 0x00189436
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityHookLockPointChangeGravityResponse other)
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

		// Token: 0x0600A38A RID: 41866 RVA: 0x0018B267 File Offset: 0x00189467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A38B RID: 41867 RVA: 0x0018B270 File Offset: 0x00189470
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

		// Token: 0x04004BDA RID: 19418
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BDB RID: 19419
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004BDC RID: 19420
		private ErrorCode errorCode_;
	}
}
