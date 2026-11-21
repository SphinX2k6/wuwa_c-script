using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001099 RID: 4249
	[NetMessage(EMessageId.RoleSexChangeResponse)]
	public sealed class RoleSexChangeResponse : IMessage<RoleSexChangeResponse>, IMessage, IEquatable<RoleSexChangeResponse>, IDeepCloneable<RoleSexChangeResponse>, IBufferMessage
	{
		// Token: 0x06016B82 RID: 93058 RVA: 0x0034DD2D File Offset: 0x0034BF2D
		[NullableContext(1)]
		public static RoleSexChangeResponse Create()
		{
			return new RoleSexChangeResponse();
		}

		// Token: 0x17004C26 RID: 19494
		// (get) Token: 0x06016B83 RID: 93059 RVA: 0x0034DD34 File Offset: 0x0034BF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C27 RID: 19495
		// (get) Token: 0x06016B84 RID: 93060 RVA: 0x0034DD37 File Offset: 0x0034BF37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleSexChangeResponse.Descriptor;
			}
		}

		// Token: 0x06016B85 RID: 93061 RVA: 0x0034DD3E File Offset: 0x0034BF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeResponse()
		{
		}

		// Token: 0x06016B86 RID: 93062 RVA: 0x0034DD46 File Offset: 0x0034BF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeResponse(RoleSexChangeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.sex_ = other.sex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016B87 RID: 93063 RVA: 0x0034DD77 File Offset: 0x0034BF77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleSexChangeResponse Clone()
		{
			return new RoleSexChangeResponse(this);
		}

		// Token: 0x17004C28 RID: 19496
		// (get) Token: 0x06016B88 RID: 93064 RVA: 0x0034DD7F File Offset: 0x0034BF7F
		// (set) Token: 0x06016B89 RID: 93065 RVA: 0x0034DD87 File Offset: 0x0034BF87
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

		// Token: 0x17004C29 RID: 19497
		// (get) Token: 0x06016B8A RID: 93066 RVA: 0x0034DD90 File Offset: 0x0034BF90
		// (set) Token: 0x06016B8B RID: 93067 RVA: 0x0034DD98 File Offset: 0x0034BF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Sex
		{
			get
			{
				return this.sex_;
			}
			set
			{
				this.sex_ = value;
			}
		}

		// Token: 0x06016B8C RID: 93068 RVA: 0x0034DDA1 File Offset: 0x0034BFA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleSexChangeResponse);
		}

		// Token: 0x06016B8D RID: 93069 RVA: 0x0034DDAF File Offset: 0x0034BFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleSexChangeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Sex == other.Sex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016B8E RID: 93070 RVA: 0x0034DDF0 File Offset: 0x0034BFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Sex != 0)
			{
				num ^= this.Sex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016B8F RID: 93071 RVA: 0x0034DE4E File Offset: 0x0034C04E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016B90 RID: 93072 RVA: 0x0034DE5B File Offset: 0x0034C05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016B91 RID: 93073 RVA: 0x0034DE64 File Offset: 0x0034C064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Sex != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Sex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016B92 RID: 93074 RVA: 0x0034DEC0 File Offset: 0x0034C0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Sex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Sex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016B93 RID: 93075 RVA: 0x0034DF18 File Offset: 0x0034C118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleSexChangeResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Sex != 0)
			{
				this.Sex = other.Sex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016B94 RID: 93076 RVA: 0x0034DF68 File Offset: 0x0034C168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016B95 RID: 93077 RVA: 0x0034DF74 File Offset: 0x0034C174
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
				if (num != 48U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Sex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008827 RID: 34855
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008828 RID: 34856
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04008829 RID: 34857
		private ErrorCode errorCode_;

		// Token: 0x0400882A RID: 34858
		public const int SexFieldNumber = 15;

		// Token: 0x0400882B RID: 34859
		private int sex_;
	}
}
