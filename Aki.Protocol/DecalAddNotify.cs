using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B9 RID: 953
	[NetMessage(EMessageId.DecalAddNotify)]
	public sealed class DecalAddNotify : IMessage<DecalAddNotify>, IMessage, IEquatable<DecalAddNotify>, IDeepCloneable<DecalAddNotify>, IBufferMessage
	{
		// Token: 0x06005D61 RID: 23905 RVA: 0x000E2915 File Offset: 0x000E0B15
		[NullableContext(1)]
		public static DecalAddNotify Create()
		{
			return new DecalAddNotify();
		}

		// Token: 0x17001155 RID: 4437
		// (get) Token: 0x06005D62 RID: 23906 RVA: 0x000E291C File Offset: 0x000E0B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06005D63 RID: 23907 RVA: 0x000E291F File Offset: 0x000E0B1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecalAddNotify.Descriptor;
			}
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x000E2926 File Offset: 0x000E0B26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalAddNotify()
		{
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x000E2939 File Offset: 0x000E0B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalAddNotify(DecalAddNotify other) : this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x000E2963 File Offset: 0x000E0B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalAddNotify Clone()
		{
			return new DecalAddNotify(this);
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06005D67 RID: 23911 RVA: 0x000E296B File Offset: 0x000E0B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecalInfo> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x000E2973 File Offset: 0x000E0B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecalAddNotify);
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x000E2981 File Offset: 0x000E0B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecalAddNotify other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x000E29B4 File Offset: 0x000E0BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.info_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x000E29E8 File Offset: 0x000E0BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x000E29F5 File Offset: 0x000E0BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x000E29FE File Offset: 0x000E0BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.info_.WriteTo(ref output, DecalAddNotify._repeated_info_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x000E2A28 File Offset: 0x000E0C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.info_.CalculateSize(DecalAddNotify._repeated_info_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x000E2A61 File Offset: 0x000E0C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DecalAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.info_.Add(other.info_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x000E2A8F File Offset: 0x000E0C8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x000E2A98 File Offset: 0x000E0C98
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.info_.AddEntriesFrom(ref input, DecalAddNotify._repeated_info_codec);
				}
			}
		}

		// Token: 0x04003686 RID: 13958
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003687 RID: 13959
		public const int InfoFieldNumber = 4;

		// Token: 0x04003688 RID: 13960
		private static readonly FieldCodec<DecalInfo> _repeated_info_codec = FieldCodec.ForMessage<DecalInfo>(34U, DecalInfo.Parser);

		// Token: 0x04003689 RID: 13961
		private readonly RepeatedField<DecalInfo> info_ = new RepeatedField<DecalInfo>();
	}
}
