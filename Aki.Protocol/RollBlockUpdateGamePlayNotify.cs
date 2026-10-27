using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EC RID: 4332
	[NetMessage(EMessageId.RollBlockUpdateGamePlayNotify)]
	public sealed class RollBlockUpdateGamePlayNotify : IMessage<RollBlockUpdateGamePlayNotify>, IMessage, IEquatable<RollBlockUpdateGamePlayNotify>, IDeepCloneable<RollBlockUpdateGamePlayNotify>, IBufferMessage
	{
		// Token: 0x0601719D RID: 94621 RVA: 0x00359FCC File Offset: 0x003581CC
		[NullableContext(1)]
		public static RollBlockUpdateGamePlayNotify Create()
		{
			return new RollBlockUpdateGamePlayNotify();
		}

		// Token: 0x17004D5D RID: 19805
		// (get) Token: 0x0601719E RID: 94622 RVA: 0x00359FD3 File Offset: 0x003581D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D5E RID: 19806
		// (get) Token: 0x0601719F RID: 94623 RVA: 0x00359FD6 File Offset: 0x003581D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockUpdateGamePlayNotify.Descriptor;
			}
		}

		// Token: 0x060171A0 RID: 94624 RVA: 0x00359FDD File Offset: 0x003581DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateGamePlayNotify()
		{
		}

		// Token: 0x060171A1 RID: 94625 RVA: 0x00359FE5 File Offset: 0x003581E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateGamePlayNotify(RollBlockUpdateGamePlayNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060171A2 RID: 94626 RVA: 0x0035A01A File Offset: 0x0035821A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockUpdateGamePlayNotify Clone()
		{
			return new RollBlockUpdateGamePlayNotify(this);
		}

		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x060171A3 RID: 94627 RVA: 0x0035A022 File Offset: 0x00358222
		// (set) Token: 0x060171A4 RID: 94628 RVA: 0x0035A02A File Offset: 0x0035822A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockGamePlayPbInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x060171A5 RID: 94629 RVA: 0x0035A033 File Offset: 0x00358233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockUpdateGamePlayNotify);
		}

		// Token: 0x060171A6 RID: 94630 RVA: 0x0035A041 File Offset: 0x00358241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockUpdateGamePlayNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060171A7 RID: 94631 RVA: 0x0035A074 File Offset: 0x00358274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060171A8 RID: 94632 RVA: 0x0035A0B0 File Offset: 0x003582B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060171A9 RID: 94633 RVA: 0x0035A0BD File Offset: 0x003582BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060171AA RID: 94634 RVA: 0x0035A0C6 File Offset: 0x003582C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060171AB RID: 94635 RVA: 0x0035A0F8 File Offset: 0x003582F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060171AC RID: 94636 RVA: 0x0035A138 File Offset: 0x00358338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockUpdateGamePlayNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new RollBlockGamePlayPbInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060171AD RID: 94637 RVA: 0x0035A18C File Offset: 0x0035838C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060171AE RID: 94638 RVA: 0x0035A198 File Offset: 0x00358398
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new RollBlockGamePlayPbInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x0400895C RID: 35164
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400895D RID: 35165
		public const int InfoFieldNumber = 12;

		// Token: 0x0400895E RID: 35166
		private RollBlockGamePlayPbInfo info_;
	}
}
