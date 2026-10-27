using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200091A RID: 2330
	public sealed class LiftComponentPb : IMessage<LiftComponentPb>, IMessage, IEquatable<LiftComponentPb>, IDeepCloneable<LiftComponentPb>, IBufferMessage
	{
		// Token: 0x0600CD98 RID: 52632 RVA: 0x001E49A5 File Offset: 0x001E2BA5
		[NullableContext(1)]
		public static LiftComponentPb Create()
		{
			return new LiftComponentPb();
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x0600CD99 RID: 52633 RVA: 0x001E49AC File Offset: 0x001E2BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002986 RID: 10630
		// (get) Token: 0x0600CD9A RID: 52634 RVA: 0x001E49AF File Offset: 0x001E2BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LiftComponentPb.Descriptor;
			}
		}

		// Token: 0x0600CD9B RID: 52635 RVA: 0x001E49B6 File Offset: 0x001E2BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftComponentPb()
		{
		}

		// Token: 0x0600CD9C RID: 52636 RVA: 0x001E49BE File Offset: 0x001E2BBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftComponentPb(LiftComponentPb other) : this()
		{
			this.location_ = other.location_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD9D RID: 52637 RVA: 0x001E49E3 File Offset: 0x001E2BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LiftComponentPb Clone()
		{
			return new LiftComponentPb(this);
		}

		// Token: 0x17002987 RID: 10631
		// (get) Token: 0x0600CD9E RID: 52638 RVA: 0x001E49EB File Offset: 0x001E2BEB
		// (set) Token: 0x0600CD9F RID: 52639 RVA: 0x001E49F3 File Offset: 0x001E2BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Location
		{
			get
			{
				return this.location_;
			}
			set
			{
				this.location_ = value;
			}
		}

		// Token: 0x0600CDA0 RID: 52640 RVA: 0x001E49FC File Offset: 0x001E2BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LiftComponentPb);
		}

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x001E4A0A File Offset: 0x001E2C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LiftComponentPb other)
		{
			return other != null && (other == this || (this.Location == other.Location && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CDA2 RID: 52642 RVA: 0x001E4A38 File Offset: 0x001E2C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Location != 0)
			{
				num ^= this.Location.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CDA3 RID: 52643 RVA: 0x001E4A77 File Offset: 0x001E2C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CDA4 RID: 52644 RVA: 0x001E4A84 File Offset: 0x001E2C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CDA5 RID: 52645 RVA: 0x001E4A8D File Offset: 0x001E2C8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Location != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Location);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CDA6 RID: 52646 RVA: 0x001E4AC0 File Offset: 0x001E2CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Location != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Location);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CDA7 RID: 52647 RVA: 0x001E4AFE File Offset: 0x001E2CFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LiftComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Location != 0)
			{
				this.Location = other.Location;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CDA8 RID: 52648 RVA: 0x001E4B2F File Offset: 0x001E2D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CDA9 RID: 52649 RVA: 0x001E4B38 File Offset: 0x001E2D38
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Location = input.ReadInt32();
				}
			}
		}

		// Token: 0x040056FF RID: 22271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005700 RID: 22272
		public const int LocationFieldNumber = 1;

		// Token: 0x04005701 RID: 22273
		private int location_;
	}
}
