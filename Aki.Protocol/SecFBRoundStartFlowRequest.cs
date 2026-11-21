using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E8 RID: 4584
	[NetMessage(EMessageId.SecFBRoundStartFlowRequest)]
	public sealed class SecFBRoundStartFlowRequest : IMessage<SecFBRoundStartFlowRequest>, IMessage, IEquatable<SecFBRoundStartFlowRequest>, IDeepCloneable<SecFBRoundStartFlowRequest>, IBufferMessage
	{
		// Token: 0x0601879E RID: 100254 RVA: 0x003908D7 File Offset: 0x0038EAD7
		[NullableContext(1)]
		public static SecFBRoundStartFlowRequest Create()
		{
			return new SecFBRoundStartFlowRequest();
		}

		// Token: 0x1700528D RID: 21133
		// (get) Token: 0x0601879F RID: 100255 RVA: 0x003908DE File Offset: 0x0038EADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700528E RID: 21134
		// (get) Token: 0x060187A0 RID: 100256 RVA: 0x003908E1 File Offset: 0x0038EAE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundStartFlowRequest.Descriptor;
			}
		}

		// Token: 0x060187A1 RID: 100257 RVA: 0x003908E8 File Offset: 0x0038EAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowRequest()
		{
		}

		// Token: 0x060187A2 RID: 100258 RVA: 0x003908FC File Offset: 0x0038EAFC
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

		// Token: 0x060187A3 RID: 100259 RVA: 0x003909A8 File Offset: 0x0038EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowRequest Clone()
		{
			return new SecFBRoundStartFlowRequest(this);
		}

		// Token: 0x1700528F RID: 21135
		// (get) Token: 0x060187A4 RID: 100260 RVA: 0x003909B0 File Offset: 0x0038EBB0
		// (set) Token: 0x060187A5 RID: 100261 RVA: 0x003909B8 File Offset: 0x0038EBB8
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

		// Token: 0x17005290 RID: 21136
		// (get) Token: 0x060187A6 RID: 100262 RVA: 0x003909C1 File Offset: 0x0038EBC1
		// (set) Token: 0x060187A7 RID: 100263 RVA: 0x003909C9 File Offset: 0x0038EBC9
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

		// Token: 0x17005291 RID: 21137
		// (get) Token: 0x060187A8 RID: 100264 RVA: 0x003909DC File Offset: 0x0038EBDC
		// (set) Token: 0x060187A9 RID: 100265 RVA: 0x003909E4 File Offset: 0x0038EBE4
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

		// Token: 0x17005292 RID: 21138
		// (get) Token: 0x060187AA RID: 100266 RVA: 0x003909ED File Offset: 0x0038EBED
		// (set) Token: 0x060187AB RID: 100267 RVA: 0x003909F5 File Offset: 0x0038EBF5
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

		// Token: 0x17005293 RID: 21139
		// (get) Token: 0x060187AC RID: 100268 RVA: 0x003909FE File Offset: 0x0038EBFE
		// (set) Token: 0x060187AD RID: 100269 RVA: 0x00390A06 File Offset: 0x0038EC06
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

		// Token: 0x17005294 RID: 21140
		// (get) Token: 0x060187AE RID: 100270 RVA: 0x00390A0F File Offset: 0x0038EC0F
		// (set) Token: 0x060187AF RID: 100271 RVA: 0x00390A17 File Offset: 0x0038EC17
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

		// Token: 0x060187B0 RID: 100272 RVA: 0x00390A20 File Offset: 0x0038EC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundStartFlowRequest);
		}

		// Token: 0x060187B1 RID: 100273 RVA: 0x00390A30 File Offset: 0x0038EC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundStartFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientStartTime != other.ClientStartTime) && object.Equals(this.SrvFighter1Info, other.SrvFighter1Info) && object.Equals(this.SrvFighter2Info, other.SrvFighter2Info) && object.Equals(this.SrvFighter3Info, other.SrvFighter3Info) && object.Equals(this.SrvFighter4Info, other.SrvFighter4Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187B2 RID: 100274 RVA: 0x00390AD4 File Offset: 0x0038ECD4
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

		// Token: 0x060187B3 RID: 100275 RVA: 0x00390B86 File Offset: 0x0038ED86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187B4 RID: 100276 RVA: 0x00390B93 File Offset: 0x0038ED93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187B5 RID: 100277 RVA: 0x00390B9C File Offset: 0x0038ED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LogId);
			}
			if (this.srvFighter1Info_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.SrvFighter1Info);
			}
			if (this.srvFighter3Info_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SrvFighter3Info);
			}
			if (this.ClientStartTime.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.ClientStartTime);
			}
			if (this.srvFighter4Info_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SrvFighter4Info);
			}
			if (this.srvFighter2Info_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SrvFighter2Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187B6 RID: 100278 RVA: 0x00390C6C File Offset: 0x0038EE6C
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

		// Token: 0x060187B7 RID: 100279 RVA: 0x00390D28 File Offset: 0x0038EF28
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

		// Token: 0x060187B8 RID: 100280 RVA: 0x00390E2D File Offset: 0x0038F02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187B9 RID: 100281 RVA: 0x00390E38 File Offset: 0x0038F038
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
					if (num == 16U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
					if (num == 34U)
					{
						if (this.srvFighter1Info_ == null)
						{
							this.SrvFighter1Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter1Info);
						continue;
					}
					if (num == 50U)
					{
						if (this.srvFighter3Info_ == null)
						{
							this.SrvFighter3Info = new SrvFighterInfo();
						}
						input.ReadMessage(this.SrvFighter3Info);
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.ClientStartTime = input.ReadString();
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
					if (num == 114U)
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

		// Token: 0x0400916B RID: 37227
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400916C RID: 37228
		public const int LogIdFieldNumber = 2;

		// Token: 0x0400916D RID: 37229
		private long logId_;

		// Token: 0x0400916E RID: 37230
		public const int ClientStartTimeFieldNumber = 8;

		// Token: 0x0400916F RID: 37231
		private string clientStartTime_ = "";

		// Token: 0x04009170 RID: 37232
		public const int SrvFighter1InfoFieldNumber = 4;

		// Token: 0x04009171 RID: 37233
		private SrvFighterInfo srvFighter1Info_;

		// Token: 0x04009172 RID: 37234
		public const int SrvFighter2InfoFieldNumber = 14;

		// Token: 0x04009173 RID: 37235
		private SrvFighterInfo srvFighter2Info_;

		// Token: 0x04009174 RID: 37236
		public const int SrvFighter3InfoFieldNumber = 6;

		// Token: 0x04009175 RID: 37237
		private SrvFighterInfo srvFighter3Info_;

		// Token: 0x04009176 RID: 37238
		public const int SrvFighter4InfoFieldNumber = 11;

		// Token: 0x04009177 RID: 37239
		private SrvFighterInfo srvFighter4Info_;
	}
}
