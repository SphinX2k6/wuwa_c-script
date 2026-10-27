using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A2 RID: 5282
	[NetMessage(EMessageId.UpdatePlayerPassiveSkillResponse)]
	public sealed class UpdatePlayerPassiveSkillResponse : IMessage<UpdatePlayerPassiveSkillResponse>, IMessage, IEquatable<UpdatePlayerPassiveSkillResponse>, IDeepCloneable<UpdatePlayerPassiveSkillResponse>, IBufferMessage
	{
		// Token: 0x0601BEFF RID: 114431 RVA: 0x00409CD6 File Offset: 0x00407ED6
		[NullableContext(1)]
		public static UpdatePlayerPassiveSkillResponse Create()
		{
			return new UpdatePlayerPassiveSkillResponse();
		}

		// Token: 0x17005E27 RID: 24103
		// (get) Token: 0x0601BF00 RID: 114432 RVA: 0x00409CDD File Offset: 0x00407EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E28 RID: 24104
		// (get) Token: 0x0601BF01 RID: 114433 RVA: 0x00409CE0 File Offset: 0x00407EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayerPassiveSkillResponse.Descriptor;
			}
		}

		// Token: 0x0601BF02 RID: 114434 RVA: 0x00409CE7 File Offset: 0x00407EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillResponse()
		{
		}

		// Token: 0x0601BF03 RID: 114435 RVA: 0x00409CEF File Offset: 0x00407EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillResponse(UpdatePlayerPassiveSkillResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF04 RID: 114436 RVA: 0x00409D14 File Offset: 0x00407F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayerPassiveSkillResponse Clone()
		{
			return new UpdatePlayerPassiveSkillResponse(this);
		}

		// Token: 0x17005E29 RID: 24105
		// (get) Token: 0x0601BF05 RID: 114437 RVA: 0x00409D1C File Offset: 0x00407F1C
		// (set) Token: 0x0601BF06 RID: 114438 RVA: 0x00409D24 File Offset: 0x00407F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601BF07 RID: 114439 RVA: 0x00409D2D File Offset: 0x00407F2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayerPassiveSkillResponse);
		}

		// Token: 0x0601BF08 RID: 114440 RVA: 0x00409D3B File Offset: 0x00407F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayerPassiveSkillResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF09 RID: 114441 RVA: 0x00409D6C File Offset: 0x00407F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF0A RID: 114442 RVA: 0x00409DB1 File Offset: 0x00407FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF0B RID: 114443 RVA: 0x00409DBE File Offset: 0x00407FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF0C RID: 114444 RVA: 0x00409DC7 File Offset: 0x00407FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF0D RID: 114445 RVA: 0x00409DFC File Offset: 0x00407FFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF0E RID: 114446 RVA: 0x00409E3A File Offset: 0x0040803A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayerPassiveSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF0F RID: 114447 RVA: 0x00409E6B File Offset: 0x0040806B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF10 RID: 114448 RVA: 0x00409E74 File Offset: 0x00408074
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A088 RID: 41096
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A089 RID: 41097
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x0400A08A RID: 41098
		private ErrorCode errCode_;
	}
}
