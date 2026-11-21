using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E47 RID: 3655
	public sealed class RacingBetsDangoRoundStart : IMessage<RacingBetsDangoRoundStart>, IMessage, IEquatable<RacingBetsDangoRoundStart>, IDeepCloneable<RacingBetsDangoRoundStart>, IBufferMessage
	{
		// Token: 0x06013A6B RID: 80491 RVA: 0x002DBE06 File Offset: 0x002DA006
		[NullableContext(1)]
		public static RacingBetsDangoRoundStart Create()
		{
			return new RacingBetsDangoRoundStart();
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x06013A6C RID: 80492 RVA: 0x002DBE0D File Offset: 0x002DA00D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x06013A6D RID: 80493 RVA: 0x002DBE10 File Offset: 0x002DA010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoRoundStart.Descriptor;
			}
		}

		// Token: 0x06013A6E RID: 80494 RVA: 0x002DBE17 File Offset: 0x002DA017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoRoundStart()
		{
		}

		// Token: 0x06013A6F RID: 80495 RVA: 0x002DBE1F File Offset: 0x002DA01F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoRoundStart(RacingBetsDangoRoundStart other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A70 RID: 80496 RVA: 0x002DBE44 File Offset: 0x002DA044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoRoundStart Clone()
		{
			return new RacingBetsDangoRoundStart(this);
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x06013A71 RID: 80497 RVA: 0x002DBE4C File Offset: 0x002DA04C
		// (set) Token: 0x06013A72 RID: 80498 RVA: 0x002DBE54 File Offset: 0x002DA054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x06013A73 RID: 80499 RVA: 0x002DBE5D File Offset: 0x002DA05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoRoundStart);
		}

		// Token: 0x06013A74 RID: 80500 RVA: 0x002DBE6B File Offset: 0x002DA06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoRoundStart other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A75 RID: 80501 RVA: 0x002DBE9C File Offset: 0x002DA09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A76 RID: 80502 RVA: 0x002DBEDB File Offset: 0x002DA0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A77 RID: 80503 RVA: 0x002DBEE8 File Offset: 0x002DA0E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A78 RID: 80504 RVA: 0x002DBEF1 File Offset: 0x002DA0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A79 RID: 80505 RVA: 0x002DBF24 File Offset: 0x002DA124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A7A RID: 80506 RVA: 0x002DBF62 File Offset: 0x002DA162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoRoundStart other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A7B RID: 80507 RVA: 0x002DBF93 File Offset: 0x002DA193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A7C RID: 80508 RVA: 0x002DBF9C File Offset: 0x002DA19C
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
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040078B4 RID: 30900
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078B5 RID: 30901
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040078B6 RID: 30902
		private int dangoId_;
	}
}
