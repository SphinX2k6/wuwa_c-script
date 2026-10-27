using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED1 RID: 3793
	public sealed class RecentlyTeamInfo : IMessage<RecentlyTeamInfo>, IMessage, IEquatable<RecentlyTeamInfo>, IDeepCloneable<RecentlyTeamInfo>, IBufferMessage
	{
		// Token: 0x06014548 RID: 83272 RVA: 0x002F42A9 File Offset: 0x002F24A9
		[NullableContext(1)]
		public static RecentlyTeamInfo Create()
		{
			return new RecentlyTeamInfo();
		}

		// Token: 0x17004391 RID: 17297
		// (get) Token: 0x06014549 RID: 83273 RVA: 0x002F42B0 File Offset: 0x002F24B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecentlyTeamInfo> Parser
		{
			get
			{
				return RecentlyTeamInfo._parser;
			}
		}

		// Token: 0x17004392 RID: 17298
		// (get) Token: 0x0601454A RID: 83274 RVA: 0x002F42B7 File Offset: 0x002F24B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004393 RID: 17299
		// (get) Token: 0x0601454B RID: 83275 RVA: 0x002F42BA File Offset: 0x002F24BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecentlyTeamInfo.Descriptor;
			}
		}

		// Token: 0x0601454C RID: 83276 RVA: 0x002F42C1 File Offset: 0x002F24C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecentlyTeamInfo()
		{
		}

		// Token: 0x0601454D RID: 83277 RVA: 0x002F42CC File Offset: 0x002F24CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecentlyTeamInfo(RecentlyTeamInfo other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.teamTime_ = other.teamTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601454E RID: 83278 RVA: 0x002F4318 File Offset: 0x002F2518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecentlyTeamInfo Clone()
		{
			return new RecentlyTeamInfo(this);
		}

		// Token: 0x17004394 RID: 17300
		// (get) Token: 0x0601454F RID: 83279 RVA: 0x002F4320 File Offset: 0x002F2520
		// (set) Token: 0x06014550 RID: 83280 RVA: 0x002F4328 File Offset: 0x002F2528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetails Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x17004395 RID: 17301
		// (get) Token: 0x06014551 RID: 83281 RVA: 0x002F4331 File Offset: 0x002F2531
		// (set) Token: 0x06014552 RID: 83282 RVA: 0x002F4339 File Offset: 0x002F2539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TeamTime
		{
			get
			{
				return this.teamTime_;
			}
			set
			{
				this.teamTime_ = value;
			}
		}

		// Token: 0x06014553 RID: 83283 RVA: 0x002F4342 File Offset: 0x002F2542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecentlyTeamInfo);
		}

		// Token: 0x06014554 RID: 83284 RVA: 0x002F4350 File Offset: 0x002F2550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecentlyTeamInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && this.TeamTime == other.TeamTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014555 RID: 83285 RVA: 0x002F43A0 File Offset: 0x002F25A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.TeamTime != 0L)
			{
				num ^= this.TeamTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014556 RID: 83286 RVA: 0x002F43F5 File Offset: 0x002F25F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014557 RID: 83287 RVA: 0x002F4402 File Offset: 0x002F2602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014558 RID: 83288 RVA: 0x002F440C File Offset: 0x002F260C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Info);
			}
			if (this.TeamTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TeamTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014559 RID: 83289 RVA: 0x002F4468 File Offset: 0x002F2668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.TeamTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TeamTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601455A RID: 83290 RVA: 0x002F44C0 File Offset: 0x002F26C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecentlyTeamInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new PlayerDetails();
				}
				this.Info.MergeFrom(other.Info);
			}
			if (other.TeamTime != 0L)
			{
				this.TeamTime = other.TeamTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601455B RID: 83291 RVA: 0x002F4528 File Offset: 0x002F2728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601455C RID: 83292 RVA: 0x002F4534 File Offset: 0x002F2734
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TeamTime = input.ReadInt64();
					}
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new PlayerDetails();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x04007B6D RID: 31597
		private static readonly MessageParser<RecentlyTeamInfo> _parser = new MessageParser<RecentlyTeamInfo>(() => new RecentlyTeamInfo());

		// Token: 0x04007B6E RID: 31598
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B6F RID: 31599
		public const int InfoFieldNumber = 1;

		// Token: 0x04007B70 RID: 31600
		private PlayerDetails info_;

		// Token: 0x04007B71 RID: 31601
		public const int TeamTimeFieldNumber = 2;

		// Token: 0x04007B72 RID: 31602
		private long teamTime_;
	}
}
