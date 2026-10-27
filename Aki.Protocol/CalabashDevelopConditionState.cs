using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200021A RID: 538
	public sealed class CalabashDevelopConditionState : IMessage<CalabashDevelopConditionState>, IMessage, IEquatable<CalabashDevelopConditionState>, IDeepCloneable<CalabashDevelopConditionState>, IBufferMessage
	{
		// Token: 0x06003AF1 RID: 15089 RVA: 0x00092CF4 File Offset: 0x00090EF4
		[NullableContext(1)]
		public static CalabashDevelopConditionState Create()
		{
			return new CalabashDevelopConditionState();
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06003AF2 RID: 15090 RVA: 0x00092CFB File Offset: 0x00090EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CalabashDevelopConditionState> Parser
		{
			get
			{
				return CalabashDevelopConditionState._parser;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x00092D02 File Offset: 0x00090F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x00092D05 File Offset: 0x00090F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashDevelopConditionState.Descriptor;
			}
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x00092D0C File Offset: 0x00090F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopConditionState()
		{
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00092D14 File Offset: 0x00090F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopConditionState(CalabashDevelopConditionState other) : this()
		{
			this.conditionId_ = other.conditionId_;
			this.rewarded_ = other.rewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x00092D45 File Offset: 0x00090F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashDevelopConditionState Clone()
		{
			return new CalabashDevelopConditionState(this);
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06003AF8 RID: 15096 RVA: 0x00092D4D File Offset: 0x00090F4D
		// (set) Token: 0x06003AF9 RID: 15097 RVA: 0x00092D55 File Offset: 0x00090F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionId
		{
			get
			{
				return this.conditionId_;
			}
			set
			{
				this.conditionId_ = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06003AFA RID: 15098 RVA: 0x00092D5E File Offset: 0x00090F5E
		// (set) Token: 0x06003AFB RID: 15099 RVA: 0x00092D66 File Offset: 0x00090F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x06003AFC RID: 15100 RVA: 0x00092D6F File Offset: 0x00090F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashDevelopConditionState);
		}

		// Token: 0x06003AFD RID: 15101 RVA: 0x00092D7D File Offset: 0x00090F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashDevelopConditionState other)
		{
			return other != null && (other == this || (this.ConditionId == other.ConditionId && this.Rewarded == other.Rewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003AFE RID: 15102 RVA: 0x00092DBC File Offset: 0x00090FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConditionId != 0)
			{
				num ^= this.ConditionId.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003AFF RID: 15103 RVA: 0x00092E14 File Offset: 0x00091014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003B00 RID: 15104 RVA: 0x00092E21 File Offset: 0x00091021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003B01 RID: 15105 RVA: 0x00092E2C File Offset: 0x0009102C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConditionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConditionId);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Rewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003B02 RID: 15106 RVA: 0x00092E84 File Offset: 0x00091084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConditionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionId);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003B03 RID: 15107 RVA: 0x00092ED0 File Offset: 0x000910D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashDevelopConditionState other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConditionId != 0)
			{
				this.ConditionId = other.ConditionId;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003B04 RID: 15108 RVA: 0x00092F20 File Offset: 0x00091120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003B05 RID: 15109 RVA: 0x00092F2C File Offset: 0x0009112C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Rewarded = input.ReadBool();
					}
				}
				else
				{
					this.ConditionId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002C02 RID: 11266
		private static readonly MessageParser<CalabashDevelopConditionState> _parser = new MessageParser<CalabashDevelopConditionState>(() => new CalabashDevelopConditionState());

		// Token: 0x04002C03 RID: 11267
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002C04 RID: 11268
		public const int ConditionIdFieldNumber = 1;

		// Token: 0x04002C05 RID: 11269
		private int conditionId_;

		// Token: 0x04002C06 RID: 11270
		public const int RewardedFieldNumber = 2;

		// Token: 0x04002C07 RID: 11271
		private bool rewarded_;
	}
}
