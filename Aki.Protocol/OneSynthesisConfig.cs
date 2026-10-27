using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B90 RID: 2960
	public sealed class OneSynthesisConfig : IMessage<OneSynthesisConfig>, IMessage, IEquatable<OneSynthesisConfig>, IDeepCloneable<OneSynthesisConfig>, IBufferMessage
	{
		// Token: 0x060100B6 RID: 65718 RVA: 0x002575D8 File Offset: 0x002557D8
		[NullableContext(1)]
		public static OneSynthesisConfig Create()
		{
			return new OneSynthesisConfig();
		}

		// Token: 0x17003485 RID: 13445
		// (get) Token: 0x060100B7 RID: 65719 RVA: 0x002575DF File Offset: 0x002557DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneSynthesisConfig> Parser
		{
			get
			{
				return OneSynthesisConfig._parser;
			}
		}

		// Token: 0x17003486 RID: 13446
		// (get) Token: 0x060100B8 RID: 65720 RVA: 0x002575E6 File Offset: 0x002557E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003487 RID: 13447
		// (get) Token: 0x060100B9 RID: 65721 RVA: 0x002575E9 File Offset: 0x002557E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneSynthesisConfig.Descriptor;
			}
		}

		// Token: 0x060100BA RID: 65722 RVA: 0x002575F0 File Offset: 0x002557F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisConfig()
		{
		}

		// Token: 0x060100BB RID: 65723 RVA: 0x002575F8 File Offset: 0x002557F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisConfig(OneSynthesisConfig other) : this()
		{
			this.id_ = other.id_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060100BC RID: 65724 RVA: 0x00257635 File Offset: 0x00255835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSynthesisConfig Clone()
		{
			return new OneSynthesisConfig(this);
		}

		// Token: 0x17003488 RID: 13448
		// (get) Token: 0x060100BD RID: 65725 RVA: 0x0025763D File Offset: 0x0025583D
		// (set) Token: 0x060100BE RID: 65726 RVA: 0x00257645 File Offset: 0x00255845
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

		// Token: 0x17003489 RID: 13449
		// (get) Token: 0x060100BF RID: 65727 RVA: 0x0025764E File Offset: 0x0025584E
		// (set) Token: 0x060100C0 RID: 65728 RVA: 0x00257656 File Offset: 0x00255856
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

		// Token: 0x1700348A RID: 13450
		// (get) Token: 0x060100C1 RID: 65729 RVA: 0x0025765F File Offset: 0x0025585F
		// (set) Token: 0x060100C2 RID: 65730 RVA: 0x00257667 File Offset: 0x00255867
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

		// Token: 0x060100C3 RID: 65731 RVA: 0x00257670 File Offset: 0x00255870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneSynthesisConfig);
		}

		// Token: 0x060100C4 RID: 65732 RVA: 0x00257680 File Offset: 0x00255880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneSynthesisConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060100C5 RID: 65733 RVA: 0x002576DC File Offset: 0x002558DC
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

		// Token: 0x060100C6 RID: 65734 RVA: 0x0025774D File Offset: 0x0025594D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060100C7 RID: 65735 RVA: 0x0025775A File Offset: 0x0025595A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060100C8 RID: 65736 RVA: 0x00257764 File Offset: 0x00255964
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

		// Token: 0x060100C9 RID: 65737 RVA: 0x002577D8 File Offset: 0x002559D8
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

		// Token: 0x060100CA RID: 65738 RVA: 0x00257848 File Offset: 0x00255A48
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

		// Token: 0x060100CB RID: 65739 RVA: 0x002578AC File Offset: 0x00255AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060100CC RID: 65740 RVA: 0x002578B8 File Offset: 0x00255AB8
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

		// Token: 0x04006648 RID: 26184
		private static readonly MessageParser<OneSynthesisConfig> _parser = new MessageParser<OneSynthesisConfig>(() => new OneSynthesisConfig());

		// Token: 0x04006649 RID: 26185
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400664A RID: 26186
		public const int IdFieldNumber = 1;

		// Token: 0x0400664B RID: 26187
		private int id_;

		// Token: 0x0400664C RID: 26188
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x0400664D RID: 26189
		private long limitBeginTime_;

		// Token: 0x0400664E RID: 26190
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x0400664F RID: 26191
		private long limitEndTime_;
	}
}
