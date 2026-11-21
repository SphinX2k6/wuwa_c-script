using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E7B RID: 3707
	public sealed class RbBreakableObstaclePbType : IMessage<RbBreakableObstaclePbType>, IMessage, IEquatable<RbBreakableObstaclePbType>, IDeepCloneable<RbBreakableObstaclePbType>, IBufferMessage
	{
		// Token: 0x06013F0D RID: 81677 RVA: 0x002E846E File Offset: 0x002E666E
		[NullableContext(1)]
		public static RbBreakableObstaclePbType Create()
		{
			return new RbBreakableObstaclePbType();
		}

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x06013F0E RID: 81678 RVA: 0x002E8475 File Offset: 0x002E6675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x06013F0F RID: 81679 RVA: 0x002E8478 File Offset: 0x002E6678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBreakableObstaclePbType.Descriptor;
			}
		}

		// Token: 0x06013F10 RID: 81680 RVA: 0x002E847F File Offset: 0x002E667F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBreakableObstaclePbType()
		{
		}

		// Token: 0x06013F11 RID: 81681 RVA: 0x002E8492 File Offset: 0x002E6692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBreakableObstaclePbType(RbBreakableObstaclePbType other) : this()
		{
			this.linkPoints_ = other.linkPoints_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F12 RID: 81682 RVA: 0x002E84BC File Offset: 0x002E66BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBreakableObstaclePbType Clone()
		{
			return new RbBreakableObstaclePbType(this);
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x06013F13 RID: 81683 RVA: 0x002E84C4 File Offset: 0x002E66C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> LinkPoints
		{
			get
			{
				return this.linkPoints_;
			}
		}

		// Token: 0x06013F14 RID: 81684 RVA: 0x002E84CC File Offset: 0x002E66CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBreakableObstaclePbType);
		}

		// Token: 0x06013F15 RID: 81685 RVA: 0x002E84DA File Offset: 0x002E66DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBreakableObstaclePbType other)
		{
			return other != null && (other == this || (this.linkPoints_.Equals(other.linkPoints_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F16 RID: 81686 RVA: 0x002E8510 File Offset: 0x002E6710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.linkPoints_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F17 RID: 81687 RVA: 0x002E8544 File Offset: 0x002E6744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F18 RID: 81688 RVA: 0x002E8551 File Offset: 0x002E6751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F19 RID: 81689 RVA: 0x002E855A File Offset: 0x002E675A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.linkPoints_.WriteTo(ref output, RbBreakableObstaclePbType._repeated_linkPoints_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F1A RID: 81690 RVA: 0x002E8584 File Offset: 0x002E6784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.linkPoints_.CalculateSize(RbBreakableObstaclePbType._repeated_linkPoints_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F1B RID: 81691 RVA: 0x002E85BD File Offset: 0x002E67BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RbBreakableObstaclePbType other)
		{
			if (other == null)
			{
				return;
			}
			this.linkPoints_.Add(other.linkPoints_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F1C RID: 81692 RVA: 0x002E85EB File Offset: 0x002E67EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F1D RID: 81693 RVA: 0x002E85F4 File Offset: 0x002E67F4
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.linkPoints_.AddEntriesFrom(ref input, RbBreakableObstaclePbType._repeated_linkPoints_codec);
				}
			}
		}

		// Token: 0x04007A4C RID: 31308
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A4D RID: 31309
		public const int LinkPointsFieldNumber = 1;

		// Token: 0x04007A4E RID: 31310
		private static readonly FieldCodec<Vector> _repeated_linkPoints_codec = FieldCodec.ForMessage<Vector>(10U, Vector.Parser);

		// Token: 0x04007A4F RID: 31311
		private readonly RepeatedField<Vector> linkPoints_ = new RepeatedField<Vector>();
	}
}
