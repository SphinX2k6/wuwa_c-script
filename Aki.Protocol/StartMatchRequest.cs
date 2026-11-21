using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FB RID: 4859
	[NetMessage(EMessageId.StartMatchRequest)]
	public sealed class StartMatchRequest : IMessage<StartMatchRequest>, IMessage, IEquatable<StartMatchRequest>, IDeepCloneable<StartMatchRequest>, IBufferMessage
	{
		// Token: 0x06019EBA RID: 106170 RVA: 0x003C7AE9 File Offset: 0x003C5CE9
		[NullableContext(1)]
		public static StartMatchRequest Create()
		{
			return new StartMatchRequest();
		}

		// Token: 0x170057C9 RID: 22473
		// (get) Token: 0x06019EBB RID: 106171 RVA: 0x003C7AF0 File Offset: 0x003C5CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057CA RID: 22474
		// (get) Token: 0x06019EBC RID: 106172 RVA: 0x003C7AF3 File Offset: 0x003C5CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartMatchRequest.Descriptor;
			}
		}

		// Token: 0x06019EBD RID: 106173 RVA: 0x003C7AFA File Offset: 0x003C5CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchRequest()
		{
		}

		// Token: 0x06019EBE RID: 106174 RVA: 0x003C7B02 File Offset: 0x003C5D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchRequest(StartMatchRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.isInviteTeammate_ = other.isInviteTeammate_;
			this.instEnterId_ = other.instEnterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019EBF RID: 106175 RVA: 0x003C7B3F File Offset: 0x003C5D3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartMatchRequest Clone()
		{
			return new StartMatchRequest(this);
		}

		// Token: 0x170057CB RID: 22475
		// (get) Token: 0x06019EC0 RID: 106176 RVA: 0x003C7B47 File Offset: 0x003C5D47
		// (set) Token: 0x06019EC1 RID: 106177 RVA: 0x003C7B4F File Offset: 0x003C5D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x170057CC RID: 22476
		// (get) Token: 0x06019EC2 RID: 106178 RVA: 0x003C7B58 File Offset: 0x003C5D58
		// (set) Token: 0x06019EC3 RID: 106179 RVA: 0x003C7B60 File Offset: 0x003C5D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInviteTeammate
		{
			get
			{
				return this.isInviteTeammate_;
			}
			set
			{
				this.isInviteTeammate_ = value;
			}
		}

		// Token: 0x170057CD RID: 22477
		// (get) Token: 0x06019EC4 RID: 106180 RVA: 0x003C7B69 File Offset: 0x003C5D69
		// (set) Token: 0x06019EC5 RID: 106181 RVA: 0x003C7B71 File Offset: 0x003C5D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstEnterId
		{
			get
			{
				return this.instEnterId_;
			}
			set
			{
				this.instEnterId_ = value;
			}
		}

		// Token: 0x06019EC6 RID: 106182 RVA: 0x003C7B7A File Offset: 0x003C5D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartMatchRequest);
		}

		// Token: 0x06019EC7 RID: 106183 RVA: 0x003C7B88 File Offset: 0x003C5D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartMatchRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.IsInviteTeammate == other.IsInviteTeammate && this.InstEnterId == other.InstEnterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019EC8 RID: 106184 RVA: 0x003C7BE4 File Offset: 0x003C5DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.IsInviteTeammate)
			{
				num ^= this.IsInviteTeammate.GetHashCode();
			}
			if (this.InstEnterId != 0)
			{
				num ^= this.InstEnterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019EC9 RID: 106185 RVA: 0x003C7C55 File Offset: 0x003C5E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019ECA RID: 106186 RVA: 0x003C7C62 File Offset: 0x003C5E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019ECB RID: 106187 RVA: 0x003C7C6C File Offset: 0x003C5E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstEnterId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstEnterId);
			}
			if (this.IsInviteTeammate)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsInviteTeammate);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019ECC RID: 106188 RVA: 0x003C7CE0 File Offset: 0x003C5EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.IsInviteTeammate)
			{
				num += 2;
			}
			if (this.InstEnterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstEnterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019ECD RID: 106189 RVA: 0x003C7D44 File Offset: 0x003C5F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartMatchRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.IsInviteTeammate)
			{
				this.IsInviteTeammate = other.IsInviteTeammate;
			}
			if (other.InstEnterId != 0)
			{
				this.InstEnterId = other.InstEnterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019ECE RID: 106190 RVA: 0x003C7DA8 File Offset: 0x003C5FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019ECF RID: 106191 RVA: 0x003C7DB4 File Offset: 0x003C5FB4
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
				if (num != 8U)
				{
					if (num != 24U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.InstId = input.ReadInt32();
						}
					}
					else
					{
						this.IsInviteTeammate = input.ReadBool();
					}
				}
				else
				{
					this.InstEnterId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040098D3 RID: 39123
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098D4 RID: 39124
		public const int InstIdFieldNumber = 12;

		// Token: 0x040098D5 RID: 39125
		private int instId_;

		// Token: 0x040098D6 RID: 39126
		public const int IsInviteTeammateFieldNumber = 3;

		// Token: 0x040098D7 RID: 39127
		private bool isInviteTeammate_;

		// Token: 0x040098D8 RID: 39128
		public const int InstEnterIdFieldNumber = 1;

		// Token: 0x040098D9 RID: 39129
		private int instEnterId_;
	}
}
