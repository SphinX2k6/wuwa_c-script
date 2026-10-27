using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C55 RID: 3157
	public sealed class PhantomBattleCardPosChangeInfo : IMessage<PhantomBattleCardPosChangeInfo>, IMessage, IEquatable<PhantomBattleCardPosChangeInfo>, IDeepCloneable<PhantomBattleCardPosChangeInfo>, IBufferMessage
	{
		// Token: 0x060111E2 RID: 70114 RVA: 0x00281B19 File Offset: 0x0027FD19
		[NullableContext(1)]
		public static PhantomBattleCardPosChangeInfo Create()
		{
			return new PhantomBattleCardPosChangeInfo();
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x060111E3 RID: 70115 RVA: 0x00281B20 File Offset: 0x0027FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardPosChangeInfo> Parser
		{
			get
			{
				return PhantomBattleCardPosChangeInfo._parser;
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x060111E4 RID: 70116 RVA: 0x00281B27 File Offset: 0x0027FD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x060111E5 RID: 70117 RVA: 0x00281B2A File Offset: 0x0027FD2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardPosChangeInfo.Descriptor;
			}
		}

		// Token: 0x060111E6 RID: 70118 RVA: 0x00281B31 File Offset: 0x0027FD31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeInfo()
		{
		}

		// Token: 0x060111E7 RID: 70119 RVA: 0x00281B39 File Offset: 0x0027FD39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeInfo(PhantomBattleCardPosChangeInfo other) : this()
		{
			this.fighterUid_ = other.fighterUid_;
			this.afterPos_ = other.afterPos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060111E8 RID: 70120 RVA: 0x00281B6A File Offset: 0x0027FD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardPosChangeInfo Clone()
		{
			return new PhantomBattleCardPosChangeInfo(this);
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x060111E9 RID: 70121 RVA: 0x00281B72 File Offset: 0x0027FD72
		// (set) Token: 0x060111EA RID: 70122 RVA: 0x00281B7A File Offset: 0x0027FD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FighterUid
		{
			get
			{
				return this.fighterUid_;
			}
			set
			{
				this.fighterUid_ = value;
			}
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x060111EB RID: 70123 RVA: 0x00281B83 File Offset: 0x0027FD83
		// (set) Token: 0x060111EC RID: 70124 RVA: 0x00281B8B File Offset: 0x0027FD8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AfterPos
		{
			get
			{
				return this.afterPos_;
			}
			set
			{
				this.afterPos_ = value;
			}
		}

		// Token: 0x060111ED RID: 70125 RVA: 0x00281B94 File Offset: 0x0027FD94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardPosChangeInfo);
		}

		// Token: 0x060111EE RID: 70126 RVA: 0x00281BA2 File Offset: 0x0027FDA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardPosChangeInfo other)
		{
			return other != null && (other == this || (this.FighterUid == other.FighterUid && this.AfterPos == other.AfterPos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060111EF RID: 70127 RVA: 0x00281BE0 File Offset: 0x0027FDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FighterUid != 0)
			{
				num ^= this.FighterUid.GetHashCode();
			}
			if (this.AfterPos != 0)
			{
				num ^= this.AfterPos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060111F0 RID: 70128 RVA: 0x00281C38 File Offset: 0x0027FE38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060111F1 RID: 70129 RVA: 0x00281C45 File Offset: 0x0027FE45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060111F2 RID: 70130 RVA: 0x00281C50 File Offset: 0x0027FE50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FighterUid != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FighterUid);
			}
			if (this.AfterPos != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.AfterPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060111F3 RID: 70131 RVA: 0x00281CA8 File Offset: 0x0027FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FighterUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FighterUid);
			}
			if (this.AfterPos != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AfterPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060111F4 RID: 70132 RVA: 0x00281D00 File Offset: 0x0027FF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardPosChangeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FighterUid != 0)
			{
				this.FighterUid = other.FighterUid;
			}
			if (other.AfterPos != 0)
			{
				this.AfterPos = other.AfterPos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060111F5 RID: 70133 RVA: 0x00281D50 File Offset: 0x0027FF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060111F6 RID: 70134 RVA: 0x00281D5C File Offset: 0x0027FF5C
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
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AfterPos = input.ReadInt32();
					}
				}
				else
				{
					this.FighterUid = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C65 RID: 27749
		private static readonly MessageParser<PhantomBattleCardPosChangeInfo> _parser = new MessageParser<PhantomBattleCardPosChangeInfo>(() => new PhantomBattleCardPosChangeInfo());

		// Token: 0x04006C66 RID: 27750
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C67 RID: 27751
		public const int FighterUidFieldNumber = 1;

		// Token: 0x04006C68 RID: 27752
		private int fighterUid_;

		// Token: 0x04006C69 RID: 27753
		public const int AfterPosFieldNumber = 3;

		// Token: 0x04006C6A RID: 27754
		private int afterPos_;
	}
}
