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
		// Token: 0x06002494 RID: 9364 RVA: 0x00061C71 File Offset: 0x0005FE71
		[NullableContext(1)]
		public static ApplyJoinWorldNotify Create()
		{
			return new ApplyJoinWorldNotify();
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x00061C78 File Offset: 0x0005FE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ApplyJoinWorldNotify> Parser
		{
			get
			{
				return ApplyJoinWorldNotify._parser;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002496 RID: 9366 RVA: 0x00061C7F File Offset: 0x0005FE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x00061C82 File Offset: 0x0005FE82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ApplyJoinWorldNotify.Descriptor;
			}
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00061C8C File Offset: 0x0005FE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldNotify()
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00061CEC File Offset: 0x0005FEEC
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

		// Token: 0x0600249A RID: 9370 RVA: 0x00061D94 File Offset: 0x0005FF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ApplyJoinWorldNotify Clone()
		{
			return new ApplyJoinWorldNotify(this);
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x00061D9C File Offset: 0x0005FF9C
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x00061DA4 File Offset: 0x0005FFA4
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

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600249D RID: 9373 RVA: 0x00061DAD File Offset: 0x0005FFAD
		// (set) Token: 0x0600249E RID: 9374 RVA: 0x00061DB5 File Offset: 0x0005FFB5
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

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600249F RID: 9375 RVA: 0x00061DBE File Offset: 0x0005FFBE
		// (set) Token: 0x060024A0 RID: 9376 RVA: 0x00061DC6 File Offset: 0x0005FFC6
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

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060024A1 RID: 9377 RVA: 0x00061DD9 File Offset: 0x0005FFD9
		// (set) Token: 0x060024A2 RID: 9378 RVA: 0x00061DE1 File Offset: 0x0005FFE1
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

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060024A3 RID: 9379 RVA: 0x00061DEA File Offset: 0x0005FFEA
		// (set) Token: 0x060024A4 RID: 9380 RVA: 0x00061DF2 File Offset: 0x0005FFF2
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

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x00061DFB File Offset: 0x0005FFFB
		// (set) Token: 0x060024A6 RID: 9382 RVA: 0x00061E03 File Offset: 0x00060003
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

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x00061E16 File Offset: 0x00060016
		// (set) Token: 0x060024A8 RID: 9384 RVA: 0x00061E1E File Offset: 0x0006001E
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

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x060024A9 RID: 9385 RVA: 0x00061E31 File Offset: 0x00060031
		// (set) Token: 0x060024AA RID: 9386 RVA: 0x00061E39 File Offset: 0x00060039
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

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x00061E4C File Offset: 0x0006004C
		// (set) Token: 0x060024AC RID: 9388 RVA: 0x00061E54 File Offset: 0x00060054
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

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060024AD RID: 9389 RVA: 0x00061E67 File Offset: 0x00060067
		// (set) Token: 0x060024AE RID: 9390 RVA: 0x00061E6F File Offset: 0x0006006F
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060024AF RID: 9391 RVA: 0x00061E82 File Offset: 0x00060082
		// (set) Token: 0x060024B0 RID: 9392 RVA: 0x00061E8A File Offset: 0x0006008A
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

		// Token: 0x060024B1 RID: 9393 RVA: 0x00061E9D File Offset: 0x0006009D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ApplyJoinWorldNotify);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00061EAC File Offset: 0x000600AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ApplyJoinWorldNotify other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.RefuseTimestamp == other.RefuseTimestamp && !(this.PlayerName != other.PlayerName) && this.HeadId == other.HeadId && this.Level == other.Level && !(this.PsnUserId != other.PsnUserId) && !(this.PsnOnlineId != other.PsnOnlineId) && !(this.PsnAccountId != other.PsnAccountId) && !(this.XboxUserId != other.XboxUserId) && !(this.XboxOnlineId != other.XboxOnlineId) && !(this.XboxAccountId != other.XboxAccountId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00061FA8 File Offset: 0x000601A8
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

		// Token: 0x060024B4 RID: 9396 RVA: 0x000620EF File Offset: 0x000602EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x000620FC File Offset: 0x000602FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00062108 File Offset: 0x00060308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PsnAccountId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.PsnAccountId);
			}
			if (this.PsnUserId.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.PsnUserId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Level);
			}
			if (this.XboxOnlineId.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.XboxOnlineId);
			}
			if (this.XboxUserId.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.XboxUserId);
			}
			if (this.HeadId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.HeadId);
			}
			if (this.PsnOnlineId.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.PsnOnlineId);
			}
			if (this.XboxAccountId.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.XboxAccountId);
			}
			if (this.PlayerName.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(this.PlayerName);
			}
			if (this.RefuseTimestamp != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.RefuseTimestamp);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x00062280 File Offset: 0x00060480
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

		// Token: 0x060024B8 RID: 9400 RVA: 0x000623D4 File Offset: 0x000605D4
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

		// Token: 0x060024B9 RID: 9401 RVA: 0x000624FB File Offset: 0x000606FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00062504 File Offset: 0x00060704
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
					if (num <= 26U)
					{
						if (num == 18U)
						{
							this.PsnAccountId = input.ReadString();
							continue;
						}
						if (num == 26U)
						{
							this.PsnUserId = input.ReadString();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.Level = input.ReadInt32();
							continue;
						}
						if (num == 42U)
						{
							this.XboxOnlineId = input.ReadString();
							continue;
						}
						if (num == 50U)
						{
							this.XboxUserId = input.ReadString();
							continue;
						}
					}
				}
				else if (num <= 82U)
				{
					if (num == 64U)
					{
						this.HeadId = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.PsnOnlineId = input.ReadString();
						continue;
					}
					if (num == 82U)
					{
						this.XboxAccountId = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.PlayerName = input.ReadString();
						continue;
					}
					if (num == 104U)
					{
						this.RefuseTimestamp = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400257A RID: 9594
		private static readonly MessageParser<ApplyJoinWorldNotify> _parser = new MessageParser<ApplyJoinWorldNotify>(() => new ApplyJoinWorldNotify());

		// Token: 0x0400257B RID: 9595
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400257C RID: 9596
		public const int PlayerIdFieldNumber = 15;

		// Token: 0x0400257D RID: 9597
		private int playerId_;

		// Token: 0x0400257E RID: 9598
		public const int RefuseTimestampFieldNumber = 13;

		// Token: 0x0400257F RID: 9599
		private long refuseTimestamp_;

		// Token: 0x04002580 RID: 9600
		public const int PlayerNameFieldNumber = 11;

		// Token: 0x04002581 RID: 9601
		private string playerName_ = "";

		// Token: 0x04002582 RID: 9602
		public const int HeadIdFieldNumber = 8;

		// Token: 0x04002583 RID: 9603
		private int headId_;

		// Token: 0x04002584 RID: 9604
		public const int LevelFieldNumber = 4;

		// Token: 0x04002585 RID: 9605
		private int level_;

		// Token: 0x04002586 RID: 9606
		public const int PsnUserIdFieldNumber = 3;

		// Token: 0x04002587 RID: 9607
		private string psnUserId_ = "";

		// Token: 0x04002588 RID: 9608
		public const int PsnOnlineIdFieldNumber = 9;

		// Token: 0x04002589 RID: 9609
		private string psnOnlineId_ = "";

		// Token: 0x0400258A RID: 9610
		public const int PsnAccountIdFieldNumber = 2;

		// Token: 0x0400258B RID: 9611
		private string psnAccountId_ = "";

		// Token: 0x0400258C RID: 9612
		public const int XboxUserIdFieldNumber = 6;

		// Token: 0x0400258D RID: 9613
		private string xboxUserId_ = "";

		// Token: 0x0400258E RID: 9614
		public const int XboxOnlineIdFieldNumber = 5;

		// Token: 0x0400258F RID: 9615
		private string xboxOnlineId_ = "";

		// Token: 0x04002590 RID: 9616
		public const int XboxAccountIdFieldNumber = 10;

		// Token: 0x04002591 RID: 9617
		private string xboxAccountId_ = "";
	}
}
