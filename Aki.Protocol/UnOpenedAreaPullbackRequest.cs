using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148F RID: 5263
	[NetMessage(EMessageId.UnOpenedAreaPullbackRequest)]
	public sealed class UnOpenedAreaPullbackRequest : IMessage<UnOpenedAreaPullbackRequest>, IMessage, IEquatable<UnOpenedAreaPullbackRequest>, IDeepCloneable<UnOpenedAreaPullbackRequest>, IBufferMessage
	{
		// Token: 0x0601BD85 RID: 114053 RVA: 0x00406BE9 File Offset: 0x00404DE9
		[NullableContext(1)]
		public static UnOpenedAreaPullbackRequest Create()
		{
			return new UnOpenedAreaPullbackRequest();
		}

		// Token: 0x17005DDC RID: 24028
		// (get) Token: 0x0601BD86 RID: 114054 RVA: 0x00406BF0 File Offset: 0x00404DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DDD RID: 24029
		// (get) Token: 0x0601BD87 RID: 114055 RVA: 0x00406BF3 File Offset: 0x00404DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnOpenedAreaPullbackRequest.Descriptor;
			}
		}

		// Token: 0x0601BD88 RID: 114056 RVA: 0x00406BFA File Offset: 0x00404DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackRequest()
		{
		}

		// Token: 0x0601BD89 RID: 114057 RVA: 0x00406C02 File Offset: 0x00404E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackRequest(UnOpenedAreaPullbackRequest other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.reason_ = other.reason_;
			this.transferEffectId_ = other.transferEffectId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BD8A RID: 114058 RVA: 0x00406C3F File Offset: 0x00404E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnOpenedAreaPullbackRequest Clone()
		{
			return new UnOpenedAreaPullbackRequest(this);
		}

		// Token: 0x17005DDE RID: 24030
		// (get) Token: 0x0601BD8B RID: 114059 RVA: 0x00406C47 File Offset: 0x00404E47
		// (set) Token: 0x0601BD8C RID: 114060 RVA: 0x00406C5F File Offset: 0x00404E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TeleportReason Reason
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.reason_;
				}
				return UnOpenedAreaPullbackRequest.ReasonDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.reason_ = value;
			}
		}

		// Token: 0x17005DDF RID: 24031
		// (get) Token: 0x0601BD8D RID: 114061 RVA: 0x00406C76 File Offset: 0x00404E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReason
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0601BD8E RID: 114062 RVA: 0x00406C83 File Offset: 0x00404E83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearReason()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17005DE0 RID: 24032
		// (get) Token: 0x0601BD8F RID: 114063 RVA: 0x00406C94 File Offset: 0x00404E94
		// (set) Token: 0x0601BD90 RID: 114064 RVA: 0x00406CAC File Offset: 0x00404EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TransferEffectId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.transferEffectId_;
				}
				return UnOpenedAreaPullbackRequest.TransferEffectIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.transferEffectId_ = value;
			}
		}

		// Token: 0x17005DE1 RID: 24033
		// (get) Token: 0x0601BD91 RID: 114065 RVA: 0x00406CC3 File Offset: 0x00404EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTransferEffectId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0601BD92 RID: 114066 RVA: 0x00406CD0 File Offset: 0x00404ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTransferEffectId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0601BD93 RID: 114067 RVA: 0x00406CE1 File Offset: 0x00404EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnOpenedAreaPullbackRequest);
		}

		// Token: 0x0601BD94 RID: 114068 RVA: 0x00406CEF File Offset: 0x00404EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnOpenedAreaPullbackRequest other)
		{
			return other != null && (other == this || (this.Reason == other.Reason && this.TransferEffectId == other.TransferEffectId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BD95 RID: 114069 RVA: 0x00406D30 File Offset: 0x00404F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasReason)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this.HasTransferEffectId)
			{
				num ^= this.TransferEffectId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BD96 RID: 114070 RVA: 0x00406D8E File Offset: 0x00404F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BD97 RID: 114071 RVA: 0x00406D9B File Offset: 0x00404F9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BD98 RID: 114072 RVA: 0x00406DA4 File Offset: 0x00404FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasTransferEffectId)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.TransferEffectId);
			}
			if (this.HasReason)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BD99 RID: 114073 RVA: 0x00406E00 File Offset: 0x00405000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasReason)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this.HasTransferEffectId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TransferEffectId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BD9A RID: 114074 RVA: 0x00406E58 File Offset: 0x00405058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnOpenedAreaPullbackRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasReason)
			{
				this.Reason = other.Reason;
			}
			if (other.HasTransferEffectId)
			{
				this.TransferEffectId = other.TransferEffectId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BD9B RID: 114075 RVA: 0x00406EA8 File Offset: 0x004050A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BD9C RID: 114076 RVA: 0x00406EB4 File Offset: 0x004050B4
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
				if (num != 72U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Reason = (TeleportReason)input.ReadEnum();
					}
				}
				else
				{
					this.TransferEffectId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A024 RID: 40996
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A025 RID: 40997
		private int _hasBits0;

		// Token: 0x0400A026 RID: 40998
		public const int ReasonFieldNumber = 10;

		// Token: 0x0400A027 RID: 40999
		private static readonly TeleportReason ReasonDefaultValue;

		// Token: 0x0400A028 RID: 41000
		private TeleportReason reason_;

		// Token: 0x0400A029 RID: 41001
		public const int TransferEffectIdFieldNumber = 9;

		// Token: 0x0400A02A RID: 41002
		private static readonly int TransferEffectIdDefaultValue;

		// Token: 0x0400A02B RID: 41003
		private int transferEffectId_;
	}
}
