using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B8 RID: 1720
	[NetMessage(EMessageId.GatherActivityRewardRequest)]
	public sealed class GatherActivityRewardRequest : IMessage<GatherActivityRewardRequest>, IMessage, IEquatable<GatherActivityRewardRequest>, IDeepCloneable<GatherActivityRewardRequest>, IBufferMessage
	{
		// Token: 0x06009D96 RID: 40342 RVA: 0x0017EF69 File Offset: 0x0017D169
		[NullableContext(1)]
		public static GatherActivityRewardRequest Create()
		{
			return new GatherActivityRewardRequest();
		}

		// Token: 0x17001FAD RID: 8109
		// (get) Token: 0x06009D97 RID: 40343 RVA: 0x0017EF70 File Offset: 0x0017D170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001FAE RID: 8110
		// (get) Token: 0x06009D98 RID: 40344 RVA: 0x0017EF73 File Offset: 0x0017D173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherActivityRewardRequest.Descriptor;
			}
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x0017EF7A File Offset: 0x0017D17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardRequest()
		{
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x0017EF82 File Offset: 0x0017D182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardRequest(GatherActivityRewardRequest other) : this()
		{
			this.gatherTaskId_ = other.gatherTaskId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D9B RID: 40347 RVA: 0x0017EFA7 File Offset: 0x0017D1A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherActivityRewardRequest Clone()
		{
			return new GatherActivityRewardRequest(this);
		}

		// Token: 0x17001FAF RID: 8111
		// (get) Token: 0x06009D9C RID: 40348 RVA: 0x0017EFAF File Offset: 0x0017D1AF
		// (set) Token: 0x06009D9D RID: 40349 RVA: 0x0017EFB7 File Offset: 0x0017D1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GatherTaskId
		{
			get
			{
				return this.gatherTaskId_;
			}
			set
			{
				this.gatherTaskId_ = value;
			}
		}

		// Token: 0x06009D9E RID: 40350 RVA: 0x0017EFC0 File Offset: 0x0017D1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherActivityRewardRequest);
		}

		// Token: 0x06009D9F RID: 40351 RVA: 0x0017EFCE File Offset: 0x0017D1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherActivityRewardRequest other)
		{
			return other != null && (other == this || (this.GatherTaskId == other.GatherTaskId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009DA0 RID: 40352 RVA: 0x0017EFFC File Offset: 0x0017D1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GatherTaskId != 0)
			{
				num ^= this.GatherTaskId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x0017F03B File Offset: 0x0017D23B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x0017F048 File Offset: 0x0017D248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x0017F051 File Offset: 0x0017D251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GatherTaskId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GatherTaskId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x0017F084 File Offset: 0x0017D284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GatherTaskId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GatherTaskId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x0017F0C2 File Offset: 0x0017D2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherActivityRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GatherTaskId != 0)
			{
				this.GatherTaskId = other.GatherTaskId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x0017F0F3 File Offset: 0x0017D2F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x0017F0FC File Offset: 0x0017D2FC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GatherTaskId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004A00 RID: 18944
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A01 RID: 18945
		public const int GatherTaskIdFieldNumber = 6;

		// Token: 0x04004A02 RID: 18946
		private int gatherTaskId_;
	}
}
