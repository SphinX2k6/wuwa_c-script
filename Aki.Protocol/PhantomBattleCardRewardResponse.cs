using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5A RID: 3162
	[NetMessage(EMessageId.PhantomBattleCardRewardResponse)]
	public sealed class PhantomBattleCardRewardResponse : IMessage<PhantomBattleCardRewardResponse>, IMessage, IEquatable<PhantomBattleCardRewardResponse>, IDeepCloneable<PhantomBattleCardRewardResponse>, IBufferMessage
	{
		// Token: 0x0601124A RID: 70218 RVA: 0x00282860 File Offset: 0x00280A60
		[NullableContext(1)]
		public static PhantomBattleCardRewardResponse Create()
		{
			return new PhantomBattleCardRewardResponse();
		}

		// Token: 0x170038AB RID: 14507
		// (get) Token: 0x0601124B RID: 70219 RVA: 0x00282867 File Offset: 0x00280A67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038AC RID: 14508
		// (get) Token: 0x0601124C RID: 70220 RVA: 0x0028286A File Offset: 0x00280A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601124D RID: 70221 RVA: 0x00282871 File Offset: 0x00280A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardResponse()
		{
		}

		// Token: 0x0601124E RID: 70222 RVA: 0x00282879 File Offset: 0x00280A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardResponse(PhantomBattleCardRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601124F RID: 70223 RVA: 0x0028289E File Offset: 0x00280A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardResponse Clone()
		{
			return new PhantomBattleCardRewardResponse(this);
		}

		// Token: 0x170038AD RID: 14509
		// (get) Token: 0x06011250 RID: 70224 RVA: 0x002828A6 File Offset: 0x00280AA6
		// (set) Token: 0x06011251 RID: 70225 RVA: 0x002828AE File Offset: 0x00280AAE
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

		// Token: 0x06011252 RID: 70226 RVA: 0x002828B7 File Offset: 0x00280AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardResponse);
		}

		// Token: 0x06011253 RID: 70227 RVA: 0x002828C5 File Offset: 0x00280AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011254 RID: 70228 RVA: 0x002828F4 File Offset: 0x00280AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011255 RID: 70229 RVA: 0x00282939 File Offset: 0x00280B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011256 RID: 70230 RVA: 0x00282946 File Offset: 0x00280B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011257 RID: 70231 RVA: 0x0028294F File Offset: 0x00280B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011258 RID: 70232 RVA: 0x00282984 File Offset: 0x00280B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011259 RID: 70233 RVA: 0x002829C2 File Offset: 0x00280BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601125A RID: 70234 RVA: 0x002829F3 File Offset: 0x00280BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601125B RID: 70235 RVA: 0x002829FC File Offset: 0x00280BFC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C83 RID: 27779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C84 RID: 27780
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04006C85 RID: 27781
		private ErrorCode errorCode_;
	}
}
