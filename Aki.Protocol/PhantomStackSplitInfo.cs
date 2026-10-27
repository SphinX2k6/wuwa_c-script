using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D0B RID: 3339
	public sealed class PhantomStackSplitInfo : IMessage<PhantomStackSplitInfo>, IMessage, IEquatable<PhantomStackSplitInfo>, IDeepCloneable<PhantomStackSplitInfo>, IBufferMessage
	{
		// Token: 0x060120B1 RID: 73905 RVA: 0x002A3172 File Offset: 0x002A1372
		[NullableContext(1)]
		public static PhantomStackSplitInfo Create()
		{
			return new PhantomStackSplitInfo();
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x060120B2 RID: 73906 RVA: 0x002A3179 File Offset: 0x002A1379
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomStackSplitInfo> Parser
		{
			get
			{
				return PhantomStackSplitInfo._parser;
			}
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x060120B3 RID: 73907 RVA: 0x002A3180 File Offset: 0x002A1380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003BCA RID: 15306
		// (get) Token: 0x060120B4 RID: 73908 RVA: 0x002A3183 File Offset: 0x002A1383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomStackSplitInfo.Descriptor;
			}
		}

		// Token: 0x060120B5 RID: 73909 RVA: 0x002A318A File Offset: 0x002A138A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo()
		{
		}

		// Token: 0x060120B6 RID: 73910 RVA: 0x002A3194 File Offset: 0x002A1394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo(PhantomStackSplitInfo other) : this()
		{
			this.operateItem_ = ((other.operateItem_ != null) ? other.operateItem_.Clone() : null);
			this.operateBeforeCount_ = other.operateBeforeCount_;
			this.remainderItem_ = ((other.remainderItem_ != null) ? other.remainderItem_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060120B7 RID: 73911 RVA: 0x002A31FC File Offset: 0x002A13FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomStackSplitInfo Clone()
		{
			return new PhantomStackSplitInfo(this);
		}

		// Token: 0x17003BCB RID: 15307
		// (get) Token: 0x060120B8 RID: 73912 RVA: 0x002A3204 File Offset: 0x002A1404
		// (set) Token: 0x060120B9 RID: 73913 RVA: 0x002A320C File Offset: 0x002A140C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem OperateItem
		{
			get
			{
				return this.operateItem_;
			}
			set
			{
				this.operateItem_ = value;
			}
		}

		// Token: 0x17003BCC RID: 15308
		// (get) Token: 0x060120BA RID: 73914 RVA: 0x002A3215 File Offset: 0x002A1415
		// (set) Token: 0x060120BB RID: 73915 RVA: 0x002A321D File Offset: 0x002A141D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int OperateBeforeCount
		{
			get
			{
				return this.operateBeforeCount_;
			}
			set
			{
				this.operateBeforeCount_ = value;
			}
		}

		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x060120BC RID: 73916 RVA: 0x002A3226 File Offset: 0x002A1426
		// (set) Token: 0x060120BD RID: 73917 RVA: 0x002A322E File Offset: 0x002A142E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomItem RemainderItem
		{
			get
			{
				return this.remainderItem_;
			}
			set
			{
				this.remainderItem_ = value;
			}
		}

		// Token: 0x060120BE RID: 73918 RVA: 0x002A3237 File Offset: 0x002A1437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomStackSplitInfo);
		}

		// Token: 0x060120BF RID: 73919 RVA: 0x002A3248 File Offset: 0x002A1448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomStackSplitInfo other)
		{
			return other != null && (other == this || (object.Equals(this.OperateItem, other.OperateItem) && this.OperateBeforeCount == other.OperateBeforeCount && object.Equals(this.RemainderItem, other.RemainderItem) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060120C0 RID: 73920 RVA: 0x002A32AC File Offset: 0x002A14AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.operateItem_ != null)
			{
				num ^= this.OperateItem.GetHashCode();
			}
			if (this.OperateBeforeCount != 0)
			{
				num ^= this.OperateBeforeCount.GetHashCode();
			}
			if (this.remainderItem_ != null)
			{
				num ^= this.RemainderItem.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060120C1 RID: 73921 RVA: 0x002A3317 File Offset: 0x002A1517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060120C2 RID: 73922 RVA: 0x002A3324 File Offset: 0x002A1524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060120C3 RID: 73923 RVA: 0x002A3330 File Offset: 0x002A1530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.operateItem_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.OperateItem);
			}
			if (this.OperateBeforeCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.OperateBeforeCount);
			}
			if (this.remainderItem_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RemainderItem);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060120C4 RID: 73924 RVA: 0x002A33A8 File Offset: 0x002A15A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.operateItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OperateItem);
			}
			if (this.OperateBeforeCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.OperateBeforeCount);
			}
			if (this.remainderItem_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RemainderItem);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060120C5 RID: 73925 RVA: 0x002A3418 File Offset: 0x002A1618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomStackSplitInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.operateItem_ != null)
			{
				if (this.operateItem_ == null)
				{
					this.OperateItem = new PhantomItem();
				}
				this.OperateItem.MergeFrom(other.OperateItem);
			}
			if (other.OperateBeforeCount != 0)
			{
				this.OperateBeforeCount = other.OperateBeforeCount;
			}
			if (other.remainderItem_ != null)
			{
				if (this.remainderItem_ == null)
				{
					this.RemainderItem = new PhantomItem();
				}
				this.RemainderItem.MergeFrom(other.RemainderItem);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060120C6 RID: 73926 RVA: 0x002A34AC File Offset: 0x002A16AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060120C7 RID: 73927 RVA: 0x002A34B8 File Offset: 0x002A16B8
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
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.remainderItem_ == null)
							{
								this.RemainderItem = new PhantomItem();
							}
							input.ReadMessage(this.RemainderItem);
						}
					}
					else
					{
						this.OperateBeforeCount = input.ReadInt32();
					}
				}
				else
				{
					if (this.operateItem_ == null)
					{
						this.OperateItem = new PhantomItem();
					}
					input.ReadMessage(this.OperateItem);
				}
			}
		}

		// Token: 0x040070F2 RID: 28914
		private static readonly MessageParser<PhantomStackSplitInfo> _parser = new MessageParser<PhantomStackSplitInfo>(() => new PhantomStackSplitInfo());

		// Token: 0x040070F3 RID: 28915
		private UnknownFieldSet _unknownFields;

		// Token: 0x040070F4 RID: 28916
		public const int OperateItemFieldNumber = 1;

		// Token: 0x040070F5 RID: 28917
		private PhantomItem operateItem_;

		// Token: 0x040070F6 RID: 28918
		public const int OperateBeforeCountFieldNumber = 2;

		// Token: 0x040070F7 RID: 28919
		private int operateBeforeCount_;

		// Token: 0x040070F8 RID: 28920
		public const int RemainderItemFieldNumber = 3;

		// Token: 0x040070F9 RID: 28921
		private PhantomItem remainderItem_;
	}
}
