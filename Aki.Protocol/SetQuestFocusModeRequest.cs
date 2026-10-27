using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DC RID: 4572
	[NetMessage(EMessageId.SetQuestFocusModeRequest)]
	public sealed class SetQuestFocusModeRequest : IMessage<SetQuestFocusModeRequest>, IMessage, IEquatable<SetQuestFocusModeRequest>, IDeepCloneable<SetQuestFocusModeRequest>, IBufferMessage
	{
		// Token: 0x06018602 RID: 99842 RVA: 0x0038B861 File Offset: 0x00389A61
		[NullableContext(1)]
		public static SetQuestFocusModeRequest Create()
		{
			return new SetQuestFocusModeRequest();
		}

		// Token: 0x17005210 RID: 21008
		// (get) Token: 0x06018603 RID: 99843 RVA: 0x0038B868 File Offset: 0x00389A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005211 RID: 21009
		// (get) Token: 0x06018604 RID: 99844 RVA: 0x0038B86B File Offset: 0x00389A6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestFocusModeRequest.Descriptor;
			}
		}

		// Token: 0x06018605 RID: 99845 RVA: 0x0038B872 File Offset: 0x00389A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeRequest()
		{
		}

		// Token: 0x06018606 RID: 99846 RVA: 0x0038B87A File Offset: 0x00389A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeRequest(SetQuestFocusModeRequest other) : this()
		{
			this.questId_ = other.questId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018607 RID: 99847 RVA: 0x0038B89F File Offset: 0x00389A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestFocusModeRequest Clone()
		{
			return new SetQuestFocusModeRequest(this);
		}

		// Token: 0x17005212 RID: 21010
		// (get) Token: 0x06018608 RID: 99848 RVA: 0x0038B8A7 File Offset: 0x00389AA7
		// (set) Token: 0x06018609 RID: 99849 RVA: 0x0038B8AF File Offset: 0x00389AAF
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

		// Token: 0x0601860A RID: 99850 RVA: 0x0038B8B8 File Offset: 0x00389AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestFocusModeRequest);
		}

		// Token: 0x0601860B RID: 99851 RVA: 0x0038B8C6 File Offset: 0x00389AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestFocusModeRequest other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601860C RID: 99852 RVA: 0x0038B8F4 File Offset: 0x00389AF4
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

		// Token: 0x0601860D RID: 99853 RVA: 0x0038B933 File Offset: 0x00389B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601860E RID: 99854 RVA: 0x0038B940 File Offset: 0x00389B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601860F RID: 99855 RVA: 0x0038B949 File Offset: 0x00389B49
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

		// Token: 0x06018610 RID: 99856 RVA: 0x0038B97C File Offset: 0x00389B7C
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

		// Token: 0x06018611 RID: 99857 RVA: 0x0038B9BA File Offset: 0x00389BBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetQuestFocusModeRequest other)
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

		// Token: 0x06018612 RID: 99858 RVA: 0x0038B9EB File Offset: 0x00389BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018613 RID: 99859 RVA: 0x0038B9F4 File Offset: 0x00389BF4
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

		// Token: 0x0400902E RID: 36910
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400902F RID: 36911
		public const int QuestIdFieldNumber = 15;

		// Token: 0x04009030 RID: 36912
		private int questId_;
	}
}
