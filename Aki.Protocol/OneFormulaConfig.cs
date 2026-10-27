using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8A RID: 2954
	public sealed class OneFormulaConfig : IMessage<OneFormulaConfig>, IMessage, IEquatable<OneFormulaConfig>, IDeepCloneable<OneFormulaConfig>, IBufferMessage
	{
		// Token: 0x0601002C RID: 65580 RVA: 0x002561C4 File Offset: 0x002543C4
		[NullableContext(1)]
		public static OneFormulaConfig Create()
		{
			return new OneFormulaConfig();
		}

		// Token: 0x17003462 RID: 13410
		// (get) Token: 0x0601002D RID: 65581 RVA: 0x002561CB File Offset: 0x002543CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFormulaConfig> Parser
		{
			get
			{
				return OneFormulaConfig._parser;
			}
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0601002E RID: 65582 RVA: 0x002561D2 File Offset: 0x002543D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0601002F RID: 65583 RVA: 0x002561D5 File Offset: 0x002543D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFormulaConfig.Descriptor;
			}
		}

		// Token: 0x06010030 RID: 65584 RVA: 0x002561DC File Offset: 0x002543DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFormulaConfig()
		{
		}

		// Token: 0x06010031 RID: 65585 RVA: 0x002561E4 File Offset: 0x002543E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFormulaConfig(OneFormulaConfig other) : this()
		{
			this.id_ = other.id_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010032 RID: 65586 RVA: 0x00256221 File Offset: 0x00254421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFormulaConfig Clone()
		{
			return new OneFormulaConfig(this);
		}

		// Token: 0x17003465 RID: 13413
		// (get) Token: 0x06010033 RID: 65587 RVA: 0x00256229 File Offset: 0x00254429
		// (set) Token: 0x06010034 RID: 65588 RVA: 0x00256231 File Offset: 0x00254431
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

		// Token: 0x17003466 RID: 13414
		// (get) Token: 0x06010035 RID: 65589 RVA: 0x0025623A File Offset: 0x0025443A
		// (set) Token: 0x06010036 RID: 65590 RVA: 0x00256242 File Offset: 0x00254442
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

		// Token: 0x17003467 RID: 13415
		// (get) Token: 0x06010037 RID: 65591 RVA: 0x0025624B File Offset: 0x0025444B
		// (set) Token: 0x06010038 RID: 65592 RVA: 0x00256253 File Offset: 0x00254453
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

		// Token: 0x06010039 RID: 65593 RVA: 0x0025625C File Offset: 0x0025445C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFormulaConfig);
		}

		// Token: 0x0601003A RID: 65594 RVA: 0x0025626C File Offset: 0x0025446C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFormulaConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601003B RID: 65595 RVA: 0x002562C8 File Offset: 0x002544C8
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

		// Token: 0x0601003C RID: 65596 RVA: 0x00256339 File Offset: 0x00254539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601003D RID: 65597 RVA: 0x00256346 File Offset: 0x00254546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601003E RID: 65598 RVA: 0x00256350 File Offset: 0x00254550
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

		// Token: 0x0601003F RID: 65599 RVA: 0x002563C4 File Offset: 0x002545C4
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

		// Token: 0x06010040 RID: 65600 RVA: 0x00256434 File Offset: 0x00254634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneFormulaConfig other)
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

		// Token: 0x06010041 RID: 65601 RVA: 0x00256498 File Offset: 0x00254698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010042 RID: 65602 RVA: 0x002564A4 File Offset: 0x002546A4
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

		// Token: 0x04006616 RID: 26134
		private static readonly MessageParser<OneFormulaConfig> _parser = new MessageParser<OneFormulaConfig>(() => new OneFormulaConfig());

		// Token: 0x04006617 RID: 26135
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006618 RID: 26136
		public const int IdFieldNumber = 1;

		// Token: 0x04006619 RID: 26137
		private int id_;

		// Token: 0x0400661A RID: 26138
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x0400661B RID: 26139
		private long limitBeginTime_;

		// Token: 0x0400661C RID: 26140
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x0400661D RID: 26141
		private long limitEndTime_;
	}
}
