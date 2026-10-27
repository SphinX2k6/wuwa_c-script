using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004E RID: 78
	[NetMessage(EMessageId.AcceptFocusWaitQuestRequest)]
	public sealed class AcceptFocusWaitQuestRequest : IMessage<AcceptFocusWaitQuestRequest>, IMessage, IEquatable<AcceptFocusWaitQuestRequest>, IDeepCloneable<AcceptFocusWaitQuestRequest>, IBufferMessage
	{
		// Token: 0x060014B1 RID: 5297 RVA: 0x000376FE File Offset: 0x000358FE
		[NullableContext(1)]
		public static AcceptFocusWaitQuestRequest Create()
		{
			return new AcceptFocusWaitQuestRequest();
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00037705 File Offset: 0x00035905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00037708 File Offset: 0x00035908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptFocusWaitQuestRequest.Descriptor;
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0003770F File Offset: 0x0003590F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestRequest()
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00037717 File Offset: 0x00035917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestRequest(AcceptFocusWaitQuestRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0003773C File Offset: 0x0003593C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptFocusWaitQuestRequest Clone()
		{
			return new AcceptFocusWaitQuestRequest(this);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00037744 File Offset: 0x00035944
		// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0003774C File Offset: 0x0003594C
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

		// Token: 0x060014B9 RID: 5305 RVA: 0x00037755 File Offset: 0x00035955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptFocusWaitQuestRequest);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00037763 File Offset: 0x00035963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptFocusWaitQuestRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00037794 File Offset: 0x00035994
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

		// Token: 0x060014BC RID: 5308 RVA: 0x000377D3 File Offset: 0x000359D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000377E0 File Offset: 0x000359E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x000377E9 File Offset: 0x000359E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0003781C File Offset: 0x00035A1C
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

		// Token: 0x060014C0 RID: 5312 RVA: 0x0003785A File Offset: 0x00035A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptFocusWaitQuestRequest other)
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

		// Token: 0x060014C1 RID: 5313 RVA: 0x0003788B File Offset: 0x00035A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00037894 File Offset: 0x00035A94
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002073 RID: 8307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002074 RID: 8308
		public const int QuestIdFieldNumber = 3;

		// Token: 0x04002075 RID: 8309
		private int questId_;
	}
}
