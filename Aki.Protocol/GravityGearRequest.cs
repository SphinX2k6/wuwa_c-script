using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000712 RID: 1810
	[NetMessage(EMessageId.GravityGearRequest)]
	public sealed class GravityGearRequest : IMessage<GravityGearRequest>, IMessage, IEquatable<GravityGearRequest>, IDeepCloneable<GravityGearRequest>, IBufferMessage
	{
		// Token: 0x0600A498 RID: 42136 RVA: 0x0018D4B4 File Offset: 0x0018B6B4
		[NullableContext(1)]
		public static GravityGearRequest Create()
		{
			return new GravityGearRequest();
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x0600A499 RID: 42137 RVA: 0x0018D4BB File Offset: 0x0018B6BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x0600A49A RID: 42138 RVA: 0x0018D4BE File Offset: 0x0018B6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityGearRequest.Descriptor;
			}
		}

		// Token: 0x0600A49B RID: 42139 RVA: 0x0018D4C5 File Offset: 0x0018B6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearRequest()
		{
		}

		// Token: 0x0600A49C RID: 42140 RVA: 0x0018D4CD File Offset: 0x0018B6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearRequest(GravityGearRequest other) : this()
		{
			this.entityConfId_ = other.entityConfId_;
			this.gravityGearOperate_ = other.gravityGearOperate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A49D RID: 42141 RVA: 0x0018D4FE File Offset: 0x0018B6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearRequest Clone()
		{
			return new GravityGearRequest(this);
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x0600A49E RID: 42142 RVA: 0x0018D506 File Offset: 0x0018B706
		// (set) Token: 0x0600A49F RID: 42143 RVA: 0x0018D50E File Offset: 0x0018B70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfId
		{
			get
			{
				return this.entityConfId_;
			}
			set
			{
				this.entityConfId_ = value;
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x0600A4A0 RID: 42144 RVA: 0x0018D517 File Offset: 0x0018B717
		// (set) Token: 0x0600A4A1 RID: 42145 RVA: 0x0018D51F File Offset: 0x0018B71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityGearOperate GravityGearOperate
		{
			get
			{
				return this.gravityGearOperate_;
			}
			set
			{
				this.gravityGearOperate_ = value;
			}
		}

		// Token: 0x0600A4A2 RID: 42146 RVA: 0x0018D528 File Offset: 0x0018B728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityGearRequest);
		}

		// Token: 0x0600A4A3 RID: 42147 RVA: 0x0018D536 File Offset: 0x0018B736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityGearRequest other)
		{
			return other != null && (other == this || (this.EntityConfId == other.EntityConfId && this.GravityGearOperate == other.GravityGearOperate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4A4 RID: 42148 RVA: 0x0018D574 File Offset: 0x0018B774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityConfId != 0)
			{
				num ^= this.EntityConfId.GetHashCode();
			}
			if (this.GravityGearOperate != GravityGearOperate.InActive)
			{
				num ^= this.GravityGearOperate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4A5 RID: 42149 RVA: 0x0018D5D2 File Offset: 0x0018B7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4A6 RID: 42150 RVA: 0x0018D5DF File Offset: 0x0018B7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4A7 RID: 42151 RVA: 0x0018D5E8 File Offset: 0x0018B7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GravityGearOperate != GravityGearOperate.InActive)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.GravityGearOperate);
			}
			if (this.EntityConfId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.EntityConfId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4A8 RID: 42152 RVA: 0x0018D644 File Offset: 0x0018B844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfId);
			}
			if (this.GravityGearOperate != GravityGearOperate.InActive)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GravityGearOperate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4A9 RID: 42153 RVA: 0x0018D69C File Offset: 0x0018B89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityGearRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityConfId != 0)
			{
				this.EntityConfId = other.EntityConfId;
			}
			if (other.GravityGearOperate != GravityGearOperate.InActive)
			{
				this.GravityGearOperate = other.GravityGearOperate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4AA RID: 42154 RVA: 0x0018D6EC File Offset: 0x0018B8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4AB RID: 42155 RVA: 0x0018D6F8 File Offset: 0x0018B8F8
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
				if (num != 16U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityConfId = input.ReadInt32();
					}
				}
				else
				{
					this.GravityGearOperate = (GravityGearOperate)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BD6 RID: 19414
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BD7 RID: 19415
		public const int EntityConfIdFieldNumber = 6;

		// Token: 0x04004BD8 RID: 19416
		private int entityConfId_;

		// Token: 0x04004BD9 RID: 19417
		public const int GravityGearOperateFieldNumber = 2;

		// Token: 0x04004BDA RID: 19418
		private GravityGearOperate gravityGearOperate_;
	}
}
