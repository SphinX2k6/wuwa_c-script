using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095D RID: 2397
	public sealed class LordGymEntranceInfo : IMessage<LordGymEntranceInfo>, IMessage, IEquatable<LordGymEntranceInfo>, IDeepCloneable<LordGymEntranceInfo>, IBufferMessage
	{
		// Token: 0x0600D333 RID: 54067 RVA: 0x001F1E44 File Offset: 0x001F0044
		[NullableContext(1)]
		public static LordGymEntranceInfo Create()
		{
			return new LordGymEntranceInfo();
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x0600D334 RID: 54068 RVA: 0x001F1E4B File Offset: 0x001F004B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LordGymEntranceInfo> Parser
		{
			get
			{
				return LordGymEntranceInfo._parser;
			}
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x0600D335 RID: 54069 RVA: 0x001F1E52 File Offset: 0x001F0052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0600D336 RID: 54070 RVA: 0x001F1E55 File Offset: 0x001F0055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymEntranceInfo.Descriptor;
			}
		}

		// Token: 0x0600D337 RID: 54071 RVA: 0x001F1E5C File Offset: 0x001F005C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymEntranceInfo()
		{
		}

		// Token: 0x0600D338 RID: 54072 RVA: 0x001F1E64 File Offset: 0x001F0064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymEntranceInfo(LordGymEntranceInfo other) : this()
		{
			this.id_ = other.id_;
			this.effectBeginTime_ = other.effectBeginTime_;
			this.effectEndTime_ = other.effectEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D339 RID: 54073 RVA: 0x001F1EA1 File Offset: 0x001F00A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymEntranceInfo Clone()
		{
			return new LordGymEntranceInfo(this);
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600D33A RID: 54074 RVA: 0x001F1EA9 File Offset: 0x001F00A9
		// (set) Token: 0x0600D33B RID: 54075 RVA: 0x001F1EB1 File Offset: 0x001F00B1
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

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600D33C RID: 54076 RVA: 0x001F1EBA File Offset: 0x001F00BA
		// (set) Token: 0x0600D33D RID: 54077 RVA: 0x001F1EC2 File Offset: 0x001F00C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EffectBeginTime
		{
			get
			{
				return this.effectBeginTime_;
			}
			set
			{
				this.effectBeginTime_ = value;
			}
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x0600D33E RID: 54078 RVA: 0x001F1ECB File Offset: 0x001F00CB
		// (set) Token: 0x0600D33F RID: 54079 RVA: 0x001F1ED3 File Offset: 0x001F00D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EffectEndTime
		{
			get
			{
				return this.effectEndTime_;
			}
			set
			{
				this.effectEndTime_ = value;
			}
		}

		// Token: 0x0600D340 RID: 54080 RVA: 0x001F1EDC File Offset: 0x001F00DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymEntranceInfo);
		}

		// Token: 0x0600D341 RID: 54081 RVA: 0x001F1EEC File Offset: 0x001F00EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymEntranceInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EffectBeginTime == other.EffectBeginTime && this.EffectEndTime == other.EffectEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D342 RID: 54082 RVA: 0x001F1F48 File Offset: 0x001F0148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EffectBeginTime != 0L)
			{
				num ^= this.EffectBeginTime.GetHashCode();
			}
			if (this.EffectEndTime != 0L)
			{
				num ^= this.EffectEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D343 RID: 54083 RVA: 0x001F1FB9 File Offset: 0x001F01B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D344 RID: 54084 RVA: 0x001F1FC6 File Offset: 0x001F01C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D345 RID: 54085 RVA: 0x001F1FD0 File Offset: 0x001F01D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.EffectBeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EffectBeginTime);
			}
			if (this.EffectEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EffectEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D346 RID: 54086 RVA: 0x001F2044 File Offset: 0x001F0244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.EffectBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EffectBeginTime);
			}
			if (this.EffectEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EffectEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D347 RID: 54087 RVA: 0x001F20B4 File Offset: 0x001F02B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymEntranceInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.EffectBeginTime != 0L)
			{
				this.EffectBeginTime = other.EffectBeginTime;
			}
			if (other.EffectEndTime != 0L)
			{
				this.EffectEndTime = other.EffectEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D348 RID: 54088 RVA: 0x001F2118 File Offset: 0x001F0318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D349 RID: 54089 RVA: 0x001F2124 File Offset: 0x001F0324
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
							this.EffectEndTime = input.ReadInt64();
						}
					}
					else
					{
						this.EffectBeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040058C5 RID: 22725
		private static readonly MessageParser<LordGymEntranceInfo> _parser = new MessageParser<LordGymEntranceInfo>(() => new LordGymEntranceInfo());

		// Token: 0x040058C6 RID: 22726
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058C7 RID: 22727
		public const int IdFieldNumber = 1;

		// Token: 0x040058C8 RID: 22728
		private int id_;

		// Token: 0x040058C9 RID: 22729
		public const int EffectBeginTimeFieldNumber = 2;

		// Token: 0x040058CA RID: 22730
		private long effectBeginTime_;

		// Token: 0x040058CB RID: 22731
		public const int EffectEndTimeFieldNumber = 3;

		// Token: 0x040058CC RID: 22732
		private long effectEndTime_;
	}
}
