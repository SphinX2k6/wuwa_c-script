using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200109C RID: 4252
	[NetMessage(EMessageId.RoleShowListUpdateRequest)]
	public sealed class RoleShowListUpdateRequest : IMessage<RoleShowListUpdateRequest>, IMessage, IEquatable<RoleShowListUpdateRequest>, IDeepCloneable<RoleShowListUpdateRequest>, IBufferMessage
	{
		// Token: 0x06016BBE RID: 93118 RVA: 0x0034E465 File Offset: 0x0034C665
		[NullableContext(1)]
		public static RoleShowListUpdateRequest Create()
		{
			return new RoleShowListUpdateRequest();
		}

		// Token: 0x17004C32 RID: 19506
		// (get) Token: 0x06016BBF RID: 93119 RVA: 0x0034E46C File Offset: 0x0034C66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C33 RID: 19507
		// (get) Token: 0x06016BC0 RID: 93120 RVA: 0x0034E46F File Offset: 0x0034C66F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowListUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06016BC1 RID: 93121 RVA: 0x0034E476 File Offset: 0x0034C676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateRequest()
		{
		}

		// Token: 0x06016BC2 RID: 93122 RVA: 0x0034E489 File Offset: 0x0034C689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateRequest(RoleShowListUpdateRequest other) : this()
		{
			this.roleList_ = other.roleList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016BC3 RID: 93123 RVA: 0x0034E4B3 File Offset: 0x0034C6B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowListUpdateRequest Clone()
		{
			return new RoleShowListUpdateRequest(this);
		}

		// Token: 0x17004C34 RID: 19508
		// (get) Token: 0x06016BC4 RID: 93124 RVA: 0x0034E4BB File Offset: 0x0034C6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleList
		{
			get
			{
				return this.roleList_;
			}
		}

		// Token: 0x06016BC5 RID: 93125 RVA: 0x0034E4C3 File Offset: 0x0034C6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowListUpdateRequest);
		}

		// Token: 0x06016BC6 RID: 93126 RVA: 0x0034E4D1 File Offset: 0x0034C6D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowListUpdateRequest other)
		{
			return other != null && (other == this || (this.roleList_.Equals(other.roleList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016BC7 RID: 93127 RVA: 0x0034E504 File Offset: 0x0034C704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016BC8 RID: 93128 RVA: 0x0034E538 File Offset: 0x0034C738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016BC9 RID: 93129 RVA: 0x0034E545 File Offset: 0x0034C745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016BCA RID: 93130 RVA: 0x0034E54E File Offset: 0x0034C74E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleList_.WriteTo(ref output, RoleShowListUpdateRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016BCB RID: 93131 RVA: 0x0034E578 File Offset: 0x0034C778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleList_.CalculateSize(RoleShowListUpdateRequest._repeated_roleList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016BCC RID: 93132 RVA: 0x0034E5B1 File Offset: 0x0034C7B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleShowListUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.roleList_.Add(other.roleList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016BCD RID: 93133 RVA: 0x0034E5DF File Offset: 0x0034C7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016BCE RID: 93134 RVA: 0x0034E5E8 File Offset: 0x0034C7E8
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.roleList_.AddEntriesFrom(ref input, RoleShowListUpdateRequest._repeated_roleList_codec);
				}
			}
		}

		// Token: 0x04008836 RID: 34870
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008837 RID: 34871
		public const int RoleListFieldNumber = 7;

		// Token: 0x04008838 RID: 34872
		private static readonly FieldCodec<int> _repeated_roleList_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008839 RID: 34873
		private readonly RepeatedField<int> roleList_ = new RepeatedField<int>();
	}
}
