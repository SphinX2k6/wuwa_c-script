using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EE RID: 4590
	[NetMessage(EMessageId.SecRoleFightFlowRequest)]
	public sealed class SecRoleFightFlowRequest : IMessage<SecRoleFightFlowRequest>, IMessage, IEquatable<SecRoleFightFlowRequest>, IDeepCloneable<SecRoleFightFlowRequest>, IBufferMessage
	{
		// Token: 0x06018855 RID: 100437 RVA: 0x00392F50 File Offset: 0x00391150
		[NullableContext(1)]
		public static SecRoleFightFlowRequest Create()
		{
			return new SecRoleFightFlowRequest();
		}

		// Token: 0x170052C5 RID: 21189
		// (get) Token: 0x06018856 RID: 100438 RVA: 0x00392F57 File Offset: 0x00391157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052C6 RID: 21190
		// (get) Token: 0x06018857 RID: 100439 RVA: 0x00392F5A File Offset: 0x0039115A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecRoleFightFlowRequest.Descriptor;
			}
		}

		// Token: 0x06018858 RID: 100440 RVA: 0x00392F61 File Offset: 0x00391161
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowRequest()
		{
		}

		// Token: 0x06018859 RID: 100441 RVA: 0x00392F80 File Offset: 0x00391180
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

		// Token: 0x0601885A RID: 100442 RVA: 0x00392FD9 File Offset: 0x003911D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowRequest Clone()
		{
			return new SecRoleFightFlowRequest(this);
		}

		// Token: 0x170052C7 RID: 21191
		// (get) Token: 0x0601885B RID: 100443 RVA: 0x00392FE1 File Offset: 0x003911E1
		// (set) Token: 0x0601885C RID: 100444 RVA: 0x00392FE9 File Offset: 0x003911E9
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

		// Token: 0x170052C8 RID: 21192
		// (get) Token: 0x0601885D RID: 100445 RVA: 0x00392FF2 File Offset: 0x003911F2
		// (set) Token: 0x0601885E RID: 100446 RVA: 0x00392FFA File Offset: 0x003911FA
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

		// Token: 0x170052C9 RID: 21193
		// (get) Token: 0x0601885F RID: 100447 RVA: 0x0039300D File Offset: 0x0039120D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SecRoleFightFlowData> SecRoleFightFlowDataList
		{
			get
			{
				return this.secRoleFightFlowDataList_;
			}
		}

		// Token: 0x170052CA RID: 21194
		// (get) Token: 0x06018860 RID: 100448 RVA: 0x00393015 File Offset: 0x00391215
		// (set) Token: 0x06018861 RID: 100449 RVA: 0x0039301D File Offset: 0x0039121D
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

		// Token: 0x06018862 RID: 100450 RVA: 0x00393026 File Offset: 0x00391226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecRoleFightFlowRequest);
		}

		// Token: 0x06018863 RID: 100451 RVA: 0x00393034 File Offset: 0x00391234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecRoleFightFlowRequest other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && !(this.ClientTime != other.ClientTime) && this.secRoleFightFlowDataList_.Equals(other.secRoleFightFlowDataList_) && this.LogType == other.LogType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018864 RID: 100452 RVA: 0x003930A8 File Offset: 0x003912A8
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

		// Token: 0x06018865 RID: 100453 RVA: 0x0039312F File Offset: 0x0039132F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018866 RID: 100454 RVA: 0x0039313C File Offset: 0x0039133C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018867 RID: 100455 RVA: 0x00393148 File Offset: 0x00391348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LogType != AceBattleAntiCheatingLogType.LogTypeSecGetReportData2Flow)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.LogType);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LogId);
			}
			this.secRoleFightFlowDataList_.WriteTo(ref output, SecRoleFightFlowRequest._repeated_secRoleFightFlowDataList_codec);
			if (this.ClientTime.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.ClientTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018868 RID: 100456 RVA: 0x003931D4 File Offset: 0x003913D4
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

		// Token: 0x06018869 RID: 100457 RVA: 0x0039325C File Offset: 0x0039145C
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

		// Token: 0x0601886A RID: 100458 RVA: 0x003932D6 File Offset: 0x003914D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601886B RID: 100459 RVA: 0x003932E0 File Offset: 0x003914E0
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
					if (num == 16U)
					{
						this.LogType = (AceBattleAntiCheatingLogType)input.ReadEnum();
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
					if (num == 106U)
					{
						this.secRoleFightFlowDataList_.AddEntriesFrom(ref input, SecRoleFightFlowRequest._repeated_secRoleFightFlowDataList_codec);
						continue;
					}
					if (num == 122U)
					{
						this.ClientTime = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040091C9 RID: 37321
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091CA RID: 37322
		public const int LogIdFieldNumber = 7;

		// Token: 0x040091CB RID: 37323
		private long logId_;

		// Token: 0x040091CC RID: 37324
		public const int ClientTimeFieldNumber = 15;

		// Token: 0x040091CD RID: 37325
		private string clientTime_ = "";

		// Token: 0x040091CE RID: 37326
		public const int SecRoleFightFlowDataListFieldNumber = 13;

		// Token: 0x040091CF RID: 37327
		private static readonly FieldCodec<SecRoleFightFlowData> _repeated_secRoleFightFlowDataList_codec = FieldCodec.ForMessage<SecRoleFightFlowData>(106U, SecRoleFightFlowData.Parser);

		// Token: 0x040091D0 RID: 37328
		private readonly RepeatedField<SecRoleFightFlowData> secRoleFightFlowDataList_ = new RepeatedField<SecRoleFightFlowData>();

		// Token: 0x040091D1 RID: 37329
		public const int LogTypeFieldNumber = 2;

		// Token: 0x040091D2 RID: 37330
		private AceBattleAntiCheatingLogType logType_;
	}
}
