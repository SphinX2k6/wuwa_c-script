using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093E RID: 2366
	public sealed class LongPressInteractActionCtxPb : IMessage<LongPressInteractActionCtxPb>, IMessage, IEquatable<LongPressInteractActionCtxPb>, IDeepCloneable<LongPressInteractActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600D0F4 RID: 53492 RVA: 0x001ED36C File Offset: 0x001EB56C
		[NullableContext(1)]
		public static LongPressInteractActionCtxPb Create()
		{
			return new LongPressInteractActionCtxPb();
		}

		// Token: 0x17002A45 RID: 10821
		// (get) Token: 0x0600D0F5 RID: 53493 RVA: 0x001ED373 File Offset: 0x001EB573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A46 RID: 10822
		// (get) Token: 0x0600D0F6 RID: 53494 RVA: 0x001ED376 File Offset: 0x001EB576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LongPressInteractActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600D0F7 RID: 53495 RVA: 0x001ED37D File Offset: 0x001EB57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractActionCtxPb()
		{
		}

		// Token: 0x0600D0F8 RID: 53496 RVA: 0x001ED388 File Offset: 0x001EB588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractActionCtxPb(LongPressInteractActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0F9 RID: 53497 RVA: 0x001ED3D4 File Offset: 0x001EB5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LongPressInteractActionCtxPb Clone()
		{
			return new LongPressInteractActionCtxPb(this);
		}

		// Token: 0x17002A47 RID: 10823
		// (get) Token: 0x0600D0FA RID: 53498 RVA: 0x001ED3DC File Offset: 0x001EB5DC
		// (set) Token: 0x0600D0FB RID: 53499 RVA: 0x001ED3E4 File Offset: 0x001EB5E4
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

		// Token: 0x17002A48 RID: 10824
		// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x001ED3ED File Offset: 0x001EB5ED
		// (set) Token: 0x0600D0FD RID: 53501 RVA: 0x001ED3F5 File Offset: 0x001EB5F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OptionIndex
		{
			get
			{
				return this.optionIndex_;
			}
			set
			{
				this.optionIndex_ = value;
			}
		}

		// Token: 0x0600D0FE RID: 53502 RVA: 0x001ED3FE File Offset: 0x001EB5FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LongPressInteractActionCtxPb);
		}

		// Token: 0x0600D0FF RID: 53503 RVA: 0x001ED40C File Offset: 0x001EB60C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LongPressInteractActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D100 RID: 53504 RVA: 0x001ED45C File Offset: 0x001EB65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.OptionIndex != 0)
			{
				num ^= this.OptionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D101 RID: 53505 RVA: 0x001ED4B1 File Offset: 0x001EB6B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D102 RID: 53506 RVA: 0x001ED4BE File Offset: 0x001EB6BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D103 RID: 53507 RVA: 0x001ED4C8 File Offset: 0x001EB6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.OptionIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D104 RID: 53508 RVA: 0x001ED524 File Offset: 0x001EB724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.OptionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OptionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D105 RID: 53509 RVA: 0x001ED57C File Offset: 0x001EB77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LongPressInteractActionCtxPb other)
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
			if (other.OptionIndex != 0)
			{
				this.OptionIndex = other.OptionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D106 RID: 53510 RVA: 0x001ED5E4 File Offset: 0x001EB7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D107 RID: 53511 RVA: 0x001ED5F0 File Offset: 0x001EB7F0
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
						this.OptionIndex = input.ReadInt32();
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

		// Token: 0x04005871 RID: 22641
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005872 RID: 22642
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04005873 RID: 22643
		private EntityCtxPb entityCtx_;

		// Token: 0x04005874 RID: 22644
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x04005875 RID: 22645
		private int optionIndex_;
	}
}
