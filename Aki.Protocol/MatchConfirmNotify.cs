using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009B7 RID: 2487
	[NetMessage(EMessageId.MatchConfirmNotify)]
	public sealed class MatchConfirmNotify : IMessage<MatchConfirmNotify>, IMessage, IEquatable<MatchConfirmNotify>, IDeepCloneable<MatchConfirmNotify>, IBufferMessage
	{
		// Token: 0x0600DA39 RID: 55865 RVA: 0x00200B05 File Offset: 0x001FED05
		[NullableContext(1)]
		public static MatchConfirmNotify Create()
		{
			return new MatchConfirmNotify();
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x0600DA3A RID: 55866 RVA: 0x00200B0C File Offset: 0x001FED0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x0600DA3B RID: 55867 RVA: 0x00200B0F File Offset: 0x001FED0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchConfirmNotify.Descriptor;
			}
		}

		// Token: 0x0600DA3C RID: 55868 RVA: 0x00200B16 File Offset: 0x001FED16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmNotify()
		{
		}

		// Token: 0x0600DA3D RID: 55869 RVA: 0x00200B1E File Offset: 0x001FED1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmNotify(MatchConfirmNotify other) : this()
		{
			this.confirmId_ = other.confirmId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA3E RID: 55870 RVA: 0x00200B43 File Offset: 0x001FED43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchConfirmNotify Clone()
		{
			return new MatchConfirmNotify(this);
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x0600DA3F RID: 55871 RVA: 0x00200B4B File Offset: 0x001FED4B
		// (set) Token: 0x0600DA40 RID: 55872 RVA: 0x00200B53 File Offset: 0x001FED53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfirmId
		{
			get
			{
				return this.confirmId_;
			}
			set
			{
				this.confirmId_ = value;
			}
		}

		// Token: 0x0600DA41 RID: 55873 RVA: 0x00200B5C File Offset: 0x001FED5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchConfirmNotify);
		}

		// Token: 0x0600DA42 RID: 55874 RVA: 0x00200B6A File Offset: 0x001FED6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchConfirmNotify other)
		{
			return other != null && (other == this || (this.ConfirmId == other.ConfirmId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA43 RID: 55875 RVA: 0x00200B98 File Offset: 0x001FED98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfirmId != 0)
			{
				num ^= this.ConfirmId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DA44 RID: 55876 RVA: 0x00200BD7 File Offset: 0x001FEDD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DA45 RID: 55877 RVA: 0x00200BE4 File Offset: 0x001FEDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA46 RID: 55878 RVA: 0x00200BED File Offset: 0x001FEDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfirmId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ConfirmId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA47 RID: 55879 RVA: 0x00200C20 File Offset: 0x001FEE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfirmId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfirmId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA48 RID: 55880 RVA: 0x00200C5E File Offset: 0x001FEE5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchConfirmNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfirmId != 0)
			{
				this.ConfirmId = other.ConfirmId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x00200C8F File Offset: 0x001FEE8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x00200C98 File Offset: 0x001FEE98
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfirmId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005AA9 RID: 23209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005AAA RID: 23210
		public const int ConfirmIdFieldNumber = 15;

		// Token: 0x04005AAB RID: 23211
		private int confirmId_;
	}
}
