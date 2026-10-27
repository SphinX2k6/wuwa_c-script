using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CC2 RID: 3266
	[NetMessage(EMessageId.PhantomBattleTaskRewardResponse)]
	public sealed class PhantomBattleTaskRewardResponse : IMessage<PhantomBattleTaskRewardResponse>, IMessage, IEquatable<PhantomBattleTaskRewardResponse>, IDeepCloneable<PhantomBattleTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06011AFB RID: 72443 RVA: 0x00296E85 File Offset: 0x00295085
		[NullableContext(1)]
		public static PhantomBattleTaskRewardResponse Create()
		{
			return new PhantomBattleTaskRewardResponse();
		}

		// Token: 0x17003A9A RID: 15002
		// (get) Token: 0x06011AFC RID: 72444 RVA: 0x00296E8C File Offset: 0x0029508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x06011AFD RID: 72445 RVA: 0x00296E8F File Offset: 0x0029508F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06011AFE RID: 72446 RVA: 0x00296E96 File Offset: 0x00295096
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardResponse()
		{
		}

		// Token: 0x06011AFF RID: 72447 RVA: 0x00296E9E File Offset: 0x0029509E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardResponse(PhantomBattleTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011B00 RID: 72448 RVA: 0x00296EC3 File Offset: 0x002950C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleTaskRewardResponse Clone()
		{
			return new PhantomBattleTaskRewardResponse(this);
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x06011B01 RID: 72449 RVA: 0x00296ECB File Offset: 0x002950CB
		// (set) Token: 0x06011B02 RID: 72450 RVA: 0x00296ED3 File Offset: 0x002950D3
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

		// Token: 0x06011B03 RID: 72451 RVA: 0x00296EDC File Offset: 0x002950DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleTaskRewardResponse);
		}

		// Token: 0x06011B04 RID: 72452 RVA: 0x00296EEA File Offset: 0x002950EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011B05 RID: 72453 RVA: 0x00296F18 File Offset: 0x00295118
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

		// Token: 0x06011B06 RID: 72454 RVA: 0x00296F5D File Offset: 0x0029515D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011B07 RID: 72455 RVA: 0x00296F6A File Offset: 0x0029516A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011B08 RID: 72456 RVA: 0x00296F73 File Offset: 0x00295173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011B09 RID: 72457 RVA: 0x00296FA8 File Offset: 0x002951A8
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

		// Token: 0x06011B0A RID: 72458 RVA: 0x00296FE6 File Offset: 0x002951E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleTaskRewardResponse other)
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

		// Token: 0x06011B0B RID: 72459 RVA: 0x00297017 File Offset: 0x00295217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011B0C RID: 72460 RVA: 0x00297020 File Offset: 0x00295220
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F47 RID: 28487
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F48 RID: 28488
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04006F49 RID: 28489
		private ErrorCode errorCode_;
	}
}
