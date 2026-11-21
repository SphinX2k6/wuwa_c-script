using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001160 RID: 4448
	[NetMessage(EMessageId.RoverRogueShopRefreshRequest)]
	public sealed class RoverRogueShopRefreshRequest : IMessage<RoverRogueShopRefreshRequest>, IMessage, IEquatable<RoverRogueShopRefreshRequest>, IDeepCloneable<RoverRogueShopRefreshRequest>, IBufferMessage
	{
		// Token: 0x06017C59 RID: 97369 RVA: 0x00376228 File Offset: 0x00374428
		[NullableContext(1)]
		public static RoverRogueShopRefreshRequest Create()
		{
			return new RoverRogueShopRefreshRequest();
		}

		// Token: 0x17005008 RID: 20488
		// (get) Token: 0x06017C5A RID: 97370 RVA: 0x0037622F File Offset: 0x0037442F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005009 RID: 20489
		// (get) Token: 0x06017C5B RID: 97371 RVA: 0x00376232 File Offset: 0x00374432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopRefreshRequest.Descriptor;
			}
		}

		// Token: 0x06017C5C RID: 97372 RVA: 0x00376239 File Offset: 0x00374439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshRequest()
		{
		}

		// Token: 0x06017C5D RID: 97373 RVA: 0x00376241 File Offset: 0x00374441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshRequest(RoverRogueShopRefreshRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017C5E RID: 97374 RVA: 0x00376266 File Offset: 0x00374466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopRefreshRequest Clone()
		{
			return new RoverRogueShopRefreshRequest(this);
		}

		// Token: 0x1700500A RID: 20490
		// (get) Token: 0x06017C5F RID: 97375 RVA: 0x0037626E File Offset: 0x0037446E
		// (set) Token: 0x06017C60 RID: 97376 RVA: 0x00376276 File Offset: 0x00374476
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

		// Token: 0x06017C61 RID: 97377 RVA: 0x0037627F File Offset: 0x0037447F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopRefreshRequest);
		}

		// Token: 0x06017C62 RID: 97378 RVA: 0x0037628D File Offset: 0x0037448D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopRefreshRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017C63 RID: 97379 RVA: 0x003762BC File Offset: 0x003744BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017C64 RID: 97380 RVA: 0x003762FB File Offset: 0x003744FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017C65 RID: 97381 RVA: 0x00376308 File Offset: 0x00374508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017C66 RID: 97382 RVA: 0x00376311 File Offset: 0x00374511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017C67 RID: 97383 RVA: 0x00376344 File Offset: 0x00374544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017C68 RID: 97384 RVA: 0x00376382 File Offset: 0x00374582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopRefreshRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017C69 RID: 97385 RVA: 0x003763B3 File Offset: 0x003745B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017C6A RID: 97386 RVA: 0x003763BC File Offset: 0x003745BC
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
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008DE0 RID: 36320
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DE1 RID: 36321
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04008DE2 RID: 36322
		private int activityId_;
	}
}
