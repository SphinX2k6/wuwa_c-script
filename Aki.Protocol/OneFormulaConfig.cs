using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7A RID: 2938
	public sealed class OneFormulaConfig : IMessage<OneFormulaConfig>, IMessage, IEquatable<OneFormulaConfig>, IDeepCloneable<OneFormulaConfig>, IBufferMessage
	{
		// Token: 0x0600FF28 RID: 65320 RVA: 0x002542F4 File Offset: 0x002524F4
		[NullableContext(1)]
		public static OneFormulaConfig Create()
		{
			return new OneFormulaConfig();
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600FF29 RID: 65321 RVA: 0x002542FB File Offset: 0x002524FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneFormulaConfig> Parser
		{
			get
			{
				return OneFormulaConfig._parser;
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600FF2A RID: 65322 RVA: 0x00254302 File Offset: 0x00252502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600FF2B RID: 65323 RVA: 0x00254305 File Offset: 0x00252505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneFormulaConfig.Descriptor;
			}
		}

		// Token: 0x0600FF2C RID: 65324 RVA: 0x0025430C File Offset: 0x0025250C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFormulaConfig()
		{
		}

		// Token: 0x0600FF2D RID: 65325 RVA: 0x00254314 File Offset: 0x00252514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFormulaConfig(OneFormulaConfig other) : this()
		{
			this.id_ = other.id_;
			this.limitBeginTime_ = other.limitBeginTime_;
			this.limitEndTime_ = other.limitEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FF2E RID: 65326 RVA: 0x00254351 File Offset: 0x00252551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFormulaConfig Clone()
		{
			return new OneFormulaConfig(this);
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600FF2F RID: 65327 RVA: 0x00254359 File Offset: 0x00252559
		// (set) Token: 0x0600FF30 RID: 65328 RVA: 0x00254361 File Offset: 0x00252561
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

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600FF31 RID: 65329 RVA: 0x0025436A File Offset: 0x0025256A
		// (set) Token: 0x0600FF32 RID: 65330 RVA: 0x00254372 File Offset: 0x00252572
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

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600FF33 RID: 65331 RVA: 0x0025437B File Offset: 0x0025257B
		// (set) Token: 0x0600FF34 RID: 65332 RVA: 0x00254383 File Offset: 0x00252583
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

		// Token: 0x0600FF35 RID: 65333 RVA: 0x0025438C File Offset: 0x0025258C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneFormulaConfig);
		}

		// Token: 0x0600FF36 RID: 65334 RVA: 0x0025439C File Offset: 0x0025259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneFormulaConfig other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.LimitBeginTime == other.LimitBeginTime && this.LimitEndTime == other.LimitEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FF37 RID: 65335 RVA: 0x002543F8 File Offset: 0x002525F8
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

		// Token: 0x0600FF38 RID: 65336 RVA: 0x00254469 File Offset: 0x00252669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FF39 RID: 65337 RVA: 0x00254476 File Offset: 0x00252676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FF3A RID: 65338 RVA: 0x00254480 File Offset: 0x00252680
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

		// Token: 0x0600FF3B RID: 65339 RVA: 0x002544F4 File Offset: 0x002526F4
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

		// Token: 0x0600FF3C RID: 65340 RVA: 0x00254564 File Offset: 0x00252764
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

		// Token: 0x0600FF3D RID: 65341 RVA: 0x002545C8 File Offset: 0x002527C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FF3E RID: 65342 RVA: 0x002545D4 File Offset: 0x002527D4
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

		// Token: 0x04006626 RID: 26150
		private static readonly MessageParser<OneFormulaConfig> _parser = new MessageParser<OneFormulaConfig>(() => new OneFormulaConfig());

		// Token: 0x04006627 RID: 26151
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006628 RID: 26152
		public const int IdFieldNumber = 1;

		// Token: 0x04006629 RID: 26153
		private int id_;

		// Token: 0x0400662A RID: 26154
		public const int LimitBeginTimeFieldNumber = 2;

		// Token: 0x0400662B RID: 26155
		private long limitBeginTime_;

		// Token: 0x0400662C RID: 26156
		public const int LimitEndTimeFieldNumber = 3;

		// Token: 0x0400662D RID: 26157
		private long limitEndTime_;
	}
}
