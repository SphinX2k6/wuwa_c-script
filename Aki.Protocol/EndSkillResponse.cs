using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200042D RID: 1069
	[NetMessage(EMessageId.EndSkillResponse)]
	public sealed class EndSkillResponse : IMessage<EndSkillResponse>, IMessage, IEquatable<EndSkillResponse>, IDeepCloneable<EndSkillResponse>, IBufferMessage
	{
		// Token: 0x060066EF RID: 26351 RVA: 0x000F7EB3 File Offset: 0x000F60B3
		[NullableContext(1)]
		public static EndSkillResponse Create()
		{
			return new EndSkillResponse();
		}

		// Token: 0x17001359 RID: 4953
		// (get) Token: 0x060066F0 RID: 26352 RVA: 0x000F7EBA File Offset: 0x000F60BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x060066F1 RID: 26353 RVA: 0x000F7EBD File Offset: 0x000F60BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EndSkillResponse.Descriptor;
			}
		}

		// Token: 0x060066F2 RID: 26354 RVA: 0x000F7EC4 File Offset: 0x000F60C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillResponse()
		{
		}

		// Token: 0x060066F3 RID: 26355 RVA: 0x000F7ECC File Offset: 0x000F60CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillResponse(EndSkillResponse other) : this()
		{
			this.useSkillInfo_ = ((other.useSkillInfo_ != null) ? other.useSkillInfo_.Clone() : null);
			this.skillSingleId_ = other.skillSingleId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066F4 RID: 26356 RVA: 0x000F7F24 File Offset: 0x000F6124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EndSkillResponse Clone()
		{
			return new EndSkillResponse(this);
		}

		// Token: 0x1700135B RID: 4955
		// (get) Token: 0x060066F5 RID: 26357 RVA: 0x000F7F2C File Offset: 0x000F612C
		// (set) Token: 0x060066F6 RID: 26358 RVA: 0x000F7F34 File Offset: 0x000F6134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UseSkillInformation UseSkillInfo
		{
			get
			{
				return this.useSkillInfo_;
			}
			set
			{
				this.useSkillInfo_ = value;
			}
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x060066F7 RID: 26359 RVA: 0x000F7F3D File Offset: 0x000F613D
		// (set) Token: 0x060066F8 RID: 26360 RVA: 0x000F7F45 File Offset: 0x000F6145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillSingleId
		{
			get
			{
				return this.skillSingleId_;
			}
			set
			{
				this.skillSingleId_ = value;
			}
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x060066F9 RID: 26361 RVA: 0x000F7F4E File Offset: 0x000F614E
		// (set) Token: 0x060066FA RID: 26362 RVA: 0x000F7F56 File Offset: 0x000F6156
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

		// Token: 0x060066FB RID: 26363 RVA: 0x000F7F5F File Offset: 0x000F615F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EndSkillResponse);
		}

		// Token: 0x060066FC RID: 26364 RVA: 0x000F7F70 File Offset: 0x000F6170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EndSkillResponse other)
		{
			return other != null && (other == this || (object.Equals(this.UseSkillInfo, other.UseSkillInfo) && this.SkillSingleId == other.SkillSingleId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066FD RID: 26365 RVA: 0x000F7FD0 File Offset: 0x000F61D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.useSkillInfo_ != null)
			{
				num ^= this.UseSkillInfo.GetHashCode();
			}
			if (this.SkillSingleId != 0)
			{
				num ^= this.SkillSingleId.GetHashCode();
			}
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

		// Token: 0x060066FE RID: 26366 RVA: 0x000F8044 File Offset: 0x000F6244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060066FF RID: 26367 RVA: 0x000F8051 File Offset: 0x000F6251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006700 RID: 26368 RVA: 0x000F805C File Offset: 0x000F625C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillSingleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillSingleId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.useSkillInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.UseSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006701 RID: 26369 RVA: 0x000F80D0 File Offset: 0x000F62D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.useSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UseSkillInfo);
			}
			if (this.SkillSingleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillSingleId);
			}
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

		// Token: 0x06006702 RID: 26370 RVA: 0x000F8140 File Offset: 0x000F6340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EndSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.useSkillInfo_ != null)
			{
				if (this.useSkillInfo_ == null)
				{
					this.UseSkillInfo = new UseSkillInformation();
				}
				this.UseSkillInfo.MergeFrom(other.UseSkillInfo);
			}
			if (other.SkillSingleId != 0)
			{
				this.SkillSingleId = other.SkillSingleId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006703 RID: 26371 RVA: 0x000F81BC File Offset: 0x000F63BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006704 RID: 26372 RVA: 0x000F81C8 File Offset: 0x000F63C8
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
					if (num != 64U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.useSkillInfo_ == null)
							{
								this.UseSkillInfo = new UseSkillInformation();
							}
							input.ReadMessage(this.UseSkillInfo);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.SkillSingleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040039A6 RID: 14758
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039A7 RID: 14759
		public const int UseSkillInfoFieldNumber = 14;

		// Token: 0x040039A8 RID: 14760
		private UseSkillInformation useSkillInfo_;

		// Token: 0x040039A9 RID: 14761
		public const int SkillSingleIdFieldNumber = 1;

		// Token: 0x040039AA RID: 14762
		private int skillSingleId_;

		// Token: 0x040039AB RID: 14763
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040039AC RID: 14764
		private ErrorCode errorCode_;
	}
}
