using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200089F RID: 2207
	[NetMessage(EMessageId.KurotatoItemUpdateNotify)]
	public sealed class KurotatoItemUpdateNotify : IMessage<KurotatoItemUpdateNotify>, IMessage, IEquatable<KurotatoItemUpdateNotify>, IDeepCloneable<KurotatoItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C41E RID: 50206 RVA: 0x001D1211 File Offset: 0x001CF411
		[NullableContext(1)]
		public static KurotatoItemUpdateNotify Create()
		{
			return new KurotatoItemUpdateNotify();
		}

		// Token: 0x170027A6 RID: 10150
		// (get) Token: 0x0600C41F RID: 50207 RVA: 0x001D1218 File Offset: 0x001CF418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027A7 RID: 10151
		// (get) Token: 0x0600C420 RID: 50208 RVA: 0x001D121B File Offset: 0x001CF41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x001D1222 File Offset: 0x001CF422
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUpdateNotify()
		{
		}

		// Token: 0x0600C422 RID: 50210 RVA: 0x001D122C File Offset: 0x001CF42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUpdateNotify(KurotatoItemUpdateNotify other) : this()
		{
			this.itemPbData_ = ((other.itemPbData_ != null) ? other.itemPbData_.Clone() : null);
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C423 RID: 50211 RVA: 0x001D1278 File Offset: 0x001CF478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUpdateNotify Clone()
		{
			return new KurotatoItemUpdateNotify(this);
		}

		// Token: 0x170027A8 RID: 10152
		// (get) Token: 0x0600C424 RID: 50212 RVA: 0x001D1280 File Offset: 0x001CF480
		// (set) Token: 0x0600C425 RID: 50213 RVA: 0x001D1288 File Offset: 0x001CF488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemPbData ItemPbData
		{
			get
			{
				return this.itemPbData_;
			}
			set
			{
				this.itemPbData_ = value;
			}
		}

		// Token: 0x170027A9 RID: 10153
		// (get) Token: 0x0600C426 RID: 50214 RVA: 0x001D1291 File Offset: 0x001CF491
		// (set) Token: 0x0600C427 RID: 50215 RVA: 0x001D1299 File Offset: 0x001CF499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x0600C428 RID: 50216 RVA: 0x001D12A2 File Offset: 0x001CF4A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemUpdateNotify);
		}

		// Token: 0x0600C429 RID: 50217 RVA: 0x001D12B0 File Offset: 0x001CF4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ItemPbData, other.ItemPbData) && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C42A RID: 50218 RVA: 0x001D1300 File Offset: 0x001CF500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.itemPbData_ != null)
			{
				num ^= this.ItemPbData.GetHashCode();
			}
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C42B RID: 50219 RVA: 0x001D1355 File Offset: 0x001CF555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C42C RID: 50220 RVA: 0x001D1362 File Offset: 0x001CF562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C42D RID: 50221 RVA: 0x001D136C File Offset: 0x001CF56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAdd)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsAdd);
			}
			if (this.itemPbData_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ItemPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C42E RID: 50222 RVA: 0x001D13C4 File Offset: 0x001CF5C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.itemPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ItemPbData);
			}
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C42F RID: 50223 RVA: 0x001D1410 File Offset: 0x001CF610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.itemPbData_ != null)
			{
				if (this.itemPbData_ == null)
				{
					this.ItemPbData = new KurotatoItemPbData();
				}
				this.ItemPbData.MergeFrom(other.ItemPbData);
			}
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C430 RID: 50224 RVA: 0x001D1478 File Offset: 0x001CF678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C431 RID: 50225 RVA: 0x001D1484 File Offset: 0x001CF684
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
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.itemPbData_ == null)
						{
							this.ItemPbData = new KurotatoItemPbData();
						}
						input.ReadMessage(this.ItemPbData);
					}
				}
				else
				{
					this.IsAdd = input.ReadBool();
				}
			}
		}

		// Token: 0x040054A4 RID: 21668
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054A5 RID: 21669
		public const int ItemPbDataFieldNumber = 12;

		// Token: 0x040054A6 RID: 21670
		private KurotatoItemPbData itemPbData_;

		// Token: 0x040054A7 RID: 21671
		public const int IsAddFieldNumber = 1;

		// Token: 0x040054A8 RID: 21672
		private bool isAdd_;
	}
}
