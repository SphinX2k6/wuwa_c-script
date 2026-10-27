using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000499 RID: 1177
	[NetMessage(EMessageId.EntityInteractResponse)]
	public sealed class EntityInteractResponse : IMessage<EntityInteractResponse>, IMessage, IEquatable<EntityInteractResponse>, IDeepCloneable<EntityInteractResponse>, IBufferMessage
	{
		// Token: 0x06007068 RID: 28776 RVA: 0x00113E53 File Offset: 0x00112053
		[NullableContext(1)]
		public static EntityInteractResponse Create()
		{
			return new EntityInteractResponse();
		}

		// Token: 0x170015A8 RID: 5544
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x00113E5A File Offset: 0x0011205A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015A9 RID: 5545
		// (get) Token: 0x0600706A RID: 28778 RVA: 0x00113E5D File Offset: 0x0011205D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityInteractResponse.Descriptor;
			}
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x00113E64 File Offset: 0x00112064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractResponse()
		{
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x00113E6C File Offset: 0x0011206C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractResponse(EntityInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.interacting_ = other.interacting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600706D RID: 28781 RVA: 0x00113E9D File Offset: 0x0011209D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractResponse Clone()
		{
			return new EntityInteractResponse(this);
		}

		// Token: 0x170015AA RID: 5546
		// (get) Token: 0x0600706E RID: 28782 RVA: 0x00113EA5 File Offset: 0x001120A5
		// (set) Token: 0x0600706F RID: 28783 RVA: 0x00113EAD File Offset: 0x001120AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170015AB RID: 5547
		// (get) Token: 0x06007070 RID: 28784 RVA: 0x00113EB6 File Offset: 0x001120B6
		// (set) Token: 0x06007071 RID: 28785 RVA: 0x00113EBE File Offset: 0x001120BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Interacting
		{
			get
			{
				return this.interacting_;
			}
			set
			{
				this.interacting_ = value;
			}
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x00113EC7 File Offset: 0x001120C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityInteractResponse);
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x00113ED5 File Offset: 0x001120D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Interacting == other.Interacting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x00113F14 File Offset: 0x00112114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Interacting)
			{
				num ^= this.Interacting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x00113F72 File Offset: 0x00112172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x00113F7F File Offset: 0x0011217F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x00113F88 File Offset: 0x00112188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Interacting)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.Interacting);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x00113FE4 File Offset: 0x001121E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Interacting)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x00114030 File Offset: 0x00112230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityInteractResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Interacting)
			{
				this.Interacting = other.Interacting;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x00114080 File Offset: 0x00112280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x0011408C File Offset: 0x0011228C
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
				if (num != 40U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Interacting = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003C37 RID: 15415
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C38 RID: 15416
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04003C39 RID: 15417
		private ErrorCode errorCode_;

		// Token: 0x04003C3A RID: 15418
		public const int InteractingFieldNumber = 9;

		// Token: 0x04003C3B RID: 15419
		private bool interacting_;
	}
}
