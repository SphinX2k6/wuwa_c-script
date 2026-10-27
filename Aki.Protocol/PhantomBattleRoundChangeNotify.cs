using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAC RID: 3244
	[NetMessage(EMessageId.PhantomBattleRoundChangeNotify)]
	public sealed class PhantomBattleRoundChangeNotify : IMessage<PhantomBattleRoundChangeNotify>, IMessage, IEquatable<PhantomBattleRoundChangeNotify>, IDeepCloneable<PhantomBattleRoundChangeNotify>, IBufferMessage
	{
		// Token: 0x06011937 RID: 71991 RVA: 0x00293041 File Offset: 0x00291241
		[NullableContext(1)]
		public static PhantomBattleRoundChangeNotify Create()
		{
			return new PhantomBattleRoundChangeNotify();
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x06011938 RID: 71992 RVA: 0x00293048 File Offset: 0x00291248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x06011939 RID: 71993 RVA: 0x0029304B File Offset: 0x0029124B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoundChangeNotify.Descriptor;
			}
		}

		// Token: 0x0601193A RID: 71994 RVA: 0x00293052 File Offset: 0x00291252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundChangeNotify()
		{
		}

		// Token: 0x0601193B RID: 71995 RVA: 0x00293070 File Offset: 0x00291270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundChangeNotify(PhantomBattleRoundChangeNotify other) : this()
		{
			this.roundNum_ = other.roundNum_;
			this.phantomBattleFighterInfo_ = other.phantomBattleFighterInfo_.Clone();
			this.sealInfos_ = other.sealInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601193C RID: 71996 RVA: 0x002930C2 File Offset: 0x002912C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundChangeNotify Clone()
		{
			return new PhantomBattleRoundChangeNotify(this);
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0601193D RID: 71997 RVA: 0x002930CA File Offset: 0x002912CA
		// (set) Token: 0x0601193E RID: 71998 RVA: 0x002930D2 File Offset: 0x002912D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoundNum
		{
			get
			{
				return this.roundNum_;
			}
			set
			{
				this.roundNum_ = value;
			}
		}

		// Token: 0x17003A3E RID: 14910
		// (get) Token: 0x0601193F RID: 71999 RVA: 0x002930DB File Offset: 0x002912DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x17003A3F RID: 14911
		// (get) Token: 0x06011940 RID: 72000 RVA: 0x002930E3 File Offset: 0x002912E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AreaSealInfo> SealInfos
		{
			get
			{
				return this.sealInfos_;
			}
		}

		// Token: 0x06011941 RID: 72001 RVA: 0x002930EB File Offset: 0x002912EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoundChangeNotify);
		}

		// Token: 0x06011942 RID: 72002 RVA: 0x002930FC File Offset: 0x002912FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoundChangeNotify other)
		{
			return other != null && (other == this || (this.RoundNum == other.RoundNum && this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.sealInfos_.Equals(other.sealInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011943 RID: 72003 RVA: 0x00293160 File Offset: 0x00291360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoundNum != 0)
			{
				num ^= this.RoundNum.GetHashCode();
			}
			num ^= this.phantomBattleFighterInfo_.GetHashCode();
			num ^= this.sealInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011944 RID: 72004 RVA: 0x002931BB File Offset: 0x002913BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011945 RID: 72005 RVA: 0x002931C8 File Offset: 0x002913C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011946 RID: 72006 RVA: 0x002931D4 File Offset: 0x002913D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.sealInfos_.WriteTo(ref output, PhantomBattleRoundChangeNotify._repeated_sealInfos_codec);
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleRoundChangeNotify._repeated_phantomBattleFighterInfo_codec);
			if (this.RoundNum != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.RoundNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011947 RID: 72007 RVA: 0x00293234 File Offset: 0x00291434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoundNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoundNum);
			}
			num += this.phantomBattleFighterInfo_.CalculateSize(PhantomBattleRoundChangeNotify._repeated_phantomBattleFighterInfo_codec);
			num += this.sealInfos_.CalculateSize(PhantomBattleRoundChangeNotify._repeated_sealInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011948 RID: 72008 RVA: 0x00293298 File Offset: 0x00291498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoundChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoundNum != 0)
			{
				this.RoundNum = other.RoundNum;
			}
			this.phantomBattleFighterInfo_.Add(other.phantomBattleFighterInfo_);
			this.sealInfos_.Add(other.sealInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011949 RID: 72009 RVA: 0x002932F6 File Offset: 0x002914F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601194A RID: 72010 RVA: 0x00293300 File Offset: 0x00291500
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
				if (num != 18U)
				{
					if (num != 58U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoundNum = input.ReadInt32();
						}
					}
					else
					{
						this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleRoundChangeNotify._repeated_phantomBattleFighterInfo_codec);
					}
				}
				else
				{
					this.sealInfos_.AddEntriesFrom(ref input, PhantomBattleRoundChangeNotify._repeated_sealInfos_codec);
				}
			}
		}

		// Token: 0x04006EC0 RID: 28352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EC1 RID: 28353
		public const int RoundNumFieldNumber = 12;

		// Token: 0x04006EC2 RID: 28354
		private int roundNum_;

		// Token: 0x04006EC3 RID: 28355
		public const int PhantomBattleFighterInfoFieldNumber = 7;

		// Token: 0x04006EC4 RID: 28356
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(58U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006EC5 RID: 28357
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006EC6 RID: 28358
		public const int SealInfosFieldNumber = 2;

		// Token: 0x04006EC7 RID: 28359
		private static readonly FieldCodec<AreaSealInfo> _repeated_sealInfos_codec = FieldCodec.ForMessage<AreaSealInfo>(18U, AreaSealInfo.Parser);

		// Token: 0x04006EC8 RID: 28360
		private readonly RepeatedField<AreaSealInfo> sealInfos_ = new RepeatedField<AreaSealInfo>();
	}
}
