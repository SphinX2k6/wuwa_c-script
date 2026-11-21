using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B8 RID: 5048
	public sealed class TempFishPointInfo : IMessage<TempFishPointInfo>, IMessage, IEquatable<TempFishPointInfo>, IDeepCloneable<TempFishPointInfo>, IBufferMessage
	{
		// Token: 0x0601ADD9 RID: 110041 RVA: 0x003E9AEE File Offset: 0x003E7CEE
		[NullableContext(1)]
		public static TempFishPointInfo Create()
		{
			return new TempFishPointInfo();
		}

		// Token: 0x17005AFA RID: 23290
		// (get) Token: 0x0601ADDA RID: 110042 RVA: 0x003E9AF5 File Offset: 0x003E7CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TempFishPointInfo> Parser
		{
			get
			{
				return TempFishPointInfo._parser;
			}
		}

		// Token: 0x17005AFB RID: 23291
		// (get) Token: 0x0601ADDB RID: 110043 RVA: 0x003E9AFC File Offset: 0x003E7CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AFC RID: 23292
		// (get) Token: 0x0601ADDC RID: 110044 RVA: 0x003E9AFF File Offset: 0x003E7CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TempFishPointInfo.Descriptor;
			}
		}

		// Token: 0x0601ADDD RID: 110045 RVA: 0x003E9B06 File Offset: 0x003E7D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TempFishPointInfo()
		{
		}

		// Token: 0x0601ADDE RID: 110046 RVA: 0x003E9B10 File Offset: 0x003E7D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TempFishPointInfo(TempFishPointInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.curCount_ = other.curCount_;
			this.maxCount_ = other.maxCount_;
			this.configId_ = other.configId_;
			this.gamePlayId_ = other.gamePlayId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADDF RID: 110047 RVA: 0x003E9B70 File Offset: 0x003E7D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TempFishPointInfo Clone()
		{
			return new TempFishPointInfo(this);
		}

		// Token: 0x17005AFD RID: 23293
		// (get) Token: 0x0601ADE0 RID: 110048 RVA: 0x003E9B78 File Offset: 0x003E7D78
		// (set) Token: 0x0601ADE1 RID: 110049 RVA: 0x003E9B80 File Offset: 0x003E7D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17005AFE RID: 23294
		// (get) Token: 0x0601ADE2 RID: 110050 RVA: 0x003E9B89 File Offset: 0x003E7D89
		// (set) Token: 0x0601ADE3 RID: 110051 RVA: 0x003E9B91 File Offset: 0x003E7D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCount
		{
			get
			{
				return this.curCount_;
			}
			set
			{
				this.curCount_ = value;
			}
		}

		// Token: 0x17005AFF RID: 23295
		// (get) Token: 0x0601ADE4 RID: 110052 RVA: 0x003E9B9A File Offset: 0x003E7D9A
		// (set) Token: 0x0601ADE5 RID: 110053 RVA: 0x003E9BA2 File Offset: 0x003E7DA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxCount
		{
			get
			{
				return this.maxCount_;
			}
			set
			{
				this.maxCount_ = value;
			}
		}

		// Token: 0x17005B00 RID: 23296
		// (get) Token: 0x0601ADE6 RID: 110054 RVA: 0x003E9BAB File Offset: 0x003E7DAB
		// (set) Token: 0x0601ADE7 RID: 110055 RVA: 0x003E9BB3 File Offset: 0x003E7DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005B01 RID: 23297
		// (get) Token: 0x0601ADE8 RID: 110056 RVA: 0x003E9BBC File Offset: 0x003E7DBC
		// (set) Token: 0x0601ADE9 RID: 110057 RVA: 0x003E9BC4 File Offset: 0x003E7DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GamePlayId
		{
			get
			{
				return this.gamePlayId_;
			}
			set
			{
				this.gamePlayId_ = value;
			}
		}

		// Token: 0x0601ADEA RID: 110058 RVA: 0x003E9BCD File Offset: 0x003E7DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TempFishPointInfo);
		}

		// Token: 0x0601ADEB RID: 110059 RVA: 0x003E9BDC File Offset: 0x003E7DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TempFishPointInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.CurCount == other.CurCount && this.MaxCount == other.MaxCount && this.ConfigId == other.ConfigId && this.GamePlayId == other.GamePlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADEC RID: 110060 RVA: 0x003E9C58 File Offset: 0x003E7E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.CurCount != 0)
			{
				num ^= this.CurCount.GetHashCode();
			}
			if (this.MaxCount != 0)
			{
				num ^= this.MaxCount.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.GamePlayId != 0)
			{
				num ^= this.GamePlayId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601ADED RID: 110061 RVA: 0x003E9CFB File Offset: 0x003E7EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADEE RID: 110062 RVA: 0x003E9D08 File Offset: 0x003E7F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADEF RID: 110063 RVA: 0x003E9D14 File Offset: 0x003E7F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.CurCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurCount);
			}
			if (this.MaxCount != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MaxCount);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ConfigId);
			}
			if (this.GamePlayId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADF0 RID: 110064 RVA: 0x003E9DC0 File Offset: 0x003E7FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.CurCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCount);
			}
			if (this.MaxCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxCount);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.GamePlayId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GamePlayId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601ADF1 RID: 110065 RVA: 0x003E9E60 File Offset: 0x003E8060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TempFishPointInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.CurCount != 0)
			{
				this.CurCount = other.CurCount;
			}
			if (other.MaxCount != 0)
			{
				this.MaxCount = other.MaxCount;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.GamePlayId != 0)
			{
				this.GamePlayId = other.GamePlayId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601ADF2 RID: 110066 RVA: 0x003E9EEC File Offset: 0x003E80EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADF3 RID: 110067 RVA: 0x003E9EF8 File Offset: 0x003E80F8
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.CurCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.MaxCount = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.GamePlayId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009D27 RID: 40231
		private static readonly MessageParser<TempFishPointInfo> _parser = new MessageParser<TempFishPointInfo>(() => new TempFishPointInfo());

		// Token: 0x04009D28 RID: 40232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D29 RID: 40233
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04009D2A RID: 40234
		private long entityId_;

		// Token: 0x04009D2B RID: 40235
		public const int CurCountFieldNumber = 2;

		// Token: 0x04009D2C RID: 40236
		private int curCount_;

		// Token: 0x04009D2D RID: 40237
		public const int MaxCountFieldNumber = 3;

		// Token: 0x04009D2E RID: 40238
		private int maxCount_;

		// Token: 0x04009D2F RID: 40239
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x04009D30 RID: 40240
		private int configId_;

		// Token: 0x04009D31 RID: 40241
		public const int GamePlayIdFieldNumber = 5;

		// Token: 0x04009D32 RID: 40242
		private int gamePlayId_;
	}
}
