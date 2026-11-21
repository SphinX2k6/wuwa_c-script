using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A8D RID: 2701
	public sealed class MotorSliderCtxPb : IMessage<MotorSliderCtxPb>, IMessage, IEquatable<MotorSliderCtxPb>, IDeepCloneable<MotorSliderCtxPb>, IBufferMessage
	{
		// Token: 0x0600EB8F RID: 60303 RVA: 0x00226B34 File Offset: 0x00224D34
		[NullableContext(1)]
		public static MotorSliderCtxPb Create()
		{
			return new MotorSliderCtxPb();
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x0600EB90 RID: 60304 RVA: 0x00226B3B File Offset: 0x00224D3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x0600EB91 RID: 60305 RVA: 0x00226B3E File Offset: 0x00224D3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorSliderCtxPb.Descriptor;
			}
		}

		// Token: 0x0600EB92 RID: 60306 RVA: 0x00226B45 File Offset: 0x00224D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderCtxPb()
		{
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x00226B50 File Offset: 0x00224D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderCtxPb(MotorSliderCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EB94 RID: 60308 RVA: 0x00226B9C File Offset: 0x00224D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorSliderCtxPb Clone()
		{
			return new MotorSliderCtxPb(this);
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x00226BA4 File Offset: 0x00224DA4
		// (set) Token: 0x0600EB96 RID: 60310 RVA: 0x00226BAC File Offset: 0x00224DAC
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

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x0600EB97 RID: 60311 RVA: 0x00226BB5 File Offset: 0x00224DB5
		// (set) Token: 0x0600EB98 RID: 60312 RVA: 0x00226BBD File Offset: 0x00224DBD
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

		// Token: 0x0600EB99 RID: 60313 RVA: 0x00226BC6 File Offset: 0x00224DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorSliderCtxPb);
		}

		// Token: 0x0600EB9A RID: 60314 RVA: 0x00226BD4 File Offset: 0x00224DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorSliderCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EB9B RID: 60315 RVA: 0x00226C24 File Offset: 0x00224E24
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

		// Token: 0x0600EB9C RID: 60316 RVA: 0x00226C79 File Offset: 0x00224E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x00226C86 File Offset: 0x00224E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EB9E RID: 60318 RVA: 0x00226C90 File Offset: 0x00224E90
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

		// Token: 0x0600EB9F RID: 60319 RVA: 0x00226CEC File Offset: 0x00224EEC
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

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x00226D38 File Offset: 0x00224F38
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

		// Token: 0x0600EBA1 RID: 60321 RVA: 0x00226DA0 File Offset: 0x00224FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x00226DAC File Offset: 0x00224FAC
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

		// Token: 0x04005FFB RID: 24571
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FFC RID: 24572
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04005FFD RID: 24573
		private EntityCtxPb entityCtx_;

		// Token: 0x04005FFE RID: 24574
		public const int IsEnterFieldNumber = 2;

		// Token: 0x04005FFF RID: 24575
		private bool isEnter_;
	}
}
