using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010C4 RID: 4292
	[NetMessage(EMessageId.RoleSkinUpdateNotify)]
	public sealed class RoleSkinUpdateNotify : IMessage<RoleSkinUpdateNotify>, IMessage, IEquatable<RoleSkinUpdateNotify>, IDeepCloneable<RoleSkinUpdateNotify>, IBufferMessage
	{
		// Token: 0x06016E7B RID: 93819 RVA: 0x0035365A File Offset: 0x0035185A
		[NullableContext(1)]
		public static RoleSkinUpdateNotify Create()
		{
			return new RoleSkinUpdateNotify();
		}

		// Token: 0x17004CB9 RID: 19641
		// (get) Token: 0x06016E7C RID: 93820 RVA: 0x00353661 File Offset: 0x00351861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004CBA RID: 19642
		// (get) Token: 0x06016E7D RID: 93821 RVA: 0x00353664 File Offset: 0x00351864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSkinUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06016E7E RID: 93822 RVA: 0x0035366B File Offset: 0x0035186B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinUpdateNotify()
		{
		}

		// Token: 0x06016E7F RID: 93823 RVA: 0x0035367E File Offset: 0x0035187E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinUpdateNotify(RoleSkinUpdateNotify other) : this()
		{
			this.skinIds_ = other.skinIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016E80 RID: 93824 RVA: 0x003536A8 File Offset: 0x003518A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSkinUpdateNotify Clone()
		{
			return new RoleSkinUpdateNotify(this);
		}

		// Token: 0x17004CBB RID: 19643
		// (get) Token: 0x06016E81 RID: 93825 RVA: 0x003536B0 File Offset: 0x003518B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> SkinIds
		{
			get
			{
				return this.skinIds_;
			}
		}

		// Token: 0x06016E82 RID: 93826 RVA: 0x003536B8 File Offset: 0x003518B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSkinUpdateNotify);
		}

		// Token: 0x06016E83 RID: 93827 RVA: 0x003536C6 File Offset: 0x003518C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSkinUpdateNotify other)
		{
			return other != null && (other == this || (this.skinIds_.Equals(other.skinIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016E84 RID: 93828 RVA: 0x003536FC File Offset: 0x003518FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.skinIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016E85 RID: 93829 RVA: 0x00353730 File Offset: 0x00351930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016E86 RID: 93830 RVA: 0x0035373D File Offset: 0x0035193D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016E87 RID: 93831 RVA: 0x00353746 File Offset: 0x00351946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinIds_.WriteTo(ref output, RoleSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016E88 RID: 93832 RVA: 0x00353770 File Offset: 0x00351970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.skinIds_.CalculateSize(RoleSkinUpdateNotify._repeated_skinIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016E89 RID: 93833 RVA: 0x003537A9 File Offset: 0x003519A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSkinUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.skinIds_.Add(other.skinIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016E8A RID: 93834 RVA: 0x003537D7 File Offset: 0x003519D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016E8B RID: 93835 RVA: 0x003537E0 File Offset: 0x003519E0
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.skinIds_.AddEntriesFrom(ref input, RoleSkinUpdateNotify._repeated_skinIds_codec);
				}
			}
		}

		// Token: 0x04008884 RID: 34948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008885 RID: 34949
		public const int SkinIdsFieldNumber = 10;

		// Token: 0x04008886 RID: 34950
		private static readonly FieldCodec<int> _repeated_skinIds_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04008887 RID: 34951
		private readonly RepeatedField<int> skinIds_ = new RepeatedField<int>();
	}
}
