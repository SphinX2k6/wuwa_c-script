using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E8B RID: 3723
	public sealed class RbBreakableObstaclePbType : IMessage<RbBreakableObstaclePbType>, IMessage, IEquatable<RbBreakableObstaclePbType>, IDeepCloneable<RbBreakableObstaclePbType>, IBufferMessage
	{
		// Token: 0x06013FF2 RID: 81906 RVA: 0x002E9B2A File Offset: 0x002E7D2A
		[NullableContext(1)]
		public static RbBreakableObstaclePbType Create()
		{
			return new RbBreakableObstaclePbType();
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x06013FF3 RID: 81907 RVA: 0x002E9B31 File Offset: 0x002E7D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x06013FF4 RID: 81908 RVA: 0x002E9B34 File Offset: 0x002E7D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RbBreakableObstaclePbType.Descriptor;
			}
		}

		// Token: 0x06013FF5 RID: 81909 RVA: 0x002E9B3B File Offset: 0x002E7D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBreakableObstaclePbType()
		{
		}

		// Token: 0x06013FF6 RID: 81910 RVA: 0x002E9B4E File Offset: 0x002E7D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBreakableObstaclePbType(RbBreakableObstaclePbType other) : this()
		{
			this.linkPoints_ = other.linkPoints_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FF7 RID: 81911 RVA: 0x002E9B78 File Offset: 0x002E7D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbBreakableObstaclePbType Clone()
		{
			return new RbBreakableObstaclePbType(this);
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x06013FF8 RID: 81912 RVA: 0x002E9B80 File Offset: 0x002E7D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Vector> LinkPoints
		{
			get
			{
				return this.linkPoints_;
			}
		}

		// Token: 0x06013FF9 RID: 81913 RVA: 0x002E9B88 File Offset: 0x002E7D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RbBreakableObstaclePbType);
		}

		// Token: 0x06013FFA RID: 81914 RVA: 0x002E9B96 File Offset: 0x002E7D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RbBreakableObstaclePbType other)
		{
			return other != null && (other == this || (this.linkPoints_.Equals(other.linkPoints_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013FFB RID: 81915 RVA: 0x002E9BCC File Offset: 0x002E7DCC
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

		// Token: 0x06013FFC RID: 81916 RVA: 0x002E9C00 File Offset: 0x002E7E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013FFD RID: 81917 RVA: 0x002E9C0D File Offset: 0x002E7E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013FFE RID: 81918 RVA: 0x002E9C16 File Offset: 0x002E7E16
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

		// Token: 0x06013FFF RID: 81919 RVA: 0x002E9C40 File Offset: 0x002E7E40
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

		// Token: 0x06014000 RID: 81920 RVA: 0x002E9C79 File Offset: 0x002E7E79
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

		// Token: 0x06014001 RID: 81921 RVA: 0x002E9CA7 File Offset: 0x002E7EA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014002 RID: 81922 RVA: 0x002E9CB0 File Offset: 0x002E7EB0
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

		// Token: 0x04007A22 RID: 31266
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A23 RID: 31267
		public const int LinkPointsFieldNumber = 1;

		// Token: 0x04007A24 RID: 31268
		private static readonly FieldCodec<Vector> _repeated_linkPoints_codec = FieldCodec.ForMessage<Vector>(10U, Vector.Parser);

		// Token: 0x04007A25 RID: 31269
		private readonly RepeatedField<Vector> linkPoints_ = new RepeatedField<Vector>();
	}
}
