using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4A RID: 2890
	public sealed class NormalInteractCtxPb : IMessage<NormalInteractCtxPb>, IMessage, IEquatable<NormalInteractCtxPb>, IDeepCloneable<NormalInteractCtxPb>, IBufferMessage
	{
		// Token: 0x0600FADE RID: 64222 RVA: 0x0024921B File Offset: 0x0024741B
		[NullableContext(1)]
		public static NormalInteractCtxPb Create()
		{
			return new NormalInteractCtxPb();
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600FADF RID: 64223 RVA: 0x00249222 File Offset: 0x00247422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600FAE0 RID: 64224 RVA: 0x00249225 File Offset: 0x00247425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalInteractCtxPb.Descriptor;
			}
		}

		// Token: 0x0600FAE1 RID: 64225 RVA: 0x0024922C File Offset: 0x0024742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalInteractCtxPb()
		{
		}

		// Token: 0x0600FAE2 RID: 64226 RVA: 0x00249234 File Offset: 0x00247434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalInteractCtxPb(NormalInteractCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.optionIndex_ = other.optionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAE3 RID: 64227 RVA: 0x00249280 File Offset: 0x00247480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalInteractCtxPb Clone()
		{
			return new NormalInteractCtxPb(this);
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600FAE4 RID: 64228 RVA: 0x00249288 File Offset: 0x00247488
		// (set) Token: 0x0600FAE5 RID: 64229 RVA: 0x00249290 File Offset: 0x00247490
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

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600FAE6 RID: 64230 RVA: 0x00249299 File Offset: 0x00247499
		// (set) Token: 0x0600FAE7 RID: 64231 RVA: 0x002492A1 File Offset: 0x002474A1
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

		// Token: 0x0600FAE8 RID: 64232 RVA: 0x002492AA File Offset: 0x002474AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalInteractCtxPb);
		}

		// Token: 0x0600FAE9 RID: 64233 RVA: 0x002492B8 File Offset: 0x002474B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalInteractCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.OptionIndex == other.OptionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAEA RID: 64234 RVA: 0x00249308 File Offset: 0x00247508
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

		// Token: 0x0600FAEB RID: 64235 RVA: 0x0024935D File Offset: 0x0024755D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FAEC RID: 64236 RVA: 0x0024936A File Offset: 0x0024756A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FAED RID: 64237 RVA: 0x00249374 File Offset: 0x00247574
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

		// Token: 0x0600FAEE RID: 64238 RVA: 0x002493D0 File Offset: 0x002475D0
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

		// Token: 0x0600FAEF RID: 64239 RVA: 0x00249428 File Offset: 0x00247628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalInteractCtxPb other)
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

		// Token: 0x0600FAF0 RID: 64240 RVA: 0x00249490 File Offset: 0x00247690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FAF1 RID: 64241 RVA: 0x0024949C File Offset: 0x0024769C
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

		// Token: 0x040064B0 RID: 25776
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064B1 RID: 25777
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x040064B2 RID: 25778
		private EntityCtxPb entityCtx_;

		// Token: 0x040064B3 RID: 25779
		public const int OptionIndexFieldNumber = 2;

		// Token: 0x040064B4 RID: 25780
		private int optionIndex_;
	}
}
