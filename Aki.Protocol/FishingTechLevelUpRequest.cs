using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000578 RID: 1400
	[NetMessage(EMessageId.FishingTechLevelUpRequest)]
	public sealed class FishingTechLevelUpRequest : IMessage<FishingTechLevelUpRequest>, IMessage, IEquatable<FishingTechLevelUpRequest>, IDeepCloneable<FishingTechLevelUpRequest>, IBufferMessage
	{
		// Token: 0x0600825A RID: 33370 RVA: 0x0013A7C8 File Offset: 0x001389C8
		[NullableContext(1)]
		public static FishingTechLevelUpRequest Create()
		{
			return new FishingTechLevelUpRequest();
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600825B RID: 33371 RVA: 0x0013A7CF File Offset: 0x001389CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600825C RID: 33372 RVA: 0x0013A7D2 File Offset: 0x001389D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTechLevelUpRequest.Descriptor;
			}
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x0013A7D9 File Offset: 0x001389D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpRequest()
		{
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x0013A7E1 File Offset: 0x001389E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpRequest(FishingTechLevelUpRequest other) : this()
		{
			this.nodeId_ = other.nodeId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x0013A806 File Offset: 0x00138A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTechLevelUpRequest Clone()
		{
			return new FishingTechLevelUpRequest(this);
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06008260 RID: 33376 RVA: 0x0013A80E File Offset: 0x00138A0E
		// (set) Token: 0x06008261 RID: 33377 RVA: 0x0013A816 File Offset: 0x00138A16
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

		// Token: 0x06008262 RID: 33378 RVA: 0x0013A81F File Offset: 0x00138A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTechLevelUpRequest);
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x0013A82D File Offset: 0x00138A2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTechLevelUpRequest other)
		{
			return other != null && (other == this || (this.NodeId == other.NodeId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x0013A85C File Offset: 0x00138A5C
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

		// Token: 0x06008265 RID: 33381 RVA: 0x0013A89B File Offset: 0x00138A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x0013A8A8 File Offset: 0x00138AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x0013A8B1 File Offset: 0x00138AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NodeId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.NodeId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x0013A8E4 File Offset: 0x00138AE4
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

		// Token: 0x06008269 RID: 33385 RVA: 0x0013A922 File Offset: 0x00138B22
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

		// Token: 0x0600826A RID: 33386 RVA: 0x0013A953 File Offset: 0x00138B53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x0013A95C File Offset: 0x00138B5C
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004181 RID: 16769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004182 RID: 16770
		public const int NodeIdFieldNumber = 11;

		// Token: 0x04004183 RID: 16771
		private int nodeId_;
	}
}
