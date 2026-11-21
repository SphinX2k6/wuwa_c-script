using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000093 RID: 147
	[NetMessage(EMessageId.ActivityResultRewardRequest)]
	public sealed class ActivityResultRewardRequest : IMessage<ActivityResultRewardRequest>, IMessage, IEquatable<ActivityResultRewardRequest>, IDeepCloneable<ActivityResultRewardRequest>, IBufferMessage
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x0004CE58 File Offset: 0x0004B058
		[NullableContext(1)]
		public static ActivityResultRewardRequest Create()
		{
			return new ActivityResultRewardRequest();
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x0004CE5F File Offset: 0x0004B05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0004CE62 File Offset: 0x0004B062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResultRewardRequest.Descriptor;
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0004CE69 File Offset: 0x0004B069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardRequest()
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0004CE71 File Offset: 0x0004B071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardRequest(ActivityResultRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.resultId_ = other.resultId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0004CEA2 File Offset: 0x0004B0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardRequest Clone()
		{
			return new ActivityResultRewardRequest(this);
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0004CEAA File Offset: 0x0004B0AA
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0004CEB2 File Offset: 0x0004B0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0004CEBB File Offset: 0x0004B0BB
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0004CEC3 File Offset: 0x0004B0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResultId
		{
			get
			{
				return this.resultId_;
			}
			set
			{
				this.resultId_ = value;
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0004CECC File Offset: 0x0004B0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResultRewardRequest);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0004CEDA File Offset: 0x0004B0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResultRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ResultId == other.ResultId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0004CF18 File Offset: 0x0004B118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ResultId != 0)
			{
				num ^= this.ResultId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0004CF70 File Offset: 0x0004B170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0004CF7D File Offset: 0x0004B17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0004CF88 File Offset: 0x0004B188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResultId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ResultId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0004CFE4 File Offset: 0x0004B1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ResultId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResultId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0004D03C File Offset: 0x0004B23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivityResultRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ResultId != 0)
			{
				this.ResultId = other.ResultId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0004D08C File Offset: 0x0004B28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0004D098 File Offset: 0x0004B298
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
				if (num != 64U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.ResultId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040022E4 RID: 8932
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022E5 RID: 8933
		public const int ActivityIdFieldNumber = 10;

		// Token: 0x040022E6 RID: 8934
		private int activityId_;

		// Token: 0x040022E7 RID: 8935
		public const int ResultIdFieldNumber = 8;

		// Token: 0x040022E8 RID: 8936
		private int resultId_;
	}
}
