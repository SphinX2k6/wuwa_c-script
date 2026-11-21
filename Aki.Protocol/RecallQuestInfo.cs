using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EB1 RID: 3761
	public sealed class RecallQuestInfo : IMessage<RecallQuestInfo>, IMessage, IEquatable<RecallQuestInfo>, IDeepCloneable<RecallQuestInfo>, IBufferMessage
	{
		// Token: 0x06014336 RID: 82742 RVA: 0x002F0982 File Offset: 0x002EEB82
		[NullableContext(1)]
		public static RecallQuestInfo Create()
		{
			return new RecallQuestInfo();
		}

		// Token: 0x17004330 RID: 17200
		// (get) Token: 0x06014337 RID: 82743 RVA: 0x002F0989 File Offset: 0x002EEB89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallQuestInfo> Parser
		{
			get
			{
				return RecallQuestInfo._parser;
			}
		}

		// Token: 0x17004331 RID: 17201
		// (get) Token: 0x06014338 RID: 82744 RVA: 0x002F0990 File Offset: 0x002EEB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004332 RID: 17202
		// (get) Token: 0x06014339 RID: 82745 RVA: 0x002F0993 File Offset: 0x002EEB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallQuestInfo.Descriptor;
			}
		}

		// Token: 0x0601433A RID: 82746 RVA: 0x002F099A File Offset: 0x002EEB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestInfo()
		{
		}

		// Token: 0x0601433B RID: 82747 RVA: 0x002F09A2 File Offset: 0x002EEBA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestInfo(RecallQuestInfo other) : this()
		{
			this.recallQuestId_ = other.recallQuestId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601433C RID: 82748 RVA: 0x002F09D3 File Offset: 0x002EEBD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestInfo Clone()
		{
			return new RecallQuestInfo(this);
		}

		// Token: 0x17004333 RID: 17203
		// (get) Token: 0x0601433D RID: 82749 RVA: 0x002F09DB File Offset: 0x002EEBDB
		// (set) Token: 0x0601433E RID: 82750 RVA: 0x002F09E3 File Offset: 0x002EEBE3
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

		// Token: 0x17004334 RID: 17204
		// (get) Token: 0x0601433F RID: 82751 RVA: 0x002F09EC File Offset: 0x002EEBEC
		// (set) Token: 0x06014340 RID: 82752 RVA: 0x002F09F4 File Offset: 0x002EEBF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallQuestStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06014341 RID: 82753 RVA: 0x002F09FD File Offset: 0x002EEBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallQuestInfo);
		}

		// Token: 0x06014342 RID: 82754 RVA: 0x002F0A0B File Offset: 0x002EEC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallQuestInfo other)
		{
			return other != null && (other == this || (this.RecallQuestId == other.RecallQuestId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014343 RID: 82755 RVA: 0x002F0A4C File Offset: 0x002EEC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallQuestId != 0)
			{
				num ^= this.RecallQuestId.GetHashCode();
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014344 RID: 82756 RVA: 0x002F0AAA File Offset: 0x002EECAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014345 RID: 82757 RVA: 0x002F0AB7 File Offset: 0x002EECB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014346 RID: 82758 RVA: 0x002F0AC0 File Offset: 0x002EECC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallQuestId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RecallQuestId);
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014347 RID: 82759 RVA: 0x002F0B18 File Offset: 0x002EED18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallQuestId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallQuestId);
			}
			if (this.Status != RecallQuestStatus.InActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014348 RID: 82760 RVA: 0x002F0B70 File Offset: 0x002EED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallQuestInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallQuestId != 0)
			{
				this.RecallQuestId = other.RecallQuestId;
			}
			if (other.Status != RecallQuestStatus.InActive)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014349 RID: 82761 RVA: 0x002F0BC0 File Offset: 0x002EEDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601434A RID: 82762 RVA: 0x002F0BCC File Offset: 0x002EEDCC
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = (RecallQuestStatus)input.ReadEnum();
					}
				}
				else
				{
					this.RecallQuestId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007B56 RID: 31574
		private static readonly MessageParser<RecallQuestInfo> _parser = new MessageParser<RecallQuestInfo>(() => new RecallQuestInfo());

		// Token: 0x04007B57 RID: 31575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B58 RID: 31576
		public const int RecallQuestIdFieldNumber = 1;

		// Token: 0x04007B59 RID: 31577
		private int recallQuestId_;

		// Token: 0x04007B5A RID: 31578
		public const int StatusFieldNumber = 2;

		// Token: 0x04007B5B RID: 31579
		private RecallQuestStatus status_;
	}
}
