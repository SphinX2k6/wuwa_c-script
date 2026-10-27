using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200032B RID: 811
	public sealed class DailyQuestTerminateActionCtxPb : IMessage<DailyQuestTerminateActionCtxPb>, IMessage, IEquatable<DailyQuestTerminateActionCtxPb>, IDeepCloneable<DailyQuestTerminateActionCtxPb>, IBufferMessage
	{
		// Token: 0x06005159 RID: 20825 RVA: 0x000C5DC4 File Offset: 0x000C3FC4
		[NullableContext(1)]
		public static DailyQuestTerminateActionCtxPb Create()
		{
			return new DailyQuestTerminateActionCtxPb();
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x0600515A RID: 20826 RVA: 0x000C5DCB File Offset: 0x000C3FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600515B RID: 20827 RVA: 0x000C5DCE File Offset: 0x000C3FCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DailyQuestTerminateActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x000C5DD5 File Offset: 0x000C3FD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestTerminateActionCtxPb()
		{
		}

		// Token: 0x0600515D RID: 20829 RVA: 0x000C5DDD File Offset: 0x000C3FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestTerminateActionCtxPb(DailyQuestTerminateActionCtxPb other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600515E RID: 20830 RVA: 0x000C5E02 File Offset: 0x000C4002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DailyQuestTerminateActionCtxPb Clone()
		{
			return new DailyQuestTerminateActionCtxPb(this);
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600515F RID: 20831 RVA: 0x000C5E0A File Offset: 0x000C400A
		// (set) Token: 0x06005160 RID: 20832 RVA: 0x000C5E12 File Offset: 0x000C4012
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

		// Token: 0x06005161 RID: 20833 RVA: 0x000C5E1B File Offset: 0x000C401B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DailyQuestTerminateActionCtxPb);
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x000C5E29 File Offset: 0x000C4029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DailyQuestTerminateActionCtxPb other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x000C5E58 File Offset: 0x000C4058
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

		// Token: 0x06005164 RID: 20836 RVA: 0x000C5E97 File Offset: 0x000C4097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x000C5EA4 File Offset: 0x000C40A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x000C5EAD File Offset: 0x000C40AD
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

		// Token: 0x06005167 RID: 20839 RVA: 0x000C5EE0 File Offset: 0x000C40E0
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

		// Token: 0x06005168 RID: 20840 RVA: 0x000C5F1E File Offset: 0x000C411E
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

		// Token: 0x06005169 RID: 20841 RVA: 0x000C5F4F File Offset: 0x000C414F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600516A RID: 20842 RVA: 0x000C5F58 File Offset: 0x000C4158
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

		// Token: 0x0400329F RID: 12959
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032A0 RID: 12960
		public const int QuestIdFieldNumber = 1;

		// Token: 0x040032A1 RID: 12961
		private int questId_;
	}
}
