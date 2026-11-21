using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FC2 RID: 4034
	[NetMessage(EMessageId.RogueResChangeFormationResponse)]
	public sealed class RogueResChangeFormationResponse : IMessage<RogueResChangeFormationResponse>, IMessage, IEquatable<RogueResChangeFormationResponse>, IDeepCloneable<RogueResChangeFormationResponse>, IBufferMessage
	{
		// Token: 0x06015979 RID: 88441 RVA: 0x00322E5B File Offset: 0x0032105B
		[NullableContext(1)]
		public static RogueResChangeFormationResponse Create()
		{
			return new RogueResChangeFormationResponse();
		}

		// Token: 0x17004807 RID: 18439
		// (get) Token: 0x0601597A RID: 88442 RVA: 0x00322E62 File Offset: 0x00321062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004808 RID: 18440
		// (get) Token: 0x0601597B RID: 88443 RVA: 0x00322E65 File Offset: 0x00321065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResChangeFormationResponse.Descriptor;
			}
		}

		// Token: 0x0601597C RID: 88444 RVA: 0x00322E6C File Offset: 0x0032106C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationResponse()
		{
		}

		// Token: 0x0601597D RID: 88445 RVA: 0x00322E74 File Offset: 0x00321074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationResponse(RogueResChangeFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.rogueResFormation_ = ((other.rogueResFormation_ != null) ? other.rogueResFormation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601597E RID: 88446 RVA: 0x00322EC0 File Offset: 0x003210C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResChangeFormationResponse Clone()
		{
			return new RogueResChangeFormationResponse(this);
		}

		// Token: 0x17004809 RID: 18441
		// (get) Token: 0x0601597F RID: 88447 RVA: 0x00322EC8 File Offset: 0x003210C8
		// (set) Token: 0x06015980 RID: 88448 RVA: 0x00322ED0 File Offset: 0x003210D0
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

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x06015981 RID: 88449 RVA: 0x00322ED9 File Offset: 0x003210D9
		// (set) Token: 0x06015982 RID: 88450 RVA: 0x00322EE1 File Offset: 0x003210E1
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

		// Token: 0x06015983 RID: 88451 RVA: 0x00322EEA File Offset: 0x003210EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResChangeFormationResponse);
		}

		// Token: 0x06015984 RID: 88452 RVA: 0x00322EF8 File Offset: 0x003210F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResChangeFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.RogueResFormation, other.RogueResFormation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015985 RID: 88453 RVA: 0x00322F48 File Offset: 0x00321148
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

		// Token: 0x06015986 RID: 88454 RVA: 0x00322FA3 File Offset: 0x003211A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015987 RID: 88455 RVA: 0x00322FB0 File Offset: 0x003211B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015988 RID: 88456 RVA: 0x00322FBC File Offset: 0x003211BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueResFormation_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RogueResFormation);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015989 RID: 88457 RVA: 0x00323018 File Offset: 0x00321218
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

		// Token: 0x0601598A RID: 88458 RVA: 0x00323070 File Offset: 0x00321270
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

		// Token: 0x0601598B RID: 88459 RVA: 0x003230D8 File Offset: 0x003212D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601598C RID: 88460 RVA: 0x003230E4 File Offset: 0x003212E4
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
				if (num != 74U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
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
		}

		// Token: 0x04008221 RID: 33313
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008222 RID: 33314
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008223 RID: 33315
		private ErrorCode errorCode_;

		// Token: 0x04008224 RID: 33316
		public const int RogueResFormationFieldNumber = 9;

		// Token: 0x04008225 RID: 33317
		private RogueResFormation rogueResFormation_;
	}
}
