using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200108D RID: 4237
	[NetMessage(EMessageId.RolePropRequest)]
	public sealed class RolePropRequest : IMessage<RolePropRequest>, IMessage, IEquatable<RolePropRequest>, IDeepCloneable<RolePropRequest>, IBufferMessage
	{
		// Token: 0x06016A99 RID: 92825 RVA: 0x0034C015 File Offset: 0x0034A215
		[NullableContext(1)]
		public static RolePropRequest Create()
		{
			return new RolePropRequest();
		}

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x06016A9A RID: 92826 RVA: 0x0034C01C File Offset: 0x0034A21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x06016A9B RID: 92827 RVA: 0x0034C01F File Offset: 0x0034A21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RolePropRequest.Descriptor;
			}
		}

		// Token: 0x06016A9C RID: 92828 RVA: 0x0034C026 File Offset: 0x0034A226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropRequest()
		{
		}

		// Token: 0x06016A9D RID: 92829 RVA: 0x0034C039 File Offset: 0x0034A239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropRequest(RolePropRequest other) : this()
		{
			this.roleIds_ = other.roleIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016A9E RID: 92830 RVA: 0x0034C063 File Offset: 0x0034A263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RolePropRequest Clone()
		{
			return new RolePropRequest(this);
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x06016A9F RID: 92831 RVA: 0x0034C06B File Offset: 0x0034A26B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleIds
		{
			get
			{
				return this.roleIds_;
			}
		}

		// Token: 0x06016AA0 RID: 92832 RVA: 0x0034C073 File Offset: 0x0034A273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RolePropRequest);
		}

		// Token: 0x06016AA1 RID: 92833 RVA: 0x0034C081 File Offset: 0x0034A281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RolePropRequest other)
		{
			return other != null && (other == this || (this.roleIds_.Equals(other.roleIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016AA2 RID: 92834 RVA: 0x0034C0B4 File Offset: 0x0034A2B4
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

		// Token: 0x06016AA3 RID: 92835 RVA: 0x0034C0E8 File Offset: 0x0034A2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016AA4 RID: 92836 RVA: 0x0034C0F5 File Offset: 0x0034A2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016AA5 RID: 92837 RVA: 0x0034C0FE File Offset: 0x0034A2FE
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

		// Token: 0x06016AA6 RID: 92838 RVA: 0x0034C128 File Offset: 0x0034A328
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

		// Token: 0x06016AA7 RID: 92839 RVA: 0x0034C161 File Offset: 0x0034A361
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

		// Token: 0x06016AA8 RID: 92840 RVA: 0x0034C18F File Offset: 0x0034A38F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016AA9 RID: 92841 RVA: 0x0034C198 File Offset: 0x0034A398
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

		// Token: 0x040087E9 RID: 34793
		private UnknownFieldSet _unknownFields;

		// Token: 0x040087EA RID: 34794
		public const int RoleIdsFieldNumber = 13;

		// Token: 0x040087EB RID: 34795
		private static readonly FieldCodec<int> _repeated_roleIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x040087EC RID: 34796
		private readonly RepeatedField<int> roleIds_ = new RepeatedField<int>();
	}
}
