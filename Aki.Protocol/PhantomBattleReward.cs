using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C97 RID: 3223
	public sealed class PhantomBattleReward : IMessage<PhantomBattleReward>, IMessage, IEquatable<PhantomBattleReward>, IDeepCloneable<PhantomBattleReward>, IBufferMessage
	{
		// Token: 0x060117D1 RID: 71633 RVA: 0x00290689 File Offset: 0x0028E889
		[NullableContext(1)]
		public static PhantomBattleReward Create()
		{
			return new PhantomBattleReward();
		}

		// Token: 0x170039EF RID: 14831
		// (get) Token: 0x060117D2 RID: 71634 RVA: 0x00290690 File Offset: 0x0028E890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleReward> Parser
		{
			get
			{
				return PhantomBattleReward._parser;
			}
		}

		// Token: 0x170039F0 RID: 14832
		// (get) Token: 0x060117D3 RID: 71635 RVA: 0x00290697 File Offset: 0x0028E897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x060117D4 RID: 71636 RVA: 0x0029069A File Offset: 0x0028E89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReward.Descriptor;
			}
		}

		// Token: 0x060117D5 RID: 71637 RVA: 0x002906A1 File Offset: 0x0028E8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReward()
		{
		}

		// Token: 0x060117D6 RID: 71638 RVA: 0x002906A9 File Offset: 0x0028E8A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReward(PhantomBattleReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117D7 RID: 71639 RVA: 0x002906E6 File Offset: 0x0028E8E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReward Clone()
		{
			return new PhantomBattleReward(this);
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x060117D8 RID: 71640 RVA: 0x002906EE File Offset: 0x0028E8EE
		// (set) Token: 0x060117D9 RID: 71641 RVA: 0x002906F6 File Offset: 0x0028E8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x060117DA RID: 71642 RVA: 0x002906FF File Offset: 0x0028E8FF
		// (set) Token: 0x060117DB RID: 71643 RVA: 0x00290707 File Offset: 0x0028E907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x060117DC RID: 71644 RVA: 0x00290710 File Offset: 0x0028E910
		// (set) Token: 0x060117DD RID: 71645 RVA: 0x00290718 File Offset: 0x0028E918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x060117DE RID: 71646 RVA: 0x00290721 File Offset: 0x0028E921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReward);
		}

		// Token: 0x060117DF RID: 71647 RVA: 0x00290730 File Offset: 0x0028E930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117E0 RID: 71648 RVA: 0x0029078C File Offset: 0x0028E98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060117E1 RID: 71649 RVA: 0x002907FD File Offset: 0x0028E9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117E2 RID: 71650 RVA: 0x0029080A File Offset: 0x0028EA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117E3 RID: 71651 RVA: 0x00290814 File Offset: 0x0028EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.IncId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060117E4 RID: 71652 RVA: 0x00290888 File Offset: 0x0028EA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060117E5 RID: 71653 RVA: 0x002908F8 File Offset: 0x0028EAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060117E6 RID: 71654 RVA: 0x0029095C File Offset: 0x0028EB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117E7 RID: 71655 RVA: 0x00290968 File Offset: 0x0028EB68
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
							this.IncId = input.ReadInt32();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006EBA RID: 28346
		private static readonly MessageParser<PhantomBattleReward> _parser = new MessageParser<PhantomBattleReward>(() => new PhantomBattleReward());

		// Token: 0x04006EBB RID: 28347
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EBC RID: 28348
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04006EBD RID: 28349
		private int itemId_;

		// Token: 0x04006EBE RID: 28350
		public const int CountFieldNumber = 2;

		// Token: 0x04006EBF RID: 28351
		private int count_;

		// Token: 0x04006EC0 RID: 28352
		public const int IncIdFieldNumber = 3;

		// Token: 0x04006EC1 RID: 28353
		private int incId_;
	}
}
