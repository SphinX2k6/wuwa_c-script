using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200115B RID: 4443
	[NetMessage(EMessageId.RoverRogueShopBuyRequest)]
	public sealed class RoverRogueShopBuyRequest : IMessage<RoverRogueShopBuyRequest>, IMessage, IEquatable<RoverRogueShopBuyRequest>, IDeepCloneable<RoverRogueShopBuyRequest>, IBufferMessage
	{
		// Token: 0x06017BE9 RID: 97257 RVA: 0x0037519B File Offset: 0x0037339B
		[NullableContext(1)]
		public static RoverRogueShopBuyRequest Create()
		{
			return new RoverRogueShopBuyRequest();
		}

		// Token: 0x17004FEE RID: 20462
		// (get) Token: 0x06017BEA RID: 97258 RVA: 0x003751A2 File Offset: 0x003733A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FEF RID: 20463
		// (get) Token: 0x06017BEB RID: 97259 RVA: 0x003751A5 File Offset: 0x003733A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopBuyRequest.Descriptor;
			}
		}

		// Token: 0x06017BEC RID: 97260 RVA: 0x003751AC File Offset: 0x003733AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyRequest()
		{
		}

		// Token: 0x06017BED RID: 97261 RVA: 0x003751B4 File Offset: 0x003733B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyRequest(RoverRogueShopBuyRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.goodIncId_ = other.goodIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017BEE RID: 97262 RVA: 0x003751E5 File Offset: 0x003733E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopBuyRequest Clone()
		{
			return new RoverRogueShopBuyRequest(this);
		}

		// Token: 0x17004FF0 RID: 20464
		// (get) Token: 0x06017BEF RID: 97263 RVA: 0x003751ED File Offset: 0x003733ED
		// (set) Token: 0x06017BF0 RID: 97264 RVA: 0x003751F5 File Offset: 0x003733F5
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

		// Token: 0x17004FF1 RID: 20465
		// (get) Token: 0x06017BF1 RID: 97265 RVA: 0x003751FE File Offset: 0x003733FE
		// (set) Token: 0x06017BF2 RID: 97266 RVA: 0x00375206 File Offset: 0x00373406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoodIncId
		{
			get
			{
				return this.goodIncId_;
			}
			set
			{
				this.goodIncId_ = value;
			}
		}

		// Token: 0x06017BF3 RID: 97267 RVA: 0x0037520F File Offset: 0x0037340F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopBuyRequest);
		}

		// Token: 0x06017BF4 RID: 97268 RVA: 0x0037521D File Offset: 0x0037341D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopBuyRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.GoodIncId == other.GoodIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017BF5 RID: 97269 RVA: 0x0037525C File Offset: 0x0037345C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.GoodIncId != 0)
			{
				num ^= this.GoodIncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017BF6 RID: 97270 RVA: 0x003752B4 File Offset: 0x003734B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017BF7 RID: 97271 RVA: 0x003752C1 File Offset: 0x003734C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017BF8 RID: 97272 RVA: 0x003752CC File Offset: 0x003734CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GoodIncId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GoodIncId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017BF9 RID: 97273 RVA: 0x00375328 File Offset: 0x00373528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.GoodIncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoodIncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017BFA RID: 97274 RVA: 0x00375380 File Offset: 0x00373580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopBuyRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.GoodIncId != 0)
			{
				this.GoodIncId = other.GoodIncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017BFB RID: 97275 RVA: 0x003753D0 File Offset: 0x003735D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017BFC RID: 97276 RVA: 0x003753DC File Offset: 0x003735DC
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
				if (num != 16U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.GoodIncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008DBC RID: 36284
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008DBD RID: 36285
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04008DBE RID: 36286
		private int activityId_;

		// Token: 0x04008DBF RID: 36287
		public const int GoodIncIdFieldNumber = 2;

		// Token: 0x04008DC0 RID: 36288
		private int goodIncId_;
	}
}
