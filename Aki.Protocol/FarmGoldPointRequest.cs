using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000513 RID: 1299
	[NetMessage(EMessageId.FarmGoldPointRequest)]
	public sealed class FarmGoldPointRequest : IMessage<FarmGoldPointRequest>, IMessage, IEquatable<FarmGoldPointRequest>, IDeepCloneable<FarmGoldPointRequest>, IBufferMessage
	{
		// Token: 0x06007A64 RID: 31332 RVA: 0x00129689 File Offset: 0x00127889
		[NullableContext(1)]
		public static FarmGoldPointRequest Create()
		{
			return new FarmGoldPointRequest();
		}

		// Token: 0x170017B7 RID: 6071
		// (get) Token: 0x06007A65 RID: 31333 RVA: 0x00129690 File Offset: 0x00127890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017B8 RID: 6072
		// (get) Token: 0x06007A66 RID: 31334 RVA: 0x00129693 File Offset: 0x00127893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldPointRequest.Descriptor;
			}
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x0012969A File Offset: 0x0012789A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRequest()
		{
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x001296A2 File Offset: 0x001278A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRequest(FarmGoldPointRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x001296D3 File Offset: 0x001278D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldPointRequest Clone()
		{
			return new FarmGoldPointRequest(this);
		}

		// Token: 0x170017B9 RID: 6073
		// (get) Token: 0x06007A6A RID: 31338 RVA: 0x001296DB File Offset: 0x001278DB
		// (set) Token: 0x06007A6B RID: 31339 RVA: 0x001296E3 File Offset: 0x001278E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170017BA RID: 6074
		// (get) Token: 0x06007A6C RID: 31340 RVA: 0x001296EC File Offset: 0x001278EC
		// (set) Token: 0x06007A6D RID: 31341 RVA: 0x001296F4 File Offset: 0x001278F4
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

		// Token: 0x06007A6E RID: 31342 RVA: 0x001296FD File Offset: 0x001278FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldPointRequest);
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x0012970B File Offset: 0x0012790B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldPointRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A70 RID: 31344 RVA: 0x0012974C File Offset: 0x0012794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A71 RID: 31345 RVA: 0x001297A4 File Offset: 0x001279A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A72 RID: 31346 RVA: 0x001297B1 File Offset: 0x001279B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x001297BC File Offset: 0x001279BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x00129818 File Offset: 0x00127A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A75 RID: 31349 RVA: 0x00129870 File Offset: 0x00127A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldPointRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007A76 RID: 31350 RVA: 0x001298C0 File Offset: 0x00127AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A77 RID: 31351 RVA: 0x001298CC File Offset: 0x00127ACC
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003F3A RID: 16186
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F3B RID: 16187
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x04003F3C RID: 16188
		private int activityId_;

		// Token: 0x04003F3D RID: 16189
		public const int IdFieldNumber = 10;

		// Token: 0x04003F3E RID: 16190
		private int id_;
	}
}
