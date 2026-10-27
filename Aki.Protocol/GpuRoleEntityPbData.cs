using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070C RID: 1804
	public sealed class GpuRoleEntityPbData : IMessage<GpuRoleEntityPbData>, IMessage, IEquatable<GpuRoleEntityPbData>, IDeepCloneable<GpuRoleEntityPbData>, IBufferMessage
	{
		// Token: 0x0600A426 RID: 42022 RVA: 0x0018C74C File Offset: 0x0018A94C
		[NullableContext(1)]
		public static GpuRoleEntityPbData Create()
		{
			return new GpuRoleEntityPbData();
		}

		// Token: 0x17002103 RID: 8451
		// (get) Token: 0x0600A427 RID: 42023 RVA: 0x0018C753 File Offset: 0x0018A953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002104 RID: 8452
		// (get) Token: 0x0600A428 RID: 42024 RVA: 0x0018C756 File Offset: 0x0018A956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuRoleEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600A429 RID: 42025 RVA: 0x0018C75D File Offset: 0x0018A95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuRoleEntityPbData()
		{
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x0018C765 File Offset: 0x0018A965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuRoleEntityPbData(GpuRoleEntityPbData other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x0018C78A File Offset: 0x0018A98A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuRoleEntityPbData Clone()
		{
			return new GpuRoleEntityPbData(this);
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x0600A42C RID: 42028 RVA: 0x0018C792 File Offset: 0x0018A992
		// (set) Token: 0x0600A42D RID: 42029 RVA: 0x0018C79A File Offset: 0x0018A99A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x0600A42E RID: 42030 RVA: 0x0018C7A3 File Offset: 0x0018A9A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuRoleEntityPbData);
		}

		// Token: 0x0600A42F RID: 42031 RVA: 0x0018C7B1 File Offset: 0x0018A9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuRoleEntityPbData other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A430 RID: 42032 RVA: 0x0018C7E0 File Offset: 0x0018A9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0L)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A431 RID: 42033 RVA: 0x0018C81F File Offset: 0x0018AA1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A432 RID: 42034 RVA: 0x0018C82C File Offset: 0x0018AA2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x0018C835 File Offset: 0x0018AA35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x0018C868 File Offset: 0x0018AA68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A435 RID: 42037 RVA: 0x0018C8A6 File Offset: 0x0018AAA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GpuRoleEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0L)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A436 RID: 42038 RVA: 0x0018C8D7 File Offset: 0x0018AAD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x0018C8E0 File Offset: 0x0018AAE0
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004BBE RID: 19390
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BBF RID: 19391
		public const int IncIdFieldNumber = 1;

		// Token: 0x04004BC0 RID: 19392
		private long incId_;
	}
}
