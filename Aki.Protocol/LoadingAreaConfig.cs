using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093E RID: 2366
	public sealed class LoadingAreaConfig : IMessage<LoadingAreaConfig>, IMessage, IEquatable<LoadingAreaConfig>, IDeepCloneable<LoadingAreaConfig>, IBufferMessage
	{
		// Token: 0x0600D074 RID: 53364 RVA: 0x001EAC07 File Offset: 0x001E8E07
		[NullableContext(1)]
		public static LoadingAreaConfig Create()
		{
			return new LoadingAreaConfig();
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x0600D075 RID: 53365 RVA: 0x001EAC0E File Offset: 0x001E8E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LoadingAreaConfig> Parser
		{
			get
			{
				return LoadingAreaConfig._parser;
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x0600D076 RID: 53366 RVA: 0x001EAC15 File Offset: 0x001E8E15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x0600D077 RID: 53367 RVA: 0x001EAC18 File Offset: 0x001E8E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadingAreaConfig.Descriptor;
			}
		}

		// Token: 0x0600D078 RID: 53368 RVA: 0x001EAC1F File Offset: 0x001E8E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingAreaConfig()
		{
		}

		// Token: 0x0600D079 RID: 53369 RVA: 0x001EAC27 File Offset: 0x001E8E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingAreaConfig(LoadingAreaConfig other) : this()
		{
			this.id_ = other.id_;
			this.beginTime_ = other.beginTime_;
			this.endTime_ = other.endTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D07A RID: 53370 RVA: 0x001EAC64 File Offset: 0x001E8E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadingAreaConfig Clone()
		{
			return new LoadingAreaConfig(this);
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x0600D07B RID: 53371 RVA: 0x001EAC6C File Offset: 0x001E8E6C
		// (set) Token: 0x0600D07C RID: 53372 RVA: 0x001EAC74 File Offset: 0x001E8E74
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

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x0600D07D RID: 53373 RVA: 0x001EAC7D File Offset: 0x001E8E7D
		// (set) Token: 0x0600D07E RID: 53374 RVA: 0x001EAC85 File Offset: 0x001E8E85
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

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x0600D07F RID: 53375 RVA: 0x001EAC8E File Offset: 0x001E8E8E
		// (set) Token: 0x0600D080 RID: 53376 RVA: 0x001EAC96 File Offset: 0x001E8E96
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

		// Token: 0x0600D081 RID: 53377 RVA: 0x001EAC9F File Offset: 0x001E8E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadingAreaConfig);
		}

		// Token: 0x0600D082 RID: 53378 RVA: 0x001EACB0 File Offset: 0x001E8EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadingAreaConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.BeginTime == other.BeginTime && this.EndTime == other.EndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D083 RID: 53379 RVA: 0x001EAD0C File Offset: 0x001E8F0C
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

		// Token: 0x0600D084 RID: 53380 RVA: 0x001EAD7D File Offset: 0x001E8F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D085 RID: 53381 RVA: 0x001EAD8A File Offset: 0x001E8F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D086 RID: 53382 RVA: 0x001EAD94 File Offset: 0x001E8F94
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

		// Token: 0x0600D087 RID: 53383 RVA: 0x001EAE08 File Offset: 0x001E9008
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

		// Token: 0x0600D088 RID: 53384 RVA: 0x001EAE78 File Offset: 0x001E9078
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

		// Token: 0x0600D089 RID: 53385 RVA: 0x001EAEDC File Offset: 0x001E90DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D08A RID: 53386 RVA: 0x001EAEE8 File Offset: 0x001E90E8
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

		// Token: 0x040057CA RID: 22474
		private static readonly MessageParser<LoadingAreaConfig> _parser = new MessageParser<LoadingAreaConfig>(() => new LoadingAreaConfig());

		// Token: 0x040057CB RID: 22475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057CC RID: 22476
		public const int IdFieldNumber = 1;

		// Token: 0x040057CD RID: 22477
		private int id_;

		// Token: 0x040057CE RID: 22478
		public const int BeginTimeFieldNumber = 2;

		// Token: 0x040057CF RID: 22479
		private long beginTime_;

		// Token: 0x040057D0 RID: 22480
		public const int EndTimeFieldNumber = 3;

		// Token: 0x040057D1 RID: 22481
		private long endTime_;
	}
}
