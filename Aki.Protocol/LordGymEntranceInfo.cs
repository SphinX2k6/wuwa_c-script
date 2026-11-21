using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094C RID: 2380
	public sealed class LordGymEntranceInfo : IMessage<LordGymEntranceInfo>, IMessage, IEquatable<LordGymEntranceInfo>, IDeepCloneable<LordGymEntranceInfo>, IBufferMessage
	{
		// Token: 0x0600D219 RID: 53785 RVA: 0x001EFC61 File Offset: 0x001EDE61
		[NullableContext(1)]
		public static LordGymEntranceInfo Create()
		{
			return new LordGymEntranceInfo();
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x0600D21A RID: 53786 RVA: 0x001EFC68 File Offset: 0x001EDE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LordGymEntranceInfo> Parser
		{
			get
			{
				return LordGymEntranceInfo._parser;
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x0600D21B RID: 53787 RVA: 0x001EFC6F File Offset: 0x001EDE6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x0600D21C RID: 53788 RVA: 0x001EFC72 File Offset: 0x001EDE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymEntranceInfo.Descriptor;
			}
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x001EFC79 File Offset: 0x001EDE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymEntranceInfo()
		{
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x001EFC81 File Offset: 0x001EDE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymEntranceInfo(LordGymEntranceInfo other) : this()
		{
			this.id_ = other.id_;
			this.effectBeginTime_ = other.effectBeginTime_;
			this.effectEndTime_ = other.effectEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x001EFCBE File Offset: 0x001EDEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymEntranceInfo Clone()
		{
			return new LordGymEntranceInfo(this);
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x0600D220 RID: 53792 RVA: 0x001EFCC6 File Offset: 0x001EDEC6
		// (set) Token: 0x0600D221 RID: 53793 RVA: 0x001EFCCE File Offset: 0x001EDECE
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

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x0600D222 RID: 53794 RVA: 0x001EFCD7 File Offset: 0x001EDED7
		// (set) Token: 0x0600D223 RID: 53795 RVA: 0x001EFCDF File Offset: 0x001EDEDF
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

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x0600D224 RID: 53796 RVA: 0x001EFCE8 File Offset: 0x001EDEE8
		// (set) Token: 0x0600D225 RID: 53797 RVA: 0x001EFCF0 File Offset: 0x001EDEF0
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

		// Token: 0x0600D226 RID: 53798 RVA: 0x001EFCF9 File Offset: 0x001EDEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymEntranceInfo);
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x001EFD08 File Offset: 0x001EDF08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymEntranceInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.EffectBeginTime == other.EffectBeginTime && this.EffectEndTime == other.EffectEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x001EFD64 File Offset: 0x001EDF64
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

		// Token: 0x0600D229 RID: 53801 RVA: 0x001EFDD5 File Offset: 0x001EDFD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D22A RID: 53802 RVA: 0x001EFDE2 File Offset: 0x001EDFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D22B RID: 53803 RVA: 0x001EFDEC File Offset: 0x001EDFEC
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

		// Token: 0x0600D22C RID: 53804 RVA: 0x001EFE60 File Offset: 0x001EE060
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

		// Token: 0x0600D22D RID: 53805 RVA: 0x001EFED0 File Offset: 0x001EE0D0
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

		// Token: 0x0600D22E RID: 53806 RVA: 0x001EFF34 File Offset: 0x001EE134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D22F RID: 53807 RVA: 0x001EFF40 File Offset: 0x001EE140
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

		// Token: 0x040058CE RID: 22734
		private static readonly MessageParser<LordGymEntranceInfo> _parser = new MessageParser<LordGymEntranceInfo>(() => new LordGymEntranceInfo());

		// Token: 0x040058CF RID: 22735
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058D0 RID: 22736
		public const int IdFieldNumber = 1;

		// Token: 0x040058D1 RID: 22737
		private int id_;

		// Token: 0x040058D2 RID: 22738
		public const int EffectBeginTimeFieldNumber = 2;

		// Token: 0x040058D3 RID: 22739
		private long effectBeginTime_;

		// Token: 0x040058D4 RID: 22740
		public const int EffectEndTimeFieldNumber = 3;

		// Token: 0x040058D5 RID: 22741
		private long effectEndTime_;
	}
}
