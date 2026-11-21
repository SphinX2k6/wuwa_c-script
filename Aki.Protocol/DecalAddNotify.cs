using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A2 RID: 930
	[NetMessage(EMessageId.DecalAddNotify)]
	public sealed class DecalAddNotify : IMessage<DecalAddNotify>, IMessage, IEquatable<DecalAddNotify>, IDeepCloneable<DecalAddNotify>, IBufferMessage
	{
		// Token: 0x06005BCF RID: 23503 RVA: 0x000DF6CC File Offset: 0x000DD8CC
		[NullableContext(1)]
		public static DecalAddNotify Create()
		{
			return new DecalAddNotify();
		}

		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x000DF6D3 File Offset: 0x000DD8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001100 RID: 4352
		// (get) Token: 0x06005BD1 RID: 23505 RVA: 0x000DF6D6 File Offset: 0x000DD8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DecalAddNotify.Descriptor;
			}
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x000DF6DD File Offset: 0x000DD8DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalAddNotify()
		{
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x000DF6F0 File Offset: 0x000DD8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalAddNotify(DecalAddNotify other) : this()
		{
			this.info_ = other.info_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x000DF71A File Offset: 0x000DD91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DecalAddNotify Clone()
		{
			return new DecalAddNotify(this);
		}

		// Token: 0x17001101 RID: 4353
		// (get) Token: 0x06005BD5 RID: 23509 RVA: 0x000DF722 File Offset: 0x000DD922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DecalInfo> Info
		{
			get
			{
				return this.info_;
			}
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x000DF72A File Offset: 0x000DD92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DecalAddNotify);
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x000DF738 File Offset: 0x000DD938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DecalAddNotify other)
		{
			return other != null && (other == this || (this.info_.Equals(other.info_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x000DF76C File Offset: 0x000DD96C
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

		// Token: 0x06005BD9 RID: 23513 RVA: 0x000DF7A0 File Offset: 0x000DD9A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x000DF7AD File Offset: 0x000DD9AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x000DF7B6 File Offset: 0x000DD9B6
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

		// Token: 0x06005BDC RID: 23516 RVA: 0x000DF7E0 File Offset: 0x000DD9E0
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

		// Token: 0x06005BDD RID: 23517 RVA: 0x000DF819 File Offset: 0x000DDA19
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

		// Token: 0x06005BDE RID: 23518 RVA: 0x000DF847 File Offset: 0x000DDA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x000DF850 File Offset: 0x000DDA50
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.info_.AddEntriesFrom(ref input, DecalAddNotify._repeated_info_codec);
				}
			}
		}

		// Token: 0x04003671 RID: 13937
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003672 RID: 13938
		public const int InfoFieldNumber = 10;

		// Token: 0x04003673 RID: 13939
		private static readonly FieldCodec<DecalInfo> _repeated_info_codec = FieldCodec.ForMessage<DecalInfo>(82U, DecalInfo.Parser);

		// Token: 0x04003674 RID: 13940
		private readonly RepeatedField<DecalInfo> info_ = new RepeatedField<DecalInfo>();
	}
}
