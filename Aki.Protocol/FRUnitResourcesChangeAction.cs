using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000651 RID: 1617
	public sealed class FRUnitResourcesChangeAction : IMessage<FRUnitResourcesChangeAction>, IMessage, IEquatable<FRUnitResourcesChangeAction>, IDeepCloneable<FRUnitResourcesChangeAction>, IBufferMessage
	{
		// Token: 0x060094DD RID: 38109 RVA: 0x00167AE1 File Offset: 0x00165CE1
		[NullableContext(1)]
		public static FRUnitResourcesChangeAction Create()
		{
			return new FRUnitResourcesChangeAction();
		}

		// Token: 0x17001D9B RID: 7579
		// (get) Token: 0x060094DE RID: 38110 RVA: 0x00167AE8 File Offset: 0x00165CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FRUnitResourcesChangeAction> Parser
		{
			get
			{
				return FRUnitResourcesChangeAction._parser;
			}
		}

		// Token: 0x17001D9C RID: 7580
		// (get) Token: 0x060094DF RID: 38111 RVA: 0x00167AEF File Offset: 0x00165CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x060094E0 RID: 38112 RVA: 0x00167AF2 File Offset: 0x00165CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitResourcesChangeAction.Descriptor;
			}
		}

		// Token: 0x060094E1 RID: 38113 RVA: 0x00167AF9 File Offset: 0x00165CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction()
		{
		}

		// Token: 0x060094E2 RID: 38114 RVA: 0x00167B01 File Offset: 0x00165D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction(FRUnitResourcesChangeAction other) : this()
		{
			this.type_ = other.type_;
			this.changeCount_ = other.changeCount_;
			this.targetUnitIncId_ = other.targetUnitIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094E3 RID: 38115 RVA: 0x00167B3E File Offset: 0x00165D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeAction Clone()
		{
			return new FRUnitResourcesChangeAction(this);
		}

		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x060094E4 RID: 38116 RVA: 0x00167B46 File Offset: 0x00165D46
		// (set) Token: 0x060094E5 RID: 38117 RVA: 0x00167B4E File Offset: 0x00165D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitResourcesChangeType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17001D9F RID: 7583
		// (get) Token: 0x060094E6 RID: 38118 RVA: 0x00167B57 File Offset: 0x00165D57
		// (set) Token: 0x060094E7 RID: 38119 RVA: 0x00167B5F File Offset: 0x00165D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ChangeCount
		{
			get
			{
				return this.changeCount_;
			}
			set
			{
				this.changeCount_ = value;
			}
		}

		// Token: 0x17001DA0 RID: 7584
		// (get) Token: 0x060094E8 RID: 38120 RVA: 0x00167B68 File Offset: 0x00165D68
		// (set) Token: 0x060094E9 RID: 38121 RVA: 0x00167B70 File Offset: 0x00165D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetUnitIncId
		{
			get
			{
				return this.targetUnitIncId_;
			}
			set
			{
				this.targetUnitIncId_ = value;
			}
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x00167B79 File Offset: 0x00165D79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitResourcesChangeAction);
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x00167B88 File Offset: 0x00165D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitResourcesChangeAction other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.ChangeCount == other.ChangeCount && this.TargetUnitIncId == other.TargetUnitIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x00167BE4 File Offset: 0x00165DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.ChangeCount != 0L)
			{
				num ^= this.ChangeCount.GetHashCode();
			}
			if (this.TargetUnitIncId != 0)
			{
				num ^= this.TargetUnitIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094ED RID: 38125 RVA: 0x00167C5B File Offset: 0x00165E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094EE RID: 38126 RVA: 0x00167C68 File Offset: 0x00165E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094EF RID: 38127 RVA: 0x00167C74 File Offset: 0x00165E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			if (this.ChangeCount != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.ChangeCount);
			}
			if (this.TargetUnitIncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetUnitIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094F0 RID: 38128 RVA: 0x00167CE8 File Offset: 0x00165EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.ChangeCount != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ChangeCount);
			}
			if (this.TargetUnitIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetUnitIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094F1 RID: 38129 RVA: 0x00167D58 File Offset: 0x00165F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitResourcesChangeAction other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != FRUnitResourcesChangeType.UnitBaseSalary)
			{
				this.Type = other.Type;
			}
			if (other.ChangeCount != 0L)
			{
				this.ChangeCount = other.ChangeCount;
			}
			if (other.TargetUnitIncId != 0)
			{
				this.TargetUnitIncId = other.TargetUnitIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094F2 RID: 38130 RVA: 0x00167DBC File Offset: 0x00165FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094F3 RID: 38131 RVA: 0x00167DC8 File Offset: 0x00165FC8
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TargetUnitIncId = input.ReadInt32();
						}
					}
					else
					{
						this.ChangeCount = input.ReadInt64();
					}
				}
				else
				{
					this.Type = (FRUnitResourcesChangeType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004794 RID: 18324
		private static readonly MessageParser<FRUnitResourcesChangeAction> _parser = new MessageParser<FRUnitResourcesChangeAction>(() => new FRUnitResourcesChangeAction());

		// Token: 0x04004795 RID: 18325
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004796 RID: 18326
		public const int TypeFieldNumber = 1;

		// Token: 0x04004797 RID: 18327
		private FRUnitResourcesChangeType type_;

		// Token: 0x04004798 RID: 18328
		public const int ChangeCountFieldNumber = 2;

		// Token: 0x04004799 RID: 18329
		private long changeCount_;

		// Token: 0x0400479A RID: 18330
		public const int TargetUnitIncIdFieldNumber = 3;

		// Token: 0x0400479B RID: 18331
		private int targetUnitIncId_;
	}
}
