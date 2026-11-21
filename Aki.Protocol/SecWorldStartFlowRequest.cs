using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F4 RID: 4596
	[NetMessage(EMessageId.SecWorldStartFlowRequest)]
	public sealed class SecWorldStartFlowRequest : IMessage<SecWorldStartFlowRequest>, IMessage, IEquatable<SecWorldStartFlowRequest>, IDeepCloneable<SecWorldStartFlowRequest>, IBufferMessage
	{
		// Token: 0x06018911 RID: 100625 RVA: 0x00395843 File Offset: 0x00393A43
		[NullableContext(1)]
		public static SecWorldStartFlowRequest Create()
		{
			return new SecWorldStartFlowRequest();
		}

		// Token: 0x170052FF RID: 21247
		// (get) Token: 0x06018912 RID: 100626 RVA: 0x0039584A File Offset: 0x00393A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005300 RID: 21248
		// (get) Token: 0x06018913 RID: 100627 RVA: 0x0039584D File Offset: 0x00393A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldStartFlowRequest.Descriptor;
			}
		}

		// Token: 0x06018914 RID: 100628 RVA: 0x00395854 File Offset: 0x00393A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowRequest()
		{
		}

		// Token: 0x06018915 RID: 100629 RVA: 0x00395868 File Offset: 0x00393A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowRequest(SecWorldStartFlowRequest other) : this()
		{
			this.logId_ = other.logId_;
			this.clientStartTime_ = other.clientStartTime_;
			this.srvFighter1Info_ = ((other.srvFighter1Info_ != null) ? other.srvFighter1Info_.Clone() : null);
			this.srvFighter2Info_ = ((other.srvFighter2Info_ != null) ? other.srvFighter2Info_.Clone() : null);
			this.srvFighter3Info_ = ((other.srvFighter3Info_ != null) ? other.srvFighter3Info_.Clone() : null);
			this.srvFighter4Info_ = ((other.srvFighter4Info_ != null) ? other.srvFighter4Info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018916 RID: 100630 RVA: 0x00395914 File Offset: 0x00393B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowRequest Clone()
		{
			return new SecWorldStartFlowRequest(this);
		}

		// Token: 0x17005301 RID: 21249
		// (get) Token: 0x06018917 RID: 100631 RVA: 0x0039591C File Offset: 0x00393B1C
		// (set) Token: 0x06018918 RID: 100632 RVA: 0x00395924 File Offset: 0x00393B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x17005302 RID: 21250
		// (get) Token: 0x06018919 RID: 100633 RVA: 0x0039592D File Offset: 0x00393B2D
		// (set) Token: 0x0601891A RID: 100634 RVA: 0x00395935 File Offset: 0x00393B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientStartTime
		{
			get
			{
				return this.clientStartTime_;
			}
			set
			{
				this.clientStartTime_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005303 RID: 21251
		// (get) Token: 0x0601891B RID: 100635 RVA: 0x00395948 File Offset: 0x00393B48
		// (set) Token: 0x0601891C RID: 100636 RVA: 0x00395950 File Offset: 0x00393B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo SrvFighter1Info
		{
			get
			{
				return this.srvFighter1Info_;
			}
			set
			{
				this.srvFighter1Info_ = value;
			}
		}

		// Token: 0x17005304 RID: 21252
		// (get) Token: 0x0601891D RID: 100637 RVA: 0x00395959 File Offset: 0x00393B59
		// (set) Token: 0x0601891E RID: 100638 RVA: 0x00395961 File Offset: 0x00393B61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo SrvFighter2Info
		{
			get
			{
				return this.srvFighter2Info_;
			}
			set
			{
				this.srvFighter2Info_ = value;
			}
		}

		// Token: 0x17005305 RID: 21253
		// (get) Token: 0x0601891F RID: 100639 RVA: 0x0039596A File Offset: 0x00393B6A
		// (set) Token: 0x06018920 RID: 100640 RVA: 0x00395972 File Offset: 0x00393B72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo SrvFighter3Info
		{
			get
			{
				return this.srvFighter3Info_;
			}
			set
			{
				this.srvFighter3Info_ = value;
			}
		}

		// Token: 0x17005306 RID: 21254
		// (get) Token: 0x06018921 RID: 100641 RVA: 0x0039597B File Offset: 0x00393B7B
		// (set) Token: 0x06018922 RID: 100642 RVA: 0x00395983 File Offset: 0x00393B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SrvFighterInfo SrvFighter4Info
		{
			get
			{
				return this.srvFighter4Info_;
			}
			set
			{
				this.srvFighter4Info_ = value;
			}
		}

		// Token: 0x06018923 RID: 100643 RVA: 0x0039598C File Offset: 0x00393B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldStartFlowRequest);
		}

		// Token: 0x06018924 RID: 100644 RVA: 0x0039599C File Offset: 0x00393B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldStartFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientStartTime != other.ClientStartTime) && object.Equals(this.SrvFighter1Info, other.SrvFighter1Info) && object.Equals(this.SrvFighter2Info, other.SrvFighter2Info) && object.Equals(this.SrvFighter3Info, other.SrvFighter3Info) && object.Equals(this.SrvFighter4Info, other.SrvFighter4Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018925 RID: 100645 RVA: 0x00395A40 File Offset: 0x00393C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.ClientStartTime.Length != 0)
			{
				num ^= this.ClientStartTime.GetHashCode();
			}
			if (this.srvFighter1Info_ != null)
			{
				num ^= this.SrvFighter1Info.GetHashCode();
			}
			if (this.srvFighter2Info_ != null)
			{
				num ^= this.SrvFighter2Info.GetHashCode();
			}
			if (this.srvFighter3Info_ != null)
			{
				num ^= this.SrvFighter3Info.GetHashCode();
			}
			if (this.srvFighter4Info_ != null)
			{
				num ^= this.SrvFighter4Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018926 RID: 100646 RVA: 0x00395AF2 File Offset: 0x00393CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018927 RID: 100647 RVA: 0x00395AFF File Offset: 0x00393CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018928 RID: 100648 RVA: 0x00395B08 File Offset: 0x00393D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.srvFighter4Info_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SrvFighter4Info);
			}
			if (this.srvFighter3Info_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SrvFighter3Info);
			}
			if (this.ClientStartTime.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.ClientStartTime);
			}
			if (this.srvFighter1Info_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SrvFighter1Info);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.LogId);
			}
			if (this.srvFighter2Info_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.SrvFighter2Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018929 RID: 100649 RVA: 0x00395BD8 File Offset: 0x00393DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.ClientStartTime.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientStartTime);
			}
			if (this.srvFighter1Info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SrvFighter1Info);
			}
			if (this.srvFighter2Info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SrvFighter2Info);
			}
			if (this.srvFighter3Info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SrvFighter3Info);
			}
			if (this.srvFighter4Info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SrvFighter4Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601892A RID: 100650 RVA: 0x00395C94 File Offset: 0x00393E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldStartFlowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.ClientStartTime.Length != 0)
			{
				this.ClientStartTime = other.ClientStartTime;
			}
			if (other.srvFighter1Info_ != null)
			{
				if (this.srvFighter1Info_ == null)
				{
					this.SrvFighter1Info = new SrvFighterInfo();
				}
				this.SrvFighter1Info.MergeFrom(other.SrvFighter1Info);
			}
			if (other.srvFighter2Info_ != null)
			{
				if (this.srvFighter2Info_ == null)
				{
					this.SrvFighter2Info = new SrvFighterInfo();
				}
				this.SrvFighter2Info.MergeFrom(other.SrvFighter2Info);
			}
			if (other.srvFighter3Info_ != null)
			{
				if (this.srvFighter3Info_ == null)
				{
					this.SrvFighter3Info = new SrvFighterInfo();
				}
				this.SrvFighter3Info.MergeFrom(other.SrvFighter3Info);
			}
			if (other.srvFighter4Info_ != null)
			{
				if (this.srvFighter4Info_ == null)
				{
					this.SrvFighter4Info = new SrvFighterInfo();
				}
				this.SrvFighter4Info.MergeFrom(other.SrvFighter4Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601892B RID: 100651 RVA: 0x00395D99 File Offset: 0x00393F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601892C RID: 100652 RVA: 0x00395DA4 File Offset: 0x00393FA4
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
				if (num <= 74U)
				{
					if (num == 34U)
					{
						if (this.srvFighter4Info_ == null)
						{
							this.SrvFighter4Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter4Info);
						continue;
					}
					if (num == 42U)
					{
						if (this.srvFighter3Info_ == null)
						{
							this.SrvFighter3Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter3Info);
						continue;
					}
					if (num == 74U)
					{
						this.ClientStartTime = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.srvFighter1Info_ == null)
						{
							this.SrvFighter1Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter1Info);
						continue;
					}
					if (num == 88U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
					if (num == 98U)
					{
						if (this.srvFighter2Info_ == null)
						{
							this.SrvFighter2Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter2Info);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400922C RID: 37420
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400922D RID: 37421
		public const int LogIdFieldNumber = 11;

		// Token: 0x0400922E RID: 37422
		private long logId_;

		// Token: 0x0400922F RID: 37423
		public const int ClientStartTimeFieldNumber = 9;

		// Token: 0x04009230 RID: 37424
		private string clientStartTime_ = "";

		// Token: 0x04009231 RID: 37425
		public const int SrvFighter1InfoFieldNumber = 10;

		// Token: 0x04009232 RID: 37426
		private SrvFighterInfo srvFighter1Info_;

		// Token: 0x04009233 RID: 37427
		public const int SrvFighter2InfoFieldNumber = 12;

		// Token: 0x04009234 RID: 37428
		private SrvFighterInfo srvFighter2Info_;

		// Token: 0x04009235 RID: 37429
		public const int SrvFighter3InfoFieldNumber = 5;

		// Token: 0x04009236 RID: 37430
		private SrvFighterInfo srvFighter3Info_;

		// Token: 0x04009237 RID: 37431
		public const int SrvFighter4InfoFieldNumber = 4;

		// Token: 0x04009238 RID: 37432
		private SrvFighterInfo srvFighter4Info_;
	}
}
