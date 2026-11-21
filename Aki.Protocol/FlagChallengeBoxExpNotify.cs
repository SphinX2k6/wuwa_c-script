using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200057F RID: 1407
	[NetMessage(EMessageId.FlagChallengeBoxExpNotify)]
	public sealed class FlagChallengeBoxExpNotify : IMessage<FlagChallengeBoxExpNotify>, IMessage, IEquatable<FlagChallengeBoxExpNotify>, IDeepCloneable<FlagChallengeBoxExpNotify>, IBufferMessage
	{
		// Token: 0x060082E1 RID: 33505 RVA: 0x0013B9EC File Offset: 0x00139BEC
		[NullableContext(1)]
		public static FlagChallengeBoxExpNotify Create()
		{
			return new FlagChallengeBoxExpNotify();
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x0013B9F3 File Offset: 0x00139BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x060082E3 RID: 33507 RVA: 0x0013B9F6 File Offset: 0x00139BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeBoxExpNotify.Descriptor;
			}
		}

		// Token: 0x060082E4 RID: 33508 RVA: 0x0013B9FD File Offset: 0x00139BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeBoxExpNotify()
		{
		}

		// Token: 0x060082E5 RID: 33509 RVA: 0x0013BA05 File Offset: 0x00139C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeBoxExpNotify(FlagChallengeBoxExpNotify other) : this()
		{
			this.challengeLevelId_ = other.challengeLevelId_;
			this.boxExp_ = other.boxExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082E6 RID: 33510 RVA: 0x0013BA36 File Offset: 0x00139C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeBoxExpNotify Clone()
		{
			return new FlagChallengeBoxExpNotify(this);
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x060082E7 RID: 33511 RVA: 0x0013BA3E File Offset: 0x00139C3E
		// (set) Token: 0x060082E8 RID: 33512 RVA: 0x0013BA46 File Offset: 0x00139C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeLevelId
		{
			get
			{
				return this.challengeLevelId_;
			}
			set
			{
				this.challengeLevelId_ = value;
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x060082E9 RID: 33513 RVA: 0x0013BA4F File Offset: 0x00139C4F
		// (set) Token: 0x060082EA RID: 33514 RVA: 0x0013BA57 File Offset: 0x00139C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BoxExp
		{
			get
			{
				return this.boxExp_;
			}
			set
			{
				this.boxExp_ = value;
			}
		}

		// Token: 0x060082EB RID: 33515 RVA: 0x0013BA60 File Offset: 0x00139C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeBoxExpNotify);
		}

		// Token: 0x060082EC RID: 33516 RVA: 0x0013BA6E File Offset: 0x00139C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeBoxExpNotify other)
		{
			return other != null && (other == this || (this.ChallengeLevelId == other.ChallengeLevelId && this.BoxExp == other.BoxExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082ED RID: 33517 RVA: 0x0013BAAC File Offset: 0x00139CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeLevelId != 0)
			{
				num ^= this.ChallengeLevelId.GetHashCode();
			}
			if (this.BoxExp != 0)
			{
				num ^= this.BoxExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060082EE RID: 33518 RVA: 0x0013BB04 File Offset: 0x00139D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060082EF RID: 33519 RVA: 0x0013BB11 File Offset: 0x00139D11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060082F0 RID: 33520 RVA: 0x0013BB1C File Offset: 0x00139D1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BoxExp != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.BoxExp);
			}
			if (this.ChallengeLevelId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ChallengeLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060082F1 RID: 33521 RVA: 0x0013BB78 File Offset: 0x00139D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeLevelId);
			}
			if (this.BoxExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BoxExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060082F2 RID: 33522 RVA: 0x0013BBD0 File Offset: 0x00139DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeBoxExpNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeLevelId != 0)
			{
				this.ChallengeLevelId = other.ChallengeLevelId;
			}
			if (other.BoxExp != 0)
			{
				this.BoxExp = other.BoxExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060082F3 RID: 33523 RVA: 0x0013BC20 File Offset: 0x00139E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060082F4 RID: 33524 RVA: 0x0013BC2C File Offset: 0x00139E2C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ChallengeLevelId = input.ReadInt32();
					}
				}
				else
				{
					this.BoxExp = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041A6 RID: 16806
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041A7 RID: 16807
		public const int ChallengeLevelIdFieldNumber = 6;

		// Token: 0x040041A8 RID: 16808
		private int challengeLevelId_;

		// Token: 0x040041A9 RID: 16809
		public const int BoxExpFieldNumber = 4;

		// Token: 0x040041AA RID: 16810
		private int boxExp_;
	}
}
