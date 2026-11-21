using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D24 RID: 3364
	[NetMessage(EMessageId.PhotoMemoryCollectNotify)]
	public sealed class PhotoMemoryCollectNotify : IMessage<PhotoMemoryCollectNotify>, IMessage, IEquatable<PhotoMemoryCollectNotify>, IDeepCloneable<PhotoMemoryCollectNotify>, IBufferMessage
	{
		// Token: 0x060122FC RID: 74492 RVA: 0x002A85CE File Offset: 0x002A67CE
		[NullableContext(1)]
		public static PhotoMemoryCollectNotify Create()
		{
			return new PhotoMemoryCollectNotify();
		}

		// Token: 0x17003C45 RID: 15429
		// (get) Token: 0x060122FD RID: 74493 RVA: 0x002A85D5 File Offset: 0x002A67D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x060122FE RID: 74494 RVA: 0x002A85D8 File Offset: 0x002A67D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryCollectNotify.Descriptor;
			}
		}

		// Token: 0x060122FF RID: 74495 RVA: 0x002A85DF File Offset: 0x002A67DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectNotify()
		{
		}

		// Token: 0x06012300 RID: 74496 RVA: 0x002A85E7 File Offset: 0x002A67E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectNotify(PhotoMemoryCollectNotify other) : this()
		{
			this.collectInfo_ = ((other.collectInfo_ != null) ? other.collectInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012301 RID: 74497 RVA: 0x002A861C File Offset: 0x002A681C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectNotify Clone()
		{
			return new PhotoMemoryCollectNotify(this);
		}

		// Token: 0x17003C47 RID: 15431
		// (get) Token: 0x06012302 RID: 74498 RVA: 0x002A8624 File Offset: 0x002A6824
		// (set) Token: 0x06012303 RID: 74499 RVA: 0x002A862C File Offset: 0x002A682C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectInfo CollectInfo
		{
			get
			{
				return this.collectInfo_;
			}
			set
			{
				this.collectInfo_ = value;
			}
		}

		// Token: 0x06012304 RID: 74500 RVA: 0x002A8635 File Offset: 0x002A6835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryCollectNotify);
		}

		// Token: 0x06012305 RID: 74501 RVA: 0x002A8643 File Offset: 0x002A6843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryCollectNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CollectInfo, other.CollectInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012306 RID: 74502 RVA: 0x002A8678 File Offset: 0x002A6878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.collectInfo_ != null)
			{
				num ^= this.CollectInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012307 RID: 74503 RVA: 0x002A86B4 File Offset: 0x002A68B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012308 RID: 74504 RVA: 0x002A86C1 File Offset: 0x002A68C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012309 RID: 74505 RVA: 0x002A86CA File Offset: 0x002A68CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.collectInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.CollectInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601230A RID: 74506 RVA: 0x002A86FC File Offset: 0x002A68FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.collectInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CollectInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601230B RID: 74507 RVA: 0x002A873C File Offset: 0x002A693C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryCollectNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.collectInfo_ != null)
			{
				if (this.collectInfo_ == null)
				{
					this.CollectInfo = new PhotoMemoryCollectInfo();
				}
				this.CollectInfo.MergeFrom(other.CollectInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601230C RID: 74508 RVA: 0x002A8790 File Offset: 0x002A6990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601230D RID: 74509 RVA: 0x002A879C File Offset: 0x002A699C
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.collectInfo_ == null)
					{
						this.CollectInfo = new PhotoMemoryCollectInfo();
					}
					input.ReadMessage(this.CollectInfo);
				}
			}
		}

		// Token: 0x040071FC RID: 29180
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071FD RID: 29181
		public const int CollectInfoFieldNumber = 10;

		// Token: 0x040071FE RID: 29182
		private PhotoMemoryCollectInfo collectInfo_;
	}
}
