using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C2 RID: 706
	public sealed class CompleteInstProgress : IMessage<CompleteInstProgress>, IMessage, IEquatable<CompleteInstProgress>, IDeepCloneable<CompleteInstProgress>, IBufferMessage
	{
		// Token: 0x060048A4 RID: 18596 RVA: 0x000B1DF9 File Offset: 0x000AFFF9
		[NullableContext(1)]
		public static CompleteInstProgress Create()
		{
			return new CompleteInstProgress();
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060048A5 RID: 18597 RVA: 0x000B1E00 File Offset: 0x000B0000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x000B1E03 File Offset: 0x000B0003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompleteInstProgress.Descriptor;
			}
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x000B1E0A File Offset: 0x000B000A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteInstProgress()
		{
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x000B1E12 File Offset: 0x000B0012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteInstProgress(CompleteInstProgress other) : this()
		{
			this.instId_ = other.instId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x000B1E43 File Offset: 0x000B0043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompleteInstProgress Clone()
		{
			return new CompleteInstProgress(this);
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x000B1E4B File Offset: 0x000B004B
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x000B1E53 File Offset: 0x000B0053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x000B1E5C File Offset: 0x000B005C
		// (set) Token: 0x060048AD RID: 18605 RVA: 0x000B1E64 File Offset: 0x000B0064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x060048AE RID: 18606 RVA: 0x000B1E6D File Offset: 0x000B006D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompleteInstProgress);
		}

		// Token: 0x060048AF RID: 18607 RVA: 0x000B1E7B File Offset: 0x000B007B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompleteInstProgress other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048B0 RID: 18608 RVA: 0x000B1EBC File Offset: 0x000B00BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060048B1 RID: 18609 RVA: 0x000B1F14 File Offset: 0x000B0114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x000B1F21 File Offset: 0x000B0121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x000B1F2C File Offset: 0x000B012C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.InstId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x000B1F84 File Offset: 0x000B0184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x000B1FDC File Offset: 0x000B01DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CompleteInstProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x000B202C File Offset: 0x000B022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x000B2038 File Offset: 0x000B0238
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
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002FED RID: 12269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FEE RID: 12270
		public const int InstIdFieldNumber = 1;

		// Token: 0x04002FEF RID: 12271
		private int instId_;

		// Token: 0x04002FF0 RID: 12272
		public const int CountFieldNumber = 2;

		// Token: 0x04002FF1 RID: 12273
		private int count_;
	}
}
