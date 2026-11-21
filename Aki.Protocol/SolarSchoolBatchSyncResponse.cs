using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A5 RID: 4773
	[NetMessage(EMessageId.SolarSchoolBatchSyncResponse)]
	public sealed class SolarSchoolBatchSyncResponse : IMessage<SolarSchoolBatchSyncResponse>, IMessage, IEquatable<SolarSchoolBatchSyncResponse>, IDeepCloneable<SolarSchoolBatchSyncResponse>, IBufferMessage
	{
		// Token: 0x060197A8 RID: 104360 RVA: 0x003B79B9 File Offset: 0x003B5BB9
		[NullableContext(1)]
		public static SolarSchoolBatchSyncResponse Create()
		{
			return new SolarSchoolBatchSyncResponse();
		}

		// Token: 0x17005638 RID: 22072
		// (get) Token: 0x060197A9 RID: 104361 RVA: 0x003B79C0 File Offset: 0x003B5BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005639 RID: 22073
		// (get) Token: 0x060197AA RID: 104362 RVA: 0x003B79C3 File Offset: 0x003B5BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolBatchSyncResponse.Descriptor;
			}
		}

		// Token: 0x060197AB RID: 104363 RVA: 0x003B79CA File Offset: 0x003B5BCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncResponse()
		{
		}

		// Token: 0x060197AC RID: 104364 RVA: 0x003B79D2 File Offset: 0x003B5BD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncResponse(SolarSchoolBatchSyncResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.failedIndex_ = other.failedIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060197AD RID: 104365 RVA: 0x003B7A03 File Offset: 0x003B5C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolBatchSyncResponse Clone()
		{
			return new SolarSchoolBatchSyncResponse(this);
		}

		// Token: 0x1700563A RID: 22074
		// (get) Token: 0x060197AE RID: 104366 RVA: 0x003B7A0B File Offset: 0x003B5C0B
		// (set) Token: 0x060197AF RID: 104367 RVA: 0x003B7A13 File Offset: 0x003B5C13
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

		// Token: 0x1700563B RID: 22075
		// (get) Token: 0x060197B0 RID: 104368 RVA: 0x003B7A1C File Offset: 0x003B5C1C
		// (set) Token: 0x060197B1 RID: 104369 RVA: 0x003B7A24 File Offset: 0x003B5C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FailedIndex
		{
			get
			{
				return this.failedIndex_;
			}
			set
			{
				this.failedIndex_ = value;
			}
		}

		// Token: 0x060197B2 RID: 104370 RVA: 0x003B7A2D File Offset: 0x003B5C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolBatchSyncResponse);
		}

		// Token: 0x060197B3 RID: 104371 RVA: 0x003B7A3B File Offset: 0x003B5C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolBatchSyncResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.FailedIndex == other.FailedIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197B4 RID: 104372 RVA: 0x003B7A7C File Offset: 0x003B5C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.FailedIndex != 0)
			{
				num ^= this.FailedIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060197B5 RID: 104373 RVA: 0x003B7ADA File Offset: 0x003B5CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197B6 RID: 104374 RVA: 0x003B7AE7 File Offset: 0x003B5CE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197B7 RID: 104375 RVA: 0x003B7AF0 File Offset: 0x003B5CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.FailedIndex != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FailedIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197B8 RID: 104376 RVA: 0x003B7B4C File Offset: 0x003B5D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.FailedIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FailedIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060197B9 RID: 104377 RVA: 0x003B7BA4 File Offset: 0x003B5DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolBatchSyncResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.FailedIndex != 0)
			{
				this.FailedIndex = other.FailedIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060197BA RID: 104378 RVA: 0x003B7BF4 File Offset: 0x003B5DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197BB RID: 104379 RVA: 0x003B7C00 File Offset: 0x003B5E00
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
				if (num != 24U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FailedIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400969B RID: 38555
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400969C RID: 38556
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400969D RID: 38557
		private ErrorCode errorCode_;

		// Token: 0x0400969E RID: 38558
		public const int FailedIndexFieldNumber = 8;

		// Token: 0x0400969F RID: 38559
		private int failedIndex_;
	}
}
