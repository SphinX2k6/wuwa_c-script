using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003F9 RID: 1017
	[NetMessage(EMessageId.DollGrabTimeBallRequest)]
	public sealed class DollGrabTimeBallRequest : IMessage<DollGrabTimeBallRequest>, IMessage, IEquatable<DollGrabTimeBallRequest>, IDeepCloneable<DollGrabTimeBallRequest>, IBufferMessage
	{
		// Token: 0x0600625B RID: 25179 RVA: 0x000ECE58 File Offset: 0x000EB058
		[NullableContext(1)]
		public static DollGrabTimeBallRequest Create()
		{
			return new DollGrabTimeBallRequest();
		}

		// Token: 0x17001255 RID: 4693
		// (get) Token: 0x0600625C RID: 25180 RVA: 0x000ECE5F File Offset: 0x000EB05F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001256 RID: 4694
		// (get) Token: 0x0600625D RID: 25181 RVA: 0x000ECE62 File Offset: 0x000EB062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabTimeBallRequest.Descriptor;
			}
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x000ECE69 File Offset: 0x000EB069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallRequest()
		{
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x000ECE71 File Offset: 0x000EB071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallRequest(DollGrabTimeBallRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.itemUniId_ = other.itemUniId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006260 RID: 25184 RVA: 0x000ECEA2 File Offset: 0x000EB0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallRequest Clone()
		{
			return new DollGrabTimeBallRequest(this);
		}

		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x06006261 RID: 25185 RVA: 0x000ECEAA File Offset: 0x000EB0AA
		// (set) Token: 0x06006262 RID: 25186 RVA: 0x000ECEB2 File Offset: 0x000EB0B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x06006263 RID: 25187 RVA: 0x000ECEBB File Offset: 0x000EB0BB
		// (set) Token: 0x06006264 RID: 25188 RVA: 0x000ECEC3 File Offset: 0x000EB0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUniId
		{
			get
			{
				return this.itemUniId_;
			}
			set
			{
				this.itemUniId_ = value;
			}
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x000ECECC File Offset: 0x000EB0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabTimeBallRequest);
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x000ECEDA File Offset: 0x000EB0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabTimeBallRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.ItemUniId == other.ItemUniId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x000ECF18 File Offset: 0x000EB118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.ItemUniId != 0)
			{
				num ^= this.ItemUniId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x000ECF70 File Offset: 0x000EB170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x000ECF7D File Offset: 0x000EB17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x000ECF88 File Offset: 0x000EB188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.EntityIncId);
			}
			if (this.ItemUniId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ItemUniId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x000ECFE4 File Offset: 0x000EB1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.ItemUniId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUniId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x000ED03C File Offset: 0x000EB23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabTimeBallRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.ItemUniId != 0)
			{
				this.ItemUniId = other.ItemUniId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x000ED08C File Offset: 0x000EB28C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x000ED098 File Offset: 0x000EB298
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
				if (num != 48U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemUniId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x040037D5 RID: 14293
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037D6 RID: 14294
		public const int EntityIncIdFieldNumber = 6;

		// Token: 0x040037D7 RID: 14295
		private long entityIncId_;

		// Token: 0x040037D8 RID: 14296
		public const int ItemUniIdFieldNumber = 9;

		// Token: 0x040037D9 RID: 14297
		private int itemUniId_;
	}
}
