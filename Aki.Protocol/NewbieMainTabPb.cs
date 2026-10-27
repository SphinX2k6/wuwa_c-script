using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B12 RID: 2834
	public sealed class NewbieMainTabPb : IMessage<NewbieMainTabPb>, IMessage, IEquatable<NewbieMainTabPb>, IDeepCloneable<NewbieMainTabPb>, IBufferMessage
	{
		// Token: 0x0600F621 RID: 63009 RVA: 0x0023E608 File Offset: 0x0023C808
		[NullableContext(1)]
		public static NewbieMainTabPb Create()
		{
			return new NewbieMainTabPb();
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600F622 RID: 63010 RVA: 0x0023E60F File Offset: 0x0023C80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NewbieMainTabPb> Parser
		{
			get
			{
				return NewbieMainTabPb._parser;
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600F623 RID: 63011 RVA: 0x0023E616 File Offset: 0x0023C816
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600F624 RID: 63012 RVA: 0x0023E619 File Offset: 0x0023C819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieMainTabPb.Descriptor;
			}
		}

		// Token: 0x0600F625 RID: 63013 RVA: 0x0023E620 File Offset: 0x0023C820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTabPb()
		{
		}

		// Token: 0x0600F626 RID: 63014 RVA: 0x0023E633 File Offset: 0x0023C833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTabPb(NewbieMainTabPb other) : this()
		{
			this.tabId_ = other.tabId_;
			this.completedTaskIds_ = other.completedTaskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F627 RID: 63015 RVA: 0x0023E669 File Offset: 0x0023C869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieMainTabPb Clone()
		{
			return new NewbieMainTabPb(this);
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600F628 RID: 63016 RVA: 0x0023E671 File Offset: 0x0023C871
		// (set) Token: 0x0600F629 RID: 63017 RVA: 0x0023E679 File Offset: 0x0023C879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TabId
		{
			get
			{
				return this.tabId_;
			}
			set
			{
				this.tabId_ = value;
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600F62A RID: 63018 RVA: 0x0023E682 File Offset: 0x0023C882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CompletedTaskIds
		{
			get
			{
				return this.completedTaskIds_;
			}
		}

		// Token: 0x0600F62B RID: 63019 RVA: 0x0023E68A File Offset: 0x0023C88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieMainTabPb);
		}

		// Token: 0x0600F62C RID: 63020 RVA: 0x0023E698 File Offset: 0x0023C898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieMainTabPb other)
		{
			return other != null && (other == this || (this.TabId == other.TabId && this.completedTaskIds_.Equals(other.completedTaskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F62D RID: 63021 RVA: 0x0023E6E8 File Offset: 0x0023C8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TabId != 0)
			{
				num ^= this.TabId.GetHashCode();
			}
			num ^= this.completedTaskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F62E RID: 63022 RVA: 0x0023E735 File Offset: 0x0023C935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F62F RID: 63023 RVA: 0x0023E742 File Offset: 0x0023C942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F630 RID: 63024 RVA: 0x0023E74C File Offset: 0x0023C94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TabId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TabId);
			}
			this.completedTaskIds_.WriteTo(ref output, NewbieMainTabPb._repeated_completedTaskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F631 RID: 63025 RVA: 0x0023E79C File Offset: 0x0023C99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TabId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TabId);
			}
			num += this.completedTaskIds_.CalculateSize(NewbieMainTabPb._repeated_completedTaskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F632 RID: 63026 RVA: 0x0023E7F0 File Offset: 0x0023C9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieMainTabPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TabId != 0)
			{
				this.TabId = other.TabId;
			}
			this.completedTaskIds_.Add(other.completedTaskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F633 RID: 63027 RVA: 0x0023E83D File Offset: 0x0023CA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F634 RID: 63028 RVA: 0x0023E848 File Offset: 0x0023CA48
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.completedTaskIds_.AddEntriesFrom(ref input, NewbieMainTabPb._repeated_completedTaskIds_codec);
					}
				}
				else
				{
					this.TabId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040062E1 RID: 25313
		private static readonly MessageParser<NewbieMainTabPb> _parser = new MessageParser<NewbieMainTabPb>(() => new NewbieMainTabPb());

		// Token: 0x040062E2 RID: 25314
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062E3 RID: 25315
		public const int TabIdFieldNumber = 1;

		// Token: 0x040062E4 RID: 25316
		private int tabId_;

		// Token: 0x040062E5 RID: 25317
		public const int CompletedTaskIdsFieldNumber = 2;

		// Token: 0x040062E6 RID: 25318
		private static readonly FieldCodec<int> _repeated_completedTaskIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x040062E7 RID: 25319
		private readonly RepeatedField<int> completedTaskIds_ = new RepeatedField<int>();
	}
}
