using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D79 RID: 3449
	[NetMessage(EMessageId.PlayerAccessCasketRequest)]
	public sealed class PlayerAccessCasketRequest : IMessage<PlayerAccessCasketRequest>, IMessage, IEquatable<PlayerAccessCasketRequest>, IDeepCloneable<PlayerAccessCasketRequest>, IBufferMessage
	{
		// Token: 0x0601297A RID: 76154 RVA: 0x002B648F File Offset: 0x002B468F
		[NullableContext(1)]
		public static PlayerAccessCasketRequest Create()
		{
			return new PlayerAccessCasketRequest();
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x0601297B RID: 76155 RVA: 0x002B6496 File Offset: 0x002B4696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x0601297C RID: 76156 RVA: 0x002B6499 File Offset: 0x002B4699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAccessCasketRequest.Descriptor;
			}
		}

		// Token: 0x0601297D RID: 76157 RVA: 0x002B64A0 File Offset: 0x002B46A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketRequest()
		{
		}

		// Token: 0x0601297E RID: 76158 RVA: 0x002B64B4 File Offset: 0x002B46B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketRequest(PlayerAccessCasketRequest other) : this()
		{
			this.accessEntityIncIds_ = other.accessEntityIncIds_.Clone();
			this.isEnter_ = other.isEnter_;
			this.casketEntityIncId_ = other.casketEntityIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601297F RID: 76159 RVA: 0x002B6501 File Offset: 0x002B4701
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAccessCasketRequest Clone()
		{
			return new PlayerAccessCasketRequest(this);
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x06012980 RID: 76160 RVA: 0x002B6509 File Offset: 0x002B4709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> AccessEntityIncIds
		{
			get
			{
				return this.accessEntityIncIds_;
			}
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x06012981 RID: 76161 RVA: 0x002B6511 File Offset: 0x002B4711
		// (set) Token: 0x06012982 RID: 76162 RVA: 0x002B6519 File Offset: 0x002B4719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x06012983 RID: 76163 RVA: 0x002B6522 File Offset: 0x002B4722
		// (set) Token: 0x06012984 RID: 76164 RVA: 0x002B652A File Offset: 0x002B472A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CasketEntityIncId
		{
			get
			{
				return this.casketEntityIncId_;
			}
			set
			{
				this.casketEntityIncId_ = value;
			}
		}

		// Token: 0x06012985 RID: 76165 RVA: 0x002B6533 File Offset: 0x002B4733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAccessCasketRequest);
		}

		// Token: 0x06012986 RID: 76166 RVA: 0x002B6544 File Offset: 0x002B4744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAccessCasketRequest other)
		{
			return other != null && (other == this || (this.accessEntityIncIds_.Equals(other.accessEntityIncIds_) && this.IsEnter == other.IsEnter && this.CasketEntityIncId == other.CasketEntityIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012987 RID: 76167 RVA: 0x002B65A4 File Offset: 0x002B47A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.accessEntityIncIds_.GetHashCode();
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this.CasketEntityIncId != 0L)
			{
				num ^= this.CasketEntityIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012988 RID: 76168 RVA: 0x002B660A File Offset: 0x002B480A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012989 RID: 76169 RVA: 0x002B6617 File Offset: 0x002B4817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601298A RID: 76170 RVA: 0x002B6620 File Offset: 0x002B4820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CasketEntityIncId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CasketEntityIncId);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsEnter);
			}
			this.accessEntityIncIds_.WriteTo(ref output, PlayerAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601298B RID: 76171 RVA: 0x002B668C File Offset: 0x002B488C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.accessEntityIncIds_.CalculateSize(PlayerAccessCasketRequest._repeated_accessEntityIncIds_codec);
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this.CasketEntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CasketEntityIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601298C RID: 76172 RVA: 0x002B66EC File Offset: 0x002B48EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAccessCasketRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.accessEntityIncIds_.Add(other.accessEntityIncIds_);
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			if (other.CasketEntityIncId != 0L)
			{
				this.CasketEntityIncId = other.CasketEntityIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601298D RID: 76173 RVA: 0x002B674D File Offset: 0x002B494D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601298E RID: 76174 RVA: 0x002B6758 File Offset: 0x002B4958
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
				if (num <= 96U)
				{
					if (num == 24U)
					{
						this.CasketEntityIncId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.IsEnter = input.ReadBool();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.accessEntityIncIds_.AddEntriesFrom(ref input, PlayerAccessCasketRequest._repeated_accessEntityIncIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007369 RID: 29545
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400736A RID: 29546
		public const int AccessEntityIncIdsFieldNumber = 15;

		// Token: 0x0400736B RID: 29547
		private static readonly FieldCodec<long> _repeated_accessEntityIncIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x0400736C RID: 29548
		private readonly RepeatedField<long> accessEntityIncIds_ = new RepeatedField<long>();

		// Token: 0x0400736D RID: 29549
		public const int IsEnterFieldNumber = 12;

		// Token: 0x0400736E RID: 29550
		private bool isEnter_;

		// Token: 0x0400736F RID: 29551
		public const int CasketEntityIncIdFieldNumber = 3;

		// Token: 0x04007370 RID: 29552
		private long casketEntityIncId_;
	}
}
