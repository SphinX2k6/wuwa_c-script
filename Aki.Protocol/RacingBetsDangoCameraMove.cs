using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E45 RID: 3653
	public sealed class RacingBetsDangoCameraMove : IMessage<RacingBetsDangoCameraMove>, IMessage, IEquatable<RacingBetsDangoCameraMove>, IDeepCloneable<RacingBetsDangoCameraMove>, IBufferMessage
	{
		// Token: 0x06013A41 RID: 80449 RVA: 0x002DB8C8 File Offset: 0x002D9AC8
		[NullableContext(1)]
		public static RacingBetsDangoCameraMove Create()
		{
			return new RacingBetsDangoCameraMove();
		}

		// Token: 0x17004134 RID: 16692
		// (get) Token: 0x06013A42 RID: 80450 RVA: 0x002DB8CF File Offset: 0x002D9ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004135 RID: 16693
		// (get) Token: 0x06013A43 RID: 80451 RVA: 0x002DB8D2 File Offset: 0x002D9AD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoCameraMove.Descriptor;
			}
		}

		// Token: 0x06013A44 RID: 80452 RVA: 0x002DB8D9 File Offset: 0x002D9AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoCameraMove()
		{
		}

		// Token: 0x06013A45 RID: 80453 RVA: 0x002DB8E1 File Offset: 0x002D9AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoCameraMove(RacingBetsDangoCameraMove other) : this()
		{
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A46 RID: 80454 RVA: 0x002DB906 File Offset: 0x002D9B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoCameraMove Clone()
		{
			return new RacingBetsDangoCameraMove(this);
		}

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x06013A47 RID: 80455 RVA: 0x002DB90E File Offset: 0x002D9B0E
		// (set) Token: 0x06013A48 RID: 80456 RVA: 0x002DB916 File Offset: 0x002D9B16
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

		// Token: 0x06013A49 RID: 80457 RVA: 0x002DB91F File Offset: 0x002D9B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoCameraMove);
		}

		// Token: 0x06013A4A RID: 80458 RVA: 0x002DB92D File Offset: 0x002D9B2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoCameraMove other)
		{
			return other != null && (other == this || (this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A4B RID: 80459 RVA: 0x002DB95C File Offset: 0x002D9B5C
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

		// Token: 0x06013A4C RID: 80460 RVA: 0x002DB99B File Offset: 0x002D9B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A4D RID: 80461 RVA: 0x002DB9A8 File Offset: 0x002D9BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A4E RID: 80462 RVA: 0x002DB9B1 File Offset: 0x002D9BB1
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

		// Token: 0x06013A4F RID: 80463 RVA: 0x002DB9E4 File Offset: 0x002D9BE4
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

		// Token: 0x06013A50 RID: 80464 RVA: 0x002DBA22 File Offset: 0x002D9C22
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

		// Token: 0x06013A51 RID: 80465 RVA: 0x002DBA53 File Offset: 0x002D9C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A52 RID: 80466 RVA: 0x002DBA5C File Offset: 0x002D9C5C
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

		// Token: 0x040078A9 RID: 30889
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078AA RID: 30890
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040078AB RID: 30891
		private int dangoId_;
	}
}
