using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200058D RID: 1421
	[NetMessage(EMessageId.FishingTechLevelUpRequest)]
	public sealed class FishingTechLevelUpRequest : IMessage<FishingTechLevelUpRequest>, IMessage, IEquatable<FishingTechLevelUpRequest>, IDeepCloneable<FishingTechLevelUpRequest>, IBufferMessage
	{
		// Token: 0x060083C2 RID: 33730 RVA: 0x0013D3D4 File Offset: 0x0013B5D4
		[NullableContext(1)]
		public static FishingTechLevelUpRequest Create()
		{
			return new FishingTechLevelUpRequest();
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x060083C3 RID: 33731 RVA: 0x0013D3DB File Offset: 0x0013B5DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x060083C4 RID: 33732 RVA: 0x0013D3DE File Offset: 0x0013B5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x0013D3E5 File Offset: 0x0013B5E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpRequest()
		{
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x0013D3ED File Offset: 0x0013B5ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpRequest(FishingTechLevelUpRequest other) : this()
		{
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x0013D412 File Offset: 0x0013B612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpRequest Clone()
		{
			return new FishingTechLevelUpRequest(this);
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x060083C8 RID: 33736 RVA: 0x0013D41A File Offset: 0x0013B61A
		// (set) Token: 0x060083C9 RID: 33737 RVA: 0x0013D422 File Offset: 0x0013B622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NodeId
		{
			get
			{
				return this.nodeId_;
			}
			set
			{
				this.nodeId_ = value;
			}
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x0013D42B File Offset: 0x0013B62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechLevelUpRequest);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x0013D439 File Offset: 0x0013B639
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechLevelUpRequest other)
		{
			return other != null && (other == this || (this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0013D468 File Offset: 0x0013B668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NodeId != 0)
			{
				num ^= this.NodeId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x0013D4A7 File Offset: 0x0013B6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x0013D4B4 File Offset: 0x0013B6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x0013D4BD File Offset: 0x0013B6BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x0013D4F0 File Offset: 0x0013B6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x0013D52E File Offset: 0x0013B72E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTechLevelUpRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NodeId != 0)
			{
				this.NodeId = other.NodeId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x0013D55F File Offset: 0x0013B75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x0013D568 File Offset: 0x0013B768
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400418B RID: 16779
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400418C RID: 16780
		public const int NodeIdFieldNumber = 15;

		// Token: 0x0400418D RID: 16781
		private int nodeId_;
	}
}
