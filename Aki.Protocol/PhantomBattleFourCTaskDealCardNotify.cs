using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C89 RID: 3209
	[NetMessage(EMessageId.PhantomBattleFourCTaskDealCardNotify)]
	public sealed class PhantomBattleFourCTaskDealCardNotify : IMessage<PhantomBattleFourCTaskDealCardNotify>, IMessage, IEquatable<PhantomBattleFourCTaskDealCardNotify>, IDeepCloneable<PhantomBattleFourCTaskDealCardNotify>, IBufferMessage
	{
		// Token: 0x06011656 RID: 71254 RVA: 0x0028CA20 File Offset: 0x0028AC20
		[NullableContext(1)]
		public static PhantomBattleFourCTaskDealCardNotify Create()
		{
			return new PhantomBattleFourCTaskDealCardNotify();
		}

		// Token: 0x1700399B RID: 14747
		// (get) Token: 0x06011657 RID: 71255 RVA: 0x0028CA27 File Offset: 0x0028AC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700399C RID: 14748
		// (get) Token: 0x06011658 RID: 71256 RVA: 0x0028CA2A File Offset: 0x0028AC2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleFourCTaskDealCardNotify.Descriptor;
			}
		}

		// Token: 0x06011659 RID: 71257 RVA: 0x0028CA31 File Offset: 0x0028AC31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskDealCardNotify()
		{
		}

		// Token: 0x0601165A RID: 71258 RVA: 0x0028CA39 File Offset: 0x0028AC39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskDealCardNotify(PhantomBattleFourCTaskDealCardNotify other) : this()
		{
			this.phantomBattleHandCardInfo_ = ((other.phantomBattleHandCardInfo_ != null) ? other.phantomBattleHandCardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601165B RID: 71259 RVA: 0x0028CA6E File Offset: 0x0028AC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFourCTaskDealCardNotify Clone()
		{
			return new PhantomBattleFourCTaskDealCardNotify(this);
		}

		// Token: 0x1700399D RID: 14749
		// (get) Token: 0x0601165C RID: 71260 RVA: 0x0028CA76 File Offset: 0x0028AC76
		// (set) Token: 0x0601165D RID: 71261 RVA: 0x0028CA7E File Offset: 0x0028AC7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleHandCardInfo PhantomBattleHandCardInfo
		{
			get
			{
				return this.phantomBattleHandCardInfo_;
			}
			set
			{
				this.phantomBattleHandCardInfo_ = value;
			}
		}

		// Token: 0x0601165E RID: 71262 RVA: 0x0028CA87 File Offset: 0x0028AC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleFourCTaskDealCardNotify);
		}

		// Token: 0x0601165F RID: 71263 RVA: 0x0028CA95 File Offset: 0x0028AC95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleFourCTaskDealCardNotify other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleHandCardInfo, other.PhantomBattleHandCardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011660 RID: 71264 RVA: 0x0028CAC8 File Offset: 0x0028ACC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num ^= this.PhantomBattleHandCardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011661 RID: 71265 RVA: 0x0028CB04 File Offset: 0x0028AD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011662 RID: 71266 RVA: 0x0028CB11 File Offset: 0x0028AD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011663 RID: 71267 RVA: 0x0028CB1A File Offset: 0x0028AD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleHandCardInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PhantomBattleHandCardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011664 RID: 71268 RVA: 0x0028CB4C File Offset: 0x0028AD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleHandCardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleHandCardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011665 RID: 71269 RVA: 0x0028CB8C File Offset: 0x0028AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleFourCTaskDealCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleHandCardInfo_ != null)
			{
				if (this.phantomBattleHandCardInfo_ == null)
				{
					this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
				}
				this.PhantomBattleHandCardInfo.MergeFrom(other.PhantomBattleHandCardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011666 RID: 71270 RVA: 0x0028CBE0 File Offset: 0x0028ADE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011667 RID: 71271 RVA: 0x0028CBEC File Offset: 0x0028ADEC
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.phantomBattleHandCardInfo_ == null)
					{
						this.PhantomBattleHandCardInfo = new PhantomBattleHandCardInfo();
					}
					input.ReadMessage(this.PhantomBattleHandCardInfo);
				}
			}
		}

		// Token: 0x04006DDE RID: 28126
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DDF RID: 28127
		public const int PhantomBattleHandCardInfoFieldNumber = 6;

		// Token: 0x04006DE0 RID: 28128
		private PhantomBattleHandCardInfo phantomBattleHandCardInfo_;
	}
}
