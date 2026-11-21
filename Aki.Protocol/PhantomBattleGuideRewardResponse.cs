using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C81 RID: 3201
	[NetMessage(EMessageId.PhantomBattleGuideRewardResponse)]
	public sealed class PhantomBattleGuideRewardResponse : IMessage<PhantomBattleGuideRewardResponse>, IMessage, IEquatable<PhantomBattleGuideRewardResponse>, IDeepCloneable<PhantomBattleGuideRewardResponse>, IBufferMessage
	{
		// Token: 0x06011608 RID: 71176 RVA: 0x0028C75E File Offset: 0x0028A95E
		[NullableContext(1)]
		public static PhantomBattleGuideRewardResponse Create()
		{
			return new PhantomBattleGuideRewardResponse();
		}

		// Token: 0x1700398E RID: 14734
		// (get) Token: 0x06011609 RID: 71177 RVA: 0x0028C765 File Offset: 0x0028A965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700398F RID: 14735
		// (get) Token: 0x0601160A RID: 71178 RVA: 0x0028C768 File Offset: 0x0028A968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleGuideRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601160B RID: 71179 RVA: 0x0028C76F File Offset: 0x0028A96F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardResponse()
		{
		}

		// Token: 0x0601160C RID: 71180 RVA: 0x0028C777 File Offset: 0x0028A977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardResponse(PhantomBattleGuideRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601160D RID: 71181 RVA: 0x0028C79C File Offset: 0x0028A99C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleGuideRewardResponse Clone()
		{
			return new PhantomBattleGuideRewardResponse(this);
		}

		// Token: 0x17003990 RID: 14736
		// (get) Token: 0x0601160E RID: 71182 RVA: 0x0028C7A4 File Offset: 0x0028A9A4
		// (set) Token: 0x0601160F RID: 71183 RVA: 0x0028C7AC File Offset: 0x0028A9AC
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

		// Token: 0x06011610 RID: 71184 RVA: 0x0028C7B5 File Offset: 0x0028A9B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleGuideRewardResponse);
		}

		// Token: 0x06011611 RID: 71185 RVA: 0x0028C7C3 File Offset: 0x0028A9C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleGuideRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011612 RID: 71186 RVA: 0x0028C7F4 File Offset: 0x0028A9F4
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

		// Token: 0x06011613 RID: 71187 RVA: 0x0028C839 File Offset: 0x0028AA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011614 RID: 71188 RVA: 0x0028C846 File Offset: 0x0028AA46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011615 RID: 71189 RVA: 0x0028C84F File Offset: 0x0028AA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011616 RID: 71190 RVA: 0x0028C884 File Offset: 0x0028AA84
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

		// Token: 0x06011617 RID: 71191 RVA: 0x0028C8C2 File Offset: 0x0028AAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleGuideRewardResponse other)
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

		// Token: 0x06011618 RID: 71192 RVA: 0x0028C8F3 File Offset: 0x0028AAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011619 RID: 71193 RVA: 0x0028C8FC File Offset: 0x0028AAFC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006E31 RID: 28209
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E32 RID: 28210
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006E33 RID: 28211
		private ErrorCode errorCode_;
	}
}
