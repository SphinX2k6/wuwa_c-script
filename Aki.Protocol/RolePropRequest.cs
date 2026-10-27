using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109D RID: 4253
	[NetMessage(EMessageId.RolePropRequest)]
	public sealed class RolePropRequest : IMessage<RolePropRequest>, IMessage, IEquatable<RolePropRequest>, IDeepCloneable<RolePropRequest>, IBufferMessage
	{
		// Token: 0x06016B7E RID: 93054 RVA: 0x0034D6F1 File Offset: 0x0034B8F1
		[NullableContext(1)]
		public static RolePropRequest Create()
		{
			return new RolePropRequest();
		}

		// Token: 0x17004C22 RID: 19490
		// (get) Token: 0x06016B7F RID: 93055 RVA: 0x0034D6F8 File Offset: 0x0034B8F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C23 RID: 19491
		// (get) Token: 0x06016B80 RID: 93056 RVA: 0x0034D6FB File Offset: 0x0034B8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePropRequest.Descriptor;
			}
		}

		// Token: 0x06016B81 RID: 93057 RVA: 0x0034D702 File Offset: 0x0034B902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropRequest()
		{
		}

		// Token: 0x06016B82 RID: 93058 RVA: 0x0034D715 File Offset: 0x0034B915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropRequest(RolePropRequest other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B83 RID: 93059 RVA: 0x0034D73F File Offset: 0x0034B93F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropRequest Clone()
		{
			return new RolePropRequest(this);
		}

		// Token: 0x17004C24 RID: 19492
		// (get) Token: 0x06016B84 RID: 93060 RVA: 0x0034D747 File Offset: 0x0034B947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x06016B85 RID: 93061 RVA: 0x0034D74F File Offset: 0x0034B94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePropRequest);
		}

		// Token: 0x06016B86 RID: 93062 RVA: 0x0034D75D File Offset: 0x0034B95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePropRequest other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B87 RID: 93063 RVA: 0x0034D790 File Offset: 0x0034B990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B88 RID: 93064 RVA: 0x0034D7C4 File Offset: 0x0034B9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B89 RID: 93065 RVA: 0x0034D7D1 File Offset: 0x0034B9D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B8A RID: 93066 RVA: 0x0034D7DA File Offset: 0x0034B9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleIds_.WriteTo(ref output, RolePropRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B8B RID: 93067 RVA: 0x0034D804 File Offset: 0x0034BA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIds_.CalculateSize(RolePropRequest._repeated_roleIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B8C RID: 93068 RVA: 0x0034D83D File Offset: 0x0034BA3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RolePropRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.roleIds_.Add(other.roleIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B8D RID: 93069 RVA: 0x0034D86B File Offset: 0x0034BA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B8E RID: 93070 RVA: 0x0034D874 File Offset: 0x0034BA74
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleIds_.AddEntriesFrom(ref input, RolePropRequest._repeated_roleIds_codec);
				}
			}
		}

		// Token: 0x040087BF RID: 34751
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087C0 RID: 34752
		public const int RoleIdsFieldNumber = 13;

		// Token: 0x040087C1 RID: 34753
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040087C2 RID: 34754
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
