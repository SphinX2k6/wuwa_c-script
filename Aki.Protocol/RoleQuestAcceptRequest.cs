using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010A0 RID: 4256
	[NetMessage(EMessageId.RoleQuestAcceptRequest)]
	public sealed class RoleQuestAcceptRequest : IMessage<RoleQuestAcceptRequest>, IMessage, IEquatable<RoleQuestAcceptRequest>, IDeepCloneable<RoleQuestAcceptRequest>, IBufferMessage
	{
		// Token: 0x06016BB4 RID: 93108 RVA: 0x0034DCBE File Offset: 0x0034BEBE
		[NullableContext(1)]
		public static RoleQuestAcceptRequest Create()
		{
			return new RoleQuestAcceptRequest();
		}

		// Token: 0x17004C2B RID: 19499
		// (get) Token: 0x06016BB5 RID: 93109 RVA: 0x0034DCC5 File Offset: 0x0034BEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C2C RID: 19500
		// (get) Token: 0x06016BB6 RID: 93110 RVA: 0x0034DCC8 File Offset: 0x0034BEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleQuestAcceptRequest.Descriptor;
			}
		}

		// Token: 0x06016BB7 RID: 93111 RVA: 0x0034DCCF File Offset: 0x0034BECF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptRequest()
		{
		}

		// Token: 0x06016BB8 RID: 93112 RVA: 0x0034DCD7 File Offset: 0x0034BED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptRequest(RoleQuestAcceptRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BB9 RID: 93113 RVA: 0x0034DCFC File Offset: 0x0034BEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleQuestAcceptRequest Clone()
		{
			return new RoleQuestAcceptRequest(this);
		}

		// Token: 0x17004C2D RID: 19501
		// (get) Token: 0x06016BBA RID: 93114 RVA: 0x0034DD04 File Offset: 0x0034BF04
		// (set) Token: 0x06016BBB RID: 93115 RVA: 0x0034DD0C File Offset: 0x0034BF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x06016BBC RID: 93116 RVA: 0x0034DD15 File Offset: 0x0034BF15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleQuestAcceptRequest);
		}

		// Token: 0x06016BBD RID: 93117 RVA: 0x0034DD23 File Offset: 0x0034BF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleQuestAcceptRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BBE RID: 93118 RVA: 0x0034DD54 File Offset: 0x0034BF54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016BBF RID: 93119 RVA: 0x0034DD93 File Offset: 0x0034BF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BC0 RID: 93120 RVA: 0x0034DDA0 File Offset: 0x0034BFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BC1 RID: 93121 RVA: 0x0034DDA9 File Offset: 0x0034BFA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BC2 RID: 93122 RVA: 0x0034DDDC File Offset: 0x0034BFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016BC3 RID: 93123 RVA: 0x0034DE1A File Offset: 0x0034C01A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleQuestAcceptRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0)
			{
				this.QuestId = other.QuestId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016BC4 RID: 93124 RVA: 0x0034DE4B File Offset: 0x0034C04B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BC5 RID: 93125 RVA: 0x0034DE54 File Offset: 0x0034C054
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040087CA RID: 34762
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087CB RID: 34763
		public const int QuestIdFieldNumber = 15;

		// Token: 0x040087CC RID: 34764
		private int questId_;
	}
}
