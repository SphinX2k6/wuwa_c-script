using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFC RID: 3836
	[NetMessage(EMessageId.RemoveSysBuffNotify)]
	public sealed class RemoveSysBuffNotify : IMessage<RemoveSysBuffNotify>, IMessage, IEquatable<RemoveSysBuffNotify>, IDeepCloneable<RemoveSysBuffNotify>, IBufferMessage
	{
		// Token: 0x06014927 RID: 84263 RVA: 0x002FD5E1 File Offset: 0x002FB7E1
		[NullableContext(1)]
		public static RemoveSysBuffNotify Create()
		{
			return new RemoveSysBuffNotify();
		}

		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x06014928 RID: 84264 RVA: 0x002FD5E8 File Offset: 0x002FB7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x06014929 RID: 84265 RVA: 0x002FD5EB File Offset: 0x002FB7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveSysBuffNotify.Descriptor;
			}
		}

		// Token: 0x0601492A RID: 84266 RVA: 0x002FD5F2 File Offset: 0x002FB7F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSysBuffNotify()
		{
		}

		// Token: 0x0601492B RID: 84267 RVA: 0x002FD605 File Offset: 0x002FB805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSysBuffNotify(RemoveSysBuffNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601492C RID: 84268 RVA: 0x002FD63B File Offset: 0x002FB83B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSysBuffNotify Clone()
		{
			return new RemoveSysBuffNotify(this);
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x0601492D RID: 84269 RVA: 0x002FD643 File Offset: 0x002FB843
		// (set) Token: 0x0601492E RID: 84270 RVA: 0x002FD64B File Offset: 0x002FB84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x0601492F RID: 84271 RVA: 0x002FD654 File Offset: 0x002FB854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x06014930 RID: 84272 RVA: 0x002FD65C File Offset: 0x002FB85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveSysBuffNotify);
		}

		// Token: 0x06014931 RID: 84273 RVA: 0x002FD66C File Offset: 0x002FB86C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveSysBuffNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014932 RID: 84274 RVA: 0x002FD6BC File Offset: 0x002FB8BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014933 RID: 84275 RVA: 0x002FD709 File Offset: 0x002FB909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014934 RID: 84276 RVA: 0x002FD716 File Offset: 0x002FB916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014935 RID: 84277 RVA: 0x002FD720 File Offset: 0x002FB920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			this.ids_.WriteTo(ref output, RemoveSysBuffNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014936 RID: 84278 RVA: 0x002FD770 File Offset: 0x002FB970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			num += this.ids_.CalculateSize(RemoveSysBuffNotify._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014937 RID: 84279 RVA: 0x002FD7C4 File Offset: 0x002FB9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveSysBuffNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014938 RID: 84280 RVA: 0x002FD811 File Offset: 0x002FBA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014939 RID: 84281 RVA: 0x002FD81C File Offset: 0x002FBA1C
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
				if (num != 16U)
				{
					if (num != 48U && num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, RemoveSysBuffNotify._repeated_ids_codec);
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D01 RID: 32001
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D02 RID: 32002
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04007D03 RID: 32003
		private long entityId_;

		// Token: 0x04007D04 RID: 32004
		public const int IdsFieldNumber = 6;

		// Token: 0x04007D05 RID: 32005
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04007D06 RID: 32006
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
