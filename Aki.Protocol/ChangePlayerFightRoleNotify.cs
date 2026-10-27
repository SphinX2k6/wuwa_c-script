using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000257 RID: 599
	[NetMessage(EMessageId.ChangePlayerFightRoleNotify)]
	public sealed class ChangePlayerFightRoleNotify : IMessage<ChangePlayerFightRoleNotify>, IMessage, IEquatable<ChangePlayerFightRoleNotify>, IDeepCloneable<ChangePlayerFightRoleNotify>, IBufferMessage
	{
		// Token: 0x06003FA9 RID: 16297 RVA: 0x0009C900 File Offset: 0x0009AB00
		[NullableContext(1)]
		public static ChangePlayerFightRoleNotify Create()
		{
			return new ChangePlayerFightRoleNotify();
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06003FAA RID: 16298 RVA: 0x0009C907 File Offset: 0x0009AB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x0009C90A File Offset: 0x0009AB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePlayerFightRoleNotify.Descriptor;
			}
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x0009C911 File Offset: 0x0009AB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerFightRoleNotify()
		{
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x0009C924 File Offset: 0x0009AB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerFightRoleNotify(ChangePlayerFightRoleNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.fightRoleInfos_ = other.fightRoleInfos_.Clone();
			this.isPhantom_ = other.isPhantom_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x0009C971 File Offset: 0x0009AB71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePlayerFightRoleNotify Clone()
		{
			return new ChangePlayerFightRoleNotify(this);
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x0009C979 File Offset: 0x0009AB79
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x0009C981 File Offset: 0x0009AB81
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

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x0009C98A File Offset: 0x0009AB8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FightRoleInformation> FightRoleInfos
		{
			get
			{
				return this.fightRoleInfos_;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x0009C992 File Offset: 0x0009AB92
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x0009C99A File Offset: 0x0009AB9A
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

		// Token: 0x06003FB4 RID: 16308 RVA: 0x0009C9A3 File Offset: 0x0009ABA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePlayerFightRoleNotify);
		}

		// Token: 0x06003FB5 RID: 16309 RVA: 0x0009C9B4 File Offset: 0x0009ABB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePlayerFightRoleNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.fightRoleInfos_.Equals(other.fightRoleInfos_) && this.IsPhantom == other.IsPhantom && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FB6 RID: 16310 RVA: 0x0009CA14 File Offset: 0x0009AC14
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

		// Token: 0x06003FB7 RID: 16311 RVA: 0x0009CA7A File Offset: 0x0009AC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x0009CA87 File Offset: 0x0009AC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FB9 RID: 16313 RVA: 0x0009CA90 File Offset: 0x0009AC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.IsPhantom)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsPhantom);
			}
			this.fightRoleInfos_.WriteTo(ref output, ChangePlayerFightRoleNotify._repeated_fightRoleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x0009CAFC File Offset: 0x0009ACFC
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

		// Token: 0x06003FBB RID: 16315 RVA: 0x0009CB5C File Offset: 0x0009AD5C
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

		// Token: 0x06003FBC RID: 16316 RVA: 0x0009CBBD File Offset: 0x0009ADBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FBD RID: 16317 RVA: 0x0009CBC8 File Offset: 0x0009ADC8
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
					if (num != 48U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D2E RID: 11566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D2F RID: 11567
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x04002D30 RID: 11568
		private int playerId_;

		// Token: 0x04002D31 RID: 11569
		public const int FightRoleInfosFieldNumber = 11;

		// Token: 0x04002D32 RID: 11570
		private static readonly FieldCodec<FightRoleInformation> _repeated_fightRoleInfos_codec = FieldCodec.ForMessage<FightRoleInformation>(90U, FightRoleInformation.Parser);

		// Token: 0x04002D33 RID: 11571
		private readonly RepeatedField<FightRoleInformation> fightRoleInfos_ = new RepeatedField<FightRoleInformation>();

		// Token: 0x04002D34 RID: 11572
		public const int IsPhantomFieldNumber = 6;

		// Token: 0x04002D35 RID: 11573
		private bool isPhantom_;
	}
}
