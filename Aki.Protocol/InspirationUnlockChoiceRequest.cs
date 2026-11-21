using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000804 RID: 2052
	[NetMessage(EMessageId.InspirationUnlockChoiceRequest)]
	public sealed class InspirationUnlockChoiceRequest : IMessage<InspirationUnlockChoiceRequest>, IMessage, IEquatable<InspirationUnlockChoiceRequest>, IDeepCloneable<InspirationUnlockChoiceRequest>, IBufferMessage
	{
		// Token: 0x0600B7E0 RID: 47072 RVA: 0x001B65D1 File Offset: 0x001B47D1
		[NullableContext(1)]
		public static InspirationUnlockChoiceRequest Create()
		{
			return new InspirationUnlockChoiceRequest();
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x0600B7E1 RID: 47073 RVA: 0x001B65D8 File Offset: 0x001B47D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x0600B7E2 RID: 47074 RVA: 0x001B65DB File Offset: 0x001B47DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InspirationUnlockChoiceRequest.Descriptor;
			}
		}

		// Token: 0x0600B7E3 RID: 47075 RVA: 0x001B65E2 File Offset: 0x001B47E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceRequest()
		{
		}

		// Token: 0x0600B7E4 RID: 47076 RVA: 0x001B65EA File Offset: 0x001B47EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceRequest(InspirationUnlockChoiceRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.chapterId_ = other.chapterId_;
			this.choiceId_ = other.choiceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7E5 RID: 47077 RVA: 0x001B6627 File Offset: 0x001B4827
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InspirationUnlockChoiceRequest Clone()
		{
			return new InspirationUnlockChoiceRequest(this);
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x0600B7E6 RID: 47078 RVA: 0x001B662F File Offset: 0x001B482F
		// (set) Token: 0x0600B7E7 RID: 47079 RVA: 0x001B6637 File Offset: 0x001B4837
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

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x0600B7E8 RID: 47080 RVA: 0x001B6640 File Offset: 0x001B4840
		// (set) Token: 0x0600B7E9 RID: 47081 RVA: 0x001B6648 File Offset: 0x001B4848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChapterId
		{
			get
			{
				return this.chapterId_;
			}
			set
			{
				this.chapterId_ = value;
			}
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x0600B7EA RID: 47082 RVA: 0x001B6651 File Offset: 0x001B4851
		// (set) Token: 0x0600B7EB RID: 47083 RVA: 0x001B6659 File Offset: 0x001B4859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChoiceId
		{
			get
			{
				return this.choiceId_;
			}
			set
			{
				this.choiceId_ = value;
			}
		}

		// Token: 0x0600B7EC RID: 47084 RVA: 0x001B6662 File Offset: 0x001B4862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InspirationUnlockChoiceRequest);
		}

		// Token: 0x0600B7ED RID: 47085 RVA: 0x001B6670 File Offset: 0x001B4870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InspirationUnlockChoiceRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.ChapterId == other.ChapterId && this.ChoiceId == other.ChoiceId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7EE RID: 47086 RVA: 0x001B66CC File Offset: 0x001B48CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.ChapterId != 0)
			{
				num ^= this.ChapterId.GetHashCode();
			}
			if (this.ChoiceId != 0)
			{
				num ^= this.ChoiceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x001B673D File Offset: 0x001B493D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x001B674A File Offset: 0x001B494A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x001B6754 File Offset: 0x001B4954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChoiceId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ChoiceId);
			}
			if (this.ChapterId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChapterId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x001B67CC File Offset: 0x001B49CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.ChapterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChapterId);
			}
			if (this.ChoiceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChoiceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x001B683C File Offset: 0x001B4A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InspirationUnlockChoiceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.ChapterId != 0)
			{
				this.ChapterId = other.ChapterId;
			}
			if (other.ChoiceId != 0)
			{
				this.ChoiceId = other.ChoiceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x001B68A0 File Offset: 0x001B4AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x001B68AC File Offset: 0x001B4AAC
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
				if (num != 16U)
				{
					if (num != 32U)
					{
						if (num != 112U)
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
						this.ChapterId = input.ReadInt32();
					}
				}
				else
				{
					this.ChoiceId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400516D RID: 20845
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400516E RID: 20846
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x0400516F RID: 20847
		private int activityId_;

		// Token: 0x04005170 RID: 20848
		public const int ChapterIdFieldNumber = 4;

		// Token: 0x04005171 RID: 20849
		private int chapterId_;

		// Token: 0x04005172 RID: 20850
		public const int ChoiceIdFieldNumber = 2;

		// Token: 0x04005173 RID: 20851
		private int choiceId_;
	}
}
