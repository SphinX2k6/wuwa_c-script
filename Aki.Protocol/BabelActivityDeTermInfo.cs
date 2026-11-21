using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000142 RID: 322
	public sealed class BabelActivityDeTermInfo : IMessage<BabelActivityDeTermInfo>, IMessage, IEquatable<BabelActivityDeTermInfo>, IDeepCloneable<BabelActivityDeTermInfo>, IBufferMessage
	{
		// Token: 0x060029D8 RID: 10712 RVA: 0x0006DC39 File Offset: 0x0006BE39
		[NullableContext(1)]
		public static BabelActivityDeTermInfo Create()
		{
			return new BabelActivityDeTermInfo();
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060029D9 RID: 10713 RVA: 0x0006DC40 File Offset: 0x0006BE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BabelActivityDeTermInfo> Parser
		{
			get
			{
				return BabelActivityDeTermInfo._parser;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060029DA RID: 10714 RVA: 0x0006DC47 File Offset: 0x0006BE47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x0006DC4A File Offset: 0x0006BE4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelActivityDeTermInfo.Descriptor;
			}
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x0006DC51 File Offset: 0x0006BE51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfo()
		{
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x0006DC59 File Offset: 0x0006BE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfo(BabelActivityDeTermInfo other) : this()
		{
			this.deTermId_ = other.deTermId_;
			this.difficultUnlock_ = other.difficultUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x0006DC8A File Offset: 0x0006BE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelActivityDeTermInfo Clone()
		{
			return new BabelActivityDeTermInfo(this);
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060029DF RID: 10719 RVA: 0x0006DC92 File Offset: 0x0006BE92
		// (set) Token: 0x060029E0 RID: 10720 RVA: 0x0006DC9A File Offset: 0x0006BE9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DeTermId
		{
			get
			{
				return this.deTermId_;
			}
			set
			{
				this.deTermId_ = value;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060029E1 RID: 10721 RVA: 0x0006DCA3 File Offset: 0x0006BEA3
		// (set) Token: 0x060029E2 RID: 10722 RVA: 0x0006DCAB File Offset: 0x0006BEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DifficultUnlock
		{
			get
			{
				return this.difficultUnlock_;
			}
			set
			{
				this.difficultUnlock_ = value;
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x0006DCB4 File Offset: 0x0006BEB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelActivityDeTermInfo);
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x0006DCC2 File Offset: 0x0006BEC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelActivityDeTermInfo other)
		{
			return other != null && (other == this || (this.DeTermId == other.DeTermId && this.DifficultUnlock == other.DifficultUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x0006DD00 File Offset: 0x0006BF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DeTermId != 0)
			{
				num ^= this.DeTermId.GetHashCode();
			}
			if (this.DifficultUnlock)
			{
				num ^= this.DifficultUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x0006DD58 File Offset: 0x0006BF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x0006DD65 File Offset: 0x0006BF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x0006DD70 File Offset: 0x0006BF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DeTermId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DeTermId);
			}
			if (this.DifficultUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DifficultUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x0006DDC8 File Offset: 0x0006BFC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DeTermId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeTermId);
			}
			if (this.DifficultUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x0006DE14 File Offset: 0x0006C014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelActivityDeTermInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DeTermId != 0)
			{
				this.DeTermId = other.DeTermId;
			}
			if (other.DifficultUnlock)
			{
				this.DifficultUnlock = other.DifficultUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x0006DE64 File Offset: 0x0006C064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x0006DE70 File Offset: 0x0006C070
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
						this.DifficultUnlock = input.ReadBool();
					}
				}
				else
				{
					this.DeTermId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400275E RID: 10078
		private static readonly MessageParser<BabelActivityDeTermInfo> _parser = new MessageParser<BabelActivityDeTermInfo>(() => new BabelActivityDeTermInfo());

		// Token: 0x0400275F RID: 10079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002760 RID: 10080
		public const int DeTermIdFieldNumber = 1;

		// Token: 0x04002761 RID: 10081
		private int deTermId_;

		// Token: 0x04002762 RID: 10082
		public const int DifficultUnlockFieldNumber = 2;

		// Token: 0x04002763 RID: 10083
		private bool difficultUnlock_;
	}
}
