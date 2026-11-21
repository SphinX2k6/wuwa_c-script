using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000092 RID: 146
	[NetMessage(EMessageId.ActivityResponse)]
	public sealed class ActivityResponse : IMessage<ActivityResponse>, IMessage, IEquatable<ActivityResponse>, IDeepCloneable<ActivityResponse>, IBufferMessage
	{
		// Token: 0x06001B59 RID: 7001 RVA: 0x0004CBA6 File Offset: 0x0004ADA6
		[NullableContext(1)]
		public static ActivityResponse Create()
		{
			return new ActivityResponse();
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0004CBAD File Offset: 0x0004ADAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0004CBB0 File Offset: 0x0004ADB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResponse.Descriptor;
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0004CBB7 File Offset: 0x0004ADB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResponse()
		{
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0004CBCA File Offset: 0x0004ADCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResponse(ActivityResponse other) : this()
		{
			this.activities_ = other.activities_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0004CC00 File Offset: 0x0004AE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResponse Clone()
		{
			return new ActivityResponse(this);
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0004CC08 File Offset: 0x0004AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activities
		{
			get
			{
				return this.activities_;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0004CC10 File Offset: 0x0004AE10
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0004CC18 File Offset: 0x0004AE18
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

		// Token: 0x06001B62 RID: 7010 RVA: 0x0004CC21 File Offset: 0x0004AE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResponse);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0004CC30 File Offset: 0x0004AE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResponse other)
		{
			return other != null && (other == this || (this.activities_.Equals(other.activities_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0004CC80 File Offset: 0x0004AE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activities_.GetHashCode();
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

		// Token: 0x06001B65 RID: 7013 RVA: 0x0004CCD3 File Offset: 0x0004AED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0004CCE0 File Offset: 0x0004AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0004CCEC File Offset: 0x0004AEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activities_.WriteTo(ref output, ActivityResponse._repeated_activities_codec);
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

		// Token: 0x06001B68 RID: 7016 RVA: 0x0004CD3C File Offset: 0x0004AF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activities_.CalculateSize(ActivityResponse._repeated_activities_codec);
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

		// Token: 0x06001B69 RID: 7017 RVA: 0x0004CD90 File Offset: 0x0004AF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.activities_.Add(other.activities_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0004CDDD File Offset: 0x0004AFDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0004CDE8 File Offset: 0x0004AFE8
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
				if (num != 50U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.activities_.AddEntriesFrom(ref input, ActivityResponse._repeated_activities_codec);
				}
			}
		}

		// Token: 0x040022DE RID: 8926
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022DF RID: 8927
		public const int ActivitiesFieldNumber = 6;

		// Token: 0x040022E0 RID: 8928
		private static readonly FieldCodec<ActivityData> _repeated_activities_codec = FieldCodec.ForMessage<ActivityData>(50U, ActivityData.Parser);

		// Token: 0x040022E1 RID: 8929
		private readonly RepeatedField<ActivityData> activities_ = new RepeatedField<ActivityData>();

		// Token: 0x040022E2 RID: 8930
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040022E3 RID: 8931
		private ErrorCode errorCode_;
	}
}
