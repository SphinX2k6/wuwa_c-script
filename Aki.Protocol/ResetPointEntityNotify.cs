using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F15 RID: 3861
	[NetMessage(EMessageId.ResetPointEntityNotify)]
	public sealed class ResetPointEntityNotify : IMessage<ResetPointEntityNotify>, IMessage, IEquatable<ResetPointEntityNotify>, IDeepCloneable<ResetPointEntityNotify>, IBufferMessage
	{
		// Token: 0x06014B17 RID: 84759 RVA: 0x003016E0 File Offset: 0x002FF8E0
		[NullableContext(1)]
		public static ResetPointEntityNotify Create()
		{
			return new ResetPointEntityNotify();
		}

		// Token: 0x170044CD RID: 17613
		// (get) Token: 0x06014B18 RID: 84760 RVA: 0x003016E7 File Offset: 0x002FF8E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044CE RID: 17614
		// (get) Token: 0x06014B19 RID: 84761 RVA: 0x003016EA File Offset: 0x002FF8EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResetPointEntityNotify.Descriptor;
			}
		}

		// Token: 0x06014B1A RID: 84762 RVA: 0x003016F1 File Offset: 0x002FF8F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetPointEntityNotify()
		{
		}

		// Token: 0x06014B1B RID: 84763 RVA: 0x003016F9 File Offset: 0x002FF8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetPointEntityNotify(ResetPointEntityNotify other) : this()
		{
			this.resetPointEntityId_ = other.resetPointEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014B1C RID: 84764 RVA: 0x0030171E File Offset: 0x002FF91E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ResetPointEntityNotify Clone()
		{
			return new ResetPointEntityNotify(this);
		}

		// Token: 0x170044CF RID: 17615
		// (get) Token: 0x06014B1D RID: 84765 RVA: 0x00301726 File Offset: 0x002FF926
		// (set) Token: 0x06014B1E RID: 84766 RVA: 0x0030172E File Offset: 0x002FF92E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ResetPointEntityId
		{
			get
			{
				return this.resetPointEntityId_;
			}
			set
			{
				this.resetPointEntityId_ = value;
			}
		}

		// Token: 0x06014B1F RID: 84767 RVA: 0x00301737 File Offset: 0x002FF937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResetPointEntityNotify);
		}

		// Token: 0x06014B20 RID: 84768 RVA: 0x00301745 File Offset: 0x002FF945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ResetPointEntityNotify other)
		{
			return other != null && (other == this || (this.ResetPointEntityId == other.ResetPointEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014B21 RID: 84769 RVA: 0x00301774 File Offset: 0x002FF974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ResetPointEntityId != 0)
			{
				num ^= this.ResetPointEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014B22 RID: 84770 RVA: 0x003017B3 File Offset: 0x002FF9B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014B23 RID: 84771 RVA: 0x003017C0 File Offset: 0x002FF9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014B24 RID: 84772 RVA: 0x003017C9 File Offset: 0x002FF9C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ResetPointEntityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ResetPointEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014B25 RID: 84773 RVA: 0x003017FC File Offset: 0x002FF9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ResetPointEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ResetPointEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014B26 RID: 84774 RVA: 0x0030183A File Offset: 0x002FFA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ResetPointEntityNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ResetPointEntityId != 0)
			{
				this.ResetPointEntityId = other.ResetPointEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014B27 RID: 84775 RVA: 0x0030186B File Offset: 0x002FFA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014B28 RID: 84776 RVA: 0x00301874 File Offset: 0x002FFA74
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
					this.ResetPointEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007D7A RID: 32122
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D7B RID: 32123
		public const int ResetPointEntityIdFieldNumber = 6;

		// Token: 0x04007D7C RID: 32124
		private int resetPointEntityId_;
	}
}
