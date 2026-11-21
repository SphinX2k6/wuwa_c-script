using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007B8 RID: 1976
	[NetMessage(EMessageId.IllustratedUnlockNotify)]
	public sealed class IllustratedUnlockNotify : IMessage<IllustratedUnlockNotify>, IMessage, IEquatable<IllustratedUnlockNotify>, IDeepCloneable<IllustratedUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600B226 RID: 45606 RVA: 0x001AAE31 File Offset: 0x001A9031
		[NullableContext(1)]
		public static IllustratedUnlockNotify Create()
		{
			return new IllustratedUnlockNotify();
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x0600B227 RID: 45607 RVA: 0x001AAE38 File Offset: 0x001A9038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x0600B228 RID: 45608 RVA: 0x001AAE3B File Offset: 0x001A903B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x001AAE42 File Offset: 0x001A9042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockNotify()
		{
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x001AAE4C File Offset: 0x001A904C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockNotify(IllustratedUnlockNotify other) : this()
		{
			this.type_ = other.type_;
			this.entry_ = ((other.entry_ != null) ? other.entry_.Clone() : null);
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B22B RID: 45611 RVA: 0x001AAEA4 File Offset: 0x001A90A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockNotify Clone()
		{
			return new IllustratedUnlockNotify(this);
		}

		// Token: 0x170023F0 RID: 9200
		// (get) Token: 0x0600B22C RID: 45612 RVA: 0x001AAEAC File Offset: 0x001A90AC
		// (set) Token: 0x0600B22D RID: 45613 RVA: 0x001AAEB4 File Offset: 0x001A90B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170023F1 RID: 9201
		// (get) Token: 0x0600B22E RID: 45614 RVA: 0x001AAEBD File Offset: 0x001A90BD
		// (set) Token: 0x0600B22F RID: 45615 RVA: 0x001AAEC5 File Offset: 0x001A90C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry Entry
		{
			get
			{
				return this.entry_;
			}
			set
			{
				this.entry_ = value;
			}
		}

		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600B230 RID: 45616 RVA: 0x001AAECE File Offset: 0x001A90CE
		// (set) Token: 0x0600B231 RID: 45617 RVA: 0x001AAED6 File Offset: 0x001A90D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x001AAEDF File Offset: 0x001A90DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedUnlockNotify);
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x001AAEF0 File Offset: 0x001A90F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedUnlockNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this.Entry, other.Entry) && this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x001AAF50 File Offset: 0x001A9150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != IllustratedType.Monster)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.entry_ != null)
			{
				num ^= this.Entry.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x001AAFC4 File Offset: 0x001A91C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x001AAFD1 File Offset: 0x001A91D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x001AAFDC File Offset: 0x001A91DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNew);
			}
			if (this.entry_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Entry);
			}
			if (this.Type != IllustratedType.Monster)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x001AB050 File Offset: 0x001A9250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != IllustratedType.Monster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.entry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entry);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x001AB0B4 File Offset: 0x001A92B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != IllustratedType.Monster)
			{
				this.Type = other.Type;
			}
			if (other.entry_ != null)
			{
				if (this.entry_ == null)
				{
					this.Entry = new IllustratedEntry();
				}
				this.Entry.MergeFrom(other.Entry);
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x001AB130 File Offset: 0x001A9330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x001AB13C File Offset: 0x001A933C
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
					if (num != 26U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Type = (IllustratedType)input.ReadEnum();
						}
					}
					else
					{
						if (this.entry_ == null)
						{
							this.Entry = new IllustratedEntry();
						}
						input.ReadMessage(this.Entry);
					}
				}
				else
				{
					this.IsNew = input.ReadBool();
				}
			}
		}

		// Token: 0x04005009 RID: 20489
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400500A RID: 20490
		public const int TypeFieldNumber = 4;

		// Token: 0x0400500B RID: 20491
		private IllustratedType type_;

		// Token: 0x0400500C RID: 20492
		public const int EntryFieldNumber = 3;

		// Token: 0x0400500D RID: 20493
		private IllustratedEntry entry_;

		// Token: 0x0400500E RID: 20494
		public const int IsNewFieldNumber = 1;

		// Token: 0x0400500F RID: 20495
		private bool isNew_;
	}
}
