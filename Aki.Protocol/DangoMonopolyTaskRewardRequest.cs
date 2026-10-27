using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000392 RID: 914
	[NetMessage(EMessageId.DangoMonopolyTaskRewardRequest)]
	public sealed class DangoMonopolyTaskRewardRequest : IMessage<DangoMonopolyTaskRewardRequest>, IMessage, IEquatable<DangoMonopolyTaskRewardRequest>, IDeepCloneable<DangoMonopolyTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x06005A43 RID: 23107 RVA: 0x000DBB2C File Offset: 0x000D9D2C
		[NullableContext(1)]
		public static DangoMonopolyTaskRewardRequest Create()
		{
			return new DangoMonopolyTaskRewardRequest();
		}

		// Token: 0x170010AE RID: 4270
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x000DBB33 File Offset: 0x000D9D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010AF RID: 4271
		// (get) Token: 0x06005A45 RID: 23109 RVA: 0x000DBB36 File Offset: 0x000D9D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x000DBB3D File Offset: 0x000D9D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardRequest()
		{
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x000DBB50 File Offset: 0x000D9D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardRequest(DangoMonopolyTaskRewardRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A48 RID: 23112 RVA: 0x000DBB86 File Offset: 0x000D9D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyTaskRewardRequest Clone()
		{
			return new DangoMonopolyTaskRewardRequest(this);
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06005A49 RID: 23113 RVA: 0x000DBB8E File Offset: 0x000D9D8E
		// (set) Token: 0x06005A4A RID: 23114 RVA: 0x000DBB96 File Offset: 0x000D9D96
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

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06005A4B RID: 23115 RVA: 0x000DBB9F File Offset: 0x000D9D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x000DBBA7 File Offset: 0x000D9DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyTaskRewardRequest);
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x000DBBB8 File Offset: 0x000D9DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyTaskRewardRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x000DBC08 File Offset: 0x000D9E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x000DBC55 File Offset: 0x000D9E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x000DBC62 File Offset: 0x000D9E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x000DBC6C File Offset: 0x000D9E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			this.taskIds_.WriteTo(ref output, DangoMonopolyTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x000DBCBC File Offset: 0x000D9EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.taskIds_.CalculateSize(DangoMonopolyTaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x000DBD10 File Offset: 0x000D9F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A54 RID: 23124 RVA: 0x000DBD5D File Offset: 0x000D9F5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A55 RID: 23125 RVA: 0x000DBD68 File Offset: 0x000D9F68
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
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.taskIds_.AddEntriesFrom(ref input, DangoMonopolyTaskRewardRequest._repeated_taskIds_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040035A8 RID: 13736
		private UnknownFieldSet _unknownFields;

		// Token: 0x040035A9 RID: 13737
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040035AA RID: 13738
		private int activityId_;

		// Token: 0x040035AB RID: 13739
		public const int TaskIdsFieldNumber = 15;

		// Token: 0x040035AC RID: 13740
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(122U);

		// Token: 0x040035AD RID: 13741
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
