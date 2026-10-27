using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001345 RID: 4933
	public sealed class TempFishPointInfo : IMessage<TempFishPointInfo>, IMessage, IEquatable<TempFishPointInfo>, IDeepCloneable<TempFishPointInfo>, IBufferMessage
	{
		// Token: 0x0601A352 RID: 107346 RVA: 0x003CE9BE File Offset: 0x003CCBBE
		[NullableContext(1)]
		public static TempFishPointInfo Create()
		{
			return new TempFishPointInfo();
		}

		// Token: 0x17005867 RID: 22631
		// (get) Token: 0x0601A353 RID: 107347 RVA: 0x003CE9C5 File Offset: 0x003CCBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TempFishPointInfo> Parser
		{
			get
			{
				return TempFishPointInfo._parser;
			}
		}

		// Token: 0x17005868 RID: 22632
		// (get) Token: 0x0601A354 RID: 107348 RVA: 0x003CE9CC File Offset: 0x003CCBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005869 RID: 22633
		// (get) Token: 0x0601A355 RID: 107349 RVA: 0x003CE9CF File Offset: 0x003CCBCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TempFishPointInfo.Descriptor;
			}
		}

		// Token: 0x0601A356 RID: 107350 RVA: 0x003CE9D6 File Offset: 0x003CCBD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TempFishPointInfo()
		{
		}

		// Token: 0x0601A357 RID: 107351 RVA: 0x003CE9E0 File Offset: 0x003CCBE0
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

		// Token: 0x0601A358 RID: 107352 RVA: 0x003CEA40 File Offset: 0x003CCC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TempFishPointInfo Clone()
		{
			return new TempFishPointInfo(this);
		}

		// Token: 0x1700586A RID: 22634
		// (get) Token: 0x0601A359 RID: 107353 RVA: 0x003CEA48 File Offset: 0x003CCC48
		// (set) Token: 0x0601A35A RID: 107354 RVA: 0x003CEA50 File Offset: 0x003CCC50
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

		// Token: 0x1700586B RID: 22635
		// (get) Token: 0x0601A35B RID: 107355 RVA: 0x003CEA59 File Offset: 0x003CCC59
		// (set) Token: 0x0601A35C RID: 107356 RVA: 0x003CEA61 File Offset: 0x003CCC61
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

		// Token: 0x1700586C RID: 22636
		// (get) Token: 0x0601A35D RID: 107357 RVA: 0x003CEA6A File Offset: 0x003CCC6A
		// (set) Token: 0x0601A35E RID: 107358 RVA: 0x003CEA72 File Offset: 0x003CCC72
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

		// Token: 0x1700586D RID: 22637
		// (get) Token: 0x0601A35F RID: 107359 RVA: 0x003CEA7B File Offset: 0x003CCC7B
		// (set) Token: 0x0601A360 RID: 107360 RVA: 0x003CEA83 File Offset: 0x003CCC83
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

		// Token: 0x1700586E RID: 22638
		// (get) Token: 0x0601A361 RID: 107361 RVA: 0x003CEA8C File Offset: 0x003CCC8C
		// (set) Token: 0x0601A362 RID: 107362 RVA: 0x003CEA94 File Offset: 0x003CCC94
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

		// Token: 0x0601A363 RID: 107363 RVA: 0x003CEA9D File Offset: 0x003CCC9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TempFishPointInfo);
		}

		// Token: 0x0601A364 RID: 107364 RVA: 0x003CEAAC File Offset: 0x003CCCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TempFishPointInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.CurCount == other.CurCount && this.MaxCount == other.MaxCount && this.ConfigId == other.ConfigId && this.GamePlayId == other.GamePlayId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A365 RID: 107365 RVA: 0x003CEB28 File Offset: 0x003CCD28
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

		// Token: 0x0601A366 RID: 107366 RVA: 0x003CEBCB File Offset: 0x003CCDCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A367 RID: 107367 RVA: 0x003CEBD8 File Offset: 0x003CCDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A368 RID: 107368 RVA: 0x003CEBE4 File Offset: 0x003CCDE4
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

		// Token: 0x0601A369 RID: 107369 RVA: 0x003CEC90 File Offset: 0x003CCE90
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

		// Token: 0x0601A36A RID: 107370 RVA: 0x003CED30 File Offset: 0x003CCF30
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

		// Token: 0x0601A36B RID: 107371 RVA: 0x003CEDBC File Offset: 0x003CCFBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A36C RID: 107372 RVA: 0x003CEDC8 File Offset: 0x003CCFC8
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

		// Token: 0x040098E5 RID: 39141
		private static readonly MessageParser<TempFishPointInfo> _parser = new MessageParser<TempFishPointInfo>(() => new TempFishPointInfo());

		// Token: 0x040098E6 RID: 39142
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098E7 RID: 39143
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040098E8 RID: 39144
		private long entityId_;

		// Token: 0x040098E9 RID: 39145
		public const int CurCountFieldNumber = 2;

		// Token: 0x040098EA RID: 39146
		private int curCount_;

		// Token: 0x040098EB RID: 39147
		public const int MaxCountFieldNumber = 3;

		// Token: 0x040098EC RID: 39148
		private int maxCount_;

		// Token: 0x040098ED RID: 39149
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x040098EE RID: 39150
		private int configId_;

		// Token: 0x040098EF RID: 39151
		public const int GamePlayIdFieldNumber = 5;

		// Token: 0x040098F0 RID: 39152
		private int gamePlayId_;
	}
}
