using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000093 RID: 147
	[NetMessage(EMessageId.ActivityResultRewardResponse)]
	public sealed class ActivityResultRewardResponse : IMessage<ActivityResultRewardResponse>, IMessage, IEquatable<ActivityResultRewardResponse>, IDeepCloneable<ActivityResultRewardResponse>, IBufferMessage
	{
		// Token: 0x06001B3A RID: 6970 RVA: 0x0004C4E0 File Offset: 0x0004A6E0
		[NullableContext(1)]
		public static ActivityResultRewardResponse Create()
		{
			return new ActivityResultRewardResponse();
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0004C4E7 File Offset: 0x0004A6E7
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
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0004C4EA File Offset: 0x0004A6EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResultRewardResponse.Descriptor;
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0004C4F1 File Offset: 0x0004A6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardResponse()
		{
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0004C504 File Offset: 0x0004A704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardResponse(ActivityResultRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.takeRewardResultIds_ = other.takeRewardResultIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0004C53A File Offset: 0x0004A73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardResponse Clone()
		{
			return new ActivityResultRewardResponse(this);
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0004C542 File Offset: 0x0004A742
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0004C54A File Offset: 0x0004A74A
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

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0004C553 File Offset: 0x0004A753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TakeRewardResultIds
		{
			get
			{
				return this.takeRewardResultIds_;
			}
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0004C55B File Offset: 0x0004A75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResultRewardResponse);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0004C56C File Offset: 0x0004A76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResultRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.takeRewardResultIds_.Equals(other.takeRewardResultIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0004C5BC File Offset: 0x0004A7BC
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

		// Token: 0x06001B46 RID: 6982 RVA: 0x0004C60F File Offset: 0x0004A80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0004C61C File Offset: 0x0004A81C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0004C628 File Offset: 0x0004A828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.takeRewardResultIds_.WriteTo(ref output, ActivityResultRewardResponse._repeated_takeRewardResultIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x0004C678 File Offset: 0x0004A878
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

		// Token: 0x06001B4A RID: 6986 RVA: 0x0004C6CC File Offset: 0x0004A8CC
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

		// Token: 0x06001B4B RID: 6987 RVA: 0x0004C719 File Offset: 0x0004A919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x0004C724 File Offset: 0x0004A924
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
				if (num != 72U && num != 74U)
				{
					if (num != 112U)
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
					this.takeRewardResultIds_.AddEntriesFrom(ref input, ActivityResultRewardResponse._repeated_takeRewardResultIds_codec);
				}
			}
		}

		// Token: 0x04002288 RID: 8840
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002289 RID: 8841
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400228A RID: 8842
		private ErrorCode errorCode_;

		// Token: 0x0400228B RID: 8843
		public const int TakeRewardResultIdsFieldNumber = 9;

		// Token: 0x0400228C RID: 8844
		private static readonly FieldCodec<int> _repeated_takeRewardResultIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400228D RID: 8845
		private readonly RepeatedField<int> takeRewardResultIds_ = new RepeatedField<int>();
	}
}
