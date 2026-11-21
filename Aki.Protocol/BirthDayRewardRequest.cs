using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001A1 RID: 417
	[NetMessage(EMessageId.BirthDayRewardRequest)]
	public sealed class BirthDayRewardRequest : IMessage<BirthDayRewardRequest>, IMessage, IEquatable<BirthDayRewardRequest>, IDeepCloneable<BirthDayRewardRequest>, IBufferMessage
	{
		// Token: 0x0600314E RID: 12622 RVA: 0x0007DB39 File Offset: 0x0007BD39
		[NullableContext(1)]
		public static BirthDayRewardRequest Create()
		{
			return new BirthDayRewardRequest();
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x0007DB40 File Offset: 0x0007BD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x0007DB43 File Offset: 0x0007BD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayRewardRequest.Descriptor;
			}
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x0007DB4A File Offset: 0x0007BD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardRequest()
		{
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x0007DB52 File Offset: 0x0007BD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardRequest(BirthDayRewardRequest other) : this()
		{
			this.yearId_ = other.yearId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x0007DB77 File Offset: 0x0007BD77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardRequest Clone()
		{
			return new BirthDayRewardRequest(this);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x0007DB7F File Offset: 0x0007BD7F
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x0007DB87 File Offset: 0x0007BD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int YearId
		{
			get
			{
				return this.yearId_;
			}
			set
			{
				this.yearId_ = value;
			}
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x0007DB90 File Offset: 0x0007BD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayRewardRequest);
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x0007DB9E File Offset: 0x0007BD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayRewardRequest other)
		{
			return other != null && (other == this || (this.YearId == other.YearId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x0007DBCC File Offset: 0x0007BDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.YearId != 0)
			{
				num ^= this.YearId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x0007DC0B File Offset: 0x0007BE0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x0007DC18 File Offset: 0x0007BE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x0007DC21 File Offset: 0x0007BE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.YearId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.YearId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x0007DC54 File Offset: 0x0007BE54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.YearId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.YearId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x0007DC92 File Offset: 0x0007BE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.YearId != 0)
			{
				this.YearId = other.YearId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0007DCC3 File Offset: 0x0007BEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0007DCCC File Offset: 0x0007BECC
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
					this.YearId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002981 RID: 10625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002982 RID: 10626
		public const int YearIdFieldNumber = 15;

		// Token: 0x04002983 RID: 10627
		private int yearId_;
	}
}
