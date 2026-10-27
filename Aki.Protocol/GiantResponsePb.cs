using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006E3 RID: 1763
	public sealed class GiantResponsePb : IMessage<GiantResponsePb>, IMessage, IEquatable<GiantResponsePb>, IDeepCloneable<GiantResponsePb>, IBufferMessage
	{
		// Token: 0x0600A0DC RID: 41180 RVA: 0x001856A7 File Offset: 0x001838A7
		[NullableContext(1)]
		public static GiantResponsePb Create()
		{
			return new GiantResponsePb();
		}

		// Token: 0x17002050 RID: 8272
		// (get) Token: 0x0600A0DD RID: 41181 RVA: 0x001856AE File Offset: 0x001838AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiantResponsePb> Parser
		{
			get
			{
				return GiantResponsePb._parser;
			}
		}

		// Token: 0x17002051 RID: 8273
		// (get) Token: 0x0600A0DE RID: 41182 RVA: 0x001856B5 File Offset: 0x001838B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002052 RID: 8274
		// (get) Token: 0x0600A0DF RID: 41183 RVA: 0x001856B8 File Offset: 0x001838B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponsePb.Descriptor;
			}
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x001856BF File Offset: 0x001838BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePb()
		{
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x001856C8 File Offset: 0x001838C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePb(GiantResponsePb other) : this()
		{
			this.giantResponseType_ = other.giantResponseType_;
			GiantResponsePb.GiantResponseOneofCase giantResponseCase = other.GiantResponseCase;
			if (giantResponseCase != GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation)
			{
				if (giantResponseCase == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow)
				{
					this.GiantResponsePlayFlow = other.GiantResponsePlayFlow.Clone();
				}
			}
			else
			{
				this.GiantResponsePlayAnimation = other.GiantResponsePlayAnimation.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x0018572D File Offset: 0x0018392D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePb Clone()
		{
			return new GiantResponsePb(this);
		}

		// Token: 0x17002053 RID: 8275
		// (get) Token: 0x0600A0E3 RID: 41187 RVA: 0x00185735 File Offset: 0x00183935
		// (set) Token: 0x0600A0E4 RID: 41188 RVA: 0x0018573D File Offset: 0x0018393D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponseType GiantResponseType
		{
			get
			{
				return this.giantResponseType_;
			}
			set
			{
				this.giantResponseType_ = value;
			}
		}

		// Token: 0x17002054 RID: 8276
		// (get) Token: 0x0600A0E5 RID: 41189 RVA: 0x00185746 File Offset: 0x00183946
		// (set) Token: 0x0600A0E6 RID: 41190 RVA: 0x0018575E File Offset: 0x0018395E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayAnimationPb GiantResponsePlayAnimation
		{
			get
			{
				if (this.giantResponseCase_ != GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation)
				{
					return null;
				}
				return (GiantResponsePlayAnimationPb)this.giantResponse_;
			}
			set
			{
				this.giantResponse_ = value;
				this.giantResponseCase_ = ((value == null) ? GiantResponsePb.GiantResponseOneofCase.None : GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation);
			}
		}

		// Token: 0x17002055 RID: 8277
		// (get) Token: 0x0600A0E7 RID: 41191 RVA: 0x00185774 File Offset: 0x00183974
		// (set) Token: 0x0600A0E8 RID: 41192 RVA: 0x0018578C File Offset: 0x0018398C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePlayFlowPb GiantResponsePlayFlow
		{
			get
			{
				if (this.giantResponseCase_ != GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow)
				{
					return null;
				}
				return (GiantResponsePlayFlowPb)this.giantResponse_;
			}
			set
			{
				this.giantResponse_ = value;
				this.giantResponseCase_ = ((value == null) ? GiantResponsePb.GiantResponseOneofCase.None : GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow);
			}
		}

		// Token: 0x17002056 RID: 8278
		// (get) Token: 0x0600A0E9 RID: 41193 RVA: 0x001857A2 File Offset: 0x001839A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePb.GiantResponseOneofCase GiantResponseCase
		{
			get
			{
				return this.giantResponseCase_;
			}
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x001857AA File Offset: 0x001839AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearGiantResponse()
		{
			this.giantResponseCase_ = GiantResponsePb.GiantResponseOneofCase.None;
			this.giantResponse_ = null;
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x001857BA File Offset: 0x001839BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponsePb);
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x001857C8 File Offset: 0x001839C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponsePb other)
		{
			return other != null && (other == this || (this.GiantResponseType == other.GiantResponseType && object.Equals(this.GiantResponsePlayAnimation, other.GiantResponsePlayAnimation) && object.Equals(this.GiantResponsePlayFlow, other.GiantResponsePlayFlow) && this.GiantResponseCase == other.GiantResponseCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x0018583C File Offset: 0x00183A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GiantResponseType != GiantResponseType.PlayAnimation)
			{
				num ^= this.GiantResponseType.GetHashCode();
			}
			if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation)
			{
				num ^= this.GiantResponsePlayAnimation.GetHashCode();
			}
			if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow)
			{
				num ^= this.GiantResponsePlayFlow.GetHashCode();
			}
			num ^= (int)this.giantResponseCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x001858B8 File Offset: 0x00183AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x001858C5 File Offset: 0x00183AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x001858D0 File Offset: 0x00183AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GiantResponseType != GiantResponseType.PlayAnimation)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.GiantResponseType);
			}
			if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GiantResponsePlayAnimation);
			}
			if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.GiantResponsePlayFlow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x00185948 File Offset: 0x00183B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GiantResponseType != GiantResponseType.PlayAnimation)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.GiantResponseType);
			}
			if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GiantResponsePlayAnimation);
			}
			if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GiantResponsePlayFlow);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x001859B8 File Offset: 0x00183BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantResponsePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GiantResponseType != GiantResponseType.PlayAnimation)
			{
				this.GiantResponseType = other.GiantResponseType;
			}
			GiantResponsePb.GiantResponseOneofCase giantResponseCase = other.GiantResponseCase;
			if (giantResponseCase != GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation)
			{
				if (giantResponseCase == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow)
				{
					if (this.GiantResponsePlayFlow == null)
					{
						this.GiantResponsePlayFlow = new GiantResponsePlayFlowPb();
					}
					this.GiantResponsePlayFlow.MergeFrom(other.GiantResponsePlayFlow);
				}
			}
			else
			{
				if (this.GiantResponsePlayAnimation == null)
				{
					this.GiantResponsePlayAnimation = new GiantResponsePlayAnimationPb();
				}
				this.GiantResponsePlayAnimation.MergeFrom(other.GiantResponsePlayAnimation);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x00185A4F File Offset: 0x00183C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x00185A58 File Offset: 0x00183C58
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							GiantResponsePlayFlowPb giantResponsePlayFlowPb = new GiantResponsePlayFlowPb();
							if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayFlow)
							{
								giantResponsePlayFlowPb.MergeFrom(this.GiantResponsePlayFlow);
							}
							input.ReadMessage(giantResponsePlayFlowPb);
							this.GiantResponsePlayFlow = giantResponsePlayFlowPb;
						}
					}
					else
					{
						GiantResponsePlayAnimationPb giantResponsePlayAnimationPb = new GiantResponsePlayAnimationPb();
						if (this.giantResponseCase_ == GiantResponsePb.GiantResponseOneofCase.GiantResponsePlayAnimation)
						{
							giantResponsePlayAnimationPb.MergeFrom(this.GiantResponsePlayAnimation);
						}
						input.ReadMessage(giantResponsePlayAnimationPb);
						this.GiantResponsePlayAnimation = giantResponsePlayAnimationPb;
					}
				}
				else
				{
					this.GiantResponseType = (GiantResponseType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004AD0 RID: 19152
		private static readonly MessageParser<GiantResponsePb> _parser = new MessageParser<GiantResponsePb>(() => new GiantResponsePb());

		// Token: 0x04004AD1 RID: 19153
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AD2 RID: 19154
		public const int GiantResponseTypeFieldNumber = 1;

		// Token: 0x04004AD3 RID: 19155
		private GiantResponseType giantResponseType_;

		// Token: 0x04004AD4 RID: 19156
		public const int GiantResponsePlayAnimationFieldNumber = 2;

		// Token: 0x04004AD5 RID: 19157
		public const int GiantResponsePlayFlowFieldNumber = 3;

		// Token: 0x04004AD6 RID: 19158
		private object giantResponse_;

		// Token: 0x04004AD7 RID: 19159
		private GiantResponsePb.GiantResponseOneofCase giantResponseCase_;

		// Token: 0x020017D1 RID: 6097
		public enum GiantResponseOneofCase
		{
			// Token: 0x0400C766 RID: 51046
			None,
			// Token: 0x0400C767 RID: 51047
			GiantResponsePlayAnimation = 2,
			// Token: 0x0400C768 RID: 51048
			GiantResponsePlayFlow
		}
	}
}
