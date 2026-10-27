using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048E RID: 1166
	public sealed class EntityFoundationComponentPb : IMessage<EntityFoundationComponentPb>, IMessage, IEquatable<EntityFoundationComponentPb>, IDeepCloneable<EntityFoundationComponentPb>, IBufferMessage
	{
		// Token: 0x06006F81 RID: 28545 RVA: 0x00111B39 File Offset: 0x0010FD39
		[NullableContext(1)]
		public static EntityFoundationComponentPb Create()
		{
			return new EntityFoundationComponentPb();
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06006F82 RID: 28546 RVA: 0x00111B40 File Offset: 0x0010FD40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06006F83 RID: 28547 RVA: 0x00111B43 File Offset: 0x0010FD43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFoundationComponentPb.Descriptor;
			}
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x00111B4A File Offset: 0x0010FD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationComponentPb()
		{
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x00111B52 File Offset: 0x0010FD52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationComponentPb(EntityFoundationComponentPb other) : this()
		{
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x00111B87 File Offset: 0x0010FD87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationComponentPb Clone()
		{
			return new EntityFoundationComponentPb(this);
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x06006F87 RID: 28551 RVA: 0x00111B8F File Offset: 0x0010FD8F
		// (set) Token: 0x06006F88 RID: 28552 RVA: 0x00111B97 File Offset: 0x0010FD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x00111BA0 File Offset: 0x0010FDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFoundationComponentPb);
		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x00111BAE File Offset: 0x0010FDAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFoundationComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F8B RID: 28555 RVA: 0x00111BE4 File Offset: 0x0010FDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x00111C20 File Offset: 0x0010FE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x00111C2D File Offset: 0x0010FE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x00111C36 File Offset: 0x0010FE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00111C68 File Offset: 0x0010FE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x00111CA8 File Offset: 0x0010FEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFoundationComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F91 RID: 28561 RVA: 0x00111CFC File Offset: 0x0010FEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F92 RID: 28562 RVA: 0x00111D08 File Offset: 0x0010FF08
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.foundationCoreInfo_ == null)
					{
						this.FoundationCoreInfo = new FoundationCoreInfo();
					}
					input.ReadMessage(this.FoundationCoreInfo);
				}
			}
		}

		// Token: 0x04003BF2 RID: 15346
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BF3 RID: 15347
		public const int FoundationCoreInfoFieldNumber = 1;

		// Token: 0x04003BF4 RID: 15348
		private FoundationCoreInfo foundationCoreInfo_;
	}
}
