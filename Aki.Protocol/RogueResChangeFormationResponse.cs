using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FD2 RID: 4050
	[NetMessage(EMessageId.RogueResChangeFormationResponse)]
	public sealed class RogueResChangeFormationResponse : IMessage<RogueResChangeFormationResponse>, IMessage, IEquatable<RogueResChangeFormationResponse>, IDeepCloneable<RogueResChangeFormationResponse>, IBufferMessage
	{
		// Token: 0x06015A5E RID: 88670 RVA: 0x0032450F File Offset: 0x0032270F
		[NullableContext(1)]
		public static RogueResChangeFormationResponse Create()
		{
			return new RogueResChangeFormationResponse();
		}

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x06015A5F RID: 88671 RVA: 0x00324516 File Offset: 0x00322716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x06015A60 RID: 88672 RVA: 0x00324519 File Offset: 0x00322719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResChangeFormationResponse.Descriptor;
			}
		}

		// Token: 0x06015A61 RID: 88673 RVA: 0x00324520 File Offset: 0x00322720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationResponse()
		{
		}

		// Token: 0x06015A62 RID: 88674 RVA: 0x00324528 File Offset: 0x00322728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationResponse(RogueResChangeFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueResFormation_ = ((other.rogueResFormation_ != null) ? other.rogueResFormation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A63 RID: 88675 RVA: 0x00324574 File Offset: 0x00322774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationResponse Clone()
		{
			return new RogueResChangeFormationResponse(this);
		}

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x06015A64 RID: 88676 RVA: 0x0032457C File Offset: 0x0032277C
		// (set) Token: 0x06015A65 RID: 88677 RVA: 0x00324584 File Offset: 0x00322784
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

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x06015A66 RID: 88678 RVA: 0x0032458D File Offset: 0x0032278D
		// (set) Token: 0x06015A67 RID: 88679 RVA: 0x00324595 File Offset: 0x00322795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResFormation RogueResFormation
		{
			get
			{
				return this.rogueResFormation_;
			}
			set
			{
				this.rogueResFormation_ = value;
			}
		}

		// Token: 0x06015A68 RID: 88680 RVA: 0x0032459E File Offset: 0x0032279E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResChangeFormationResponse);
		}

		// Token: 0x06015A69 RID: 88681 RVA: 0x003245AC File Offset: 0x003227AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResChangeFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueResFormation, other.RogueResFormation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A6A RID: 88682 RVA: 0x003245FC File Offset: 0x003227FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.rogueResFormation_ != null)
			{
				num ^= this.RogueResFormation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A6B RID: 88683 RVA: 0x00324657 File Offset: 0x00322857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A6C RID: 88684 RVA: 0x00324664 File Offset: 0x00322864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A6D RID: 88685 RVA: 0x00324670 File Offset: 0x00322870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.rogueResFormation_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.RogueResFormation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A6E RID: 88686 RVA: 0x003246CC File Offset: 0x003228CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.rogueResFormation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResFormation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A6F RID: 88687 RVA: 0x00324724 File Offset: 0x00322924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResChangeFormationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.rogueResFormation_ != null)
			{
				if (this.rogueResFormation_ == null)
				{
					this.RogueResFormation = new RogueResFormation();
				}
				this.RogueResFormation.MergeFrom(other.RogueResFormation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A70 RID: 88688 RVA: 0x0032478C File Offset: 0x0032298C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A71 RID: 88689 RVA: 0x00324798 File Offset: 0x00322998
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
				if (num != 88U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueResFormation_ == null)
						{
							this.RogueResFormation = new RogueResFormation();
						}
						input.ReadMessage(this.RogueResFormation);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040081F7 RID: 33271
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081F8 RID: 33272
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040081F9 RID: 33273
		private ErrorCode errorCode_;

		// Token: 0x040081FA RID: 33274
		public const int RogueResFormationFieldNumber = 13;

		// Token: 0x040081FB RID: 33275
		private RogueResFormation rogueResFormation_;
	}
}
