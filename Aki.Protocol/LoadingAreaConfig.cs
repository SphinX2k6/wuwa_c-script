using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092D RID: 2349
	public sealed class LoadingAreaConfig : IMessage<LoadingAreaConfig>, IMessage, IEquatable<LoadingAreaConfig>, IDeepCloneable<LoadingAreaConfig>, IBufferMessage
	{
		// Token: 0x0600CF58 RID: 53080 RVA: 0x001E8934 File Offset: 0x001E6B34
		[NullableContext(1)]
		public static LoadingAreaConfig Create()
		{
			return new LoadingAreaConfig();
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600CF59 RID: 53081 RVA: 0x001E893B File Offset: 0x001E6B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LoadingAreaConfig> Parser
		{
			get
			{
				return LoadingAreaConfig._parser;
			}
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0600CF5A RID: 53082 RVA: 0x001E8942 File Offset: 0x001E6B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x0600CF5B RID: 53083 RVA: 0x001E8945 File Offset: 0x001E6B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadingAreaConfig.Descriptor;
			}
		}

		// Token: 0x0600CF5C RID: 53084 RVA: 0x001E894C File Offset: 0x001E6B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingAreaConfig()
		{
		}

		// Token: 0x0600CF5D RID: 53085 RVA: 0x001E8954 File Offset: 0x001E6B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingAreaConfig(LoadingAreaConfig other) : this()
		{
			this.id_ = other.id_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF5E RID: 53086 RVA: 0x001E8991 File Offset: 0x001E6B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingAreaConfig Clone()
		{
			return new LoadingAreaConfig(this);
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x0600CF5F RID: 53087 RVA: 0x001E8999 File Offset: 0x001E6B99
		// (set) Token: 0x0600CF60 RID: 53088 RVA: 0x001E89A1 File Offset: 0x001E6BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0600CF61 RID: 53089 RVA: 0x001E89AA File Offset: 0x001E6BAA
		// (set) Token: 0x0600CF62 RID: 53090 RVA: 0x001E89B2 File Offset: 0x001E6BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BeginTime
		{
			get
			{
				return this.beginTime_;
			}
			set
			{
				this.beginTime_ = value;
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0600CF63 RID: 53091 RVA: 0x001E89BB File Offset: 0x001E6BBB
		// (set) Token: 0x0600CF64 RID: 53092 RVA: 0x001E89C3 File Offset: 0x001E6BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x0600CF65 RID: 53093 RVA: 0x001E89CC File Offset: 0x001E6BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadingAreaConfig);
		}

		// Token: 0x0600CF66 RID: 53094 RVA: 0x001E89DC File Offset: 0x001E6BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadingAreaConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF67 RID: 53095 RVA: 0x001E8A38 File Offset: 0x001E6C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.BeginTime != 0L)
			{
				num ^= this.BeginTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CF68 RID: 53096 RVA: 0x001E8AA9 File Offset: 0x001E6CA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF69 RID: 53097 RVA: 0x001E8AB6 File Offset: 0x001E6CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF6A RID: 53098 RVA: 0x001E8AC0 File Offset: 0x001E6CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.BeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF6B RID: 53099 RVA: 0x001E8B34 File Offset: 0x001E6D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.BeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BeginTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CF6C RID: 53100 RVA: 0x001E8BA4 File Offset: 0x001E6DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadingAreaConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.BeginTime != 0L)
			{
				this.BeginTime = other.BeginTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x001E8C08 File Offset: 0x001E6E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF6E RID: 53102 RVA: 0x001E8C14 File Offset: 0x001E6E14
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EndTime = input.ReadInt64();
						}
					}
					else
					{
						this.BeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040057D1 RID: 22481
		private static readonly MessageParser<LoadingAreaConfig> _parser = new MessageParser<LoadingAreaConfig>(() => new LoadingAreaConfig());

		// Token: 0x040057D2 RID: 22482
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057D3 RID: 22483
		public const int IdFieldNumber = 1;

		// Token: 0x040057D4 RID: 22484
		private int id_;

		// Token: 0x040057D5 RID: 22485
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x040057D6 RID: 22486
		private long beginTime_;

		// Token: 0x040057D7 RID: 22487
		public const int EndTimeFieldNumber = 3;

		// Token: 0x040057D8 RID: 22488
		private long endTime_;
	}
}
