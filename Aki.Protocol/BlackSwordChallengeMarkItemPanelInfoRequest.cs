using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B3 RID: 435
	[NetMessage(EMessageId.BlackSwordChallengeMarkItemPanelInfoRequest)]
	public sealed class BlackSwordChallengeMarkItemPanelInfoRequest : IMessage<BlackSwordChallengeMarkItemPanelInfoRequest>, IMessage, IEquatable<BlackSwordChallengeMarkItemPanelInfoRequest>, IDeepCloneable<BlackSwordChallengeMarkItemPanelInfoRequest>, IBufferMessage
	{
		// Token: 0x060032D6 RID: 13014 RVA: 0x00081417 File Offset: 0x0007F617
		[NullableContext(1)]
		public static BlackSwordChallengeMarkItemPanelInfoRequest Create()
		{
			return new BlackSwordChallengeMarkItemPanelInfoRequest();
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060032D7 RID: 13015 RVA: 0x0008141E File Offset: 0x0007F61E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00081421 File Offset: 0x0007F621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BlackSwordChallengeMarkItemPanelInfoRequest.Descriptor;
			}
		}

		// Token: 0x060032D9 RID: 13017 RVA: 0x00081428 File Offset: 0x0007F628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoRequest()
		{
		}

		// Token: 0x060032DA RID: 13018 RVA: 0x00081430 File Offset: 0x0007F630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoRequest(BlackSwordChallengeMarkItemPanelInfoRequest other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032DB RID: 13019 RVA: 0x00081455 File Offset: 0x0007F655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BlackSwordChallengeMarkItemPanelInfoRequest Clone()
		{
			return new BlackSwordChallengeMarkItemPanelInfoRequest(this);
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x0008145D File Offset: 0x0007F65D
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x00081465 File Offset: 0x0007F665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x0008146E File Offset: 0x0007F66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BlackSwordChallengeMarkItemPanelInfoRequest);
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x0008147C File Offset: 0x0007F67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BlackSwordChallengeMarkItemPanelInfoRequest other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x000814AC File Offset: 0x0007F6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000814EB File Offset: 0x0007F6EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000814F8 File Offset: 0x0007F6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x00081501 File Offset: 0x0007F701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x00081534 File Offset: 0x0007F734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x00081572 File Offset: 0x0007F772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BlackSwordChallengeMarkItemPanelInfoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x000815A3 File Offset: 0x0007F7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x000815AC File Offset: 0x0007F7AC
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029EA RID: 10730
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029EB RID: 10731
		public const int ChallengeIdFieldNumber = 4;

		// Token: 0x040029EC RID: 10732
		private int challengeId_;
	}
}
