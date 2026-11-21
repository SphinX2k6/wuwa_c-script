using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C65 RID: 3173
	public sealed class PhantomBattleDebugBuffInfo : IMessage<PhantomBattleDebugBuffInfo>, IMessage, IEquatable<PhantomBattleDebugBuffInfo>, IDeepCloneable<PhantomBattleDebugBuffInfo>, IBufferMessage
	{
		// Token: 0x06011394 RID: 70548 RVA: 0x002860C8 File Offset: 0x002842C8
		[NullableContext(1)]
		public static PhantomBattleDebugBuffInfo Create()
		{
			return new PhantomBattleDebugBuffInfo();
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x06011395 RID: 70549 RVA: 0x002860CF File Offset: 0x002842CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleDebugBuffInfo> Parser
		{
			get
			{
				return PhantomBattleDebugBuffInfo._parser;
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x06011396 RID: 70550 RVA: 0x002860D6 File Offset: 0x002842D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038FA RID: 14586
		// (get) Token: 0x06011397 RID: 70551 RVA: 0x002860D9 File Offset: 0x002842D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDebugBuffInfo.Descriptor;
			}
		}

		// Token: 0x06011398 RID: 70552 RVA: 0x002860E0 File Offset: 0x002842E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugBuffInfo()
		{
		}

		// Token: 0x06011399 RID: 70553 RVA: 0x002860E8 File Offset: 0x002842E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugBuffInfo(PhantomBattleDebugBuffInfo other) : this()
		{
			this.buffUId_ = other.buffUId_;
			this.buffConfId_ = other.buffConfId_;
			this.remainRound_ = other.remainRound_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601139A RID: 70554 RVA: 0x00286125 File Offset: 0x00284325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDebugBuffInfo Clone()
		{
			return new PhantomBattleDebugBuffInfo(this);
		}

		// Token: 0x170038FB RID: 14587
		// (get) Token: 0x0601139B RID: 70555 RVA: 0x0028612D File Offset: 0x0028432D
		// (set) Token: 0x0601139C RID: 70556 RVA: 0x00286135 File Offset: 0x00284335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffUId
		{
			get
			{
				return this.buffUId_;
			}
			set
			{
				this.buffUId_ = value;
			}
		}

		// Token: 0x170038FC RID: 14588
		// (get) Token: 0x0601139D RID: 70557 RVA: 0x0028613E File Offset: 0x0028433E
		// (set) Token: 0x0601139E RID: 70558 RVA: 0x00286146 File Offset: 0x00284346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffConfId
		{
			get
			{
				return this.buffConfId_;
			}
			set
			{
				this.buffConfId_ = value;
			}
		}

		// Token: 0x170038FD RID: 14589
		// (get) Token: 0x0601139F RID: 70559 RVA: 0x0028614F File Offset: 0x0028434F
		// (set) Token: 0x060113A0 RID: 70560 RVA: 0x00286157 File Offset: 0x00284357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RemainRound
		{
			get
			{
				return this.remainRound_;
			}
			set
			{
				this.remainRound_ = value;
			}
		}

		// Token: 0x060113A1 RID: 70561 RVA: 0x00286160 File Offset: 0x00284360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDebugBuffInfo);
		}

		// Token: 0x060113A2 RID: 70562 RVA: 0x00286170 File Offset: 0x00284370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDebugBuffInfo other)
		{
			return other != null && (other == this || (this.BuffUId == other.BuffUId && this.BuffConfId == other.BuffConfId && this.RemainRound == other.RemainRound && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113A3 RID: 70563 RVA: 0x002861CC File Offset: 0x002843CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffUId != 0)
			{
				num ^= this.BuffUId.GetHashCode();
			}
			if (this.BuffConfId != 0)
			{
				num ^= this.BuffConfId.GetHashCode();
			}
			if (this.RemainRound != 0)
			{
				num ^= this.RemainRound.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060113A4 RID: 70564 RVA: 0x0028623D File Offset: 0x0028443D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113A5 RID: 70565 RVA: 0x0028624A File Offset: 0x0028444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113A6 RID: 70566 RVA: 0x00286254 File Offset: 0x00284454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffUId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BuffUId);
			}
			if (this.BuffConfId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BuffConfId);
			}
			if (this.RemainRound != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RemainRound);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113A7 RID: 70567 RVA: 0x002862C8 File Offset: 0x002844C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffUId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffUId);
			}
			if (this.BuffConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffConfId);
			}
			if (this.RemainRound != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RemainRound);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060113A8 RID: 70568 RVA: 0x00286338 File Offset: 0x00284538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDebugBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffUId != 0)
			{
				this.BuffUId = other.BuffUId;
			}
			if (other.BuffConfId != 0)
			{
				this.BuffConfId = other.BuffConfId;
			}
			if (other.RemainRound != 0)
			{
				this.RemainRound = other.RemainRound;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060113A9 RID: 70569 RVA: 0x0028639C File Offset: 0x0028459C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060113AA RID: 70570 RVA: 0x002863A8 File Offset: 0x002845A8
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
							this.RemainRound = input.ReadInt32();
						}
					}
					else
					{
						this.BuffConfId = input.ReadInt32();
					}
				}
				else
				{
					this.BuffUId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006D60 RID: 28000
		private static readonly MessageParser<PhantomBattleDebugBuffInfo> _parser = new MessageParser<PhantomBattleDebugBuffInfo>(() => new PhantomBattleDebugBuffInfo());

		// Token: 0x04006D61 RID: 28001
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D62 RID: 28002
		public const int BuffUIdFieldNumber = 1;

		// Token: 0x04006D63 RID: 28003
		private int buffUId_;

		// Token: 0x04006D64 RID: 28004
		public const int BuffConfIdFieldNumber = 2;

		// Token: 0x04006D65 RID: 28005
		private int buffConfId_;

		// Token: 0x04006D66 RID: 28006
		public const int RemainRoundFieldNumber = 3;

		// Token: 0x04006D67 RID: 28007
		private int remainRound_;
	}
}
