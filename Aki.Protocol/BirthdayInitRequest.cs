using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019B RID: 411
	[NetMessage(EMessageId.BirthdayInitRequest)]
	public sealed class BirthdayInitRequest : IMessage<BirthdayInitRequest>, IMessage, IEquatable<BirthdayInitRequest>, IDeepCloneable<BirthdayInitRequest>, IBufferMessage
	{
		// Token: 0x0600309D RID: 12445 RVA: 0x0007C013 File Offset: 0x0007A213
		[NullableContext(1)]
		public static BirthdayInitRequest Create()
		{
			return new BirthdayInitRequest();
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x0600309E RID: 12446 RVA: 0x0007C01A File Offset: 0x0007A21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x0007C01D File Offset: 0x0007A21D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthdayInitRequest.Descriptor;
			}
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0007C024 File Offset: 0x0007A224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitRequest()
		{
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x0007C02C File Offset: 0x0007A22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitRequest(BirthdayInitRequest other) : this()
		{
			this.birthday_ = other.birthday_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x0007C051 File Offset: 0x0007A251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthdayInitRequest Clone()
		{
			return new BirthdayInitRequest(this);
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x0007C059 File Offset: 0x0007A259
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x0007C061 File Offset: 0x0007A261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Birthday
		{
			get
			{
				return this.birthday_;
			}
			set
			{
				this.birthday_ = value;
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x0007C06A File Offset: 0x0007A26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthdayInitRequest);
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x0007C078 File Offset: 0x0007A278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthdayInitRequest other)
		{
			return other != null && (other == this || (this.Birthday == other.Birthday && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030A7 RID: 12455 RVA: 0x0007C0A8 File Offset: 0x0007A2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Birthday != 0)
			{
				num ^= this.Birthday.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030A8 RID: 12456 RVA: 0x0007C0E7 File Offset: 0x0007A2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0007C0F4 File Offset: 0x0007A2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x0007C0FD File Offset: 0x0007A2FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Birthday != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Birthday);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0007C130 File Offset: 0x0007A330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Birthday != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Birthday);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0007C16E File Offset: 0x0007A36E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthdayInitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Birthday != 0)
			{
				this.Birthday = other.Birthday;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0007C19F File Offset: 0x0007A39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Birthday = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002900 RID: 10496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002901 RID: 10497
		public const int BirthdayFieldNumber = 4;

		// Token: 0x04002902 RID: 10498
		private int birthday_;
	}
}
