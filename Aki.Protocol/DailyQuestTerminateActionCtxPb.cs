using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000332 RID: 818
	public sealed class DailyQuestTerminateActionCtxPb : IMessage<DailyQuestTerminateActionCtxPb>, IMessage, IEquatable<DailyQuestTerminateActionCtxPb>, IDeepCloneable<DailyQuestTerminateActionCtxPb>, IBufferMessage
	{
		// Token: 0x06005232 RID: 21042 RVA: 0x000C81B8 File Offset: 0x000C63B8
		[NullableContext(1)]
		public static DailyQuestTerminateActionCtxPb Create()
		{
			return new DailyQuestTerminateActionCtxPb();
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06005233 RID: 21043 RVA: 0x000C81BF File Offset: 0x000C63BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06005234 RID: 21044 RVA: 0x000C81C2 File Offset: 0x000C63C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestTerminateActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x000C81C9 File Offset: 0x000C63C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestTerminateActionCtxPb()
		{
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x000C81D1 File Offset: 0x000C63D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestTerminateActionCtxPb(DailyQuestTerminateActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x000C81F6 File Offset: 0x000C63F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestTerminateActionCtxPb Clone()
		{
			return new DailyQuestTerminateActionCtxPb(this);
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06005238 RID: 21048 RVA: 0x000C81FE File Offset: 0x000C63FE
		// (set) Token: 0x06005239 RID: 21049 RVA: 0x000C8206 File Offset: 0x000C6406
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

		// Token: 0x0600523A RID: 21050 RVA: 0x000C820F File Offset: 0x000C640F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestTerminateActionCtxPb);
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x000C821D File Offset: 0x000C641D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestTerminateActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x000C824C File Offset: 0x000C644C
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

		// Token: 0x0600523D RID: 21053 RVA: 0x000C828B File Offset: 0x000C648B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x000C8298 File Offset: 0x000C6498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x000C82A1 File Offset: 0x000C64A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x000C82D4 File Offset: 0x000C64D4
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

		// Token: 0x06005241 RID: 21057 RVA: 0x000C8312 File Offset: 0x000C6512
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DailyQuestTerminateActionCtxPb other)
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

		// Token: 0x06005242 RID: 21058 RVA: 0x000C8343 File Offset: 0x000C6543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x000C834C File Offset: 0x000C654C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.QuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003336 RID: 13110
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003337 RID: 13111
		public const int QuestIdFieldNumber = 1;

		// Token: 0x04003338 RID: 13112
		private int questId_;
	}
}
