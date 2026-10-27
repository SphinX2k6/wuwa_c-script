using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD4 RID: 3540
	public sealed class PreOpenDetections : IMessage<PreOpenDetections>, IMessage, IEquatable<PreOpenDetections>, IDeepCloneable<PreOpenDetections>, IBufferMessage
	{
		// Token: 0x060130DD RID: 78045 RVA: 0x002C6D7C File Offset: 0x002C4F7C
		[NullableContext(1)]
		public static PreOpenDetections Create()
		{
			return new PreOpenDetections();
		}

		// Token: 0x17003F38 RID: 16184
		// (get) Token: 0x060130DE RID: 78046 RVA: 0x002C6D83 File Offset: 0x002C4F83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PreOpenDetections> Parser
		{
			get
			{
				return PreOpenDetections._parser;
			}
		}

		// Token: 0x17003F39 RID: 16185
		// (get) Token: 0x060130DF RID: 78047 RVA: 0x002C6D8A File Offset: 0x002C4F8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F3A RID: 16186
		// (get) Token: 0x060130E0 RID: 78048 RVA: 0x002C6D8D File Offset: 0x002C4F8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreOpenDetections.Descriptor;
			}
		}

		// Token: 0x060130E1 RID: 78049 RVA: 0x002C6D94 File Offset: 0x002C4F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetections()
		{
		}

		// Token: 0x060130E2 RID: 78050 RVA: 0x002C6D9C File Offset: 0x002C4F9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetections(PreOpenDetections other) : this()
		{
			this.id_ = other.id_;
			this.preOpenId_ = other.preOpenId_;
			this.preOpenBeginTime_ = other.preOpenBeginTime_;
			this.preOpenEndTime_ = other.preOpenEndTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060130E3 RID: 78051 RVA: 0x002C6DF0 File Offset: 0x002C4FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreOpenDetections Clone()
		{
			return new PreOpenDetections(this);
		}

		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x060130E4 RID: 78052 RVA: 0x002C6DF8 File Offset: 0x002C4FF8
		// (set) Token: 0x060130E5 RID: 78053 RVA: 0x002C6E00 File Offset: 0x002C5000
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

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x060130E6 RID: 78054 RVA: 0x002C6E09 File Offset: 0x002C5009
		// (set) Token: 0x060130E7 RID: 78055 RVA: 0x002C6E11 File Offset: 0x002C5011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreOpenId
		{
			get
			{
				return this.preOpenId_;
			}
			set
			{
				this.preOpenId_ = value;
			}
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x060130E8 RID: 78056 RVA: 0x002C6E1A File Offset: 0x002C501A
		// (set) Token: 0x060130E9 RID: 78057 RVA: 0x002C6E22 File Offset: 0x002C5022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreOpenBeginTime
		{
			get
			{
				return this.preOpenBeginTime_;
			}
			set
			{
				this.preOpenBeginTime_ = value;
			}
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x060130EA RID: 78058 RVA: 0x002C6E2B File Offset: 0x002C502B
		// (set) Token: 0x060130EB RID: 78059 RVA: 0x002C6E33 File Offset: 0x002C5033
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreOpenEndTime
		{
			get
			{
				return this.preOpenEndTime_;
			}
			set
			{
				this.preOpenEndTime_ = value;
			}
		}

		// Token: 0x060130EC RID: 78060 RVA: 0x002C6E3C File Offset: 0x002C503C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreOpenDetections);
		}

		// Token: 0x060130ED RID: 78061 RVA: 0x002C6E4C File Offset: 0x002C504C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreOpenDetections other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.PreOpenId == other.PreOpenId && this.PreOpenBeginTime == other.PreOpenBeginTime && this.PreOpenEndTime == other.PreOpenEndTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060130EE RID: 78062 RVA: 0x002C6EB8 File Offset: 0x002C50B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.PreOpenId != 0)
			{
				num ^= this.PreOpenId.GetHashCode();
			}
			if (this.PreOpenBeginTime != 0L)
			{
				num ^= this.PreOpenBeginTime.GetHashCode();
			}
			if (this.PreOpenEndTime != 0L)
			{
				num ^= this.PreOpenEndTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060130EF RID: 78063 RVA: 0x002C6F42 File Offset: 0x002C5142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060130F0 RID: 78064 RVA: 0x002C6F4F File Offset: 0x002C514F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060130F1 RID: 78065 RVA: 0x002C6F58 File Offset: 0x002C5158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.PreOpenId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PreOpenId);
			}
			if (this.PreOpenBeginTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.PreOpenBeginTime);
			}
			if (this.PreOpenEndTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.PreOpenEndTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060130F2 RID: 78066 RVA: 0x002C6FE8 File Offset: 0x002C51E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.PreOpenId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreOpenId);
			}
			if (this.PreOpenBeginTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreOpenBeginTime);
			}
			if (this.PreOpenEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreOpenEndTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060130F3 RID: 78067 RVA: 0x002C7070 File Offset: 0x002C5270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreOpenDetections other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.PreOpenId != 0)
			{
				this.PreOpenId = other.PreOpenId;
			}
			if (other.PreOpenBeginTime != 0L)
			{
				this.PreOpenBeginTime = other.PreOpenBeginTime;
			}
			if (other.PreOpenEndTime != 0L)
			{
				this.PreOpenEndTime = other.PreOpenEndTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060130F4 RID: 78068 RVA: 0x002C70E8 File Offset: 0x002C52E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060130F5 RID: 78069 RVA: 0x002C70F4 File Offset: 0x002C52F4
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
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.PreOpenId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PreOpenBeginTime = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.PreOpenEndTime = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007594 RID: 30100
		private static readonly MessageParser<PreOpenDetections> _parser = new MessageParser<PreOpenDetections>(() => new PreOpenDetections());

		// Token: 0x04007595 RID: 30101
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007596 RID: 30102
		public const int IdFieldNumber = 1;

		// Token: 0x04007597 RID: 30103
		private int id_;

		// Token: 0x04007598 RID: 30104
		public const int PreOpenIdFieldNumber = 2;

		// Token: 0x04007599 RID: 30105
		private int preOpenId_;

		// Token: 0x0400759A RID: 30106
		public const int PreOpenBeginTimeFieldNumber = 3;

		// Token: 0x0400759B RID: 30107
		private long preOpenBeginTime_;

		// Token: 0x0400759C RID: 30108
		public const int PreOpenEndTimeFieldNumber = 4;

		// Token: 0x0400759D RID: 30109
		private long preOpenEndTime_;
	}
}
