using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000092 RID: 146
	[NetMessage(EMessageId.ActivityResultRewardRequest)]
	public sealed class ActivityResultRewardRequest : IMessage<ActivityResultRewardRequest>, IMessage, IEquatable<ActivityResultRewardRequest>, IDeepCloneable<ActivityResultRewardRequest>, IBufferMessage
	{
		// Token: 0x06001B26 RID: 6950 RVA: 0x0004C248 File Offset: 0x0004A448
		[NullableContext(1)]
		public static ActivityResultRewardRequest Create()
		{
			return new ActivityResultRewardRequest();
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001B27 RID: 6951 RVA: 0x0004C24F File Offset: 0x0004A44F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001B28 RID: 6952 RVA: 0x0004C252 File Offset: 0x0004A452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivityResultRewardRequest.Descriptor;
			}
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x0004C259 File Offset: 0x0004A459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardRequest()
		{
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x0004C261 File Offset: 0x0004A461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardRequest(ActivityResultRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.resultId_ = other.resultId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x0004C292 File Offset: 0x0004A492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityResultRewardRequest Clone()
		{
			return new ActivityResultRewardRequest(this);
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001B2C RID: 6956 RVA: 0x0004C29A File Offset: 0x0004A49A
		// (set) Token: 0x06001B2D RID: 6957 RVA: 0x0004C2A2 File Offset: 0x0004A4A2
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

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0004C2AB File Offset: 0x0004A4AB
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x0004C2B3 File Offset: 0x0004A4B3
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

		// Token: 0x06001B30 RID: 6960 RVA: 0x0004C2BC File Offset: 0x0004A4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivityResultRewardRequest);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0004C2CA File Offset: 0x0004A4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivityResultRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ResultId == other.ResultId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0004C308 File Offset: 0x0004A508
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

		// Token: 0x06001B33 RID: 6963 RVA: 0x0004C360 File Offset: 0x0004A560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0004C36D File Offset: 0x0004A56D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0004C378 File Offset: 0x0004A578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResultId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ResultId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x0004C3D4 File Offset: 0x0004A5D4
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

		// Token: 0x06001B37 RID: 6967 RVA: 0x0004C42C File Offset: 0x0004A62C
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

		// Token: 0x06001B38 RID: 6968 RVA: 0x0004C47C File Offset: 0x0004A67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0004C488 File Offset: 0x0004A688
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
				if (num != 96U)
				{
					if (num != 104U)
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

		// Token: 0x04002283 RID: 8835
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002284 RID: 8836
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04002285 RID: 8837
		private int activityId_;

		// Token: 0x04002286 RID: 8838
		public const int ResultIdFieldNumber = 12;

		// Token: 0x04002287 RID: 8839
		private int resultId_;
	}
}
