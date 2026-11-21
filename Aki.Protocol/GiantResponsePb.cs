using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006CF RID: 1743
	public sealed class GiantResponsePb : IMessage<GiantResponsePb>, IMessage, IEquatable<GiantResponsePb>, IDeepCloneable<GiantResponsePb>, IBufferMessage
	{
		// Token: 0x06009F86 RID: 40838 RVA: 0x00182C74 File Offset: 0x00180E74
		[NullableContext(1)]
		public static GiantResponsePb Create()
		{
			return new GiantResponsePb();
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06009F87 RID: 40839 RVA: 0x00182C7B File Offset: 0x00180E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GiantResponsePb> Parser
		{
			get
			{
				return GiantResponsePb._parser;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06009F88 RID: 40840 RVA: 0x00182C82 File Offset: 0x00180E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06009F89 RID: 40841 RVA: 0x00182C85 File Offset: 0x00180E85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantResponsePb.Descriptor;
			}
		}

		// Token: 0x06009F8A RID: 40842 RVA: 0x00182C8C File Offset: 0x00180E8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePb()
		{
		}

		// Token: 0x06009F8B RID: 40843 RVA: 0x00182C94 File Offset: 0x00180E94
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

		// Token: 0x06009F8C RID: 40844 RVA: 0x00182CF9 File Offset: 0x00180EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePb Clone()
		{
			return new GiantResponsePb(this);
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06009F8D RID: 40845 RVA: 0x00182D01 File Offset: 0x00180F01
		// (set) Token: 0x06009F8E RID: 40846 RVA: 0x00182D09 File Offset: 0x00180F09
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

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x06009F8F RID: 40847 RVA: 0x00182D12 File Offset: 0x00180F12
		// (set) Token: 0x06009F90 RID: 40848 RVA: 0x00182D2A File Offset: 0x00180F2A
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

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x06009F91 RID: 40849 RVA: 0x00182D40 File Offset: 0x00180F40
		// (set) Token: 0x06009F92 RID: 40850 RVA: 0x00182D58 File Offset: 0x00180F58
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

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x06009F93 RID: 40851 RVA: 0x00182D6E File Offset: 0x00180F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantResponsePb.GiantResponseOneofCase GiantResponseCase
		{
			get
			{
				return this.giantResponseCase_;
			}
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x00182D76 File Offset: 0x00180F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearGiantResponse()
		{
			this.giantResponseCase_ = GiantResponsePb.GiantResponseOneofCase.None;
			this.giantResponse_ = null;
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x00182D86 File Offset: 0x00180F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantResponsePb);
		}

		// Token: 0x06009F96 RID: 40854 RVA: 0x00182D94 File Offset: 0x00180F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantResponsePb other)
		{
			return other != null && (other == this || (this.GiantResponseType == other.GiantResponseType && object.Equals(this.GiantResponsePlayAnimation, other.GiantResponsePlayAnimation) && object.Equals(this.GiantResponsePlayFlow, other.GiantResponsePlayFlow) && this.GiantResponseCase == other.GiantResponseCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F97 RID: 40855 RVA: 0x00182E08 File Offset: 0x00181008
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

		// Token: 0x06009F98 RID: 40856 RVA: 0x00182E84 File Offset: 0x00181084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009F99 RID: 40857 RVA: 0x00182E91 File Offset: 0x00181091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F9A RID: 40858 RVA: 0x00182E9C File Offset: 0x0018109C
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

		// Token: 0x06009F9B RID: 40859 RVA: 0x00182F14 File Offset: 0x00181114
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

		// Token: 0x06009F9C RID: 40860 RVA: 0x00182F84 File Offset: 0x00181184
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

		// Token: 0x06009F9D RID: 40861 RVA: 0x0018301B File Offset: 0x0018121B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F9E RID: 40862 RVA: 0x00183024 File Offset: 0x00181224
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

		// Token: 0x04004AC9 RID: 19145
		private static readonly MessageParser<GiantResponsePb> _parser = new MessageParser<GiantResponsePb>(() => new GiantResponsePb());

		// Token: 0x04004ACA RID: 19146
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ACB RID: 19147
		public const int GiantResponseTypeFieldNumber = 1;

		// Token: 0x04004ACC RID: 19148
		private GiantResponseType giantResponseType_;

		// Token: 0x04004ACD RID: 19149
		public const int GiantResponsePlayAnimationFieldNumber = 2;

		// Token: 0x04004ACE RID: 19150
		public const int GiantResponsePlayFlowFieldNumber = 3;

		// Token: 0x04004ACF RID: 19151
		private object giantResponse_;

		// Token: 0x04004AD0 RID: 19152
		private GiantResponsePb.GiantResponseOneofCase giantResponseCase_;

		// Token: 0x02001849 RID: 6217
		public enum GiantResponseOneofCase
		{
			// Token: 0x0400CC91 RID: 52369
			None,
			// Token: 0x0400CC92 RID: 52370
			GiantResponsePlayAnimation = 2,
			// Token: 0x0400CC93 RID: 52371
			GiantResponsePlayFlow
		}
	}
}
