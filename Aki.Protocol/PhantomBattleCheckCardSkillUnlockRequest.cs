using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6D RID: 3181
	[NetMessage(EMessageId.PhantomBattleCheckCardSkillUnlockRequest)]
	public sealed class PhantomBattleCheckCardSkillUnlockRequest : IMessage<PhantomBattleCheckCardSkillUnlockRequest>, IMessage, IEquatable<PhantomBattleCheckCardSkillUnlockRequest>, IDeepCloneable<PhantomBattleCheckCardSkillUnlockRequest>, IBufferMessage
	{
		// Token: 0x060113F0 RID: 70640 RVA: 0x002867C1 File Offset: 0x002849C1
		[NullableContext(1)]
		public static PhantomBattleCheckCardSkillUnlockRequest Create()
		{
			return new PhantomBattleCheckCardSkillUnlockRequest();
		}

		// Token: 0x1700390D RID: 14605
		// (get) Token: 0x060113F1 RID: 70641 RVA: 0x002867C8 File Offset: 0x002849C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700390E RID: 14606
		// (get) Token: 0x060113F2 RID: 70642 RVA: 0x002867CB File Offset: 0x002849CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCheckCardSkillUnlockRequest.Descriptor;
			}
		}

		// Token: 0x060113F3 RID: 70643 RVA: 0x002867D2 File Offset: 0x002849D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockRequest()
		{
		}

		// Token: 0x060113F4 RID: 70644 RVA: 0x002867E5 File Offset: 0x002849E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockRequest(PhantomBattleCheckCardSkillUnlockRequest other) : this()
		{
			this.cardConfig_ = other.cardConfig_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060113F5 RID: 70645 RVA: 0x0028680F File Offset: 0x00284A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockRequest Clone()
		{
			return new PhantomBattleCheckCardSkillUnlockRequest(this);
		}

		// Token: 0x1700390F RID: 14607
		// (get) Token: 0x060113F6 RID: 70646 RVA: 0x00286817 File Offset: 0x00284A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardConfig
		{
			get
			{
				return this.cardConfig_;
			}
		}

		// Token: 0x060113F7 RID: 70647 RVA: 0x0028681F File Offset: 0x00284A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCheckCardSkillUnlockRequest);
		}

		// Token: 0x060113F8 RID: 70648 RVA: 0x0028682D File Offset: 0x00284A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCheckCardSkillUnlockRequest other)
		{
			return other != null && (other == this || (this.cardConfig_.Equals(other.cardConfig_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060113F9 RID: 70649 RVA: 0x00286860 File Offset: 0x00284A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.cardConfig_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060113FA RID: 70650 RVA: 0x00286894 File Offset: 0x00284A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060113FB RID: 70651 RVA: 0x002868A1 File Offset: 0x00284AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060113FC RID: 70652 RVA: 0x002868AA File Offset: 0x00284AAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.cardConfig_.WriteTo(ref output, PhantomBattleCheckCardSkillUnlockRequest._repeated_cardConfig_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060113FD RID: 70653 RVA: 0x002868D4 File Offset: 0x00284AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.cardConfig_.CalculateSize(PhantomBattleCheckCardSkillUnlockRequest._repeated_cardConfig_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060113FE RID: 70654 RVA: 0x0028690D File Offset: 0x00284B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCheckCardSkillUnlockRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.cardConfig_.Add(other.cardConfig_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060113FF RID: 70655 RVA: 0x0028693B File Offset: 0x00284B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011400 RID: 70656 RVA: 0x00286944 File Offset: 0x00284B44
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
				if (num != 96U && num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cardConfig_.AddEntriesFrom(ref input, PhantomBattleCheckCardSkillUnlockRequest._repeated_cardConfig_codec);
				}
			}
		}

		// Token: 0x04006D18 RID: 27928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D19 RID: 27929
		public const int CardConfigFieldNumber = 12;

		// Token: 0x04006D1A RID: 27930
		private static readonly FieldCodec<int> _repeated_cardConfig_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04006D1B RID: 27931
		private readonly RepeatedField<int> cardConfig_ = new RepeatedField<int>();
	}
}
