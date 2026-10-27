using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DE RID: 4574
	[NetMessage(EMessageId.SetQuestResourceStateRequest)]
	public sealed class SetQuestResourceStateRequest : IMessage<SetQuestResourceStateRequest>, IMessage, IEquatable<SetQuestResourceStateRequest>, IDeepCloneable<SetQuestResourceStateRequest>, IBufferMessage
	{
		// Token: 0x06018626 RID: 99878 RVA: 0x0038BC19 File Offset: 0x00389E19
		[NullableContext(1)]
		public static SetQuestResourceStateRequest Create()
		{
			return new SetQuestResourceStateRequest();
		}

		// Token: 0x17005216 RID: 21014
		// (get) Token: 0x06018627 RID: 99879 RVA: 0x0038BC20 File Offset: 0x00389E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005217 RID: 21015
		// (get) Token: 0x06018628 RID: 99880 RVA: 0x0038BC23 File Offset: 0x00389E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestResourceStateRequest.Descriptor;
			}
		}

		// Token: 0x06018629 RID: 99881 RVA: 0x0038BC2A File Offset: 0x00389E2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateRequest()
		{
		}

		// Token: 0x0601862A RID: 99882 RVA: 0x0038BC32 File Offset: 0x00389E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateRequest(SetQuestResourceStateRequest other) : this()
		{
			this.questResourceState_ = other.questResourceState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601862B RID: 99883 RVA: 0x0038BC57 File Offset: 0x00389E57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateRequest Clone()
		{
			return new SetQuestResourceStateRequest(this);
		}

		// Token: 0x17005218 RID: 21016
		// (get) Token: 0x0601862C RID: 99884 RVA: 0x0038BC5F File Offset: 0x00389E5F
		// (set) Token: 0x0601862D RID: 99885 RVA: 0x0038BC67 File Offset: 0x00389E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int QuestResourceState
		{
			get
			{
				return this.questResourceState_;
			}
			set
			{
				this.questResourceState_ = value;
			}
		}

		// Token: 0x0601862E RID: 99886 RVA: 0x0038BC70 File Offset: 0x00389E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestResourceStateRequest);
		}

		// Token: 0x0601862F RID: 99887 RVA: 0x0038BC7E File Offset: 0x00389E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestResourceStateRequest other)
		{
			return other != null && (other == this || (this.QuestResourceState == other.QuestResourceState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018630 RID: 99888 RVA: 0x0038BCAC File Offset: 0x00389EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestResourceState != 0)
			{
				num ^= this.QuestResourceState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018631 RID: 99889 RVA: 0x0038BCEB File Offset: 0x00389EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018632 RID: 99890 RVA: 0x0038BCF8 File Offset: 0x00389EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018633 RID: 99891 RVA: 0x0038BD01 File Offset: 0x00389F01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.QuestResourceState != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.QuestResourceState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018634 RID: 99892 RVA: 0x0038BD34 File Offset: 0x00389F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestResourceState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.QuestResourceState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018635 RID: 99893 RVA: 0x0038BD72 File Offset: 0x00389F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetQuestResourceStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestResourceState != 0)
			{
				this.QuestResourceState = other.QuestResourceState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018636 RID: 99894 RVA: 0x0038BDA3 File Offset: 0x00389FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018637 RID: 99895 RVA: 0x0038BDAC File Offset: 0x00389FAC
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
					this.QuestResourceState = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009034 RID: 36916
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009035 RID: 36917
		public const int QuestResourceStateFieldNumber = 15;

		// Token: 0x04009036 RID: 36918
		private int questResourceState_;
	}
}
