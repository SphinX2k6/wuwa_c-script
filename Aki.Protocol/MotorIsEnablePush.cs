using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A62 RID: 2658
	[NetMessage(EMessageId.MotorIsEnablePush)]
	public sealed class MotorIsEnablePush : IMessage<MotorIsEnablePush>, IMessage, IEquatable<MotorIsEnablePush>, IDeepCloneable<MotorIsEnablePush>, IBufferMessage
	{
		// Token: 0x0600E81F RID: 59423 RVA: 0x0021ED1F File Offset: 0x0021CF1F
		[NullableContext(1)]
		public static MotorIsEnablePush Create()
		{
			return new MotorIsEnablePush();
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x0600E820 RID: 59424 RVA: 0x0021ED26 File Offset: 0x0021CF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x0600E821 RID: 59425 RVA: 0x0021ED29 File Offset: 0x0021CF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorIsEnablePush.Descriptor;
			}
		}

		// Token: 0x0600E822 RID: 59426 RVA: 0x0021ED30 File Offset: 0x0021CF30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorIsEnablePush()
		{
		}

		// Token: 0x0600E823 RID: 59427 RVA: 0x0021ED38 File Offset: 0x0021CF38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorIsEnablePush(MotorIsEnablePush other) : this()
		{
			this.id_ = other.id_;
			this.isEnable_ = other.isEnable_;
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E824 RID: 59428 RVA: 0x0021ED90 File Offset: 0x0021CF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorIsEnablePush Clone()
		{
			return new MotorIsEnablePush(this);
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x0600E825 RID: 59429 RVA: 0x0021ED98 File Offset: 0x0021CF98
		// (set) Token: 0x0600E826 RID: 59430 RVA: 0x0021EDA0 File Offset: 0x0021CFA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x0600E827 RID: 59431 RVA: 0x0021EDA9 File Offset: 0x0021CFA9
		// (set) Token: 0x0600E828 RID: 59432 RVA: 0x0021EDB1 File Offset: 0x0021CFB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnable
		{
			get
			{
				return this.isEnable_;
			}
			set
			{
				this.isEnable_ = value;
			}
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x0600E829 RID: 59433 RVA: 0x0021EDBA File Offset: 0x0021CFBA
		// (set) Token: 0x0600E82A RID: 59434 RVA: 0x0021EDC2 File Offset: 0x0021CFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon CombatCommon
		{
			get
			{
				return this.combatCommon_;
			}
			set
			{
				this.combatCommon_ = value;
			}
		}

		// Token: 0x0600E82B RID: 59435 RVA: 0x0021EDCB File Offset: 0x0021CFCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorIsEnablePush);
		}

		// Token: 0x0600E82C RID: 59436 RVA: 0x0021EDDC File Offset: 0x0021CFDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorIsEnablePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsEnable == other.IsEnable && object.Equals(this.CombatCommon, other.CombatCommon) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E82D RID: 59437 RVA: 0x0021EE3C File Offset: 0x0021D03C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsEnable)
			{
				num ^= this.IsEnable.GetHashCode();
			}
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E82E RID: 59438 RVA: 0x0021EEAA File Offset: 0x0021D0AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E82F RID: 59439 RVA: 0x0021EEB7 File Offset: 0x0021D0B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E830 RID: 59440 RVA: 0x0021EEC0 File Offset: 0x0021D0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.Id);
			}
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.IsEnable)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsEnable);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E831 RID: 59441 RVA: 0x0021EF38 File Offset: 0x0021D138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.IsEnable)
			{
				num += 2;
			}
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E832 RID: 59442 RVA: 0x0021EF9C File Offset: 0x0021D19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorIsEnablePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.IsEnable)
			{
				this.IsEnable = other.IsEnable;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E833 RID: 59443 RVA: 0x0021F018 File Offset: 0x0021D218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E834 RID: 59444 RVA: 0x0021F024 File Offset: 0x0021D224
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
				if (num != 64U)
				{
					if (num != 74U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsEnable = input.ReadBool();
						}
					}
					else
					{
						if (this.combatCommon_ == null)
						{
							this.CombatCommon = new CombatCommon();
						}
						input.ReadMessage(this.CombatCommon);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04005EE7 RID: 24295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EE8 RID: 24296
		public const int IdFieldNumber = 8;

		// Token: 0x04005EE9 RID: 24297
		private long id_;

		// Token: 0x04005EEA RID: 24298
		public const int IsEnableFieldNumber = 14;

		// Token: 0x04005EEB RID: 24299
		private bool isEnable_;

		// Token: 0x04005EEC RID: 24300
		public const int CombatCommonFieldNumber = 9;

		// Token: 0x04005EED RID: 24301
		private CombatCommon combatCommon_;
	}
}
