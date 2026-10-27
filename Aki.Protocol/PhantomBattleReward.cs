using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA7 RID: 3239
	public sealed class PhantomBattleReward : IMessage<PhantomBattleReward>, IMessage, IEquatable<PhantomBattleReward>, IDeepCloneable<PhantomBattleReward>, IBufferMessage
	{
		// Token: 0x060118D1 RID: 71889 RVA: 0x002923F5 File Offset: 0x002905F5
		[NullableContext(1)]
		public static PhantomBattleReward Create()
		{
			return new PhantomBattleReward();
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x060118D2 RID: 71890 RVA: 0x002923FC File Offset: 0x002905FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleReward> Parser
		{
			get
			{
				return PhantomBattleReward._parser;
			}
		}

		// Token: 0x17003A27 RID: 14887
		// (get) Token: 0x060118D3 RID: 71891 RVA: 0x00292403 File Offset: 0x00290603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A28 RID: 14888
		// (get) Token: 0x060118D4 RID: 71892 RVA: 0x00292406 File Offset: 0x00290606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReward.Descriptor;
			}
		}

		// Token: 0x060118D5 RID: 71893 RVA: 0x0029240D File Offset: 0x0029060D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReward()
		{
		}

		// Token: 0x060118D6 RID: 71894 RVA: 0x00292415 File Offset: 0x00290615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReward(PhantomBattleReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060118D7 RID: 71895 RVA: 0x00292452 File Offset: 0x00290652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReward Clone()
		{
			return new PhantomBattleReward(this);
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x060118D8 RID: 71896 RVA: 0x0029245A File Offset: 0x0029065A
		// (set) Token: 0x060118D9 RID: 71897 RVA: 0x00292462 File Offset: 0x00290662
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

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x060118DA RID: 71898 RVA: 0x0029246B File Offset: 0x0029066B
		// (set) Token: 0x060118DB RID: 71899 RVA: 0x00292473 File Offset: 0x00290673
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

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x060118DC RID: 71900 RVA: 0x0029247C File Offset: 0x0029067C
		// (set) Token: 0x060118DD RID: 71901 RVA: 0x00292484 File Offset: 0x00290684
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

		// Token: 0x060118DE RID: 71902 RVA: 0x0029248D File Offset: 0x0029068D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReward);
		}

		// Token: 0x060118DF RID: 71903 RVA: 0x0029249C File Offset: 0x0029069C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Count == other.Count && this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118E0 RID: 71904 RVA: 0x002924F8 File Offset: 0x002906F8
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

		// Token: 0x060118E1 RID: 71905 RVA: 0x00292569 File Offset: 0x00290769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118E2 RID: 71906 RVA: 0x00292576 File Offset: 0x00290776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118E3 RID: 71907 RVA: 0x00292580 File Offset: 0x00290780
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

		// Token: 0x060118E4 RID: 71908 RVA: 0x002925F4 File Offset: 0x002907F4
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

		// Token: 0x060118E5 RID: 71909 RVA: 0x00292664 File Offset: 0x00290864
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

		// Token: 0x060118E6 RID: 71910 RVA: 0x002926C8 File Offset: 0x002908C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118E7 RID: 71911 RVA: 0x002926D4 File Offset: 0x002908D4
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

		// Token: 0x04006EA6 RID: 28326
		private static readonly MessageParser<PhantomBattleReward> _parser = new MessageParser<PhantomBattleReward>(() => new PhantomBattleReward());

		// Token: 0x04006EA7 RID: 28327
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EA8 RID: 28328
		public const int ItemIdFieldNumber = 1;

		// Token: 0x04006EA9 RID: 28329
		private int itemId_;

		// Token: 0x04006EAA RID: 28330
		public const int CountFieldNumber = 2;

		// Token: 0x04006EAB RID: 28331
		private int count_;

		// Token: 0x04006EAC RID: 28332
		public const int IncIdFieldNumber = 3;

		// Token: 0x04006EAD RID: 28333
		private int incId_;
	}
}
