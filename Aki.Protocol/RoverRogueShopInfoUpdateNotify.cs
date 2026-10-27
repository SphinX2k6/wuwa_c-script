using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001124 RID: 4388
	[NetMessage(EMessageId.RoverRogueShopInfoUpdateNotify)]
	public sealed class RoverRogueShopInfoUpdateNotify : IMessage<RoverRogueShopInfoUpdateNotify>, IMessage, IEquatable<RoverRogueShopInfoUpdateNotify>, IDeepCloneable<RoverRogueShopInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601768E RID: 95886 RVA: 0x003668CA File Offset: 0x00364ACA
		[NullableContext(1)]
		public static RoverRogueShopInfoUpdateNotify Create()
		{
			return new RoverRogueShopInfoUpdateNotify();
		}

		// Token: 0x17004E93 RID: 20115
		// (get) Token: 0x0601768F RID: 95887 RVA: 0x003668D1 File Offset: 0x00364AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E94 RID: 20116
		// (get) Token: 0x06017690 RID: 95888 RVA: 0x003668D4 File Offset: 0x00364AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueShopInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017691 RID: 95889 RVA: 0x003668DB File Offset: 0x00364ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopInfoUpdateNotify()
		{
		}

		// Token: 0x06017692 RID: 95890 RVA: 0x003668E3 File Offset: 0x00364AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopInfoUpdateNotify(RoverRogueShopInfoUpdateNotify other) : this()
		{
			this.snapshot_ = ((other.snapshot_ != null) ? other.snapshot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017693 RID: 95891 RVA: 0x00366918 File Offset: 0x00364B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopInfoUpdateNotify Clone()
		{
			return new RoverRogueShopInfoUpdateNotify(this);
		}

		// Token: 0x17004E95 RID: 20117
		// (get) Token: 0x06017694 RID: 95892 RVA: 0x00366920 File Offset: 0x00364B20
		// (set) Token: 0x06017695 RID: 95893 RVA: 0x00366928 File Offset: 0x00364B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueShopSnapshot Snapshot
		{
			get
			{
				return this.snapshot_;
			}
			set
			{
				this.snapshot_ = value;
			}
		}

		// Token: 0x06017696 RID: 95894 RVA: 0x00366931 File Offset: 0x00364B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueShopInfoUpdateNotify);
		}

		// Token: 0x06017697 RID: 95895 RVA: 0x0036693F File Offset: 0x00364B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueShopInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Snapshot, other.Snapshot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017698 RID: 95896 RVA: 0x00366974 File Offset: 0x00364B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.snapshot_ != null)
			{
				num ^= this.Snapshot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017699 RID: 95897 RVA: 0x003669B0 File Offset: 0x00364BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601769A RID: 95898 RVA: 0x003669BD File Offset: 0x00364BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601769B RID: 95899 RVA: 0x003669C6 File Offset: 0x00364BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.snapshot_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601769C RID: 95900 RVA: 0x003669F8 File Offset: 0x00364BF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.snapshot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Snapshot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601769D RID: 95901 RVA: 0x00366A38 File Offset: 0x00364C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueShopInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.snapshot_ != null)
			{
				if (this.snapshot_ == null)
				{
					this.Snapshot = new RoverRogueShopSnapshot();
				}
				this.Snapshot.MergeFrom(other.Snapshot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601769E RID: 95902 RVA: 0x00366A8C File Offset: 0x00364C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601769F RID: 95903 RVA: 0x00366A98 File Offset: 0x00364C98
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.snapshot_ == null)
					{
						this.Snapshot = new RoverRogueShopSnapshot();
					}
					input.ReadMessage(this.Snapshot);
				}
			}
		}

		// Token: 0x04008B41 RID: 35649
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008B42 RID: 35650
		public const int SnapshotFieldNumber = 3;

		// Token: 0x04008B43 RID: 35651
		private RoverRogueShopSnapshot snapshot_;
	}
}
