using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011AE RID: 4526
	[NetMessage(EMessageId.SecFBRoundStartFlowRequest)]
	public sealed class SecFBRoundStartFlowRequest : IMessage<SecFBRoundStartFlowRequest>, IMessage, IEquatable<SecFBRoundStartFlowRequest>, IDeepCloneable<SecFBRoundStartFlowRequest>, IBufferMessage
	{
		// Token: 0x060181FD RID: 98813 RVA: 0x0038157F File Offset: 0x0037F77F
		[NullableContext(1)]
		public static SecFBRoundStartFlowRequest Create()
		{
			return new SecFBRoundStartFlowRequest();
		}

		// Token: 0x17005121 RID: 20769
		// (get) Token: 0x060181FE RID: 98814 RVA: 0x00381586 File Offset: 0x0037F786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005122 RID: 20770
		// (get) Token: 0x060181FF RID: 98815 RVA: 0x00381589 File Offset: 0x0037F789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundStartFlowRequest.Descriptor;
			}
		}

		// Token: 0x06018200 RID: 98816 RVA: 0x00381590 File Offset: 0x0037F790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowRequest()
		{
		}

		// Token: 0x06018201 RID: 98817 RVA: 0x003815A4 File Offset: 0x0037F7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowRequest(SecFBRoundStartFlowRequest other) : this()
		{
			this.logId_ = other.logId_;
			this.clientStartTime_ = other.clientStartTime_;
			this.srvFighter1Info_ = ((other.srvFighter1Info_ != null) ? other.srvFighter1Info_.Clone() : null);
			this.srvFighter2Info_ = ((other.srvFighter2Info_ != null) ? other.srvFighter2Info_.Clone() : null);
			this.srvFighter3Info_ = ((other.srvFighter3Info_ != null) ? other.srvFighter3Info_.Clone() : null);
			this.srvFighter4Info_ = ((other.srvFighter4Info_ != null) ? other.srvFighter4Info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018202 RID: 98818 RVA: 0x00381650 File Offset: 0x0037F850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowRequest Clone()
		{
			return new SecFBRoundStartFlowRequest(this);
		}

		// Token: 0x17005123 RID: 20771
		// (get) Token: 0x06018203 RID: 98819 RVA: 0x00381658 File Offset: 0x0037F858
		// (set) Token: 0x06018204 RID: 98820 RVA: 0x00381660 File Offset: 0x0037F860
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

		// Token: 0x17005124 RID: 20772
		// (get) Token: 0x06018205 RID: 98821 RVA: 0x00381669 File Offset: 0x0037F869
		// (set) Token: 0x06018206 RID: 98822 RVA: 0x00381671 File Offset: 0x0037F871
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

		// Token: 0x17005125 RID: 20773
		// (get) Token: 0x06018207 RID: 98823 RVA: 0x00381684 File Offset: 0x0037F884
		// (set) Token: 0x06018208 RID: 98824 RVA: 0x0038168C File Offset: 0x0037F88C
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

		// Token: 0x17005126 RID: 20774
		// (get) Token: 0x06018209 RID: 98825 RVA: 0x00381695 File Offset: 0x0037F895
		// (set) Token: 0x0601820A RID: 98826 RVA: 0x0038169D File Offset: 0x0037F89D
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

		// Token: 0x17005127 RID: 20775
		// (get) Token: 0x0601820B RID: 98827 RVA: 0x003816A6 File Offset: 0x0037F8A6
		// (set) Token: 0x0601820C RID: 98828 RVA: 0x003816AE File Offset: 0x0037F8AE
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

		// Token: 0x17005128 RID: 20776
		// (get) Token: 0x0601820D RID: 98829 RVA: 0x003816B7 File Offset: 0x0037F8B7
		// (set) Token: 0x0601820E RID: 98830 RVA: 0x003816BF File Offset: 0x0037F8BF
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

		// Token: 0x0601820F RID: 98831 RVA: 0x003816C8 File Offset: 0x0037F8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundStartFlowRequest);
		}

		// Token: 0x06018210 RID: 98832 RVA: 0x003816D8 File Offset: 0x0037F8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundStartFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientStartTime != other.ClientStartTime) && object.Equals(this.SrvFighter1Info, other.SrvFighter1Info) && object.Equals(this.SrvFighter2Info, other.SrvFighter2Info) && object.Equals(this.SrvFighter3Info, other.SrvFighter3Info) && object.Equals(this.SrvFighter4Info, other.SrvFighter4Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018211 RID: 98833 RVA: 0x0038177C File Offset: 0x0037F97C
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

		// Token: 0x06018212 RID: 98834 RVA: 0x0038182E File Offset: 0x0037FA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018213 RID: 98835 RVA: 0x0038183B File Offset: 0x0037FA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018214 RID: 98836 RVA: 0x00381844 File Offset: 0x0037FA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.srvFighter2Info_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SrvFighter2Info);
			}
			if (this.ClientStartTime.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(this.ClientStartTime);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LogId);
			}
			if (this.srvFighter3Info_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.SrvFighter3Info);
			}
			if (this.srvFighter1Info_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.SrvFighter1Info);
			}
			if (this.srvFighter4Info_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SrvFighter4Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018215 RID: 98837 RVA: 0x00381914 File Offset: 0x0037FB14
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

		// Token: 0x06018216 RID: 98838 RVA: 0x003819D0 File Offset: 0x0037FBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecFBRoundStartFlowRequest other)
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

		// Token: 0x06018217 RID: 98839 RVA: 0x00381AD5 File Offset: 0x0037FCD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018218 RID: 98840 RVA: 0x00381AE0 File Offset: 0x0037FCE0
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
				if (num <= 56U)
				{
					if (num == 10U)
					{
						if (this.srvFighter2Info_ == null)
						{
							this.SrvFighter2Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter2Info);
						continue;
					}
					if (num == 18U)
					{
						this.ClientStartTime = input.ReadString();
						continue;
					}
					if (num == 56U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.srvFighter3Info_ == null)
						{
							this.SrvFighter3Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter3Info);
						continue;
					}
					if (num == 82U)
					{
						if (this.srvFighter1Info_ == null)
						{
							this.SrvFighter1Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter1Info);
						continue;
					}
					if (num == 90U)
					{
						if (this.srvFighter4Info_ == null)
						{
							this.SrvFighter4Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter4Info);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008ED8 RID: 36568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008ED9 RID: 36569
		public const int LogIdFieldNumber = 7;

		// Token: 0x04008EDA RID: 36570
		private long logId_;

		// Token: 0x04008EDB RID: 36571
		public const int ClientStartTimeFieldNumber = 2;

		// Token: 0x04008EDC RID: 36572
		private string clientStartTime_ = "";

		// Token: 0x04008EDD RID: 36573
		public const int SrvFighter1InfoFieldNumber = 10;

		// Token: 0x04008EDE RID: 36574
		private SrvFighterInfo srvFighter1Info_;

		// Token: 0x04008EDF RID: 36575
		public const int SrvFighter2InfoFieldNumber = 1;

		// Token: 0x04008EE0 RID: 36576
		private SrvFighterInfo srvFighter2Info_;

		// Token: 0x04008EE1 RID: 36577
		public const int SrvFighter3InfoFieldNumber = 9;

		// Token: 0x04008EE2 RID: 36578
		private SrvFighterInfo srvFighter3Info_;

		// Token: 0x04008EE3 RID: 36579
		public const int SrvFighter4InfoFieldNumber = 11;

		// Token: 0x04008EE4 RID: 36580
		private SrvFighterInfo srvFighter4Info_;
	}
}
