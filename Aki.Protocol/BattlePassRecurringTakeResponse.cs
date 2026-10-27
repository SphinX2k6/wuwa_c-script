using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016F RID: 367
	[NetMessage(EMessageId.BattlePassRecurringTakeResponse)]
	public sealed class BattlePassRecurringTakeResponse : IMessage<BattlePassRecurringTakeResponse>, IMessage, IEquatable<BattlePassRecurringTakeResponse>, IDeepCloneable<BattlePassRecurringTakeResponse>, IBufferMessage
	{
		// Token: 0x06002D3E RID: 11582 RVA: 0x00075358 File Offset: 0x00073558
		[NullableContext(1)]
		public static BattlePassRecurringTakeResponse Create()
		{
			return new BattlePassRecurringTakeResponse();
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x0007535F File Offset: 0x0007355F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x00075362 File Offset: 0x00073562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassRecurringTakeResponse.Descriptor;
			}
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x00075369 File Offset: 0x00073569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeResponse()
		{
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x00075371 File Offset: 0x00073571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeResponse(BattlePassRecurringTakeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00075396 File Offset: 0x00073596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassRecurringTakeResponse Clone()
		{
			return new BattlePassRecurringTakeResponse(this);
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06002D44 RID: 11588 RVA: 0x0007539E File Offset: 0x0007359E
		// (set) Token: 0x06002D45 RID: 11589 RVA: 0x000753A6 File Offset: 0x000735A6
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

		// Token: 0x06002D46 RID: 11590 RVA: 0x000753AF File Offset: 0x000735AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassRecurringTakeResponse);
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000753BD File Offset: 0x000735BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassRecurringTakeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000753EC File Offset: 0x000735EC
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

		// Token: 0x06002D49 RID: 11593 RVA: 0x00075431 File Offset: 0x00073631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x0007543E File Offset: 0x0007363E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00075447 File Offset: 0x00073647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x0007547C File Offset: 0x0007367C
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

		// Token: 0x06002D4D RID: 11597 RVA: 0x000754BA File Offset: 0x000736BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassRecurringTakeResponse other)
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

		// Token: 0x06002D4E RID: 11598 RVA: 0x000754EB File Offset: 0x000736EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D4F RID: 11599 RVA: 0x000754F4 File Offset: 0x000736F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400282B RID: 10283
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400282C RID: 10284
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400282D RID: 10285
		private ErrorCode errorCode_;
	}
}
