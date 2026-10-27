using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A9E RID: 2718
	public sealed class MotorSliderCtxPb : IMessage<MotorSliderCtxPb>, IMessage, IEquatable<MotorSliderCtxPb>, IDeepCloneable<MotorSliderCtxPb>, IBufferMessage
	{
		// Token: 0x0600ECA9 RID: 60585 RVA: 0x00228D2C File Offset: 0x00226F2C
		[NullableContext(1)]
		public static MotorSliderCtxPb Create()
		{
			return new MotorSliderCtxPb();
		}

		// Token: 0x17003012 RID: 12306
		// (get) Token: 0x0600ECAA RID: 60586 RVA: 0x00228D33 File Offset: 0x00226F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003013 RID: 12307
		// (get) Token: 0x0600ECAB RID: 60587 RVA: 0x00228D36 File Offset: 0x00226F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSliderCtxPb.Descriptor;
			}
		}

		// Token: 0x0600ECAC RID: 60588 RVA: 0x00228D3D File Offset: 0x00226F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderCtxPb()
		{
		}

		// Token: 0x0600ECAD RID: 60589 RVA: 0x00228D48 File Offset: 0x00226F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderCtxPb(MotorSliderCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ECAE RID: 60590 RVA: 0x00228D94 File Offset: 0x00226F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderCtxPb Clone()
		{
			return new MotorSliderCtxPb(this);
		}

		// Token: 0x17003014 RID: 12308
		// (get) Token: 0x0600ECAF RID: 60591 RVA: 0x00228D9C File Offset: 0x00226F9C
		// (set) Token: 0x0600ECB0 RID: 60592 RVA: 0x00228DA4 File Offset: 0x00226FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17003015 RID: 12309
		// (get) Token: 0x0600ECB1 RID: 60593 RVA: 0x00228DAD File Offset: 0x00226FAD
		// (set) Token: 0x0600ECB2 RID: 60594 RVA: 0x00228DB5 File Offset: 0x00226FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x0600ECB3 RID: 60595 RVA: 0x00228DBE File Offset: 0x00226FBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSliderCtxPb);
		}

		// Token: 0x0600ECB4 RID: 60596 RVA: 0x00228DCC File Offset: 0x00226FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSliderCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ECB5 RID: 60597 RVA: 0x00228E1C File Offset: 0x0022701C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ECB6 RID: 60598 RVA: 0x00228E71 File Offset: 0x00227071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ECB7 RID: 60599 RVA: 0x00228E7E File Offset: 0x0022707E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ECB8 RID: 60600 RVA: 0x00228E88 File Offset: 0x00227088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ECB9 RID: 60601 RVA: 0x00228EE4 File Offset: 0x002270E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ECBA RID: 60602 RVA: 0x00228F30 File Offset: 0x00227130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorSliderCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ECBB RID: 60603 RVA: 0x00228F98 File Offset: 0x00227198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ECBC RID: 60604 RVA: 0x00228FA4 File Offset: 0x002271A4
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsEnter = input.ReadBool();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04005FF2 RID: 24562
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FF3 RID: 24563
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04005FF4 RID: 24564
		private EntityCtxPb entityCtx_;

		// Token: 0x04005FF5 RID: 24565
		public const int IsEnterFieldNumber = 2;

		// Token: 0x04005FF6 RID: 24566
		private bool isEnter_;
	}
}
