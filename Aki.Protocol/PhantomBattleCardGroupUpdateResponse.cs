using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C50 RID: 3152
	[NetMessage(EMessageId.PhantomBattleCardGroupUpdateResponse)]
	public sealed class PhantomBattleCardGroupUpdateResponse : IMessage<PhantomBattleCardGroupUpdateResponse>, IMessage, IEquatable<PhantomBattleCardGroupUpdateResponse>, IDeepCloneable<PhantomBattleCardGroupUpdateResponse>, IBufferMessage
	{
		// Token: 0x06011180 RID: 70016 RVA: 0x00280F3A File Offset: 0x0027F13A
		[NullableContext(1)]
		public static PhantomBattleCardGroupUpdateResponse Create()
		{
			return new PhantomBattleCardGroupUpdateResponse();
		}

		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x06011181 RID: 70017 RVA: 0x00280F41 File Offset: 0x0027F141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x06011182 RID: 70018 RVA: 0x00280F44 File Offset: 0x0027F144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupUpdateResponse.Descriptor;
			}
		}

		// Token: 0x06011183 RID: 70019 RVA: 0x00280F4B File Offset: 0x0027F14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateResponse()
		{
		}

		// Token: 0x06011184 RID: 70020 RVA: 0x00280F54 File Offset: 0x0027F154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateResponse(PhantomBattleCardGroupUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = ((other.phantomBattleCardGroupInfo_ != null) ? other.phantomBattleCardGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011185 RID: 70021 RVA: 0x00280FA0 File Offset: 0x0027F1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupUpdateResponse Clone()
		{
			return new PhantomBattleCardGroupUpdateResponse(this);
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x06011186 RID: 70022 RVA: 0x00280FA8 File Offset: 0x0027F1A8
		// (set) Token: 0x06011187 RID: 70023 RVA: 0x00280FB0 File Offset: 0x0027F1B0
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

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x06011188 RID: 70024 RVA: 0x00280FB9 File Offset: 0x0027F1B9
		// (set) Token: 0x06011189 RID: 70025 RVA: 0x00280FC1 File Offset: 0x0027F1C1
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

		// Token: 0x0601118A RID: 70026 RVA: 0x00280FCA File Offset: 0x0027F1CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupUpdateResponse);
		}

		// Token: 0x0601118B RID: 70027 RVA: 0x00280FD8 File Offset: 0x0027F1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleCardGroupInfo, other.PhantomBattleCardGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601118C RID: 70028 RVA: 0x00281028 File Offset: 0x0027F228
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

		// Token: 0x0601118D RID: 70029 RVA: 0x00281083 File Offset: 0x0027F283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601118E RID: 70030 RVA: 0x00281090 File Offset: 0x0027F290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601118F RID: 70031 RVA: 0x0028109C File Offset: 0x0027F29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011190 RID: 70032 RVA: 0x002810F8 File Offset: 0x0027F2F8
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

		// Token: 0x06011191 RID: 70033 RVA: 0x00281150 File Offset: 0x0027F350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupUpdateResponse other)
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

		// Token: 0x06011192 RID: 70034 RVA: 0x002811B8 File Offset: 0x0027F3B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011193 RID: 70035 RVA: 0x002811C4 File Offset: 0x0027F3C4
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
				if (num != 104U)
				{
					if (num != 122U)
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

		// Token: 0x04006C4E RID: 27726
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C4F RID: 27727
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006C50 RID: 27728
		private ErrorCode errorCode_;

		// Token: 0x04006C51 RID: 27729
		public const int PhantomBattleCardGroupInfoFieldNumber = 15;

		// Token: 0x04006C52 RID: 27730
		private PhantomBattleCardGroupInfo phantomBattleCardGroupInfo_;
	}
}
