using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019D RID: 413
	[NetMessage(EMessageId.BirthDayRewardRequest)]
	public sealed class BirthDayRewardRequest : IMessage<BirthDayRewardRequest>, IMessage, IEquatable<BirthDayRewardRequest>, IDeepCloneable<BirthDayRewardRequest>, IBufferMessage
	{
		// Token: 0x060030C1 RID: 12481 RVA: 0x0007C3CD File Offset: 0x0007A5CD
		[NullableContext(1)]
		public static BirthDayRewardRequest Create()
		{
			return new BirthDayRewardRequest();
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x0007C3D4 File Offset: 0x0007A5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x0007C3D7 File Offset: 0x0007A5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayRewardRequest.Descriptor;
			}
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0007C3DE File Offset: 0x0007A5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardRequest()
		{
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x0007C3E6 File Offset: 0x0007A5E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardRequest(BirthDayRewardRequest other) : this()
		{
			this.yearId_ = other.yearId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x0007C40B File Offset: 0x0007A60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardRequest Clone()
		{
			return new BirthDayRewardRequest(this);
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x0007C413 File Offset: 0x0007A613
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x0007C41B File Offset: 0x0007A61B
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

		// Token: 0x060030C9 RID: 12489 RVA: 0x0007C424 File Offset: 0x0007A624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayRewardRequest);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x0007C432 File Offset: 0x0007A632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayRewardRequest other)
		{
			return other != null && (other == this || (this.YearId == other.YearId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x0007C460 File Offset: 0x0007A660
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

		// Token: 0x060030CC RID: 12492 RVA: 0x0007C49F File Offset: 0x0007A69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x0007C4AC File Offset: 0x0007A6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x0007C4B5 File Offset: 0x0007A6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.YearId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.YearId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x0007C4E8 File Offset: 0x0007A6E8
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

		// Token: 0x060030D0 RID: 12496 RVA: 0x0007C526 File Offset: 0x0007A726
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

		// Token: 0x060030D1 RID: 12497 RVA: 0x0007C557 File Offset: 0x0007A757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0007C560 File Offset: 0x0007A760
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.YearId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002906 RID: 10502
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002907 RID: 10503
		public const int YearIdFieldNumber = 6;

		// Token: 0x04002908 RID: 10504
		private int yearId_;
	}
}
