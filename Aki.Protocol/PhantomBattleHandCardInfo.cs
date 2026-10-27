using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C92 RID: 3218
	public sealed class PhantomBattleHandCardInfo : IMessage<PhantomBattleHandCardInfo>, IMessage, IEquatable<PhantomBattleHandCardInfo>, IDeepCloneable<PhantomBattleHandCardInfo>, IBufferMessage
	{
		// Token: 0x0601171A RID: 71450 RVA: 0x0028E6AD File Offset: 0x0028C8AD
		[NullableContext(1)]
		public static PhantomBattleHandCardInfo Create()
		{
			return new PhantomBattleHandCardInfo();
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0601171B RID: 71451 RVA: 0x0028E6B4 File Offset: 0x0028C8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleHandCardInfo> Parser
		{
			get
			{
				return PhantomBattleHandCardInfo._parser;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0601171C RID: 71452 RVA: 0x0028E6BB File Offset: 0x0028C8BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039CA RID: 14794
		// (get) Token: 0x0601171D RID: 71453 RVA: 0x0028E6BE File Offset: 0x0028C8BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleHandCardInfo.Descriptor;
			}
		}

		// Token: 0x0601171E RID: 71454 RVA: 0x0028E6C5 File Offset: 0x0028C8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo()
		{
		}

		// Token: 0x0601171F RID: 71455 RVA: 0x0028E6CD File Offset: 0x0028C8CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo(PhantomBattleHandCardInfo other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.cardConfId_ = other.cardConfId_;
			this.canUse_ = other.canUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011720 RID: 71456 RVA: 0x0028E70A File Offset: 0x0028C90A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo Clone()
		{
			return new PhantomBattleHandCardInfo(this);
		}

		// Token: 0x170039CB RID: 14795
		// (get) Token: 0x06011721 RID: 71457 RVA: 0x0028E712 File Offset: 0x0028C912
		// (set) Token: 0x06011722 RID: 71458 RVA: 0x0028E71A File Offset: 0x0028C91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x170039CC RID: 14796
		// (get) Token: 0x06011723 RID: 71459 RVA: 0x0028E723 File Offset: 0x0028C923
		// (set) Token: 0x06011724 RID: 71460 RVA: 0x0028E72B File Offset: 0x0028C92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardConfId
		{
			get
			{
				return this.cardConfId_;
			}
			set
			{
				this.cardConfId_ = value;
			}
		}

		// Token: 0x170039CD RID: 14797
		// (get) Token: 0x06011725 RID: 71461 RVA: 0x0028E734 File Offset: 0x0028C934
		// (set) Token: 0x06011726 RID: 71462 RVA: 0x0028E73C File Offset: 0x0028C93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CanUse
		{
			get
			{
				return this.canUse_;
			}
			set
			{
				this.canUse_ = value;
			}
		}

		// Token: 0x06011727 RID: 71463 RVA: 0x0028E745 File Offset: 0x0028C945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleHandCardInfo);
		}

		// Token: 0x06011728 RID: 71464 RVA: 0x0028E754 File Offset: 0x0028C954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleHandCardInfo other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.CardConfId == other.CardConfId && this.CanUse == other.CanUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011729 RID: 71465 RVA: 0x0028E7B0 File Offset: 0x0028C9B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this.CardConfId != 0)
			{
				num ^= this.CardConfId.GetHashCode();
			}
			if (this.CanUse)
			{
				num ^= this.CanUse.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601172A RID: 71466 RVA: 0x0028E821 File Offset: 0x0028CA21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601172B RID: 71467 RVA: 0x0028E82E File Offset: 0x0028CA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601172C RID: 71468 RVA: 0x0028E838 File Offset: 0x0028CA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CardUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CardUid);
			}
			if (this.CardConfId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardConfId);
			}
			if (this.CanUse)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.CanUse);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601172D RID: 71469 RVA: 0x0028E8AC File Offset: 0x0028CAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this.CardConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardConfId);
			}
			if (this.CanUse)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601172E RID: 71470 RVA: 0x0028E910 File Offset: 0x0028CB10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleHandCardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			if (other.CardConfId != 0)
			{
				this.CardConfId = other.CardConfId;
			}
			if (other.CanUse)
			{
				this.CanUse = other.CanUse;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601172F RID: 71471 RVA: 0x0028E974 File Offset: 0x0028CB74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011730 RID: 71472 RVA: 0x0028E980 File Offset: 0x0028CB80
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
							this.CanUse = input.ReadBool();
						}
					}
					else
					{
						this.CardConfId = input.ReadInt32();
					}
				}
				else
				{
					this.CardUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006E20 RID: 28192
		private static readonly MessageParser<PhantomBattleHandCardInfo> _parser = new MessageParser<PhantomBattleHandCardInfo>(() => new PhantomBattleHandCardInfo());

		// Token: 0x04006E21 RID: 28193
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E22 RID: 28194
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006E23 RID: 28195
		private int cardUid_;

		// Token: 0x04006E24 RID: 28196
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x04006E25 RID: 28197
		private int cardConfId_;

		// Token: 0x04006E26 RID: 28198
		public const int CanUseFieldNumber = 3;

		// Token: 0x04006E27 RID: 28199
		private bool canUse_;
	}
}
