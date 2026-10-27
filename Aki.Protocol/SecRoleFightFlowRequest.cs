using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011B4 RID: 4532
	[NetMessage(EMessageId.SecRoleFightFlowRequest)]
	public sealed class SecRoleFightFlowRequest : IMessage<SecRoleFightFlowRequest>, IMessage, IEquatable<SecRoleFightFlowRequest>, IDeepCloneable<SecRoleFightFlowRequest>, IBufferMessage
	{
		// Token: 0x060182B4 RID: 98996 RVA: 0x00383BE8 File Offset: 0x00381DE8
		[NullableContext(1)]
		public static SecRoleFightFlowRequest Create()
		{
			return new SecRoleFightFlowRequest();
		}

		// Token: 0x17005159 RID: 20825
		// (get) Token: 0x060182B5 RID: 98997 RVA: 0x00383BEF File Offset: 0x00381DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700515A RID: 20826
		// (get) Token: 0x060182B6 RID: 98998 RVA: 0x00383BF2 File Offset: 0x00381DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecRoleFightFlowRequest.Descriptor;
			}
		}

		// Token: 0x060182B7 RID: 98999 RVA: 0x00383BF9 File Offset: 0x00381DF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowRequest()
		{
		}

		// Token: 0x060182B8 RID: 99000 RVA: 0x00383C18 File Offset: 0x00381E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowRequest(SecRoleFightFlowRequest other) : this()
		{
			this.logId_ = other.logId_;
			this.clientTime_ = other.clientTime_;
			this.secRoleFightFlowDataList_ = other.secRoleFightFlowDataList_.Clone();
			this.logType_ = other.logType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060182B9 RID: 99001 RVA: 0x00383C71 File Offset: 0x00381E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowRequest Clone()
		{
			return new SecRoleFightFlowRequest(this);
		}

		// Token: 0x1700515B RID: 20827
		// (get) Token: 0x060182BA RID: 99002 RVA: 0x00383C79 File Offset: 0x00381E79
		// (set) Token: 0x060182BB RID: 99003 RVA: 0x00383C81 File Offset: 0x00381E81
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

		// Token: 0x1700515C RID: 20828
		// (get) Token: 0x060182BC RID: 99004 RVA: 0x00383C8A File Offset: 0x00381E8A
		// (set) Token: 0x060182BD RID: 99005 RVA: 0x00383C92 File Offset: 0x00381E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ClientTime
		{
			get
			{
				return this.clientTime_;
			}
			set
			{
				this.clientTime_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700515D RID: 20829
		// (get) Token: 0x060182BE RID: 99006 RVA: 0x00383CA5 File Offset: 0x00381EA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SecRoleFightFlowData> SecRoleFightFlowDataList
		{
			get
			{
				return this.secRoleFightFlowDataList_;
			}
		}

		// Token: 0x1700515E RID: 20830
		// (get) Token: 0x060182BF RID: 99007 RVA: 0x00383CAD File Offset: 0x00381EAD
		// (set) Token: 0x060182C0 RID: 99008 RVA: 0x00383CB5 File Offset: 0x00381EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AceBattleAntiCheatingLogType LogType
		{
			get
			{
				return this.logType_;
			}
			set
			{
				this.logType_ = value;
			}
		}

		// Token: 0x060182C1 RID: 99009 RVA: 0x00383CBE File Offset: 0x00381EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecRoleFightFlowRequest);
		}

		// Token: 0x060182C2 RID: 99010 RVA: 0x00383CCC File Offset: 0x00381ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecRoleFightFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientTime != other.ClientTime) && this.secRoleFightFlowDataList_.Equals(other.secRoleFightFlowDataList_) && this.LogType == other.LogType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060182C3 RID: 99011 RVA: 0x00383D40 File Offset: 0x00381F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.ClientTime.Length != 0)
			{
				num ^= this.ClientTime.GetHashCode();
			}
			num ^= this.secRoleFightFlowDataList_.GetHashCode();
			if (this.LogType != AceBattleAntiCheatingLogType.LogTypeSecGetReportData2Flow)
			{
				num ^= this.LogType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060182C4 RID: 99012 RVA: 0x00383DC7 File Offset: 0x00381FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060182C5 RID: 99013 RVA: 0x00383DD4 File Offset: 0x00381FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060182C6 RID: 99014 RVA: 0x00383DE0 File Offset: 0x00381FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogType != AceBattleAntiCheatingLogType.LogTypeSecGetReportData2Flow)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.LogType);
			}
			if (this.ClientTime.Length != 0)
			{
				output.WriteRawTag(82);
				output.WriteString(this.ClientTime);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.LogId);
			}
			this.secRoleFightFlowDataList_.WriteTo(ref output, SecRoleFightFlowRequest._repeated_secRoleFightFlowDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060182C7 RID: 99015 RVA: 0x00383E6C File Offset: 0x0038206C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.ClientTime.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClientTime);
			}
			num += this.secRoleFightFlowDataList_.CalculateSize(SecRoleFightFlowRequest._repeated_secRoleFightFlowDataList_codec);
			if (this.LogType != AceBattleAntiCheatingLogType.LogTypeSecGetReportData2Flow)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LogType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060182C8 RID: 99016 RVA: 0x00383EF4 File Offset: 0x003820F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecRoleFightFlowRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.ClientTime.Length != 0)
			{
				this.ClientTime = other.ClientTime;
			}
			this.secRoleFightFlowDataList_.Add(other.secRoleFightFlowDataList_);
			if (other.LogType != AceBattleAntiCheatingLogType.LogTypeSecGetReportData2Flow)
			{
				this.LogType = other.LogType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060182C9 RID: 99017 RVA: 0x00383F6E File Offset: 0x0038216E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060182CA RID: 99018 RVA: 0x00383F78 File Offset: 0x00382178
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
				if (num <= 82U)
				{
					if (num == 32U)
					{
						this.LogType = (AceBattleAntiCheatingLogType)input.ReadEnum();
						continue;
					}
					if (num == 82U)
					{
						this.ClientTime = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.LogId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						this.secRoleFightFlowDataList_.AddEntriesFrom(ref input, SecRoleFightFlowRequest._repeated_secRoleFightFlowDataList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008F36 RID: 36662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F37 RID: 36663
		public const int LogIdFieldNumber = 12;

		// Token: 0x04008F38 RID: 36664
		private long logId_;

		// Token: 0x04008F39 RID: 36665
		public const int ClientTimeFieldNumber = 10;

		// Token: 0x04008F3A RID: 36666
		private string clientTime_ = "";

		// Token: 0x04008F3B RID: 36667
		public const int SecRoleFightFlowDataListFieldNumber = 15;

		// Token: 0x04008F3C RID: 36668
		private static readonly FieldCodec<SecRoleFightFlowData> _repeated_secRoleFightFlowDataList_codec = FieldCodec.ForMessage<SecRoleFightFlowData>(122U, SecRoleFightFlowData.Parser);

		// Token: 0x04008F3D RID: 36669
		private readonly RepeatedField<SecRoleFightFlowData> secRoleFightFlowDataList_ = new RepeatedField<SecRoleFightFlowData>();

		// Token: 0x04008F3E RID: 36670
		public const int LogTypeFieldNumber = 4;

		// Token: 0x04008F3F RID: 36671
		private AceBattleAntiCheatingLogType logType_;
	}
}
