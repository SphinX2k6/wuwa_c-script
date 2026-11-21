using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073C RID: 1852
	[NetMessage(EMessageId.HitEndPush)]
	public sealed class HitEndPush : IMessage<HitEndPush>, IMessage, IEquatable<HitEndPush>, IDeepCloneable<HitEndPush>, IBufferMessage
	{
		// Token: 0x0600A818 RID: 43032 RVA: 0x0019498E File Offset: 0x00192B8E
		[NullableContext(1)]
		public static HitEndPush Create()
		{
			return new HitEndPush();
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x0600A819 RID: 43033 RVA: 0x00194995 File Offset: 0x00192B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x0600A81A RID: 43034 RVA: 0x00194998 File Offset: 0x00192B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HitEndPush.Descriptor;
			}
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x0019499F File Offset: 0x00192B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndPush()
		{
		}

		// Token: 0x0600A81C RID: 43036 RVA: 0x001949A8 File Offset: 0x00192BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndPush(HitEndPush other) : this()
		{
			this.combatCommon_ = ((other.combatCommon_ != null) ? other.combatCommon_.Clone() : null);
			this.targetId_ = other.targetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A81D RID: 43037 RVA: 0x001949F4 File Offset: 0x00192BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HitEndPush Clone()
		{
			return new HitEndPush(this);
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x0600A81E RID: 43038 RVA: 0x001949FC File Offset: 0x00192BFC
		// (set) Token: 0x0600A81F RID: 43039 RVA: 0x00194A04 File Offset: 0x00192C04
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

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x0600A820 RID: 43040 RVA: 0x00194A0D File Offset: 0x00192C0D
		// (set) Token: 0x0600A821 RID: 43041 RVA: 0x00194A15 File Offset: 0x00192C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x0600A822 RID: 43042 RVA: 0x00194A1E File Offset: 0x00192C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HitEndPush);
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x00194A2C File Offset: 0x00192C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HitEndPush other)
		{
			return other != null && (other == this || (object.Equals(this.CombatCommon, other.CombatCommon) && this.TargetId == other.TargetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A824 RID: 43044 RVA: 0x00194A7C File Offset: 0x00192C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.combatCommon_ != null)
			{
				num ^= this.CombatCommon.GetHashCode();
			}
			if (this.TargetId != 0L)
			{
				num ^= this.TargetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A825 RID: 43045 RVA: 0x00194AD1 File Offset: 0x00192CD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A826 RID: 43046 RVA: 0x00194ADE File Offset: 0x00192CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x00194AE8 File Offset: 0x00192CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.combatCommon_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.CombatCommon);
			}
			if (this.TargetId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x00194B44 File Offset: 0x00192D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.combatCommon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CombatCommon);
			}
			if (this.TargetId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A829 RID: 43049 RVA: 0x00194B9C File Offset: 0x00192D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HitEndPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.combatCommon_ != null)
			{
				if (this.combatCommon_ == null)
				{
					this.CombatCommon = new CombatCommon();
				}
				this.CombatCommon.MergeFrom(other.CombatCommon);
			}
			if (other.TargetId != 0L)
			{
				this.TargetId = other.TargetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x00194C04 File Offset: 0x00192E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x00194C10 File Offset: 0x00192E10
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
				if (num != 50U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetId = input.ReadInt64();
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
		}

		// Token: 0x04004D0F RID: 19727
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D10 RID: 19728
		public const int CombatCommonFieldNumber = 6;

		// Token: 0x04004D11 RID: 19729
		private CombatCommon combatCommon_;

		// Token: 0x04004D12 RID: 19730
		public const int TargetIdFieldNumber = 12;

		// Token: 0x04004D13 RID: 19731
		private long targetId_;
	}
}
