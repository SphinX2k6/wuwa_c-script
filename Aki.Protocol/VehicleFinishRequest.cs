using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014CD RID: 5325
	[NetMessage(EMessageId.VehicleFinishRequest)]
	public sealed class VehicleFinishRequest : IMessage<VehicleFinishRequest>, IMessage, IEquatable<VehicleFinishRequest>, IDeepCloneable<VehicleFinishRequest>, IBufferMessage
	{
		// Token: 0x0601C293 RID: 115347 RVA: 0x004120C9 File Offset: 0x004102C9
		[NullableContext(1)]
		public static VehicleFinishRequest Create()
		{
			return new VehicleFinishRequest();
		}

		// Token: 0x17005EF0 RID: 24304
		// (get) Token: 0x0601C294 RID: 115348 RVA: 0x004120D0 File Offset: 0x004102D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EF1 RID: 24305
		// (get) Token: 0x0601C295 RID: 115349 RVA: 0x004120D3 File Offset: 0x004102D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601C296 RID: 115350 RVA: 0x004120DA File Offset: 0x004102DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishRequest()
		{
		}

		// Token: 0x0601C297 RID: 115351 RVA: 0x004120E2 File Offset: 0x004102E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishRequest(VehicleFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C298 RID: 115352 RVA: 0x00412107 File Offset: 0x00410307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishRequest Clone()
		{
			return new VehicleFinishRequest(this);
		}

		// Token: 0x17005EF2 RID: 24306
		// (get) Token: 0x0601C299 RID: 115353 RVA: 0x0041210F File Offset: 0x0041030F
		// (set) Token: 0x0601C29A RID: 115354 RVA: 0x00412117 File Offset: 0x00410317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0601C29B RID: 115355 RVA: 0x00412120 File Offset: 0x00410320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleFinishRequest);
		}

		// Token: 0x0601C29C RID: 115356 RVA: 0x0041212E File Offset: 0x0041032E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C29D RID: 115357 RVA: 0x0041215C File Offset: 0x0041035C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C29E RID: 115358 RVA: 0x0041219B File Offset: 0x0041039B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C29F RID: 115359 RVA: 0x004121A8 File Offset: 0x004103A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C2A0 RID: 115360 RVA: 0x004121B1 File Offset: 0x004103B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C2A1 RID: 115361 RVA: 0x004121E4 File Offset: 0x004103E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C2A2 RID: 115362 RVA: 0x00412222 File Offset: 0x00410422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C2A3 RID: 115363 RVA: 0x00412253 File Offset: 0x00410453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C2A4 RID: 115364 RVA: 0x0041225C File Offset: 0x0041045C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A18E RID: 41358
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A18F RID: 41359
		public const int EntityIdFieldNumber = 7;

		// Token: 0x0400A190 RID: 41360
		private long entityId_;
	}
}
