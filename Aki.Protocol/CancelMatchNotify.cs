using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000235 RID: 565
	[NetMessage(EMessageId.CancelMatchNotify)]
	public sealed class CancelMatchNotify : IMessage<CancelMatchNotify>, IMessage, IEquatable<CancelMatchNotify>, IDeepCloneable<CancelMatchNotify>, IBufferMessage
	{
		// Token: 0x06003D5C RID: 15708 RVA: 0x000988DB File Offset: 0x00096ADB
		[NullableContext(1)]
		public static CancelMatchNotify Create()
		{
			return new CancelMatchNotify();
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06003D5D RID: 15709 RVA: 0x000988E2 File Offset: 0x00096AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06003D5E RID: 15710 RVA: 0x000988E5 File Offset: 0x00096AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CancelMatchNotify.Descriptor;
			}
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x000988EC File Offset: 0x00096AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchNotify()
		{
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x000988F4 File Offset: 0x00096AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchNotify(CancelMatchNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00098919 File Offset: 0x00096B19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CancelMatchNotify Clone()
		{
			return new CancelMatchNotify(this);
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06003D62 RID: 15714 RVA: 0x00098921 File Offset: 0x00096B21
		// (set) Token: 0x06003D63 RID: 15715 RVA: 0x00098929 File Offset: 0x00096B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x00098932 File Offset: 0x00096B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CancelMatchNotify);
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x00098940 File Offset: 0x00096B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CancelMatchNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x00098970 File Offset: 0x00096B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x000989AF File Offset: 0x00096BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x000989BC File Offset: 0x00096BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x000989C5 File Offset: 0x00096BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x000989F8 File Offset: 0x00096BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00098A36 File Offset: 0x00096C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CancelMatchNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00098A67 File Offset: 0x00096C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00098A70 File Offset: 0x00096C70
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D05 RID: 11525
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D06 RID: 11526
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x04002D07 RID: 11527
		private int playerId_;
	}
}
