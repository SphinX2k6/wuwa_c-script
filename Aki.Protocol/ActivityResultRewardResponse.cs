using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000094 RID: 148
	[NetMessage(EMessageId.ActivityResultRewardResponse)]
	public sealed class ActivityResultRewardResponse : IMessage<ActivityResultRewardResponse>, IMessage, IEquatable<ActivityResultRewardResponse>, IDeepCloneable<ActivityResultRewardResponse>, IBufferMessage
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x0004D0F0 File Offset: 0x0004B2F0
		[NullableContext(1)]
		public static ActivityResultRewardResponse Create()
		{
			return new ActivityResultRewardResponse();
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0004D0F7 File Offset: 0x0004B2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001B83 RID: 7043 RVA: 0x0004D0FA File Offset: 0x0004B2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResultRewardResponse.Descriptor;
			}
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0004D101 File Offset: 0x0004B301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardResponse()
		{
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x0004D114 File Offset: 0x0004B314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardResponse(ActivityResultRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.takeRewardResultIds_ = other.takeRewardResultIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0004D14A File Offset: 0x0004B34A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardResponse Clone()
		{
			return new ActivityResultRewardResponse(this);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001B87 RID: 7047 RVA: 0x0004D152 File Offset: 0x0004B352
		// (set) Token: 0x06001B88 RID: 7048 RVA: 0x0004D15A File Offset: 0x0004B35A
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

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x0004D163 File Offset: 0x0004B363
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TakeRewardResultIds
		{
			get
			{
				return this.takeRewardResultIds_;
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0004D16B File Offset: 0x0004B36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResultRewardResponse);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0004D17C File Offset: 0x0004B37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResultRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.takeRewardResultIds_.Equals(other.takeRewardResultIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0004D1CC File Offset: 0x0004B3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.takeRewardResultIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0004D21F File Offset: 0x0004B41F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0004D22C File Offset: 0x0004B42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0004D238 File Offset: 0x0004B438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.takeRewardResultIds_.WriteTo(ref output, ActivityResultRewardResponse._repeated_takeRewardResultIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0004D288 File Offset: 0x0004B488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.takeRewardResultIds_.CalculateSize(ActivityResultRewardResponse._repeated_takeRewardResultIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0004D2DC File Offset: 0x0004B4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityResultRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.takeRewardResultIds_.Add(other.takeRewardResultIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0004D329 File Offset: 0x0004B529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0004D334 File Offset: 0x0004B534
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
					if (num != 80U && num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.takeRewardResultIds_.AddEntriesFrom(ref input, ActivityResultRewardResponse._repeated_takeRewardResultIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040022E9 RID: 8937
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022EA RID: 8938
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040022EB RID: 8939
		private ErrorCode errorCode_;

		// Token: 0x040022EC RID: 8940
		public const int TakeRewardResultIdsFieldNumber = 10;

		// Token: 0x040022ED RID: 8941
		private static readonly FieldCodec<int> _repeated_takeRewardResultIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x040022EE RID: 8942
		private readonly RepeatedField<int> takeRewardResultIds_ = new RepeatedField<int>();
	}
}
