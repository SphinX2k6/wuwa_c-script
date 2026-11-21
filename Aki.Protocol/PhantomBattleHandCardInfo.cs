using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C82 RID: 3202
	public sealed class PhantomBattleHandCardInfo : IMessage<PhantomBattleHandCardInfo>, IMessage, IEquatable<PhantomBattleHandCardInfo>, IDeepCloneable<PhantomBattleHandCardInfo>, IBufferMessage
	{
		// Token: 0x0601161A RID: 71194 RVA: 0x0028C941 File Offset: 0x0028AB41
		[NullableContext(1)]
		public static PhantomBattleHandCardInfo Create()
		{
			return new PhantomBattleHandCardInfo();
		}

		// Token: 0x17003991 RID: 14737
		// (get) Token: 0x0601161B RID: 71195 RVA: 0x0028C948 File Offset: 0x0028AB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleHandCardInfo> Parser
		{
			get
			{
				return PhantomBattleHandCardInfo._parser;
			}
		}

		// Token: 0x17003992 RID: 14738
		// (get) Token: 0x0601161C RID: 71196 RVA: 0x0028C94F File Offset: 0x0028AB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003993 RID: 14739
		// (get) Token: 0x0601161D RID: 71197 RVA: 0x0028C952 File Offset: 0x0028AB52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleHandCardInfo.Descriptor;
			}
		}

		// Token: 0x0601161E RID: 71198 RVA: 0x0028C959 File Offset: 0x0028AB59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo()
		{
		}

		// Token: 0x0601161F RID: 71199 RVA: 0x0028C961 File Offset: 0x0028AB61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo(PhantomBattleHandCardInfo other) : this()
		{
			this.cardUid_ = other.cardUid_;
			this.cardConfId_ = other.cardConfId_;
			this.canUse_ = other.canUse_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011620 RID: 71200 RVA: 0x0028C99E File Offset: 0x0028AB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo Clone()
		{
			return new PhantomBattleHandCardInfo(this);
		}

		// Token: 0x17003994 RID: 14740
		// (get) Token: 0x06011621 RID: 71201 RVA: 0x0028C9A6 File Offset: 0x0028ABA6
		// (set) Token: 0x06011622 RID: 71202 RVA: 0x0028C9AE File Offset: 0x0028ABAE
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

		// Token: 0x17003995 RID: 14741
		// (get) Token: 0x06011623 RID: 71203 RVA: 0x0028C9B7 File Offset: 0x0028ABB7
		// (set) Token: 0x06011624 RID: 71204 RVA: 0x0028C9BF File Offset: 0x0028ABBF
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

		// Token: 0x17003996 RID: 14742
		// (get) Token: 0x06011625 RID: 71205 RVA: 0x0028C9C8 File Offset: 0x0028ABC8
		// (set) Token: 0x06011626 RID: 71206 RVA: 0x0028C9D0 File Offset: 0x0028ABD0
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

		// Token: 0x06011627 RID: 71207 RVA: 0x0028C9D9 File Offset: 0x0028ABD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleHandCardInfo);
		}

		// Token: 0x06011628 RID: 71208 RVA: 0x0028C9E8 File Offset: 0x0028ABE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleHandCardInfo other)
		{
			return other != null && (other == this || (this.CardUid == other.CardUid && this.CardConfId == other.CardConfId && this.CanUse == other.CanUse && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011629 RID: 71209 RVA: 0x0028CA44 File Offset: 0x0028AC44
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

		// Token: 0x0601162A RID: 71210 RVA: 0x0028CAB5 File Offset: 0x0028ACB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601162B RID: 71211 RVA: 0x0028CAC2 File Offset: 0x0028ACC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601162C RID: 71212 RVA: 0x0028CACC File Offset: 0x0028ACCC
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

		// Token: 0x0601162D RID: 71213 RVA: 0x0028CB40 File Offset: 0x0028AD40
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

		// Token: 0x0601162E RID: 71214 RVA: 0x0028CBA4 File Offset: 0x0028ADA4
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

		// Token: 0x0601162F RID: 71215 RVA: 0x0028CC08 File Offset: 0x0028AE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011630 RID: 71216 RVA: 0x0028CC14 File Offset: 0x0028AE14
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

		// Token: 0x04006E34 RID: 28212
		private static readonly MessageParser<PhantomBattleHandCardInfo> _parser = new MessageParser<PhantomBattleHandCardInfo>(() => new PhantomBattleHandCardInfo());

		// Token: 0x04006E35 RID: 28213
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E36 RID: 28214
		public const int CardUidFieldNumber = 1;

		// Token: 0x04006E37 RID: 28215
		private int cardUid_;

		// Token: 0x04006E38 RID: 28216
		public const int CardConfIdFieldNumber = 2;

		// Token: 0x04006E39 RID: 28217
		private int cardConfId_;

		// Token: 0x04006E3A RID: 28218
		public const int CanUseFieldNumber = 3;

		// Token: 0x04006E3B RID: 28219
		private bool canUse_;
	}
}
