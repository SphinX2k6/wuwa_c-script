using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B80 RID: 2944
	public sealed class OneSynthesisConfig : IMessage<OneSynthesisConfig>, IMessage, IEquatable<OneSynthesisConfig>, IDeepCloneable<OneSynthesisConfig>, IBufferMessage
	{
		// Token: 0x0600FFB2 RID: 65458 RVA: 0x00255708 File Offset: 0x00253908
		[NullableContext(1)]
		public static OneSynthesisConfig Create()
		{
			return new OneSynthesisConfig();
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600FFB3 RID: 65459 RVA: 0x0025570F File Offset: 0x0025390F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneSynthesisConfig> Parser
		{
			get
			{
				return OneSynthesisConfig._parser;
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600FFB4 RID: 65460 RVA: 0x00255716 File Offset: 0x00253916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600FFB5 RID: 65461 RVA: 0x00255719 File Offset: 0x00253919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneSynthesisConfig.Descriptor;
			}
		}

		// Token: 0x0600FFB6 RID: 65462 RVA: 0x00255720 File Offset: 0x00253920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisConfig()
		{
		}

		// Token: 0x0600FFB7 RID: 65463 RVA: 0x00255728 File Offset: 0x00253928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisConfig(OneSynthesisConfig other) : this()
		{
			this.id_ = other.id_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FFB8 RID: 65464 RVA: 0x00255765 File Offset: 0x00253965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisConfig Clone()
		{
			return new OneSynthesisConfig(this);
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600FFB9 RID: 65465 RVA: 0x0025576D File Offset: 0x0025396D
		// (set) Token: 0x0600FFBA RID: 65466 RVA: 0x00255775 File Offset: 0x00253975
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

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600FFBB RID: 65467 RVA: 0x0025577E File Offset: 0x0025397E
		// (set) Token: 0x0600FFBC RID: 65468 RVA: 0x00255786 File Offset: 0x00253986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitBeginTime
		{
			get
			{
				return this.limitBeginTime_;
			}
			set
			{
				this.limitBeginTime_ = value;
			}
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600FFBD RID: 65469 RVA: 0x0025578F File Offset: 0x0025398F
		// (set) Token: 0x0600FFBE RID: 65470 RVA: 0x00255797 File Offset: 0x00253997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x0600FFBF RID: 65471 RVA: 0x002557A0 File Offset: 0x002539A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneSynthesisConfig);
		}

		// Token: 0x0600FFC0 RID: 65472 RVA: 0x002557B0 File Offset: 0x002539B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneSynthesisConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FFC1 RID: 65473 RVA: 0x0025580C File Offset: 0x00253A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.LimitBeginTime != 0L)
			{
				num ^= this.LimitBeginTime.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FFC2 RID: 65474 RVA: 0x0025587D File Offset: 0x00253A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FFC3 RID: 65475 RVA: 0x0025588A File Offset: 0x00253A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FFC4 RID: 65476 RVA: 0x00255894 File Offset: 0x00253A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.LimitBeginTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FFC5 RID: 65477 RVA: 0x00255908 File Offset: 0x00253B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.LimitBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitBeginTime);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FFC6 RID: 65478 RVA: 0x00255978 File Offset: 0x00253B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneSynthesisConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.LimitBeginTime != 0L)
			{
				this.LimitBeginTime = other.LimitBeginTime;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FFC7 RID: 65479 RVA: 0x002559DC File Offset: 0x00253BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FFC8 RID: 65480 RVA: 0x002559E8 File Offset: 0x00253BE8
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
							this.LimitEndTime = input.ReadInt64();
						}
					}
					else
					{
						this.LimitBeginTime = input.ReadInt64();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006658 RID: 26200
		private static readonly MessageParser<OneSynthesisConfig> _parser = new MessageParser<OneSynthesisConfig>(() => new OneSynthesisConfig());

		// Token: 0x04006659 RID: 26201
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400665A RID: 26202
		public const int IdFieldNumber = 1;

		// Token: 0x0400665B RID: 26203
		private int id_;

		// Token: 0x0400665C RID: 26204
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x0400665D RID: 26205
		private long limitBeginTime_;

		// Token: 0x0400665E RID: 26206
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x0400665F RID: 26207
		private long limitEndTime_;
	}
}
