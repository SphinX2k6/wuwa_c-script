using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000648 RID: 1608
	[NetMessage(EMessageId.FriendAddedNotify)]
	public sealed class FriendAddedNotify : IMessage<FriendAddedNotify>, IMessage, IEquatable<FriendAddedNotify>, IDeepCloneable<FriendAddedNotify>, IBufferMessage
	{
		// Token: 0x060093FF RID: 37887 RVA: 0x00165DA2 File Offset: 0x00163FA2
		[NullableContext(1)]
		public static FriendAddedNotify Create()
		{
			return new FriendAddedNotify();
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x06009400 RID: 37888 RVA: 0x00165DA9 File Offset: 0x00163FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x06009401 RID: 37889 RVA: 0x00165DAC File Offset: 0x00163FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendAddedNotify.Descriptor;
			}
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x00165DB3 File Offset: 0x00163FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAddedNotify()
		{
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x00165DBB File Offset: 0x00163FBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAddedNotify(FriendAddedNotify other) : this()
		{
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00165DF0 File Offset: 0x00163FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendAddedNotify Clone()
		{
			return new FriendAddedNotify(this);
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x06009405 RID: 37893 RVA: 0x00165DF8 File Offset: 0x00163FF8
		// (set) Token: 0x06009406 RID: 37894 RVA: 0x00165E00 File Offset: 0x00164000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00165E09 File Offset: 0x00164009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendAddedNotify);
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00165E17 File Offset: 0x00164017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendAddedNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x00165E4C File Offset: 0x0016404C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x00165E88 File Offset: 0x00164088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600940B RID: 37899 RVA: 0x00165E95 File Offset: 0x00164095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600940C RID: 37900 RVA: 0x00165E9E File Offset: 0x0016409E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.info_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600940D RID: 37901 RVA: 0x00165ED0 File Offset: 0x001640D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600940E RID: 37902 RVA: 0x00165F10 File Offset: 0x00164110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendAddedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new FriendInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600940F RID: 37903 RVA: 0x00165F64 File Offset: 0x00164164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009410 RID: 37904 RVA: 0x00165F70 File Offset: 0x00164170
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.info_ == null)
					{
						this.Info = new FriendInfo();
					}
					input.ReadMessage(this.Info);
				}
			}
		}

		// Token: 0x0400470C RID: 18188
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400470D RID: 18189
		public const int InfoFieldNumber = 4;

		// Token: 0x0400470E RID: 18190
		private FriendInfo info_;
	}
}
