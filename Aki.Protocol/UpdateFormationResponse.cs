using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150D RID: 5389
	[NetMessage(EMessageId.UpdateFormationResponse)]
	public sealed class UpdateFormationResponse : IMessage<UpdateFormationResponse>, IMessage, IEquatable<UpdateFormationResponse>, IDeepCloneable<UpdateFormationResponse>, IBufferMessage
	{
		// Token: 0x0601C8E4 RID: 116964 RVA: 0x00423781 File Offset: 0x00421981
		[NullableContext(1)]
		public static UpdateFormationResponse Create()
		{
			return new UpdateFormationResponse();
		}

		// Token: 0x17006099 RID: 24729
		// (get) Token: 0x0601C8E5 RID: 116965 RVA: 0x00423788 File Offset: 0x00421988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700609A RID: 24730
		// (get) Token: 0x0601C8E6 RID: 116966 RVA: 0x0042378B File Offset: 0x0042198B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFormationResponse.Descriptor;
			}
		}

		// Token: 0x0601C8E7 RID: 116967 RVA: 0x00423792 File Offset: 0x00421992
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationResponse()
		{
		}

		// Token: 0x0601C8E8 RID: 116968 RVA: 0x0042379C File Offset: 0x0042199C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationResponse(UpdateFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.formation_ = ((other.formation_ != null) ? other.formation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C8E9 RID: 116969 RVA: 0x004237E8 File Offset: 0x004219E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationResponse Clone()
		{
			return new UpdateFormationResponse(this);
		}

		// Token: 0x1700609B RID: 24731
		// (get) Token: 0x0601C8EA RID: 116970 RVA: 0x004237F0 File Offset: 0x004219F0
		// (set) Token: 0x0601C8EB RID: 116971 RVA: 0x004237F8 File Offset: 0x004219F8
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

		// Token: 0x1700609C RID: 24732
		// (get) Token: 0x0601C8EC RID: 116972 RVA: 0x00423801 File Offset: 0x00421A01
		// (set) Token: 0x0601C8ED RID: 116973 RVA: 0x00423809 File Offset: 0x00421A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightFormation Formation
		{
			get
			{
				return this.formation_;
			}
			set
			{
				this.formation_ = value;
			}
		}

		// Token: 0x0601C8EE RID: 116974 RVA: 0x00423812 File Offset: 0x00421A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFormationResponse);
		}

		// Token: 0x0601C8EF RID: 116975 RVA: 0x00423820 File Offset: 0x00421A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Formation, other.Formation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C8F0 RID: 116976 RVA: 0x00423870 File Offset: 0x00421A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.formation_ != null)
			{
				num ^= this.Formation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C8F1 RID: 116977 RVA: 0x004238CB File Offset: 0x00421ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C8F2 RID: 116978 RVA: 0x004238D8 File Offset: 0x00421AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C8F3 RID: 116979 RVA: 0x004238E4 File Offset: 0x00421AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.formation_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Formation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C8F4 RID: 116980 RVA: 0x0042393C File Offset: 0x00421B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.formation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Formation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C8F5 RID: 116981 RVA: 0x00423994 File Offset: 0x00421B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFormationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.formation_ != null)
			{
				if (this.formation_ == null)
				{
					this.Formation = new FightFormation();
				}
				this.Formation.MergeFrom(other.Formation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C8F6 RID: 116982 RVA: 0x004239FC File Offset: 0x00421BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C8F7 RID: 116983 RVA: 0x00423A08 File Offset: 0x00421C08
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
				if (num != 8U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.formation_ == null)
						{
							this.Formation = new FightFormation();
						}
						input.ReadMessage(this.Formation);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A4A0 RID: 42144
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4A1 RID: 42145
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A4A2 RID: 42146
		private ErrorCode errorCode_;

		// Token: 0x0400A4A3 RID: 42147
		public const int FormationFieldNumber = 15;

		// Token: 0x0400A4A4 RID: 42148
		private FightFormation formation_;
	}
}
