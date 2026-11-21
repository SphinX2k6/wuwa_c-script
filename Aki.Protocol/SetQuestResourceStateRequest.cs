using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001218 RID: 4632
	[NetMessage(EMessageId.SetQuestResourceStateRequest)]
	public sealed class SetQuestResourceStateRequest : IMessage<SetQuestResourceStateRequest>, IMessage, IEquatable<SetQuestResourceStateRequest>, IDeepCloneable<SetQuestResourceStateRequest>, IBufferMessage
	{
		// Token: 0x06018BC7 RID: 101319 RVA: 0x0039AF49 File Offset: 0x00399149
		[NullableContext(1)]
		public static SetQuestResourceStateRequest Create()
		{
			return new SetQuestResourceStateRequest();
		}

		// Token: 0x17005382 RID: 21378
		// (get) Token: 0x06018BC8 RID: 101320 RVA: 0x0039AF50 File Offset: 0x00399150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005383 RID: 21379
		// (get) Token: 0x06018BC9 RID: 101321 RVA: 0x0039AF53 File Offset: 0x00399153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestResourceStateRequest.Descriptor;
			}
		}

		// Token: 0x06018BCA RID: 101322 RVA: 0x0039AF5A File Offset: 0x0039915A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateRequest()
		{
		}

		// Token: 0x06018BCB RID: 101323 RVA: 0x0039AF62 File Offset: 0x00399162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateRequest(SetQuestResourceStateRequest other) : this()
		{
			this.questResourceState_ = other.questResourceState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018BCC RID: 101324 RVA: 0x0039AF87 File Offset: 0x00399187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateRequest Clone()
		{
			return new SetQuestResourceStateRequest(this);
		}

		// Token: 0x17005384 RID: 21380
		// (get) Token: 0x06018BCD RID: 101325 RVA: 0x0039AF8F File Offset: 0x0039918F
		// (set) Token: 0x06018BCE RID: 101326 RVA: 0x0039AF97 File Offset: 0x00399197
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

		// Token: 0x06018BCF RID: 101327 RVA: 0x0039AFA0 File Offset: 0x003991A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestResourceStateRequest);
		}

		// Token: 0x06018BD0 RID: 101328 RVA: 0x0039AFAE File Offset: 0x003991AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestResourceStateRequest other)
		{
			return other != null && (other == this || (this.QuestResourceState == other.QuestResourceState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018BD1 RID: 101329 RVA: 0x0039AFDC File Offset: 0x003991DC
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

		// Token: 0x06018BD2 RID: 101330 RVA: 0x0039B01B File Offset: 0x0039921B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018BD3 RID: 101331 RVA: 0x0039B028 File Offset: 0x00399228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018BD4 RID: 101332 RVA: 0x0039B031 File Offset: 0x00399231
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

		// Token: 0x06018BD5 RID: 101333 RVA: 0x0039B064 File Offset: 0x00399264
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

		// Token: 0x06018BD6 RID: 101334 RVA: 0x0039B0A2 File Offset: 0x003992A2
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

		// Token: 0x06018BD7 RID: 101335 RVA: 0x0039B0D3 File Offset: 0x003992D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018BD8 RID: 101336 RVA: 0x0039B0DC File Offset: 0x003992DC
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

		// Token: 0x040092C7 RID: 37575
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092C8 RID: 37576
		public const int QuestResourceStateFieldNumber = 15;

		// Token: 0x040092C9 RID: 37577
		private int questResourceState_;
	}
}
