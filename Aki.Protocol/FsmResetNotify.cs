using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000670 RID: 1648
	[NetMessage(EMessageId.FsmResetNotify)]
	public sealed class FsmResetNotify : IMessage<FsmResetNotify>, IMessage, IEquatable<FsmResetNotify>, IDeepCloneable<FsmResetNotify>, IBufferMessage
	{
		// Token: 0x06009723 RID: 38691 RVA: 0x0016C929 File Offset: 0x0016AB29
		[NullableContext(1)]
		public static FsmResetNotify Create()
		{
			return new FsmResetNotify();
		}

		// Token: 0x17001E1B RID: 7707
		// (get) Token: 0x06009724 RID: 38692 RVA: 0x0016C930 File Offset: 0x0016AB30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x06009725 RID: 38693 RVA: 0x0016C933 File Offset: 0x0016AB33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FsmResetNotify.Descriptor;
			}
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x0016C93A File Offset: 0x0016AB3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmResetNotify()
		{
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x0016C942 File Offset: 0x0016AB42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmResetNotify(FsmResetNotify other) : this()
		{
			this.entityFsmComponentPb_ = ((other.entityFsmComponentPb_ != null) ? other.entityFsmComponentPb_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009728 RID: 38696 RVA: 0x0016C977 File Offset: 0x0016AB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FsmResetNotify Clone()
		{
			return new FsmResetNotify(this);
		}

		// Token: 0x17001E1D RID: 7709
		// (get) Token: 0x06009729 RID: 38697 RVA: 0x0016C97F File Offset: 0x0016AB7F
		// (set) Token: 0x0600972A RID: 38698 RVA: 0x0016C987 File Offset: 0x0016AB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFsmComponentPb EntityFsmComponentPb
		{
			get
			{
				return this.entityFsmComponentPb_;
			}
			set
			{
				this.entityFsmComponentPb_ = value;
			}
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x0016C990 File Offset: 0x0016AB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FsmResetNotify);
		}

		// Token: 0x0600972C RID: 38700 RVA: 0x0016C99E File Offset: 0x0016AB9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FsmResetNotify other)
		{
			return other != null && (other == this || (object.Equals(this.EntityFsmComponentPb, other.EntityFsmComponentPb) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600972D RID: 38701 RVA: 0x0016C9D4 File Offset: 0x0016ABD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityFsmComponentPb_ != null)
			{
				num ^= this.EntityFsmComponentPb.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x0016CA10 File Offset: 0x0016AC10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x0016CA1D File Offset: 0x0016AC1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x0016CA26 File Offset: 0x0016AC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityFsmComponentPb_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.EntityFsmComponentPb);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x0016CA58 File Offset: 0x0016AC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityFsmComponentPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityFsmComponentPb);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x0016CA98 File Offset: 0x0016AC98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FsmResetNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityFsmComponentPb_ != null)
			{
				if (this.entityFsmComponentPb_ == null)
				{
					this.EntityFsmComponentPb = new EntityFsmComponentPb();
				}
				this.EntityFsmComponentPb.MergeFrom(other.EntityFsmComponentPb);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x0016CAEC File Offset: 0x0016ACEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x0016CAF8 File Offset: 0x0016ACF8
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.entityFsmComponentPb_ == null)
					{
						this.EntityFsmComponentPb = new EntityFsmComponentPb();
					}
					input.ReadMessage(this.EntityFsmComponentPb);
				}
			}
		}

		// Token: 0x040047E7 RID: 18407
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047E8 RID: 18408
		public const int EntityFsmComponentPbFieldNumber = 5;

		// Token: 0x040047E9 RID: 18409
		private EntityFsmComponentPb entityFsmComponentPb_;
	}
}
