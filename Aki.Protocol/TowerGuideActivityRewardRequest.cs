using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001431 RID: 5169
	[NetMessage(EMessageId.TowerGuideActivityRewardRequest)]
	public sealed class TowerGuideActivityRewardRequest : IMessage<TowerGuideActivityRewardRequest>, IMessage, IEquatable<TowerGuideActivityRewardRequest>, IDeepCloneable<TowerGuideActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B77F RID: 112511 RVA: 0x003FE4A1 File Offset: 0x003FC6A1
		[NullableContext(1)]
		public static TowerGuideActivityRewardRequest Create()
		{
			return new TowerGuideActivityRewardRequest();
		}

		// Token: 0x17005CFF RID: 23807
		// (get) Token: 0x0601B780 RID: 112512 RVA: 0x003FE4A8 File Offset: 0x003FC6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D00 RID: 23808
		// (get) Token: 0x0601B781 RID: 112513 RVA: 0x003FE4AB File Offset: 0x003FC6AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B782 RID: 112514 RVA: 0x003FE4B2 File Offset: 0x003FC6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardRequest()
		{
		}

		// Token: 0x0601B783 RID: 112515 RVA: 0x003FE4BA File Offset: 0x003FC6BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardRequest(TowerGuideActivityRewardRequest other) : this()
		{
			this.towerGuideId_ = other.towerGuideId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B784 RID: 112516 RVA: 0x003FE4DF File Offset: 0x003FC6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardRequest Clone()
		{
			return new TowerGuideActivityRewardRequest(this);
		}

		// Token: 0x17005D01 RID: 23809
		// (get) Token: 0x0601B785 RID: 112517 RVA: 0x003FE4E7 File Offset: 0x003FC6E7
		// (set) Token: 0x0601B786 RID: 112518 RVA: 0x003FE4EF File Offset: 0x003FC6EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerGuideId
		{
			get
			{
				return this.towerGuideId_;
			}
			set
			{
				this.towerGuideId_ = value;
			}
		}

		// Token: 0x0601B787 RID: 112519 RVA: 0x003FE4F8 File Offset: 0x003FC6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityRewardRequest);
		}

		// Token: 0x0601B788 RID: 112520 RVA: 0x003FE506 File Offset: 0x003FC706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityRewardRequest other)
		{
			return other != null && (other == this || (this.TowerGuideId == other.TowerGuideId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B789 RID: 112521 RVA: 0x003FE534 File Offset: 0x003FC734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TowerGuideId != 0)
			{
				num ^= this.TowerGuideId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B78A RID: 112522 RVA: 0x003FE573 File Offset: 0x003FC773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B78B RID: 112523 RVA: 0x003FE580 File Offset: 0x003FC780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B78C RID: 112524 RVA: 0x003FE589 File Offset: 0x003FC789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerGuideId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TowerGuideId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B78D RID: 112525 RVA: 0x003FE5BC File Offset: 0x003FC7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TowerGuideId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerGuideId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B78E RID: 112526 RVA: 0x003FE5FA File Offset: 0x003FC7FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerGuideActivityRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TowerGuideId != 0)
			{
				this.TowerGuideId = other.TowerGuideId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B78F RID: 112527 RVA: 0x003FE62B File Offset: 0x003FC82B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B790 RID: 112528 RVA: 0x003FE634 File Offset: 0x003FC834
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
					this.TowerGuideId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FE4 RID: 40932
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FE5 RID: 40933
		public const int TowerGuideIdFieldNumber = 4;

		// Token: 0x04009FE6 RID: 40934
		private int towerGuideId_;
	}
}
