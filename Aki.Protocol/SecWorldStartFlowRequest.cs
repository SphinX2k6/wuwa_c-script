using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BA RID: 4538
	[NetMessage(EMessageId.SecWorldStartFlowRequest)]
	public sealed class SecWorldStartFlowRequest : IMessage<SecWorldStartFlowRequest>, IMessage, IEquatable<SecWorldStartFlowRequest>, IDeepCloneable<SecWorldStartFlowRequest>, IBufferMessage
	{
		// Token: 0x06018370 RID: 99184 RVA: 0x0038650F File Offset: 0x0038470F
		[NullableContext(1)]
		public static SecWorldStartFlowRequest Create()
		{
			return new SecWorldStartFlowRequest();
		}

		// Token: 0x17005193 RID: 20883
		// (get) Token: 0x06018371 RID: 99185 RVA: 0x00386516 File Offset: 0x00384716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005194 RID: 20884
		// (get) Token: 0x06018372 RID: 99186 RVA: 0x00386519 File Offset: 0x00384719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldStartFlowRequest.Descriptor;
			}
		}

		// Token: 0x06018373 RID: 99187 RVA: 0x00386520 File Offset: 0x00384720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowRequest()
		{
		}

		// Token: 0x06018374 RID: 99188 RVA: 0x00386534 File Offset: 0x00384734
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

		// Token: 0x06018375 RID: 99189 RVA: 0x003865E0 File Offset: 0x003847E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowRequest Clone()
		{
			return new SecWorldStartFlowRequest(this);
		}

		// Token: 0x17005195 RID: 20885
		// (get) Token: 0x06018376 RID: 99190 RVA: 0x003865E8 File Offset: 0x003847E8
		// (set) Token: 0x06018377 RID: 99191 RVA: 0x003865F0 File Offset: 0x003847F0
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

		// Token: 0x17005196 RID: 20886
		// (get) Token: 0x06018378 RID: 99192 RVA: 0x003865F9 File Offset: 0x003847F9
		// (set) Token: 0x06018379 RID: 99193 RVA: 0x00386601 File Offset: 0x00384801
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

		// Token: 0x17005197 RID: 20887
		// (get) Token: 0x0601837A RID: 99194 RVA: 0x00386614 File Offset: 0x00384814
		// (set) Token: 0x0601837B RID: 99195 RVA: 0x0038661C File Offset: 0x0038481C
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

		// Token: 0x17005198 RID: 20888
		// (get) Token: 0x0601837C RID: 99196 RVA: 0x00386625 File Offset: 0x00384825
		// (set) Token: 0x0601837D RID: 99197 RVA: 0x0038662D File Offset: 0x0038482D
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

		// Token: 0x17005199 RID: 20889
		// (get) Token: 0x0601837E RID: 99198 RVA: 0x00386636 File Offset: 0x00384836
		// (set) Token: 0x0601837F RID: 99199 RVA: 0x0038663E File Offset: 0x0038483E
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

		// Token: 0x1700519A RID: 20890
		// (get) Token: 0x06018380 RID: 99200 RVA: 0x00386647 File Offset: 0x00384847
		// (set) Token: 0x06018381 RID: 99201 RVA: 0x0038664F File Offset: 0x0038484F
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

		// Token: 0x06018382 RID: 99202 RVA: 0x00386658 File Offset: 0x00384858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldStartFlowRequest);
		}

		// Token: 0x06018383 RID: 99203 RVA: 0x00386668 File Offset: 0x00384868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldStartFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientStartTime != other.ClientStartTime) && object.Equals(this.SrvFighter1Info, other.SrvFighter1Info) && object.Equals(this.SrvFighter2Info, other.SrvFighter2Info) && object.Equals(this.SrvFighter3Info, other.SrvFighter3Info) && object.Equals(this.SrvFighter4Info, other.SrvFighter4Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018384 RID: 99204 RVA: 0x0038670C File Offset: 0x0038490C
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

		// Token: 0x06018385 RID: 99205 RVA: 0x003867BE File Offset: 0x003849BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018386 RID: 99206 RVA: 0x003867CB File Offset: 0x003849CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018387 RID: 99207 RVA: 0x003867D4 File Offset: 0x003849D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.srvFighter2Info_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SrvFighter2Info);
			}
			if (this.srvFighter3Info_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SrvFighter3Info);
			}
			if (this.srvFighter4Info_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SrvFighter4Info);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LogId);
			}
			if (this.srvFighter1Info_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.SrvFighter1Info);
			}
			if (this.ClientStartTime.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.ClientStartTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018388 RID: 99208 RVA: 0x003868A4 File Offset: 0x00384AA4
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

		// Token: 0x06018389 RID: 99209 RVA: 0x00386960 File Offset: 0x00384B60
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

		// Token: 0x0601838A RID: 99210 RVA: 0x00386A65 File Offset: 0x00384C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601838B RID: 99211 RVA: 0x00386A70 File Offset: 0x00384C70
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
				if (num <= 42U)
				{
					if (num == 26U)
					{
						if (this.srvFighter2Info_ == null)
						{
							this.SrvFighter2Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter2Info);
						continue;
					}
					if (num == 34U)
					{
						if (this.srvFighter3Info_ == null)
						{
							this.SrvFighter3Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter3Info);
						continue;
					}
					if (num == 42U)
					{
						if (this.srvFighter4Info_ == null)
						{
							this.SrvFighter4Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter4Info);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
					if (num == 66U)
					{
						if (this.srvFighter1Info_ == null)
						{
							this.SrvFighter1Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter1Info);
						continue;
					}
					if (num == 114U)
					{
						this.ClientStartTime = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008F99 RID: 36761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F9A RID: 36762
		public const int LogIdFieldNumber = 6;

		// Token: 0x04008F9B RID: 36763
		private long logId_;

		// Token: 0x04008F9C RID: 36764
		public const int ClientStartTimeFieldNumber = 14;

		// Token: 0x04008F9D RID: 36765
		private string clientStartTime_ = "";

		// Token: 0x04008F9E RID: 36766
		public const int SrvFighter1InfoFieldNumber = 8;

		// Token: 0x04008F9F RID: 36767
		private SrvFighterInfo srvFighter1Info_;

		// Token: 0x04008FA0 RID: 36768
		public const int SrvFighter2InfoFieldNumber = 3;

		// Token: 0x04008FA1 RID: 36769
		private SrvFighterInfo srvFighter2Info_;

		// Token: 0x04008FA2 RID: 36770
		public const int SrvFighter3InfoFieldNumber = 4;

		// Token: 0x04008FA3 RID: 36771
		private SrvFighterInfo srvFighter3Info_;

		// Token: 0x04008FA4 RID: 36772
		public const int SrvFighter4InfoFieldNumber = 5;

		// Token: 0x04008FA5 RID: 36773
		private SrvFighterInfo srvFighter4Info_;
	}
}
