using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D34 RID: 3380
	[NetMessage(EMessageId.PhotoMemoryCollectNotify)]
	public sealed class PhotoMemoryCollectNotify : IMessage<PhotoMemoryCollectNotify>, IMessage, IEquatable<PhotoMemoryCollectNotify>, IDeepCloneable<PhotoMemoryCollectNotify>, IBufferMessage
	{
		// Token: 0x060123F8 RID: 74744 RVA: 0x002AA1F6 File Offset: 0x002A83F6
		[NullableContext(1)]
		public static PhotoMemoryCollectNotify Create()
		{
			return new PhotoMemoryCollectNotify();
		}

		// Token: 0x17003C7A RID: 15482
		// (get) Token: 0x060123F9 RID: 74745 RVA: 0x002AA1FD File Offset: 0x002A83FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C7B RID: 15483
		// (get) Token: 0x060123FA RID: 74746 RVA: 0x002AA200 File Offset: 0x002A8400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryCollectNotify.Descriptor;
			}
		}

		// Token: 0x060123FB RID: 74747 RVA: 0x002AA207 File Offset: 0x002A8407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectNotify()
		{
		}

		// Token: 0x060123FC RID: 74748 RVA: 0x002AA20F File Offset: 0x002A840F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectNotify(PhotoMemoryCollectNotify other) : this()
		{
			this.collectInfo_ = ((other.collectInfo_ != null) ? other.collectInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123FD RID: 74749 RVA: 0x002AA244 File Offset: 0x002A8444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectNotify Clone()
		{
			return new PhotoMemoryCollectNotify(this);
		}

		// Token: 0x17003C7C RID: 15484
		// (get) Token: 0x060123FE RID: 74750 RVA: 0x002AA24C File Offset: 0x002A844C
		// (set) Token: 0x060123FF RID: 74751 RVA: 0x002AA254 File Offset: 0x002A8454
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

		// Token: 0x06012400 RID: 74752 RVA: 0x002AA25D File Offset: 0x002A845D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryCollectNotify);
		}

		// Token: 0x06012401 RID: 74753 RVA: 0x002AA26B File Offset: 0x002A846B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryCollectNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CollectInfo, other.CollectInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012402 RID: 74754 RVA: 0x002AA2A0 File Offset: 0x002A84A0
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

		// Token: 0x06012403 RID: 74755 RVA: 0x002AA2DC File Offset: 0x002A84DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012404 RID: 74756 RVA: 0x002AA2E9 File Offset: 0x002A84E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012405 RID: 74757 RVA: 0x002AA2F2 File Offset: 0x002A84F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.collectInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.CollectInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012406 RID: 74758 RVA: 0x002AA324 File Offset: 0x002A8524
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

		// Token: 0x06012407 RID: 74759 RVA: 0x002AA364 File Offset: 0x002A8564
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

		// Token: 0x06012408 RID: 74760 RVA: 0x002AA3B8 File Offset: 0x002A85B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012409 RID: 74761 RVA: 0x002AA3C4 File Offset: 0x002A85C4
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
				if (num != 74U)
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

		// Token: 0x040071E4 RID: 29156
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071E5 RID: 29157
		public const int CollectInfoFieldNumber = 9;

		// Token: 0x040071E6 RID: 29158
		private PhotoMemoryCollectInfo collectInfo_;
	}
}
