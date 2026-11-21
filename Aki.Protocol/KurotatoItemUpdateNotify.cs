using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088E RID: 2190
	[NetMessage(EMessageId.KurotatoItemUpdateNotify)]
	public sealed class KurotatoItemUpdateNotify : IMessage<KurotatoItemUpdateNotify>, IMessage, IEquatable<KurotatoItemUpdateNotify>, IDeepCloneable<KurotatoItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600C302 RID: 49922 RVA: 0x001CEF2D File Offset: 0x001CD12D
		[NullableContext(1)]
		public static KurotatoItemUpdateNotify Create()
		{
			return new KurotatoItemUpdateNotify();
		}

		// Token: 0x17002767 RID: 10087
		// (get) Token: 0x0600C303 RID: 49923 RVA: 0x001CEF34 File Offset: 0x001CD134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002768 RID: 10088
		// (get) Token: 0x0600C304 RID: 49924 RVA: 0x001CEF37 File Offset: 0x001CD137
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C305 RID: 49925 RVA: 0x001CEF3E File Offset: 0x001CD13E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUpdateNotify()
		{
		}

		// Token: 0x0600C306 RID: 49926 RVA: 0x001CEF48 File Offset: 0x001CD148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUpdateNotify(KurotatoItemUpdateNotify other) : this()
		{
			this.itemPbData_ = ((other.itemPbData_ != null) ? other.itemPbData_.Clone() : null);
			this.isAdd_ = other.isAdd_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C307 RID: 49927 RVA: 0x001CEF94 File Offset: 0x001CD194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemUpdateNotify Clone()
		{
			return new KurotatoItemUpdateNotify(this);
		}

		// Token: 0x17002769 RID: 10089
		// (get) Token: 0x0600C308 RID: 49928 RVA: 0x001CEF9C File Offset: 0x001CD19C
		// (set) Token: 0x0600C309 RID: 49929 RVA: 0x001CEFA4 File Offset: 0x001CD1A4
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

		// Token: 0x1700276A RID: 10090
		// (get) Token: 0x0600C30A RID: 49930 RVA: 0x001CEFAD File Offset: 0x001CD1AD
		// (set) Token: 0x0600C30B RID: 49931 RVA: 0x001CEFB5 File Offset: 0x001CD1B5
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

		// Token: 0x0600C30C RID: 49932 RVA: 0x001CEFBE File Offset: 0x001CD1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemUpdateNotify);
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x001CEFCC File Offset: 0x001CD1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ItemPbData, other.ItemPbData) && this.IsAdd == other.IsAdd && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C30E RID: 49934 RVA: 0x001CF01C File Offset: 0x001CD21C
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

		// Token: 0x0600C30F RID: 49935 RVA: 0x001CF071 File Offset: 0x001CD271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C310 RID: 49936 RVA: 0x001CF07E File Offset: 0x001CD27E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C311 RID: 49937 RVA: 0x001CF088 File Offset: 0x001CD288
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
				output.WriteRawTag(34);
				output.WriteMessage(this.ItemPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C312 RID: 49938 RVA: 0x001CF0E0 File Offset: 0x001CD2E0
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

		// Token: 0x0600C313 RID: 49939 RVA: 0x001CF12C File Offset: 0x001CD32C
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

		// Token: 0x0600C314 RID: 49940 RVA: 0x001CF194 File Offset: 0x001CD394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C315 RID: 49941 RVA: 0x001CF1A0 File Offset: 0x001CD3A0
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
					if (num != 34U)
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

		// Token: 0x040054AB RID: 21675
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054AC RID: 21676
		public const int ItemPbDataFieldNumber = 4;

		// Token: 0x040054AD RID: 21677
		private KurotatoItemPbData itemPbData_;

		// Token: 0x040054AE RID: 21678
		public const int IsAddFieldNumber = 1;

		// Token: 0x040054AF RID: 21679
		private bool isAdd_;
	}
}
