using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126F RID: 4719
	[NetMessage(EMessageId.SitChairRequest)]
	public sealed class SitChairRequest : IMessage<SitChairRequest>, IMessage, IEquatable<SitChairRequest>, IDeepCloneable<SitChairRequest>, IBufferMessage
	{
		// Token: 0x0601931A RID: 103194 RVA: 0x003ACB47 File Offset: 0x003AAD47
		[NullableContext(1)]
		public static SitChairRequest Create()
		{
			return new SitChairRequest();
		}

		// Token: 0x1700552F RID: 21807
		// (get) Token: 0x0601931B RID: 103195 RVA: 0x003ACB4E File Offset: 0x003AAD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005530 RID: 21808
		// (get) Token: 0x0601931C RID: 103196 RVA: 0x003ACB51 File Offset: 0x003AAD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SitChairRequest.Descriptor;
			}
		}

		// Token: 0x0601931D RID: 103197 RVA: 0x003ACB58 File Offset: 0x003AAD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairRequest()
		{
		}

		// Token: 0x0601931E RID: 103198 RVA: 0x003ACB60 File Offset: 0x003AAD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairRequest(SitChairRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isSitDown_ = other.isSitDown_;
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this.request_ = ((other.request_ != null) ? other.request_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601931F RID: 103199 RVA: 0x003ACBD4 File Offset: 0x003AADD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairRequest Clone()
		{
			return new SitChairRequest(this);
		}

		// Token: 0x17005531 RID: 21809
		// (get) Token: 0x06019320 RID: 103200 RVA: 0x003ACBDC File Offset: 0x003AADDC
		// (set) Token: 0x06019321 RID: 103201 RVA: 0x003ACBE4 File Offset: 0x003AADE4
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

		// Token: 0x17005532 RID: 21810
		// (get) Token: 0x06019322 RID: 103202 RVA: 0x003ACBED File Offset: 0x003AADED
		// (set) Token: 0x06019323 RID: 103203 RVA: 0x003ACBF5 File Offset: 0x003AADF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSitDown
		{
			get
			{
				return this.isSitDown_;
			}
			set
			{
				this.isSitDown_ = value;
			}
		}

		// Token: 0x17005533 RID: 21811
		// (get) Token: 0x06019324 RID: 103204 RVA: 0x003ACBFE File Offset: 0x003AADFE
		// (set) Token: 0x06019325 RID: 103205 RVA: 0x003ACC06 File Offset: 0x003AAE06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CombatCommon Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x17005534 RID: 21812
		// (get) Token: 0x06019326 RID: 103206 RVA: 0x003ACC0F File Offset: 0x003AAE0F
		// (set) Token: 0x06019327 RID: 103207 RVA: 0x003ACC17 File Offset: 0x003AAE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AnimationStateChangedRequest Request
		{
			get
			{
				return this.request_;
			}
			set
			{
				this.request_ = value;
			}
		}

		// Token: 0x06019328 RID: 103208 RVA: 0x003ACC20 File Offset: 0x003AAE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SitChairRequest);
		}

		// Token: 0x06019329 RID: 103209 RVA: 0x003ACC30 File Offset: 0x003AAE30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SitChairRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsSitDown == other.IsSitDown && object.Equals(this.Data, other.Data) && object.Equals(this.Request, other.Request) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601932A RID: 103210 RVA: 0x003ACCA4 File Offset: 0x003AAEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsSitDown)
			{
				num ^= this.IsSitDown.GetHashCode();
			}
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this.request_ != null)
			{
				num ^= this.Request.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601932B RID: 103211 RVA: 0x003ACD28 File Offset: 0x003AAF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601932C RID: 103212 RVA: 0x003ACD35 File Offset: 0x003AAF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601932D RID: 103213 RVA: 0x003ACD40 File Offset: 0x003AAF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsSitDown)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsSitDown);
			}
			if (this.request_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Request);
			}
			if (this.data_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601932E RID: 103214 RVA: 0x003ACDD4 File Offset: 0x003AAFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsSitDown)
			{
				num += 2;
			}
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this.request_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Request);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601932F RID: 103215 RVA: 0x003ACE50 File Offset: 0x003AB050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SitChairRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsSitDown)
			{
				this.IsSitDown = other.IsSitDown;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new CombatCommon();
				}
				this.Data.MergeFrom(other.Data);
			}
			if (other.request_ != null)
			{
				if (this.request_ == null)
				{
					this.Request = new AnimationStateChangedRequest();
				}
				this.Request.MergeFrom(other.Request);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019330 RID: 103216 RVA: 0x003ACEF8 File Offset: 0x003AB0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019331 RID: 103217 RVA: 0x003ACF04 File Offset: 0x003AB104
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.IsSitDown = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						if (this.request_ == null)
						{
							this.Request = new AnimationStateChangedRequest();
						}
						input.ReadMessage(this.Request);
						continue;
					}
					if (num == 82U)
					{
						if (this.data_ == null)
						{
							this.Data = new CombatCommon();
						}
						input.ReadMessage(this.Data);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009525 RID: 38181
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009526 RID: 38182
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04009527 RID: 38183
		private long entityId_;

		// Token: 0x04009528 RID: 38184
		public const int IsSitDownFieldNumber = 3;

		// Token: 0x04009529 RID: 38185
		private bool isSitDown_;

		// Token: 0x0400952A RID: 38186
		public const int DataFieldNumber = 10;

		// Token: 0x0400952B RID: 38187
		private CombatCommon data_;

		// Token: 0x0400952C RID: 38188
		public const int RequestFieldNumber = 8;

		// Token: 0x0400952D RID: 38189
		private AnimationStateChangedRequest request_;
	}
}
