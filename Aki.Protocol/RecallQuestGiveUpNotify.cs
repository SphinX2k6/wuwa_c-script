using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB0 RID: 3760
	[NetMessage(EMessageId.RecallQuestGiveUpNotify)]
	public sealed class RecallQuestGiveUpNotify : IMessage<RecallQuestGiveUpNotify>, IMessage, IEquatable<RecallQuestGiveUpNotify>, IDeepCloneable<RecallQuestGiveUpNotify>, IBufferMessage
	{
		// Token: 0x06014320 RID: 82720 RVA: 0x002F0621 File Offset: 0x002EE821
		[NullableContext(1)]
		public static RecallQuestGiveUpNotify Create()
		{
			return new RecallQuestGiveUpNotify();
		}

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x06014321 RID: 82721 RVA: 0x002F0628 File Offset: 0x002EE828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700432C RID: 17196
		// (get) Token: 0x06014322 RID: 82722 RVA: 0x002F062B File Offset: 0x002EE82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestGiveUpNotify.Descriptor;
			}
		}

		// Token: 0x06014323 RID: 82723 RVA: 0x002F0632 File Offset: 0x002EE832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestGiveUpNotify()
		{
		}

		// Token: 0x06014324 RID: 82724 RVA: 0x002F0648 File Offset: 0x002EE848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestGiveUpNotify(RecallQuestGiveUpNotify other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.treeIncId_ = other.treeIncId_;
			this.flowIncIds_ = other.flowIncIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014325 RID: 82725 RVA: 0x002F0695 File Offset: 0x002EE895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestGiveUpNotify Clone()
		{
			return new RecallQuestGiveUpNotify(this);
		}

		// Token: 0x1700432D RID: 17197
		// (get) Token: 0x06014326 RID: 82726 RVA: 0x002F069D File Offset: 0x002EE89D
		// (set) Token: 0x06014327 RID: 82727 RVA: 0x002F06A5 File Offset: 0x002EE8A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallQuestId
		{
			get
			{
				return this.recallQuestId_;
			}
			set
			{
				this.recallQuestId_ = value;
			}
		}

		// Token: 0x1700432E RID: 17198
		// (get) Token: 0x06014328 RID: 82728 RVA: 0x002F06AE File Offset: 0x002EE8AE
		// (set) Token: 0x06014329 RID: 82729 RVA: 0x002F06B6 File Offset: 0x002EE8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x1700432F RID: 17199
		// (get) Token: 0x0601432A RID: 82730 RVA: 0x002F06BF File Offset: 0x002EE8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> FlowIncIds
		{
			get
			{
				return this.flowIncIds_;
			}
		}

		// Token: 0x0601432B RID: 82731 RVA: 0x002F06C7 File Offset: 0x002EE8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestGiveUpNotify);
		}

		// Token: 0x0601432C RID: 82732 RVA: 0x002F06D8 File Offset: 0x002EE8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestGiveUpNotify other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.TreeIncId == other.TreeIncId && this.flowIncIds_.Equals(other.flowIncIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601432D RID: 82733 RVA: 0x002F0738 File Offset: 0x002EE938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			num ^= this.flowIncIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601432E RID: 82734 RVA: 0x002F079E File Offset: 0x002EE99E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601432F RID: 82735 RVA: 0x002F07AB File Offset: 0x002EE9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014330 RID: 82736 RVA: 0x002F07B4 File Offset: 0x002EE9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.flowIncIds_.WriteTo(ref output, RecallQuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014331 RID: 82737 RVA: 0x002F0820 File Offset: 0x002EEA20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			num += this.flowIncIds_.CalculateSize(RecallQuestGiveUpNotify._repeated_flowIncIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014332 RID: 82738 RVA: 0x002F088C File Offset: 0x002EEA8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestGiveUpNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			this.flowIncIds_.Add(other.flowIncIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014333 RID: 82739 RVA: 0x002F08ED File Offset: 0x002EEAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014334 RID: 82740 RVA: 0x002F08F8 File Offset: 0x002EEAF8
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
				if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.flowIncIds_.AddEntriesFrom(ref input, RecallQuestGiveUpNotify._repeated_flowIncIds_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.TreeIncId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.RecallQuestId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B4E RID: 31566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B4F RID: 31567
		public const int RecallQuestIdFieldNumber = 14;

		// Token: 0x04007B50 RID: 31568
		private int recallQuestId_;

		// Token: 0x04007B51 RID: 31569
		public const int TreeIncIdFieldNumber = 12;

		// Token: 0x04007B52 RID: 31570
		private long treeIncId_;

		// Token: 0x04007B53 RID: 31571
		public const int FlowIncIdsFieldNumber = 7;

		// Token: 0x04007B54 RID: 31572
		private static readonly FieldCodec<long> _repeated_flowIncIds_codec = FieldCodec.ForInt64(58U);

		// Token: 0x04007B55 RID: 31573
		private readonly RepeatedField<long> flowIncIds_ = new RepeatedField<long>();
	}
}
