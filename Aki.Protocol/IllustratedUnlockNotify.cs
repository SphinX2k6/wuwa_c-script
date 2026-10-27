using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CC RID: 1996
	[NetMessage(EMessageId.IllustratedUnlockNotify)]
	public sealed class IllustratedUnlockNotify : IMessage<IllustratedUnlockNotify>, IMessage, IEquatable<IllustratedUnlockNotify>, IDeepCloneable<IllustratedUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600B37C RID: 45948 RVA: 0x001AD85D File Offset: 0x001ABA5D
		[NullableContext(1)]
		public static IllustratedUnlockNotify Create()
		{
			return new IllustratedUnlockNotify();
		}

		// Token: 0x17002438 RID: 9272
		// (get) Token: 0x0600B37D RID: 45949 RVA: 0x001AD864 File Offset: 0x001ABA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002439 RID: 9273
		// (get) Token: 0x0600B37E RID: 45950 RVA: 0x001AD867 File Offset: 0x001ABA67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x001AD86E File Offset: 0x001ABA6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockNotify()
		{
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x001AD878 File Offset: 0x001ABA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockNotify(IllustratedUnlockNotify other) : this()
		{
			this.type_ = other.type_;
			this.entry_ = ((other.entry_ != null) ? other.entry_.Clone() : null);
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x001AD8D0 File Offset: 0x001ABAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockNotify Clone()
		{
			return new IllustratedUnlockNotify(this);
		}

		// Token: 0x1700243A RID: 9274
		// (get) Token: 0x0600B382 RID: 45954 RVA: 0x001AD8D8 File Offset: 0x001ABAD8
		// (set) Token: 0x0600B383 RID: 45955 RVA: 0x001AD8E0 File Offset: 0x001ABAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x1700243B RID: 9275
		// (get) Token: 0x0600B384 RID: 45956 RVA: 0x001AD8E9 File Offset: 0x001ABAE9
		// (set) Token: 0x0600B385 RID: 45957 RVA: 0x001AD8F1 File Offset: 0x001ABAF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry Entry
		{
			get
			{
				return this.entry_;
			}
			set
			{
				this.entry_ = value;
			}
		}

		// Token: 0x1700243C RID: 9276
		// (get) Token: 0x0600B386 RID: 45958 RVA: 0x001AD8FA File Offset: 0x001ABAFA
		// (set) Token: 0x0600B387 RID: 45959 RVA: 0x001AD902 File Offset: 0x001ABB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x0600B388 RID: 45960 RVA: 0x001AD90B File Offset: 0x001ABB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedUnlockNotify);
		}

		// Token: 0x0600B389 RID: 45961 RVA: 0x001AD91C File Offset: 0x001ABB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedUnlockNotify other)
		{
			return other != null && (other == this || (this.Type == other.Type && object.Equals(this.Entry, other.Entry) && this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B38A RID: 45962 RVA: 0x001AD97C File Offset: 0x001ABB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != IllustratedType.Monster)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.entry_ != null)
			{
				num ^= this.Entry.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B38B RID: 45963 RVA: 0x001AD9F0 File Offset: 0x001ABBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B38C RID: 45964 RVA: 0x001AD9FD File Offset: 0x001ABBFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B38D RID: 45965 RVA: 0x001ADA08 File Offset: 0x001ABC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			if (this.Type != IllustratedType.Monster)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Type);
			}
			if (this.entry_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Entry);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B38E RID: 45966 RVA: 0x001ADA80 File Offset: 0x001ABC80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != IllustratedType.Monster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.entry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entry);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B38F RID: 45967 RVA: 0x001ADAE4 File Offset: 0x001ABCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != IllustratedType.Monster)
			{
				this.Type = other.Type;
			}
			if (other.entry_ != null)
			{
				if (this.entry_ == null)
				{
					this.Entry = new IllustratedEntry();
				}
				this.Entry.MergeFrom(other.Entry);
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B390 RID: 45968 RVA: 0x001ADB60 File Offset: 0x001ABD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x001ADB6C File Offset: 0x001ABD6C
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
				if (num != 16U)
				{
					if (num != 40U)
					{
						if (num != 66U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.entry_ == null)
							{
								this.Entry = new IllustratedEntry();
							}
							input.ReadMessage(this.Entry);
						}
					}
					else
					{
						this.Type = (IllustratedType)input.ReadEnum();
					}
				}
				else
				{
					this.IsNew = input.ReadBool();
				}
			}
		}

		// Token: 0x04005010 RID: 20496
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005011 RID: 20497
		public const int TypeFieldNumber = 5;

		// Token: 0x04005012 RID: 20498
		private IllustratedType type_;

		// Token: 0x04005013 RID: 20499
		public const int EntryFieldNumber = 8;

		// Token: 0x04005014 RID: 20500
		private IllustratedEntry entry_;

		// Token: 0x04005015 RID: 20501
		public const int IsNewFieldNumber = 2;

		// Token: 0x04005016 RID: 20502
		private bool isNew_;
	}
}
