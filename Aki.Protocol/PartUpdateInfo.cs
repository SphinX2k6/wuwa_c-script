using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BB6 RID: 2998
	public sealed class PartUpdateInfo : IMessage<PartUpdateInfo>, IMessage, IEquatable<PartUpdateInfo>, IDeepCloneable<PartUpdateInfo>, IBufferMessage
	{
		// Token: 0x06010443 RID: 66627 RVA: 0x0025FF32 File Offset: 0x0025E132
		[NullableContext(1)]
		public static PartUpdateInfo Create()
		{
			return new PartUpdateInfo();
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x06010444 RID: 66628 RVA: 0x0025FF39 File Offset: 0x0025E139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PartUpdateInfo> Parser
		{
			get
			{
				return PartUpdateInfo._parser;
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x06010445 RID: 66629 RVA: 0x0025FF40 File Offset: 0x0025E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x06010446 RID: 66630 RVA: 0x0025FF43 File Offset: 0x0025E143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PartUpdateInfo.Descriptor;
			}
		}

		// Token: 0x06010447 RID: 66631 RVA: 0x0025FF4A File Offset: 0x0025E14A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateInfo()
		{
		}

		// Token: 0x06010448 RID: 66632 RVA: 0x0025FF52 File Offset: 0x0025E152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateInfo(PartUpdateInfo other) : this()
		{
			this.partId_ = other.partId_;
			this.activated_ = other.activated_;
			this.reset_ = other.reset_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010449 RID: 66633 RVA: 0x0025FF8F File Offset: 0x0025E18F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PartUpdateInfo Clone()
		{
			return new PartUpdateInfo(this);
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0601044A RID: 66634 RVA: 0x0025FF97 File Offset: 0x0025E197
		// (set) Token: 0x0601044B RID: 66635 RVA: 0x0025FF9F File Offset: 0x0025E19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PartId
		{
			get
			{
				return this.partId_;
			}
			set
			{
				this.partId_ = value;
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0601044C RID: 66636 RVA: 0x0025FFA8 File Offset: 0x0025E1A8
		// (set) Token: 0x0601044D RID: 66637 RVA: 0x0025FFB0 File Offset: 0x0025E1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Activated
		{
			get
			{
				return this.activated_;
			}
			set
			{
				this.activated_ = value;
			}
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0601044E RID: 66638 RVA: 0x0025FFB9 File Offset: 0x0025E1B9
		// (set) Token: 0x0601044F RID: 66639 RVA: 0x0025FFC1 File Offset: 0x0025E1C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Reset
		{
			get
			{
				return this.reset_;
			}
			set
			{
				this.reset_ = value;
			}
		}

		// Token: 0x06010450 RID: 66640 RVA: 0x0025FFCA File Offset: 0x0025E1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PartUpdateInfo);
		}

		// Token: 0x06010451 RID: 66641 RVA: 0x0025FFD8 File Offset: 0x0025E1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PartUpdateInfo other)
		{
			return other != null && (other == this || (this.PartId == other.PartId && this.Activated == other.Activated && this.Reset == other.Reset && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010452 RID: 66642 RVA: 0x00260034 File Offset: 0x0025E234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PartId != 0)
			{
				num ^= this.PartId.GetHashCode();
			}
			if (this.Activated)
			{
				num ^= this.Activated.GetHashCode();
			}
			if (this.Reset)
			{
				num ^= this.Reset.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010453 RID: 66643 RVA: 0x002600A5 File Offset: 0x0025E2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010454 RID: 66644 RVA: 0x002600B2 File Offset: 0x0025E2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010455 RID: 66645 RVA: 0x002600BC File Offset: 0x0025E2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PartId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PartId);
			}
			if (this.Activated)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Activated);
			}
			if (this.Reset)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Reset);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010456 RID: 66646 RVA: 0x00260130 File Offset: 0x0025E330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PartId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PartId);
			}
			if (this.Activated)
			{
				num += 2;
			}
			if (this.Reset)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010457 RID: 66647 RVA: 0x00260188 File Offset: 0x0025E388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PartUpdateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PartId != 0)
			{
				this.PartId = other.PartId;
			}
			if (other.Activated)
			{
				this.Activated = other.Activated;
			}
			if (other.Reset)
			{
				this.Reset = other.Reset;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010458 RID: 66648 RVA: 0x002601EC File Offset: 0x0025E3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010459 RID: 66649 RVA: 0x002601F8 File Offset: 0x0025E3F8
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Reset = input.ReadBool();
						}
					}
					else
					{
						this.Activated = input.ReadBool();
					}
				}
				else
				{
					this.PartId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040067D1 RID: 26577
		private static readonly MessageParser<PartUpdateInfo> _parser = new MessageParser<PartUpdateInfo>(() => new PartUpdateInfo());

		// Token: 0x040067D2 RID: 26578
		private UnknownFieldSet _unknownFields;

		// Token: 0x040067D3 RID: 26579
		public const int PartIdFieldNumber = 1;

		// Token: 0x040067D4 RID: 26580
		private int partId_;

		// Token: 0x040067D5 RID: 26581
		public const int ActivatedFieldNumber = 2;

		// Token: 0x040067D6 RID: 26582
		private bool activated_;

		// Token: 0x040067D7 RID: 26583
		public const int ResetFieldNumber = 3;

		// Token: 0x040067D8 RID: 26584
		private bool reset_;
	}
}
