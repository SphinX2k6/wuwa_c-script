using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F9 RID: 4601
	[NetMessage(EMessageId.ShopUnlockNotify)]
	public sealed class ShopUnlockNotify : IMessage<ShopUnlockNotify>, IMessage, IEquatable<ShopUnlockNotify>, IDeepCloneable<ShopUnlockNotify>, IBufferMessage
	{
		// Token: 0x06018883 RID: 100483 RVA: 0x0039179B File Offset: 0x0038F99B
		[NullableContext(1)]
		public static ShopUnlockNotify Create()
		{
			return new ShopUnlockNotify();
		}

		// Token: 0x170052A6 RID: 21158
		// (get) Token: 0x06018884 RID: 100484 RVA: 0x003917A2 File Offset: 0x0038F9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052A7 RID: 21159
		// (get) Token: 0x06018885 RID: 100485 RVA: 0x003917A5 File Offset: 0x0038F9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06018886 RID: 100486 RVA: 0x003917AC File Offset: 0x0038F9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUnlockNotify()
		{
		}

		// Token: 0x06018887 RID: 100487 RVA: 0x003917BF File Offset: 0x0038F9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUnlockNotify(ShopUnlockNotify other) : this()
		{
			this.unlockList_ = other.unlockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018888 RID: 100488 RVA: 0x003917E9 File Offset: 0x0038F9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUnlockNotify Clone()
		{
			return new ShopUnlockNotify(this);
		}

		// Token: 0x170052A8 RID: 21160
		// (get) Token: 0x06018889 RID: 100489 RVA: 0x003917F1 File Offset: 0x0038F9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UnlockInfo> UnlockList
		{
			get
			{
				return this.unlockList_;
			}
		}

		// Token: 0x0601888A RID: 100490 RVA: 0x003917F9 File Offset: 0x0038F9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopUnlockNotify);
		}

		// Token: 0x0601888B RID: 100491 RVA: 0x00391807 File Offset: 0x0038FA07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockList_.Equals(other.unlockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601888C RID: 100492 RVA: 0x0039183C File Offset: 0x0038FA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601888D RID: 100493 RVA: 0x00391870 File Offset: 0x0038FA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601888E RID: 100494 RVA: 0x0039187D File Offset: 0x0038FA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601888F RID: 100495 RVA: 0x00391886 File Offset: 0x0038FA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockList_.WriteTo(ref output, ShopUnlockNotify._repeated_unlockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018890 RID: 100496 RVA: 0x003918B0 File Offset: 0x0038FAB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockList_.CalculateSize(ShopUnlockNotify._repeated_unlockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018891 RID: 100497 RVA: 0x003918E9 File Offset: 0x0038FAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockList_.Add(other.unlockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018892 RID: 100498 RVA: 0x00391917 File Offset: 0x0038FB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018893 RID: 100499 RVA: 0x00391920 File Offset: 0x0038FB20
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
					this.unlockList_.AddEntriesFrom(ref input, ShopUnlockNotify._repeated_unlockList_codec);
				}
			}
		}

		// Token: 0x0400910B RID: 37131
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400910C RID: 37132
		public const int UnlockListFieldNumber = 10;

		// Token: 0x0400910D RID: 37133
		private static readonly FieldCodec<UnlockInfo> _repeated_unlockList_codec = FieldCodec.ForMessage<UnlockInfo>(82U, UnlockInfo.Parser);

		// Token: 0x0400910E RID: 37134
		private readonly RepeatedField<UnlockInfo> unlockList_ = new RepeatedField<UnlockInfo>();
	}
}
