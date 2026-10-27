using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BE RID: 5054
	[NetMessage(EMessageId.TowerGuideActivityRewardRequest)]
	public sealed class TowerGuideActivityRewardRequest : IMessage<TowerGuideActivityRewardRequest>, IMessage, IEquatable<TowerGuideActivityRewardRequest>, IDeepCloneable<TowerGuideActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x0601ACF4 RID: 109812 RVA: 0x003E31DD File Offset: 0x003E13DD
		[NullableContext(1)]
		public static TowerGuideActivityRewardRequest Create()
		{
			return new TowerGuideActivityRewardRequest();
		}

		// Token: 0x17005A6A RID: 23146
		// (get) Token: 0x0601ACF5 RID: 109813 RVA: 0x003E31E4 File Offset: 0x003E13E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A6B RID: 23147
		// (get) Token: 0x0601ACF6 RID: 109814 RVA: 0x003E31E7 File Offset: 0x003E13E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerGuideActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601ACF7 RID: 109815 RVA: 0x003E31EE File Offset: 0x003E13EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardRequest()
		{
		}

		// Token: 0x0601ACF8 RID: 109816 RVA: 0x003E31F6 File Offset: 0x003E13F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardRequest(TowerGuideActivityRewardRequest other) : this()
		{
			this.towerGuideId_ = other.towerGuideId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ACF9 RID: 109817 RVA: 0x003E321B File Offset: 0x003E141B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerGuideActivityRewardRequest Clone()
		{
			return new TowerGuideActivityRewardRequest(this);
		}

		// Token: 0x17005A6C RID: 23148
		// (get) Token: 0x0601ACFA RID: 109818 RVA: 0x003E3223 File Offset: 0x003E1423
		// (set) Token: 0x0601ACFB RID: 109819 RVA: 0x003E322B File Offset: 0x003E142B
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

		// Token: 0x0601ACFC RID: 109820 RVA: 0x003E3234 File Offset: 0x003E1434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerGuideActivityRewardRequest);
		}

		// Token: 0x0601ACFD RID: 109821 RVA: 0x003E3242 File Offset: 0x003E1442
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerGuideActivityRewardRequest other)
		{
			return other != null && (other == this || (this.TowerGuideId == other.TowerGuideId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ACFE RID: 109822 RVA: 0x003E3270 File Offset: 0x003E1470
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

		// Token: 0x0601ACFF RID: 109823 RVA: 0x003E32AF File Offset: 0x003E14AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD00 RID: 109824 RVA: 0x003E32BC File Offset: 0x003E14BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD01 RID: 109825 RVA: 0x003E32C5 File Offset: 0x003E14C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TowerGuideId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TowerGuideId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AD02 RID: 109826 RVA: 0x003E32F8 File Offset: 0x003E14F8
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

		// Token: 0x0601AD03 RID: 109827 RVA: 0x003E3336 File Offset: 0x003E1536
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

		// Token: 0x0601AD04 RID: 109828 RVA: 0x003E3367 File Offset: 0x003E1567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD05 RID: 109829 RVA: 0x003E3370 File Offset: 0x003E1570
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TowerGuideId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009B9D RID: 39837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B9E RID: 39838
		public const int TowerGuideIdFieldNumber = 10;

		// Token: 0x04009B9F RID: 39839
		private int towerGuideId_;
	}
}
