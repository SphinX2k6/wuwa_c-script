using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025C RID: 604
	[NetMessage(EMessageId.ChangePlayerFightRoleNotify)]
	public sealed class ChangePlayerFightRoleNotify : IMessage<ChangePlayerFightRoleNotify>, IMessage, IEquatable<ChangePlayerFightRoleNotify>, IDeepCloneable<ChangePlayerFightRoleNotify>, IBufferMessage
	{
		// Token: 0x06004050 RID: 16464 RVA: 0x0009E5C8 File Offset: 0x0009C7C8
		[NullableContext(1)]
		public static ChangePlayerFightRoleNotify Create()
		{
			return new ChangePlayerFightRoleNotify();
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x0009E5CF File Offset: 0x0009C7CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x0009E5D2 File Offset: 0x0009C7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePlayerFightRoleNotify.Descriptor;
			}
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x0009E5D9 File Offset: 0x0009C7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerFightRoleNotify()
		{
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x0009E5EC File Offset: 0x0009C7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerFightRoleNotify(ChangePlayerFightRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightRoleInfos_ = other.fightRoleInfos_.Clone();
			this.isPhantom_ = other.isPhantom_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x0009E639 File Offset: 0x0009C839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerFightRoleNotify Clone()
		{
			return new ChangePlayerFightRoleNotify(this);
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x0009E641 File Offset: 0x0009C841
		// (set) Token: 0x06004057 RID: 16471 RVA: 0x0009E649 File Offset: 0x0009C849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06004058 RID: 16472 RVA: 0x0009E652 File Offset: 0x0009C852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightRoleInformation> FightRoleInfos
		{
			get
			{
				return this.fightRoleInfos_;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x0009E65A File Offset: 0x0009C85A
		// (set) Token: 0x0600405A RID: 16474 RVA: 0x0009E662 File Offset: 0x0009C862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPhantom
		{
			get
			{
				return this.isPhantom_;
			}
			set
			{
				this.isPhantom_ = value;
			}
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x0009E66B File Offset: 0x0009C86B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePlayerFightRoleNotify);
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x0009E67C File Offset: 0x0009C87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePlayerFightRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.fightRoleInfos_.Equals(other.fightRoleInfos_) && this.IsPhantom == other.IsPhantom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x0009E6DC File Offset: 0x0009C8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.fightRoleInfos_.GetHashCode();
			if (this.IsPhantom)
			{
				num ^= this.IsPhantom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x0009E742 File Offset: 0x0009C942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0009E74F File Offset: 0x0009C94F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x0009E758 File Offset: 0x0009C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsPhantom)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsPhantom);
			}
			this.fightRoleInfos_.WriteTo(ref output, ChangePlayerFightRoleNotify._repeated_fightRoleInfos_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004061 RID: 16481 RVA: 0x0009E7C4 File Offset: 0x0009C9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.fightRoleInfos_.CalculateSize(ChangePlayerFightRoleNotify._repeated_fightRoleInfos_codec);
			if (this.IsPhantom)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004062 RID: 16482 RVA: 0x0009E824 File Offset: 0x0009CA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePlayerFightRoleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.fightRoleInfos_.Add(other.fightRoleInfos_);
			if (other.IsPhantom)
			{
				this.IsPhantom = other.IsPhantom;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004063 RID: 16483 RVA: 0x0009E885 File Offset: 0x0009CA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004064 RID: 16484 RVA: 0x0009E890 File Offset: 0x0009CA90
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
				if (num != 24U)
				{
					if (num != 82U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PlayerId = input.ReadInt32();
						}
					}
					else
					{
						this.fightRoleInfos_.AddEntriesFrom(ref input, ChangePlayerFightRoleNotify._repeated_fightRoleInfos_codec);
					}
				}
				else
				{
					this.IsPhantom = input.ReadBool();
				}
			}
		}

		// Token: 0x04002DB2 RID: 11698
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DB3 RID: 11699
		public const int PlayerIdFieldNumber = 12;

		// Token: 0x04002DB4 RID: 11700
		private int playerId_;

		// Token: 0x04002DB5 RID: 11701
		public const int FightRoleInfosFieldNumber = 10;

		// Token: 0x04002DB6 RID: 11702
		private static readonly FieldCodec<FightRoleInformation> _repeated_fightRoleInfos_codec = FieldCodec.ForMessage<FightRoleInformation>(82U, FightRoleInformation.Parser);

		// Token: 0x04002DB7 RID: 11703
		private readonly RepeatedField<FightRoleInformation> fightRoleInfos_ = new RepeatedField<FightRoleInformation>();

		// Token: 0x04002DB8 RID: 11704
		public const int IsPhantomFieldNumber = 3;

		// Token: 0x04002DB9 RID: 11705
		private bool isPhantom_;
	}
}
