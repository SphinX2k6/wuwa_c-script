using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAC RID: 3244
	[NetMessage(EMessageId.PhantomBattleSlotInsteadResponse)]
	public sealed class PhantomBattleSlotInsteadResponse : IMessage<PhantomBattleSlotInsteadResponse>, IMessage, IEquatable<PhantomBattleSlotInsteadResponse>, IDeepCloneable<PhantomBattleSlotInsteadResponse>, IBufferMessage
	{
		// Token: 0x06011989 RID: 72073 RVA: 0x0029436B File Offset: 0x0029256B
		[NullableContext(1)]
		public static PhantomBattleSlotInsteadResponse Create()
		{
			return new PhantomBattleSlotInsteadResponse();
		}

		// Token: 0x17003A4E RID: 14926
		// (get) Token: 0x0601198A RID: 72074 RVA: 0x00294372 File Offset: 0x00292572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A4F RID: 14927
		// (get) Token: 0x0601198B RID: 72075 RVA: 0x00294375 File Offset: 0x00292575
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSlotInsteadResponse.Descriptor;
			}
		}

		// Token: 0x0601198C RID: 72076 RVA: 0x0029437C File Offset: 0x0029257C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadResponse()
		{
		}

		// Token: 0x0601198D RID: 72077 RVA: 0x00294384 File Offset: 0x00292584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadResponse(PhantomBattleSlotInsteadResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.startSlotIndex_ = other.startSlotIndex_;
			this.targetSlotIndex_ = other.targetSlotIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601198E RID: 72078 RVA: 0x002943C1 File Offset: 0x002925C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSlotInsteadResponse Clone()
		{
			return new PhantomBattleSlotInsteadResponse(this);
		}

		// Token: 0x17003A50 RID: 14928
		// (get) Token: 0x0601198F RID: 72079 RVA: 0x002943C9 File Offset: 0x002925C9
		// (set) Token: 0x06011990 RID: 72080 RVA: 0x002943D1 File Offset: 0x002925D1
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

		// Token: 0x17003A51 RID: 14929
		// (get) Token: 0x06011991 RID: 72081 RVA: 0x002943DA File Offset: 0x002925DA
		// (set) Token: 0x06011992 RID: 72082 RVA: 0x002943E2 File Offset: 0x002925E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StartSlotIndex
		{
			get
			{
				return this.startSlotIndex_;
			}
			set
			{
				this.startSlotIndex_ = value;
			}
		}

		// Token: 0x17003A52 RID: 14930
		// (get) Token: 0x06011993 RID: 72083 RVA: 0x002943EB File Offset: 0x002925EB
		// (set) Token: 0x06011994 RID: 72084 RVA: 0x002943F3 File Offset: 0x002925F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetSlotIndex
		{
			get
			{
				return this.targetSlotIndex_;
			}
			set
			{
				this.targetSlotIndex_ = value;
			}
		}

		// Token: 0x06011995 RID: 72085 RVA: 0x002943FC File Offset: 0x002925FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSlotInsteadResponse);
		}

		// Token: 0x06011996 RID: 72086 RVA: 0x0029440C File Offset: 0x0029260C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSlotInsteadResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.StartSlotIndex == other.StartSlotIndex && this.TargetSlotIndex == other.TargetSlotIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011997 RID: 72087 RVA: 0x00294468 File Offset: 0x00292668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.StartSlotIndex != 0)
			{
				num ^= this.StartSlotIndex.GetHashCode();
			}
			if (this.TargetSlotIndex != 0)
			{
				num ^= this.TargetSlotIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011998 RID: 72088 RVA: 0x002944DF File Offset: 0x002926DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011999 RID: 72089 RVA: 0x002944EC File Offset: 0x002926EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601199A RID: 72090 RVA: 0x002944F8 File Offset: 0x002926F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetSlotIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetSlotIndex);
			}
			if (this.StartSlotIndex != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.StartSlotIndex);
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

		// Token: 0x0601199B RID: 72091 RVA: 0x00294570 File Offset: 0x00292770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.StartSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StartSlotIndex);
			}
			if (this.TargetSlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetSlotIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601199C RID: 72092 RVA: 0x002945E0 File Offset: 0x002927E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSlotInsteadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.StartSlotIndex != 0)
			{
				this.StartSlotIndex = other.StartSlotIndex;
			}
			if (other.TargetSlotIndex != 0)
			{
				this.TargetSlotIndex = other.TargetSlotIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601199D RID: 72093 RVA: 0x00294644 File Offset: 0x00292844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601199E RID: 72094 RVA: 0x00294650 File Offset: 0x00292850
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
				if (num != 24U)
				{
					if (num != 80U)
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
						this.StartSlotIndex = input.ReadInt32();
					}
				}
				else
				{
					this.TargetSlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006F42 RID: 28482
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F43 RID: 28483
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006F44 RID: 28484
		private ErrorCode errorCode_;

		// Token: 0x04006F45 RID: 28485
		public const int StartSlotIndexFieldNumber = 10;

		// Token: 0x04006F46 RID: 28486
		private int startSlotIndex_;

		// Token: 0x04006F47 RID: 28487
		public const int TargetSlotIndexFieldNumber = 3;

		// Token: 0x04006F48 RID: 28488
		private int targetSlotIndex_;
	}
}
