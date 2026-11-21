using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001006 RID: 4102
	public sealed class RogueSeasonReward : IMessage<RogueSeasonReward>, IMessage, IEquatable<RogueSeasonReward>, IDeepCloneable<RogueSeasonReward>, IBufferMessage
	{
		// Token: 0x06015F6B RID: 89963 RVA: 0x00332260 File Offset: 0x00330460
		[NullableContext(1)]
		public static RogueSeasonReward Create()
		{
			return new RogueSeasonReward();
		}

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x06015F6C RID: 89964 RVA: 0x00332267 File Offset: 0x00330467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueSeasonReward> Parser
		{
			get
			{
				return RogueSeasonReward._parser;
			}
		}

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x06015F6D RID: 89965 RVA: 0x0033226E File Offset: 0x0033046E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x06015F6E RID: 89966 RVA: 0x00332271 File Offset: 0x00330471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueSeasonReward.Descriptor;
			}
		}

		// Token: 0x06015F6F RID: 89967 RVA: 0x00332278 File Offset: 0x00330478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonReward()
		{
		}

		// Token: 0x06015F70 RID: 89968 RVA: 0x00332280 File Offset: 0x00330480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonReward(RogueSeasonReward other) : this()
		{
			this.id_ = other.id_;
			this.isReceive_ = other.isReceive_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F71 RID: 89969 RVA: 0x003322B1 File Offset: 0x003304B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueSeasonReward Clone()
		{
			return new RogueSeasonReward(this);
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x06015F72 RID: 89970 RVA: 0x003322B9 File Offset: 0x003304B9
		// (set) Token: 0x06015F73 RID: 89971 RVA: 0x003322C1 File Offset: 0x003304C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x06015F74 RID: 89972 RVA: 0x003322CA File Offset: 0x003304CA
		// (set) Token: 0x06015F75 RID: 89973 RVA: 0x003322D2 File Offset: 0x003304D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsReceive
		{
			get
			{
				return this.isReceive_;
			}
			set
			{
				this.isReceive_ = value;
			}
		}

		// Token: 0x06015F76 RID: 89974 RVA: 0x003322DB File Offset: 0x003304DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueSeasonReward);
		}

		// Token: 0x06015F77 RID: 89975 RVA: 0x003322E9 File Offset: 0x003304E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueSeasonReward other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.IsReceive == other.IsReceive && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F78 RID: 89976 RVA: 0x00332328 File Offset: 0x00330528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.IsReceive)
			{
				num ^= this.IsReceive.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015F79 RID: 89977 RVA: 0x00332380 File Offset: 0x00330580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F7A RID: 89978 RVA: 0x0033238D File Offset: 0x0033058D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F7B RID: 89979 RVA: 0x00332398 File Offset: 0x00330598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.IsReceive)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsReceive);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F7C RID: 89980 RVA: 0x003323F0 File Offset: 0x003305F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.IsReceive)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015F7D RID: 89981 RVA: 0x0033243C File Offset: 0x0033063C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueSeasonReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.IsReceive)
			{
				this.IsReceive = other.IsReceive;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015F7E RID: 89982 RVA: 0x0033248C File Offset: 0x0033068C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F7F RID: 89983 RVA: 0x00332498 File Offset: 0x00330698
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
						this.IsReceive = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008440 RID: 33856
		private static readonly MessageParser<RogueSeasonReward> _parser = new MessageParser<RogueSeasonReward>(() => new RogueSeasonReward());

		// Token: 0x04008441 RID: 33857
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008442 RID: 33858
		public const int IdFieldNumber = 1;

		// Token: 0x04008443 RID: 33859
		private int id_;

		// Token: 0x04008444 RID: 33860
		public const int IsReceiveFieldNumber = 2;

		// Token: 0x04008445 RID: 33861
		private bool isReceive_;
	}
}
