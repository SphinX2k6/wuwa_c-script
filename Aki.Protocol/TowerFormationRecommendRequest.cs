using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200142D RID: 5165
	[NetMessage(EMessageId.TowerFormationRecommendRequest)]
	public sealed class TowerFormationRecommendRequest : IMessage<TowerFormationRecommendRequest>, IMessage, IEquatable<TowerFormationRecommendRequest>, IDeepCloneable<TowerFormationRecommendRequest>, IBufferMessage
	{
		// Token: 0x0601B733 RID: 112435 RVA: 0x003FDBB1 File Offset: 0x003FBDB1
		[NullableContext(1)]
		public static TowerFormationRecommendRequest Create()
		{
			return new TowerFormationRecommendRequest();
		}

		// Token: 0x17005CF1 RID: 23793
		// (get) Token: 0x0601B734 RID: 112436 RVA: 0x003FDBB8 File Offset: 0x003FBDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CF2 RID: 23794
		// (get) Token: 0x0601B735 RID: 112437 RVA: 0x003FDBBB File Offset: 0x003FBDBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerFormationRecommendRequest.Descriptor;
			}
		}

		// Token: 0x0601B736 RID: 112438 RVA: 0x003FDBC2 File Offset: 0x003FBDC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendRequest()
		{
		}

		// Token: 0x0601B737 RID: 112439 RVA: 0x003FDBCA File Offset: 0x003FBDCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendRequest(TowerFormationRecommendRequest other) : this()
		{
			this.towerConfigId_ = other.towerConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B738 RID: 112440 RVA: 0x003FDBEF File Offset: 0x003FBDEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerFormationRecommendRequest Clone()
		{
			return new TowerFormationRecommendRequest(this);
		}

		// Token: 0x17005CF3 RID: 23795
		// (get) Token: 0x0601B739 RID: 112441 RVA: 0x003FDBF7 File Offset: 0x003FBDF7
		// (set) Token: 0x0601B73A RID: 112442 RVA: 0x003FDBFF File Offset: 0x003FBDFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x0601B73B RID: 112443 RVA: 0x003FDC08 File Offset: 0x003FBE08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerFormationRecommendRequest);
		}

		// Token: 0x0601B73C RID: 112444 RVA: 0x003FDC16 File Offset: 0x003FBE16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerFormationRecommendRequest other)
		{
			return other != null && (other == this || (this.TowerConfigId == other.TowerConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B73D RID: 112445 RVA: 0x003FDC44 File Offset: 0x003FBE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B73E RID: 112446 RVA: 0x003FDC83 File Offset: 0x003FBE83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B73F RID: 112447 RVA: 0x003FDC90 File Offset: 0x003FBE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B740 RID: 112448 RVA: 0x003FDC99 File Offset: 0x003FBE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B741 RID: 112449 RVA: 0x003FDCCC File Offset: 0x003FBECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B742 RID: 112450 RVA: 0x003FDD0A File Offset: 0x003FBF0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerFormationRecommendRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B743 RID: 112451 RVA: 0x003FDD3B File Offset: 0x003FBF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B744 RID: 112452 RVA: 0x003FDD44 File Offset: 0x003FBF44
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TowerConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FD2 RID: 40914
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FD3 RID: 40915
		public const int TowerConfigIdFieldNumber = 5;

		// Token: 0x04009FD4 RID: 40916
		private int towerConfigId_;
	}
}
