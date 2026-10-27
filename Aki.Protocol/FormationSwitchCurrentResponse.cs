using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000633 RID: 1587
	[NetMessage(EMessageId.FormationSwitchCurrentResponse)]
	public sealed class FormationSwitchCurrentResponse : IMessage<FormationSwitchCurrentResponse>, IMessage, IEquatable<FormationSwitchCurrentResponse>, IDeepCloneable<FormationSwitchCurrentResponse>, IBufferMessage
	{
		// Token: 0x0600924A RID: 37450 RVA: 0x00161F45 File Offset: 0x00160145
		[NullableContext(1)]
		public static FormationSwitchCurrentResponse Create()
		{
			return new FormationSwitchCurrentResponse();
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x0600924B RID: 37451 RVA: 0x00161F4C File Offset: 0x0016014C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x0600924C RID: 37452 RVA: 0x00161F4F File Offset: 0x0016014F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationSwitchCurrentResponse.Descriptor;
			}
		}

		// Token: 0x0600924D RID: 37453 RVA: 0x00161F56 File Offset: 0x00160156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentResponse()
		{
		}

		// Token: 0x0600924E RID: 37454 RVA: 0x00161F5E File Offset: 0x0016015E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentResponse(FormationSwitchCurrentResponse other) : this()
		{
			this.currentId_ = other.currentId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600924F RID: 37455 RVA: 0x00161F8F File Offset: 0x0016018F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationSwitchCurrentResponse Clone()
		{
			return new FormationSwitchCurrentResponse(this);
		}

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06009250 RID: 37456 RVA: 0x00161F97 File Offset: 0x00160197
		// (set) Token: 0x06009251 RID: 37457 RVA: 0x00161F9F File Offset: 0x0016019F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrentId
		{
			get
			{
				return this.currentId_;
			}
			set
			{
				this.currentId_ = value;
			}
		}

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06009252 RID: 37458 RVA: 0x00161FA8 File Offset: 0x001601A8
		// (set) Token: 0x06009253 RID: 37459 RVA: 0x00161FB0 File Offset: 0x001601B0
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

		// Token: 0x06009254 RID: 37460 RVA: 0x00161FB9 File Offset: 0x001601B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationSwitchCurrentResponse);
		}

		// Token: 0x06009255 RID: 37461 RVA: 0x00161FC7 File Offset: 0x001601C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationSwitchCurrentResponse other)
		{
			return other != null && (other == this || (this.CurrentId == other.CurrentId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009256 RID: 37462 RVA: 0x00162008 File Offset: 0x00160208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurrentId != 0)
			{
				num ^= this.CurrentId.GetHashCode();
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

		// Token: 0x06009257 RID: 37463 RVA: 0x00162066 File Offset: 0x00160266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009258 RID: 37464 RVA: 0x00162073 File Offset: 0x00160273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009259 RID: 37465 RVA: 0x0016207C File Offset: 0x0016027C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurrentId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600925A RID: 37466 RVA: 0x001620D4 File Offset: 0x001602D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurrentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrentId);
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

		// Token: 0x0600925B RID: 37467 RVA: 0x0016212C File Offset: 0x0016032C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationSwitchCurrentResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurrentId != 0)
			{
				this.CurrentId = other.CurrentId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600925C RID: 37468 RVA: 0x0016217C File Offset: 0x0016037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600925D RID: 37469 RVA: 0x00162188 File Offset: 0x00160388
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
					if (num != 56U)
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
					this.CurrentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400468D RID: 18061
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400468E RID: 18062
		public const int CurrentIdFieldNumber = 1;

		// Token: 0x0400468F RID: 18063
		private int currentId_;

		// Token: 0x04004690 RID: 18064
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004691 RID: 18065
		private ErrorCode errorCode_;
	}
}
