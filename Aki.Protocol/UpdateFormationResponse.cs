using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001499 RID: 5273
	[NetMessage(EMessageId.UpdateFormationResponse)]
	public sealed class UpdateFormationResponse : IMessage<UpdateFormationResponse>, IMessage, IEquatable<UpdateFormationResponse>, IDeepCloneable<UpdateFormationResponse>, IBufferMessage
	{
		// Token: 0x0601BE47 RID: 114247 RVA: 0x004082DD File Offset: 0x004064DD
		[NullableContext(1)]
		public static UpdateFormationResponse Create()
		{
			return new UpdateFormationResponse();
		}

		// Token: 0x17005E01 RID: 24065
		// (get) Token: 0x0601BE48 RID: 114248 RVA: 0x004082E4 File Offset: 0x004064E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E02 RID: 24066
		// (get) Token: 0x0601BE49 RID: 114249 RVA: 0x004082E7 File Offset: 0x004064E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFormationResponse.Descriptor;
			}
		}

		// Token: 0x0601BE4A RID: 114250 RVA: 0x004082EE File Offset: 0x004064EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationResponse()
		{
		}

		// Token: 0x0601BE4B RID: 114251 RVA: 0x004082F8 File Offset: 0x004064F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationResponse(UpdateFormationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.formation_ = ((other.formation_ != null) ? other.formation_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE4C RID: 114252 RVA: 0x00408344 File Offset: 0x00406544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFormationResponse Clone()
		{
			return new UpdateFormationResponse(this);
		}

		// Token: 0x17005E03 RID: 24067
		// (get) Token: 0x0601BE4D RID: 114253 RVA: 0x0040834C File Offset: 0x0040654C
		// (set) Token: 0x0601BE4E RID: 114254 RVA: 0x00408354 File Offset: 0x00406554
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

		// Token: 0x17005E04 RID: 24068
		// (get) Token: 0x0601BE4F RID: 114255 RVA: 0x0040835D File Offset: 0x0040655D
		// (set) Token: 0x0601BE50 RID: 114256 RVA: 0x00408365 File Offset: 0x00406565
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

		// Token: 0x0601BE51 RID: 114257 RVA: 0x0040836E File Offset: 0x0040656E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFormationResponse);
		}

		// Token: 0x0601BE52 RID: 114258 RVA: 0x0040837C File Offset: 0x0040657C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFormationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.Formation, other.Formation) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE53 RID: 114259 RVA: 0x004083CC File Offset: 0x004065CC
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

		// Token: 0x0601BE54 RID: 114260 RVA: 0x00408427 File Offset: 0x00406627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE55 RID: 114261 RVA: 0x00408434 File Offset: 0x00406634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE56 RID: 114262 RVA: 0x00408440 File Offset: 0x00406640
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
				output.WriteRawTag(66);
				output.WriteMessage(this.Formation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE57 RID: 114263 RVA: 0x00408498 File Offset: 0x00406698
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

		// Token: 0x0601BE58 RID: 114264 RVA: 0x004084F0 File Offset: 0x004066F0
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

		// Token: 0x0601BE59 RID: 114265 RVA: 0x00408558 File Offset: 0x00406758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE5A RID: 114266 RVA: 0x00408564 File Offset: 0x00406764
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
					if (num != 66U)
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

		// Token: 0x0400A055 RID: 41045
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A056 RID: 41046
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x0400A057 RID: 41047
		private ErrorCode errorCode_;

		// Token: 0x0400A058 RID: 41048
		public const int FormationFieldNumber = 8;

		// Token: 0x0400A059 RID: 41049
		private FightFormation formation_;
	}
}
