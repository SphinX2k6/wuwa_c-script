using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E55 RID: 3669
	public sealed class RacingBetsDangoCameraMove : IMessage<RacingBetsDangoCameraMove>, IMessage, IEquatable<RacingBetsDangoCameraMove>, IDeepCloneable<RacingBetsDangoCameraMove>, IBufferMessage
	{
		// Token: 0x06013B26 RID: 80678 RVA: 0x002DCF84 File Offset: 0x002DB184
		[NullableContext(1)]
		public static RacingBetsDangoCameraMove Create()
		{
			return new RacingBetsDangoCameraMove();
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x06013B27 RID: 80679 RVA: 0x002DCF8B File Offset: 0x002DB18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x06013B28 RID: 80680 RVA: 0x002DCF8E File Offset: 0x002DB18E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoCameraMove.Descriptor;
			}
		}

		// Token: 0x06013B29 RID: 80681 RVA: 0x002DCF95 File Offset: 0x002DB195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoCameraMove()
		{
		}

		// Token: 0x06013B2A RID: 80682 RVA: 0x002DCF9D File Offset: 0x002DB19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoCameraMove(RacingBetsDangoCameraMove other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B2B RID: 80683 RVA: 0x002DCFC2 File Offset: 0x002DB1C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoCameraMove Clone()
		{
			return new RacingBetsDangoCameraMove(this);
		}

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x06013B2C RID: 80684 RVA: 0x002DCFCA File Offset: 0x002DB1CA
		// (set) Token: 0x06013B2D RID: 80685 RVA: 0x002DCFD2 File Offset: 0x002DB1D2
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

		// Token: 0x06013B2E RID: 80686 RVA: 0x002DCFDB File Offset: 0x002DB1DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoCameraMove);
		}

		// Token: 0x06013B2F RID: 80687 RVA: 0x002DCFE9 File Offset: 0x002DB1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoCameraMove other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B30 RID: 80688 RVA: 0x002DD018 File Offset: 0x002DB218
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

		// Token: 0x06013B31 RID: 80689 RVA: 0x002DD057 File Offset: 0x002DB257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B32 RID: 80690 RVA: 0x002DD064 File Offset: 0x002DB264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B33 RID: 80691 RVA: 0x002DD06D File Offset: 0x002DB26D
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

		// Token: 0x06013B34 RID: 80692 RVA: 0x002DD0A0 File Offset: 0x002DB2A0
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

		// Token: 0x06013B35 RID: 80693 RVA: 0x002DD0DE File Offset: 0x002DB2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoCameraMove other)
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

		// Token: 0x06013B36 RID: 80694 RVA: 0x002DD10F File Offset: 0x002DB30F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B37 RID: 80695 RVA: 0x002DD118 File Offset: 0x002DB318
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

		// Token: 0x0400787F RID: 30847
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007880 RID: 30848
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007881 RID: 30849
		private int dangoId_;
	}
}
