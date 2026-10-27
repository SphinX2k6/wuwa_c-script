using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C57 RID: 3159
	public sealed class PhantomBattleCardRewardInfo : IMessage<PhantomBattleCardRewardInfo>, IMessage, IEquatable<PhantomBattleCardRewardInfo>, IDeepCloneable<PhantomBattleCardRewardInfo>, IBufferMessage
	{
		// Token: 0x0601120C RID: 70156 RVA: 0x00282078 File Offset: 0x00280278
		[NullableContext(1)]
		public static PhantomBattleCardRewardInfo Create()
		{
			return new PhantomBattleCardRewardInfo();
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0601120D RID: 70157 RVA: 0x0028207F File Offset: 0x0028027F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleCardRewardInfo> Parser
		{
			get
			{
				return PhantomBattleCardRewardInfo._parser;
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0601120E RID: 70158 RVA: 0x00282086 File Offset: 0x00280286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0601120F RID: 70159 RVA: 0x00282089 File Offset: 0x00280289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardRewardInfo.Descriptor;
			}
		}

		// Token: 0x06011210 RID: 70160 RVA: 0x00282090 File Offset: 0x00280290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfo()
		{
		}

		// Token: 0x06011211 RID: 70161 RVA: 0x00282098 File Offset: 0x00280298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfo(PhantomBattleCardRewardInfo other) : this()
		{
			this.phantomBattleCardRewardId_ = other.phantomBattleCardRewardId_;
			this.unlockNum_ = other.unlockNum_;
			this.isRewarded_ = other.isRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011212 RID: 70162 RVA: 0x002820D5 File Offset: 0x002802D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardRewardInfo Clone()
		{
			return new PhantomBattleCardRewardInfo(this);
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x06011213 RID: 70163 RVA: 0x002820DD File Offset: 0x002802DD
		// (set) Token: 0x06011214 RID: 70164 RVA: 0x002820E5 File Offset: 0x002802E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleCardRewardId
		{
			get
			{
				return this.phantomBattleCardRewardId_;
			}
			set
			{
				this.phantomBattleCardRewardId_ = value;
			}
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x06011215 RID: 70165 RVA: 0x002820EE File Offset: 0x002802EE
		// (set) Token: 0x06011216 RID: 70166 RVA: 0x002820F6 File Offset: 0x002802F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UnlockNum
		{
			get
			{
				return this.unlockNum_;
			}
			set
			{
				this.unlockNum_ = value;
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x06011217 RID: 70167 RVA: 0x002820FF File Offset: 0x002802FF
		// (set) Token: 0x06011218 RID: 70168 RVA: 0x00282107 File Offset: 0x00280307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsRewarded
		{
			get
			{
				return this.isRewarded_;
			}
			set
			{
				this.isRewarded_ = value;
			}
		}

		// Token: 0x06011219 RID: 70169 RVA: 0x00282110 File Offset: 0x00280310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardRewardInfo);
		}

		// Token: 0x0601121A RID: 70170 RVA: 0x00282120 File Offset: 0x00280320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardRewardInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleCardRewardId == other.PhantomBattleCardRewardId && this.UnlockNum == other.UnlockNum && this.IsRewarded == other.IsRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601121B RID: 70171 RVA: 0x0028217C File Offset: 0x0028037C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleCardRewardId != 0)
			{
				num ^= this.PhantomBattleCardRewardId.GetHashCode();
			}
			if (this.UnlockNum != 0)
			{
				num ^= this.UnlockNum.GetHashCode();
			}
			if (this.IsRewarded)
			{
				num ^= this.IsRewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601121C RID: 70172 RVA: 0x002821ED File Offset: 0x002803ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601121D RID: 70173 RVA: 0x002821FA File Offset: 0x002803FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601121E RID: 70174 RVA: 0x00282204 File Offset: 0x00280404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleCardRewardId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleCardRewardId);
			}
			if (this.UnlockNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.UnlockNum);
			}
			if (this.IsRewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601121F RID: 70175 RVA: 0x00282278 File Offset: 0x00280478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleCardRewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleCardRewardId);
			}
			if (this.UnlockNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UnlockNum);
			}
			if (this.IsRewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011220 RID: 70176 RVA: 0x002822DC File Offset: 0x002804DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleCardRewardId != 0)
			{
				this.PhantomBattleCardRewardId = other.PhantomBattleCardRewardId;
			}
			if (other.UnlockNum != 0)
			{
				this.UnlockNum = other.UnlockNum;
			}
			if (other.IsRewarded)
			{
				this.IsRewarded = other.IsRewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011221 RID: 70177 RVA: 0x00282340 File Offset: 0x00280540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011222 RID: 70178 RVA: 0x0028234C File Offset: 0x0028054C
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
							this.IsRewarded = input.ReadBool();
						}
					}
					else
					{
						this.UnlockNum = input.ReadInt32();
					}
				}
				else
				{
					this.PhantomBattleCardRewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006C71 RID: 27761
		private static readonly MessageParser<PhantomBattleCardRewardInfo> _parser = new MessageParser<PhantomBattleCardRewardInfo>(() => new PhantomBattleCardRewardInfo());

		// Token: 0x04006C72 RID: 27762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C73 RID: 27763
		public const int PhantomBattleCardRewardIdFieldNumber = 1;

		// Token: 0x04006C74 RID: 27764
		private int phantomBattleCardRewardId_;

		// Token: 0x04006C75 RID: 27765
		public const int UnlockNumFieldNumber = 2;

		// Token: 0x04006C76 RID: 27766
		private int unlockNum_;

		// Token: 0x04006C77 RID: 27767
		public const int IsRewardedFieldNumber = 3;

		// Token: 0x04006C78 RID: 27768
		private bool isRewarded_;
	}
}
