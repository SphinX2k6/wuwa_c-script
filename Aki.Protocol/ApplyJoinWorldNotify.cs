using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000105 RID: 261
	[NetMessage(EMessageId.ApplyJoinWorldNotify)]
	public sealed class ApplyJoinWorldNotify : IMessage<ApplyJoinWorldNotify>, IMessage, IEquatable<ApplyJoinWorldNotify>, IDeepCloneable<ApplyJoinWorldNotify>, IBufferMessage
	{
		// Token: 0x060024CB RID: 9419 RVA: 0x00062745 File Offset: 0x00060945
		[NullableContext(1)]
		public static ApplyJoinWorldNotify Create()
		{
			return new ApplyJoinWorldNotify();
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060024CC RID: 9420 RVA: 0x0006274C File Offset: 0x0006094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ApplyJoinWorldNotify> Parser
		{
			get
			{
				return ApplyJoinWorldNotify._parser;
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060024CD RID: 9421 RVA: 0x00062753 File Offset: 0x00060953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060024CE RID: 9422 RVA: 0x00062756 File Offset: 0x00060956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyJoinWorldNotify.Descriptor;
			}
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x00062760 File Offset: 0x00060960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldNotify()
		{
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x000627C0 File Offset: 0x000609C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldNotify(ApplyJoinWorldNotify other) : this()
		{
			this.playerId_ = other.playerId_;
			this.refuseTimestamp_ = other.refuseTimestamp_;
			this.playerName_ = other.playerName_;
			this.headId_ = other.headId_;
			this.level_ = other.level_;
			this.psnUserId_ = other.psnUserId_;
			this.psnOnlineId_ = other.psnOnlineId_;
			this.psnAccountId_ = other.psnAccountId_;
			this.xboxUserId_ = other.xboxUserId_;
			this.xboxOnlineId_ = other.xboxOnlineId_;
			this.xboxAccountId_ = other.xboxAccountId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x00062868 File Offset: 0x00060A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldNotify Clone()
		{
			return new ApplyJoinWorldNotify(this);
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060024D2 RID: 9426 RVA: 0x00062870 File Offset: 0x00060A70
		// (set) Token: 0x060024D3 RID: 9427 RVA: 0x00062878 File Offset: 0x00060A78
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060024D4 RID: 9428 RVA: 0x00062881 File Offset: 0x00060A81
		// (set) Token: 0x060024D5 RID: 9429 RVA: 0x00062889 File Offset: 0x00060A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RefuseTimestamp
		{
			get
			{
				return this.refuseTimestamp_;
			}
			set
			{
				this.refuseTimestamp_ = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060024D6 RID: 9430 RVA: 0x00062892 File Offset: 0x00060A92
		// (set) Token: 0x060024D7 RID: 9431 RVA: 0x0006289A File Offset: 0x00060A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PlayerName
		{
			get
			{
				return this.playerName_;
			}
			set
			{
				this.playerName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060024D8 RID: 9432 RVA: 0x000628AD File Offset: 0x00060AAD
		// (set) Token: 0x060024D9 RID: 9433 RVA: 0x000628B5 File Offset: 0x00060AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadId
		{
			get
			{
				return this.headId_;
			}
			set
			{
				this.headId_ = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060024DA RID: 9434 RVA: 0x000628BE File Offset: 0x00060ABE
		// (set) Token: 0x060024DB RID: 9435 RVA: 0x000628C6 File Offset: 0x00060AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060024DC RID: 9436 RVA: 0x000628CF File Offset: 0x00060ACF
		// (set) Token: 0x060024DD RID: 9437 RVA: 0x000628D7 File Offset: 0x00060AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnUserId
		{
			get
			{
				return this.psnUserId_;
			}
			set
			{
				this.psnUserId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060024DE RID: 9438 RVA: 0x000628EA File Offset: 0x00060AEA
		// (set) Token: 0x060024DF RID: 9439 RVA: 0x000628F2 File Offset: 0x00060AF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnOnlineId
		{
			get
			{
				return this.psnOnlineId_;
			}
			set
			{
				this.psnOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060024E0 RID: 9440 RVA: 0x00062905 File Offset: 0x00060B05
		// (set) Token: 0x060024E1 RID: 9441 RVA: 0x0006290D File Offset: 0x00060B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string PsnAccountId
		{
			get
			{
				return this.psnAccountId_;
			}
			set
			{
				this.psnAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060024E2 RID: 9442 RVA: 0x00062920 File Offset: 0x00060B20
		// (set) Token: 0x060024E3 RID: 9443 RVA: 0x00062928 File Offset: 0x00060B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxUserId
		{
			get
			{
				return this.xboxUserId_;
			}
			set
			{
				this.xboxUserId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060024E4 RID: 9444 RVA: 0x0006293B File Offset: 0x00060B3B
		// (set) Token: 0x060024E5 RID: 9445 RVA: 0x00062943 File Offset: 0x00060B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxOnlineId
		{
			get
			{
				return this.xboxOnlineId_;
			}
			set
			{
				this.xboxOnlineId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060024E6 RID: 9446 RVA: 0x00062956 File Offset: 0x00060B56
		// (set) Token: 0x060024E7 RID: 9447 RVA: 0x0006295E File Offset: 0x00060B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string XboxAccountId
		{
			get
			{
				return this.xboxAccountId_;
			}
			set
			{
				this.xboxAccountId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060024E8 RID: 9448 RVA: 0x00062971 File Offset: 0x00060B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyJoinWorldNotify);
		}

		// Token: 0x060024E9 RID: 9449 RVA: 0x00062980 File Offset: 0x00060B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyJoinWorldNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RefuseTimestamp == other.RefuseTimestamp && !(this.PlayerName != other.PlayerName) && this.HeadId == other.HeadId && this.Level == other.Level && !(this.PsnUserId != other.PsnUserId) && !(this.PsnOnlineId != other.PsnOnlineId) && !(this.PsnAccountId != other.PsnAccountId) && !(this.XboxUserId != other.XboxUserId) && !(this.XboxOnlineId != other.XboxOnlineId) && !(this.XboxAccountId != other.XboxAccountId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024EA RID: 9450 RVA: 0x00062A7C File Offset: 0x00060C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.RefuseTimestamp != 0L)
			{
				num ^= this.RefuseTimestamp.GetHashCode();
			}
			if (this.PlayerName.Length != 0)
			{
				num ^= this.PlayerName.GetHashCode();
			}
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.PsnUserId.Length != 0)
			{
				num ^= this.PsnUserId.GetHashCode();
			}
			if (this.PsnOnlineId.Length != 0)
			{
				num ^= this.PsnOnlineId.GetHashCode();
			}
			if (this.PsnAccountId.Length != 0)
			{
				num ^= this.PsnAccountId.GetHashCode();
			}
			if (this.XboxUserId.Length != 0)
			{
				num ^= this.XboxUserId.GetHashCode();
			}
			if (this.XboxOnlineId.Length != 0)
			{
				num ^= this.XboxOnlineId.GetHashCode();
			}
			if (this.XboxAccountId.Length != 0)
			{
				num ^= this.XboxAccountId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024EB RID: 9451 RVA: 0x00062BC3 File Offset: 0x00060DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060024EC RID: 9452 RVA: 0x00062BD0 File Offset: 0x00060DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00062BDC File Offset: 0x00060DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.XboxOnlineId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(this.XboxOnlineId);
			}
			if (this.HeadId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HeadId);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Level);
			}
			if (this.PsnAccountId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.PsnAccountId);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(this.PsnOnlineId);
			}
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.PlayerName);
			}
			if (this.PsnUserId.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.PsnUserId);
			}
			if (this.XboxAccountId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.XboxAccountId);
			}
			if (this.RefuseTimestamp != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.RefuseTimestamp);
			}
			if (this.XboxUserId.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.XboxUserId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00062D54 File Offset: 0x00060F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.RefuseTimestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefuseTimestamp);
			}
			if (this.PlayerName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PlayerName);
			}
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.PsnUserId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnUserId);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnOnlineId);
			}
			if (this.PsnAccountId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.PsnAccountId);
			}
			if (this.XboxUserId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxUserId);
			}
			if (this.XboxOnlineId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxOnlineId);
			}
			if (this.XboxAccountId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.XboxAccountId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00062EA8 File Offset: 0x000610A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ApplyJoinWorldNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.RefuseTimestamp != 0L)
			{
				this.RefuseTimestamp = other.RefuseTimestamp;
			}
			if (other.PlayerName.Length != 0)
			{
				this.PlayerName = other.PlayerName;
			}
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.PsnUserId.Length != 0)
			{
				this.PsnUserId = other.PsnUserId;
			}
			if (other.PsnOnlineId.Length != 0)
			{
				this.PsnOnlineId = other.PsnOnlineId;
			}
			if (other.PsnAccountId.Length != 0)
			{
				this.PsnAccountId = other.PsnAccountId;
			}
			if (other.XboxUserId.Length != 0)
			{
				this.XboxUserId = other.XboxUserId;
			}
			if (other.XboxOnlineId.Length != 0)
			{
				this.XboxOnlineId = other.XboxOnlineId;
			}
			if (other.XboxAccountId.Length != 0)
			{
				this.XboxAccountId = other.XboxAccountId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00062FCF File Offset: 0x000611CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00062FD8 File Offset: 0x000611D8
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
				if (num <= 50U)
				{
					if (num <= 16U)
					{
						if (num == 10U)
						{
							this.XboxOnlineId = input.ReadString();
							continue;
						}
						if (num == 16U)
						{
							this.HeadId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.PlayerId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 50U)
						{
							this.PsnAccountId = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 74U)
				{
					if (num == 58U)
					{
						this.PsnOnlineId = input.ReadString();
						continue;
					}
					if (num == 66U)
					{
						this.PlayerName = input.ReadString();
						continue;
					}
					if (num == 74U)
					{
						this.PsnUserId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						this.XboxAccountId = input.ReadString();
						continue;
					}
					if (num == 112U)
					{
						this.RefuseTimestamp = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						this.XboxUserId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040025D9 RID: 9689
		private static readonly MessageParser<ApplyJoinWorldNotify> _parser = new MessageParser<ApplyJoinWorldNotify>(() => new ApplyJoinWorldNotify());

		// Token: 0x040025DA RID: 9690
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025DB RID: 9691
		public const int PlayerIdFieldNumber = 4;

		// Token: 0x040025DC RID: 9692
		private int playerId_;

		// Token: 0x040025DD RID: 9693
		public const int RefuseTimestampFieldNumber = 14;

		// Token: 0x040025DE RID: 9694
		private long refuseTimestamp_;

		// Token: 0x040025DF RID: 9695
		public const int PlayerNameFieldNumber = 8;

		// Token: 0x040025E0 RID: 9696
		private string playerName_ = "";

		// Token: 0x040025E1 RID: 9697
		public const int HeadIdFieldNumber = 2;

		// Token: 0x040025E2 RID: 9698
		private int headId_;

		// Token: 0x040025E3 RID: 9699
		public const int LevelFieldNumber = 5;

		// Token: 0x040025E4 RID: 9700
		private int level_;

		// Token: 0x040025E5 RID: 9701
		public const int PsnUserIdFieldNumber = 9;

		// Token: 0x040025E6 RID: 9702
		private string psnUserId_ = "";

		// Token: 0x040025E7 RID: 9703
		public const int PsnOnlineIdFieldNumber = 7;

		// Token: 0x040025E8 RID: 9704
		private string psnOnlineId_ = "";

		// Token: 0x040025E9 RID: 9705
		public const int PsnAccountIdFieldNumber = 6;

		// Token: 0x040025EA RID: 9706
		private string psnAccountId_ = "";

		// Token: 0x040025EB RID: 9707
		public const int XboxUserIdFieldNumber = 15;

		// Token: 0x040025EC RID: 9708
		private string xboxUserId_ = "";

		// Token: 0x040025ED RID: 9709
		public const int XboxOnlineIdFieldNumber = 1;

		// Token: 0x040025EE RID: 9710
		private string xboxOnlineId_ = "";

		// Token: 0x040025EF RID: 9711
		public const int XboxAccountIdFieldNumber = 10;

		// Token: 0x040025F0 RID: 9712
		private string xboxAccountId_ = "";
	}
}
