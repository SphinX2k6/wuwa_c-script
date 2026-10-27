using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C4E RID: 3150
	[NetMessage(EMessageId.PhantomBattleCardGroupNameResponse)]
	public sealed class PhantomBattleCardGroupNameResponse : IMessage<PhantomBattleCardGroupNameResponse>, IMessage, IEquatable<PhantomBattleCardGroupNameResponse>, IDeepCloneable<PhantomBattleCardGroupNameResponse>, IBufferMessage
	{
		// Token: 0x06011156 RID: 69974 RVA: 0x002808E7 File Offset: 0x0027EAE7
		[NullableContext(1)]
		public static PhantomBattleCardGroupNameResponse Create()
		{
			return new PhantomBattleCardGroupNameResponse();
		}

		// Token: 0x17003879 RID: 14457
		// (get) Token: 0x06011157 RID: 69975 RVA: 0x002808EE File Offset: 0x0027EAEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x06011158 RID: 69976 RVA: 0x002808F1 File Offset: 0x0027EAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupNameResponse.Descriptor;
			}
		}

		// Token: 0x06011159 RID: 69977 RVA: 0x002808F8 File Offset: 0x0027EAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameResponse()
		{
		}

		// Token: 0x0601115A RID: 69978 RVA: 0x00280900 File Offset: 0x0027EB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameResponse(PhantomBattleCardGroupNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = ((other.phantomBattleCardGroupInfo_ != null) ? other.phantomBattleCardGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601115B RID: 69979 RVA: 0x0028094C File Offset: 0x0027EB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameResponse Clone()
		{
			return new PhantomBattleCardGroupNameResponse(this);
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0601115C RID: 69980 RVA: 0x00280954 File Offset: 0x0027EB54
		// (set) Token: 0x0601115D RID: 69981 RVA: 0x0028095C File Offset: 0x0027EB5C
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

		// Token: 0x1700387C RID: 14460
		// (get) Token: 0x0601115E RID: 69982 RVA: 0x00280965 File Offset: 0x0027EB65
		// (set) Token: 0x0601115F RID: 69983 RVA: 0x0028096D File Offset: 0x0027EB6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo PhantomBattleCardGroupInfo
		{
			get
			{
				return this.phantomBattleCardGroupInfo_;
			}
			set
			{
				this.phantomBattleCardGroupInfo_ = value;
			}
		}

		// Token: 0x06011160 RID: 69984 RVA: 0x00280976 File Offset: 0x0027EB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupNameResponse);
		}

		// Token: 0x06011161 RID: 69985 RVA: 0x00280984 File Offset: 0x0027EB84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleCardGroupInfo, other.PhantomBattleCardGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011162 RID: 69986 RVA: 0x002809D4 File Offset: 0x0027EBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num ^= this.PhantomBattleCardGroupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011163 RID: 69987 RVA: 0x00280A2F File Offset: 0x0027EC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011164 RID: 69988 RVA: 0x00280A3C File Offset: 0x0027EC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011165 RID: 69989 RVA: 0x00280A48 File Offset: 0x0027EC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011166 RID: 69990 RVA: 0x00280AA4 File Offset: 0x0027ECA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011167 RID: 69991 RVA: 0x00280AFC File Offset: 0x0027ECFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupNameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleCardGroupInfo_ != null)
			{
				if (this.phantomBattleCardGroupInfo_ == null)
				{
					this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
				}
				this.PhantomBattleCardGroupInfo.MergeFrom(other.PhantomBattleCardGroupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011168 RID: 69992 RVA: 0x00280B64 File Offset: 0x0027ED64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011169 RID: 69993 RVA: 0x00280B70 File Offset: 0x0027ED70
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
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantomBattleCardGroupInfo_ == null)
						{
							this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
						}
						input.ReadMessage(this.PhantomBattleCardGroupInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C41 RID: 27713
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C42 RID: 27714
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04006C43 RID: 27715
		private ErrorCode errorCode_;

		// Token: 0x04006C44 RID: 27716
		public const int PhantomBattleCardGroupInfoFieldNumber = 14;

		// Token: 0x04006C45 RID: 27717
		private PhantomBattleCardGroupInfo phantomBattleCardGroupInfo_;
	}
}
