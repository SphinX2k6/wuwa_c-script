using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E67 RID: 3687
	[NetMessage(EMessageId.RacingBetsLegMatchInfoResponse)]
	public sealed class RacingBetsLegMatchInfoResponse : IMessage<RacingBetsLegMatchInfoResponse>, IMessage, IEquatable<RacingBetsLegMatchInfoResponse>, IDeepCloneable<RacingBetsLegMatchInfoResponse>, IBufferMessage
	{
		// Token: 0x06013CEF RID: 81135 RVA: 0x002E274C File Offset: 0x002E094C
		[NullableContext(1)]
		public static RacingBetsLegMatchInfoResponse Create()
		{
			return new RacingBetsLegMatchInfoResponse();
		}

		// Token: 0x170041DB RID: 16859
		// (get) Token: 0x06013CF0 RID: 81136 RVA: 0x002E2753 File Offset: 0x002E0953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170041DC RID: 16860
		// (get) Token: 0x06013CF1 RID: 81137 RVA: 0x002E2756 File Offset: 0x002E0956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsLegMatchInfoResponse.Descriptor;
			}
		}

		// Token: 0x06013CF2 RID: 81138 RVA: 0x002E275D File Offset: 0x002E095D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoResponse()
		{
		}

		// Token: 0x06013CF3 RID: 81139 RVA: 0x002E2768 File Offset: 0x002E0968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoResponse(RacingBetsLegMatchInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.legInfo_ = ((other.legInfo_ != null) ? other.legInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013CF4 RID: 81140 RVA: 0x002E27B4 File Offset: 0x002E09B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchInfoResponse Clone()
		{
			return new RacingBetsLegMatchInfoResponse(this);
		}

		// Token: 0x170041DD RID: 16861
		// (get) Token: 0x06013CF5 RID: 81141 RVA: 0x002E27BC File Offset: 0x002E09BC
		// (set) Token: 0x06013CF6 RID: 81142 RVA: 0x002E27C4 File Offset: 0x002E09C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170041DE RID: 16862
		// (get) Token: 0x06013CF7 RID: 81143 RVA: 0x002E27CD File Offset: 0x002E09CD
		// (set) Token: 0x06013CF8 RID: 81144 RVA: 0x002E27D5 File Offset: 0x002E09D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsLegMatchesInfo LegInfo
		{
			get
			{
				return this.legInfo_;
			}
			set
			{
				this.legInfo_ = value;
			}
		}

		// Token: 0x06013CF9 RID: 81145 RVA: 0x002E27DE File Offset: 0x002E09DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsLegMatchInfoResponse);
		}

		// Token: 0x06013CFA RID: 81146 RVA: 0x002E27EC File Offset: 0x002E09EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsLegMatchInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.LegInfo, other.LegInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013CFB RID: 81147 RVA: 0x002E283C File Offset: 0x002E0A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.legInfo_ != null)
			{
				num ^= this.LegInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013CFC RID: 81148 RVA: 0x002E2897 File Offset: 0x002E0A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013CFD RID: 81149 RVA: 0x002E28A4 File Offset: 0x002E0AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013CFE RID: 81150 RVA: 0x002E28B0 File Offset: 0x002E0AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.legInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.LegInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013CFF RID: 81151 RVA: 0x002E290C File Offset: 0x002E0B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.legInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LegInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013D00 RID: 81152 RVA: 0x002E2964 File Offset: 0x002E0B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsLegMatchInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.legInfo_ != null)
			{
				if (this.legInfo_ == null)
				{
					this.LegInfo = new RacingBetsLegMatchesInfo();
				}
				this.LegInfo.MergeFrom(other.LegInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013D01 RID: 81153 RVA: 0x002E29CC File Offset: 0x002E0BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D02 RID: 81154 RVA: 0x002E29D8 File Offset: 0x002E0BD8
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
				if (num != 72U)
				{
					if (num != 82U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.legInfo_ == null)
						{
							this.LegInfo = new RacingBetsLegMatchesInfo();
						}
						input.ReadMessage(this.LegInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007931 RID: 31025
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007932 RID: 31026
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04007933 RID: 31027
		private ErrorCode errorCode_;

		// Token: 0x04007934 RID: 31028
		public const int LegInfoFieldNumber = 10;

		// Token: 0x04007935 RID: 31029
		private RacingBetsLegMatchesInfo legInfo_;
	}
}
