using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000091 RID: 145
	[NetMessage(EMessageId.ActivityResponse)]
	public sealed class ActivityResponse : IMessage<ActivityResponse>, IMessage, IEquatable<ActivityResponse>, IDeepCloneable<ActivityResponse>, IBufferMessage
	{
		// Token: 0x06001B12 RID: 6930 RVA: 0x0004BF96 File Offset: 0x0004A196
		[NullableContext(1)]
		public static ActivityResponse Create()
		{
			return new ActivityResponse();
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06001B13 RID: 6931 RVA: 0x0004BF9D File Offset: 0x0004A19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0004BFA0 File Offset: 0x0004A1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResponse.Descriptor;
			}
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0004BFA7 File Offset: 0x0004A1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResponse()
		{
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0004BFBA File Offset: 0x0004A1BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResponse(ActivityResponse other) : this()
		{
			this.activities_ = other.activities_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0004BFF0 File Offset: 0x0004A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResponse Clone()
		{
			return new ActivityResponse(this);
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x0004BFF8 File Offset: 0x0004A1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activities
		{
			get
			{
				return this.activities_;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001B19 RID: 6937 RVA: 0x0004C000 File Offset: 0x0004A200
		// (set) Token: 0x06001B1A RID: 6938 RVA: 0x0004C008 File Offset: 0x0004A208
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

		// Token: 0x06001B1B RID: 6939 RVA: 0x0004C011 File Offset: 0x0004A211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResponse);
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0004C020 File Offset: 0x0004A220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResponse other)
		{
			return other != null && (other == this || (this.activities_.Equals(other.activities_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0004C070 File Offset: 0x0004A270
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

		// Token: 0x06001B1E RID: 6942 RVA: 0x0004C0C3 File Offset: 0x0004A2C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0004C0D0 File Offset: 0x0004A2D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0004C0DC File Offset: 0x0004A2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.activities_.WriteTo(ref output, ActivityResponse._repeated_activities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0004C12C File Offset: 0x0004A32C
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

		// Token: 0x06001B22 RID: 6946 RVA: 0x0004C180 File Offset: 0x0004A380
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

		// Token: 0x06001B23 RID: 6947 RVA: 0x0004C1CD File Offset: 0x0004A3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0004C1D8 File Offset: 0x0004A3D8
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
				if (num != 104U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.activities_.AddEntriesFrom(ref input, ActivityResponse._repeated_activities_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400227D RID: 8829
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400227E RID: 8830
		public const int ActivitiesFieldNumber = 15;

		// Token: 0x0400227F RID: 8831
		private static readonly FieldCodec<ActivityData> _repeated_activities_codec = FieldCodec.ForMessage<ActivityData>(122U, ActivityData.Parser);

		// Token: 0x04002280 RID: 8832
		private readonly RepeatedField<ActivityData> activities_ = new RepeatedField<ActivityData>();

		// Token: 0x04002281 RID: 8833
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04002282 RID: 8834
		private ErrorCode errorCode_;
	}
}
