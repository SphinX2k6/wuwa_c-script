using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5D RID: 3165
	[NetMessage(EMessageId.PhantomBattleCheckCardSkillUnlockRequest)]
	public sealed class PhantomBattleCheckCardSkillUnlockRequest : IMessage<PhantomBattleCheckCardSkillUnlockRequest>, IMessage, IEquatable<PhantomBattleCheckCardSkillUnlockRequest>, IDeepCloneable<PhantomBattleCheckCardSkillUnlockRequest>, IBufferMessage
	{
		// Token: 0x060112F0 RID: 70384 RVA: 0x00284A51 File Offset: 0x00282C51
		[NullableContext(1)]
		public static PhantomBattleCheckCardSkillUnlockRequest Create()
		{
			return new PhantomBattleCheckCardSkillUnlockRequest();
		}

		// Token: 0x170038D6 RID: 14550
		// (get) Token: 0x060112F1 RID: 70385 RVA: 0x00284A58 File Offset: 0x00282C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038D7 RID: 14551
		// (get) Token: 0x060112F2 RID: 70386 RVA: 0x00284A5B File Offset: 0x00282C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCheckCardSkillUnlockRequest.Descriptor;
			}
		}

		// Token: 0x060112F3 RID: 70387 RVA: 0x00284A62 File Offset: 0x00282C62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockRequest()
		{
		}

		// Token: 0x060112F4 RID: 70388 RVA: 0x00284A75 File Offset: 0x00282C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockRequest(PhantomBattleCheckCardSkillUnlockRequest other) : this()
		{
			this.cardConfig_ = other.cardConfig_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112F5 RID: 70389 RVA: 0x00284A9F File Offset: 0x00282C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCheckCardSkillUnlockRequest Clone()
		{
			return new PhantomBattleCheckCardSkillUnlockRequest(this);
		}

		// Token: 0x170038D8 RID: 14552
		// (get) Token: 0x060112F6 RID: 70390 RVA: 0x00284AA7 File Offset: 0x00282CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardConfig
		{
			get
			{
				return this.cardConfig_;
			}
		}

		// Token: 0x060112F7 RID: 70391 RVA: 0x00284AAF File Offset: 0x00282CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCheckCardSkillUnlockRequest);
		}

		// Token: 0x060112F8 RID: 70392 RVA: 0x00284ABD File Offset: 0x00282CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCheckCardSkillUnlockRequest other)
		{
			return other != null && (other == this || (this.cardConfig_.Equals(other.cardConfig_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112F9 RID: 70393 RVA: 0x00284AF0 File Offset: 0x00282CF0
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

		// Token: 0x060112FA RID: 70394 RVA: 0x00284B24 File Offset: 0x00282D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112FB RID: 70395 RVA: 0x00284B31 File Offset: 0x00282D31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112FC RID: 70396 RVA: 0x00284B3A File Offset: 0x00282D3A
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

		// Token: 0x060112FD RID: 70397 RVA: 0x00284B64 File Offset: 0x00282D64
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

		// Token: 0x060112FE RID: 70398 RVA: 0x00284B9D File Offset: 0x00282D9D
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

		// Token: 0x060112FF RID: 70399 RVA: 0x00284BCB File Offset: 0x00282DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011300 RID: 70400 RVA: 0x00284BD4 File Offset: 0x00282DD4
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.cardConfig_.AddEntriesFrom(ref input, PhantomBattleCheckCardSkillUnlockRequest._repeated_cardConfig_codec);
				}
			}
		}

		// Token: 0x04006D2C RID: 27948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D2D RID: 27949
		public const int CardConfigFieldNumber = 7;

		// Token: 0x04006D2E RID: 27950
		private static readonly FieldCodec<int> _repeated_cardConfig_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006D2F RID: 27951
		private readonly RepeatedField<int> cardConfig_ = new RepeatedField<int>();
	}
}
