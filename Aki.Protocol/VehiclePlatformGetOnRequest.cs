using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D3 RID: 5331
	[NetMessage(EMessageId.VehiclePlatformGetOnRequest)]
	public sealed class VehiclePlatformGetOnRequest : IMessage<VehiclePlatformGetOnRequest>, IMessage, IEquatable<VehiclePlatformGetOnRequest>, IDeepCloneable<VehiclePlatformGetOnRequest>, IBufferMessage
	{
		// Token: 0x0601C309 RID: 115465 RVA: 0x00412F80 File Offset: 0x00411180
		[NullableContext(1)]
		public static VehiclePlatformGetOnRequest Create()
		{
			return new VehiclePlatformGetOnRequest();
		}

		// Token: 0x17005F07 RID: 24327
		// (get) Token: 0x0601C30A RID: 115466 RVA: 0x00412F87 File Offset: 0x00411187
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F08 RID: 24328
		// (get) Token: 0x0601C30B RID: 115467 RVA: 0x00412F8A File Offset: 0x0041118A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehiclePlatformGetOnRequest.Descriptor;
			}
		}

		// Token: 0x0601C30C RID: 115468 RVA: 0x00412F91 File Offset: 0x00411191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnRequest()
		{
		}

		// Token: 0x0601C30D RID: 115469 RVA: 0x00412F99 File Offset: 0x00411199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnRequest(VehiclePlatformGetOnRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isGetOn_ = other.isGetOn_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C30E RID: 115470 RVA: 0x00412FCA File Offset: 0x004111CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehiclePlatformGetOnRequest Clone()
		{
			return new VehiclePlatformGetOnRequest(this);
		}

		// Token: 0x17005F09 RID: 24329
		// (get) Token: 0x0601C30F RID: 115471 RVA: 0x00412FD2 File Offset: 0x004111D2
		// (set) Token: 0x0601C310 RID: 115472 RVA: 0x00412FDA File Offset: 0x004111DA
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

		// Token: 0x17005F0A RID: 24330
		// (get) Token: 0x0601C311 RID: 115473 RVA: 0x00412FE3 File Offset: 0x004111E3
		// (set) Token: 0x0601C312 RID: 115474 RVA: 0x00412FEB File Offset: 0x004111EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsGetOn
		{
			get
			{
				return this.isGetOn_;
			}
			set
			{
				this.isGetOn_ = value;
			}
		}

		// Token: 0x0601C313 RID: 115475 RVA: 0x00412FF4 File Offset: 0x004111F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehiclePlatformGetOnRequest);
		}

		// Token: 0x0601C314 RID: 115476 RVA: 0x00413002 File Offset: 0x00411202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehiclePlatformGetOnRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsGetOn == other.IsGetOn && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C315 RID: 115477 RVA: 0x00413040 File Offset: 0x00411240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsGetOn)
			{
				num ^= this.IsGetOn.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C316 RID: 115478 RVA: 0x00413098 File Offset: 0x00411298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C317 RID: 115479 RVA: 0x004130A5 File Offset: 0x004112A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C318 RID: 115480 RVA: 0x004130B0 File Offset: 0x004112B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsGetOn)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsGetOn);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C319 RID: 115481 RVA: 0x0041310C File Offset: 0x0041130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsGetOn)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C31A RID: 115482 RVA: 0x00413158 File Offset: 0x00411358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehiclePlatformGetOnRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsGetOn)
			{
				this.IsGetOn = other.IsGetOn;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C31B RID: 115483 RVA: 0x004131A8 File Offset: 0x004113A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C31C RID: 115484 RVA: 0x004131B4 File Offset: 0x004113B4
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
				if (num != 72U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsGetOn = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A1AA RID: 41386
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A1AB RID: 41387
		public const int EntityIdFieldNumber = 9;

		// Token: 0x0400A1AC RID: 41388
		private long entityId_;

		// Token: 0x0400A1AD RID: 41389
		public const int IsGetOnFieldNumber = 12;

		// Token: 0x0400A1AE RID: 41390
		private bool isGetOn_;
	}
}
