using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F00 RID: 3840
	[NetMessage(EMessageId.RemoveTreasureBoxSlotRequest)]
	public sealed class RemoveTreasureBoxSlotRequest : IMessage<RemoveTreasureBoxSlotRequest>, IMessage, IEquatable<RemoveTreasureBoxSlotRequest>, IDeepCloneable<RemoveTreasureBoxSlotRequest>, IBufferMessage
	{
		// Token: 0x06014971 RID: 84337 RVA: 0x002FDE1D File Offset: 0x002FC01D
		[NullableContext(1)]
		public static RemoveTreasureBoxSlotRequest Create()
		{
			return new RemoveTreasureBoxSlotRequest();
		}

		// Token: 0x17004478 RID: 17528
		// (get) Token: 0x06014972 RID: 84338 RVA: 0x002FDE24 File Offset: 0x002FC024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004479 RID: 17529
		// (get) Token: 0x06014973 RID: 84339 RVA: 0x002FDE27 File Offset: 0x002FC027
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveTreasureBoxSlotRequest.Descriptor;
			}
		}

		// Token: 0x06014974 RID: 84340 RVA: 0x002FDE2E File Offset: 0x002FC02E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotRequest()
		{
		}

		// Token: 0x06014975 RID: 84341 RVA: 0x002FDE36 File Offset: 0x002FC036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotRequest(RemoveTreasureBoxSlotRequest other) : this()
		{
			this.detectionSlotId_ = other.detectionSlotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014976 RID: 84342 RVA: 0x002FDE5B File Offset: 0x002FC05B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveTreasureBoxSlotRequest Clone()
		{
			return new RemoveTreasureBoxSlotRequest(this);
		}

		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x06014977 RID: 84343 RVA: 0x002FDE63 File Offset: 0x002FC063
		// (set) Token: 0x06014978 RID: 84344 RVA: 0x002FDE6B File Offset: 0x002FC06B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DetectionSlotId
		{
			get
			{
				return this.detectionSlotId_;
			}
			set
			{
				this.detectionSlotId_ = value;
			}
		}

		// Token: 0x06014979 RID: 84345 RVA: 0x002FDE74 File Offset: 0x002FC074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveTreasureBoxSlotRequest);
		}

		// Token: 0x0601497A RID: 84346 RVA: 0x002FDE82 File Offset: 0x002FC082
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveTreasureBoxSlotRequest other)
		{
			return other != null && (other == this || (this.DetectionSlotId == other.DetectionSlotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601497B RID: 84347 RVA: 0x002FDEB0 File Offset: 0x002FC0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionSlotId != 0L)
			{
				num ^= this.DetectionSlotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601497C RID: 84348 RVA: 0x002FDEEF File Offset: 0x002FC0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601497D RID: 84349 RVA: 0x002FDEFC File Offset: 0x002FC0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601497E RID: 84350 RVA: 0x002FDF05 File Offset: 0x002FC105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionSlotId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.DetectionSlotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601497F RID: 84351 RVA: 0x002FDF38 File Offset: 0x002FC138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionSlotId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DetectionSlotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014980 RID: 84352 RVA: 0x002FDF76 File Offset: 0x002FC176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveTreasureBoxSlotRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionSlotId != 0L)
			{
				this.DetectionSlotId = other.DetectionSlotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014981 RID: 84353 RVA: 0x002FDFA7 File Offset: 0x002FC1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014982 RID: 84354 RVA: 0x002FDFB0 File Offset: 0x002FC1B0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DetectionSlotId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04007D10 RID: 32016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D11 RID: 32017
		public const int DetectionSlotIdFieldNumber = 4;

		// Token: 0x04007D12 RID: 32018
		private long detectionSlotId_;
	}
}
